using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sifravimas1Uzd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private static int Mod(int a, int b)
        {
            return (a % b + b) % b;  //Handle negative results and range between alphabet
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool encipher = true;
            if(!String.IsNullOrEmpty(CypherBox.Text) && !String.IsNullOrEmpty(KeyBox.Text)){
                string output = string.Empty;
                int nonAlphaCharCount = 0;
                for(int i = 0; i < CypherBox.Text.Length; ++i)
                {
                    if (char.IsLetter(CypherBox.Text[i]))
                    {
                        bool cIsUpper = char.IsUpper(CypherBox.Text[i]);
                        char offset = cIsUpper ? 'A' : 'a'; //location in alphabet

                        int keyIndex = (i - nonAlphaCharCount) % KeyBox.Text.Length; //current index of character in the input string minus the number of non-alpha characters by the lenght of the key string
                        int k = (cIsUpper ? char.ToUpper(KeyBox.Text[keyIndex]) : char.ToLower(KeyBox.Text[keyIndex])) - offset; //substract offset from ascii value of the character and convert to int
                        k = encipher ? k : -k; //Encryption or decryption
                        char ch = (char)((Mod(((CypherBox.Text[i] + k) - offset), 26)) + offset); //Check if remains within alphabet, convert back to char

                        output += ch; //add to string
                    }
                    else
                    {
                        output += CypherBox.Text[i];
                        ++nonAlphaCharCount;
                    }
                }
                cypherAnswer.Text = output;

            }
            
            
        }

        private void CypherBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool encipher = false;
            if (!String.IsNullOrEmpty(DecypherBox.Text) && !String.IsNullOrEmpty(KeyBox.Text))
            {
                string output = string.Empty;
                int nonAlphaCharCount = 0;
                for (int i = 0; i < DecypherBox.Text.Length; ++i)
                {
                    if (char.IsLetter(DecypherBox.Text[i]))
                    {
                        bool cIsUpper = char.IsUpper(DecypherBox.Text[i]);
                        char offset = cIsUpper ? 'A' : 'a';

                        int keyIndex = (i - nonAlphaCharCount) % KeyBox.Text.Length;
                        int k = (cIsUpper ? char.ToUpper(KeyBox.Text[keyIndex]) : char.ToLower(KeyBox.Text[keyIndex])) - offset;

                        k = encipher ? k : -k;
                        char ch = (char)((Mod(((DecypherBox.Text[i] + k) - offset), 26)) + offset);

                        output += ch;

                    }
                    else
                    {
                        output += DecypherBox.Text[i];
                        ++nonAlphaCharCount;
                    }
                }
                decypherAnswer.Text = output;

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cypherAnswer_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
