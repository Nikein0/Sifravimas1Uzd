namespace Sifravimas1Uzd
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
            this.CypherBox = new System.Windows.Forms.TextBox();
            this.DecypherBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.KeyBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cypherAnswer = new System.Windows.Forms.TextBox();
            this.decypherAnswer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CypherBox
            // 
            this.CypherBox.Location = new System.Drawing.Point(37, 38);
            this.CypherBox.Name = "CypherBox";
            this.CypherBox.Size = new System.Drawing.Size(734, 20);
            this.CypherBox.TabIndex = 0;
            this.CypherBox.TextChanged += new System.EventHandler(this.CypherBox_TextChanged);
            // 
            // DecypherBox
            // 
            this.DecypherBox.Location = new System.Drawing.Point(37, 134);
            this.DecypherBox.Name = "DecypherBox";
            this.DecypherBox.Size = new System.Drawing.Size(734, 20);
            this.DecypherBox.TabIndex = 3;
            this.DecypherBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(696, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Cipher";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(696, 184);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Decypher";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // KeyBox
            // 
            this.KeyBox.Location = new System.Drawing.Point(37, 12);
            this.KeyBox.Name = "KeyBox";
            this.KeyBox.Size = new System.Drawing.Size(175, 20);
            this.KeyBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Key";
            // 
            // cypherAnswer
            // 
            this.cypherAnswer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cypherAnswer.Location = new System.Drawing.Point(37, 64);
            this.cypherAnswer.Name = "cypherAnswer";
            this.cypherAnswer.ReadOnly = true;
            this.cypherAnswer.Size = new System.Drawing.Size(175, 13);
            this.cypherAnswer.TabIndex = 10;
            this.cypherAnswer.TextChanged += new System.EventHandler(this.cypherAnswer_TextChanged);
            // 
            // decypherAnswer
            // 
            this.decypherAnswer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.decypherAnswer.Location = new System.Drawing.Point(37, 184);
            this.decypherAnswer.Name = "decypherAnswer";
            this.decypherAnswer.ReadOnly = true;
            this.decypherAnswer.Size = new System.Drawing.Size(175, 13);
            this.decypherAnswer.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.decypherAnswer);
            this.Controls.Add(this.cypherAnswer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KeyBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DecypherBox);
            this.Controls.Add(this.CypherBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CypherBox;
        private System.Windows.Forms.TextBox DecypherBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox KeyBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cypherAnswer;
        private System.Windows.Forms.TextBox decypherAnswer;
    }
}

