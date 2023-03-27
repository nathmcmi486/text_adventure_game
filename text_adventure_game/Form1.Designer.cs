namespace text_adventure_game
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.outputLabel = new System.Windows.Forms.Label();
            this.inputLabel = new System.Windows.Forms.Label();

            this.startButton = new System.Windows.Forms.Button();
            this.option1 = new System.Windows.Forms.Button();
            this.option2 = new System.Windows.Forms.Button();
            this.option3 = new System.Windows.Forms.Button();

            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(600, 100);
            this.outputLabel.Text = "";
            this.outputLabel.TabIndex = 0;
            this.outputLabel.Location = new System.Drawing.Point(60, 30);
            this.outputLabel.ForeColor = System.Drawing.Color.LightGreen;

            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(100, 60);
            this.inputLabel.Text = "";
            this.inputLabel.TabIndex = 0;
            this.inputLabel.Location = new System.Drawing.Point(60, 180);
            this.inputLabel.ForeColor = System.Drawing.Color.LightGreen;

            this.startButton.Location = new System.Drawing.Point(40, 30);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(100, 40);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Start";
            this.startButton.ForeColor = System.Drawing.Color.LightGreen;
            this.startButton.Click += new System.EventHandler(this.startButton_click);

            this.option1.Location = new System.Drawing.Point(350, 40);
            this.option1.Name = "option1";
            this.option1.Size = new System.Drawing.Size(100, 40);
            this.option1.TabIndex = 2;
            this.option1.Text = "";
            this.option1.ForeColor = System.Drawing.Color.LightGreen;
            this.option1.Click += new System.EventHandler(this.option1_click);

            this.option2.Location = new System.Drawing.Point(460, 40);
            this.option2.Name = "option2";
            this.option2.Size = new System.Drawing.Size(100, 40);
            this.option2.TabIndex = 2;
            this.option2.Text = "";
            this.option2.ForeColor = System.Drawing.Color.LightGreen;
            this.option2.Click += new System.EventHandler(this.option2_click);

            this.option3.Location = new System.Drawing.Point(570, 40);
            this.option3.Name = "option3";
            this.option3.Size = new System.Drawing.Size(100, 40);
            this.option3.TabIndex = 2;
            this.option3.Text = "";
            this.option3.ForeColor = System.Drawing.Color.LightGreen;
            this.option3.Click += new System.EventHandler(this.option3_click);

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Text adventure";
            this.BackColor = System.Drawing.Color.FromArgb(255, 30, 30, 30);

            this.Controls.Add(this.startButton);
        }

        #endregion

        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label inputLabel;

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button option1;
        private System.Windows.Forms.Button option2;
        private System.Windows.Forms.Button option3;
    }
}

