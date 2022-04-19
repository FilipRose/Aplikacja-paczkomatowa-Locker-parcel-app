
namespace Ostatecznietotenforms
{
    partial class admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin));
            this.btnWylog = new System.Windows.Forms.Button();
            this.btnPokUz = new System.Windows.Forms.Button();
            this.btnGenR = new System.Windows.Forms.Button();
            this.btnUStat = new System.Windows.Forms.Button();
            this.statZam = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKod = new System.Windows.Forms.TextBox();
            this.btn_Ustaw = new System.Windows.Forms.Button();
            this.txtStat = new System.Windows.Forms.TextBox();
            this.pokatabele = new System.Windows.Forms.DataGridView();
            this.idKlientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwiskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrtelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nickDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hasloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serwis_ZarzadzajacyDataSet3 = new Ostatecznietotenforms.Serwis_ZarzadzajacyDataSet3();
            this.serwis_ZarzadzajacyDataSet = new Ostatecznietotenforms.Serwis_ZarzadzajacyDataSet();
            this.serwisZarzadzajacyDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klientTableAdapter = new Ostatecznietotenforms.Serwis_ZarzadzajacyDataSet3TableAdapters.KlientTableAdapter();
            this.btnDel = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.statZam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pokatabele)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serwis_ZarzadzajacyDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serwis_ZarzadzajacyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serwisZarzadzajacyDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnWylog
            // 
            this.btnWylog.BackColor = System.Drawing.Color.ForestGreen;
            this.btnWylog.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWylog.ForeColor = System.Drawing.Color.Gold;
            this.btnWylog.Location = new System.Drawing.Point(458, 611);
            this.btnWylog.Name = "btnWylog";
            this.btnWylog.Size = new System.Drawing.Size(75, 23);
            this.btnWylog.TabIndex = 0;
            this.btnWylog.Text = "Wyloguj";
            this.btnWylog.UseVisualStyleBackColor = false;
            this.btnWylog.Click += new System.EventHandler(this.btnWylog_Click);
            // 
            // btnPokUz
            // 
            this.btnPokUz.BackColor = System.Drawing.Color.ForestGreen;
            this.btnPokUz.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPokUz.ForeColor = System.Drawing.Color.Gold;
            this.btnPokUz.Location = new System.Drawing.Point(420, 12);
            this.btnPokUz.Name = "btnPokUz";
            this.btnPokUz.Size = new System.Drawing.Size(122, 23);
            this.btnPokUz.TabIndex = 1;
            this.btnPokUz.Text = "Pokaz dane";
            this.btnPokUz.UseVisualStyleBackColor = false;
            this.btnPokUz.Click += new System.EventHandler(this.btnPokUz_Click);
            // 
            // btnGenR
            // 
            this.btnGenR.BackColor = System.Drawing.Color.ForestGreen;
            this.btnGenR.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenR.ForeColor = System.Drawing.Color.Gold;
            this.btnGenR.Location = new System.Drawing.Point(399, 549);
            this.btnGenR.Name = "btnGenR";
            this.btnGenR.Size = new System.Drawing.Size(122, 23);
            this.btnGenR.TabIndex = 2;
            this.btnGenR.Text = "Generuj Raport";
            this.btnGenR.UseVisualStyleBackColor = false;
            this.btnGenR.Click += new System.EventHandler(this.btnGenR_Click);
            // 
            // btnUStat
            // 
            this.btnUStat.BackColor = System.Drawing.Color.ForestGreen;
            this.btnUStat.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUStat.ForeColor = System.Drawing.Color.Gold;
            this.btnUStat.Location = new System.Drawing.Point(420, 35);
            this.btnUStat.Name = "btnUStat";
            this.btnUStat.Size = new System.Drawing.Size(122, 23);
            this.btnUStat.TabIndex = 3;
            this.btnUStat.Text = "Ustaw status";
            this.btnUStat.UseVisualStyleBackColor = false;
            this.btnUStat.Click += new System.EventHandler(this.btnUStat_Click);
            // 
            // statZam
            // 
            this.statZam.Controls.Add(this.label1);
            this.statZam.Controls.Add(this.label5);
            this.statZam.Controls.Add(this.txtKod);
            this.statZam.Controls.Add(this.btn_Ustaw);
            this.statZam.Controls.Add(this.txtStat);
            this.statZam.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statZam.ForeColor = System.Drawing.Color.Gold;
            this.statZam.Location = new System.Drawing.Point(12, 12);
            this.statZam.Name = "statZam";
            this.statZam.Size = new System.Drawing.Size(407, 143);
            this.statZam.TabIndex = 4;
            this.statZam.TabStop = false;
            this.statZam.Text = "Status Zamówienia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 14);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nadaj status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 14);
            this.label5.TabIndex = 16;
            this.label5.Text = "Nr. zamowienia";
            // 
            // txtKod
            // 
            this.txtKod.Location = new System.Drawing.Point(14, 49);
            this.txtKod.Name = "txtKod";
            this.txtKod.Size = new System.Drawing.Size(217, 21);
            this.txtKod.TabIndex = 10;
            // 
            // btn_Ustaw
            // 
            this.btn_Ustaw.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_Ustaw.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ustaw.ForeColor = System.Drawing.Color.Gold;
            this.btn_Ustaw.Location = new System.Drawing.Point(218, 114);
            this.btn_Ustaw.Name = "btn_Ustaw";
            this.btn_Ustaw.Size = new System.Drawing.Size(183, 23);
            this.btn_Ustaw.TabIndex = 9;
            this.btn_Ustaw.Text = "Ustawa status zamówienia";
            this.btn_Ustaw.UseVisualStyleBackColor = false;
            this.btn_Ustaw.Click += new System.EventHandler(this.btn_Ustaw_Click);
            // 
            // txtStat
            // 
            this.txtStat.Location = new System.Drawing.Point(14, 87);
            this.txtStat.Name = "txtStat";
            this.txtStat.Size = new System.Drawing.Size(217, 21);
            this.txtStat.TabIndex = 8;
            // 
            // pokatabele
            // 
            this.pokatabele.AutoGenerateColumns = false;
            this.pokatabele.BackgroundColor = System.Drawing.Color.ForestGreen;
            this.pokatabele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pokatabele.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idKlientDataGridViewTextBoxColumn,
            this.imieDataGridViewTextBoxColumn,
            this.nazwiskoDataGridViewTextBoxColumn,
            this.nrtelDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn,
            this.nickDataGridViewTextBoxColumn,
            this.hasloDataGridViewTextBoxColumn});
            this.pokatabele.DataSource = this.klientBindingSource;
            this.pokatabele.Location = new System.Drawing.Point(26, 178);
            this.pokatabele.Name = "pokatabele";
            this.pokatabele.Size = new System.Drawing.Size(484, 365);
            this.pokatabele.TabIndex = 5;
            // 
            // idKlientDataGridViewTextBoxColumn
            // 
            this.idKlientDataGridViewTextBoxColumn.DataPropertyName = "idKlient";
            this.idKlientDataGridViewTextBoxColumn.HeaderText = "idKlient";
            this.idKlientDataGridViewTextBoxColumn.Name = "idKlientDataGridViewTextBoxColumn";
            this.idKlientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imieDataGridViewTextBoxColumn
            // 
            this.imieDataGridViewTextBoxColumn.DataPropertyName = "Imie";
            this.imieDataGridViewTextBoxColumn.HeaderText = "Imie";
            this.imieDataGridViewTextBoxColumn.Name = "imieDataGridViewTextBoxColumn";
            // 
            // nazwiskoDataGridViewTextBoxColumn
            // 
            this.nazwiskoDataGridViewTextBoxColumn.DataPropertyName = "Nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.HeaderText = "Nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.Name = "nazwiskoDataGridViewTextBoxColumn";
            // 
            // nrtelDataGridViewTextBoxColumn
            // 
            this.nrtelDataGridViewTextBoxColumn.DataPropertyName = "Nr_tel";
            this.nrtelDataGridViewTextBoxColumn.HeaderText = "Nr_tel";
            this.nrtelDataGridViewTextBoxColumn.Name = "nrtelDataGridViewTextBoxColumn";
            // 
            // mailDataGridViewTextBoxColumn
            // 
            this.mailDataGridViewTextBoxColumn.DataPropertyName = "Mail";
            this.mailDataGridViewTextBoxColumn.HeaderText = "Mail";
            this.mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            // 
            // nickDataGridViewTextBoxColumn
            // 
            this.nickDataGridViewTextBoxColumn.DataPropertyName = "Nick";
            this.nickDataGridViewTextBoxColumn.HeaderText = "Nick";
            this.nickDataGridViewTextBoxColumn.Name = "nickDataGridViewTextBoxColumn";
            // 
            // hasloDataGridViewTextBoxColumn
            // 
            this.hasloDataGridViewTextBoxColumn.DataPropertyName = "Haslo";
            this.hasloDataGridViewTextBoxColumn.HeaderText = "Haslo";
            this.hasloDataGridViewTextBoxColumn.Name = "hasloDataGridViewTextBoxColumn";
            // 
            // klientBindingSource
            // 
            this.klientBindingSource.DataMember = "Klient";
            this.klientBindingSource.DataSource = this.serwis_ZarzadzajacyDataSet3;
            // 
            // serwis_ZarzadzajacyDataSet3
            // 
            this.serwis_ZarzadzajacyDataSet3.DataSetName = "Serwis_ZarzadzajacyDataSet3";
            this.serwis_ZarzadzajacyDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // serwis_ZarzadzajacyDataSet
            // 
            this.serwis_ZarzadzajacyDataSet.DataSetName = "Serwis_ZarzadzajacyDataSet";
            this.serwis_ZarzadzajacyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // serwisZarzadzajacyDataSetBindingSource
            // 
            this.serwisZarzadzajacyDataSetBindingSource.DataSource = this.serwis_ZarzadzajacyDataSet;
            this.serwisZarzadzajacyDataSetBindingSource.Position = 0;
            // 
            // klientTableAdapter
            // 
            this.klientTableAdapter.ClearBeforeFill = true;
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.ForestGreen;
            this.btnDel.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.ForeColor = System.Drawing.Color.Gold;
            this.btnDel.Location = new System.Drawing.Point(271, 549);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(122, 23);
            this.btnDel.TabIndex = 6;
            this.btnDel.Text = "Usun Dane";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(204, 552);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(61, 20);
            this.txtId.TabIndex = 7;
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(545, 646);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.pokatabele);
            this.Controls.Add(this.statZam);
            this.Controls.Add(this.btnUStat);
            this.Controls.Add(this.btnGenR);
            this.Controls.Add(this.btnPokUz);
            this.Controls.Add(this.btnWylog);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel Administratora";
            this.Load += new System.EventHandler(this.admin_Load);
            this.statZam.ResumeLayout(false);
            this.statZam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pokatabele)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serwis_ZarzadzajacyDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serwis_ZarzadzajacyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serwisZarzadzajacyDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWylog;
        private System.Windows.Forms.Button btnPokUz;
        private System.Windows.Forms.Button btnGenR;
        private System.Windows.Forms.Button btnUStat;
        private System.Windows.Forms.GroupBox statZam;
        private System.Windows.Forms.DataGridView pokatabele;
        private System.Windows.Forms.BindingSource serwisZarzadzajacyDataSetBindingSource;
        private Serwis_ZarzadzajacyDataSet serwis_ZarzadzajacyDataSet;
        private Serwis_ZarzadzajacyDataSet3 serwis_ZarzadzajacyDataSet3;
        private System.Windows.Forms.BindingSource klientBindingSource;
        private Serwis_ZarzadzajacyDataSet3TableAdapters.KlientTableAdapter klientTableAdapter;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.DataGridViewTextBoxColumn idKlientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwiskoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrtelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nickDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hasloDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtKod;
        private System.Windows.Forms.Button btn_Ustaw;
        private System.Windows.Forms.TextBox txtStat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}