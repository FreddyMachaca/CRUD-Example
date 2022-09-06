
namespace INVENTARIO_MENU_1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TextBox1 = new Guna.UI.WinForms.GunaLineTextBox();
            this.TextBox2 = new Guna.UI.WinForms.GunaLineTextBox();
            this.Label1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.Button1 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 267);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // TextBox1
            // 
            this.TextBox1.BackColor = System.Drawing.Color.Gray;
            this.TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox1.FocusedLineColor = System.Drawing.Color.Red;
            this.TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TextBox1.LineColor = System.Drawing.Color.Gainsboro;
            this.TextBox1.Location = new System.Drawing.Point(216, 106);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.PasswordChar = '\0';
            this.TextBox1.Size = new System.Drawing.Size(312, 29);
            this.TextBox1.TabIndex = 13;
            // 
            // TextBox2
            // 
            this.TextBox2.BackColor = System.Drawing.Color.Gray;
            this.TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox2.FocusedLineColor = System.Drawing.Color.Red;
            this.TextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TextBox2.LineColor = System.Drawing.Color.Gainsboro;
            this.TextBox2.Location = new System.Drawing.Point(216, 186);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.PasswordChar = '●';
            this.TextBox2.Size = new System.Drawing.Size(312, 29);
            this.TextBox2.TabIndex = 13;
            this.TextBox2.UseSystemPasswordChar = true;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(201)))), ((int)(((byte)(211)))));
            this.Label1.Location = new System.Drawing.Point(211, 74);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(86, 25);
            this.Label1.TabIndex = 14;
            this.Label1.Text = "Usuario";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(201)))), ((int)(((byte)(211)))));
            this.gunaLabel1.Location = new System.Drawing.Point(211, 147);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(123, 25);
            this.gunaLabel1.TabIndex = 14;
            this.gunaLabel1.Text = "Contraseña";
            this.gunaLabel1.Click += new System.EventHandler(this.gunaLabel1_Click);
            // 
            // Button1
            // 
            this.Button1.AnimationHoverSpeed = 0.07F;
            this.Button1.AnimationSpeed = 0.03F;
            this.Button1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(96)))), ((int)(((byte)(124)))));
            this.Button1.BorderColor = System.Drawing.Color.Black;
            this.Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Button1.FocusedColor = System.Drawing.Color.Empty;
            this.Button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.ForeColor = System.Drawing.Color.White;
            this.Button1.Image = ((System.Drawing.Image)(resources.GetObject("Button1.Image")));
            this.Button1.ImageSize = new System.Drawing.Size(20, 20);
            this.Button1.Location = new System.Drawing.Point(216, 256);
            this.Button1.Name = "Button1";
            this.Button1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(112)))), ((int)(((byte)(149)))));
            this.Button1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Button1.OnHoverForeColor = System.Drawing.Color.White;
            this.Button1.OnHoverImage = null;
            this.Button1.OnPressedColor = System.Drawing.Color.Black;
            this.Button1.Size = new System.Drawing.Size(126, 48);
            this.Button1.TabIndex = 15;
            this.Button1.Text = "Entrar";
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(96)))), ((int)(((byte)(124)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton1.Image")));
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(377, 256);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(126, 48);
            this.gunaButton1.TabIndex = 15;
            this.gunaButton1.Text = "Salir";
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(96)))), ((int)(((byte)(124)))));
            this.ClientSize = new System.Drawing.Size(569, 354);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.TextBox2);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaLineTextBox TextBox2;
        private Guna.UI.WinForms.GunaLineTextBox TextBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel Label1;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaButton Button1;
    }
}