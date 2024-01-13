using System;
using System.Windows.Forms.DataVisualization.Charting;

namespace _4GSMSManger
{
    partial class MainForm
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
            label1 = new Label();
            cmbIPAddress = new ComboBox();
            btnStart = new Button();
            btnStop = new Button();
            btnCSV = new Button();
            tabControl = new TabControl();
            tabPage_2G = new TabPage();
            groupBox1 = new GroupBox();
            txt_gsm2cro1 = new TextBox();
            label5 = new Label();
            txt_gsm2cro0 = new TextBox();
            label8 = new Label();
            label9 = new Label();
            txt_gsm2cid1 = new TextBox();
            label10 = new Label();
            txt_gsm2lac1 = new TextBox();
            label11 = new Label();
            txt_gsm2cid0 = new TextBox();
            label12 = new Label();
            txt_gsm2att0 = new TextBox();
            txt_gsm2lac0 = new TextBox();
            label13 = new Label();
            btn2G_setgsm2 = new Button();
            btn2G_getgsm2 = new Button();
            txt_mcc_4 = new TextBox();
            txt_mnc_4 = new TextBox();
            txt_mnc_3 = new TextBox();
            txt_mcc_3 = new TextBox();
            txt_arfcn3 = new TextBox();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            gsm1group = new GroupBox();
            txt_gsm1cro1 = new TextBox();
            label41 = new Label();
            txt_gsm1cro0 = new TextBox();
            label35 = new Label();
            label31 = new Label();
            txt_gsm1cid1 = new TextBox();
            label33 = new Label();
            txt_gsm1lac1 = new TextBox();
            label29 = new Label();
            txt_gsm1cid0 = new TextBox();
            label26 = new Label();
            txt_gsm1att0 = new TextBox();
            txt_gsm1lac0 = new TextBox();
            label22 = new Label();
            btn2G_setgsm1 = new Button();
            btn2G_getgsm1 = new Button();
            txt_mcc_2 = new TextBox();
            txt_mnc_2 = new TextBox();
            txt_mnc_1 = new TextBox();
            txt_mcc_1 = new TextBox();
            txt_arfcn1 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            tabPage_4G = new TabPage();
            groupBox4 = new GroupBox();
            btn4G_Save4 = new Button();
            txt_plmn4g4 = new TextBox();
            label21 = new Label();
            txt_earfcn4g4 = new TextBox();
            label25 = new Label();
            groupBox3 = new GroupBox();
            btn4G_Save3 = new Button();
            txt_plmn4g3 = new TextBox();
            label27 = new Label();
            txt_earfcn4g3 = new TextBox();
            label28 = new Label();
            groupBox2 = new GroupBox();
            btn4G_Save2 = new Button();
            txt_plmn4g2 = new TextBox();
            label23 = new Label();
            txt_earfcn4g2 = new TextBox();
            label24 = new Label();
            lte1group = new GroupBox();
            txt_syncfreq = new TextBox();
            label43 = new Label();
            btn4G_Save1 = new Button();
            txt_plmn4g1 = new TextBox();
            label19 = new Label();
            txt_earfcn4g1 = new TextBox();
            label20 = new Label();
            tabPage_SMS = new TabPage();
            groupBox5 = new GroupBox();
            btnSMS_off2 = new Button();
            chkSMS_flashsms2 = new CheckBox();
            chkSMS_unicode2 = new CheckBox();
            btnSMS_send_2 = new Button();
            txtSMS_SMS_2 = new TextBox();
            label34 = new Label();
            txtSMS_sender_2 = new TextBox();
            label36 = new Label();
            groupBox6 = new GroupBox();
            btnSMS_off1 = new Button();
            chkSMS_flashsms1 = new CheckBox();
            chkSMS_unicode1 = new CheckBox();
            btnSMS_send_1 = new Button();
            txtSMS_SMS_1 = new TextBox();
            label30 = new Label();
            txtSMS_sender_1 = new TextBox();
            label32 = new Label();
            tabPage_SWEEP = new TabPage();
            groupBox9 = new GroupBox();
            config2g = new Button();
            btnSweep_search2g = new Button();
            gridSweep_2 = new DataGridView();
            GSMARFCN = new DataGridViewTextBoxColumn();
            GSMMCC = new DataGridViewTextBoxColumn();
            GSMMNC = new DataGridViewTextBoxColumn();
            RSRP = new DataGridViewTextBoxColumn();
            GSMOPERATE = new DataGridViewTextBoxColumn();
            groupBox8 = new GroupBox();
            btnSweep_config4g = new Button();
            btnSweep_search4g = new Button();
            gridSweep_1 = new DataGridView();
            LTEEARFCN = new DataGridViewTextBoxColumn();
            MCC = new DataGridViewTextBoxColumn();
            MNC = new DataGridViewTextBoxColumn();
            MCC1 = new DataGridViewTextBoxColumn();
            MNC1 = new DataGridViewTextBoxColumn();
            OPERATE = new DataGridViewTextBoxColumn();
            tabChart = new TabPage();
            barChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            pieChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            imsiimei = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            IMSI = new DataGridViewTextBoxColumn();
            IMEI = new DataGridViewTextBoxColumn();
            STATUE = new DataGridViewTextBoxColumn();
            RSSI = new DataGridViewTextBoxColumn();
            TIME = new DataGridViewTextBoxColumn();
            COUT = new DataGridViewTextBoxColumn();
            BBU = new DataGridViewTextBoxColumn();
            PROVIDER = new DataGridViewTextBoxColumn();
            LOCATION = new DataGridViewTextBoxColumn();
            COUNTRY = new DataGridViewTextBoxColumn();
            lvLogs = new ListView();
            colTime = new ColumnHeader();
            colLog = new ColumnHeader();
            lblStatus_lte4rf = new Label();
            label37 = new Label();
            lblStatus_lte3rf = new Label();
            label38 = new Label();
            lblStatus_lte2rf = new Label();
            label39 = new Label();
            lblStatus_lte1rf = new Label();
            label40 = new Label();
            lblStatus_gsm2rf = new Label();
            label42 = new Label();
            lblStatus_gsm1rf = new Label();
            label44 = new Label();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            splitContainer2 = new SplitContainer();
            tabControl.SuspendLayout();
            tabPage_2G.SuspendLayout();
            groupBox1.SuspendLayout();
            gsm1group.SuspendLayout();
            tabPage_4G.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            lte1group.SuspendLayout();
            tabPage_SMS.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            tabPage_SWEEP.SuspendLayout();
            groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridSweep_2).BeginInit();
            groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridSweep_1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imsiimei).BeginInit();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 48);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 0;
            label1.Text = "IP Address:";
            // 
            // cmbIPAddress
            // 
            cmbIPAddress.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbIPAddress.FormattingEnabled = true;
            cmbIPAddress.Location = new Point(108, 45);
            cmbIPAddress.Margin = new Padding(4, 3, 4, 3);
            cmbIPAddress.Name = "cmbIPAddress";
            cmbIPAddress.Size = new Size(186, 23);
            cmbIPAddress.TabIndex = 1;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(335, 43);
            btnStart.Margin = new Padding(4, 3, 4, 3);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(94, 30);
            btnStart.TabIndex = 2;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(436, 43);
            btnStop.Margin = new Padding(4, 3, 4, 3);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(88, 30);
            btnStop.TabIndex = 2;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // btnCSV
            // 
            btnCSV.Location = new Point(534, 43);
            btnCSV.Margin = new Padding(4, 3, 4, 3);
            btnCSV.Name = "btnCSV";
            btnCSV.Size = new Size(88, 30);
            btnCSV.TabIndex = 2;
            btnCSV.Text = "CSV";
            btnCSV.UseVisualStyleBackColor = true;
            btnCSV.Click += btnCSV_Click;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPage_2G);
            tabControl.Controls.Add(tabPage_4G);
            tabControl.Controls.Add(tabPage_SMS);
            tabControl.Controls.Add(tabPage_SWEEP);
            tabControl.Controls.Add(tabChart);
            tabControl.Location = new Point(18, 105);
            tabControl.Margin = new Padding(4, 3, 4, 3);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1346, 240);
            tabControl.TabIndex = 4;
            // 
            // tabPage_2G
            // 
            tabPage_2G.Controls.Add(groupBox1);
            tabPage_2G.Controls.Add(gsm1group);
            tabPage_2G.Location = new Point(4, 24);
            tabPage_2G.Margin = new Padding(4, 3, 4, 3);
            tabPage_2G.Name = "tabPage_2G";
            tabPage_2G.Padding = new Padding(4, 3, 4, 3);
            tabPage_2G.Size = new Size(1338, 212);
            tabPage_2G.TabIndex = 0;
            tabPage_2G.Text = "2G";
            tabPage_2G.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(txt_gsm2cro1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txt_gsm2cro0);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txt_gsm2cid1);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(txt_gsm2lac1);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(txt_gsm2cid0);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(txt_gsm2att0);
            groupBox1.Controls.Add(txt_gsm2lac0);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(btn2G_setgsm2);
            groupBox1.Controls.Add(btn2G_getgsm2);
            groupBox1.Controls.Add(txt_mcc_4);
            groupBox1.Controls.Add(txt_mnc_4);
            groupBox1.Controls.Add(txt_mnc_3);
            groupBox1.Controls.Add(txt_mcc_3);
            groupBox1.Controls.Add(txt_arfcn3);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(label17);
            groupBox1.Controls.Add(label18);
            groupBox1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(666, 7);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(656, 197);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "GSM_2";
            // 
            // txt_gsm2cro1
            // 
            txt_gsm2cro1.Location = new Point(300, 96);
            txt_gsm2cro1.Margin = new Padding(4, 3, 4, 3);
            txt_gsm2cro1.Name = "txt_gsm2cro1";
            txt_gsm2cro1.Size = new Size(53, 20);
            txt_gsm2cro1.TabIndex = 40;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(257, 99);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(33, 13);
            label5.TabIndex = 39;
            label5.Text = "CRO:";
            // 
            // txt_gsm2cro0
            // 
            txt_gsm2cro0.Location = new Point(189, 96);
            txt_gsm2cro0.Margin = new Padding(4, 3, 4, 3);
            txt_gsm2cro0.Name = "txt_gsm2cro0";
            txt_gsm2cro0.Size = new Size(56, 20);
            txt_gsm2cro0.TabIndex = 38;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(145, 99);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(33, 13);
            label8.TabIndex = 37;
            label8.Text = "CRO:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(506, 68);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(28, 13);
            label9.TabIndex = 35;
            label9.Text = "CID:";
            // 
            // txt_gsm2cid1
            // 
            txt_gsm2cid1.Location = new Point(545, 63);
            txt_gsm2cid1.Margin = new Padding(4, 3, 4, 3);
            txt_gsm2cid1.Name = "txt_gsm2cid1";
            txt_gsm2cid1.Size = new Size(94, 20);
            txt_gsm2cid1.TabIndex = 36;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(362, 68);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(30, 13);
            label10.TabIndex = 33;
            label10.Text = "LAC:";
            // 
            // txt_gsm2lac1
            // 
            txt_gsm2lac1.Location = new Point(404, 63);
            txt_gsm2lac1.Margin = new Padding(4, 3, 4, 3);
            txt_gsm2lac1.Name = "txt_gsm2lac1";
            txt_gsm2lac1.Size = new Size(94, 20);
            txt_gsm2lac1.TabIndex = 34;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(506, 37);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(28, 13);
            label11.TabIndex = 31;
            label11.Text = "CID:";
            // 
            // txt_gsm2cid0
            // 
            txt_gsm2cid0.Location = new Point(545, 32);
            txt_gsm2cid0.Margin = new Padding(4, 3, 4, 3);
            txt_gsm2cid0.Name = "txt_gsm2cid0";
            txt_gsm2cid0.Size = new Size(94, 20);
            txt_gsm2cid0.TabIndex = 32;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(362, 37);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(30, 13);
            label12.TabIndex = 28;
            label12.Text = "LAC:";
            // 
            // txt_gsm2att0
            // 
            txt_gsm2att0.Location = new Point(68, 63);
            txt_gsm2att0.Margin = new Padding(4, 3, 4, 3);
            txt_gsm2att0.Name = "txt_gsm2att0";
            txt_gsm2att0.Size = new Size(62, 20);
            txt_gsm2att0.TabIndex = 30;
            // 
            // txt_gsm2lac0
            // 
            txt_gsm2lac0.Location = new Point(404, 32);
            txt_gsm2lac0.Margin = new Padding(4, 3, 4, 3);
            txt_gsm2lac0.Name = "txt_gsm2lac0";
            txt_gsm2lac0.Size = new Size(94, 20);
            txt_gsm2lac0.TabIndex = 29;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(22, 68);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(31, 13);
            label13.TabIndex = 29;
            label13.Text = "ATT:";
            // 
            // btn2G_setgsm2
            // 
            btn2G_setgsm2.FlatAppearance.BorderColor = Color.White;
            btn2G_setgsm2.Location = new Point(465, 142);
            btn2G_setgsm2.Margin = new Padding(4, 3, 4, 3);
            btn2G_setgsm2.Name = "btn2G_setgsm2";
            btn2G_setgsm2.Size = new Size(88, 31);
            btn2G_setgsm2.TabIndex = 22;
            btn2G_setgsm2.Text = "SET";
            btn2G_setgsm2.UseVisualStyleBackColor = true;
            btn2G_setgsm2.Click += btn2G_setgsm2_Click;
            // 
            // btn2G_getgsm2
            // 
            btn2G_getgsm2.FlatAppearance.BorderColor = Color.White;
            btn2G_getgsm2.FlatAppearance.BorderSize = 0;
            btn2G_getgsm2.Location = new Point(106, 142);
            btn2G_getgsm2.Margin = new Padding(4, 3, 4, 3);
            btn2G_getgsm2.Name = "btn2G_getgsm2";
            btn2G_getgsm2.Size = new Size(88, 30);
            btn2G_getgsm2.TabIndex = 21;
            btn2G_getgsm2.Text = "GET";
            btn2G_getgsm2.UseVisualStyleBackColor = true;
            btn2G_getgsm2.Click += btn2G_getgsm2_Click;
            // 
            // txt_mcc_4
            // 
            txt_mcc_4.Location = new Point(300, 32);
            txt_mcc_4.Margin = new Padding(4, 3, 4, 3);
            txt_mcc_4.Name = "txt_mcc_4";
            txt_mcc_4.Size = new Size(53, 20);
            txt_mcc_4.TabIndex = 10;
            // 
            // txt_mnc_4
            // 
            txt_mnc_4.Location = new Point(300, 63);
            txt_mnc_4.Margin = new Padding(4, 3, 4, 3);
            txt_mnc_4.Name = "txt_mnc_4";
            txt_mnc_4.Size = new Size(53, 20);
            txt_mnc_4.TabIndex = 9;
            // 
            // txt_mnc_3
            // 
            txt_mnc_3.Location = new Point(189, 63);
            txt_mnc_3.Margin = new Padding(4, 3, 4, 3);
            txt_mnc_3.Name = "txt_mnc_3";
            txt_mnc_3.Size = new Size(56, 20);
            txt_mnc_3.TabIndex = 8;
            // 
            // txt_mcc_3
            // 
            txt_mcc_3.Location = new Point(189, 32);
            txt_mcc_3.Margin = new Padding(4, 3, 4, 3);
            txt_mcc_3.Name = "txt_mcc_3";
            txt_mcc_3.Size = new Size(56, 20);
            txt_mcc_3.TabIndex = 7;
            // 
            // txt_arfcn3
            // 
            txt_arfcn3.Location = new Point(68, 33);
            txt_arfcn3.Margin = new Padding(4, 3, 4, 3);
            txt_arfcn3.Name = "txt_arfcn3";
            txt_arfcn3.Size = new Size(62, 20);
            txt_arfcn3.TabIndex = 6;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(258, 68);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(34, 13);
            label14.TabIndex = 5;
            label14.Text = "MNC:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(258, 37);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(33, 13);
            label15.TabIndex = 4;
            label15.Text = "MCC:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(144, 68);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(34, 13);
            label16.TabIndex = 2;
            label16.Text = "MNC:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(145, 37);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(33, 13);
            label17.TabIndex = 1;
            label17.Text = "MCC:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(7, 37);
            label18.Margin = new Padding(4, 0, 4, 0);
            label18.Name = "label18";
            label18.Size = new Size(46, 13);
            label18.TabIndex = 0;
            label18.Text = "ARFCN:";
            // 
            // gsm1group
            // 
            gsm1group.BackColor = Color.Transparent;
            gsm1group.Controls.Add(txt_gsm1cro1);
            gsm1group.Controls.Add(label41);
            gsm1group.Controls.Add(txt_gsm1cro0);
            gsm1group.Controls.Add(label35);
            gsm1group.Controls.Add(label31);
            gsm1group.Controls.Add(txt_gsm1cid1);
            gsm1group.Controls.Add(label33);
            gsm1group.Controls.Add(txt_gsm1lac1);
            gsm1group.Controls.Add(label29);
            gsm1group.Controls.Add(txt_gsm1cid0);
            gsm1group.Controls.Add(label26);
            gsm1group.Controls.Add(txt_gsm1att0);
            gsm1group.Controls.Add(txt_gsm1lac0);
            gsm1group.Controls.Add(label22);
            gsm1group.Controls.Add(btn2G_setgsm1);
            gsm1group.Controls.Add(btn2G_getgsm1);
            gsm1group.Controls.Add(txt_mcc_2);
            gsm1group.Controls.Add(txt_mnc_2);
            gsm1group.Controls.Add(txt_mnc_1);
            gsm1group.Controls.Add(txt_mcc_1);
            gsm1group.Controls.Add(txt_arfcn1);
            gsm1group.Controls.Add(label7);
            gsm1group.Controls.Add(label6);
            gsm1group.Controls.Add(label4);
            gsm1group.Controls.Add(label3);
            gsm1group.Controls.Add(label2);
            gsm1group.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            gsm1group.Location = new Point(4, 7);
            gsm1group.Margin = new Padding(4, 3, 4, 3);
            gsm1group.Name = "gsm1group";
            gsm1group.Padding = new Padding(4, 3, 4, 3);
            gsm1group.Size = new Size(656, 197);
            gsm1group.TabIndex = 1;
            gsm1group.TabStop = false;
            gsm1group.Text = "GSM_1";
            // 
            // txt_gsm1cro1
            // 
            txt_gsm1cro1.Location = new Point(300, 96);
            txt_gsm1cro1.Margin = new Padding(4, 3, 4, 3);
            txt_gsm1cro1.Name = "txt_gsm1cro1";
            txt_gsm1cro1.Size = new Size(53, 20);
            txt_gsm1cro1.TabIndex = 40;
            // 
            // label41
            // 
            label41.AutoSize = true;
            label41.Location = new Point(257, 99);
            label41.Margin = new Padding(4, 0, 4, 0);
            label41.Name = "label41";
            label41.Size = new Size(33, 13);
            label41.TabIndex = 39;
            label41.Text = "CRO:";
            // 
            // txt_gsm1cro0
            // 
            txt_gsm1cro0.Location = new Point(189, 96);
            txt_gsm1cro0.Margin = new Padding(4, 3, 4, 3);
            txt_gsm1cro0.Name = "txt_gsm1cro0";
            txt_gsm1cro0.Size = new Size(56, 20);
            txt_gsm1cro0.TabIndex = 38;
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Location = new Point(145, 99);
            label35.Margin = new Padding(4, 0, 4, 0);
            label35.Name = "label35";
            label35.Size = new Size(33, 13);
            label35.TabIndex = 37;
            label35.Text = "CRO:";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new Point(506, 68);
            label31.Margin = new Padding(4, 0, 4, 0);
            label31.Name = "label31";
            label31.Size = new Size(28, 13);
            label31.TabIndex = 35;
            label31.Text = "CID:";
            // 
            // txt_gsm1cid1
            // 
            txt_gsm1cid1.Location = new Point(545, 63);
            txt_gsm1cid1.Margin = new Padding(4, 3, 4, 3);
            txt_gsm1cid1.Name = "txt_gsm1cid1";
            txt_gsm1cid1.Size = new Size(94, 20);
            txt_gsm1cid1.TabIndex = 36;
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Location = new Point(362, 68);
            label33.Margin = new Padding(4, 0, 4, 0);
            label33.Name = "label33";
            label33.Size = new Size(30, 13);
            label33.TabIndex = 33;
            label33.Text = "LAC:";
            // 
            // txt_gsm1lac1
            // 
            txt_gsm1lac1.Location = new Point(404, 63);
            txt_gsm1lac1.Margin = new Padding(4, 3, 4, 3);
            txt_gsm1lac1.Name = "txt_gsm1lac1";
            txt_gsm1lac1.Size = new Size(94, 20);
            txt_gsm1lac1.TabIndex = 34;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(506, 37);
            label29.Margin = new Padding(4, 0, 4, 0);
            label29.Name = "label29";
            label29.Size = new Size(28, 13);
            label29.TabIndex = 31;
            label29.Text = "CID:";
            // 
            // txt_gsm1cid0
            // 
            txt_gsm1cid0.Location = new Point(545, 32);
            txt_gsm1cid0.Margin = new Padding(4, 3, 4, 3);
            txt_gsm1cid0.Name = "txt_gsm1cid0";
            txt_gsm1cid0.Size = new Size(94, 20);
            txt_gsm1cid0.TabIndex = 32;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(362, 37);
            label26.Margin = new Padding(4, 0, 4, 0);
            label26.Name = "label26";
            label26.Size = new Size(30, 13);
            label26.TabIndex = 28;
            label26.Text = "LAC:";
            // 
            // txt_gsm1att0
            // 
            txt_gsm1att0.Location = new Point(68, 63);
            txt_gsm1att0.Margin = new Padding(4, 3, 4, 3);
            txt_gsm1att0.Name = "txt_gsm1att0";
            txt_gsm1att0.Size = new Size(62, 20);
            txt_gsm1att0.TabIndex = 30;
            // 
            // txt_gsm1lac0
            // 
            txt_gsm1lac0.Location = new Point(404, 32);
            txt_gsm1lac0.Margin = new Padding(4, 3, 4, 3);
            txt_gsm1lac0.Name = "txt_gsm1lac0";
            txt_gsm1lac0.Size = new Size(94, 20);
            txt_gsm1lac0.TabIndex = 29;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(22, 68);
            label22.Margin = new Padding(4, 0, 4, 0);
            label22.Name = "label22";
            label22.Size = new Size(31, 13);
            label22.TabIndex = 29;
            label22.Text = "ATT:";
            // 
            // btn2G_setgsm1
            // 
            btn2G_setgsm1.FlatAppearance.BorderColor = Color.White;
            btn2G_setgsm1.Location = new Point(465, 142);
            btn2G_setgsm1.Margin = new Padding(4, 3, 4, 3);
            btn2G_setgsm1.Name = "btn2G_setgsm1";
            btn2G_setgsm1.Size = new Size(88, 31);
            btn2G_setgsm1.TabIndex = 22;
            btn2G_setgsm1.Text = "SET";
            btn2G_setgsm1.UseVisualStyleBackColor = true;
            btn2G_setgsm1.Click += btn2G_setgsm1_Click;
            // 
            // btn2G_getgsm1
            // 
            btn2G_getgsm1.FlatAppearance.BorderColor = Color.White;
            btn2G_getgsm1.FlatAppearance.BorderSize = 0;
            btn2G_getgsm1.Location = new Point(106, 142);
            btn2G_getgsm1.Margin = new Padding(4, 3, 4, 3);
            btn2G_getgsm1.Name = "btn2G_getgsm1";
            btn2G_getgsm1.Size = new Size(88, 30);
            btn2G_getgsm1.TabIndex = 21;
            btn2G_getgsm1.Text = "GET";
            btn2G_getgsm1.UseVisualStyleBackColor = true;
            btn2G_getgsm1.Click += btn2G_getgsm1_Click;
            // 
            // txt_mcc_2
            // 
            txt_mcc_2.Location = new Point(300, 32);
            txt_mcc_2.Margin = new Padding(4, 3, 4, 3);
            txt_mcc_2.Name = "txt_mcc_2";
            txt_mcc_2.Size = new Size(53, 20);
            txt_mcc_2.TabIndex = 10;
            // 
            // txt_mnc_2
            // 
            txt_mnc_2.Location = new Point(300, 63);
            txt_mnc_2.Margin = new Padding(4, 3, 4, 3);
            txt_mnc_2.Name = "txt_mnc_2";
            txt_mnc_2.Size = new Size(53, 20);
            txt_mnc_2.TabIndex = 9;
            // 
            // txt_mnc_1
            // 
            txt_mnc_1.Location = new Point(189, 63);
            txt_mnc_1.Margin = new Padding(4, 3, 4, 3);
            txt_mnc_1.Name = "txt_mnc_1";
            txt_mnc_1.Size = new Size(56, 20);
            txt_mnc_1.TabIndex = 8;
            // 
            // txt_mcc_1
            // 
            txt_mcc_1.Location = new Point(189, 32);
            txt_mcc_1.Margin = new Padding(4, 3, 4, 3);
            txt_mcc_1.Name = "txt_mcc_1";
            txt_mcc_1.Size = new Size(56, 20);
            txt_mcc_1.TabIndex = 7;
            // 
            // txt_arfcn1
            // 
            txt_arfcn1.Location = new Point(68, 33);
            txt_arfcn1.Margin = new Padding(4, 3, 4, 3);
            txt_arfcn1.Name = "txt_arfcn1";
            txt_arfcn1.Size = new Size(62, 20);
            txt_arfcn1.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(258, 68);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(34, 13);
            label7.TabIndex = 5;
            label7.Text = "MNC:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(258, 37);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(33, 13);
            label6.TabIndex = 4;
            label6.Text = "MCC:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(144, 68);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(34, 13);
            label4.TabIndex = 2;
            label4.Text = "MNC:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(145, 37);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(33, 13);
            label3.TabIndex = 1;
            label3.Text = "MCC:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 37);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(46, 13);
            label2.TabIndex = 0;
            label2.Text = "ARFCN:";
            // 
            // tabPage_4G
            // 
            tabPage_4G.Controls.Add(groupBox4);
            tabPage_4G.Controls.Add(groupBox3);
            tabPage_4G.Controls.Add(groupBox2);
            tabPage_4G.Controls.Add(lte1group);
            tabPage_4G.Location = new Point(4, 24);
            tabPage_4G.Margin = new Padding(4, 3, 4, 3);
            tabPage_4G.Name = "tabPage_4G";
            tabPage_4G.Padding = new Padding(4, 3, 4, 3);
            tabPage_4G.Size = new Size(1338, 212);
            tabPage_4G.TabIndex = 1;
            tabPage_4G.Text = "4G";
            tabPage_4G.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.Transparent;
            groupBox4.Controls.Add(btn4G_Save4);
            groupBox4.Controls.Add(txt_plmn4g4);
            groupBox4.Controls.Add(label21);
            groupBox4.Controls.Add(txt_earfcn4g4);
            groupBox4.Controls.Add(label25);
            groupBox4.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox4.Location = new Point(1008, 7);
            groupBox4.Margin = new Padding(4, 3, 4, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(4, 3, 4, 3);
            groupBox4.Size = new Size(322, 179);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "4G_4";
            // 
            // btn4G_Save4
            // 
            btn4G_Save4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn4G_Save4.Location = new Point(204, 135);
            btn4G_Save4.Margin = new Padding(4, 3, 4, 3);
            btn4G_Save4.Name = "btn4G_Save4";
            btn4G_Save4.Size = new Size(98, 30);
            btn4G_Save4.TabIndex = 7;
            btn4G_Save4.Text = "Save";
            btn4G_Save4.UseVisualStyleBackColor = true;
            btn4G_Save4.Click += btn4G_Save4_Click;
            // 
            // txt_plmn4g4
            // 
            txt_plmn4g4.Location = new Point(80, 55);
            txt_plmn4g4.Margin = new Padding(4, 3, 4, 3);
            txt_plmn4g4.Multiline = true;
            txt_plmn4g4.Name = "txt_plmn4g4";
            txt_plmn4g4.Size = new Size(228, 22);
            txt_plmn4g4.TabIndex = 2;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(13, 60);
            label21.Margin = new Padding(4, 0, 4, 0);
            label21.Name = "label21";
            label21.Size = new Size(40, 13);
            label21.TabIndex = 1;
            label21.Text = "PLMN:";
            // 
            // txt_earfcn4g4
            // 
            txt_earfcn4g4.Location = new Point(80, 24);
            txt_earfcn4g4.Margin = new Padding(4, 3, 4, 3);
            txt_earfcn4g4.Multiline = true;
            txt_earfcn4g4.Name = "txt_earfcn4g4";
            txt_earfcn4g4.Size = new Size(228, 22);
            txt_earfcn4g4.TabIndex = 0;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(13, 30);
            label25.Margin = new Padding(4, 0, 4, 0);
            label25.Name = "label25";
            label25.Size = new Size(53, 13);
            label25.TabIndex = 0;
            label25.Text = "EARFCN:";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Transparent;
            groupBox3.Controls.Add(btn4G_Save3);
            groupBox3.Controls.Add(txt_plmn4g3);
            groupBox3.Controls.Add(label27);
            groupBox3.Controls.Add(txt_earfcn4g3);
            groupBox3.Controls.Add(label28);
            groupBox3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(676, 7);
            groupBox3.Margin = new Padding(4, 3, 4, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4, 3, 4, 3);
            groupBox3.Size = new Size(322, 179);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "4G_3";
            // 
            // btn4G_Save3
            // 
            btn4G_Save3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn4G_Save3.Location = new Point(203, 135);
            btn4G_Save3.Margin = new Padding(4, 3, 4, 3);
            btn4G_Save3.Name = "btn4G_Save3";
            btn4G_Save3.Size = new Size(98, 30);
            btn4G_Save3.TabIndex = 7;
            btn4G_Save3.Text = "Save";
            btn4G_Save3.UseVisualStyleBackColor = true;
            btn4G_Save3.Click += btn4G_Save3_Click;
            // 
            // txt_plmn4g3
            // 
            txt_plmn4g3.Location = new Point(79, 55);
            txt_plmn4g3.Margin = new Padding(4, 3, 4, 3);
            txt_plmn4g3.Multiline = true;
            txt_plmn4g3.Name = "txt_plmn4g3";
            txt_plmn4g3.Size = new Size(228, 22);
            txt_plmn4g3.TabIndex = 2;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(12, 60);
            label27.Margin = new Padding(4, 0, 4, 0);
            label27.Name = "label27";
            label27.Size = new Size(40, 13);
            label27.TabIndex = 1;
            label27.Text = "PLMN:";
            // 
            // txt_earfcn4g3
            // 
            txt_earfcn4g3.Location = new Point(79, 24);
            txt_earfcn4g3.Margin = new Padding(4, 3, 4, 3);
            txt_earfcn4g3.Multiline = true;
            txt_earfcn4g3.Name = "txt_earfcn4g3";
            txt_earfcn4g3.Size = new Size(228, 22);
            txt_earfcn4g3.TabIndex = 0;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(12, 30);
            label28.Margin = new Padding(4, 0, 4, 0);
            label28.Name = "label28";
            label28.Size = new Size(53, 13);
            label28.TabIndex = 0;
            label28.Text = "EARFCN:";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(btn4G_Save2);
            groupBox2.Controls.Add(txt_plmn4g2);
            groupBox2.Controls.Add(label23);
            groupBox2.Controls.Add(txt_earfcn4g2);
            groupBox2.Controls.Add(label24);
            groupBox2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(342, 7);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(322, 179);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "4G_2";
            // 
            // btn4G_Save2
            // 
            btn4G_Save2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn4G_Save2.Location = new Point(200, 135);
            btn4G_Save2.Margin = new Padding(4, 3, 4, 3);
            btn4G_Save2.Name = "btn4G_Save2";
            btn4G_Save2.Size = new Size(98, 30);
            btn4G_Save2.TabIndex = 7;
            btn4G_Save2.Text = "Save";
            btn4G_Save2.UseVisualStyleBackColor = true;
            btn4G_Save2.Click += btn4G_Save2_Click;
            // 
            // txt_plmn4g2
            // 
            txt_plmn4g2.Location = new Point(77, 55);
            txt_plmn4g2.Margin = new Padding(4, 3, 4, 3);
            txt_plmn4g2.Multiline = true;
            txt_plmn4g2.Name = "txt_plmn4g2";
            txt_plmn4g2.Size = new Size(228, 22);
            txt_plmn4g2.TabIndex = 2;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(9, 60);
            label23.Margin = new Padding(4, 0, 4, 0);
            label23.Name = "label23";
            label23.Size = new Size(40, 13);
            label23.TabIndex = 1;
            label23.Text = "PLMN:";
            // 
            // txt_earfcn4g2
            // 
            txt_earfcn4g2.Location = new Point(77, 24);
            txt_earfcn4g2.Margin = new Padding(4, 3, 4, 3);
            txt_earfcn4g2.Multiline = true;
            txt_earfcn4g2.Name = "txt_earfcn4g2";
            txt_earfcn4g2.Size = new Size(228, 22);
            txt_earfcn4g2.TabIndex = 0;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(9, 30);
            label24.Margin = new Padding(4, 0, 4, 0);
            label24.Name = "label24";
            label24.Size = new Size(53, 13);
            label24.TabIndex = 0;
            label24.Text = "EARFCN:";
            // 
            // lte1group
            // 
            lte1group.BackColor = Color.Transparent;
            lte1group.Controls.Add(txt_syncfreq);
            lte1group.Controls.Add(label43);
            lte1group.Controls.Add(btn4G_Save1);
            lte1group.Controls.Add(txt_plmn4g1);
            lte1group.Controls.Add(label19);
            lte1group.Controls.Add(txt_earfcn4g1);
            lte1group.Controls.Add(label20);
            lte1group.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lte1group.Location = new Point(7, 7);
            lte1group.Margin = new Padding(4, 3, 4, 3);
            lte1group.Name = "lte1group";
            lte1group.Padding = new Padding(4, 3, 4, 3);
            lte1group.Size = new Size(322, 179);
            lte1group.TabIndex = 1;
            lte1group.TabStop = false;
            lte1group.Text = "4G_1";
            // 
            // txt_syncfreq
            // 
            txt_syncfreq.Location = new Point(76, 87);
            txt_syncfreq.Margin = new Padding(4, 3, 4, 3);
            txt_syncfreq.Multiline = true;
            txt_syncfreq.Name = "txt_syncfreq";
            txt_syncfreq.Size = new Size(124, 22);
            txt_syncfreq.TabIndex = 9;
            // 
            // label43
            // 
            label43.AutoSize = true;
            label43.Location = new Point(8, 90);
            label43.Margin = new Padding(4, 0, 4, 0);
            label43.Name = "label43";
            label43.Size = new Size(39, 13);
            label43.TabIndex = 8;
            label43.Text = "SYNC:";
            // 
            // btn4G_Save1
            // 
            btn4G_Save1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn4G_Save1.Location = new Point(204, 135);
            btn4G_Save1.Margin = new Padding(4, 3, 4, 3);
            btn4G_Save1.Name = "btn4G_Save1";
            btn4G_Save1.Size = new Size(98, 30);
            btn4G_Save1.TabIndex = 7;
            btn4G_Save1.Text = "Save";
            btn4G_Save1.UseVisualStyleBackColor = true;
            btn4G_Save1.Click += btn4G_Save1_Click;
            // 
            // txt_plmn4g1
            // 
            txt_plmn4g1.Location = new Point(76, 55);
            txt_plmn4g1.Margin = new Padding(4, 3, 4, 3);
            txt_plmn4g1.Multiline = true;
            txt_plmn4g1.Name = "txt_plmn4g1";
            txt_plmn4g1.Size = new Size(228, 22);
            txt_plmn4g1.TabIndex = 2;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(8, 60);
            label19.Margin = new Padding(4, 0, 4, 0);
            label19.Name = "label19";
            label19.Size = new Size(40, 13);
            label19.TabIndex = 1;
            label19.Text = "PLMN:";
            // 
            // txt_earfcn4g1
            // 
            txt_earfcn4g1.Location = new Point(76, 24);
            txt_earfcn4g1.Margin = new Padding(4, 3, 4, 3);
            txt_earfcn4g1.Multiline = true;
            txt_earfcn4g1.Name = "txt_earfcn4g1";
            txt_earfcn4g1.Size = new Size(228, 22);
            txt_earfcn4g1.TabIndex = 0;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(8, 30);
            label20.Margin = new Padding(4, 0, 4, 0);
            label20.Name = "label20";
            label20.Size = new Size(53, 13);
            label20.TabIndex = 0;
            label20.Text = "EARFCN:";
            // 
            // tabPage_SMS
            // 
            tabPage_SMS.Controls.Add(groupBox5);
            tabPage_SMS.Controls.Add(groupBox6);
            tabPage_SMS.Location = new Point(4, 24);
            tabPage_SMS.Margin = new Padding(4, 3, 4, 3);
            tabPage_SMS.Name = "tabPage_SMS";
            tabPage_SMS.Size = new Size(1338, 212);
            tabPage_SMS.TabIndex = 2;
            tabPage_SMS.Text = "SMS";
            tabPage_SMS.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            groupBox5.BackColor = Color.Transparent;
            groupBox5.Controls.Add(btnSMS_off2);
            groupBox5.Controls.Add(chkSMS_flashsms2);
            groupBox5.Controls.Add(chkSMS_unicode2);
            groupBox5.Controls.Add(btnSMS_send_2);
            groupBox5.Controls.Add(txtSMS_SMS_2);
            groupBox5.Controls.Add(label34);
            groupBox5.Controls.Add(txtSMS_sender_2);
            groupBox5.Controls.Add(label36);
            groupBox5.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox5.Location = new Point(671, 3);
            groupBox5.Margin = new Padding(4, 3, 4, 3);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(4, 3, 4, 3);
            groupBox5.Size = new Size(660, 198);
            groupBox5.TabIndex = 1;
            groupBox5.TabStop = false;
            groupBox5.Text = "SMS_2";
            // 
            // btnSMS_off2
            // 
            btnSMS_off2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSMS_off2.Location = new Point(583, 108);
            btnSMS_off2.Margin = new Padding(4, 3, 4, 3);
            btnSMS_off2.Name = "btnSMS_off2";
            btnSMS_off2.Size = new Size(59, 77);
            btnSMS_off2.TabIndex = 6;
            btnSMS_off2.Text = "Stop";
            btnSMS_off2.UseVisualStyleBackColor = true;
            btnSMS_off2.Click += btnSMS_off2_Click;
            // 
            // chkSMS_flashsms2
            // 
            chkSMS_flashsms2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chkSMS_flashsms2.AutoSize = true;
            chkSMS_flashsms2.Location = new Point(531, 66);
            chkSMS_flashsms2.Margin = new Padding(4, 3, 4, 3);
            chkSMS_flashsms2.Name = "chkSMS_flashsms2";
            chkSMS_flashsms2.Size = new Size(69, 17);
            chkSMS_flashsms2.TabIndex = 5;
            chkSMS_flashsms2.Text = "Flashsms";
            chkSMS_flashsms2.UseVisualStyleBackColor = true;
            // 
            // chkSMS_unicode2
            // 
            chkSMS_unicode2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chkSMS_unicode2.AutoSize = true;
            chkSMS_unicode2.Location = new Point(531, 21);
            chkSMS_unicode2.Margin = new Padding(4, 3, 4, 3);
            chkSMS_unicode2.Name = "chkSMS_unicode2";
            chkSMS_unicode2.Size = new Size(66, 17);
            chkSMS_unicode2.TabIndex = 4;
            chkSMS_unicode2.Text = "Unicode";
            chkSMS_unicode2.UseVisualStyleBackColor = true;
            // 
            // btnSMS_send_2
            // 
            btnSMS_send_2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSMS_send_2.Location = new Point(520, 108);
            btnSMS_send_2.Margin = new Padding(4, 3, 4, 3);
            btnSMS_send_2.Name = "btnSMS_send_2";
            btnSMS_send_2.Size = new Size(59, 77);
            btnSMS_send_2.TabIndex = 3;
            btnSMS_send_2.Text = "Send";
            btnSMS_send_2.UseVisualStyleBackColor = true;
            btnSMS_send_2.Click += btnSMS_send_2_Click;
            // 
            // txtSMS_SMS_2
            // 
            txtSMS_SMS_2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSMS_SMS_2.Location = new Point(96, 51);
            txtSMS_SMS_2.Margin = new Padding(4, 3, 4, 3);
            txtSMS_SMS_2.Multiline = true;
            txtSMS_SMS_2.Name = "txtSMS_SMS_2";
            txtSMS_SMS_2.ScrollBars = ScrollBars.Both;
            txtSMS_SMS_2.Size = new Size(384, 139);
            txtSMS_SMS_2.TabIndex = 2;
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label34.Location = new Point(27, 51);
            label34.Margin = new Padding(4, 0, 4, 0);
            label34.Name = "label34";
            label34.Size = new Size(33, 13);
            label34.TabIndex = 1;
            label34.Text = "SMS:";
            // 
            // txtSMS_sender_2
            // 
            txtSMS_sender_2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSMS_sender_2.Location = new Point(97, 17);
            txtSMS_sender_2.Margin = new Padding(4, 3, 4, 3);
            txtSMS_sender_2.Name = "txtSMS_sender_2";
            txtSMS_sender_2.Size = new Size(383, 20);
            txtSMS_sender_2.TabIndex = 0;
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label36.Location = new Point(14, 21);
            label36.Margin = new Padding(4, 0, 4, 0);
            label36.Name = "label36";
            label36.Size = new Size(44, 13);
            label36.TabIndex = 0;
            label36.Text = "Sender:";
            // 
            // groupBox6
            // 
            groupBox6.BackColor = Color.Transparent;
            groupBox6.Controls.Add(btnSMS_off1);
            groupBox6.Controls.Add(chkSMS_flashsms1);
            groupBox6.Controls.Add(chkSMS_unicode1);
            groupBox6.Controls.Add(btnSMS_send_1);
            groupBox6.Controls.Add(txtSMS_SMS_1);
            groupBox6.Controls.Add(label30);
            groupBox6.Controls.Add(txtSMS_sender_1);
            groupBox6.Controls.Add(label32);
            groupBox6.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox6.Location = new Point(4, 3);
            groupBox6.Margin = new Padding(4, 3, 4, 3);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(4, 3, 4, 3);
            groupBox6.Size = new Size(660, 198);
            groupBox6.TabIndex = 1;
            groupBox6.TabStop = false;
            groupBox6.Text = "SMS_1";
            // 
            // btnSMS_off1
            // 
            btnSMS_off1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSMS_off1.Location = new Point(583, 108);
            btnSMS_off1.Margin = new Padding(4, 3, 4, 3);
            btnSMS_off1.Name = "btnSMS_off1";
            btnSMS_off1.Size = new Size(59, 77);
            btnSMS_off1.TabIndex = 6;
            btnSMS_off1.Text = "Stop";
            btnSMS_off1.UseVisualStyleBackColor = true;
            btnSMS_off1.Click += btnSMS_off1_Click;
            // 
            // chkSMS_flashsms1
            // 
            chkSMS_flashsms1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chkSMS_flashsms1.AutoSize = true;
            chkSMS_flashsms1.Location = new Point(531, 66);
            chkSMS_flashsms1.Margin = new Padding(4, 3, 4, 3);
            chkSMS_flashsms1.Name = "chkSMS_flashsms1";
            chkSMS_flashsms1.Size = new Size(69, 17);
            chkSMS_flashsms1.TabIndex = 5;
            chkSMS_flashsms1.Text = "Flashsms";
            chkSMS_flashsms1.UseVisualStyleBackColor = true;
            // 
            // chkSMS_unicode1
            // 
            chkSMS_unicode1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chkSMS_unicode1.AutoSize = true;
            chkSMS_unicode1.Location = new Point(531, 21);
            chkSMS_unicode1.Margin = new Padding(4, 3, 4, 3);
            chkSMS_unicode1.Name = "chkSMS_unicode1";
            chkSMS_unicode1.Size = new Size(66, 17);
            chkSMS_unicode1.TabIndex = 4;
            chkSMS_unicode1.Text = "Unicode";
            chkSMS_unicode1.UseVisualStyleBackColor = true;
            // 
            // btnSMS_send_1
            // 
            btnSMS_send_1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSMS_send_1.Location = new Point(520, 108);
            btnSMS_send_1.Margin = new Padding(4, 3, 4, 3);
            btnSMS_send_1.Name = "btnSMS_send_1";
            btnSMS_send_1.Size = new Size(59, 77);
            btnSMS_send_1.TabIndex = 3;
            btnSMS_send_1.Text = "Send";
            btnSMS_send_1.UseVisualStyleBackColor = true;
            btnSMS_send_1.Click += btnSMS_send_1_Click;
            // 
            // txtSMS_SMS_1
            // 
            txtSMS_SMS_1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSMS_SMS_1.Location = new Point(96, 51);
            txtSMS_SMS_1.Margin = new Padding(4, 3, 4, 3);
            txtSMS_SMS_1.Multiline = true;
            txtSMS_SMS_1.Name = "txtSMS_SMS_1";
            txtSMS_SMS_1.ScrollBars = ScrollBars.Both;
            txtSMS_SMS_1.Size = new Size(384, 139);
            txtSMS_SMS_1.TabIndex = 2;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label30.Location = new Point(27, 51);
            label30.Margin = new Padding(4, 0, 4, 0);
            label30.Name = "label30";
            label30.Size = new Size(33, 13);
            label30.TabIndex = 1;
            label30.Text = "SMS:";
            // 
            // txtSMS_sender_1
            // 
            txtSMS_sender_1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSMS_sender_1.Location = new Point(97, 17);
            txtSMS_sender_1.Margin = new Padding(4, 3, 4, 3);
            txtSMS_sender_1.Name = "txtSMS_sender_1";
            txtSMS_sender_1.Size = new Size(383, 20);
            txtSMS_sender_1.TabIndex = 0;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label32.Location = new Point(14, 21);
            label32.Margin = new Padding(4, 0, 4, 0);
            label32.Name = "label32";
            label32.Size = new Size(44, 13);
            label32.TabIndex = 0;
            label32.Text = "Sender:";
            // 
            // tabPage_SWEEP
            // 
            tabPage_SWEEP.Controls.Add(groupBox9);
            tabPage_SWEEP.Controls.Add(groupBox8);
            tabPage_SWEEP.Location = new Point(4, 24);
            tabPage_SWEEP.Margin = new Padding(4, 3, 4, 3);
            tabPage_SWEEP.Name = "tabPage_SWEEP";
            tabPage_SWEEP.Size = new Size(1338, 212);
            tabPage_SWEEP.TabIndex = 3;
            tabPage_SWEEP.Text = "Sweep";
            tabPage_SWEEP.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            groupBox9.BackColor = Color.Transparent;
            groupBox9.Controls.Add(config2g);
            groupBox9.Controls.Add(btnSweep_search2g);
            groupBox9.Controls.Add(gridSweep_2);
            groupBox9.Location = new Point(665, 3);
            groupBox9.Margin = new Padding(4, 3, 4, 3);
            groupBox9.Name = "groupBox9";
            groupBox9.Padding = new Padding(4, 3, 4, 3);
            groupBox9.Size = new Size(547, 204);
            groupBox9.TabIndex = 2;
            groupBox9.TabStop = false;
            groupBox9.Text = "2G OPERATE:";
            // 
            // config2g
            // 
            config2g.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            config2g.Location = new Point(443, 111);
            config2g.Margin = new Padding(4, 3, 4, 3);
            config2g.Name = "config2g";
            config2g.Size = new Size(86, 67);
            config2g.TabIndex = 3;
            config2g.Text = "SET 2G";
            config2g.UseVisualStyleBackColor = true;
            config2g.Click += config2g_Click;
            // 
            // btnSweep_search2g
            // 
            btnSweep_search2g.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSweep_search2g.Location = new Point(443, 36);
            btnSweep_search2g.Margin = new Padding(4, 3, 4, 3);
            btnSweep_search2g.Name = "btnSweep_search2g";
            btnSweep_search2g.Size = new Size(86, 67);
            btnSweep_search2g.TabIndex = 2;
            btnSweep_search2g.Text = "SWP 2G";
            btnSweep_search2g.UseVisualStyleBackColor = true;
            btnSweep_search2g.Click += btnSweep_search2g_Click;
            // 
            // gridSweep_2
            // 
            gridSweep_2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridSweep_2.Columns.AddRange(new DataGridViewColumn[] { GSMARFCN, GSMMCC, GSMMNC, RSRP, GSMOPERATE });
            gridSweep_2.Location = new Point(9, 25);
            gridSweep_2.Margin = new Padding(4, 3, 4, 3);
            gridSweep_2.Name = "gridSweep_2";
            gridSweep_2.RowTemplate.Height = 23;
            gridSweep_2.Size = new Size(401, 162);
            gridSweep_2.TabIndex = 0;
            // 
            // GSMARFCN
            // 
            GSMARFCN.HeaderText = "AFRCN";
            GSMARFCN.Name = "GSMARFCN";
            GSMARFCN.Width = 50;
            // 
            // GSMMCC
            // 
            GSMMCC.HeaderText = "MCC";
            GSMMCC.Name = "GSMMCC";
            GSMMCC.Width = 50;
            // 
            // GSMMNC
            // 
            GSMMNC.HeaderText = "MNC";
            GSMMNC.Name = "GSMMNC";
            GSMMNC.Width = 50;
            // 
            // RSRP
            // 
            RSRP.HeaderText = "RSRP";
            RSRP.Name = "RSRP";
            RSRP.Width = 50;
            // 
            // GSMOPERATE
            // 
            GSMOPERATE.HeaderText = "OPERATE";
            GSMOPERATE.Name = "GSMOPERATE";
            // 
            // groupBox8
            // 
            groupBox8.BackColor = Color.Transparent;
            groupBox8.Controls.Add(btnSweep_config4g);
            groupBox8.Controls.Add(btnSweep_search4g);
            groupBox8.Controls.Add(gridSweep_1);
            groupBox8.Location = new Point(4, 3);
            groupBox8.Margin = new Padding(4, 3, 4, 3);
            groupBox8.Name = "groupBox8";
            groupBox8.Padding = new Padding(4, 3, 4, 3);
            groupBox8.Size = new Size(654, 204);
            groupBox8.TabIndex = 1;
            groupBox8.TabStop = false;
            groupBox8.Text = "4G Operate:";
            // 
            // btnSweep_config4g
            // 
            btnSweep_config4g.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSweep_config4g.Location = new Point(552, 111);
            btnSweep_config4g.Margin = new Padding(4, 3, 4, 3);
            btnSweep_config4g.Name = "btnSweep_config4g";
            btnSweep_config4g.Size = new Size(86, 67);
            btnSweep_config4g.TabIndex = 1;
            btnSweep_config4g.Text = "SET 4G";
            btnSweep_config4g.UseVisualStyleBackColor = true;
            btnSweep_config4g.Click += btnSweep_config4g_Click;
            // 
            // btnSweep_search4g
            // 
            btnSweep_search4g.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSweep_search4g.Location = new Point(552, 36);
            btnSweep_search4g.Margin = new Padding(4, 3, 4, 3);
            btnSweep_search4g.Name = "btnSweep_search4g";
            btnSweep_search4g.Size = new Size(86, 67);
            btnSweep_search4g.TabIndex = 1;
            btnSweep_search4g.Text = "SWP 4G";
            btnSweep_search4g.UseVisualStyleBackColor = true;
            btnSweep_search4g.Click += btnSweep_search4g_Click;
            // 
            // gridSweep_1
            // 
            gridSweep_1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridSweep_1.Columns.AddRange(new DataGridViewColumn[] { LTEEARFCN, MCC, MNC, MCC1, MNC1, OPERATE });
            gridSweep_1.Location = new Point(10, 25);
            gridSweep_1.Margin = new Padding(4, 3, 4, 3);
            gridSweep_1.Name = "gridSweep_1";
            gridSweep_1.RowTemplate.Height = 23;
            gridSweep_1.Size = new Size(518, 165);
            gridSweep_1.TabIndex = 0;
            // 
            // LTEEARFCN
            // 
            LTEEARFCN.HeaderText = "EARFCN";
            LTEEARFCN.Name = "LTEEARFCN";
            LTEEARFCN.Width = 80;
            // 
            // MCC
            // 
            MCC.HeaderText = "MCC_0";
            MCC.Name = "MCC";
            MCC.Width = 50;
            // 
            // MNC
            // 
            MNC.HeaderText = "MNC_0";
            MNC.Name = "MNC";
            MNC.Width = 50;
            // 
            // MCC1
            // 
            MCC1.HeaderText = "MCC_1";
            MCC1.Name = "MCC1";
            MCC1.Width = 50;
            // 
            // MNC1
            // 
            MNC1.HeaderText = "MNC_1";
            MNC1.Name = "MNC1";
            MNC1.Width = 50;
            // 
            // OPERATE
            // 
            OPERATE.HeaderText = "OPERATE";
            OPERATE.Name = "OPERATE";
            // 
            // tabChart
            // 
            tabChart.Location = new Point(4, 24);
            tabChart.Margin = new Padding(4, 3, 4, 3);
            tabChart.Name = "tabChart";
            tabChart.Padding = new Padding(4, 3, 4, 3);
            tabChart.Size = new Size(1338, 212);
            tabChart.TabIndex = 4;
            tabChart.Text = "Chart ";
            tabChart.UseVisualStyleBackColor = true;

            System.Windows.Forms.DataVisualization.Charting.ChartArea barChartArea = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea pieChartArea = new System.Windows.Forms.DataVisualization.Charting.ChartArea();

            barChart.Size = new Size(1100, 192);
            barChart.Location = new Point(15, 10);
            barChart.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            barChart.ChartAreas.Add(barChartArea);

            pieChart.Size = new Size(200, 192);
            pieChart.Location = new Point(1123, 10);
            pieChart.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pieChart.ChartAreas.Add(pieChartArea);

            barChart.ChartAreas[0].AxisX.LabelStyle.Format = "String";

            // Add a title to the chart
            Title title = new Title("SMS Count / Provider");
            barChart.Titles.Add(title);
            pieChart.Titles.Add(title);

            // Create two series for the chart
            Series chartSeries1 = new Series("SMS Count / Provider");
            Series chartSeries2 = new Series("SMS Count / Provider");

            chartSeries1.ChartType = SeriesChartType.Column;
            chartSeries1.YValueType = ChartValueType.UInt32;

            chartSeries2.ChartType = SeriesChartType.Pie;
            chartSeries2.XValueType = ChartValueType.String;
            chartSeries2.YValueType = ChartValueType.UInt32;

            /*
            chartSeries1.Points.AddXY(0, 50);
            chartSeries1.Points.AddXY(1, 40);
            chartSeries1.Points.AddXY(2, 30);
            chartSeries1.Points.AddXY(3, 20);
            chartSeries1.Points.AddXY(4, 10);

            string[] labels = new string[] { "Apple", "Banana", "Cherry", "Date", "Elderberry" };
            for (int i = 0; i < labels.Length; i++)
            {
                CustomLabel label = new CustomLabel();
                label.Text = labels[i];
                label.FromPosition = i-0.5;
                label.ToPosition = i + 0.5;
                label.ForeColor = Color.Black;

                barChartArea.AxisX.CustomLabels.Add(label);
            }

            chartSeries2.Points.AddXY("51010", 50);
            chartSeries2.Points.AddXY("51011", 40);
            chartSeries2.Points.AddXY("51089", 30);
            chartSeries2.Points.AddXY("51001", 20);
            chartSeries2.Points.AddXY("51088", 10);
            barChart.Invalidate();
            */

            barChart.Series.Add(chartSeries1);
            pieChart.Series.Add(chartSeries2);

            tabChart.Controls.Add(barChart);
            tabChart.Controls.Add(pieChart);

            // 
            // imsiimei
            // 
            imsiimei.AllowUserToAddRows = false;
            imsiimei.AllowUserToDeleteRows = false;
            imsiimei.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            imsiimei.Columns.AddRange(new DataGridViewColumn[] { ID, IMSI, IMEI, STATUE, RSSI, TIME, COUT, BBU, PROVIDER, COUNTRY, LOCATION});
            imsiimei.Dock = DockStyle.Fill;
            imsiimei.Location = new Point(0, 0);
            imsiimei.Margin = new Padding(4, 3, 4, 3);
            imsiimei.Name = "imsiimei";
            imsiimei.RowHeadersVisible = false;
            imsiimei.RowTemplate.Height = 23;
            imsiimei.Size = new Size(1301, 194);
            imsiimei.TabIndex = 5;
            // 
            // ID
            // 
            ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.Width = 50;
            // 
            // IMSI
            // 
            IMSI.HeaderText = "IMSI";
            IMSI.Name = "IMSI";
            IMSI.Width = 150;
            // 
            // IMEI
            // 
            IMEI.HeaderText = "IMEI";
            IMEI.Name = "IMEI";
            IMEI.Width = 150;
            // 
            // STATUE
            // 
            STATUE.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            STATUE.HeaderText = "STATUE";
            STATUE.Name = "STATUE";
            STATUE.Width = 70;
            // 
            // RSSI
            // 
            RSSI.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            RSSI.HeaderText = "RSSI";
            RSSI.Name = "RSSI";
            RSSI.Width = 70;
            // 
            // TIME
            // 
            TIME.HeaderText = "TIME";
            TIME.Name = "TIME";
            TIME.Width = 150;
            // 
            // COUT
            // 
            COUT.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            COUT.HeaderText = "COUT";
            COUT.Name = "COUT";
            COUT.Width = 50;
            // 
            // BBU
            // 
            BBU.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            BBU.HeaderText = "BBU";
            BBU.Name = "BBU";
            BBU.Width = 60;

            PROVIDER.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            PROVIDER.HeaderText = "PROVIDER";
            PROVIDER.Name = "PROVIDER";
            PROVIDER.Width = 150;

            COUNTRY.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            COUNTRY.HeaderText = "COUNTRY";
            COUNTRY.Name = "COUNTRY";
            COUNTRY.Width = 150;

            LOCATION.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            LOCATION.HeaderText = "LOCATION";
            LOCATION.Name = "LOCATION";
            LOCATION.Width = 150;
            // 
            // lvLogs
            // 
            lvLogs.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvLogs.Columns.AddRange(new ColumnHeader[] { colTime, colLog });
            lvLogs.Location = new Point(4, 2);
            lvLogs.Margin = new Padding(4, 3, 4, 3);
            lvLogs.Name = "lvLogs";
            lvLogs.Size = new Size(999, 197);
            lvLogs.TabIndex = 21;
            lvLogs.UseCompatibleStateImageBehavior = false;
            lvLogs.View = View.Details;
            // 
            // colTime
            // 
            colTime.Text = "Time";
            colTime.Width = 98;
            // 
            // colLog
            // 
            colLog.Text = "Log";
            colLog.Width = 838;
            // 
            // lblStatus_lte4rf
            // 
            lblStatus_lte4rf.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblStatus_lte4rf.AutoSize = true;
            lblStatus_lte4rf.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblStatus_lte4rf.Location = new Point(1202, 163);
            lblStatus_lte4rf.Margin = new Padding(4, 0, 4, 0);
            lblStatus_lte4rf.Name = "lblStatus_lte4rf";
            lblStatus_lte4rf.Size = new Size(59, 13);
            lblStatus_lte4rf.TabIndex = 33;
            lblStatus_lte4rf.Text = "disconnect";
            // 
            // label37
            // 
            label37.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label37.AutoSize = true;
            label37.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label37.Location = new Point(1065, 163);
            label37.Margin = new Padding(4, 0, 4, 0);
            label37.Name = "label37";
            label37.Size = new Size(69, 13);
            label37.TabIndex = 32;
            label37.Text = "4G_4 Status:";
            // 
            // lblStatus_lte3rf
            // 
            lblStatus_lte3rf.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblStatus_lte3rf.AutoSize = true;
            lblStatus_lte3rf.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblStatus_lte3rf.Location = new Point(1202, 128);
            lblStatus_lte3rf.Margin = new Padding(4, 0, 4, 0);
            lblStatus_lte3rf.Name = "lblStatus_lte3rf";
            lblStatus_lte3rf.Size = new Size(59, 13);
            lblStatus_lte3rf.TabIndex = 31;
            lblStatus_lte3rf.Text = "disconnect";
            // 
            // label38
            // 
            label38.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label38.AutoSize = true;
            label38.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label38.Location = new Point(1065, 128);
            label38.Margin = new Padding(4, 0, 4, 0);
            label38.Name = "label38";
            label38.Size = new Size(69, 13);
            label38.TabIndex = 30;
            label38.Text = "4G_3 Status:";
            // 
            // lblStatus_lte2rf
            // 
            lblStatus_lte2rf.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblStatus_lte2rf.AutoSize = true;
            lblStatus_lte2rf.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblStatus_lte2rf.Location = new Point(1202, 196);
            lblStatus_lte2rf.Margin = new Padding(4, 0, 4, 0);
            lblStatus_lte2rf.Name = "lblStatus_lte2rf";
            lblStatus_lte2rf.Size = new Size(59, 13);
            lblStatus_lte2rf.TabIndex = 29;
            lblStatus_lte2rf.Text = "disconnect";
            lblStatus_lte2rf.Visible = false;
            // 
            // label39
            // 
            label39.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label39.AutoSize = true;
            label39.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label39.Location = new Point(1065, 196);
            label39.Margin = new Padding(4, 0, 4, 0);
            label39.Name = "label39";
            label39.Size = new Size(69, 13);
            label39.TabIndex = 28;
            label39.Text = "4G_2 Status:";
            label39.Visible = false;
            // 
            // lblStatus_lte1rf
            // 
            lblStatus_lte1rf.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblStatus_lte1rf.AutoSize = true;
            lblStatus_lte1rf.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblStatus_lte1rf.Location = new Point(1202, 96);
            lblStatus_lte1rf.Margin = new Padding(4, 0, 4, 0);
            lblStatus_lte1rf.Name = "lblStatus_lte1rf";
            lblStatus_lte1rf.Size = new Size(59, 13);
            lblStatus_lte1rf.TabIndex = 27;
            lblStatus_lte1rf.Text = "disconnect";
            // 
            // label40
            // 
            label40.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label40.AutoSize = true;
            label40.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label40.Location = new Point(1065, 96);
            label40.Margin = new Padding(4, 0, 4, 0);
            label40.Name = "label40";
            label40.Size = new Size(69, 13);
            label40.TabIndex = 26;
            label40.Text = "4G_1 Status:";
            // 
            // lblStatus_gsm2rf
            // 
            lblStatus_gsm2rf.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblStatus_gsm2rf.AutoSize = true;
            lblStatus_gsm2rf.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblStatus_gsm2rf.Location = new Point(1202, 61);
            lblStatus_gsm2rf.Margin = new Padding(4, 0, 4, 0);
            lblStatus_gsm2rf.Name = "lblStatus_gsm2rf";
            lblStatus_gsm2rf.Size = new Size(59, 13);
            lblStatus_gsm2rf.TabIndex = 25;
            lblStatus_gsm2rf.Text = "disconnect";
            // 
            // label42
            // 
            label42.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label42.AutoSize = true;
            label42.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label42.Location = new Point(1054, 61);
            label42.Margin = new Padding(4, 0, 4, 0);
            label42.Name = "label42";
            label42.Size = new Size(79, 13);
            label42.TabIndex = 24;
            label42.Text = "GSM_2 Status:";
            // 
            // lblStatus_gsm1rf
            // 
            lblStatus_gsm1rf.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblStatus_gsm1rf.AutoSize = true;
            lblStatus_gsm1rf.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblStatus_gsm1rf.Location = new Point(1202, 25);
            lblStatus_gsm1rf.Margin = new Padding(4, 0, 4, 0);
            lblStatus_gsm1rf.Name = "lblStatus_gsm1rf";
            lblStatus_gsm1rf.Size = new Size(59, 13);
            lblStatus_gsm1rf.TabIndex = 23;
            lblStatus_gsm1rf.Text = "disconnect";
            // 
            // label44
            // 
            label44.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label44.AutoSize = true;
            label44.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label44.Location = new Point(1054, 25);
            label44.Margin = new Padding(4, 0, 4, 0);
            label44.Name = "label44";
            label44.Size = new Size(79, 13);
            label44.TabIndex = 22;
            label44.Text = "GSM_1 Status:";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 773);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 16, 0);
            statusStrip1.Size = new Size(1396, 22);
            statusStrip1.TabIndex = 34;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(39, 17);
            toolStripStatusLabel1.Text = "Ready";
            // 
            // splitContainer2
            // 
            splitContainer2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer2.Location = new Point(22, 359);
            splitContainer2.Margin = new Padding(4, 3, 4, 3);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(imsiimei);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(lvLogs);
            splitContainer2.Panel2.Controls.Add(label44);
            splitContainer2.Panel2.Controls.Add(lblStatus_gsm1rf);
            splitContainer2.Panel2.Controls.Add(lblStatus_lte4rf);
            splitContainer2.Panel2.Controls.Add(label42);
            splitContainer2.Panel2.Controls.Add(label37);
            splitContainer2.Panel2.Controls.Add(lblStatus_gsm2rf);
            splitContainer2.Panel2.Controls.Add(lblStatus_lte3rf);
            splitContainer2.Panel2.Controls.Add(label40);
            splitContainer2.Panel2.Controls.Add(label38);
            splitContainer2.Panel2.Controls.Add(lblStatus_lte1rf);
            splitContainer2.Panel2.Controls.Add(lblStatus_lte2rf);
            splitContainer2.Panel2.Controls.Add(label39);
            splitContainer2.Size = new Size(1337, 404);
            splitContainer2.SplitterDistance = 194;
            splitContainer2.SplitterWidth = 5;
            splitContainer2.TabIndex = 36;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1396, 795);
            Controls.Add(splitContainer2);
            Controls.Add(statusStrip1);
            Controls.Add(tabControl);
            Controls.Add(btnCSV);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Controls.Add(cmbIPAddress);
            Controls.Add(label1);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "MainForm";
            Text = "4G SMS Manger v1.2";
            Load += MainForm_Load;
            tabControl.ResumeLayout(false);
            tabPage_2G.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            gsm1group.ResumeLayout(false);
            gsm1group.PerformLayout();
            tabPage_4G.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            lte1group.ResumeLayout(false);
            lte1group.PerformLayout();
            tabPage_SMS.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            tabPage_SWEEP.ResumeLayout(false);
            groupBox9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridSweep_2).EndInit();
            groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridSweep_1).EndInit();
            ((System.ComponentModel.ISupportInitialize)imsiimei).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbIPAddress;
        private Button btnStart;
        private Button btnStop;
        private Button btnCSV;
        private TabControl tabControl;
        private TabPage tabPage_2G;
        private TabPage tabPage_4G;
        private TabPage tabPage_SMS;
        private TabPage tabPage_SWEEP;
        private GroupBox gsm1group;
        private TextBox txt_gsm1cro1;
        private Label label41;
        private TextBox txt_gsm1cro0;
        private Label label35;
        private Label label31;
        private TextBox txt_gsm1cid1;
        private Label label33;
        private TextBox txt_gsm1lac1;
        private Label label29;
        private TextBox txt_gsm1cid0;
        private Label label26;
        private TextBox txt_gsm1att0;
        private TextBox txt_gsm1lac0;
        private Label label22;
        private Button btn2G_setgsm1;
        private Button btn2G_getgsm1;
        private TextBox txt_mcc_2;
        private TextBox txt_mnc_2;
        private TextBox txt_mnc_1;
        private TextBox txt_mcc_1;
        private TextBox txt_arfcn1;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private GroupBox groupBox1;
        private TextBox txt_gsm2cro1;
        private Label label5;
        private TextBox txt_gsm2cro0;
        private Label label8;
        private Label label9;
        private TextBox txt_gsm2cid1;
        private Label label10;
        private TextBox txt_gsm2lac1;
        private Label label11;
        private TextBox txt_gsm2cid0;
        private Label label12;
        private TextBox txt_gsm2att0;
        private TextBox txt_gsm2lac0;
        private Label label13;
        private Button btn2G_setgsm2;
        private Button btn2G_getgsm2;
        private TextBox txt_mcc_4;
        private TextBox txt_mnc_4;
        private TextBox txt_mnc_3;
        private TextBox txt_mcc_3;
        private TextBox txt_arfcn3;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private GroupBox lte1group;
        private TextBox txt_syncfreq;
        private Label label43;
        private Button btn4G_Save1;
        private TextBox txt_plmn4g1;
        private Label label19;
        private TextBox txt_earfcn4g1;
        private Label label20;
        private GroupBox groupBox2;
        private Button btn4G_Save2;
        private TextBox txt_plmn4g2;
        private Label label23;
        private TextBox txt_earfcn4g2;
        private Label label24;
        private GroupBox groupBox3;
        private Button btn4G_Save3;
        private TextBox txt_plmn4g3;
        private Label label27;
        private TextBox txt_earfcn4g3;
        private Label label28;
        private GroupBox groupBox4;
        private Button btn4G_Save4;
        private TextBox txt_plmn4g4;
        private Label label21;
        private TextBox txt_earfcn4g4;
        private Label label25;
        private GroupBox groupBox6;
        private Button btnSMS_off1;
        private CheckBox chkSMS_flashsms1;
        private CheckBox chkSMS_unicode1;
        private Button btnSMS_send_1;
        private TextBox txtSMS_SMS_1;
        private Label label30;
        private TextBox txtSMS_sender_1;
        private Label label32;
        private GroupBox groupBox5;
        private Button btnSMS_off2;
        private CheckBox chkSMS_flashsms2;
        private CheckBox chkSMS_unicode2;
        private Button btnSMS_send_2;
        private TextBox txtSMS_SMS_2;
        private Label label34;
        private TextBox txtSMS_sender_2;
        private Label label36;
        private GroupBox groupBox8;
        private DataGridView gridSweep_1;
        private DataGridViewTextBoxColumn LTEEARFCN;
        private DataGridViewTextBoxColumn MCC;
        private DataGridViewTextBoxColumn MNC;
        private DataGridViewTextBoxColumn MCC1;
        private DataGridViewTextBoxColumn MNC1;
        private DataGridViewTextBoxColumn OPERATE;
        private Button btnSweep_search4g;
        private Button btnSweep_config4g;
        private GroupBox groupBox9;
        private Button config2g;
        private Button btnSweep_search2g;
        private DataGridView gridSweep_2;
        private DataGridViewTextBoxColumn GSMARFCN;
        private DataGridViewTextBoxColumn GSMMCC;
        private DataGridViewTextBoxColumn GSMMNC;
        private DataGridViewTextBoxColumn RSRP;
        private DataGridViewTextBoxColumn GSMOPERATE;
        private DataGridView imsiimei;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn IMSI;
        private DataGridViewTextBoxColumn IMEI;
        private DataGridViewTextBoxColumn STATUE;
        private DataGridViewTextBoxColumn RSSI;
        private DataGridViewTextBoxColumn TIME;
        private DataGridViewTextBoxColumn COUT;
        private DataGridViewTextBoxColumn BBU;
        private DataGridViewTextBoxColumn PROVIDER;
        private DataGridViewTextBoxColumn COUNTRY;
        private DataGridViewTextBoxColumn LOCATION;
        private ListView lvLogs;
        private Label lblStatus_lte4rf;
        private Label label37;
        private Label lblStatus_lte3rf;
        private Label label38;
        private Label lblStatus_lte2rf;
        private Label label39;
        private Label lblStatus_lte1rf;
        private Label label40;
        private Label lblStatus_gsm2rf;
        private Label label42;
        private Label lblStatus_gsm1rf;
        private Label label44;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ColumnHeader colTime;
        private ColumnHeader colLog;
        private SplitContainer splitContainer2;
        private TabPage tabChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart barChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart pieChart;
    }
}

