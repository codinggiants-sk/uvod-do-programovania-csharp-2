using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    public class MemoryCard : Label
    {
        public Guid Id;
        public Image Back;
        public Image Image;

        public MemoryCard(Guid id, string backPath, string imagePath)
        {
            Id = id;
            Back = Image.FromFile(backPath);
            Image = Image.FromFile(imagePath);
            BackgroundImageLayout = ImageLayout.Stretch;
        }

        //method that hide image (set logo instead) and switch off the card
        public void Hide()
        {
            BackgroundImage = Back;
            Enabled = true;
        }

        //method that show the image and switch on the card
        public void Show()
        {
            BackgroundImage = Image;
            Enabled = false;
        }
    }
}
