namespace binary
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
            this.numbox = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.printbox = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.adresbox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // numbox
            // 
            this.numbox.Location = new System.Drawing.Point(12, 12);
            this.numbox.Name = "numbox";
            this.numbox.Size = new System.Drawing.Size(90, 183);
            this.numbox.TabIndex = 0;
            this.numbox.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Sayilari Yaz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // printbox
            // 
            this.printbox.Location = new System.Drawing.Point(194, 13);
            this.printbox.Name = "printbox";
            this.printbox.Size = new System.Drawing.Size(66, 182);
            this.printbox.TabIndex = 2;
            this.printbox.Text = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(142, 201);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Insert";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // adresbox
            // 
            this.adresbox.Location = new System.Drawing.Point(142, 13);
            this.adresbox.Name = "adresbox";
            this.adresbox.Size = new System.Drawing.Size(46, 182);
            this.adresbox.TabIndex = 4;
            this.adresbox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.adresbox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.printbox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox numbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox printbox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox adresbox;
    }
}

