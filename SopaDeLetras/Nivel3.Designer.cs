namespace SopaDeLetras
{
    partial class Nivel3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nivel3));
            this.TablaN3 = new System.Windows.Forms.DataGridView();
            this.Titulo2 = new System.Windows.Forms.Label();
            this.N3pa1 = new System.Windows.Forms.Label();
            this.N3pa3 = new System.Windows.Forms.Label();
            this.N3pa4 = new System.Windows.Forms.Label();
            this.N3pa2 = new System.Windows.Forms.Label();
            this.N3PIC1 = new System.Windows.Forms.PictureBox();
            this.N3PIC2 = new System.Windows.Forms.PictureBox();
            this.N3PIC3 = new System.Windows.Forms.PictureBox();
            this.N3PIC4 = new System.Windows.Forms.PictureBox();
            this.Tiempo = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.terminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TablaN3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.N3PIC1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.N3PIC2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.N3PIC3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.N3PIC4)).BeginInit();
            this.SuspendLayout();
            // 
            // TablaN3
            // 
            this.TablaN3.AllowUserToAddRows = false;
            this.TablaN3.AllowUserToDeleteRows = false;
            this.TablaN3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TablaN3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TablaN3.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.TablaN3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaN3.ColumnHeadersVisible = false;
            this.TablaN3.EnableHeadersVisualStyles = false;
            this.TablaN3.Location = new System.Drawing.Point(17, 108);
            this.TablaN3.Margin = new System.Windows.Forms.Padding(0);
            this.TablaN3.MultiSelect = false;
            this.TablaN3.Name = "TablaN3";
            this.TablaN3.RowHeadersVisible = false;
            this.TablaN3.RowHeadersWidth = 20;
            this.TablaN3.Size = new System.Drawing.Size(916, 500);
            this.TablaN3.TabIndex = 6;
            this.TablaN3.Click += new System.EventHandler(this.Color_click);
            this.TablaN3.DoubleClick += new System.EventHandler(this.Regresar_color_click);
            // 
            // Titulo2
            // 
            this.Titulo2.AutoSize = true;
            this.Titulo2.BackColor = System.Drawing.SystemColors.Info;
            this.Titulo2.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo2.ForeColor = System.Drawing.Color.DarkRed;
            this.Titulo2.Location = new System.Drawing.Point(914, 47);
            this.Titulo2.Name = "Titulo2";
            this.Titulo2.Size = new System.Drawing.Size(309, 24);
            this.Titulo2.TabIndex = 7;
            this.Titulo2.Text = "ENCUENTRA LAS PALABRAS";
            // 
            // N3pa1
            // 
            this.N3pa1.AutoSize = true;
            this.N3pa1.BackColor = System.Drawing.Color.Transparent;
            this.N3pa1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.N3pa1.ForeColor = System.Drawing.SystemColors.Control;
            this.N3pa1.Location = new System.Drawing.Point(1081, 214);
            this.N3pa1.Name = "N3pa1";
            this.N3pa1.Size = new System.Drawing.Size(62, 22);
            this.N3pa1.TabIndex = 8;
            this.N3pa1.Text = "AFND";
            // 
            // N3pa3
            // 
            this.N3pa3.AutoSize = true;
            this.N3pa3.BackColor = System.Drawing.Color.Transparent;
            this.N3pa3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.N3pa3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.N3pa3.Location = new System.Drawing.Point(1081, 316);
            this.N3pa3.Name = "N3pa3";
            this.N3pa3.Size = new System.Drawing.Size(120, 22);
            this.N3pa3.TabIndex = 8;
            this.N3pa3.Text = "QUINTUPLA";
            // 
            // N3pa4
            // 
            this.N3pa4.AutoSize = true;
            this.N3pa4.BackColor = System.Drawing.Color.Transparent;
            this.N3pa4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.N3pa4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.N3pa4.Location = new System.Drawing.Point(1081, 366);
            this.N3pa4.Name = "N3pa4";
            this.N3pa4.Size = new System.Drawing.Size(113, 22);
            this.N3pa4.TabIndex = 8;
            this.N3pa4.Text = "SEPTUPLA";
            // 
            // N3pa2
            // 
            this.N3pa2.AutoSize = true;
            this.N3pa2.BackColor = System.Drawing.Color.Transparent;
            this.N3pa2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.N3pa2.ForeColor = System.Drawing.Color.White;
            this.N3pa2.Location = new System.Drawing.Point(1081, 266);
            this.N3pa2.Name = "N3pa2";
            this.N3pa2.Size = new System.Drawing.Size(49, 22);
            this.N3pa2.TabIndex = 8;
            this.N3pa2.Text = "AFD";
            // 
            // N3PIC1
            // 
            this.N3PIC1.BackColor = System.Drawing.Color.Transparent;
            this.N3PIC1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("N3PIC1.BackgroundImage")));
            this.N3PIC1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.N3PIC1.Location = new System.Drawing.Point(1017, 202);
            this.N3PIC1.Name = "N3PIC1";
            this.N3PIC1.Size = new System.Drawing.Size(46, 34);
            this.N3PIC1.TabIndex = 9;
            this.N3PIC1.TabStop = false;
            // 
            // N3PIC2
            // 
            this.N3PIC2.BackColor = System.Drawing.Color.Transparent;
            this.N3PIC2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("N3PIC2.BackgroundImage")));
            this.N3PIC2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.N3PIC2.Location = new System.Drawing.Point(1017, 254);
            this.N3PIC2.Name = "N3PIC2";
            this.N3PIC2.Size = new System.Drawing.Size(46, 34);
            this.N3PIC2.TabIndex = 9;
            this.N3PIC2.TabStop = false;
            // 
            // N3PIC3
            // 
            this.N3PIC3.BackColor = System.Drawing.Color.Transparent;
            this.N3PIC3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("N3PIC3.BackgroundImage")));
            this.N3PIC3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.N3PIC3.Location = new System.Drawing.Point(1017, 304);
            this.N3PIC3.Name = "N3PIC3";
            this.N3PIC3.Size = new System.Drawing.Size(46, 34);
            this.N3PIC3.TabIndex = 10;
            this.N3PIC3.TabStop = false;
            // 
            // N3PIC4
            // 
            this.N3PIC4.BackColor = System.Drawing.Color.Transparent;
            this.N3PIC4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("N3PIC4.BackgroundImage")));
            this.N3PIC4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.N3PIC4.Location = new System.Drawing.Point(1017, 354);
            this.N3PIC4.Name = "N3PIC4";
            this.N3PIC4.Size = new System.Drawing.Size(46, 34);
            this.N3PIC4.TabIndex = 10;
            this.N3PIC4.TabStop = false;
            // 
            // Tiempo
            // 
            this.Tiempo.BackColor = System.Drawing.Color.Transparent;
            this.Tiempo.Enabled = false;
            this.Tiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tiempo.ForeColor = System.Drawing.Color.Cyan;
            this.Tiempo.Location = new System.Drawing.Point(370, 18);
            this.Tiempo.Name = "Tiempo";
            this.Tiempo.Size = new System.Drawing.Size(246, 69);
            this.Tiempo.TabIndex = 11;
            this.Tiempo.Text = "---:---";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // terminar
            // 
            this.terminar.BackColor = System.Drawing.Color.Red;
            this.terminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.terminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.terminar.Location = new System.Drawing.Point(463, 645);
            this.terminar.Name = "terminar";
            this.terminar.Size = new System.Drawing.Size(237, 61);
            this.terminar.TabIndex = 12;
            this.terminar.Text = "SALIR";
            this.terminar.UseVisualStyleBackColor = false;
            this.terminar.Click += new System.EventHandler(this.terminar_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(215, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 69);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tiempo:";
            // 
            // Nivel3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1214, 733);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.terminar);
            this.Controls.Add(this.Tiempo);
            this.Controls.Add(this.N3PIC4);
            this.Controls.Add(this.N3PIC3);
            this.Controls.Add(this.N3PIC2);
            this.Controls.Add(this.N3PIC1);
            this.Controls.Add(this.N3pa4);
            this.Controls.Add(this.N3pa3);
            this.Controls.Add(this.N3pa2);
            this.Controls.Add(this.N3pa1);
            this.Controls.Add(this.Titulo2);
            this.Controls.Add(this.TablaN3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1230, 777);
            this.Name = "Nivel3";
            this.Text = "Nivel 3";
            this.Load += new System.EventHandler(this.Nivel3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TablaN3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.N3PIC1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.N3PIC2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.N3PIC3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.N3PIC4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TablaN3;
        private System.Windows.Forms.Label Titulo2;
        private System.Windows.Forms.Label N3pa1;
        private System.Windows.Forms.Label N3pa3;
        private System.Windows.Forms.Label N3pa4;
        private System.Windows.Forms.Label N3pa2;
        private System.Windows.Forms.PictureBox N3PIC1;
        private System.Windows.Forms.PictureBox N3PIC2;
        private System.Windows.Forms.PictureBox N3PIC3;
        private System.Windows.Forms.PictureBox N3PIC4;
        private System.Windows.Forms.Label Tiempo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button terminar;
        private System.Windows.Forms.Label label1;
    }
}