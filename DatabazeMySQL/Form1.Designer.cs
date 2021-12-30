
namespace DatabazeMySQL {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonVlozit = new System.Windows.Forms.Button();
            this.textBoxJmeno = new System.Windows.Forms.TextBox();
            this.textBoxPrijmeni = new System.Windows.Forms.TextBox();
            this.textBoxPohlavi = new System.Windows.Forms.TextBox();
            this.textBoxIdTrida = new System.Windows.Forms.TextBox();
            this.labelJmeno = new System.Windows.Forms.Label();
            this.labelPrijmeni = new System.Windows.Forms.Label();
            this.labelPohlavi = new System.Windows.Forms.Label();
            this.labelIdTrida = new System.Windows.Forms.Label();
            this.buttonVymazat = new System.Windows.Forms.Button();
            this.buttonZobrazit = new System.Windows.Forms.Button();
            this.buttonHledat = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonUpravit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeight = 25;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView.Location = new System.Drawing.Point(218, 15);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.ShowCellToolTips = false;
            this.dataGridView.ShowEditingIcon = false;
            this.dataGridView.ShowRowErrors = false;
            this.dataGridView.Size = new System.Drawing.Size(501, 526);
            this.dataGridView.TabIndex = 9;
            this.dataGridView.TabStop = false;
            // 
            // buttonVlozit
            // 
            this.buttonVlozit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonVlozit.Location = new System.Drawing.Point(67, 189);
            this.buttonVlozit.Name = "buttonVlozit";
            this.buttonVlozit.Size = new System.Drawing.Size(100, 30);
            this.buttonVlozit.TabIndex = 5;
            this.buttonVlozit.Text = "Vložit";
            this.buttonVlozit.UseVisualStyleBackColor = false;
            this.buttonVlozit.Click += new System.EventHandler(this.buttonVlozit_Click);
            // 
            // textBoxJmeno
            // 
            this.textBoxJmeno.Location = new System.Drawing.Point(67, 22);
            this.textBoxJmeno.Name = "textBoxJmeno";
            this.textBoxJmeno.Size = new System.Drawing.Size(100, 23);
            this.textBoxJmeno.TabIndex = 1;
            // 
            // textBoxPrijmeni
            // 
            this.textBoxPrijmeni.Location = new System.Drawing.Point(67, 62);
            this.textBoxPrijmeni.Name = "textBoxPrijmeni";
            this.textBoxPrijmeni.Size = new System.Drawing.Size(100, 23);
            this.textBoxPrijmeni.TabIndex = 2;
            // 
            // textBoxPohlavi
            // 
            this.textBoxPohlavi.Location = new System.Drawing.Point(67, 102);
            this.textBoxPohlavi.Name = "textBoxPohlavi";
            this.textBoxPohlavi.Size = new System.Drawing.Size(100, 23);
            this.textBoxPohlavi.TabIndex = 3;
            // 
            // textBoxIdTrida
            // 
            this.textBoxIdTrida.Location = new System.Drawing.Point(67, 141);
            this.textBoxIdTrida.Name = "textBoxIdTrida";
            this.textBoxIdTrida.Size = new System.Drawing.Size(100, 23);
            this.textBoxIdTrida.TabIndex = 4;
            // 
            // labelJmeno
            // 
            this.labelJmeno.AutoSize = true;
            this.labelJmeno.Location = new System.Drawing.Point(10, 25);
            this.labelJmeno.Name = "labelJmeno";
            this.labelJmeno.Size = new System.Drawing.Size(45, 15);
            this.labelJmeno.TabIndex = 6;
            this.labelJmeno.Text = "Jméno:";
            // 
            // labelPrijmeni
            // 
            this.labelPrijmeni.AutoSize = true;
            this.labelPrijmeni.Location = new System.Drawing.Point(9, 65);
            this.labelPrijmeni.Name = "labelPrijmeni";
            this.labelPrijmeni.Size = new System.Drawing.Size(54, 15);
            this.labelPrijmeni.TabIndex = 6;
            this.labelPrijmeni.Text = "Příjmení:";
            // 
            // labelPohlavi
            // 
            this.labelPohlavi.AutoSize = true;
            this.labelPohlavi.Location = new System.Drawing.Point(9, 105);
            this.labelPohlavi.Name = "labelPohlavi";
            this.labelPohlavi.Size = new System.Drawing.Size(49, 15);
            this.labelPohlavi.TabIndex = 6;
            this.labelPohlavi.Text = "Pohlaví:";
            // 
            // labelIdTrida
            // 
            this.labelIdTrida.AutoSize = true;
            this.labelIdTrida.Location = new System.Drawing.Point(9, 144);
            this.labelIdTrida.Name = "labelIdTrida";
            this.labelIdTrida.Size = new System.Drawing.Size(48, 15);
            this.labelIdTrida.TabIndex = 6;
            this.labelIdTrida.Text = "ID třída:";
            // 
            // buttonVymazat
            // 
            this.buttonVymazat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonVymazat.Location = new System.Drawing.Point(56, 109);
            this.buttonVymazat.Name = "buttonVymazat";
            this.buttonVymazat.Size = new System.Drawing.Size(100, 30);
            this.buttonVymazat.TabIndex = 10;
            this.buttonVymazat.Text = "Vymazat";
            this.buttonVymazat.UseVisualStyleBackColor = false;
            this.buttonVymazat.Click += new System.EventHandler(this.buttonVymazat_Click);
            // 
            // buttonZobrazit
            // 
            this.buttonZobrazit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonZobrazit.Location = new System.Drawing.Point(67, 288);
            this.buttonZobrazit.Name = "buttonZobrazit";
            this.buttonZobrazit.Size = new System.Drawing.Size(100, 30);
            this.buttonZobrazit.TabIndex = 7;
            this.buttonZobrazit.Text = "Zobrazit vše";
            this.buttonZobrazit.UseVisualStyleBackColor = false;
            this.buttonZobrazit.Click += new System.EventHandler(this.buttonZobrazit_Click);
            // 
            // buttonHledat
            // 
            this.buttonHledat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonHledat.Location = new System.Drawing.Point(67, 238);
            this.buttonHledat.Name = "buttonHledat";
            this.buttonHledat.Size = new System.Drawing.Size(100, 30);
            this.buttonHledat.TabIndex = 6;
            this.buttonHledat.Text = "Hledat";
            this.buttonHledat.UseVisualStyleBackColor = false;
            this.buttonHledat.Click += new System.EventHandler(this.buttonHledat_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(56, 18);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 23);
            this.textBoxID.TabIndex = 8;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(18, 21);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(21, 15);
            this.labelID.TabIndex = 8;
            this.labelID.Text = "ID:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.buttonUpravit);
            this.panel2.Controls.Add(this.textBoxID);
            this.panel2.Controls.Add(this.labelID);
            this.panel2.Controls.Add(this.buttonVymazat);
            this.panel2.Location = new System.Drawing.Point(13, 381);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(189, 160);
            this.panel2.TabIndex = 10;
            // 
            // buttonUpravit
            // 
            this.buttonUpravit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonUpravit.Location = new System.Drawing.Point(56, 61);
            this.buttonUpravit.Name = "buttonUpravit";
            this.buttonUpravit.Size = new System.Drawing.Size(100, 30);
            this.buttonUpravit.TabIndex = 9;
            this.buttonUpravit.Text = "Upravit";
            this.buttonUpravit.UseVisualStyleBackColor = false;
            this.buttonUpravit.Click += new System.EventHandler(this.buttonUpravit_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelJmeno);
            this.panel1.Controls.Add(this.buttonVlozit);
            this.panel1.Controls.Add(this.labelIdTrida);
            this.panel1.Controls.Add(this.buttonZobrazit);
            this.panel1.Controls.Add(this.labelPohlavi);
            this.panel1.Controls.Add(this.buttonHledat);
            this.panel1.Controls.Add(this.labelPrijmeni);
            this.panel1.Controls.Add(this.textBoxJmeno);
            this.panel1.Controls.Add(this.textBoxPrijmeni);
            this.panel1.Controls.Add(this.textBoxIdTrida);
            this.panel1.Controls.Add(this.textBoxPohlavi);
            this.panel1.Location = new System.Drawing.Point(13, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 345);
            this.panel1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 555);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(750, 594);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MySQL databáze";
            this.Load += new System.EventHandler(this.Form1_Load);            
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonVlozit;
        private System.Windows.Forms.TextBox textBoxJmeno;
        private System.Windows.Forms.TextBox textBoxPrijmeni;
        private System.Windows.Forms.TextBox textBoxPohlavi;
        private System.Windows.Forms.TextBox textBoxIdTrida;
        private System.Windows.Forms.Label labelJmeno;
        private System.Windows.Forms.Label labelPrijmeni;
        private System.Windows.Forms.Label labelPohlavi;
        private System.Windows.Forms.Label labelIdTrida;
        private System.Windows.Forms.Button buttonVymazat;
        private System.Windows.Forms.Button buttonZobrazit;
        private System.Windows.Forms.Button buttonHledat;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonUpravit;
        private System.Windows.Forms.Panel panel1;
    }
}

