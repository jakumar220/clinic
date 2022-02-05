
namespace Przychodnia
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.whiterect1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginhelp = new System.Windows.Forms.Label();
            this.warn1 = new System.Windows.Forms.PictureBox();
            this.warn2 = new System.Windows.Forms.PictureBox();
            this.passhelp = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loginfailedcomm = new System.Windows.Forms.Label();
            this.warn3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.labelcomminactive = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.whiterect1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warn1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warn2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warn3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(76)))), ((int)(((byte)(110)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(76)))), ((int)(((byte)(110)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(879, 779);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "ZALOGUJ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_Hover);
            this.button1.MouseLeave += new System.EventHandler(this.button1_Leave);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(76)))), ((int)(((byte)(110)))));
            this.textBox1.Location = new System.Drawing.Point(782, 547);
            this.textBox1.MaxLength = 40;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(361, 33);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enterclick);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(76)))), ((int)(((byte)(110)))));
            this.textBox2.Location = new System.Drawing.Point(782, 684);
            this.textBox2.MaxLength = 40;
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(361, 33);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enterclick);
            // 
            // whiterect1
            // 
            this.whiterect1.BackColor = System.Drawing.Color.White;
            this.whiterect1.Location = new System.Drawing.Point(710, 317);
            this.whiterect1.Name = "whiterect1";
            this.whiterect1.Size = new System.Drawing.Size(500, 599);
            this.whiterect1.TabIndex = 5;
            this.whiterect1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(76)))), ((int)(((byte)(110)))));
            this.label1.Location = new System.Drawing.Point(927, 495);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "LOGIN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(76)))), ((int)(((byte)(110)))));
            this.label2.Location = new System.Drawing.Point(924, 635);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "HASŁO:";
            // 
            // loginhelp
            // 
            this.loginhelp.BackColor = System.Drawing.Color.White;
            this.loginhelp.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginhelp.ForeColor = System.Drawing.Color.Red;
            this.loginhelp.Location = new System.Drawing.Point(822, 584);
            this.loginhelp.Name = "loginhelp";
            this.loginhelp.Size = new System.Drawing.Size(305, 51);
            this.loginhelp.TabIndex = 9;
            this.loginhelp.Text = "Pusty, niepoprawny, bądź nieistniejący login. Spróbuj wpisać login ponownie.";
            this.loginhelp.Visible = false;
            this.loginhelp.Click += new System.EventHandler(this.loginhelp_Click);
            // 
            // warn1
            // 
            this.warn1.BackColor = System.Drawing.Color.White;
            this.warn1.Image = ((System.Drawing.Image)(resources.GetObject("warn1.Image")));
            this.warn1.Location = new System.Drawing.Point(782, 590);
            this.warn1.Name = "warn1";
            this.warn1.Size = new System.Drawing.Size(33, 30);
            this.warn1.TabIndex = 11;
            this.warn1.TabStop = false;
            this.warn1.Visible = false;
            // 
            // warn2
            // 
            this.warn2.BackColor = System.Drawing.Color.White;
            this.warn2.Image = ((System.Drawing.Image)(resources.GetObject("warn2.Image")));
            this.warn2.Location = new System.Drawing.Point(782, 726);
            this.warn2.Name = "warn2";
            this.warn2.Size = new System.Drawing.Size(33, 30);
            this.warn2.TabIndex = 13;
            this.warn2.TabStop = false;
            this.warn2.Visible = false;
            // 
            // passhelp
            // 
            this.passhelp.BackColor = System.Drawing.Color.White;
            this.passhelp.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passhelp.ForeColor = System.Drawing.Color.Red;
            this.passhelp.Location = new System.Drawing.Point(822, 729);
            this.passhelp.Name = "passhelp";
            this.passhelp.Size = new System.Drawing.Size(305, 51);
            this.passhelp.TabIndex = 12;
            this.passhelp.Text = "Puste, bądź niepoprawne hasło. Spróbuj wpisać hasło ponownie.";
            this.passhelp.Visible = false;
            this.passhelp.Click += new System.EventHandler(this.passhelp_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(812, 235);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(383, 82);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // loginfailedcomm
            // 
            this.loginfailedcomm.BackColor = System.Drawing.Color.White;
            this.loginfailedcomm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginfailedcomm.ForeColor = System.Drawing.Color.Red;
            this.loginfailedcomm.Location = new System.Drawing.Point(821, 729);
            this.loginfailedcomm.Name = "loginfailedcomm";
            this.loginfailedcomm.Size = new System.Drawing.Size(305, 51);
            this.loginfailedcomm.TabIndex = 15;
            this.loginfailedcomm.Text = "Niepoprawny login, bądź hasło.";
            this.loginfailedcomm.Visible = false;
            this.loginfailedcomm.Click += new System.EventHandler(this.loginfailedcomm_Click);
            // 
            // warn3
            // 
            this.warn3.BackColor = System.Drawing.Color.White;
            this.warn3.Image = ((System.Drawing.Image)(resources.GetObject("warn3.Image")));
            this.warn3.Location = new System.Drawing.Point(782, 726);
            this.warn3.Name = "warn3";
            this.warn3.Size = new System.Drawing.Size(33, 30);
            this.warn3.TabIndex = 16;
            this.warn3.TabStop = false;
            this.warn3.Visible = false;
            this.warn3.Click += new System.EventHandler(this.warn3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(812, 235);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(308, 266);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Location = new System.Drawing.Point(715, 321);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(498, 598);
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // labelcomminactive
            // 
            this.labelcomminactive.BackColor = System.Drawing.Color.White;
            this.labelcomminactive.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelcomminactive.ForeColor = System.Drawing.Color.Red;
            this.labelcomminactive.Location = new System.Drawing.Point(821, 729);
            this.labelcomminactive.Name = "labelcomminactive";
            this.labelcomminactive.Size = new System.Drawing.Size(305, 51);
            this.labelcomminactive.TabIndex = 19;
            this.labelcomminactive.Text = "Konto nieaktywne.";
            this.labelcomminactive.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(150)))), ((int)(((byte)(217)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.labelcomminactive);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.warn3);
            this.Controls.Add(this.loginfailedcomm);
            this.Controls.Add(this.warn2);
            this.Controls.Add(this.passhelp);
            this.Controls.Add(this.warn1);
            this.Controls.Add(this.loginhelp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.whiterect1);
            this.Controls.Add(this.pictureBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Przychodnia StudMed";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.whiterect1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warn1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warn2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warn3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox whiterect1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label loginhelp;
        private System.Windows.Forms.PictureBox warn1;
        private System.Windows.Forms.PictureBox warn2;
        private System.Windows.Forms.Label passhelp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label loginfailedcomm;
        private System.Windows.Forms.PictureBox warn3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label labelcomminactive;
    }
}

