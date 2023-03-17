namespace TakeHomeW3Edward
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
            this.btn_NextForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Artist = new System.Windows.Forms.TextBox();
            this.check_tnc = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_NextForm
            // 
            this.btn_NextForm.Location = new System.Drawing.Point(20, 10);
            this.btn_NextForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_NextForm.Name = "btn_NextForm";
            this.btn_NextForm.Size = new System.Drawing.Size(145, 34);
            this.btn_NextForm.TabIndex = 0;
            this.btn_NextForm.Text = "Open Next Form";
            this.btn_NextForm.UseVisualStyleBackColor = true;
            this.btn_NextForm.Click += new System.EventHandler(this.btn_NextForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(118, 60);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(173, 22);
            this.txt_Name.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Favorite Artist";
            // 
            // txt_Artist
            // 
            this.txt_Artist.Location = new System.Drawing.Point(118, 93);
            this.txt_Artist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Artist.Name = "txt_Artist";
            this.txt_Artist.Size = new System.Drawing.Size(173, 22);
            this.txt_Artist.TabIndex = 4;
            // 
            // check_tnc
            // 
            this.check_tnc.AutoSize = true;
            this.check_tnc.Location = new System.Drawing.Point(20, 138);
            this.check_tnc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.check_tnc.Name = "check_tnc";
            this.check_tnc.Size = new System.Drawing.Size(238, 20);
            this.check_tnc.TabIndex = 5;
            this.check_tnc.Text = "All of the content I put above is true !";
            this.check_tnc.UseVisualStyleBackColor = true;
            this.check_tnc.CheckedChanged += new System.EventHandler(this.check_tnc_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(20, 173);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::TakeHomeW3Edward.Properties.Resources.jentoi;
            this.pictureBox1.Location = new System.Drawing.Point(363, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(296, 262);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.check_tnc);
            this.Controls.Add(this.txt_Artist);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_NextForm);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Main Windows Form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_NextForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Artist;
        private System.Windows.Forms.CheckBox check_tnc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

