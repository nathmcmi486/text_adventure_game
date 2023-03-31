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
        static int PAGE = -1;
        // One of your friends feel insulted by something you did/said
        bool insult = false;

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
                case 0:
                    this.Controls.Remove(this.outputLabel);
                    this.Controls.Remove(this.option1);
                    this.Controls.Remove(this.option2);
                    this.Controls.Remove(this.inputLabel);
                    this.Controls.Add(this.startButton);
                    break;
                case 1:
                    this.outputLabel.Text = ">> Your friends asked if you wanted to hang out. Do you want to go?";
                    PAGE = 2;
                    break;
                case 2:
                    this.option1.Text = "Go to the park";
                    this.option2.Text = "Get something to eat";
                    this.outputLabel.Text = "Your friends ask what you want to do.";
                    PAGE = 3;
                    break;
                case 3:
                    this.option1.Text = "Say \"That sounds ridiculous\"";
                    this.option2.Text = "Laugh and start running";

                    this.Controls.Add(this.option3);
                    this.option3.Text = "Ignore it";

                    this.outputLabel.Text = ">> You and your friends start  walking to the park together. In your town there is a very large hill that divides the town. There are roads built over it but there has always been one short tunnel connecting the two sides. This tunnel is closer to your house than the roads but you've never actually thought about going through it. Your friends suggest walking through thee tunnel so it could be faster, and \"it's something different\"\n";

                    sleep_refresh(1250);

                    this.outputLabel.Text += "After walking in the tunnel for a few minutes, one of your friends complains about how long the walk is taking. A few minutes later, you feel like it has taken an absurd amount of time to cross the tunnel -it's only less than 100m \"It feels like we're not  even moving\" one of your friends says";

                    sleep_refresh(250);

                    PAGE = 4;

                    break;
                case 4:
                    this.option1.Text = "Yes";
                    this.option2.Text = "No";

                    insult = true;

                    this.outputLabel.Text = ">> Your friend turns around and says in shock: \"We\'re still at the start! We really haven\'t moved at all!\"\n";
                    this.Controls.Remove(this.option3);

                    sleep_refresh(750);


                    this.outputLabel.Text += "Your friends seem incredibly confused and terrified. They start running out of the tunnel, do you follow them?";

                    PAGE = 5;

                    break;
                case 5:
                    this.option1.Text = "Yes";
                    this.option2.Text = "No";

                    this.outputLabel.Text = ">> You follow your friends out of the tunnel and see a group of people in the distance walking towards the tunnel. \"Don't go!\" one of your friends yells.\n";

                    sleep_refresh(1000);

                    this.outputLabel.Text += "\"What ?\" you hear in the distance\n";

                    sleep_refresh(750);

                    this.outputLabel.Text += "\"I feel really weird\" your friend says, \"I don't feel ok.\". The group of people are still walking to the tunnel. Do you and your friends try to stop them?";

                    PAGE = 6;
                    break;
                case 6:
                    this.option1.Text = "Yes";
                    this.option2.Text = "No";

                    this.outputLabel.Text = ">> As you start getting closer you think the people walking to the tunnel look exactly like you and your friends. You consider that after something absurd just happened and now you're seeing a group of who look exactly like you, you think you time traveled. Do you say something?";

                    PAGE = 7;
                    break;
                case 7:
                    this.option1.Text = "Yes";
                    this.option2.Text = "No";

                    this.outputLabel.Text = ">> \"I know this sounds very strange, but I think we've time traveled. If this is true we really shouldn't go near them, we've probably already interacted with them too much.\" Because you doubted one of your friends, the rest of the group ignores you. Do you keep following them ?";

                    PAGE = 8;

                    break;
                case 8:
                    this.outputLabel.Text = ">> You follow them for a few more a few more minutes then \"normally\" walk away and hide in a bush.";

                    sleep_refresh(1100);

                    this.outputLabel.Text += "You watch your friends from the present approach you and your friends from the past. There is a bright flash of light around them, when you look over again they're all gone except your past self.";

                    sleep_refresh(5000);

                    this.outputLabel.Text = "You don't think about why you're still ok, you assume you have to try to get yourself to get to where you are now.";

                    sleep_refresh(1100);

                    this.outputLabel.Text += " You jump out of the bush, \"Go into that tunnel and come out the same way immediately!\" You scream to yourself. Your past self looks at you in confusion. \"Now!\" you yell. Your past self runs into the tunnel, you look into the tunnel and see that there's nothing in there.";

                    sleep_refresh(1200);

                    this.outputLabel.Text += "\nYou start hyperventilating and pass out.";

                    sleep_refresh(100);
                    break;
                case 101:
                    this.outputLabel.Text = ">> You fall asleep and did nothing for the rest of the day";

                    this.outputLabel.Text += "Would you like to play again?";

                    PAGE = 0;
                    break;
                case 102:
                    this.outputLabel.Text = "You died a horrible, painful, unexplainable, death";

                    this.outputLabel.Text += "Would you like to play again?";

                    PAGE = 0;
                    break;
                case 103:
                    

                default:
                    break;
            }
        }

        private void option2_click(object _o, EventArgs _e)
        {
            this.inputLabel.Text = $"<< {this.option2.Text}";

            sleep_refresh(600);

            this.inputLabel.Text = "";

            switch (PAGE)
            {
                case 0:
                    this.Controls.Remove(this.outputLabel);
                    this.Controls.Remove(this.option1);
                    this.Controls.Remove(this.option2);
                    this.Controls.Remove(this.inputLabel);
                    this.Controls.Add(this.startButton);
                    break;
                case 1:
                    PAGE = 101;

                    option2_click(_o, _e);
                    break;
                case 2:
                    PAGE = 101;

                    option2_click(_o, _e);
                    break;
                case 3:
                    this.outputLabel.Text = ">> You went to a fast food restaurant and then went home after.";
                    this.option1.Text = "Next";
                    this.Controls.Remove(this.option2);

                    PAGE = 103;

                    option2_click(_o, _e);
                    break;
                case 4:
                    this.outputLabel.Text = ">> As you start running there are sparks of light throughout the whole tunnel, all of a sudden you and your friends start floating";

                    PAGE = 102;

                    option2_click(_o, _e);
                    break;
                case 5:
                    this.outputLabel.Text = ">> You stay and watch your friends leave. As they start running there are sparks of light throughout the whole tunnel, all of a sudden you and your friends start floating";

                    PAGE = 102;

                    option2_click(_o, _e);
                    break;
                case 6:
                    this.outputLabel.Text = ">> You and your friends decide to go home and agreed to never mention what just happened";

                    PAGE = 103;

                    option2_click(_o, _e);

                    break;
                case 7:
                    this.outputLabel.Text = ">> You and your friends continue to walk to the group\n";

                    sleep_refresh(750);

                    if (insult)
                    {
                        this.outputLabel.Text += "Your friend who first pointed out that they weren't moving gets very frustrated about this situation and seem very mad at you. They start running to your past self, you think interacting with your past self is very bad and try to stop them. As you get closer you start seeing flashing lights everywhere";
                    } else
                    {
                        this.outputLabel.Text += "As you get closer you think something bad could happen from stop yourselves. You start seeing flashing lights as you get closer.";
                    }

                    PAGE = 102;

                    sleep_refresh(500);


                    option2_click(_o, _e);
                    break;
                case 8:
                    PAGE = 7;
                    option2_click(_o, _e);
                    break;
                case 101:
                    this.outputLabel.Text = "You fall asleep and did nothing for the rest of the day";

                    option2_click(_o, _e);
                    break;
                case 102:
                    this.outputLabel.Text = "You died a horrible, painful, unexplainable, death";

                    this.outputLabel.Text += "Would you like to play again?";

                    PAGE = 0;
                    break;
                default:
                    break;
            }
        }

        private void option3_click(object _o, EventArgs _e)
        {
            switch (PAGE)
            {
                case 4:
                    Random rnd = new Random();
                    int rnd_int = rnd.Next(0, 101);

                    if (rnd_int > 10)
                    {
                        insult = true;
                    }

                    this.outputLabel.Text = "Your friend turns around and says in shock: \"We're still at the start! We really haven't moved at all!\"";
                    break;
                case 101:
                    this.outputLabel.Text = "You fall asleep and did nothing for the rest of the day";
                    break;
                default:
                    break;
            }
        }
    }
}
