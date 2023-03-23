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

        private void startButton_click(object _o, EventArgs _e)
        {
            this.Controls.Remove(this.startButton);

            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.option1);
            this.Controls.Add(this.option2);
        }

        private void option1_click(object _o, EventArgs _e)
        {

        }

        private void option2_click(object _o, EventArgs _e)
        {

        }

        private void option3_click(object _o, EventArgs _e)
        {

        }
    }
}
