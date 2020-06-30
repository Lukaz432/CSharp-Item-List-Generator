namespace CSharp_List
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.RemBtn = new System.Windows.Forms.Button();
            this.ShowBtn = new System.Windows.Forms.Button();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.CrtListBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CrtDictBtn = new System.Windows.Forms.Button();
            this.ClrTxtBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(40, 33);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(406, 348);
            this.textBox1.TabIndex = 0;
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(494, 141);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(97, 35);
            this.AddBtn.TabIndex = 2;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // RemBtn
            // 
            this.RemBtn.Location = new System.Drawing.Point(494, 194);
            this.RemBtn.Name = "RemBtn";
            this.RemBtn.Size = new System.Drawing.Size(97, 35);
            this.RemBtn.TabIndex = 3;
            this.RemBtn.Text = "Remove";
            this.RemBtn.UseVisualStyleBackColor = true;
            this.RemBtn.Click += new System.EventHandler(this.RemBtn_Click);
            // 
            // ShowBtn
            // 
            this.ShowBtn.Location = new System.Drawing.Point(494, 245);
            this.ShowBtn.Name = "ShowBtn";
            this.ShowBtn.Size = new System.Drawing.Size(97, 35);
            this.ShowBtn.TabIndex = 4;
            this.ShowBtn.Text = "Show";
            this.ShowBtn.UseVisualStyleBackColor = true;
            this.ShowBtn.Click += new System.EventHandler(this.ShowBtn_Click);
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(494, 361);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(97, 20);
            this.NameBox.TabIndex = 5;
            // 
            // CrtListBtn
            // 
            this.CrtListBtn.Location = new System.Drawing.Point(494, 33);
            this.CrtListBtn.Name = "CrtListBtn";
            this.CrtListBtn.Size = new System.Drawing.Size(97, 35);
            this.CrtListBtn.TabIndex = 6;
            this.CrtListBtn.Text = "Create List (Item)";
            this.CrtListBtn.UseVisualStyleBackColor = true;
            this.CrtListBtn.Click += new System.EventHandler(this.CrtListBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "oldschool runescape  list (item) and dictionary (place) editor";
            // 
            // CrtDictBtn
            // 
            this.CrtDictBtn.Location = new System.Drawing.Point(494, 88);
            this.CrtDictBtn.Name = "CrtDictBtn";
            this.CrtDictBtn.Size = new System.Drawing.Size(97, 35);
            this.CrtDictBtn.TabIndex = 8;
            this.CrtDictBtn.Text = "Create Dictionary (place)";
            this.CrtDictBtn.UseVisualStyleBackColor = true;
            this.CrtDictBtn.Click += new System.EventHandler(this.CrtDictBtn_Click);
            // 
            // ClrTxtBtn
            // 
            this.ClrTxtBtn.Location = new System.Drawing.Point(494, 304);
            this.ClrTxtBtn.Name = "ClrTxtBtn";
            this.ClrTxtBtn.Size = new System.Drawing.Size(97, 35);
            this.ClrTxtBtn.TabIndex = 9;
            this.ClrTxtBtn.Text = "Clear Text";
            this.ClrTxtBtn.UseVisualStyleBackColor = true;
            this.ClrTxtBtn.Click += new System.EventHandler(this.ClrTxtBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 417);
            this.Controls.Add(this.ClrTxtBtn);
            this.Controls.Add(this.CrtDictBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CrtListBtn);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.ShowBtn);
            this.Controls.Add(this.RemBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button RemBtn;
        private System.Windows.Forms.Button ShowBtn;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Button CrtListBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CrtDictBtn;
        private System.Windows.Forms.Button ClrTxtBtn;
    }
}

