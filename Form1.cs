using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace random_game
{
    public partial class Form1 : Form
    {
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            resultLabel.Text = "";
        }

        private void random_button_Click(object sender, EventArgs e)
        {
            int lineCount = richTextBox.Lines.Count();
            if (lineCount > 0)
            {
                if (richTextBox.Lines[lineCount - 1] == "")
                {
                    lineCount--;
                }
                int randomLine = random.Next(0, lineCount);
                String value = richTextBox.Lines[randomLine];
                resultLabel.Text = value;
            }
        }

        private void resultLabel_Click(object sender, EventArgs e)
        {
            resultLabel.Text = "";
        }
    }
}
