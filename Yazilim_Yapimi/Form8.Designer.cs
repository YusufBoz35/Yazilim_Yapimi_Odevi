
namespace Yazilim_Yapimi
{
    partial class Form8
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.paraistekidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paraistekuserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paraistekmiktarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paraistekbirimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paraistekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finansDataSet3 = new Yazilim_Yapimi.finansDataSet3();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.urunistekidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunistekuserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunistektipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunistekmiktarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunistekbirimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunistekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finansDataSet4 = new Yazilim_Yapimi.finansDataSet4();
            this.BtnParaG = new System.Windows.Forms.Button();
            this.BtnParaS = new System.Windows.Forms.Button();
            this.BtnUrunS = new System.Windows.Forms.Button();
            this.BtnUrunG = new System.Windows.Forms.Button();
            this.para_istekTableAdapter = new Yazilim_Yapimi.finansDataSet3TableAdapters.para_istekTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.urun_istekTableAdapter = new Yazilim_Yapimi.finansDataSet4TableAdapters.urun_istekTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paraistekBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finansDataSet3)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunistekBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finansDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(52, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 307);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Para Ekleme İstekleri";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.paraistekidDataGridViewTextBoxColumn,
            this.paraistekuserDataGridViewTextBoxColumn,
            this.paraistekmiktarDataGridViewTextBoxColumn,
            this.paraistekbirimDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.paraistekBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(428, 281);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // paraistekidDataGridViewTextBoxColumn
            // 
            this.paraistekidDataGridViewTextBoxColumn.DataPropertyName = "para_istek_id";
            this.paraistekidDataGridViewTextBoxColumn.HeaderText = "id";
            this.paraistekidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.paraistekidDataGridViewTextBoxColumn.Name = "paraistekidDataGridViewTextBoxColumn";
            this.paraistekidDataGridViewTextBoxColumn.ReadOnly = true;
            this.paraistekidDataGridViewTextBoxColumn.Visible = false;
            this.paraistekidDataGridViewTextBoxColumn.Width = 40;
            // 
            // paraistekuserDataGridViewTextBoxColumn
            // 
            this.paraistekuserDataGridViewTextBoxColumn.DataPropertyName = "para_istek_user";
            this.paraistekuserDataGridViewTextBoxColumn.HeaderText = "Kullanıcı Adı";
            this.paraistekuserDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.paraistekuserDataGridViewTextBoxColumn.Name = "paraistekuserDataGridViewTextBoxColumn";
            this.paraistekuserDataGridViewTextBoxColumn.Width = 125;
            // 
            // paraistekmiktarDataGridViewTextBoxColumn
            // 
            this.paraistekmiktarDataGridViewTextBoxColumn.DataPropertyName = "para_istek_miktar";
            this.paraistekmiktarDataGridViewTextBoxColumn.HeaderText = "Miktar";
            this.paraistekmiktarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.paraistekmiktarDataGridViewTextBoxColumn.Name = "paraistekmiktarDataGridViewTextBoxColumn";
            this.paraistekmiktarDataGridViewTextBoxColumn.Width = 125;
            // 
            // paraistekbirimDataGridViewTextBoxColumn
            // 
            this.paraistekbirimDataGridViewTextBoxColumn.DataPropertyName = "para_istek_birim";
            this.paraistekbirimDataGridViewTextBoxColumn.HeaderText = "Para Birim";
            this.paraistekbirimDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.paraistekbirimDataGridViewTextBoxColumn.Name = "paraistekbirimDataGridViewTextBoxColumn";
            this.paraistekbirimDataGridViewTextBoxColumn.Width = 125;
            // 
            // paraistekBindingSource
            // 
            this.paraistekBindingSource.DataMember = "para_istek";
            this.paraistekBindingSource.DataSource = this.finansDataSet3;
            // 
            // finansDataSet3
            // 
            this.finansDataSet3.DataSetName = "finansDataSet3";
            this.finansDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Location = new System.Drawing.Point(546, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(514, 307);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün Ekleme İstekleri";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urunistekidDataGridViewTextBoxColumn,
            this.urunistekuserDataGridViewTextBoxColumn,
            this.urunistektipDataGridViewTextBoxColumn,
            this.urunistekmiktarDataGridViewTextBoxColumn,
            this.urunistekbirimDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.urunistekBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 23);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(508, 281);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            // 
            // urunistekidDataGridViewTextBoxColumn
            // 
            this.urunistekidDataGridViewTextBoxColumn.DataPropertyName = "urun_istek_id";
            this.urunistekidDataGridViewTextBoxColumn.HeaderText = "urun_istek_id";
            this.urunistekidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urunistekidDataGridViewTextBoxColumn.Name = "urunistekidDataGridViewTextBoxColumn";
            this.urunistekidDataGridViewTextBoxColumn.ReadOnly = true;
            this.urunistekidDataGridViewTextBoxColumn.Visible = false;
            this.urunistekidDataGridViewTextBoxColumn.Width = 125;
            // 
            // urunistekuserDataGridViewTextBoxColumn
            // 
            this.urunistekuserDataGridViewTextBoxColumn.DataPropertyName = "urun_istek_user";
            this.urunistekuserDataGridViewTextBoxColumn.HeaderText = "Kullanıcı Adı";
            this.urunistekuserDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urunistekuserDataGridViewTextBoxColumn.Name = "urunistekuserDataGridViewTextBoxColumn";
            this.urunistekuserDataGridViewTextBoxColumn.Width = 125;
            // 
            // urunistektipDataGridViewTextBoxColumn
            // 
            this.urunistektipDataGridViewTextBoxColumn.DataPropertyName = "urun_istek_tip";
            this.urunistektipDataGridViewTextBoxColumn.HeaderText = "Ürün Adı";
            this.urunistektipDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urunistektipDataGridViewTextBoxColumn.Name = "urunistektipDataGridViewTextBoxColumn";
            this.urunistektipDataGridViewTextBoxColumn.Width = 125;
            // 
            // urunistekmiktarDataGridViewTextBoxColumn
            // 
            this.urunistekmiktarDataGridViewTextBoxColumn.DataPropertyName = "urun_istek_miktar";
            this.urunistekmiktarDataGridViewTextBoxColumn.HeaderText = "İstek Miktarı";
            this.urunistekmiktarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urunistekmiktarDataGridViewTextBoxColumn.Name = "urunistekmiktarDataGridViewTextBoxColumn";
            this.urunistekmiktarDataGridViewTextBoxColumn.Width = 125;
            // 
            // urunistekbirimDataGridViewTextBoxColumn
            // 
            this.urunistekbirimDataGridViewTextBoxColumn.DataPropertyName = "urun_istek_birim";
            this.urunistekbirimDataGridViewTextBoxColumn.HeaderText = "Urun Birim";
            this.urunistekbirimDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urunistekbirimDataGridViewTextBoxColumn.Name = "urunistekbirimDataGridViewTextBoxColumn";
            this.urunistekbirimDataGridViewTextBoxColumn.Width = 80;
            // 
            // urunistekBindingSource
            // 
            this.urunistekBindingSource.DataMember = "urun_istek";
            this.urunistekBindingSource.DataSource = this.finansDataSet4;
            // 
            // finansDataSet4
            // 
            this.finansDataSet4.DataSetName = "finansDataSet4";
            this.finansDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BtnParaG
            // 
            this.BtnParaG.Location = new System.Drawing.Point(52, 395);
            this.BtnParaG.Name = "BtnParaG";
            this.BtnParaG.Size = new System.Drawing.Size(166, 38);
            this.BtnParaG.TabIndex = 2;
            this.BtnParaG.Text = "Güncelle";
            this.BtnParaG.UseVisualStyleBackColor = true;
            this.BtnParaG.Click += new System.EventHandler(this.BtnParaG_Click);
            // 
            // BtnParaS
            // 
            this.BtnParaS.Location = new System.Drawing.Point(317, 395);
            this.BtnParaS.Name = "BtnParaS";
            this.BtnParaS.Size = new System.Drawing.Size(166, 38);
            this.BtnParaS.TabIndex = 3;
            this.BtnParaS.Text = "Sil";
            this.BtnParaS.UseVisualStyleBackColor = true;
            this.BtnParaS.Click += new System.EventHandler(this.BtnParaS_Click);
            // 
            // BtnUrunS
            // 
            this.BtnUrunS.Location = new System.Drawing.Point(905, 395);
            this.BtnUrunS.Name = "BtnUrunS";
            this.BtnUrunS.Size = new System.Drawing.Size(152, 38);
            this.BtnUrunS.TabIndex = 5;
            this.BtnUrunS.Text = "Sil";
            this.BtnUrunS.UseVisualStyleBackColor = true;
            this.BtnUrunS.Click += new System.EventHandler(this.BtnUrunS_Click);
            // 
            // BtnUrunG
            // 
            this.BtnUrunG.Location = new System.Drawing.Point(546, 395);
            this.BtnUrunG.Name = "BtnUrunG";
            this.BtnUrunG.Size = new System.Drawing.Size(153, 38);
            this.BtnUrunG.TabIndex = 4;
            this.BtnUrunG.Text = "Güncelle";
            this.BtnUrunG.UseVisualStyleBackColor = true;
            this.BtnUrunG.Click += new System.EventHandler(this.BtnUrunG_Click);
            // 
            // para_istekTableAdapter
            // 
            this.para_istekTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(977, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "Çıkış";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // urun_istekTableAdapter
            // 
            this.urun_istekTableAdapter.ClearBeforeFill = true;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1112, 520);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnUrunS);
            this.Controls.Add(this.BtnUrunG);
            this.Controls.Add(this.BtnParaS);
            this.Controls.Add(this.BtnParaG);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Form8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.Form8_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paraistekBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finansDataSet3)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunistekBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finansDataSet4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button BtnParaG;
        private System.Windows.Forms.Button BtnParaS;
        private System.Windows.Forms.Button BtnUrunS;
        private System.Windows.Forms.Button BtnUrunG;
        private finansDataSet3 finansDataSet3;
        private System.Windows.Forms.BindingSource paraistekBindingSource;
        private finansDataSet3TableAdapters.para_istekTableAdapter para_istekTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn paraistekidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paraistekuserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paraistekmiktarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paraistekbirimDataGridViewTextBoxColumn;
        private finansDataSet4 finansDataSet4;
        private System.Windows.Forms.BindingSource urunistekBindingSource;
        private finansDataSet4TableAdapters.urun_istekTableAdapter urun_istekTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunistekidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunistekuserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunistektipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunistekmiktarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunistekbirimDataGridViewTextBoxColumn;
    }
}