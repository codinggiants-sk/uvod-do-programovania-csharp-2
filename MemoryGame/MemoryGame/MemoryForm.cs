using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class MemoryForm : Form
    {
        // game settings object
        private GameSettings _settings;

        //helper variables for uncovered cards
        MemoryCard _first = null;
        MemoryCard _second = null;

        public MemoryForm()
        {
            InitializeComponent();
            //create game settings object
            _settings = new GameSettings();
            //call method that will set controls
            SetControls();
            //call method that create cards
            GenerateCards();
            //start first timer, which count down time to start of the game
            timerDisplayTime.Start();
        }

        //method that set initial form settings
        //it will be called during first run of the game
        //and when game will be restarted
        private void SetControls()
        {
            //calculate how many space is required for all cards
            //based on parameters stored in GameSettings object
            //thanks to that, you don't have to do it manually in Designer
            //calculate width and hight for panel with cards
            panelCards.Width = _settings.Side * _settings.Rows;
            panelCards.Height = _settings.Side * _settings.Cols;
            //panel is inside the form, so it has to be resized too
            //add few more pixels as a margin
            Width = panelCards.Width + 40;
            Height = panelCards.Height + 100;

            //set text in labels
            lblStartInfo.Text = $"Game begins in {_settings.DisplayTime}.";
            lblPointsValue.Text = _settings.CurrentPoints.ToString();
            lblTimeValue.Text = _settings.GameTime.ToString();
            //set visibility of label that count down
            //when game starts, it will be hidden
            lblStartInfo.Visible = true;
        }

        private void GenerateCards()
        {
            //get paths to files with images
            string[] memories = Directory.GetFiles(_settings.ImagesFolder);

            //set max amount of points player can get
            //this value is equals to number of images
            _settings.MaxPoints = memories.Length;

            //create list that store game cards
            var buttons = new List<MemoryCard>();

            //for each image create two cards
            foreach(string img in memories)
            {
                //create unique id for card
                Guid id = Guid.NewGuid();

                //create first card
                var b1 = new MemoryCard(id, _settings.LogoFile, img);
                //and add it to the list
                buttons.Add(b1);

                //create second card
                var b2 = new MemoryCard(id, _settings.LogoFile, img);
                buttons.Add(b2);
            }

            //now pseudo random number generator will be used
            //for placing cards on the panel randomly
            Random random = new Random();

            //clear panel from all cards
            //some cards can be inside because this method is used
            //when game is being restarted
            panelCards.Controls.Clear();

            //loop through all rows
            for (int x = 0; x < _settings.Rows; x++)
            {
                //in each row loop through each column
                //in this way 2D grid will be created with placed cards
                for(int y = 0; y < _settings.Cols; y++)
                {
                    //draw index of the next card in range from 0
                    //to amount of cards to place
                    var index = random.Next(0, buttons.Count);

                    //get card at given index from the list
                    var b = buttons[index];

                    //add variable for small margin - space between cards
                    int margin = 2;

                    //calculate x and y position to place a card on the panel
                    //x is calculated by multiplying current row by side length
                    //add margin at left and right side
                    //y is calculated by multiplying current column by side length
                    //add margin at the top and bottom
                    b.Location = new Point((x*_settings.Side) + (margin*x), (y*_settings.Side) + (margin*y));

                    //set card size
                    b.Width = _settings.Side;
                    b.Height = _settings.Side;

                    //this line assign BtnClicked method to onClick event
                    //it is the same as choosing method in the Designer
                    b.Click += BtnClicked;

                    //card is vivible when game starts
                    b.Show();

                    //add prepared card to the panel
                    panelCards.Controls.Add(b);

                    //at the end delete card, which cannot be added one more time, from the list
                    buttons.Remove(b);
                }
            }
        }

        //method for timer DispalyTime - is called every second
        //this method reduces remaining time of displaying cards
        //and when time is up, hides all cards and starts a game
        private void timerDisplayTime_Tick(object sender, EventArgs e)
        {
            //decrement displaying time
            _settings.DisplayTime--;

            //update label that shows time to start of the game
            lblStartInfo.Text = $"Game begins in {_settings.DisplayTime}.";

            //check if time is up
            if(_settings.DisplayTime <= 0)
            {
                //if so, hide label that shows time to start of the game
                lblStartInfo.Visible = false;

                //loop through all controls in panel
                //inside panel are only game cards
                foreach(var control in panelCards.Controls)
                {
                    //variable Controls stores all controls in the panel
                    //so each control is of Control type
                    //casting has to be used to change type from Control to MemoryCard
                    //it is possible, becouse our control inherits from Label type
                    //which inherits from Control type
                    MemoryCard card = (MemoryCard)control;
                    card.Hide();
                }
                //stop DisplayTime timer - it ended its job
                timerDisplayTime.Stop();
                //instead start GameTime timer
                timerGameTime.Start();
            }
        }

        //method is called when player clicks card
        //method will check if chosen cards are the same
        //and manages cards hiding or points adding
        private void BtnClicked(object sender, EventArgs e)
        {
            //sender is the control that fire an event
            //method is applied only for game cards
            //so is it possible to cast type to MemoryCard safely
            MemoryCard btn = (MemoryCard)sender;

            //first, check if first card has been chosen yet
            //i.e. if card has been assigned to first variable
            if(_first == null)
            {
                //if not, that means that clicked card is first
                //assign card to helper variable
                _first = btn;
                _first.Show();
            } else
            {
                //if first card is set,
                //that means taht player clicked second card
                //assign card to helper variable
                _second = btn;
                _second.Show();

                //turn off possibility to click on the panel for a while
                panelCards.Enabled = false;

                //check if cards have the same picture
                //i.e. if theid ids are the same
                if(_first.Id == _second.Id)
                {
                    //if so, player guessed, increment amount of points
                    _settings.CurrentPoints++;

                    //update label that shows points
                    lblPointsValue.Text = _settings.CurrentPoints.ToString();

                    //clear helper variables
                    _first = null;
                    _second = null;

                    //unlock possibility to click on the panel
                    panelCards.Enabled = true;
                } else
                {
                    //otherwise, player did not guessed
                    //starts hider timer which will hide both cards after few seconds
                    timerHider.Start();
                }
            }
        }

        //method for Hider timer, which hide two unguessed cards
        //using timer gives player chance to see, what cards they clicked
        private void timerHider_Tick(object sender, EventArgs e)
        {
            //hide both cards
            _first.Hide();
            _second.Hide();

            //clear helper variables
            _first = null;
            _second = null;

            //activate panel with cards, so player can click again
            panelCards.Enabled = true;

            //stop Hider timer
            //this timer is called only once
            timerHider.Stop();
        }

        //method for GameTime timer, which is called every second
        //method check if game should be ended
        private void timerGameTime_Tick(object sender, EventArgs e)
        {
            //decreace remaining game time
            _settings.GameTime--;

            //update label that shows this time
            lblTimeValue.Text = _settings.GameTime.ToString();

            //check if one of two end game conditions is met
            // - time is up
            // - player guessed all cards
            if(_settings.GameTime <= 0 || _settings.CurrentPoints == _settings.MaxPoints)
            {
                //if at least one of the condistions is met
                //stop timers Hider and GameTime
                timerGameTime.Stop();
                timerHider.Stop();

                //show MessageBox with the result and question
                //if player wants to play again
                //what button was clicked by player is stored in variable
                var yesNo = MessageBox.Show($"Scored points: {_settings.CurrentPoints}. Do you want to play again?", "Game Over", MessageBoxButtons.YesNo);
                //check if player clicked "Yes"
                if(yesNo == DialogResult.Yes)
                {
                    //to restart the game the same methods
                    //as in constructor have to be called
                    //in addition, game settings has to be reseted too
                    _settings.InitialSettings();
                    GenerateCards();
                    SetControls();

                    //again start DispalyTime timer
                    timerDisplayTime.Start();
                } else
                {
                    //if player chosen "No", close the application
                    Application.Exit();
                }
            }
        }
    }
}
