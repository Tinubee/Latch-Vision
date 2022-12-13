namespace VISION
{
    partial class Frm_Main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Main));
            this.tlpUnder = new System.Windows.Forms.TableLayoutPanel();
            this.btn_ToolSetUp = new System.Windows.Forms.Button();
            this.btn_CamSet = new System.Windows.Forms.Button();
            this.btn_Model = new System.Windows.Forms.Button();
            this.btn_Analyze = new System.Windows.Forms.Button();
            this.btn_SystemSetup = new System.Windows.Forms.Button();
            this.tlpTopSide = new System.Windows.Forms.TableLayoutPanel();
            this.lb_CurruntModelName = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lb_Time = new System.Windows.Forms.Label();
            this.lb_Ver = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.btn_Status = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer_Setting = new System.Windows.Forms.Timer(this.components);
            this.bk_IO = new System.ComponentModel.BackgroundWorker();
            this.LightControl = new System.IO.Ports.SerialPort(this.components);
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.cdyDisplay3 = new Cognex.VisionPro.Display.CogDisplay();
            this.tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
            this.lb_Cam3_Result = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lb_Cam3_InsTime = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.cdyDisplay2 = new Cognex.VisionPro.Display.CogDisplay();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.lb_Cam2_Result = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lb_Cam2_InsTime = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.cdyDisplay = new Cognex.VisionPro.Display.CogDisplay();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_Cam1_Result = new System.Windows.Forms.Label();
            this.lb_Cam1_InsTime = new System.Windows.Forms.Label();
            this.Tab_IO = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel19 = new System.Windows.Forms.TableLayoutPanel();
            this.button21 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.btn_OUTPUT6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tableLayoutPanel20 = new System.Windows.Forms.TableLayoutPanel();
            this.button20 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.btn_OUTPUT5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tableLayoutPanel21 = new System.Windows.Forms.TableLayoutPanel();
            this.button17 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.btn_OUTPUT4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.tableLayoutPanel22 = new System.Windows.Forms.TableLayoutPanel();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.btn_OUTPUT3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.tableLayoutPanel23 = new System.Windows.Forms.TableLayoutPanel();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.btn_OUTPUT2 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.tableLayoutPanel24 = new System.Windows.Forms.TableLayoutPanel();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.btn_OUTPUT1 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.tableLayoutPanel25 = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_OUTPUT0 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.btn_INPUT15 = new System.Windows.Forms.Button();
            this.btn_INPUT14 = new System.Windows.Forms.Button();
            this.btn_INPUT13 = new System.Windows.Forms.Button();
            this.btn_INPUT12 = new System.Windows.Forms.Button();
            this.btn_INPUT11 = new System.Windows.Forms.Button();
            this.btn_INPUT10 = new System.Windows.Forms.Button();
            this.btn_INPUT9 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_INPUT8 = new System.Windows.Forms.Button();
            this.Tab_Log = new System.Windows.Forms.TabPage();
            this.logControl1 = new KimLib.LogControl();
            this.Main_TabControl = new System.Windows.Forms.TabControl();
            this.Tab_Home = new System.Windows.Forms.TabPage();
            this.Tab_Count = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel27 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel18 = new System.Windows.Forms.TableLayoutPanel();
            this.lb_CAM3_NGRATE = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.lb_CAM3_TOTAL = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.lb_CAM3_NG = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.lb_CAM3_OK = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.tableLayoutPanel17 = new System.Windows.Forms.TableLayoutPanel();
            this.lb_CAM2_NGRATE = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.lb_CAM2_TOTAL = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.lb_CAM2_NG = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.lb_CAM2_OK = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.tableLayoutPanel16 = new System.Windows.Forms.TableLayoutPanel();
            this.lb_CAM1_NGRATE = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.lb_CAM1_TOTAL = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lb_CAM1_NG = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lb_CAM1_OK = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_IO = new System.Windows.Forms.Button();
            this.btn_Log = new System.Windows.Forms.Button();
            this.btn_Count = new System.Windows.Forms.Button();
            this.tableLayoutPanel31 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Home = new System.Windows.Forms.Button();
            this.bk_AutoDelete = new System.ComponentModel.BackgroundWorker();
            this.tlpUnder.SuspendLayout();
            this.tlpTopSide.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cdyDisplay3)).BeginInit();
            this.tableLayoutPanel13.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cdyDisplay2)).BeginInit();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cdyDisplay)).BeginInit();
            this.tableLayoutPanel10.SuspendLayout();
            this.Tab_IO.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel19.SuspendLayout();
            this.tableLayoutPanel20.SuspendLayout();
            this.tableLayoutPanel21.SuspendLayout();
            this.tableLayoutPanel22.SuspendLayout();
            this.tableLayoutPanel23.SuspendLayout();
            this.tableLayoutPanel24.SuspendLayout();
            this.tableLayoutPanel25.SuspendLayout();
            this.Tab_Log.SuspendLayout();
            this.Main_TabControl.SuspendLayout();
            this.Tab_Home.SuspendLayout();
            this.Tab_Count.SuspendLayout();
            this.tableLayoutPanel27.SuspendLayout();
            this.tableLayoutPanel18.SuspendLayout();
            this.tableLayoutPanel17.SuspendLayout();
            this.tableLayoutPanel16.SuspendLayout();
            this.tableLayoutPanel31.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpUnder
            // 
            this.tlpUnder.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpUnder.ColumnCount = 5;
            this.tlpUnder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpUnder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpUnder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpUnder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpUnder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpUnder.Controls.Add(this.btn_ToolSetUp, 0, 0);
            this.tlpUnder.Controls.Add(this.btn_CamSet, 1, 0);
            this.tlpUnder.Controls.Add(this.btn_Model, 2, 0);
            this.tlpUnder.Controls.Add(this.btn_Analyze, 3, 0);
            this.tlpUnder.Controls.Add(this.btn_SystemSetup, 4, 0);
            this.tlpUnder.Location = new System.Drawing.Point(641, 77);
            this.tlpUnder.Margin = new System.Windows.Forms.Padding(0);
            this.tlpUnder.Name = "tlpUnder";
            this.tlpUnder.RowCount = 1;
            this.tlpUnder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpUnder.Size = new System.Drawing.Size(803, 77);
            this.tlpUnder.TabIndex = 1;
            // 
            // btn_ToolSetUp
            // 
            this.btn_ToolSetUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_ToolSetUp.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_ToolSetUp.Image = global::VISION.Properties.Resources.Setup;
            this.btn_ToolSetUp.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_ToolSetUp.Location = new System.Drawing.Point(1, 1);
            this.btn_ToolSetUp.Margin = new System.Windows.Forms.Padding(0);
            this.btn_ToolSetUp.Name = "btn_ToolSetUp";
            this.btn_ToolSetUp.Size = new System.Drawing.Size(159, 75);
            this.btn_ToolSetUp.TabIndex = 0;
            this.btn_ToolSetUp.Tag = "Front";
            this.btn_ToolSetUp.Text = "Tool Setting";
            this.btn_ToolSetUp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ToolSetUp.UseVisualStyleBackColor = true;
            this.btn_ToolSetUp.Click += new System.EventHandler(this.btn_ToolSetUp_Click);
            // 
            // btn_CamSet
            // 
            this.btn_CamSet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_CamSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_CamSet.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_CamSet.Image = global::VISION.Properties.Resources.OneShot;
            this.btn_CamSet.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_CamSet.Location = new System.Drawing.Point(161, 1);
            this.btn_CamSet.Margin = new System.Windows.Forms.Padding(0);
            this.btn_CamSet.Name = "btn_CamSet";
            this.btn_CamSet.Size = new System.Drawing.Size(159, 75);
            this.btn_CamSet.TabIndex = 51;
            this.btn_CamSet.Tag = "";
            this.btn_CamSet.Text = "Camera Setting";
            this.btn_CamSet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_CamSet.UseVisualStyleBackColor = true;
            this.btn_CamSet.Visible = false;
            this.btn_CamSet.Click += new System.EventHandler(this.btn_CamList_Click);
            // 
            // btn_Model
            // 
            this.btn_Model.BackColor = System.Drawing.Color.Transparent;
            this.btn_Model.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Model.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Model.Image = global::VISION.Properties.Resources.JobOpen;
            this.btn_Model.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Model.Location = new System.Drawing.Point(321, 1);
            this.btn_Model.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Model.Name = "btn_Model";
            this.btn_Model.Size = new System.Drawing.Size(159, 75);
            this.btn_Model.TabIndex = 2;
            this.btn_Model.Tag = "";
            this.btn_Model.Text = "Model";
            this.btn_Model.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Model.UseVisualStyleBackColor = false;
            this.btn_Model.Click += new System.EventHandler(this.btn_Model_Click);
            // 
            // btn_Analyze
            // 
            this.btn_Analyze.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Analyze.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Analyze.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Analyze.Image = global::VISION.Properties.Resources.Analyze;
            this.btn_Analyze.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Analyze.Location = new System.Drawing.Point(481, 1);
            this.btn_Analyze.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Analyze.Name = "btn_Analyze";
            this.btn_Analyze.Size = new System.Drawing.Size(159, 75);
            this.btn_Analyze.TabIndex = 52;
            this.btn_Analyze.Tag = "";
            this.btn_Analyze.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Analyze.UseVisualStyleBackColor = true;
            this.btn_Analyze.Visible = false;
            this.btn_Analyze.Click += new System.EventHandler(this.btn_Analyze_Click);
            // 
            // btn_SystemSetup
            // 
            this.btn_SystemSetup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_SystemSetup.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_SystemSetup.Image = global::VISION.Properties.Resources.Setting;
            this.btn_SystemSetup.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_SystemSetup.Location = new System.Drawing.Point(641, 1);
            this.btn_SystemSetup.Margin = new System.Windows.Forms.Padding(0);
            this.btn_SystemSetup.Name = "btn_SystemSetup";
            this.btn_SystemSetup.Size = new System.Drawing.Size(161, 75);
            this.btn_SystemSetup.TabIndex = 0;
            this.btn_SystemSetup.Text = "System Setting";
            this.btn_SystemSetup.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_SystemSetup.UseVisualStyleBackColor = true;
            this.btn_SystemSetup.Click += new System.EventHandler(this.btn_SystemSetup_Click);
            // 
            // tlpTopSide
            // 
            this.tlpTopSide.ColumnCount = 7;
            this.tlpTopSide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.65755F));
            this.tlpTopSide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.65533F));
            this.tlpTopSide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.14597F));
            this.tlpTopSide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.53649F));
            this.tlpTopSide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.669042F));
            this.tlpTopSide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.669042F));
            this.tlpTopSide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666586F));
            this.tlpTopSide.Controls.Add(this.lb_CurruntModelName, 3, 0);
            this.tlpTopSide.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.tlpTopSide.Controls.Add(this.btn_Exit, 6, 0);
            this.tlpTopSide.Controls.Add(this.btn_Stop, 5, 0);
            this.tlpTopSide.Controls.Add(this.btn_Status, 4, 0);
            this.tlpTopSide.Controls.Add(this.pictureBox1, 0, 0);
            this.tlpTopSide.Controls.Add(this.label1, 2, 0);
            this.tlpTopSide.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpTopSide.Location = new System.Drawing.Point(0, 0);
            this.tlpTopSide.Margin = new System.Windows.Forms.Padding(0);
            this.tlpTopSide.Name = "tlpTopSide";
            this.tlpTopSide.RowCount = 1;
            this.tlpTopSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTopSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tlpTopSide.Size = new System.Drawing.Size(1920, 77);
            this.tlpTopSide.TabIndex = 2;
            // 
            // lb_CurruntModelName
            // 
            this.lb_CurruntModelName.AutoSize = true;
            this.lb_CurruntModelName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lb_CurruntModelName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_CurruntModelName.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_CurruntModelName.Location = new System.Drawing.Point(1333, 3);
            this.lb_CurruntModelName.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.lb_CurruntModelName.Name = "lb_CurruntModelName";
            this.lb_CurruntModelName.Size = new System.Drawing.Size(202, 71);
            this.lb_CurruntModelName.TabIndex = 1;
            this.lb_CurruntModelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lb_Time, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lb_Ver, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(265, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(256, 71);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // lb_Time
            // 
            this.lb_Time.AutoSize = true;
            this.lb_Time.BackColor = System.Drawing.Color.Black;
            this.lb_Time.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Time.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_Time.ForeColor = System.Drawing.Color.White;
            this.lb_Time.Location = new System.Drawing.Point(0, 0);
            this.lb_Time.Margin = new System.Windows.Forms.Padding(0);
            this.lb_Time.Name = "lb_Time";
            this.lb_Time.Size = new System.Drawing.Size(256, 35);
            this.lb_Time.TabIndex = 0;
            this.lb_Time.Text = "0000-00-00 오전 00:00:00";
            this.lb_Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Ver
            // 
            this.lb_Ver.AutoSize = true;
            this.lb_Ver.BackColor = System.Drawing.Color.Black;
            this.lb_Ver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Ver.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_Ver.ForeColor = System.Drawing.Color.White;
            this.lb_Ver.Location = new System.Drawing.Point(0, 35);
            this.lb_Ver.Margin = new System.Windows.Forms.Padding(0);
            this.lb_Ver.Name = "lb_Ver";
            this.lb_Ver.Size = new System.Drawing.Size(256, 36);
            this.lb_Ver.TabIndex = 4;
            this.lb_Ver.Text = "Ver. 1.0.0";
            this.lb_Ver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Exit.Image = global::VISION.Properties.Resources.Close;
            this.btn_Exit.Location = new System.Drawing.Point(1791, 2);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(129, 73);
            this.btn_Exit.TabIndex = 0;
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Stop.Image = global::VISION.Properties.Resources.Stop;
            this.btn_Stop.Location = new System.Drawing.Point(1663, 2);
            this.btn_Stop.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(128, 73);
            this.btn_Stop.TabIndex = 9;
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // btn_Status
            // 
            this.btn_Status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Status.Image = global::VISION.Properties.Resources.Run;
            this.btn_Status.Location = new System.Drawing.Point(1535, 2);
            this.btn_Status.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.btn_Status.Name = "btn_Status";
            this.btn_Status.Size = new System.Drawing.Size(128, 73);
            this.btn_Status.TabIndex = 5;
            this.btn_Status.UseVisualStyleBackColor = true;
            this.btn_Status.Click += new System.EventHandler(this.btn_Status_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::VISION.Properties.Resources.logo1;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(524, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(809, 71);
            this.label1.TabIndex = 11;
            this.label1.Text = "Channel Vision Program";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer_Setting
            // 
            this.timer_Setting.Tick += new System.EventHandler(this.timer_Setting_Tick);
            // 
            // bk_IO
            // 
            this.bk_IO.WorkerSupportsCancellation = true;
            this.bk_IO.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bk_IO_DoWork);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel8, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1912, 919);
            this.tableLayoutPanel2.TabIndex = 26;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Controls.Add(this.cdyDisplay3, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel13, 0, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(1275, 1);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 2;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(636, 917);
            this.tableLayoutPanel8.TabIndex = 20;
            // 
            // cdyDisplay3
            // 
            this.cdyDisplay3.ColorMapLowerClipColor = System.Drawing.Color.Black;
            this.cdyDisplay3.ColorMapLowerRoiLimit = 0D;
            this.cdyDisplay3.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
            this.cdyDisplay3.ColorMapUpperClipColor = System.Drawing.Color.Black;
            this.cdyDisplay3.ColorMapUpperRoiLimit = 1D;
            this.cdyDisplay3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cdyDisplay3.DoubleTapZoomCycleLength = 2;
            this.cdyDisplay3.DoubleTapZoomSensitivity = 2.5D;
            this.cdyDisplay3.Location = new System.Drawing.Point(2, 121);
            this.cdyDisplay3.Margin = new System.Windows.Forms.Padding(1);
            this.cdyDisplay3.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.cdyDisplay3.MouseWheelSensitivity = 1D;
            this.cdyDisplay3.Name = "cdyDisplay3";
            this.cdyDisplay3.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("cdyDisplay3.OcxState")));
            this.cdyDisplay3.Size = new System.Drawing.Size(632, 794);
            this.cdyDisplay3.TabIndex = 10;
            // 
            // tableLayoutPanel13
            // 
            this.tableLayoutPanel13.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel13.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel13.ColumnCount = 3;
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel13.Controls.Add(this.lb_Cam3_Result, 1, 0);
            this.tableLayoutPanel13.Controls.Add(this.label13, 0, 0);
            this.tableLayoutPanel13.Controls.Add(this.lb_Cam3_InsTime, 2, 0);
            this.tableLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel13.ForeColor = System.Drawing.Color.White;
            this.tableLayoutPanel13.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel13.Name = "tableLayoutPanel13";
            this.tableLayoutPanel13.RowCount = 1;
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel13.Size = new System.Drawing.Size(628, 112);
            this.tableLayoutPanel13.TabIndex = 9;
            // 
            // lb_Cam3_Result
            // 
            this.lb_Cam3_Result.AutoSize = true;
            this.lb_Cam3_Result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam3_Result.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_Cam3_Result.Location = new System.Drawing.Point(129, 1);
            this.lb_Cam3_Result.Name = "lb_Cam3_Result";
            this.lb_Cam3_Result.Size = new System.Drawing.Size(306, 110);
            this.lb_Cam3_Result.TabIndex = 1;
            this.lb_Cam3_Result.Text = "Result";
            this.lb_Cam3_Result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.Location = new System.Drawing.Point(4, 1);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 110);
            this.label13.TabIndex = 0;
            this.label13.Text = "CAM 3";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam3_InsTime
            // 
            this.lb_Cam3_InsTime.AutoSize = true;
            this.lb_Cam3_InsTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam3_InsTime.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_Cam3_InsTime.Location = new System.Drawing.Point(442, 1);
            this.lb_Cam3_InsTime.Name = "lb_Cam3_InsTime";
            this.lb_Cam3_InsTime.Size = new System.Drawing.Size(182, 110);
            this.lb_Cam3_InsTime.TabIndex = 2;
            this.lb_Cam3_InsTime.Text = "0msec";
            this.lb_Cam3_InsTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.cdyDisplay2, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(638, 1);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(636, 917);
            this.tableLayoutPanel5.TabIndex = 19;
            // 
            // cdyDisplay2
            // 
            this.cdyDisplay2.ColorMapLowerClipColor = System.Drawing.Color.Black;
            this.cdyDisplay2.ColorMapLowerRoiLimit = 0D;
            this.cdyDisplay2.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
            this.cdyDisplay2.ColorMapUpperClipColor = System.Drawing.Color.Black;
            this.cdyDisplay2.ColorMapUpperRoiLimit = 1D;
            this.cdyDisplay2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cdyDisplay2.DoubleTapZoomCycleLength = 2;
            this.cdyDisplay2.DoubleTapZoomSensitivity = 2.5D;
            this.cdyDisplay2.Location = new System.Drawing.Point(2, 121);
            this.cdyDisplay2.Margin = new System.Windows.Forms.Padding(1);
            this.cdyDisplay2.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.cdyDisplay2.MouseWheelSensitivity = 1D;
            this.cdyDisplay2.Name = "cdyDisplay2";
            this.cdyDisplay2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("cdyDisplay2.OcxState")));
            this.cdyDisplay2.Size = new System.Drawing.Size(632, 794);
            this.cdyDisplay2.TabIndex = 8;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel6.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel6.Controls.Add(this.lb_Cam2_Result, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.label11, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.lb_Cam2_InsTime, 2, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.ForeColor = System.Drawing.Color.White;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(628, 112);
            this.tableLayoutPanel6.TabIndex = 9;
            // 
            // lb_Cam2_Result
            // 
            this.lb_Cam2_Result.AutoSize = true;
            this.lb_Cam2_Result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam2_Result.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_Cam2_Result.Location = new System.Drawing.Point(129, 1);
            this.lb_Cam2_Result.Name = "lb_Cam2_Result";
            this.lb_Cam2_Result.Size = new System.Drawing.Size(306, 110);
            this.lb_Cam2_Result.TabIndex = 1;
            this.lb_Cam2_Result.Text = "Result";
            this.lb_Cam2_Result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(4, 1);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 110);
            this.label11.TabIndex = 0;
            this.label11.Text = "CAM 2";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam2_InsTime
            // 
            this.lb_Cam2_InsTime.AutoSize = true;
            this.lb_Cam2_InsTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam2_InsTime.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_Cam2_InsTime.Location = new System.Drawing.Point(442, 1);
            this.lb_Cam2_InsTime.Name = "lb_Cam2_InsTime";
            this.lb_Cam2_InsTime.Size = new System.Drawing.Size(182, 110);
            this.lb_Cam2_InsTime.TabIndex = 2;
            this.lb_Cam2_InsTime.Text = "0msec";
            this.lb_Cam2_InsTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.cdyDisplay, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel10, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.ForeColor = System.Drawing.Color.White;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(1, 1);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(636, 917);
            this.tableLayoutPanel4.TabIndex = 13;
            // 
            // cdyDisplay
            // 
            this.cdyDisplay.ColorMapLowerClipColor = System.Drawing.Color.Black;
            this.cdyDisplay.ColorMapLowerRoiLimit = 0D;
            this.cdyDisplay.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
            this.cdyDisplay.ColorMapUpperClipColor = System.Drawing.Color.Black;
            this.cdyDisplay.ColorMapUpperRoiLimit = 1D;
            this.cdyDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cdyDisplay.DoubleTapZoomCycleLength = 2;
            this.cdyDisplay.DoubleTapZoomSensitivity = 2.5D;
            this.cdyDisplay.Location = new System.Drawing.Point(2, 121);
            this.cdyDisplay.Margin = new System.Windows.Forms.Padding(1);
            this.cdyDisplay.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.cdyDisplay.MouseWheelSensitivity = 1D;
            this.cdyDisplay.Name = "cdyDisplay";
            this.cdyDisplay.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("cdyDisplay.OcxState")));
            this.cdyDisplay.Size = new System.Drawing.Size(632, 794);
            this.cdyDisplay.TabIndex = 8;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel10.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel10.ColumnCount = 3;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel10.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.lb_Cam1_Result, 1, 0);
            this.tableLayoutPanel10.Controls.Add(this.lb_Cam1_InsTime, 2, 0);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 1;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(628, 112);
            this.tableLayoutPanel10.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(4, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 110);
            this.label4.TabIndex = 0;
            this.label4.Text = "CAM 1";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1_Result
            // 
            this.lb_Cam1_Result.AutoSize = true;
            this.lb_Cam1_Result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1_Result.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_Cam1_Result.Location = new System.Drawing.Point(129, 1);
            this.lb_Cam1_Result.Name = "lb_Cam1_Result";
            this.lb_Cam1_Result.Size = new System.Drawing.Size(306, 110);
            this.lb_Cam1_Result.TabIndex = 1;
            this.lb_Cam1_Result.Text = "Result";
            this.lb_Cam1_Result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1_InsTime
            // 
            this.lb_Cam1_InsTime.AutoSize = true;
            this.lb_Cam1_InsTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1_InsTime.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_Cam1_InsTime.Location = new System.Drawing.Point(442, 1);
            this.lb_Cam1_InsTime.Name = "lb_Cam1_InsTime";
            this.lb_Cam1_InsTime.Size = new System.Drawing.Size(182, 110);
            this.lb_Cam1_InsTime.TabIndex = 3;
            this.lb_Cam1_InsTime.Text = "0msec";
            this.lb_Cam1_InsTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Tab_IO
            // 
            this.Tab_IO.Controls.Add(this.tableLayoutPanel3);
            this.Tab_IO.Location = new System.Drawing.Point(4, 22);
            this.Tab_IO.Name = "Tab_IO";
            this.Tab_IO.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_IO.Size = new System.Drawing.Size(1912, 919);
            this.Tab_IO.TabIndex = 1;
            this.Tab_IO.Text = "I/O";
            this.Tab_IO.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.DimGray;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel19, 1, 8);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel20, 1, 7);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel21, 1, 6);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel22, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel23, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel24, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel25, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.btn_INPUT15, 0, 8);
            this.tableLayoutPanel3.Controls.Add(this.btn_INPUT14, 0, 7);
            this.tableLayoutPanel3.Controls.Add(this.btn_INPUT13, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.btn_INPUT12, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.btn_INPUT11, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.btn_INPUT10, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.btn_INPUT9, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_INPUT8, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 9;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1906, 913);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // tableLayoutPanel19
            // 
            this.tableLayoutPanel19.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel19.ColumnCount = 4;
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel19.Controls.Add(this.button21, 3, 0);
            this.tableLayoutPanel19.Controls.Add(this.button19, 0, 0);
            this.tableLayoutPanel19.Controls.Add(this.btn_OUTPUT6, 0, 0);
            this.tableLayoutPanel19.Controls.Add(this.button3, 2, 0);
            this.tableLayoutPanel19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel19.Location = new System.Drawing.Point(956, 811);
            this.tableLayoutPanel19.Name = "tableLayoutPanel19";
            this.tableLayoutPanel19.RowCount = 1;
            this.tableLayoutPanel19.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel19.Size = new System.Drawing.Size(947, 99);
            this.tableLayoutPanel19.TabIndex = 41;
            // 
            // button21
            // 
            this.button21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button21.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button21.Location = new System.Drawing.Point(712, 4);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(231, 91);
            this.button21.TabIndex = 44;
            this.button21.Tag = "14";
            this.button21.Text = "14OFF";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.OUTPUTOFF_Click);
            // 
            // button19
            // 
            this.button19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button19.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button19.Location = new System.Drawing.Point(240, 4);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(229, 91);
            this.button19.TabIndex = 43;
            this.button19.Tag = "6";
            this.button19.Text = "6 OFF";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.OUTPUTOFF_Click);
            // 
            // btn_OUTPUT6
            // 
            this.btn_OUTPUT6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_OUTPUT6.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_OUTPUT6.Location = new System.Drawing.Point(4, 4);
            this.btn_OUTPUT6.Name = "btn_OUTPUT6";
            this.btn_OUTPUT6.Size = new System.Drawing.Size(229, 91);
            this.btn_OUTPUT6.TabIndex = 15;
            this.btn_OUTPUT6.Tag = "6";
            this.btn_OUTPUT6.Text = "6 ON";
            this.btn_OUTPUT6.UseVisualStyleBackColor = true;
            this.btn_OUTPUT6.Click += new System.EventHandler(this.OUTPUT_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3.Location = new System.Drawing.Point(476, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(229, 91);
            this.button3.TabIndex = 41;
            this.button3.Tag = "14";
            this.button3.Text = "14ON";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.OUTPUT_Click);
            // 
            // tableLayoutPanel20
            // 
            this.tableLayoutPanel20.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel20.ColumnCount = 4;
            this.tableLayoutPanel20.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel20.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel20.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel20.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel20.Controls.Add(this.button20, 3, 0);
            this.tableLayoutPanel20.Controls.Add(this.button18, 1, 0);
            this.tableLayoutPanel20.Controls.Add(this.btn_OUTPUT5, 0, 0);
            this.tableLayoutPanel20.Controls.Add(this.button4, 2, 0);
            this.tableLayoutPanel20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel20.Location = new System.Drawing.Point(956, 710);
            this.tableLayoutPanel20.Name = "tableLayoutPanel20";
            this.tableLayoutPanel20.RowCount = 1;
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel20.Size = new System.Drawing.Size(947, 95);
            this.tableLayoutPanel20.TabIndex = 40;
            // 
            // button20
            // 
            this.button20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button20.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button20.Location = new System.Drawing.Point(712, 4);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(231, 87);
            this.button20.TabIndex = 44;
            this.button20.Tag = "13";
            this.button20.Text = "13OFF";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.OUTPUTOFF_Click);
            // 
            // button18
            // 
            this.button18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button18.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button18.Location = new System.Drawing.Point(240, 4);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(229, 87);
            this.button18.TabIndex = 43;
            this.button18.Tag = "5";
            this.button18.Text = "5 OFF";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.OUTPUTOFF_Click);
            // 
            // btn_OUTPUT5
            // 
            this.btn_OUTPUT5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_OUTPUT5.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_OUTPUT5.Location = new System.Drawing.Point(4, 4);
            this.btn_OUTPUT5.Name = "btn_OUTPUT5";
            this.btn_OUTPUT5.Size = new System.Drawing.Size(229, 87);
            this.btn_OUTPUT5.TabIndex = 13;
            this.btn_OUTPUT5.Tag = "5";
            this.btn_OUTPUT5.Text = "5 ON";
            this.btn_OUTPUT5.UseVisualStyleBackColor = true;
            this.btn_OUTPUT5.Click += new System.EventHandler(this.OUTPUT_Click);
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button4.Location = new System.Drawing.Point(476, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(229, 87);
            this.button4.TabIndex = 40;
            this.button4.Tag = "13";
            this.button4.Text = "13ON";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.OUTPUT_Click);
            // 
            // tableLayoutPanel21
            // 
            this.tableLayoutPanel21.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel21.ColumnCount = 4;
            this.tableLayoutPanel21.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel21.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel21.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel21.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel21.Controls.Add(this.button17, 3, 0);
            this.tableLayoutPanel21.Controls.Add(this.button16, 0, 0);
            this.tableLayoutPanel21.Controls.Add(this.btn_OUTPUT4, 0, 0);
            this.tableLayoutPanel21.Controls.Add(this.button5, 2, 0);
            this.tableLayoutPanel21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel21.Location = new System.Drawing.Point(956, 609);
            this.tableLayoutPanel21.Name = "tableLayoutPanel21";
            this.tableLayoutPanel21.RowCount = 1;
            this.tableLayoutPanel21.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel21.Size = new System.Drawing.Size(947, 95);
            this.tableLayoutPanel21.TabIndex = 39;
            // 
            // button17
            // 
            this.button17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button17.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button17.Location = new System.Drawing.Point(712, 4);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(231, 87);
            this.button17.TabIndex = 44;
            this.button17.Tag = "12";
            this.button17.Text = "12OFF";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.OUTPUTOFF_Click);
            // 
            // button16
            // 
            this.button16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button16.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button16.Location = new System.Drawing.Point(240, 4);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(229, 87);
            this.button16.TabIndex = 43;
            this.button16.Tag = "4";
            this.button16.Text = "4 OFF";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.OUTPUTOFF_Click);
            // 
            // btn_OUTPUT4
            // 
            this.btn_OUTPUT4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_OUTPUT4.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_OUTPUT4.Location = new System.Drawing.Point(4, 4);
            this.btn_OUTPUT4.Name = "btn_OUTPUT4";
            this.btn_OUTPUT4.Size = new System.Drawing.Size(229, 87);
            this.btn_OUTPUT4.TabIndex = 11;
            this.btn_OUTPUT4.Tag = "4";
            this.btn_OUTPUT4.Text = "4 ON";
            this.btn_OUTPUT4.UseVisualStyleBackColor = true;
            this.btn_OUTPUT4.Click += new System.EventHandler(this.OUTPUT_Click);
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button5.Location = new System.Drawing.Point(476, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(229, 87);
            this.button5.TabIndex = 39;
            this.button5.Tag = "12";
            this.button5.Text = "12ON";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.OUTPUT_Click);
            // 
            // tableLayoutPanel22
            // 
            this.tableLayoutPanel22.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel22.ColumnCount = 4;
            this.tableLayoutPanel22.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel22.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel22.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel22.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel22.Controls.Add(this.button15, 3, 0);
            this.tableLayoutPanel22.Controls.Add(this.button14, 0, 0);
            this.tableLayoutPanel22.Controls.Add(this.btn_OUTPUT3, 0, 0);
            this.tableLayoutPanel22.Controls.Add(this.button6, 2, 0);
            this.tableLayoutPanel22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel22.Location = new System.Drawing.Point(956, 508);
            this.tableLayoutPanel22.Name = "tableLayoutPanel22";
            this.tableLayoutPanel22.RowCount = 1;
            this.tableLayoutPanel22.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel22.Size = new System.Drawing.Size(947, 95);
            this.tableLayoutPanel22.TabIndex = 38;
            // 
            // button15
            // 
            this.button15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button15.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button15.Location = new System.Drawing.Point(712, 4);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(231, 87);
            this.button15.TabIndex = 44;
            this.button15.Tag = "11";
            this.button15.Text = "11OFF";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.OUTPUTOFF_Click);
            // 
            // button14
            // 
            this.button14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button14.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button14.Location = new System.Drawing.Point(240, 4);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(229, 87);
            this.button14.TabIndex = 43;
            this.button14.Tag = "3";
            this.button14.Text = "3 OFF";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.OUTPUTOFF_Click);
            // 
            // btn_OUTPUT3
            // 
            this.btn_OUTPUT3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_OUTPUT3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_OUTPUT3.Location = new System.Drawing.Point(4, 4);
            this.btn_OUTPUT3.Name = "btn_OUTPUT3";
            this.btn_OUTPUT3.Size = new System.Drawing.Size(229, 87);
            this.btn_OUTPUT3.TabIndex = 9;
            this.btn_OUTPUT3.Tag = "3";
            this.btn_OUTPUT3.Text = "3 ON";
            this.btn_OUTPUT3.UseVisualStyleBackColor = true;
            this.btn_OUTPUT3.Click += new System.EventHandler(this.OUTPUT_Click);
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button6.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button6.Location = new System.Drawing.Point(476, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(229, 87);
            this.button6.TabIndex = 38;
            this.button6.Tag = "11";
            this.button6.Text = "11ON";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.OUTPUT_Click);
            // 
            // tableLayoutPanel23
            // 
            this.tableLayoutPanel23.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel23.ColumnCount = 4;
            this.tableLayoutPanel23.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel23.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel23.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel23.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel23.Controls.Add(this.button13, 3, 0);
            this.tableLayoutPanel23.Controls.Add(this.button12, 0, 0);
            this.tableLayoutPanel23.Controls.Add(this.btn_OUTPUT2, 0, 0);
            this.tableLayoutPanel23.Controls.Add(this.button7, 2, 0);
            this.tableLayoutPanel23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel23.Location = new System.Drawing.Point(956, 407);
            this.tableLayoutPanel23.Name = "tableLayoutPanel23";
            this.tableLayoutPanel23.RowCount = 1;
            this.tableLayoutPanel23.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel23.Size = new System.Drawing.Size(947, 95);
            this.tableLayoutPanel23.TabIndex = 36;
            // 
            // button13
            // 
            this.button13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button13.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button13.Location = new System.Drawing.Point(712, 4);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(231, 87);
            this.button13.TabIndex = 44;
            this.button13.Tag = "10";
            this.button13.Text = "10OFF";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.OUTPUTOFF_Click);
            // 
            // button12
            // 
            this.button12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button12.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button12.Location = new System.Drawing.Point(240, 4);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(229, 87);
            this.button12.TabIndex = 43;
            this.button12.Tag = "2";
            this.button12.Text = "2 OFF";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.OUTPUTOFF_Click);
            // 
            // btn_OUTPUT2
            // 
            this.btn_OUTPUT2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_OUTPUT2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_OUTPUT2.Location = new System.Drawing.Point(4, 4);
            this.btn_OUTPUT2.Name = "btn_OUTPUT2";
            this.btn_OUTPUT2.Size = new System.Drawing.Size(229, 87);
            this.btn_OUTPUT2.TabIndex = 7;
            this.btn_OUTPUT2.Tag = "2";
            this.btn_OUTPUT2.Text = "2 ON";
            this.btn_OUTPUT2.UseVisualStyleBackColor = true;
            this.btn_OUTPUT2.Click += new System.EventHandler(this.OUTPUT_Click);
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button7.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button7.Location = new System.Drawing.Point(476, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(229, 87);
            this.button7.TabIndex = 37;
            this.button7.Tag = "10";
            this.button7.Text = "10ON";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.OUTPUT_Click);
            // 
            // tableLayoutPanel24
            // 
            this.tableLayoutPanel24.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel24.ColumnCount = 4;
            this.tableLayoutPanel24.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel24.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel24.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel24.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel24.Controls.Add(this.button11, 3, 0);
            this.tableLayoutPanel24.Controls.Add(this.button10, 1, 0);
            this.tableLayoutPanel24.Controls.Add(this.btn_OUTPUT1, 0, 0);
            this.tableLayoutPanel24.Controls.Add(this.button9, 2, 0);
            this.tableLayoutPanel24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel24.Location = new System.Drawing.Point(956, 306);
            this.tableLayoutPanel24.Name = "tableLayoutPanel24";
            this.tableLayoutPanel24.RowCount = 1;
            this.tableLayoutPanel24.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel24.Size = new System.Drawing.Size(947, 95);
            this.tableLayoutPanel24.TabIndex = 37;
            // 
            // button11
            // 
            this.button11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button11.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button11.Location = new System.Drawing.Point(712, 4);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(231, 87);
            this.button11.TabIndex = 44;
            this.button11.Tag = "8";
            this.button11.Text = "8 OFF";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.OUTPUTOFF_Click);
            // 
            // button10
            // 
            this.button10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button10.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button10.Location = new System.Drawing.Point(240, 4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(229, 87);
            this.button10.TabIndex = 43;
            this.button10.Tag = "1";
            this.button10.Text = "1 OFF";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.OUTPUTOFF_Click);
            // 
            // btn_OUTPUT1
            // 
            this.btn_OUTPUT1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_OUTPUT1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_OUTPUT1.Location = new System.Drawing.Point(4, 4);
            this.btn_OUTPUT1.Name = "btn_OUTPUT1";
            this.btn_OUTPUT1.Size = new System.Drawing.Size(229, 87);
            this.btn_OUTPUT1.TabIndex = 5;
            this.btn_OUTPUT1.Tag = "1";
            this.btn_OUTPUT1.Text = "1 ON";
            this.btn_OUTPUT1.UseVisualStyleBackColor = true;
            this.btn_OUTPUT1.Click += new System.EventHandler(this.OUTPUT_Click);
            // 
            // button9
            // 
            this.button9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button9.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button9.Location = new System.Drawing.Point(476, 4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(229, 87);
            this.button9.TabIndex = 36;
            this.button9.Tag = "8";
            this.button9.Text = "8 ON";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.OUTPUT_Click);
            // 
            // tableLayoutPanel25
            // 
            this.tableLayoutPanel25.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel25.ColumnCount = 4;
            this.tableLayoutPanel25.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel25.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel25.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel25.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel25.Controls.Add(this.button2, 3, 0);
            this.tableLayoutPanel25.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel25.Controls.Add(this.btn_OUTPUT0, 0, 0);
            this.tableLayoutPanel25.Controls.Add(this.button8, 2, 0);
            this.tableLayoutPanel25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel25.Location = new System.Drawing.Point(956, 205);
            this.tableLayoutPanel25.Name = "tableLayoutPanel25";
            this.tableLayoutPanel25.RowCount = 1;
            this.tableLayoutPanel25.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel25.Size = new System.Drawing.Size(947, 95);
            this.tableLayoutPanel25.TabIndex = 35;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.Location = new System.Drawing.Point(712, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(231, 87);
            this.button2.TabIndex = 43;
            this.button2.Tag = "7";
            this.button2.Text = "7 OFF";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.OUTPUTOFF_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(240, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 87);
            this.button1.TabIndex = 42;
            this.button1.Tag = "0";
            this.button1.Text = "0 OFF";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OUTPUTOFF_Click);
            // 
            // btn_OUTPUT0
            // 
            this.btn_OUTPUT0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_OUTPUT0.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_OUTPUT0.Location = new System.Drawing.Point(4, 4);
            this.btn_OUTPUT0.Name = "btn_OUTPUT0";
            this.btn_OUTPUT0.Size = new System.Drawing.Size(229, 87);
            this.btn_OUTPUT0.TabIndex = 3;
            this.btn_OUTPUT0.Tag = "0";
            this.btn_OUTPUT0.Text = "0 ON";
            this.btn_OUTPUT0.UseVisualStyleBackColor = true;
            this.btn_OUTPUT0.Click += new System.EventHandler(this.OUTPUT_Click);
            // 
            // button8
            // 
            this.button8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button8.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button8.Location = new System.Drawing.Point(476, 4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(229, 87);
            this.button8.TabIndex = 35;
            this.button8.Tag = "7";
            this.button8.Text = "7 ON";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.OUTPUT_Click);
            // 
            // btn_INPUT15
            // 
            this.btn_INPUT15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_INPUT15.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_INPUT15.Location = new System.Drawing.Point(3, 811);
            this.btn_INPUT15.Name = "btn_INPUT15";
            this.btn_INPUT15.Size = new System.Drawing.Size(947, 99);
            this.btn_INPUT15.TabIndex = 16;
            this.btn_INPUT15.Text = "7";
            this.btn_INPUT15.UseVisualStyleBackColor = true;
            // 
            // btn_INPUT14
            // 
            this.btn_INPUT14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_INPUT14.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_INPUT14.Location = new System.Drawing.Point(3, 710);
            this.btn_INPUT14.Name = "btn_INPUT14";
            this.btn_INPUT14.Size = new System.Drawing.Size(947, 95);
            this.btn_INPUT14.TabIndex = 14;
            this.btn_INPUT14.Text = "6";
            this.btn_INPUT14.UseVisualStyleBackColor = true;
            // 
            // btn_INPUT13
            // 
            this.btn_INPUT13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_INPUT13.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_INPUT13.Location = new System.Drawing.Point(3, 609);
            this.btn_INPUT13.Name = "btn_INPUT13";
            this.btn_INPUT13.Size = new System.Drawing.Size(947, 95);
            this.btn_INPUT13.TabIndex = 12;
            this.btn_INPUT13.Text = "5";
            this.btn_INPUT13.UseVisualStyleBackColor = true;
            // 
            // btn_INPUT12
            // 
            this.btn_INPUT12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_INPUT12.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_INPUT12.Location = new System.Drawing.Point(3, 508);
            this.btn_INPUT12.Name = "btn_INPUT12";
            this.btn_INPUT12.Size = new System.Drawing.Size(947, 95);
            this.btn_INPUT12.TabIndex = 10;
            this.btn_INPUT12.Text = "4";
            this.btn_INPUT12.UseVisualStyleBackColor = true;
            // 
            // btn_INPUT11
            // 
            this.btn_INPUT11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_INPUT11.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_INPUT11.Location = new System.Drawing.Point(3, 407);
            this.btn_INPUT11.Name = "btn_INPUT11";
            this.btn_INPUT11.Size = new System.Drawing.Size(947, 95);
            this.btn_INPUT11.TabIndex = 8;
            this.btn_INPUT11.Text = "3";
            this.btn_INPUT11.UseVisualStyleBackColor = true;
            // 
            // btn_INPUT10
            // 
            this.btn_INPUT10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_INPUT10.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_INPUT10.Location = new System.Drawing.Point(3, 306);
            this.btn_INPUT10.Name = "btn_INPUT10";
            this.btn_INPUT10.Size = new System.Drawing.Size(947, 95);
            this.btn_INPUT10.TabIndex = 6;
            this.btn_INPUT10.Text = "2";
            this.btn_INPUT10.UseVisualStyleBackColor = true;
            // 
            // btn_INPUT9
            // 
            this.btn_INPUT9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_INPUT9.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_INPUT9.Location = new System.Drawing.Point(3, 205);
            this.btn_INPUT9.Name = "btn_INPUT9";
            this.btn_INPUT9.Size = new System.Drawing.Size(947, 95);
            this.btn_INPUT9.TabIndex = 4;
            this.btn_INPUT9.Text = "1";
            this.btn_INPUT9.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(947, 101);
            this.label2.TabIndex = 0;
            this.label2.Text = "INPUT";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(956, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(947, 101);
            this.label3.TabIndex = 1;
            this.label3.Text = "OUTPUT";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_INPUT8
            // 
            this.btn_INPUT8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_INPUT8.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_INPUT8.Location = new System.Drawing.Point(3, 104);
            this.btn_INPUT8.Name = "btn_INPUT8";
            this.btn_INPUT8.Size = new System.Drawing.Size(947, 95);
            this.btn_INPUT8.TabIndex = 2;
            this.btn_INPUT8.Text = "0";
            this.btn_INPUT8.UseVisualStyleBackColor = true;
            // 
            // Tab_Log
            // 
            this.Tab_Log.Controls.Add(this.logControl1);
            this.Tab_Log.Location = new System.Drawing.Point(4, 22);
            this.Tab_Log.Name = "Tab_Log";
            this.Tab_Log.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_Log.Size = new System.Drawing.Size(1912, 919);
            this.Tab_Log.TabIndex = 0;
            this.Tab_Log.Text = "LOG";
            this.Tab_Log.UseVisualStyleBackColor = true;
            // 
            // logControl1
            // 
            this.logControl1.Color_ControlBack = System.Drawing.Color.Black;
            this.logControl1.Color_ErrorText = System.Drawing.Color.Red;
            this.logControl1.Color_NormalText = System.Drawing.Color.White;
            this.logControl1.Color_WarningText = System.Drawing.Color.Yellow;
            this.logControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logControl1.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.logControl1.Location = new System.Drawing.Point(3, 3);
            this.logControl1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.logControl1.Name = "logControl1";
            this.logControl1.Size = new System.Drawing.Size(1906, 913);
            this.logControl1.TabIndex = 42;
            // 
            // Main_TabControl
            // 
            this.Main_TabControl.Controls.Add(this.Tab_Home);
            this.Main_TabControl.Controls.Add(this.Tab_Log);
            this.Main_TabControl.Controls.Add(this.Tab_IO);
            this.Main_TabControl.Controls.Add(this.Tab_Count);
            this.Main_TabControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Main_TabControl.Location = new System.Drawing.Point(0, 135);
            this.Main_TabControl.Margin = new System.Windows.Forms.Padding(0);
            this.Main_TabControl.Name = "Main_TabControl";
            this.Main_TabControl.SelectedIndex = 0;
            this.Main_TabControl.Size = new System.Drawing.Size(1920, 945);
            this.Main_TabControl.TabIndex = 25;
            // 
            // Tab_Home
            // 
            this.Tab_Home.Controls.Add(this.tableLayoutPanel2);
            this.Tab_Home.Location = new System.Drawing.Point(4, 22);
            this.Tab_Home.Margin = new System.Windows.Forms.Padding(0);
            this.Tab_Home.Name = "Tab_Home";
            this.Tab_Home.Size = new System.Drawing.Size(1912, 919);
            this.Tab_Home.TabIndex = 5;
            this.Tab_Home.Text = "HOME";
            this.Tab_Home.UseVisualStyleBackColor = true;
            // 
            // Tab_Count
            // 
            this.Tab_Count.Controls.Add(this.tableLayoutPanel27);
            this.Tab_Count.Location = new System.Drawing.Point(4, 22);
            this.Tab_Count.Name = "Tab_Count";
            this.Tab_Count.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_Count.Size = new System.Drawing.Size(1912, 919);
            this.Tab_Count.TabIndex = 4;
            this.Tab_Count.Text = "COUNT";
            this.Tab_Count.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel27
            // 
            this.tableLayoutPanel27.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel27.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel27.ColumnCount = 2;
            this.tableLayoutPanel27.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel27.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel27.Controls.Add(this.tableLayoutPanel18, 1, 2);
            this.tableLayoutPanel27.Controls.Add(this.tableLayoutPanel17, 1, 1);
            this.tableLayoutPanel27.Controls.Add(this.tableLayoutPanel16, 1, 0);
            this.tableLayoutPanel27.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel27.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel27.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel27.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel27.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel27.Name = "tableLayoutPanel27";
            this.tableLayoutPanel27.RowCount = 3;
            this.tableLayoutPanel27.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel27.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel27.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel27.Size = new System.Drawing.Size(1906, 913);
            this.tableLayoutPanel27.TabIndex = 0;
            // 
            // tableLayoutPanel18
            // 
            this.tableLayoutPanel18.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel18.ColumnCount = 2;
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel18.Controls.Add(this.lb_CAM3_NGRATE, 1, 3);
            this.tableLayoutPanel18.Controls.Add(this.label35, 0, 3);
            this.tableLayoutPanel18.Controls.Add(this.lb_CAM3_TOTAL, 1, 2);
            this.tableLayoutPanel18.Controls.Add(this.label37, 0, 2);
            this.tableLayoutPanel18.Controls.Add(this.lb_CAM3_NG, 1, 1);
            this.tableLayoutPanel18.Controls.Add(this.label39, 0, 1);
            this.tableLayoutPanel18.Controls.Add(this.lb_CAM3_OK, 1, 0);
            this.tableLayoutPanel18.Controls.Add(this.label41, 0, 0);
            this.tableLayoutPanel18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel18.Location = new System.Drawing.Point(385, 612);
            this.tableLayoutPanel18.Name = "tableLayoutPanel18";
            this.tableLayoutPanel18.RowCount = 4;
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel18.Size = new System.Drawing.Size(1517, 297);
            this.tableLayoutPanel18.TabIndex = 8;
            // 
            // lb_CAM3_NGRATE
            // 
            this.lb_CAM3_NGRATE.AutoSize = true;
            this.lb_CAM3_NGRATE.BackColor = System.Drawing.Color.Black;
            this.lb_CAM3_NGRATE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_CAM3_NGRATE.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_CAM3_NGRATE.ForeColor = System.Drawing.Color.Yellow;
            this.lb_CAM3_NGRATE.Location = new System.Drawing.Point(459, 223);
            this.lb_CAM3_NGRATE.Name = "lb_CAM3_NGRATE";
            this.lb_CAM3_NGRATE.Size = new System.Drawing.Size(1054, 73);
            this.lb_CAM3_NGRATE.TabIndex = 7;
            this.lb_CAM3_NGRATE.Text = "0";
            this.lb_CAM3_NGRATE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.BackColor = System.Drawing.Color.Black;
            this.label35.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label35.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label35.ForeColor = System.Drawing.Color.Yellow;
            this.label35.Location = new System.Drawing.Point(4, 223);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(448, 73);
            this.label35.TabIndex = 6;
            this.label35.Text = "NG RATE";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_CAM3_TOTAL
            // 
            this.lb_CAM3_TOTAL.AutoSize = true;
            this.lb_CAM3_TOTAL.BackColor = System.Drawing.Color.Black;
            this.lb_CAM3_TOTAL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_CAM3_TOTAL.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_CAM3_TOTAL.ForeColor = System.Drawing.Color.White;
            this.lb_CAM3_TOTAL.Location = new System.Drawing.Point(459, 149);
            this.lb_CAM3_TOTAL.Name = "lb_CAM3_TOTAL";
            this.lb_CAM3_TOTAL.Size = new System.Drawing.Size(1054, 73);
            this.lb_CAM3_TOTAL.TabIndex = 5;
            this.lb_CAM3_TOTAL.Text = "0";
            this.lb_CAM3_TOTAL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.BackColor = System.Drawing.Color.Black;
            this.label37.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label37.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label37.ForeColor = System.Drawing.Color.White;
            this.label37.Location = new System.Drawing.Point(4, 149);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(448, 73);
            this.label37.TabIndex = 4;
            this.label37.Text = "TOTAL";
            this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_CAM3_NG
            // 
            this.lb_CAM3_NG.AutoSize = true;
            this.lb_CAM3_NG.BackColor = System.Drawing.Color.Black;
            this.lb_CAM3_NG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_CAM3_NG.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_CAM3_NG.ForeColor = System.Drawing.Color.Red;
            this.lb_CAM3_NG.Location = new System.Drawing.Point(459, 75);
            this.lb_CAM3_NG.Name = "lb_CAM3_NG";
            this.lb_CAM3_NG.Size = new System.Drawing.Size(1054, 73);
            this.lb_CAM3_NG.TabIndex = 3;
            this.lb_CAM3_NG.Text = "0";
            this.lb_CAM3_NG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.BackColor = System.Drawing.Color.Black;
            this.label39.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label39.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label39.ForeColor = System.Drawing.Color.Red;
            this.label39.Location = new System.Drawing.Point(4, 75);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(448, 73);
            this.label39.TabIndex = 2;
            this.label39.Text = "NG";
            this.label39.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_CAM3_OK
            // 
            this.lb_CAM3_OK.AutoSize = true;
            this.lb_CAM3_OK.BackColor = System.Drawing.Color.Black;
            this.lb_CAM3_OK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_CAM3_OK.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_CAM3_OK.ForeColor = System.Drawing.Color.Lime;
            this.lb_CAM3_OK.Location = new System.Drawing.Point(459, 1);
            this.lb_CAM3_OK.Name = "lb_CAM3_OK";
            this.lb_CAM3_OK.Size = new System.Drawing.Size(1054, 73);
            this.lb_CAM3_OK.TabIndex = 1;
            this.lb_CAM3_OK.Text = "0";
            this.lb_CAM3_OK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.BackColor = System.Drawing.Color.Black;
            this.label41.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label41.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label41.ForeColor = System.Drawing.Color.Lime;
            this.label41.Location = new System.Drawing.Point(4, 1);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(448, 73);
            this.label41.TabIndex = 0;
            this.label41.Text = "OK";
            this.label41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel17
            // 
            this.tableLayoutPanel17.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel17.ColumnCount = 2;
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel17.Controls.Add(this.lb_CAM2_NGRATE, 1, 3);
            this.tableLayoutPanel17.Controls.Add(this.label27, 0, 3);
            this.tableLayoutPanel17.Controls.Add(this.lb_CAM2_TOTAL, 1, 2);
            this.tableLayoutPanel17.Controls.Add(this.label29, 0, 2);
            this.tableLayoutPanel17.Controls.Add(this.lb_CAM2_NG, 1, 1);
            this.tableLayoutPanel17.Controls.Add(this.label31, 0, 1);
            this.tableLayoutPanel17.Controls.Add(this.lb_CAM2_OK, 1, 0);
            this.tableLayoutPanel17.Controls.Add(this.label33, 0, 0);
            this.tableLayoutPanel17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel17.Location = new System.Drawing.Point(385, 308);
            this.tableLayoutPanel17.Name = "tableLayoutPanel17";
            this.tableLayoutPanel17.RowCount = 4;
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel17.Size = new System.Drawing.Size(1517, 297);
            this.tableLayoutPanel17.TabIndex = 7;
            // 
            // lb_CAM2_NGRATE
            // 
            this.lb_CAM2_NGRATE.AutoSize = true;
            this.lb_CAM2_NGRATE.BackColor = System.Drawing.Color.Black;
            this.lb_CAM2_NGRATE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_CAM2_NGRATE.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_CAM2_NGRATE.ForeColor = System.Drawing.Color.Yellow;
            this.lb_CAM2_NGRATE.Location = new System.Drawing.Point(459, 223);
            this.lb_CAM2_NGRATE.Name = "lb_CAM2_NGRATE";
            this.lb_CAM2_NGRATE.Size = new System.Drawing.Size(1054, 73);
            this.lb_CAM2_NGRATE.TabIndex = 7;
            this.lb_CAM2_NGRATE.Text = "0";
            this.lb_CAM2_NGRATE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Black;
            this.label27.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label27.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label27.ForeColor = System.Drawing.Color.Yellow;
            this.label27.Location = new System.Drawing.Point(4, 223);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(448, 73);
            this.label27.TabIndex = 6;
            this.label27.Text = "NG RATE";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_CAM2_TOTAL
            // 
            this.lb_CAM2_TOTAL.AutoSize = true;
            this.lb_CAM2_TOTAL.BackColor = System.Drawing.Color.Black;
            this.lb_CAM2_TOTAL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_CAM2_TOTAL.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_CAM2_TOTAL.ForeColor = System.Drawing.Color.White;
            this.lb_CAM2_TOTAL.Location = new System.Drawing.Point(459, 149);
            this.lb_CAM2_TOTAL.Name = "lb_CAM2_TOTAL";
            this.lb_CAM2_TOTAL.Size = new System.Drawing.Size(1054, 73);
            this.lb_CAM2_TOTAL.TabIndex = 5;
            this.lb_CAM2_TOTAL.Text = "0";
            this.lb_CAM2_TOTAL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.Black;
            this.label29.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label29.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label29.ForeColor = System.Drawing.Color.White;
            this.label29.Location = new System.Drawing.Point(4, 149);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(448, 73);
            this.label29.TabIndex = 4;
            this.label29.Text = "TOTAL";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_CAM2_NG
            // 
            this.lb_CAM2_NG.AutoSize = true;
            this.lb_CAM2_NG.BackColor = System.Drawing.Color.Black;
            this.lb_CAM2_NG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_CAM2_NG.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_CAM2_NG.ForeColor = System.Drawing.Color.Red;
            this.lb_CAM2_NG.Location = new System.Drawing.Point(459, 75);
            this.lb_CAM2_NG.Name = "lb_CAM2_NG";
            this.lb_CAM2_NG.Size = new System.Drawing.Size(1054, 73);
            this.lb_CAM2_NG.TabIndex = 3;
            this.lb_CAM2_NG.Text = "0";
            this.lb_CAM2_NG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.Black;
            this.label31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label31.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label31.ForeColor = System.Drawing.Color.Red;
            this.label31.Location = new System.Drawing.Point(4, 75);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(448, 73);
            this.label31.TabIndex = 2;
            this.label31.Text = "NG";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_CAM2_OK
            // 
            this.lb_CAM2_OK.AutoSize = true;
            this.lb_CAM2_OK.BackColor = System.Drawing.Color.Black;
            this.lb_CAM2_OK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_CAM2_OK.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_CAM2_OK.ForeColor = System.Drawing.Color.Lime;
            this.lb_CAM2_OK.Location = new System.Drawing.Point(459, 1);
            this.lb_CAM2_OK.Name = "lb_CAM2_OK";
            this.lb_CAM2_OK.Size = new System.Drawing.Size(1054, 73);
            this.lb_CAM2_OK.TabIndex = 1;
            this.lb_CAM2_OK.Text = "0";
            this.lb_CAM2_OK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.Black;
            this.label33.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label33.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label33.ForeColor = System.Drawing.Color.Lime;
            this.label33.Location = new System.Drawing.Point(4, 1);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(448, 73);
            this.label33.TabIndex = 0;
            this.label33.Text = "OK";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel16
            // 
            this.tableLayoutPanel16.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel16.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel16.ColumnCount = 2;
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel16.Controls.Add(this.lb_CAM1_NGRATE, 1, 3);
            this.tableLayoutPanel16.Controls.Add(this.label24, 0, 3);
            this.tableLayoutPanel16.Controls.Add(this.lb_CAM1_TOTAL, 1, 2);
            this.tableLayoutPanel16.Controls.Add(this.label22, 0, 2);
            this.tableLayoutPanel16.Controls.Add(this.lb_CAM1_NG, 1, 1);
            this.tableLayoutPanel16.Controls.Add(this.label20, 0, 1);
            this.tableLayoutPanel16.Controls.Add(this.lb_CAM1_OK, 1, 0);
            this.tableLayoutPanel16.Controls.Add(this.label17, 0, 0);
            this.tableLayoutPanel16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel16.Location = new System.Drawing.Point(385, 4);
            this.tableLayoutPanel16.Name = "tableLayoutPanel16";
            this.tableLayoutPanel16.RowCount = 4;
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel16.Size = new System.Drawing.Size(1517, 297);
            this.tableLayoutPanel16.TabIndex = 6;
            // 
            // lb_CAM1_NGRATE
            // 
            this.lb_CAM1_NGRATE.AutoSize = true;
            this.lb_CAM1_NGRATE.BackColor = System.Drawing.Color.Black;
            this.lb_CAM1_NGRATE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_CAM1_NGRATE.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_CAM1_NGRATE.ForeColor = System.Drawing.Color.Yellow;
            this.lb_CAM1_NGRATE.Location = new System.Drawing.Point(459, 223);
            this.lb_CAM1_NGRATE.Name = "lb_CAM1_NGRATE";
            this.lb_CAM1_NGRATE.Size = new System.Drawing.Size(1054, 73);
            this.lb_CAM1_NGRATE.TabIndex = 7;
            this.lb_CAM1_NGRATE.Text = "0";
            this.lb_CAM1_NGRATE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Black;
            this.label24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label24.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label24.ForeColor = System.Drawing.Color.Yellow;
            this.label24.Location = new System.Drawing.Point(4, 223);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(448, 73);
            this.label24.TabIndex = 6;
            this.label24.Text = "NG RATE";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_CAM1_TOTAL
            // 
            this.lb_CAM1_TOTAL.AutoSize = true;
            this.lb_CAM1_TOTAL.BackColor = System.Drawing.Color.Black;
            this.lb_CAM1_TOTAL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_CAM1_TOTAL.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_CAM1_TOTAL.ForeColor = System.Drawing.Color.White;
            this.lb_CAM1_TOTAL.Location = new System.Drawing.Point(459, 149);
            this.lb_CAM1_TOTAL.Name = "lb_CAM1_TOTAL";
            this.lb_CAM1_TOTAL.Size = new System.Drawing.Size(1054, 73);
            this.lb_CAM1_TOTAL.TabIndex = 5;
            this.lb_CAM1_TOTAL.Text = "0";
            this.lb_CAM1_TOTAL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Black;
            this.label22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label22.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(4, 149);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(448, 73);
            this.label22.TabIndex = 4;
            this.label22.Text = "TOTAL";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_CAM1_NG
            // 
            this.lb_CAM1_NG.AutoSize = true;
            this.lb_CAM1_NG.BackColor = System.Drawing.Color.Black;
            this.lb_CAM1_NG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_CAM1_NG.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_CAM1_NG.ForeColor = System.Drawing.Color.Red;
            this.lb_CAM1_NG.Location = new System.Drawing.Point(459, 75);
            this.lb_CAM1_NG.Name = "lb_CAM1_NG";
            this.lb_CAM1_NG.Size = new System.Drawing.Size(1054, 73);
            this.lb_CAM1_NG.TabIndex = 3;
            this.lb_CAM1_NG.Text = "0";
            this.lb_CAM1_NG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Black;
            this.label20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label20.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label20.ForeColor = System.Drawing.Color.Red;
            this.label20.Location = new System.Drawing.Point(4, 75);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(448, 73);
            this.label20.TabIndex = 2;
            this.label20.Text = "NG";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_CAM1_OK
            // 
            this.lb_CAM1_OK.AutoSize = true;
            this.lb_CAM1_OK.BackColor = System.Drawing.Color.Black;
            this.lb_CAM1_OK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_CAM1_OK.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_CAM1_OK.ForeColor = System.Drawing.Color.Lime;
            this.lb_CAM1_OK.Location = new System.Drawing.Point(459, 1);
            this.lb_CAM1_OK.Name = "lb_CAM1_OK";
            this.lb_CAM1_OK.Size = new System.Drawing.Size(1054, 73);
            this.lb_CAM1_OK.TabIndex = 1;
            this.lb_CAM1_OK.Text = "0";
            this.lb_CAM1_OK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Black;
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label17.ForeColor = System.Drawing.Color.Lime;
            this.label17.Location = new System.Drawing.Point(4, 1);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(448, 73);
            this.label17.TabIndex = 0;
            this.label17.Text = "OK";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(4, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(374, 303);
            this.label5.TabIndex = 0;
            this.label5.Text = "CAM1";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(4, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(374, 303);
            this.label6.TabIndex = 1;
            this.label6.Text = "CAM2";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(4, 609);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(374, 303);
            this.label8.TabIndex = 2;
            this.label8.Text = "CAM3";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_IO
            // 
            this.btn_IO.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_IO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_IO.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_IO.ForeColor = System.Drawing.Color.White;
            this.btn_IO.Location = new System.Drawing.Point(262, 4);
            this.btn_IO.Name = "btn_IO";
            this.btn_IO.Size = new System.Drawing.Size(122, 69);
            this.btn_IO.TabIndex = 30;
            this.btn_IO.Tag = "2";
            this.btn_IO.Text = "I/O";
            this.btn_IO.UseVisualStyleBackColor = false;
            this.btn_IO.Click += new System.EventHandler(this.btn_Log_Click);
            // 
            // btn_Log
            // 
            this.btn_Log.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Log.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Log.ForeColor = System.Drawing.Color.White;
            this.btn_Log.Location = new System.Drawing.Point(133, 4);
            this.btn_Log.Name = "btn_Log";
            this.btn_Log.Size = new System.Drawing.Size(122, 69);
            this.btn_Log.TabIndex = 31;
            this.btn_Log.Tag = "1";
            this.btn_Log.Text = "로그";
            this.btn_Log.UseVisualStyleBackColor = false;
            this.btn_Log.Click += new System.EventHandler(this.btn_Log_Click);
            // 
            // btn_Count
            // 
            this.btn_Count.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Count.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Count.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Count.ForeColor = System.Drawing.Color.White;
            this.btn_Count.Location = new System.Drawing.Point(391, 4);
            this.btn_Count.Name = "btn_Count";
            this.btn_Count.Size = new System.Drawing.Size(123, 69);
            this.btn_Count.TabIndex = 32;
            this.btn_Count.Tag = "3";
            this.btn_Count.Text = "수량";
            this.btn_Count.UseVisualStyleBackColor = false;
            this.btn_Count.Click += new System.EventHandler(this.btn_Log_Click);
            // 
            // tableLayoutPanel31
            // 
            this.tableLayoutPanel31.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tableLayoutPanel31.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel31.ColumnCount = 4;
            this.tableLayoutPanel31.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel31.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel31.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel31.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel31.Controls.Add(this.btn_Home, 0, 0);
            this.tableLayoutPanel31.Controls.Add(this.btn_Count, 3, 0);
            this.tableLayoutPanel31.Controls.Add(this.btn_Log, 1, 0);
            this.tableLayoutPanel31.Controls.Add(this.btn_IO, 2, 0);
            this.tableLayoutPanel31.Location = new System.Drawing.Point(0, 77);
            this.tableLayoutPanel31.Name = "tableLayoutPanel31";
            this.tableLayoutPanel31.RowCount = 1;
            this.tableLayoutPanel31.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel31.Size = new System.Drawing.Size(518, 77);
            this.tableLayoutPanel31.TabIndex = 27;
            // 
            // btn_Home
            // 
            this.btn_Home.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Home.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Home.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Home.ForeColor = System.Drawing.Color.White;
            this.btn_Home.Location = new System.Drawing.Point(4, 4);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(122, 69);
            this.btn_Home.TabIndex = 33;
            this.btn_Home.Tag = "0";
            this.btn_Home.Text = "홈";
            this.btn_Home.UseVisualStyleBackColor = false;
            this.btn_Home.Click += new System.EventHandler(this.btn_Log_Click);
            // 
            // bk_AutoDelete
            // 
            this.bk_AutoDelete.WorkerSupportsCancellation = true;
            this.bk_AutoDelete.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bk_AutoDelete_DoWork);
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.tableLayoutPanel31);
            this.Controls.Add(this.tlpUnder);
            this.Controls.Add(this.tlpTopSide);
            this.Controls.Add(this.Main_TabControl);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VISION PROGRAM";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Main_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Main_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Frm_Main_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_Main_KeyDown);
            this.tlpUnder.ResumeLayout(false);
            this.tlpTopSide.ResumeLayout(false);
            this.tlpTopSide.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cdyDisplay3)).EndInit();
            this.tableLayoutPanel13.ResumeLayout(false);
            this.tableLayoutPanel13.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cdyDisplay2)).EndInit();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cdyDisplay)).EndInit();
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            this.Tab_IO.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel19.ResumeLayout(false);
            this.tableLayoutPanel20.ResumeLayout(false);
            this.tableLayoutPanel21.ResumeLayout(false);
            this.tableLayoutPanel22.ResumeLayout(false);
            this.tableLayoutPanel23.ResumeLayout(false);
            this.tableLayoutPanel24.ResumeLayout(false);
            this.tableLayoutPanel25.ResumeLayout(false);
            this.Tab_Log.ResumeLayout(false);
            this.Main_TabControl.ResumeLayout(false);
            this.Tab_Home.ResumeLayout(false);
            this.Tab_Count.ResumeLayout(false);
            this.tableLayoutPanel27.ResumeLayout(false);
            this.tableLayoutPanel27.PerformLayout();
            this.tableLayoutPanel18.ResumeLayout(false);
            this.tableLayoutPanel18.PerformLayout();
            this.tableLayoutPanel17.ResumeLayout(false);
            this.tableLayoutPanel17.PerformLayout();
            this.tableLayoutPanel16.ResumeLayout(false);
            this.tableLayoutPanel16.PerformLayout();
            this.tableLayoutPanel31.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpUnder;
        private System.Windows.Forms.Button btn_ToolSetUp;
        private System.Windows.Forms.Button btn_SystemSetup;
        private System.Windows.Forms.TableLayoutPanel tlpTopSide;
        private System.Windows.Forms.Label lb_Ver;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label lb_Time;
        private System.Windows.Forms.Timer timer_Setting;
        private System.Windows.Forms.Button btn_Status;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.ComponentModel.BackgroundWorker bk_IO;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.Button btn_Model;
        private System.Windows.Forms.Label lb_CurruntModelName;
        public System.IO.Ports.SerialPort LightControl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_CamSet;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        internal Cognex.VisionPro.Display.CogDisplay cdyDisplay;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        internal Cognex.VisionPro.Display.CogDisplay cdyDisplay2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label lb_Cam2_Result;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage Tab_IO;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel19;
        public System.Windows.Forms.Button button21;
        public System.Windows.Forms.Button button19;
        public System.Windows.Forms.Button btn_OUTPUT6;
        public System.Windows.Forms.Button button3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel20;
        public System.Windows.Forms.Button button20;
        public System.Windows.Forms.Button button18;
        public System.Windows.Forms.Button btn_OUTPUT5;
        public System.Windows.Forms.Button button4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel21;
        public System.Windows.Forms.Button button17;
        public System.Windows.Forms.Button button16;
        public System.Windows.Forms.Button btn_OUTPUT4;
        public System.Windows.Forms.Button button5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel22;
        public System.Windows.Forms.Button button15;
        public System.Windows.Forms.Button button14;
        public System.Windows.Forms.Button btn_OUTPUT3;
        public System.Windows.Forms.Button button6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel23;
        public System.Windows.Forms.Button button13;
        public System.Windows.Forms.Button button12;
        public System.Windows.Forms.Button btn_OUTPUT2;
        public System.Windows.Forms.Button button7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel24;
        public System.Windows.Forms.Button button11;
        public System.Windows.Forms.Button button10;
        public System.Windows.Forms.Button btn_OUTPUT1;
        public System.Windows.Forms.Button button9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel25;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button btn_OUTPUT0;
        public System.Windows.Forms.Button button8;
        public System.Windows.Forms.Button btn_INPUT15;
        public System.Windows.Forms.Button btn_INPUT14;
        public System.Windows.Forms.Button btn_INPUT13;
        public System.Windows.Forms.Button btn_INPUT12;
        public System.Windows.Forms.Button btn_INPUT11;
        public System.Windows.Forms.Button btn_INPUT10;
        public System.Windows.Forms.Button btn_INPUT9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button btn_INPUT8;
        private System.Windows.Forms.TabPage Tab_Log;
        private System.Windows.Forms.TabControl Main_TabControl;
        private System.Windows.Forms.Label lb_Cam2_InsTime;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_Cam1_Result;
        private System.Windows.Forms.Label lb_Cam1_InsTime;
        private System.Windows.Forms.TabPage Tab_Count;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel27;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel18;
        private System.Windows.Forms.Label lb_CAM3_NGRATE;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label lb_CAM3_TOTAL;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label lb_CAM3_NG;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label lb_CAM3_OK;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel17;
        private System.Windows.Forms.Label lb_CAM2_NGRATE;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label lb_CAM2_TOTAL;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label lb_CAM2_NG;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label lb_CAM2_OK;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel16;
        private System.Windows.Forms.Label lb_CAM1_NGRATE;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lb_CAM1_TOTAL;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lb_CAM1_NG;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lb_CAM1_OK;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_IO;
        private System.Windows.Forms.Button btn_Log;
        private System.Windows.Forms.Button btn_Count;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel31;
        private KimLib.LogControl logControl1;
        private System.Windows.Forms.Button btn_Analyze;
        public System.ComponentModel.BackgroundWorker bk_AutoDelete;
        private System.Windows.Forms.TabPage Tab_Home;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        internal Cognex.VisionPro.Display.CogDisplay cdyDisplay3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel13;
        private System.Windows.Forms.Label lb_Cam3_Result;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lb_Cam3_InsTime;
        private System.Windows.Forms.Button btn_Home;
    }
}

