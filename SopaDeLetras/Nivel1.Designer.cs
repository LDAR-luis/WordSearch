namespace SopaDeLetras
{
    partial class Nivel1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nivel1));
            this.Tabla = new System.Windows.Forms.DataGridView();
            this.Titulo = new System.Windows.Forms.Label();
            this.Pa1 = new System.Windows.Forms.Label();
            this.pa2 = new System.Windows.Forms.Label();
            this.pa3 = new System.Windows.Forms.Label();
            this.pa4 = new System.Windows.Forms.Label();
            this.pa5 = new System.Windows.Forms.Label();
            this.pa6 = new System.Windows.Forms.Label();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.pic3 = new System.Windows.Forms.PictureBox();
            this.pic4 = new System.Windows.Forms.PictureBox();
            this.pic5 = new System.Windows.Forms.PictureBox();
            this.pic6 = new System.Windows.Forms.PictureBox();
            this.SigNivel = new System.Windows.Forms.Button();
            this.Tiempo = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic6)).BeginInit();
            this.SuspendLayout();
            // 
            // Tabla
            // 
            this.Tabla.AllowUserToAddRows = false;
            this.Tabla.AllowUserToDeleteRows = false;
            this.Tabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Tabla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tabla.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabla.ColumnHeadersVisible = false;
            this.Tabla.EnableHeadersVisualStyles = false;
            this.Tabla.Location = new System.Drawing.Point(66, 104);
            this.Tabla.Margin = new System.Windows.Forms.Padding(0);
            this.Tabla.MultiSelect = false;
            this.Tabla.Name = "Tabla";
            this.Tabla.RowHeadersVisible = false;
            this.Tabla.RowHeadersWidth = 20;
            this.Tabla.Size = new System.Drawing.Size(734, 363);
            this.Tabla.TabIndex = 0;
            this.Tabla.Click += new System.EventHandler(this.Color_click);
            this.Tabla.DoubleClick += new System.EventHandler(this.RegresarColor_Doclick);
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.BackColor = System.Drawing.SystemColors.Info;
            this.Titulo.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.Color.DarkRed;
            this.Titulo.Location = new System.Drawing.Point(864, 35);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(309, 24);
            this.Titulo.TabIndex = 1;
            this.Titulo.Text = "ENCUENTRA LAS PALABRAS";
            // 
            // Pa1
            // 
            this.Pa1.AutoSize = true;
            this.Pa1.BackColor = System.Drawing.Color.Transparent;
            this.Pa1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pa1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Pa1.Location = new System.Drawing.Point(1032, 112);
            this.Pa1.Name = "Pa1";
            this.Pa1.Size = new System.Drawing.Size(101, 22);
            this.Pa1.TabIndex = 2;
            this.Pa1.Text = "SIMBOLO";
            this.Pa1.Click += new System.EventHandler(this.Pa1_Click);
            // 
            // pa2
            // 
            this.pa2.AutoSize = true;
            this.pa2.BackColor = System.Drawing.Color.Transparent;
            this.pa2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pa2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pa2.Location = new System.Drawing.Point(1031, 165);
            this.pa2.Name = "pa2";
            this.pa2.Size = new System.Drawing.Size(103, 22);
            this.pa2.TabIndex = 2;
            this.pa2.Text = "ESTADOS";
            // 
            // pa3
            // 
            this.pa3.AutoSize = true;
            this.pa3.BackColor = System.Drawing.Color.Transparent;
            this.pa3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pa3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pa3.Location = new System.Drawing.Point(1031, 216);
            this.pa3.Name = "pa3";
            this.pa3.Size = new System.Drawing.Size(77, 22);
            this.pa3.TabIndex = 2;
            this.pa3.Text = "INICIAL";
            // 
            // pa4
            // 
            this.pa4.AutoSize = true;
            this.pa4.BackColor = System.Drawing.Color.Transparent;
            this.pa4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pa4.ForeColor = System.Drawing.Color.White;
            this.pa4.Location = new System.Drawing.Point(1034, 274);
            this.pa4.Name = "pa4";
            this.pa4.Size = new System.Drawing.Size(65, 22);
            this.pa4.TabIndex = 2;
            this.pa4.Text = "FINAL";
            // 
            // pa5
            // 
            this.pa5.AutoSize = true;
            this.pa5.BackColor = System.Drawing.Color.Transparent;
            this.pa5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pa5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pa5.Location = new System.Drawing.Point(1034, 326);
            this.pa5.Name = "pa5";
            this.pa5.Size = new System.Drawing.Size(90, 22);
            this.pa5.TabIndex = 2;
            this.pa5.Text = "CADENA";
            // 
            // pa6
            // 
            this.pa6.AutoSize = true;
            this.pa6.BackColor = System.Drawing.Color.Transparent;
            this.pa6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pa6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pa6.Location = new System.Drawing.Point(1033, 382);
            this.pa6.Name = "pa6";
            this.pa6.Size = new System.Drawing.Size(118, 22);
            this.pa6.TabIndex = 2;
            this.pa6.Text = "AUTOMATA";
            // 
            // pic1
            // 
            this.pic1.BackColor = System.Drawing.Color.Transparent;
            this.pic1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic1.BackgroundImage")));
            this.pic1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic1.Location = new System.Drawing.Point(934, 90);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(100, 50);
            this.pic1.TabIndex = 3;
            this.pic1.TabStop = false;
            // 
            // pic2
            // 
            this.pic2.BackColor = System.Drawing.Color.Transparent;
            this.pic2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic2.BackgroundImage")));
            this.pic2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic2.Location = new System.Drawing.Point(934, 146);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(100, 50);
            this.pic2.TabIndex = 3;
            this.pic2.TabStop = false;
            // 
            // pic3
            // 
            this.pic3.BackColor = System.Drawing.Color.Transparent;
            this.pic3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic3.BackgroundImage")));
            this.pic3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic3.Location = new System.Drawing.Point(934, 202);
            this.pic3.Name = "pic3";
            this.pic3.Size = new System.Drawing.Size(100, 50);
            this.pic3.TabIndex = 3;
            this.pic3.TabStop = false;
            // 
            // pic4
            // 
            this.pic4.BackColor = System.Drawing.Color.Transparent;
            this.pic4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic4.BackgroundImage")));
            this.pic4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic4.Location = new System.Drawing.Point(934, 260);
            this.pic4.Name = "pic4";
            this.pic4.Size = new System.Drawing.Size(100, 50);
            this.pic4.TabIndex = 3;
            this.pic4.TabStop = false;
            // 
            // pic5
            // 
            this.pic5.BackColor = System.Drawing.Color.Transparent;
            this.pic5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic5.BackgroundImage")));
            this.pic5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic5.Location = new System.Drawing.Point(934, 313);
            this.pic5.Name = "pic5";
            this.pic5.Size = new System.Drawing.Size(100, 50);
            this.pic5.TabIndex = 3;
            this.pic5.TabStop = false;
            // 
            // pic6
            // 
            this.pic6.BackColor = System.Drawing.Color.Transparent;
            this.pic6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic6.BackgroundImage")));
            this.pic6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic6.Location = new System.Drawing.Point(934, 369);
            this.pic6.Name = "pic6";
            this.pic6.Size = new System.Drawing.Size(100, 50);
            this.pic6.TabIndex = 3;
            this.pic6.TabStop = false;
            // 
            // SigNivel
            // 
            this.SigNivel.BackColor = System.Drawing.Color.Red;
            this.SigNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SigNivel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SigNivel.Location = new System.Drawing.Point(441, 532);
            this.SigNivel.Name = "SigNivel";
            this.SigNivel.Size = new System.Drawing.Size(306, 52);
            this.SigNivel.TabIndex = 4;
            this.SigNivel.Text = "SIGUIENTE NIVEL";
            this.SigNivel.UseVisualStyleBackColor = false;
            this.SigNivel.Click += new System.EventHandler(this.SigNivel_Click);
            // 
            // Tiempo
            // 
            this.Tiempo.BackColor = System.Drawing.Color.Transparent;
            this.Tiempo.Enabled = false;
            this.Tiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tiempo.ForeColor = System.Drawing.Color.Yellow;
            this.Tiempo.Location = new System.Drawing.Point(363, 19);
            this.Tiempo.Name = "Tiempo";
            this.Tiempo.Size = new System.Drawing.Size(246, 69);
            this.Tiempo.TabIndex = 5;
            this.Tiempo.Text = "---:---";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(210, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 69);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tiempo:";
            // 
            // Nivel1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1214, 643);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tiempo);
            this.Controls.Add(this.SigNivel);
            this.Controls.Add(this.pic6);
            this.Controls.Add(this.pic5);
            this.Controls.Add(this.pic4);
            this.Controls.Add(this.pic3);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.pa6);
            this.Controls.Add(this.pa5);
            this.Controls.Add(this.pa4);
            this.Controls.Add(this.pa3);
            this.Controls.Add(this.pa2);
            this.Controls.Add(this.Pa1);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.Tabla);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1230, 682);
            this.Name = "Nivel1";
            this.Text = "Nivel1";
            this.Load += new System.EventHandler(this.Nivel1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tabla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Tabla;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Label Pa1;
        private System.Windows.Forms.Label pa2;
        private System.Windows.Forms.Label pa3;
        private System.Windows.Forms.Label pa4;
        private System.Windows.Forms.Label pa5;
        private System.Windows.Forms.Label pa6;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.PictureBox pic3;
        private System.Windows.Forms.PictureBox pic4;
        private System.Windows.Forms.PictureBox pic5;
        private System.Windows.Forms.PictureBox pic6;
        private System.Windows.Forms.Button SigNivel;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.Label Tiempo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}