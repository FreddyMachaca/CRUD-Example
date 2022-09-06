
namespace INVENTARIO_MENU_1
{
    partial class Productos
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productos));
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.TextBox6 = new Guna.UI.WinForms.GunaLineTextBox();
            this.Button5 = new Guna.UI.WinForms.GunaButton();
            this.Button6 = new Guna.UI.WinForms.GunaButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(201)))), ((int)(((byte)(211)))));
            this.gunaLabel1.Location = new System.Drawing.Point(3, 55);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(145, 25);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "PRODUCTOS";
            // 
            // TextBox6
            // 
            this.TextBox6.BackColor = System.Drawing.Color.Gray;
            this.TextBox6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox6.FocusedLineColor = System.Drawing.Color.Red;
            this.TextBox6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TextBox6.LineColor = System.Drawing.Color.Gainsboro;
            this.TextBox6.Location = new System.Drawing.Point(146, 55);
            this.TextBox6.Name = "TextBox6";
            this.TextBox6.PasswordChar = '\0';
            this.TextBox6.Size = new System.Drawing.Size(314, 29);
            this.TextBox6.TabIndex = 1;
            // 
            // Button5
            // 
            this.Button5.AnimationHoverSpeed = 0.07F;
            this.Button5.AnimationSpeed = 0.03F;
            this.Button5.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(96)))), ((int)(((byte)(124)))));
            this.Button5.BorderColor = System.Drawing.Color.Black;
            this.Button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button5.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Button5.FocusedColor = System.Drawing.Color.Empty;
            this.Button5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button5.ForeColor = System.Drawing.Color.White;
            this.Button5.Image = ((System.Drawing.Image)(resources.GetObject("Button5.Image")));
            this.Button5.ImageSize = new System.Drawing.Size(20, 20);
            this.Button5.Location = new System.Drawing.Point(466, 55);
            this.Button5.Name = "Button5";
            this.Button5.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.Button5.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Button5.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(112)))), ((int)(((byte)(149)))));
            this.Button5.OnHoverImage = null;
            this.Button5.OnPressedColor = System.Drawing.Color.Black;
            this.Button5.Size = new System.Drawing.Size(115, 29);
            this.Button5.TabIndex = 9;
            this.Button5.Text = "Buscar";
            this.Button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // Button6
            // 
            this.Button6.AnimationHoverSpeed = 0.07F;
            this.Button6.AnimationSpeed = 0.03F;
            this.Button6.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(96)))), ((int)(((byte)(124)))));
            this.Button6.BorderColor = System.Drawing.Color.Black;
            this.Button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button6.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Button6.FocusedColor = System.Drawing.Color.Empty;
            this.Button6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button6.ForeColor = System.Drawing.Color.White;
            this.Button6.Image = ((System.Drawing.Image)(resources.GetObject("Button6.Image")));
            this.Button6.ImageSize = new System.Drawing.Size(20, 20);
            this.Button6.Location = new System.Drawing.Point(587, 55);
            this.Button6.Name = "Button6";
            this.Button6.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.Button6.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Button6.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(112)))), ((int)(((byte)(149)))));
            this.Button6.OnHoverImage = null;
            this.Button6.OnPressedColor = System.Drawing.Color.Black;
            this.Button6.Size = new System.Drawing.Size(115, 29);
            this.Button6.TabIndex = 9;
            this.Button6.Text = "Refrescar";
            this.Button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(109, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(445, 233);
            this.dataGridView1.TabIndex = 14;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Button6);
            this.Controls.Add(this.Button5);
            this.Controls.Add(this.TextBox6);
            this.Controls.Add(this.gunaLabel1);
            this.Name = "Productos";
            this.Size = new System.Drawing.Size(707, 479);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLineTextBox TextBox6;
        private Guna.UI.WinForms.GunaButton Button5;
        private Guna.UI.WinForms.GunaButton Button6;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
