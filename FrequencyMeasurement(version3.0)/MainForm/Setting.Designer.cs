namespace MainForm
{
    partial class Setting
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ChooseFreqMeter = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DeviceInfo = new System.Windows.Forms.Label();
            this.DeviceList = new System.Windows.Forms.ComboBox();
            this.ConnectToDevice = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.AllanOver_visible = new System.Windows.Forms.CheckBox();
            this.SKSV_visible = new System.Windows.Forms.CheckBox();
            this.SKO_visible = new System.Windows.Forms.CheckBox();
            this.Allan_visible = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.CountPointListType = new System.Windows.Forms.ComboBox();
            this.AutoScrol = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Resolution_AllanOver = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Resolution_SKSV = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Resolution_AVAR = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Resolution_SKO = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Resolution_F = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TimeListType = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(561, 421);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(553, 395);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Подключение к прибору";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ChooseFreqMeter);
            this.groupBox4.Location = new System.Drawing.Point(8, 31);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(223, 100);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Выбор прибора";
            // 
            // ChooseFreqMeter
            // 
            this.ChooseFreqMeter.FormattingEnabled = true;
            this.ChooseFreqMeter.Items.AddRange(new object[] {
            "CNT-90/CNT-91",
            "VCH308A",
            "Виртуальный прибор"});
            this.ChooseFreqMeter.Location = new System.Drawing.Point(15, 36);
            this.ChooseFreqMeter.Name = "ChooseFreqMeter";
            this.ChooseFreqMeter.Size = new System.Drawing.Size(174, 21);
            this.ChooseFreqMeter.TabIndex = 4;
            this.ChooseFreqMeter.Text = "CNT-90/CNT-91";
            this.ChooseFreqMeter.SelectedIndexChanged += new System.EventHandler(this.ChooseFreqMeter_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DeviceInfo);
            this.groupBox1.Controls.Add(this.DeviceList);
            this.groupBox1.Controls.Add(this.ConnectToDevice);
            this.groupBox1.Location = new System.Drawing.Point(8, 170);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(533, 131);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Подключение к прибору";
            // 
            // DeviceInfo
            // 
            this.DeviceInfo.AutoSize = true;
            this.DeviceInfo.Location = new System.Drawing.Point(27, 72);
            this.DeviceInfo.Name = "DeviceInfo";
            this.DeviceInfo.Size = new System.Drawing.Size(133, 13);
            this.DeviceInfo.TabIndex = 3;
            this.DeviceInfo.Text = "Информация о приборе: ";
            // 
            // DeviceList
            // 
            this.DeviceList.FormattingEnabled = true;
            this.DeviceList.Location = new System.Drawing.Point(27, 29);
            this.DeviceList.Name = "DeviceList";
            this.DeviceList.Size = new System.Drawing.Size(349, 21);
            this.DeviceList.TabIndex = 1;
            this.DeviceList.SelectedIndexChanged += new System.EventHandler(this.DeviceList_SelectedIndexChanged);
            this.DeviceList.Click += new System.EventHandler(this.DeviceList_Click);
            // 
            // ConnectToDevice
            // 
            this.ConnectToDevice.Location = new System.Drawing.Point(392, 27);
            this.ConnectToDevice.Name = "ConnectToDevice";
            this.ConnectToDevice.Size = new System.Drawing.Size(122, 23);
            this.ConnectToDevice.TabIndex = 2;
            this.ConnectToDevice.Text = "Подключить";
            this.ConnectToDevice.UseVisualStyleBackColor = true;
            this.ConnectToDevice.Click += new System.EventHandler(this.ConnectToDevice_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.AutoScrol);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(553, 395);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Отображение данных";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.AllanOver_visible);
            this.groupBox6.Controls.Add(this.SKSV_visible);
            this.groupBox6.Controls.Add(this.SKO_visible);
            this.groupBox6.Controls.Add(this.Allan_visible);
            this.groupBox6.Location = new System.Drawing.Point(7, 259);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox6.Size = new System.Drawing.Size(355, 112);
            this.groupBox6.TabIndex = 16;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Видимые характеристики";
            // 
            // AllanOver_visible
            // 
            this.AllanOver_visible.AutoSize = true;
            this.AllanOver_visible.Checked = true;
            this.AllanOver_visible.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AllanOver_visible.Location = new System.Drawing.Point(129, 61);
            this.AllanOver_visible.Name = "AllanOver_visible";
            this.AllanOver_visible.Size = new System.Drawing.Size(202, 17);
            this.AllanOver_visible.TabIndex = 15;
            this.AllanOver_visible.Text = "Вариация Аллана с перекрытиями";
            this.AllanOver_visible.UseVisualStyleBackColor = true;
            this.AllanOver_visible.CheckedChanged += new System.EventHandler(this.AllanOver_visible_CheckedChanged);
            // 
            // SKSV_visible
            // 
            this.SKSV_visible.AutoSize = true;
            this.SKSV_visible.Checked = true;
            this.SKSV_visible.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SKSV_visible.Location = new System.Drawing.Point(7, 61);
            this.SKSV_visible.Name = "SKSV_visible";
            this.SKSV_visible.Size = new System.Drawing.Size(54, 17);
            this.SKSV_visible.TabIndex = 14;
            this.SKSV_visible.Text = "СКСВ";
            this.SKSV_visible.UseVisualStyleBackColor = true;
            this.SKSV_visible.CheckedChanged += new System.EventHandler(this.SKSV_visible_CheckedChanged);
            // 
            // SKO_visible
            // 
            this.SKO_visible.AutoSize = true;
            this.SKO_visible.Checked = true;
            this.SKO_visible.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SKO_visible.Location = new System.Drawing.Point(129, 18);
            this.SKO_visible.Name = "SKO_visible";
            this.SKO_visible.Size = new System.Drawing.Size(48, 17);
            this.SKO_visible.TabIndex = 12;
            this.SKO_visible.Text = "СКО";
            this.SKO_visible.UseVisualStyleBackColor = true;
            this.SKO_visible.CheckedChanged += new System.EventHandler(this.SKO_visible_CheckedChanged);
            // 
            // Allan_visible
            // 
            this.Allan_visible.AutoSize = true;
            this.Allan_visible.Checked = true;
            this.Allan_visible.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Allan_visible.Location = new System.Drawing.Point(8, 18);
            this.Allan_visible.Name = "Allan_visible";
            this.Allan_visible.Size = new System.Drawing.Size(115, 17);
            this.Allan_visible.TabIndex = 13;
            this.Allan_visible.Text = "Вариация Аллана";
            this.Allan_visible.UseVisualStyleBackColor = true;
            this.Allan_visible.CheckedChanged += new System.EventHandler(this.Allan_visible_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.CountPointListType);
            this.groupBox5.Location = new System.Drawing.Point(204, 141);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(175, 83);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Количество точек на графике";
            // 
            // CountPointListType
            // 
            this.CountPointListType.FormattingEnabled = true;
            this.CountPointListType.Items.AddRange(new object[] {
            "10",
            "100",
            "1000",
            "10000",
            ""});
            this.CountPointListType.Location = new System.Drawing.Point(9, 34);
            this.CountPointListType.Margin = new System.Windows.Forms.Padding(2);
            this.CountPointListType.Name = "CountPointListType";
            this.CountPointListType.Size = new System.Drawing.Size(130, 21);
            this.CountPointListType.TabIndex = 0;
            this.CountPointListType.Text = "1000000000";
            // 
            // AutoScrol
            // 
            this.AutoScrol.AutoSize = true;
            this.AutoScrol.Checked = true;
            this.AutoScrol.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AutoScrol.Location = new System.Drawing.Point(7, 237);
            this.AutoScrol.Name = "AutoScrol";
            this.AutoScrol.Size = new System.Drawing.Size(102, 17);
            this.AutoScrol.TabIndex = 10;
            this.AutoScrol.Text = "Автопрокрутка";
            this.AutoScrol.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.Resolution_AllanOver);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.Resolution_SKSV);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.Resolution_AVAR);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.Resolution_SKO);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.Resolution_F);
            this.groupBox3.Location = new System.Drawing.Point(7, 5);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(336, 123);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Количество значащих цифр";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(110, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Вариация Аллана с перекрытиями";
            // 
            // Resolution_AllanOver
            // 
            this.Resolution_AllanOver.FormattingEnabled = true;
            this.Resolution_AllanOver.Items.AddRange(new object[] {
            "#",
            "##",
            "####",
            "######",
            "########"});
            this.Resolution_AllanOver.Location = new System.Drawing.Point(113, 86);
            this.Resolution_AllanOver.Margin = new System.Windows.Forms.Padding(2);
            this.Resolution_AllanOver.Name = "Resolution_AllanOver";
            this.Resolution_AllanOver.Size = new System.Drawing.Size(82, 21);
            this.Resolution_AllanOver.TabIndex = 13;
            this.Resolution_AllanOver.Text = "##";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "CKСВ";
            // 
            // Resolution_SKSV
            // 
            this.Resolution_SKSV.FormattingEnabled = true;
            this.Resolution_SKSV.Items.AddRange(new object[] {
            "#",
            "##",
            "####",
            "######",
            "########"});
            this.Resolution_SKSV.Location = new System.Drawing.Point(7, 86);
            this.Resolution_SKSV.Margin = new System.Windows.Forms.Padding(2);
            this.Resolution_SKSV.Name = "Resolution_SKSV";
            this.Resolution_SKSV.Size = new System.Drawing.Size(82, 21);
            this.Resolution_SKSV.TabIndex = 11;
            this.Resolution_SKSV.Text = "##";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Вариация Аллана";
            // 
            // Resolution_AVAR
            // 
            this.Resolution_AVAR.FormattingEnabled = true;
            this.Resolution_AVAR.Items.AddRange(new object[] {
            "#",
            "##",
            "####",
            "######",
            "########"});
            this.Resolution_AVAR.Location = new System.Drawing.Point(216, 45);
            this.Resolution_AVAR.Margin = new System.Windows.Forms.Padding(2);
            this.Resolution_AVAR.Name = "Resolution_AVAR";
            this.Resolution_AVAR.Size = new System.Drawing.Size(82, 21);
            this.Resolution_AVAR.TabIndex = 9;
            this.Resolution_AVAR.Text = "##";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "CKO";
            // 
            // Resolution_SKO
            // 
            this.Resolution_SKO.FormattingEnabled = true;
            this.Resolution_SKO.Items.AddRange(new object[] {
            "#",
            "##",
            "####",
            "######",
            "########"});
            this.Resolution_SKO.Location = new System.Drawing.Point(113, 45);
            this.Resolution_SKO.Margin = new System.Windows.Forms.Padding(2);
            this.Resolution_SKO.Name = "Resolution_SKO";
            this.Resolution_SKO.Size = new System.Drawing.Size(82, 21);
            this.Resolution_SKO.TabIndex = 7;
            this.Resolution_SKO.Text = "##";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Частота";
            // 
            // Resolution_F
            // 
            this.Resolution_F.FormattingEnabled = true;
            this.Resolution_F.Items.AddRange(new object[] {
            "#",
            "##",
            "####",
            "######",
            "########"});
            this.Resolution_F.Location = new System.Drawing.Point(7, 45);
            this.Resolution_F.Margin = new System.Windows.Forms.Padding(2);
            this.Resolution_F.Name = "Resolution_F";
            this.Resolution_F.Size = new System.Drawing.Size(82, 21);
            this.Resolution_F.TabIndex = 5;
            this.Resolution_F.Text = "##";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TimeListType);
            this.groupBox2.Location = new System.Drawing.Point(7, 141);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(183, 83);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Временной ряд";
            // 
            // TimeListType
            // 
            this.TimeListType.FormattingEnabled = true;
            this.TimeListType.Items.AddRange(new object[] {
            "1,10,100...",
            "1,2,4,8,16...",
            "1,2,5,10,20,50,100...",
            "1,2,3,4,5,6,7,8..."});
            this.TimeListType.Location = new System.Drawing.Point(12, 34);
            this.TimeListType.Margin = new System.Windows.Forms.Padding(2);
            this.TimeListType.Name = "TimeListType";
            this.TimeListType.Size = new System.Drawing.Size(130, 21);
            this.TimeListType.TabIndex = 0;
            this.TimeListType.Text = "1,2,4,8,16...";
            this.TimeListType.TextChanged += new System.EventHandler(this.TimeListType_TextChanged);
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 421);
            this.Controls.Add(this.tabControl1);
            this.Name = "Setting";
            this.Text = "Настройки";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Setting_FormClosing);
            this.Load += new System.EventHandler(this.Setting_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox ChooseFreqMeter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label DeviceInfo;
        private System.Windows.Forms.ComboBox DeviceList;
        private System.Windows.Forms.Button ConnectToDevice;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox CountPointListType;
        private System.Windows.Forms.CheckBox AutoScrol;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Resolution_AllanOver;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Resolution_SKSV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Resolution_AVAR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Resolution_SKO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Resolution_F;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox TimeListType;
        private System.Windows.Forms.CheckBox SKO_visible;
        private System.Windows.Forms.CheckBox Allan_visible;
        private System.Windows.Forms.CheckBox SKSV_visible;
        private System.Windows.Forms.CheckBox AllanOver_visible;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.IO.Ports.SerialPort serialPort1;
    }
}