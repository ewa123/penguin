namespace WindowsFormsApplication4
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.richTextBox6 = new System.Windows.Forms.RichTextBox();
            this.richTextBox7 = new System.Windows.Forms.RichTextBox();
            this.richTextBox8 = new System.Windows.Forms.RichTextBox();
            this.richTextBox9 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(398, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wynik";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(588, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "koniec";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 112);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(88, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(294, 112);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(88, 20);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(200, 112);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(88, 20);
            this.textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(482, 112);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(88, 20);
            this.textBox5.TabIndex = 9;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(106, 112);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(88, 20);
            this.textBox6.TabIndex = 10;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(388, 112);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(88, 20);
            this.textBox8.TabIndex = 12;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(575, 112);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(88, 20);
            this.textBox10.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(294, 138);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Licz H";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.richTextBox1.Location = new System.Drawing.Point(12, 40);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(88, 66);
            this.richTextBox1.TabIndex = 17;
            this.richTextBox1.Text = "prędkość na dopływie do turbiny [m/s]";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(294, 40);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(88, 66);
            this.richTextBox2.TabIndex = 18;
            this.richTextBox2.Text = "nadciśnienie na dopływie  [kG/m^3]";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(200, 40);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(88, 66);
            this.richTextBox3.TabIndex = 19;
            this.richTextBox3.Text = "ciężar objętościowy [kG/m^3]";
            // 
            // richTextBox4
            // 
            this.richTextBox4.Location = new System.Drawing.Point(482, 40);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(88, 66);
            this.richTextBox4.TabIndex = 20;
            this.richTextBox4.Text = "rzędna wody na dopływie \n[m n. p. m.]";
            // 
            // richTextBox5
            // 
            this.richTextBox5.Location = new System.Drawing.Point(106, 40);
            this.richTextBox5.Name = "richTextBox5";
            this.richTextBox5.Size = new System.Drawing.Size(88, 66);
            this.richTextBox5.TabIndex = 21;
            this.richTextBox5.Text = "prędkość na odpływie do turbiny [m/s]";
            // 
            // richTextBox6
            // 
            this.richTextBox6.Location = new System.Drawing.Point(388, 40);
            this.richTextBox6.Name = "richTextBox6";
            this.richTextBox6.Size = new System.Drawing.Size(88, 66);
            this.richTextBox6.TabIndex = 22;
            this.richTextBox6.Text = "nadciśnienie na odpływie  [kG/m^3]";
            // 
            // richTextBox7
            // 
            this.richTextBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBox7.Location = new System.Drawing.Point(575, 40);
            this.richTextBox7.Name = "richTextBox7";
            this.richTextBox7.Size = new System.Drawing.Size(88, 66);
            this.richTextBox7.TabIndex = 23;
            this.richTextBox7.Text = "rzędna wody na odpływie\n[m n. p. m.]";
            // 
            // richTextBox8
            // 
            this.richTextBox8.Location = new System.Drawing.Point(12, 166);
            this.richTextBox8.Name = "richTextBox8";
            this.richTextBox8.Size = new System.Drawing.Size(196, 23);
            this.richTextBox8.TabIndex = 24;
            this.richTextBox8.Text = "Przyspieszenie ziemskie g =  9,8 m/s^2";
            // 
            // richTextBox9
            // 
            this.richTextBox9.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.richTextBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBox9.Location = new System.Drawing.Point(225, 1);
            this.richTextBox9.Name = "richTextBox9";
            this.richTextBox9.Size = new System.Drawing.Size(210, 33);
            this.richTextBox9.TabIndex = 25;
            this.richTextBox9.Text = "Równanie Bernoulliego";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 202);
            this.Controls.Add(this.richTextBox9);
            this.Controls.Add(this.richTextBox8);
            this.Controls.Add(this.richTextBox7);
            this.Controls.Add(this.richTextBox6);
            this.Controls.Add(this.richTextBox5);
            this.Controls.Add(this.richTextBox4);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.RichTextBox richTextBox5;
        private System.Windows.Forms.RichTextBox richTextBox6;
        private System.Windows.Forms.RichTextBox richTextBox7;
        private System.Windows.Forms.RichTextBox richTextBox8;
        private System.Windows.Forms.RichTextBox richTextBox9;
    }
}