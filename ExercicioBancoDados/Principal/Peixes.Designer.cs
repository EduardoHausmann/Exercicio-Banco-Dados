namespace Principal
{
    partial class frmPeixes
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblRaca = new System.Windows.Forms.Label();
            this.cbRaca = new System.Windows.Forms.ComboBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.mtbPreco = new System.Windows.Forms.MaskedTextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.dgvPeixes = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeixes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(12, 9);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(66, 21);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(84, 9);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(19, 21);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "0";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(12, 43);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(55, 21);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(12, 67);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(165, 29);
            this.txtNome.TabIndex = 3;
            // 
            // lblRaca
            // 
            this.lblRaca.AutoSize = true;
            this.lblRaca.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRaca.Location = new System.Drawing.Point(12, 111);
            this.lblRaca.Name = "lblRaca";
            this.lblRaca.Size = new System.Drawing.Size(48, 21);
            this.lblRaca.TabIndex = 4;
            this.lblRaca.Text = "Raça";
            // 
            // cbRaca
            // 
            this.cbRaca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRaca.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRaca.FormattingEnabled = true;
            this.cbRaca.Items.AddRange(new object[] {
            "Tilapia",
            "Carpa",
            "Dourado",
            "Salmão",
            "Espada",
            "Robalo",
            "Baiacu",
            "Palhaço"});
            this.cbRaca.Location = new System.Drawing.Point(12, 135);
            this.cbRaca.Name = "cbRaca";
            this.cbRaca.Size = new System.Drawing.Size(165, 29);
            this.cbRaca.TabIndex = 5;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.Location = new System.Drawing.Point(12, 181);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(54, 21);
            this.lblPreco.TabIndex = 6;
            this.lblPreco.Text = "Preço";
            // 
            // mtbPreco
            // 
            this.mtbPreco.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbPreco.Location = new System.Drawing.Point(12, 205);
            this.mtbPreco.Name = "mtbPreco";
            this.mtbPreco.Size = new System.Drawing.Size(165, 29);
            this.mtbPreco.TabIndex = 7;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.Location = new System.Drawing.Point(12, 251);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(95, 21);
            this.lblQuantidade.TabIndex = 8;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(12, 323);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(72, 69);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.Location = new System.Drawing.Point(104, 323);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(72, 69);
            this.btnApagar.TabIndex = 10;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // dgvPeixes
            // 
            this.dgvPeixes.AllowUserToAddRows = false;
            this.dgvPeixes.AllowUserToDeleteRows = false;
            this.dgvPeixes.BackgroundColor = System.Drawing.Color.White;
            this.dgvPeixes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeixes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnNome,
            this.ColumnRaca,
            this.ColumnPreco,
            this.ColumnQuantidade});
            this.dgvPeixes.Location = new System.Drawing.Point(183, 67);
            this.dgvPeixes.Name = "dgvPeixes";
            this.dgvPeixes.ReadOnly = true;
            this.dgvPeixes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPeixes.Size = new System.Drawing.Size(443, 325);
            this.dgvPeixes.TabIndex = 11;
            this.dgvPeixes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPeixes_CellDoubleClick);
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "Código";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            this.ColumnId.Width = 50;
            // 
            // ColumnNome
            // 
            this.ColumnNome.HeaderText = "Nome";
            this.ColumnNome.Name = "ColumnNome";
            this.ColumnNome.ReadOnly = true;
            // 
            // ColumnRaca
            // 
            this.ColumnRaca.HeaderText = "Raça";
            this.ColumnRaca.Name = "ColumnRaca";
            this.ColumnRaca.ReadOnly = true;
            // 
            // ColumnPreco
            // 
            this.ColumnPreco.HeaderText = "Preço";
            this.ColumnPreco.Name = "ColumnPreco";
            this.ColumnPreco.ReadOnly = true;
            this.ColumnPreco.Width = 75;
            // 
            // ColumnQuantidade
            // 
            this.ColumnQuantidade.HeaderText = "Quantidade";
            this.ColumnQuantidade.Name = "ColumnQuantidade";
            this.ColumnQuantidade.ReadOnly = true;
            this.ColumnQuantidade.Width = 75;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidade.Location = new System.Drawing.Point(12, 275);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(164, 29);
            this.txtQuantidade.TabIndex = 12;
            // 
            // frmPeixes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(632, 400);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.dgvPeixes);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.mtbPreco);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.cbRaca);
            this.Controls.Add(this.lblRaca);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblCodigo);
            this.Name = "frmPeixes";
            this.Text = "Peixes";
            this.Load += new System.EventHandler(this.frmPeixes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeixes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblRaca;
        private System.Windows.Forms.ComboBox cbRaca;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.MaskedTextBox mtbPreco;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.DataGridView dgvPeixes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPreco;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQuantidade;
        private System.Windows.Forms.TextBox txtQuantidade;
    }
}