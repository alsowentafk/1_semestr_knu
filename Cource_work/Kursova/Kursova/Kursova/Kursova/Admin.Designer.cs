namespace Kursova
{
    partial class Admin
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.кінецьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.режимКористувачаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btEditFindClient = new System.Windows.Forms.Button();
            this.cbEditClient = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btEditClientDeposit = new System.Windows.Forms.Button();
            this.btEditClientPlusMoneyDeposit = new System.Windows.Forms.Button();
            this.btEditClientMinusMoneyDeposit = new System.Windows.Forms.Button();
            this.cbEditDeposit = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btEditClientPlusMoney = new System.Windows.Forms.Button();
            this.btEditClientMinusMoney = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbEditSurname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbEditPrizv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbEditName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbEditPasport = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btEditClient = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbEditPinKod = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tSS = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbAddSurname = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbAddPrizv = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbAddName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAddPasport = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btAddClient = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tbAddPinKod = new System.Windows.Forms.TextBox();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.tSS2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.menuStrip1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.кінецьToolStripMenuItem,
            this.режимКористувачаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1715, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // кінецьToolStripMenuItem
            // 
            this.кінецьToolStripMenuItem.Name = "кінецьToolStripMenuItem";
            this.кінецьToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.кінецьToolStripMenuItem.Text = "Кінець";
            this.кінецьToolStripMenuItem.Click += new System.EventHandler(this.кінецьToolStripMenuItem_Click);
            // 
            // режимКористувачаToolStripMenuItem
            // 
            this.режимКористувачаToolStripMenuItem.Name = "режимКористувачаToolStripMenuItem";
            this.режимКористувачаToolStripMenuItem.Size = new System.Drawing.Size(182, 24);
            this.режимКористувачаToolStripMenuItem.Text = "Повернутись до Логіну";
            this.режимКористувачаToolStripMenuItem.Click += new System.EventHandler(this.режимКористувачаToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::Kursova.Properties.Resources.Money_Banknotes_Colored_background_556540_1280x854;
            this.tabPage1.Controls.Add(this.btEditFindClient);
            this.tabPage1.Controls.Add(this.cbEditClient);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.statusStrip1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1707, 978);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Редагувати";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btEditFindClient
            // 
            this.btEditFindClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btEditFindClient.Location = new System.Drawing.Point(635, 25);
            this.btEditFindClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btEditFindClient.Name = "btEditFindClient";
            this.btEditFindClient.Size = new System.Drawing.Size(237, 44);
            this.btEditFindClient.TabIndex = 24;
            this.btEditFindClient.Text = "Пошук клієнта";
            this.btEditFindClient.UseVisualStyleBackColor = true;
            this.btEditFindClient.Click += new System.EventHandler(this.BtEditFindClient_Click);
            // 
            // cbEditClient
            // 
            this.cbEditClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbEditClient.FormattingEnabled = true;
            this.cbEditClient.Location = new System.Drawing.Point(307, 32);
            this.cbEditClient.Margin = new System.Windows.Forms.Padding(4);
            this.cbEditClient.Name = "cbEditClient";
            this.cbEditClient.Size = new System.Drawing.Size(200, 33);
            this.cbEditClient.TabIndex = 40;
            this.cbEditClient.SelectedIndexChanged += new System.EventHandler(this.CbEditClient_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(101, 39);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(175, 25);
            this.label14.TabIndex = 24;
            this.label14.Text = "Оберіть клієнта";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(1181, 39);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(461, 848);
            this.dataGridView1.TabIndex = 39;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Дата";
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Сума операції";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.btEditClientPlusMoney);
            this.groupBox2.Controls.Add(this.btEditClientMinusMoney);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(63, 473);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1056, 468);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Рахунок";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.btEditClientDeposit);
            this.groupBox4.Controls.Add(this.btEditClientPlusMoneyDeposit);
            this.groupBox4.Controls.Add(this.btEditClientMinusMoneyDeposit);
            this.groupBox4.Controls.Add(this.cbEditDeposit);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(44, 174);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(984, 287);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Депозит";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(35, 224);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(249, 42);
            this.label15.TabIndex = 30;
            this.label15.Text = "Дата вкладу";
            // 
            // btEditClientDeposit
            // 
            this.btEditClientDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btEditClientDeposit.Location = new System.Drawing.Point(773, 113);
            this.btEditClientDeposit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btEditClientDeposit.Name = "btEditClientDeposit";
            this.btEditClientDeposit.Size = new System.Drawing.Size(211, 58);
            this.btEditClientDeposit.TabIndex = 27;
            this.btEditClientDeposit.Text = "Додати депозит";
            this.btEditClientDeposit.UseVisualStyleBackColor = true;
            this.btEditClientDeposit.Visible = false;
            this.btEditClientDeposit.Click += new System.EventHandler(this.BtEditClientDeposit_Click);
            // 
            // btEditClientPlusMoneyDeposit
            // 
            this.btEditClientPlusMoneyDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btEditClientPlusMoneyDeposit.Location = new System.Drawing.Point(644, 32);
            this.btEditClientPlusMoneyDeposit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btEditClientPlusMoneyDeposit.Name = "btEditClientPlusMoneyDeposit";
            this.btEditClientPlusMoneyDeposit.Size = new System.Drawing.Size(217, 54);
            this.btEditClientPlusMoneyDeposit.TabIndex = 28;
            this.btEditClientPlusMoneyDeposit.Text = "Поповнити рахунок";
            this.btEditClientPlusMoneyDeposit.UseVisualStyleBackColor = true;
            this.btEditClientPlusMoneyDeposit.Click += new System.EventHandler(this.BtEditClientPlusMoneyDeposit_Click);
            // 
            // btEditClientMinusMoneyDeposit
            // 
            this.btEditClientMinusMoneyDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btEditClientMinusMoneyDeposit.Location = new System.Drawing.Point(429, 33);
            this.btEditClientMinusMoneyDeposit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btEditClientMinusMoneyDeposit.Name = "btEditClientMinusMoneyDeposit";
            this.btEditClientMinusMoneyDeposit.Size = new System.Drawing.Size(165, 54);
            this.btEditClientMinusMoneyDeposit.TabIndex = 27;
            this.btEditClientMinusMoneyDeposit.Text = "Зняти кошти";
            this.btEditClientMinusMoneyDeposit.UseVisualStyleBackColor = true;
            this.btEditClientMinusMoneyDeposit.Click += new System.EventHandler(this.BtEditClientMinusMoneyDeposit_Click);
            // 
            // cbEditDeposit
            // 
            this.cbEditDeposit.Enabled = false;
            this.cbEditDeposit.FormattingEnabled = true;
            this.cbEditDeposit.Items.AddRange(new object[] {
            "Накопичувальний",
            "Ощадний",
            "Універсальний"});
            this.cbEditDeposit.Location = new System.Drawing.Point(148, 47);
            this.cbEditDeposit.Margin = new System.Windows.Forms.Padding(4);
            this.cbEditDeposit.Name = "cbEditDeposit";
            this.cbEditDeposit.Size = new System.Drawing.Size(192, 37);
            this.cbEditDeposit.TabIndex = 29;
            this.cbEditDeposit.SelectedIndexChanged += new System.EventHandler(this.CbEditDeposit_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(44, 144);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(151, 42);
            this.label13.TabIndex = 28;
            this.label13.Text = "Баланс";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(35, 47);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 42);
            this.label8.TabIndex = 27;
            this.label8.Text = "Вид:";
            // 
            // btEditClientPlusMoney
            // 
            this.btEditClientPlusMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btEditClientPlusMoney.Location = new System.Drawing.Point(688, 86);
            this.btEditClientPlusMoney.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btEditClientPlusMoney.Name = "btEditClientPlusMoney";
            this.btEditClientPlusMoney.Size = new System.Drawing.Size(244, 65);
            this.btEditClientPlusMoney.TabIndex = 25;
            this.btEditClientPlusMoney.Text = "Поповнити рахунок";
            this.btEditClientPlusMoney.UseVisualStyleBackColor = true;
            this.btEditClientPlusMoney.Click += new System.EventHandler(this.BtEditClientPlusMoney_Click);
            // 
            // btEditClientMinusMoney
            // 
            this.btEditClientMinusMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btEditClientMinusMoney.Location = new System.Drawing.Point(133, 86);
            this.btEditClientMinusMoney.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btEditClientMinusMoney.Name = "btEditClientMinusMoney";
            this.btEditClientMinusMoney.Size = new System.Drawing.Size(177, 65);
            this.btEditClientMinusMoney.TabIndex = 24;
            this.btEditClientMinusMoney.Text = "Зняти кошти";
            this.btEditClientMinusMoney.UseVisualStyleBackColor = true;
            this.btEditClientMinusMoney.Click += new System.EventHandler(this.BtEditClientMinusMoney_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(125, 31);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 42);
            this.label7.TabIndex = 0;
            this.label7.Text = "Баланс";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.tbEditSurname);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbEditPrizv);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbEditName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbEditPasport);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btEditClient);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbEditPinKod);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(63, 105);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1056, 375);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Клієнт";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(745, 209);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(283, 65);
            this.button1.TabIndex = 24;
            this.button1.Text = "Видалити клієнта";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // tbEditSurname
            // 
            this.tbEditSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbEditSurname.Location = new System.Drawing.Point(561, 81);
            this.tbEditSurname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEditSurname.Name = "tbEditSurname";
            this.tbEditSurname.Size = new System.Drawing.Size(141, 30);
            this.tbEditSurname.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(91, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Прізвище";
            // 
            // tbEditPrizv
            // 
            this.tbEditPrizv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbEditPrizv.Location = new System.Drawing.Point(96, 81);
            this.tbEditPrizv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEditPrizv.Name = "tbEditPrizv";
            this.tbEditPrizv.Size = new System.Drawing.Size(141, 30);
            this.tbEditPrizv.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(360, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Імя";
            // 
            // tbEditName
            // 
            this.tbEditName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbEditName.Location = new System.Drawing.Point(324, 81);
            this.tbEditName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEditName.Name = "tbEditName";
            this.tbEditName.Size = new System.Drawing.Size(141, 30);
            this.tbEditName.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(556, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "По батькові";
            // 
            // tbEditPasport
            // 
            this.tbEditPasport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbEditPasport.Location = new System.Drawing.Point(811, 81);
            this.tbEditPasport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEditPasport.Name = "tbEditPasport";
            this.tbEditPasport.Size = new System.Drawing.Size(141, 30);
            this.tbEditPasport.TabIndex = 2;
            this.tbEditPasport.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbEditPasport_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(212, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Пін код";
            // 
            // btEditClient
            // 
            this.btEditClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btEditClient.Location = new System.Drawing.Point(437, 209);
            this.btEditClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btEditClient.Name = "btEditClient";
            this.btEditClient.Size = new System.Drawing.Size(283, 65);
            this.btEditClient.TabIndex = 21;
            this.btEditClient.Text = "Редагувати клієнта";
            this.btEditClient.UseVisualStyleBackColor = true;
            this.btEditClient.Click += new System.EventHandler(this.BtEditClient_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(805, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Номер паспорту";
            // 
            // tbEditPinKod
            // 
            this.tbEditPinKod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbEditPinKod.Location = new System.Drawing.Point(217, 225);
            this.tbEditPinKod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEditPinKod.Name = "tbEditPinKod";
            this.tbEditPinKod.Size = new System.Drawing.Size(141, 30);
            this.tbEditPinKod.TabIndex = 4;
            this.tbEditPinKod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbEditPinKod_KeyPress);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSS});
            this.statusStrip1.Location = new System.Drawing.Point(3, 954);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1701, 22);
            this.statusStrip1.TabIndex = 36;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tSS
            // 
            this.tSS.Name = "tSS";
            this.tSS.Size = new System.Drawing.Size(0, 17);
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::Kursova.Properties.Resources.Money_Banknotes_Colored_background_556540_1280x854;
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.statusStrip2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1707, 978);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Додати";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.tbAddSurname);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.tbAddPrizv);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.tbAddName);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.tbAddPasport);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.btAddClient);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.tbAddPinKod);
            this.groupBox3.Location = new System.Drawing.Point(19, 22);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(1056, 338);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Клієнт";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(121, 30);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(143, 17);
            this.label16.TabIndex = 33;
            this.label16.Text = "Оберіть тип клієнта:";
            // 
            // tbAddSurname
            // 
            this.tbAddSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbAddSurname.Location = new System.Drawing.Point(559, 117);
            this.tbAddSurname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAddSurname.Name = "tbAddSurname";
            this.tbAddSurname.Size = new System.Drawing.Size(141, 30);
            this.tbAddSurname.TabIndex = 23;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Фізична особа",
            "Юридична особа"});
            this.comboBox1.Location = new System.Drawing.Point(278, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 32;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(89, 77);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 25);
            this.label12.TabIndex = 15;
            this.label12.Text = "Прізвище";
            // 
            // tbAddPrizv
            // 
            this.tbAddPrizv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbAddPrizv.Location = new System.Drawing.Point(94, 117);
            this.tbAddPrizv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAddPrizv.Name = "tbAddPrizv";
            this.tbAddPrizv.Size = new System.Drawing.Size(141, 30);
            this.tbAddPrizv.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(358, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 25);
            this.label11.TabIndex = 17;
            this.label11.Text = "Імя";
            // 
            // tbAddName
            // 
            this.tbAddName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbAddName.Location = new System.Drawing.Point(322, 117);
            this.tbAddName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAddName.Name = "tbAddName";
            this.tbAddName.Size = new System.Drawing.Size(141, 30);
            this.tbAddName.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(554, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 25);
            this.label4.TabIndex = 22;
            this.label4.Text = "По батькові";
            // 
            // tbAddPasport
            // 
            this.tbAddPasport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbAddPasport.Location = new System.Drawing.Point(809, 117);
            this.tbAddPasport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAddPasport.Name = "tbAddPasport";
            this.tbAddPasport.Size = new System.Drawing.Size(141, 30);
            this.tbAddPasport.TabIndex = 2;
            this.tbAddPasport.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbAddPasport_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(210, 234);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 25);
            this.label9.TabIndex = 3;
            this.label9.Text = "Пін код";
            // 
            // btAddClient
            // 
            this.btAddClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btAddClient.Location = new System.Drawing.Point(559, 245);
            this.btAddClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAddClient.Name = "btAddClient";
            this.btAddClient.Size = new System.Drawing.Size(137, 65);
            this.btAddClient.TabIndex = 21;
            this.btAddClient.Text = "Додати клієнта";
            this.btAddClient.UseVisualStyleBackColor = true;
            this.btAddClient.Click += new System.EventHandler(this.Button5_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(803, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(165, 25);
            this.label10.TabIndex = 1;
            this.label10.Text = "Номер паспорту";
            // 
            // tbAddPinKod
            // 
            this.tbAddPinKod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbAddPinKod.Location = new System.Drawing.Point(215, 261);
            this.tbAddPinKod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAddPinKod.Name = "tbAddPinKod";
            this.tbAddPinKod.Size = new System.Drawing.Size(141, 30);
            this.tbAddPinKod.TabIndex = 4;
            this.tbAddPinKod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbAddPinKod_KeyPress);
            // 
            // statusStrip2
            // 
            this.statusStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSS2});
            this.statusStrip2.Location = new System.Drawing.Point(3, 954);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusStrip2.Size = new System.Drawing.Size(1701, 22);
            this.statusStrip2.TabIndex = 31;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // tSS2
            // 
            this.tSS2.Name = "tSS2";
            this.tSS2.Size = new System.Drawing.Size(0, 17);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1715, 1007);
            this.tabControl1.TabIndex = 10;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.TabControl1_SelectedIndexChanged);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1715, 1035);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Admin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Admin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem кінецьToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tSS;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel tSS2;
        private System.Windows.Forms.ToolStripMenuItem режимКористувачаToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbAddPinKod;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbAddPasport;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btAddClient;
        private System.Windows.Forms.TextBox tbAddName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbAddPrizv;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbAddSurname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbEditSurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbEditPrizv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbEditName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbEditPasport;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btEditClient;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbEditPinKod;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button btEditClientPlusMoney;
        private System.Windows.Forms.Button btEditClientMinusMoney;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btEditFindClient;
        private System.Windows.Forms.ComboBox cbEditClient;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btEditClientDeposit;
        private System.Windows.Forms.Button btEditClientPlusMoneyDeposit;
        private System.Windows.Forms.Button btEditClientMinusMoneyDeposit;
        private System.Windows.Forms.ComboBox cbEditDeposit;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

