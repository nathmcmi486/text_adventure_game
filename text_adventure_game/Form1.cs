using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace text_adventure_game
{
    public partial class Form1 : Form
    {
        static int PAGE = 0;
        public Form1()
        {
            InitializeComponent();
        }

        // Refreshes the display and waits for ``time``.
        private void sleep_refresh(int time)
        {
            this.Refresh();
            System.Threading.Thread.Sleep(time);
        }

        private void startButton_click(object _o, EventArgs _e)
        {
            this.Controls.Remove(this.startButton);

            sleep_refresh(1000);

            PAGE = 1;

            // "page 1"
            this.outputLabel.Text = ">> It's the middle of the afternoon and you're watching tv. You get a notification on your phone. Do you check it?";
            this.option1.Text = "Yes";
            this.option2.Text = "No";

            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.option1);
            this.Controls.Add(this.option2);
        }

        private void option1_click(object _o, EventArgs _e)
        {
            this.inputLabel.Text = $"<< {this.option1.Text}";

            sleep_refresh(600);

            this.inputLabel.Text = "";

            sleep_refresh(400);

            switch (PAGE)
            {
                case 1:
                    this.outputLabel.Text = "Your friends asked if you wanted to hang out. Do you want to go?";
                    PAGE = 2;
                    break;
                case 2:
                    this.outputLabel.Text = "Your friends ask what you want to do.";
                    this.option1.Text = "Go to the park";
                    this.option2.Text = "Get something to eat";
                    PAGE = 3;
                    break;
                case 3:
                    this.outputLabel.Text = "You and your friends start  walking to the park together. In your town there is a very large hill that divides the town. There are roads built over it but there has always been one short tunnel connecting the two sides. This tunnel is closer to your house than the roads but you've never actually thought about going through it. Your friends suggest walking through thee tunnel so it could be faster, and \"it's something different\"";

                    sleep_refresh(750);

                    this.outputLabel.Text += "";

                    break;
                case 101:
                    this.outputLabel.Text = "You fall asleep and did nothing for the rest of the day";
                    break;
                default:
                    break;
            }
        }

        private void option2_click(object _o, EventArgs _e)
        {
            switch (PAGE)
            {
                case 101:
                    this.outputLabel.Text = "You fall asleep and did nothing for the rest of the day";
                    break;
                default:
                    break;
            }
        }

        private void option3_click(object _o, EventArgs _e)
        {
            switch (PAGE)
            {
                case 101:
                    this.outputLabel.Text = "You fall asleep and did nothing for the rest of the day";
                    break;
                default:
                    break;
            }
        }
    }
}
