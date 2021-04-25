
namespace MemoryGame
{
    partial class MemoryForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblTimeValue = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.lblPointsValue = new System.Windows.Forms.Label();
            this.lblStartInfo = new System.Windows.Forms.Label();
            this.panelCards = new System.Windows.Forms.Panel();
            this.timerHider = new System.Windows.Forms.Timer(this.components);
            this.timerGameTime = new System.Windows.Forms.Timer(this.components);
            this.timerDisplayTime = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTime.ForeColor = System.Drawing.Color.Black;
            this.lblTime.Location = new System.Drawing.Point(13, 13);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(47, 20);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "Time:";
            // 
            // lblTimeValue
            // 
            this.lblTimeValue.AutoSize = true;
            this.lblTimeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTimeValue.ForeColor = System.Drawing.Color.Black;
            this.lblTimeValue.Location = new System.Drawing.Point(66, 13);
            this.lblTimeValue.Name = "lblTimeValue";
            this.lblTimeValue.Size = new System.Drawing.Size(29, 20);
            this.lblTimeValue.TabIndex = 1;
            this.lblTimeValue.Text = "60";
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPoints.ForeColor = System.Drawing.Color.Black;
            this.lblPoints.Location = new System.Drawing.Point(129, 13);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(57, 20);
            this.lblPoints.TabIndex = 2;
            this.lblPoints.Text = "Points:";
            // 
            // lblPointsValue
            // 
            this.lblPointsValue.AutoSize = true;
            this.lblPointsValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPointsValue.ForeColor = System.Drawing.Color.Black;
            this.lblPointsValue.Location = new System.Drawing.Point(183, 13);
            this.lblPointsValue.Name = "lblPointsValue";
            this.lblPointsValue.Size = new System.Drawing.Size(19, 20);
            this.lblPointsValue.TabIndex = 3;
            this.lblPointsValue.Text = "0";
            // 
            // lblStartInfo
            // 
            this.lblStartInfo.AutoSize = true;
            this.lblStartInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStartInfo.Location = new System.Drawing.Point(309, 13);
            this.lblStartInfo.Name = "lblStartInfo";
            this.lblStartInfo.Size = new System.Drawing.Size(137, 20);
            this.lblStartInfo.TabIndex = 4;
            this.lblStartInfo.Text = "Game begins in 5.";
            // 
            // panelCards
            // 
            this.panelCards.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCards.Location = new System.Drawing.Point(6, 40);
            this.panelCards.Name = "panelCards";
            this.panelCards.Size = new System.Drawing.Size(579, 20);
            this.panelCards.TabIndex = 5;
            // 
            // timerHider
            // 
            this.timerHider.Interval = 1000;
            this.timerHider.Tick += new System.EventHandler(this.timerHider_Tick);
            // 
            // timerGameTime
            // 
            this.timerGameTime.Interval = 1000;
            this.timerGameTime.Tick += new System.EventHandler(this.timerGameTime_Tick);
            // 
            // timerDisplayTime
            // 
            this.timerDisplayTime.Interval = 1000;
            this.timerDisplayTime.Tick += new System.EventHandler(this.timerDisplayTime_Tick);
            // 
            // MemoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(588, 72);
            this.Controls.Add(this.panelCards);
            this.Controls.Add(this.lblStartInfo);
            this.Controls.Add(this.lblPointsValue);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.lblTimeValue);
            this.Controls.Add(this.lblTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MemoryForm";
            this.Text = "Memory Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblTimeValue;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Label lblPointsValue;
        private System.Windows.Forms.Label lblStartInfo;
        private System.Windows.Forms.Panel panelCards;
        private System.Windows.Forms.Timer timerHider;
        private System.Windows.Forms.Timer timerGameTime;
        private System.Windows.Forms.Timer timerDisplayTime;
    }
}

