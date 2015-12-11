namespace Algoritma
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.main_panel = new System.Windows.Forms.Panel();
            this.propertPanel = new System.Windows.Forms.Panel();
            this.tabControlProperti = new System.Windows.Forms.TabControl();
            this.tapOzellikler = new System.Windows.Forms.TabPage();
            this.btnBaglantiSil = new System.Windows.Forms.Button();
            this.btnBagla = new System.Windows.Forms.Button();
            this.cbOtoBagla = new System.Windows.Forms.CheckBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblYapilacakIslem = new System.Windows.Forms.Label();
            this.cbGoruntulenecekDegisken = new System.Windows.Forms.ComboBox();
            this.txtYapilacakIslem = new System.Windows.Forms.TextBox();
            this.lblGoruntulenecekDegisken = new System.Windows.Forms.Label();
            this.txtGoruntulenecekMetin = new System.Windows.Forms.TextBox();
            this.lbltGoruntulenecekMetin = new System.Windows.Forms.Label();
            this.tabDegiskenler = new System.Windows.Forms.TabPage();
            this.Degiskenler = new System.Windows.Forms.DataGridView();
            this.col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cop_panel = new System.Windows.Forms.Panel();
            this.Cop_pictureBox = new System.Windows.Forms.PictureBox();
            this.tools_panel = new System.Windows.Forms.Panel();
            this.btnDegiskenIzle = new System.Windows.Forms.Button();
            this.btnfor = new System.Windows.Forms.Button();
            this.btnDur = new System.Windows.Forms.Button();
            this.btnDugum = new System.Windows.Forms.Button();
            this.btnBekle = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnEger = new System.Windows.Forms.Button();
            this.btnGiris = new System.Windows.Forms.Button();
            this.btnIslem = new System.Windows.Forms.Button();
            this.btnDegisken = new System.Windows.Forms.Button();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.top_panel = new System.Windows.Forms.Panel();
            this.lblHiz = new System.Windows.Forms.Label();
            this.trackBarHiz = new System.Windows.Forms.TrackBar();
            this.btnAc = new System.Windows.Forms.Button();
            this.btnYeni = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnDevamEt = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.main_panel.SuspendLayout();
            this.propertPanel.SuspendLayout();
            this.tabControlProperti.SuspendLayout();
            this.tapOzellikler.SuspendLayout();
            this.tabDegiskenler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Degiskenler)).BeginInit();
            this.cop_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cop_pictureBox)).BeginInit();
            this.tools_panel.SuspendLayout();
            this.top_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHiz)).BeginInit();
            this.SuspendLayout();
            // 
            // main_panel
            // 
            this.main_panel.BackColor = System.Drawing.Color.White;
            this.main_panel.Controls.Add(this.propertPanel);
            this.main_panel.Controls.Add(this.cop_panel);
            this.main_panel.Controls.Add(this.tools_panel);
            this.main_panel.Controls.Add(this.top_panel);
            this.main_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_panel.Location = new System.Drawing.Point(0, 0);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(964, 708);
            this.main_panel.TabIndex = 1;
            this.main_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.main_panel_Paint);
            // 
            // propertPanel
            // 
            this.propertPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propertPanel.BackColor = System.Drawing.Color.Silver;
            this.propertPanel.Controls.Add(this.tabControlProperti);
            this.propertPanel.Location = new System.Drawing.Point(722, 251);
            this.propertPanel.Name = "propertPanel";
            this.propertPanel.Size = new System.Drawing.Size(242, 456);
            this.propertPanel.TabIndex = 3;
            // 
            // tabControlProperti
            // 
            this.tabControlProperti.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlProperti.Controls.Add(this.tapOzellikler);
            this.tabControlProperti.Controls.Add(this.tabDegiskenler);
            this.tabControlProperti.Location = new System.Drawing.Point(0, 3);
            this.tabControlProperti.Name = "tabControlProperti";
            this.tabControlProperti.SelectedIndex = 0;
            this.tabControlProperti.Size = new System.Drawing.Size(242, 451);
            this.tabControlProperti.TabIndex = 0;
            this.tabControlProperti.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControlProperti_Selecting);
            // 
            // tapOzellikler
            // 
            this.tapOzellikler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tapOzellikler.Controls.Add(this.btnBaglantiSil);
            this.tapOzellikler.Controls.Add(this.btnBagla);
            this.tapOzellikler.Controls.Add(this.cbOtoBagla);
            this.tapOzellikler.Controls.Add(this.txtHeight);
            this.tapOzellikler.Controls.Add(this.txtWidth);
            this.tapOzellikler.Controls.Add(this.label2);
            this.tapOzellikler.Controls.Add(this.label1);
            this.tapOzellikler.Controls.Add(this.lblYapilacakIslem);
            this.tapOzellikler.Controls.Add(this.cbGoruntulenecekDegisken);
            this.tapOzellikler.Controls.Add(this.txtYapilacakIslem);
            this.tapOzellikler.Controls.Add(this.lblGoruntulenecekDegisken);
            this.tapOzellikler.Controls.Add(this.txtGoruntulenecekMetin);
            this.tapOzellikler.Controls.Add(this.lbltGoruntulenecekMetin);
            this.tapOzellikler.Location = new System.Drawing.Point(4, 22);
            this.tapOzellikler.Name = "tapOzellikler";
            this.tapOzellikler.Padding = new System.Windows.Forms.Padding(3);
            this.tapOzellikler.Size = new System.Drawing.Size(234, 425);
            this.tapOzellikler.TabIndex = 0;
            this.tapOzellikler.Text = "  Özellikler";
            // 
            // btnBaglantiSil
            // 
            this.btnBaglantiSil.Location = new System.Drawing.Point(129, 373);
            this.btnBaglantiSil.Name = "btnBaglantiSil";
            this.btnBaglantiSil.Size = new System.Drawing.Size(92, 30);
            this.btnBaglantiSil.TabIndex = 12;
            this.btnBaglantiSil.Text = "Bağlantı Sil";
            this.btnBaglantiSil.UseVisualStyleBackColor = true;
            this.btnBaglantiSil.Click += new System.EventHandler(this.btnBaglantiSil_Click);
            // 
            // btnBagla
            // 
            this.btnBagla.Location = new System.Drawing.Point(18, 373);
            this.btnBagla.Name = "btnBagla";
            this.btnBagla.Size = new System.Drawing.Size(98, 31);
            this.btnBagla.TabIndex = 11;
            this.btnBagla.Text = "Bağla";
            this.btnBagla.UseVisualStyleBackColor = true;
            this.btnBagla.Click += new System.EventHandler(this.btnBagla_Click);
            // 
            // cbOtoBagla
            // 
            this.cbOtoBagla.AutoSize = true;
            this.cbOtoBagla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbOtoBagla.Location = new System.Drawing.Point(20, 341);
            this.cbOtoBagla.Name = "cbOtoBagla";
            this.cbOtoBagla.Size = new System.Drawing.Size(135, 24);
            this.cbOtoBagla.TabIndex = 10;
            this.cbOtoBagla.Text = "Otomatik bağla";
            this.cbOtoBagla.UseVisualStyleBackColor = true;
            // 
            // txtHeight
            // 
            this.txtHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtHeight.Location = new System.Drawing.Point(91, 307);
            this.txtHeight.MaxLength = 3;
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.ShortcutsEnabled = false;
            this.txtHeight.Size = new System.Drawing.Size(121, 26);
            this.txtHeight.TabIndex = 9;
            this.txtHeight.TextChanged += new System.EventHandler(this.txtHeight_TextChanged);
            this.txtHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHeight_KeyPress);
            // 
            // txtWidth
            // 
            this.txtWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtWidth.Location = new System.Drawing.Point(89, 271);
            this.txtWidth.MaxLength = 3;
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.ShortcutsEnabled = false;
            this.txtWidth.Size = new System.Drawing.Size(121, 26);
            this.txtWidth.TabIndex = 8;
            this.txtWidth.TextChanged += new System.EventHandler(this.txtWidth_TextChanged);
            this.txtWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWidth_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(16, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Height   :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(16, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Width   :";
            // 
            // lblYapilacakIslem
            // 
            this.lblYapilacakIslem.AutoSize = true;
            this.lblYapilacakIslem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYapilacakIslem.Location = new System.Drawing.Point(16, 166);
            this.lblYapilacakIslem.Name = "lblYapilacakIslem";
            this.lblYapilacakIslem.Size = new System.Drawing.Size(120, 20);
            this.lblYapilacakIslem.TabIndex = 5;
            this.lblYapilacakIslem.Text = "Yapılacak İşlem";
            // 
            // cbGoruntulenecekDegisken
            // 
            this.cbGoruntulenecekDegisken.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbGoruntulenecekDegisken.FormattingEnabled = true;
            this.cbGoruntulenecekDegisken.Location = new System.Drawing.Point(16, 128);
            this.cbGoruntulenecekDegisken.Name = "cbGoruntulenecekDegisken";
            this.cbGoruntulenecekDegisken.Size = new System.Drawing.Size(207, 28);
            this.cbGoruntulenecekDegisken.TabIndex = 4;
            this.cbGoruntulenecekDegisken.SelectedIndexChanged += new System.EventHandler(this.cbGoruntulenecekDegisken_SelectedIndexChanged);
            // 
            // txtYapilacakIslem
            // 
            this.txtYapilacakIslem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYapilacakIslem.Location = new System.Drawing.Point(15, 192);
            this.txtYapilacakIslem.Multiline = true;
            this.txtYapilacakIslem.Name = "txtYapilacakIslem";
            this.txtYapilacakIslem.Size = new System.Drawing.Size(207, 66);
            this.txtYapilacakIslem.TabIndex = 3;
            this.txtYapilacakIslem.TextChanged += new System.EventHandler(this.txtYapilacakIslem_TextChanged);
            // 
            // lblGoruntulenecekDegisken
            // 
            this.lblGoruntulenecekDegisken.AutoSize = true;
            this.lblGoruntulenecekDegisken.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGoruntulenecekDegisken.Location = new System.Drawing.Point(12, 105);
            this.lblGoruntulenecekDegisken.Name = "lblGoruntulenecekDegisken";
            this.lblGoruntulenecekDegisken.Size = new System.Drawing.Size(194, 20);
            this.lblGoruntulenecekDegisken.TabIndex = 2;
            this.lblGoruntulenecekDegisken.Text = "Görüntülenecek Değişken";
            // 
            // txtGoruntulenecekMetin
            // 
            this.txtGoruntulenecekMetin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGoruntulenecekMetin.Location = new System.Drawing.Point(14, 32);
            this.txtGoruntulenecekMetin.Multiline = true;
            this.txtGoruntulenecekMetin.Name = "txtGoruntulenecekMetin";
            this.txtGoruntulenecekMetin.Size = new System.Drawing.Size(207, 66);
            this.txtGoruntulenecekMetin.TabIndex = 1;
            this.txtGoruntulenecekMetin.TextChanged += new System.EventHandler(this.txtGoruntulenecekMetin_TextChanged);
            // 
            // lbltGoruntulenecekMetin
            // 
            this.lbltGoruntulenecekMetin.AutoSize = true;
            this.lbltGoruntulenecekMetin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltGoruntulenecekMetin.Location = new System.Drawing.Point(14, 7);
            this.lbltGoruntulenecekMetin.Name = "lbltGoruntulenecekMetin";
            this.lbltGoruntulenecekMetin.Size = new System.Drawing.Size(166, 20);
            this.lbltGoruntulenecekMetin.TabIndex = 0;
            this.lbltGoruntulenecekMetin.Text = "Görüntülenecek Metin";
            // 
            // tabDegiskenler
            // 
            this.tabDegiskenler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabDegiskenler.Controls.Add(this.Degiskenler);
            this.tabDegiskenler.Location = new System.Drawing.Point(4, 22);
            this.tabDegiskenler.Name = "tabDegiskenler";
            this.tabDegiskenler.Padding = new System.Windows.Forms.Padding(3);
            this.tabDegiskenler.Size = new System.Drawing.Size(234, 425);
            this.tabDegiskenler.TabIndex = 1;
            this.tabDegiskenler.Text = "Değişkenler";
            // 
            // Degiskenler
            // 
            this.Degiskenler.AllowUserToDeleteRows = false;
            this.Degiskenler.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Degiskenler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Degiskenler.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Degiskenler.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Degiskenler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Degiskenler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Degiskenler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col1,
            this.col2});
            this.Degiskenler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Degiskenler.Location = new System.Drawing.Point(3, 3);
            this.Degiskenler.Name = "Degiskenler";
            this.Degiskenler.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Degiskenler.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Degiskenler.RowHeadersVisible = false;
            this.Degiskenler.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Degiskenler.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Degiskenler.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.Degiskenler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Degiskenler.ShowCellToolTips = false;
            this.Degiskenler.Size = new System.Drawing.Size(228, 419);
            this.Degiskenler.TabIndex = 0;
            // 
            // col1
            // 
            this.col1.FillWeight = 50F;
            this.col1.HeaderText = "Değişken";
            this.col1.MinimumWidth = 125;
            this.col1.Name = "col1";
            this.col1.ReadOnly = true;
            this.col1.Width = 125;
            // 
            // col2
            // 
            this.col2.DividerWidth = 2;
            this.col2.HeaderText = "Değeri";
            this.col2.MinimumWidth = 150;
            this.col2.Name = "col2";
            this.col2.ReadOnly = true;
            this.col2.Width = 150;
            // 
            // cop_panel
            // 
            this.cop_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cop_panel.BackColor = System.Drawing.Color.Silver;
            this.cop_panel.Controls.Add(this.Cop_pictureBox);
            this.cop_panel.Location = new System.Drawing.Point(722, 54);
            this.cop_panel.Name = "cop_panel";
            this.cop_panel.Size = new System.Drawing.Size(242, 197);
            this.cop_panel.TabIndex = 2;
            // 
            // Cop_pictureBox
            // 
            this.Cop_pictureBox.Image = global::Algoritma.Properties.Resources.canclosed;
            this.Cop_pictureBox.Location = new System.Drawing.Point(77, 58);
            this.Cop_pictureBox.Name = "Cop_pictureBox";
            this.Cop_pictureBox.Size = new System.Drawing.Size(100, 94);
            this.Cop_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Cop_pictureBox.TabIndex = 0;
            this.Cop_pictureBox.TabStop = false;
            // 
            // tools_panel
            // 
            this.tools_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tools_panel.BackColor = System.Drawing.Color.Silver;
            this.tools_panel.Controls.Add(this.btnDegiskenIzle);
            this.tools_panel.Controls.Add(this.btnfor);
            this.tools_panel.Controls.Add(this.btnDur);
            this.tools_panel.Controls.Add(this.btnDugum);
            this.tools_panel.Controls.Add(this.btnBekle);
            this.tools_panel.Controls.Add(this.btnCikis);
            this.tools_panel.Controls.Add(this.btnEger);
            this.tools_panel.Controls.Add(this.btnGiris);
            this.tools_panel.Controls.Add(this.btnIslem);
            this.tools_panel.Controls.Add(this.btnDegisken);
            this.tools_panel.Controls.Add(this.btnBaslat);
            this.tools_panel.Location = new System.Drawing.Point(1, 54);
            this.tools_panel.Name = "tools_panel";
            this.tools_panel.Size = new System.Drawing.Size(148, 654);
            this.tools_panel.TabIndex = 1;
            // 
            // btnDegiskenIzle
            // 
            this.btnDegiskenIzle.BackColor = System.Drawing.Color.White;
            this.btnDegiskenIzle.BackgroundImage = global::Algoritma.Properties.Resources.degiskenIzle;
            this.btnDegiskenIzle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDegiskenIzle.Location = new System.Drawing.Point(5, 532);
            this.btnDegiskenIzle.Name = "btnDegiskenIzle";
            this.btnDegiskenIzle.Size = new System.Drawing.Size(135, 57);
            this.btnDegiskenIzle.TabIndex = 10;
            this.btnDegiskenIzle.UseVisualStyleBackColor = false;
            this.btnDegiskenIzle.Click += new System.EventHandler(this.btnDegiskenIzle_Click);
            // 
            // btnfor
            // 
            this.btnfor.BackColor = System.Drawing.Color.White;
            this.btnfor.BackgroundImage = global::Algoritma.Properties.Resources._for;
            this.btnfor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnfor.Location = new System.Drawing.Point(5, 280);
            this.btnfor.Name = "btnfor";
            this.btnfor.Size = new System.Drawing.Size(135, 57);
            this.btnfor.TabIndex = 9;
            this.btnfor.UseVisualStyleBackColor = false;
            this.btnfor.Click += new System.EventHandler(this.btnfor_Click);
            // 
            // btnDur
            // 
            this.btnDur.BackColor = System.Drawing.Color.White;
            this.btnDur.BackgroundImage = global::Algoritma.Properties.Resources.dur1;
            this.btnDur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDur.Location = new System.Drawing.Point(5, 593);
            this.btnDur.Name = "btnDur";
            this.btnDur.Size = new System.Drawing.Size(135, 57);
            this.btnDur.TabIndex = 8;
            this.btnDur.UseVisualStyleBackColor = false;
            this.btnDur.Click += new System.EventHandler(this.btnDur_Click);
            // 
            // btnDugum
            // 
            this.btnDugum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDugum.BackgroundImage = global::Algoritma.Properties.Resources.dugum1;
            this.btnDugum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDugum.Location = new System.Drawing.Point(80, 470);
            this.btnDugum.Name = "btnDugum";
            this.btnDugum.Size = new System.Drawing.Size(60, 60);
            this.btnDugum.TabIndex = 7;
            this.btnDugum.UseVisualStyleBackColor = false;
            this.btnDugum.Click += new System.EventHandler(this.btnDugum_Click);
            // 
            // btnBekle
            // 
            this.btnBekle.BackColor = System.Drawing.Color.White;
            this.btnBekle.BackgroundImage = global::Algoritma.Properties.Resources.bekle1;
            this.btnBekle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBekle.Location = new System.Drawing.Point(5, 470);
            this.btnBekle.Name = "btnBekle";
            this.btnBekle.Size = new System.Drawing.Size(60, 60);
            this.btnBekle.TabIndex = 6;
            this.btnBekle.UseVisualStyleBackColor = false;
            this.btnBekle.Click += new System.EventHandler(this.btnBekle_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.White;
            this.btnCikis.BackgroundImage = global::Algoritma.Properties.Resources.cikis1;
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCikis.Location = new System.Drawing.Point(5, 410);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(135, 57);
            this.btnCikis.TabIndex = 5;
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnEger
            // 
            this.btnEger.BackColor = System.Drawing.Color.White;
            this.btnEger.BackgroundImage = global::Algoritma.Properties.Resources.eger1;
            this.btnEger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEger.Location = new System.Drawing.Point(5, 348);
            this.btnEger.Name = "btnEger";
            this.btnEger.Size = new System.Drawing.Size(135, 57);
            this.btnEger.TabIndex = 4;
            this.btnEger.UseVisualStyleBackColor = false;
            this.btnEger.Click += new System.EventHandler(this.btnEger_Click);
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.White;
            this.btnGiris.BackgroundImage = global::Algoritma.Properties.Resources.giris1;
            this.btnGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGiris.Location = new System.Drawing.Point(5, 215);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(135, 57);
            this.btnGiris.TabIndex = 3;
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // btnIslem
            // 
            this.btnIslem.BackColor = System.Drawing.Color.White;
            this.btnIslem.BackgroundImage = global::Algoritma.Properties.Resources.islem1;
            this.btnIslem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnIslem.Location = new System.Drawing.Point(5, 150);
            this.btnIslem.Name = "btnIslem";
            this.btnIslem.Size = new System.Drawing.Size(135, 57);
            this.btnIslem.TabIndex = 2;
            this.btnIslem.UseVisualStyleBackColor = false;
            this.btnIslem.Click += new System.EventHandler(this.btnIslem_Click);
            // 
            // btnDegisken
            // 
            this.btnDegisken.BackColor = System.Drawing.Color.White;
            this.btnDegisken.BackgroundImage = global::Algoritma.Properties.Resources.degisken2;
            this.btnDegisken.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDegisken.Location = new System.Drawing.Point(5, 85);
            this.btnDegisken.Name = "btnDegisken";
            this.btnDegisken.Size = new System.Drawing.Size(135, 57);
            this.btnDegisken.TabIndex = 1;
            this.btnDegisken.UseVisualStyleBackColor = false;
            this.btnDegisken.Click += new System.EventHandler(this.btnDegisken_Click);
            // 
            // btnBaslat
            // 
            this.btnBaslat.BackColor = System.Drawing.Color.White;
            this.btnBaslat.BackgroundImage = global::Algoritma.Properties.Resources.baslat1;
            this.btnBaslat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBaslat.Location = new System.Drawing.Point(5, 20);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(135, 57);
            this.btnBaslat.TabIndex = 0;
            this.btnBaslat.UseVisualStyleBackColor = false;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // top_panel
            // 
            this.top_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.top_panel.BackColor = System.Drawing.Color.Turquoise;
            this.top_panel.Controls.Add(this.lblHiz);
            this.top_panel.Controls.Add(this.trackBarHiz);
            this.top_panel.Controls.Add(this.btnAc);
            this.top_panel.Controls.Add(this.btnYeni);
            this.top_panel.Controls.Add(this.btnKaydet);
            this.top_panel.Controls.Add(this.btnDevamEt);
            this.top_panel.Controls.Add(this.btnRun);
            this.top_panel.Location = new System.Drawing.Point(1, 1);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(963, 54);
            this.top_panel.TabIndex = 0;
            // 
            // lblHiz
            // 
            this.lblHiz.AutoSize = true;
            this.lblHiz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblHiz.Location = new System.Drawing.Point(257, 33);
            this.lblHiz.Name = "lblHiz";
            this.lblHiz.Size = new System.Drawing.Size(26, 13);
            this.lblHiz.TabIndex = 6;
            this.lblHiz.Text = "0ms";
            // 
            // trackBarHiz
            // 
            this.trackBarHiz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.trackBarHiz.Location = new System.Drawing.Point(218, 4);
            this.trackBarHiz.Maximum = 1000;
            this.trackBarHiz.Name = "trackBarHiz";
            this.trackBarHiz.Size = new System.Drawing.Size(111, 45);
            this.trackBarHiz.SmallChange = 5;
            this.trackBarHiz.TabIndex = 5;
            this.trackBarHiz.Scroll += new System.EventHandler(this.trackBarHiz_Scroll);
            // 
            // btnAc
            // 
            this.btnAc.Location = new System.Drawing.Point(51, 8);
            this.btnAc.Name = "btnAc";
            this.btnAc.Size = new System.Drawing.Size(39, 36);
            this.btnAc.TabIndex = 4;
            this.btnAc.Text = "open";
            this.btnAc.UseVisualStyleBackColor = true;
            this.btnAc.Click += new System.EventHandler(this.btnAc_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.BackgroundImage = global::Algoritma.Properties.Resources._new;
            this.btnYeni.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnYeni.Location = new System.Drawing.Point(4, 6);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(41, 39);
            this.btnYeni.TabIndex = 3;
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackgroundImage = global::Algoritma.Properties.Resources.save;
            this.btnKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnKaydet.Location = new System.Drawing.Point(96, 5);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(52, 41);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnDevamEt
            // 
            this.btnDevamEt.Location = new System.Drawing.Point(335, 5);
            this.btnDevamEt.Name = "btnDevamEt";
            this.btnDevamEt.Size = new System.Drawing.Size(85, 40);
            this.btnDevamEt.TabIndex = 1;
            this.btnDevamEt.Text = "|_>";
            this.btnDevamEt.UseVisualStyleBackColor = true;
            this.btnDevamEt.Click += new System.EventHandler(this.btnDevamEt_Click);
            // 
            // btnRun
            // 
            this.btnRun.BackgroundImage = global::Algoritma.Properties.Resources.run2;
            this.btnRun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRun.Location = new System.Drawing.Point(158, 6);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(46, 41);
            this.btnRun.TabIndex = 0;
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 708);
            this.Controls.Add(this.main_panel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Algoritma";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.main_panel.ResumeLayout(false);
            this.propertPanel.ResumeLayout(false);
            this.tabControlProperti.ResumeLayout(false);
            this.tapOzellikler.ResumeLayout(false);
            this.tapOzellikler.PerformLayout();
            this.tabDegiskenler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Degiskenler)).EndInit();
            this.cop_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Cop_pictureBox)).EndInit();
            this.tools_panel.ResumeLayout(false);
            this.top_panel.ResumeLayout(false);
            this.top_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHiz)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.Panel top_panel;
        private System.Windows.Forms.Panel tools_panel;
        private System.Windows.Forms.Panel cop_panel;
        private System.Windows.Forms.PictureBox Cop_pictureBox;
        private System.Windows.Forms.Panel propertPanel;
        private System.Windows.Forms.Button btnEger;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Button btnIslem;
        private System.Windows.Forms.Button btnDegisken;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnDur;
        private System.Windows.Forms.Button btnDugum;
        private System.Windows.Forms.Button btnBekle;
        private System.Windows.Forms.TabControl tabControlProperti;
        private System.Windows.Forms.TabPage tapOzellikler;
        private System.Windows.Forms.TabPage tabDegiskenler;
        private System.Windows.Forms.TextBox txtGoruntulenecekMetin;
        private System.Windows.Forms.Label lbltGoruntulenecekMetin;
        private System.Windows.Forms.Label lblYapilacakIslem;
        private System.Windows.Forms.ComboBox cbGoruntulenecekDegisken;
        private System.Windows.Forms.TextBox txtYapilacakIslem;
        private System.Windows.Forms.Label lblGoruntulenecekDegisken;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Degiskenler;
        private System.Windows.Forms.DataGridViewTextBoxColumn col1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col2;
        private System.Windows.Forms.Button btnBaglantiSil;
        private System.Windows.Forms.Button btnBagla;
        private System.Windows.Forms.CheckBox cbOtoBagla;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnfor;
        private System.Windows.Forms.Button btnDevamEt;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Button btnAc;
        private System.Windows.Forms.TrackBar trackBarHiz;
        private System.Windows.Forms.Label lblHiz;
        private System.Windows.Forms.Button btnDegiskenIzle;

    }
}

