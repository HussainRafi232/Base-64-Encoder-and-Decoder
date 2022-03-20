using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Base64
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            copyAlert.Text = "";
        }

        public void encode()
        {
            string text = Convert.ToBase64String(Encoding.UTF8.GetBytes(Enter.Text));
            Result.Text = text;
        }


        public void decode()
        {
            string text = Encoding.UTF8.GetString(Convert.FromBase64String(Enter.Text));
            Result.Text = text;
            
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            if (Enter.Text == "")
            {
                copyAlert.Text = "Error: Text field is null";
                copyAlert.ForeColor = Color.Red;
                timer1.Start();
            }
            else
            {
                if (encodeRadioButton.Checked == true)
                {
                    encode();
                }
                else
                {
                    decode();
                }
                if (autocopyCheckBox.Checked == true)
                {
                    copyMethod();
                }
                else if (autocopyCheckBox.Checked == false)
                {
                    // Nothing happens
                }
                else
                {
                    // Nothing happens
                }
            }
           
        }

        public void clearText()
        {
            Enter.Text = "";
            Result.Text = "";
            copyAlert.Text = "";
        }

        private void encodeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            clearText();
        }

        private void decodeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            clearText();
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            copyMethod();
        }

        public void copyMethod() // A method for copying the encoded/decoded text to clipboard
        {
            if (Result.Text == "") // If the Result text field is null than it won't copy it and give an error message 
            {
                copyAlert.Text = "Error: Text field is null";
                copyAlert.ForeColor = Color.Red;
            }
            else // If the Result text field is not null and has contents than it will copy the contents of it to clipboard
            {
                Clipboard.SetText(Result.Text); // Copies the encoded/decoded text to clipboard
                copyAlert.Text = "Copied to clipboard successfully";
                copyAlert.ForeColor = Color.Green; // Changes the alert label's color to green
            }
            timer1.Start();
            timer2.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            copyAlert.Text = ""; // Clears the alert label
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            clearText(); // Clears the enter and result textfields 
        }

     
    }
}
