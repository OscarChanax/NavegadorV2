namespace NavegadorV2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.navegarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.haciaAtrásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.haciaDelanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fechaDeVisitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.másVisitadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxurl = new System.Windows.Forms.ComboBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelfecha = new System.Windows.Forms.Label();
            this.labelvisitado = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Chocolate;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(693, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Búsqueda";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.navegarToolStripMenuItem,
            this.historialToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(808, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // navegarToolStripMenuItem
            // 
            this.navegarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.haciaAtrásToolStripMenuItem,
            this.haciaDelanteToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.navegarToolStripMenuItem.Name = "navegarToolStripMenuItem";
            this.navegarToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.navegarToolStripMenuItem.Text = "Navegar";
            this.navegarToolStripMenuItem.Click += new System.EventHandler(this.navegarToolStripMenuItem_Click);
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // haciaAtrásToolStripMenuItem
            // 
            this.haciaAtrásToolStripMenuItem.Name = "haciaAtrásToolStripMenuItem";
            this.haciaAtrásToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.haciaAtrásToolStripMenuItem.Text = "Hacia atrás";
            this.haciaAtrásToolStripMenuItem.Click += new System.EventHandler(this.haciaAtrásToolStripMenuItem_Click);
            // 
            // haciaDelanteToolStripMenuItem
            // 
            this.haciaDelanteToolStripMenuItem.Name = "haciaDelanteToolStripMenuItem";
            this.haciaDelanteToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.haciaDelanteToolStripMenuItem.Text = "Hacia delante";
            this.haciaDelanteToolStripMenuItem.Click += new System.EventHandler(this.haciaDelanteToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // historialToolStripMenuItem
            // 
            this.historialToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fechaDeVisitaToolStripMenuItem,
            this.másVisitadoToolStripMenuItem});
            this.historialToolStripMenuItem.Name = "historialToolStripMenuItem";
            this.historialToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.historialToolStripMenuItem.Text = "Historial";
            this.historialToolStripMenuItem.Click += new System.EventHandler(this.historialToolStripMenuItem_Click);
            // 
            // fechaDeVisitaToolStripMenuItem
            // 
            this.fechaDeVisitaToolStripMenuItem.Name = "fechaDeVisitaToolStripMenuItem";
            this.fechaDeVisitaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fechaDeVisitaToolStripMenuItem.Text = "Fecha de visita";
            this.fechaDeVisitaToolStripMenuItem.Click += new System.EventHandler(this.fechaDeVisitaToolStripMenuItem_Click);
            // 
            // másVisitadoToolStripMenuItem
            // 
            this.másVisitadoToolStripMenuItem.Name = "másVisitadoToolStripMenuItem";
            this.másVisitadoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.másVisitadoToolStripMenuItem.Text = "Más visitado";
            this.másVisitadoToolStripMenuItem.Click += new System.EventHandler(this.másVisitadoToolStripMenuItem_Click);
            // 
            // comboBoxurl
            // 
            this.comboBoxurl.FormattingEnabled = true;
            this.comboBoxurl.Location = new System.Drawing.Point(12, 29);
            this.comboBoxurl.Name = "comboBoxurl";
            this.comboBoxurl.Size = new System.Drawing.Size(675, 21);
            this.comboBoxurl.TabIndex = 3;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 63);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(774, 376);
            this.webBrowser1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.SteelBlue;
            this.dataGridView1.Location = new System.Drawing.Point(100, 98);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Size = new System.Drawing.Size(656, 238);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // labelfecha
            // 
            this.labelfecha.AutoSize = true;
            this.labelfecha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfecha.ForeColor = System.Drawing.Color.White;
            this.labelfecha.Location = new System.Drawing.Point(329, 74);
            this.labelfecha.Name = "labelfecha";
            this.labelfecha.Size = new System.Drawing.Size(172, 21);
            this.labelfecha.TabIndex = 6;
            this.labelfecha.Text = "Ordenado por fecha";
            this.labelfecha.Click += new System.EventHandler(this.labelfecha_Click);
            // 
            // labelvisitado
            // 
            this.labelvisitado.AutoSize = true;
            this.labelvisitado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelvisitado.ForeColor = System.Drawing.Color.White;
            this.labelvisitado.Location = new System.Drawing.Point(291, 74);
            this.labelvisitado.Name = "labelvisitado";
            this.labelvisitado.Size = new System.Drawing.Size(261, 21);
            this.labelvisitado.TabIndex = 7;
            this.labelvisitado.Text = "Ordenado por número de visitas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(808, 450);
            this.Controls.Add(this.labelvisitado);
            this.Controls.Add(this.labelfecha);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.comboBoxurl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Navegador V2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem navegarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem haciaAtrásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem haciaDelanteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBoxurl;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ToolStripMenuItem historialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fechaDeVisitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem másVisitadoToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelfecha;
        private System.Windows.Forms.Label labelvisitado;
    }
}

