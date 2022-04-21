namespace WFmatDataGrid
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
            this.dataGridMatrix = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxM = new System.Windows.Forms.TextBox();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.buttonReadM = new System.Windows.Forms.Button();
            this.buttonInputM = new System.Windows.Forms.Button();
            this.buttonSize = new System.Windows.Forms.Button();
            this.listBoxMatrix = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMatrix)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridMatrix
            // 
            this.dataGridMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMatrix.ColumnHeadersVisible = false;
            this.dataGridMatrix.Location = new System.Drawing.Point(93, 76);
            this.dataGridMatrix.Name = "dataGridMatrix";
            this.dataGridMatrix.RowHeadersVisible = false;
            this.dataGridMatrix.Size = new System.Drawing.Size(240, 150);
            this.dataGridMatrix.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1016, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firmaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // firmaToolStripMenuItem
            // 
            this.firmaToolStripMenuItem.Name = "firmaToolStripMenuItem";
            this.firmaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.firmaToolStripMenuItem.Text = "Firma";
            this.firmaToolStripMenuItem.Click += new System.EventHandler(this.firmaToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // textBoxM
            // 
            this.textBoxM.Location = new System.Drawing.Point(124, 252);
            this.textBoxM.Name = "textBoxM";
            this.textBoxM.Size = new System.Drawing.Size(80, 20);
            this.textBoxM.TabIndex = 2;
            this.textBoxM.Text = "0";
            this.textBoxM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(230, 252);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(80, 20);
            this.textBoxN.TabIndex = 3;
            this.textBoxN.Text = "0";
            this.textBoxN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonReadM
            // 
            this.buttonReadM.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonReadM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReadM.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonReadM.Location = new System.Drawing.Point(376, 90);
            this.buttonReadM.Name = "buttonReadM";
            this.buttonReadM.Size = new System.Drawing.Size(96, 23);
            this.buttonReadM.TabIndex = 4;
            this.buttonReadM.Text = "Leer Matriz";
            this.buttonReadM.UseVisualStyleBackColor = false;
            this.buttonReadM.Click += new System.EventHandler(this.buttonReadM_Click);
            // 
            // buttonInputM
            // 
            this.buttonInputM.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonInputM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInputM.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonInputM.Location = new System.Drawing.Point(376, 134);
            this.buttonInputM.Name = "buttonInputM";
            this.buttonInputM.Size = new System.Drawing.Size(96, 25);
            this.buttonInputM.TabIndex = 5;
            this.buttonInputM.Text = "Introducir Matriz";
            this.buttonInputM.UseVisualStyleBackColor = false;
            this.buttonInputM.Click += new System.EventHandler(this.buttonInputM_Click);
            // 
            // buttonSize
            // 
            this.buttonSize.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSize.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSize.Location = new System.Drawing.Point(185, 292);
            this.buttonSize.Name = "buttonSize";
            this.buttonSize.Size = new System.Drawing.Size(61, 25);
            this.buttonSize.TabIndex = 6;
            this.buttonSize.Text = "Tamaño";
            this.buttonSize.UseVisualStyleBackColor = false;
            this.buttonSize.Click += new System.EventHandler(this.buttonSize_Click);
            // 
            // listBoxMatrix
            // 
            this.listBoxMatrix.FormattingEnabled = true;
            this.listBoxMatrix.Items.AddRange(new object[] {
            " "});
            this.listBoxMatrix.Location = new System.Drawing.Point(579, 76);
            this.listBoxMatrix.Name = "listBoxMatrix";
            this.listBoxMatrix.Size = new System.Drawing.Size(120, 95);
            this.listBoxMatrix.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 586);
            this.Controls.Add(this.listBoxMatrix);
            this.Controls.Add(this.buttonSize);
            this.Controls.Add(this.buttonInputM);
            this.Controls.Add(this.buttonReadM);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.textBoxM);
            this.Controls.Add(this.dataGridMatrix);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Matriz DataGrid";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMatrix)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridMatrix;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxM;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.Button buttonReadM;
        private System.Windows.Forms.Button buttonInputM;
        private System.Windows.Forms.Button buttonSize;
        private System.Windows.Forms.ListBox listBoxMatrix;
    }
}

