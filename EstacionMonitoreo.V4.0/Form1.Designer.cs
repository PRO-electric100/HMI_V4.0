namespace EstacionMonitoreo.V4._0
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.minimizar = new System.Windows.Forms.PictureBox();
            this.salir = new System.Windows.Forms.PictureBox();
            this.SpaceVoyager = new System.Windows.Forms.Panel();
            this.contra = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.contraseña = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salir)).BeginInit();
            this.SpaceVoyager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // minimizar
            // 
            this.minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizar.Image = ((System.Drawing.Image)(resources.GetObject("minimizar.Image")));
            this.minimizar.Location = new System.Drawing.Point(368, 3);
            this.minimizar.Name = "minimizar";
            this.minimizar.Size = new System.Drawing.Size(25, 25);
            this.minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimizar.TabIndex = 2;
            this.minimizar.TabStop = false;
            this.minimizar.Click += new System.EventHandler(this.minimizar_Click);
            // 
            // salir
            // 
            this.salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salir.Image = ((System.Drawing.Image)(resources.GetObject("salir.Image")));
            this.salir.Location = new System.Drawing.Point(399, 3);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(25, 25);
            this.salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.salir.TabIndex = 0;
            this.salir.TabStop = false;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // SpaceVoyager
            // 
            this.SpaceVoyager.BackColor = System.Drawing.Color.LightSlateGray;
            this.SpaceVoyager.Controls.Add(this.minimizar);
            this.SpaceVoyager.Controls.Add(this.salir);
            this.SpaceVoyager.Dock = System.Windows.Forms.DockStyle.Top;
            this.SpaceVoyager.Location = new System.Drawing.Point(0, 0);
            this.SpaceVoyager.Name = "SpaceVoyager";
            this.SpaceVoyager.Size = new System.Drawing.Size(436, 32);
            this.SpaceVoyager.TabIndex = 26;
            this.SpaceVoyager.Paint += new System.Windows.Forms.PaintEventHandler(this.SpaceVoyager_Paint);
            this.SpaceVoyager.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SpaceVoyager_MouseDown_1);
            // 
            // contra
            // 
            this.contra.BackColor = System.Drawing.Color.Black;
            this.contra.FlatAppearance.BorderSize = 0;
            this.contra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.contra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.contra.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.contra.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.contra.Image = ((System.Drawing.Image)(resources.GetObject("contra.Image")));
            this.contra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.contra.Location = new System.Drawing.Point(337, 428);
            this.contra.Name = "contra";
            this.contra.Size = new System.Drawing.Size(87, 26);
            this.contra.TabIndex = 25;
            this.contra.Text = "ENTER";
            this.contra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.contra.UseVisualStyleBackColor = false;
            this.contra.Click += new System.EventHandler(this.contra_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(11, 408);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "PASSWORD";
            // 
            // contraseña
            // 
            this.contraseña.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.contraseña.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.contraseña.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.contraseña.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.contraseña.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.contraseña.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.contraseña.ForeColor = System.Drawing.Color.Cyan;
            this.contraseña.HintForeColor = System.Drawing.Color.Empty;
            this.contraseña.HintText = "";
            this.contraseña.isPassword = false;
            this.contraseña.LineFocusedColor = System.Drawing.Color.Orange;
            this.contraseña.LineIdleColor = System.Drawing.Color.Cyan;
            this.contraseña.LineMouseHoverColor = System.Drawing.Color.Lime;
            this.contraseña.LineThickness = 3;
            this.contraseña.Location = new System.Drawing.Point(0, 428);
            this.contraseña.Margin = new System.Windows.Forms.Padding(4);
            this.contraseña.MaxLength = 32767;
            this.contraseña.Name = "contraseña";
            this.contraseña.Size = new System.Drawing.Size(151, 33);
            this.contraseña.TabIndex = 23;
            this.contraseña.Text = " ";
            this.contraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.contraseña.KeyDown += new System.Windows.Forms.KeyEventHandler(this.contraseña_KeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(436, 461);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 461);
            this.Controls.Add(this.SpaceVoyager);
            this.Controls.Add(this.contra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.contraseña);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salir)).EndInit();
            this.SpaceVoyager.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox minimizar;
        private System.Windows.Forms.PictureBox salir;
        private System.Windows.Forms.Panel SpaceVoyager;
        private System.Windows.Forms.Button contra;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox contraseña;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

