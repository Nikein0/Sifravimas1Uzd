using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Sifravimas1Uzd
{
    public partial class Form1 : Form
    {
        int choice;
        string encryptedmessg;

        public void setEncryptedMessg(string messg) { encryptedmessg = messg; }
        public string getEncryptedMessg() { return encryptedmessg; }

        public Form1()
        {
            InitializeComponent();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(CypherBox.Text) && !String.IsNullOrEmpty(KeyBox.Text))
            {
                /*
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
                    }*/

                DES_Encryption dES_CBCEncryption = new DES_Encryption(CypherBox.Text, KeyBox.Text);
                int bytesize = dES_CBCEncryption.byteSize(KeyBox.Text, Encoding.Default);
                if (choice == 1)
                {
                    //DES_ECBencryption dESencryption = new DES_ECBencryption(CypherBox.Text, KeyBox.Text);
                    //int bytesize = dESencryption.byteSize(KeyBox.Text, Encoding.Default);
                    if (bytesize != 8)
                    {
                        cypherAnswer.Text = "Invalid key size";
                    }
                    else
                    {
                        string encryptedString = dES_CBCEncryption.Encrypt(choice);
                        dES_CBCEncryption.EncryptedMessage = encryptedString;
                        cypherAnswer.Text = encryptedString;
                    }
                }
                else if (choice == 2)
                {
                    //int bytesize = dESencryption.byteSize(KeyBox.Text, Encoding.Default);
                    if (bytesize != 8)
                    {
                        cypherAnswer.Text = "Invalid key size";
                    }
                    else
                    {
                        string encryptedString = dES_CBCEncryption.Encrypt(choice);
                        dES_CBCEncryption.EncryptedMessage = encryptedString;
                        cypherAnswer.Text = encryptedString;
                    }
                }
                else
                {
                    //int bytesize = dESencryption.byteSize(KeyBox.Text, Encoding.Default);
                    if (bytesize != 8)
                    {
                        cypherAnswer.Text = "Invalid key size";
                    }
                    else
                    {
                        string encryptedString = dES_CBCEncryption.Encrypt(choice);
                        dES_CBCEncryption.EncryptedMessage = encryptedString;
                        setEncryptedMessg(encryptedString);
                        cypherAnswer.Text = encryptedString;
                    }
                }

                

            }

        }
    
            
            
        

        private void CypherBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(CypherBox.Text) && !String.IsNullOrEmpty(KeyBox.Text))
            { 
                DES_Encryption dES_CBCEncryption = new DES_Encryption(CypherBox.Text, KeyBox.Text);
                
                
                decypherAnswer.Text = dES_CBCEncryption.Decrypt(CypherBox.Text, KeyBox.Text, choice);
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

        private void button3_Click(object sender, EventArgs e)
        {
            choice = 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            choice = 2;
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            choice = 3;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SaveAndLoad saveload = new SaveAndLoad("savedencryption.txt");
            saveload.Save(cypherAnswer.Text); 
        }

        private void KeyBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
