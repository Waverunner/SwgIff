namespace Waverunner.Swg.Plugins
{
    partial class LsbPlugin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LsbPlugin));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnOpen = new System.Windows.Forms.ToolStripButton();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanelAttributes = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAppearance = new System.Windows.Forms.TextBox();
            this.textBoxSound = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBoxFlicker = new System.Windows.Forms.CheckBox();
            this.checkBoxDblBlade = new System.Windows.Forms.CheckBox();
            this.panelAttributes = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panelUpperBlade = new System.Windows.Forms.Panel();
            this.tableLayoutPanelUpperBlade = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxUpperShdr = new System.Windows.Forms.TextBox();
            this.textBoxUpperLength = new System.Windows.Forms.TextBox();
            this.textBoxUpperWidth = new System.Windows.Forms.TextBox();
            this.textBoxUpperOpenSpd = new System.Windows.Forms.TextBox();
            this.textBoxUpperCloseSpd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelFlicker = new System.Windows.Forms.Panel();
            this.tableLayoutPanelFlicker = new System.Windows.Forms.TableLayoutPanel();
            this.label20 = new System.Windows.Forms.Label();
            this.textBoxFlickerTimeMin = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.textBoxFlickerRangeMin = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.textBoxFlickerRangeMax = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.textBoxFlickerTimeMax = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.buttonFlickerColor = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.checkBoxFlickerAware = new System.Windows.Forms.CheckBox();
            this.label18 = new System.Windows.Forms.Label();
            this.panelLowerBlade = new System.Windows.Forms.Panel();
            this.tableLayoutPanelLowerBlade = new System.Windows.Forms.TableLayoutPanel();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxLowerShdr = new System.Windows.Forms.TextBox();
            this.textBoxLowerLength = new System.Windows.Forms.TextBox();
            this.textBoxLowerWidth = new System.Windows.Forms.TextBox();
            this.textBoxLowerOpenSpd = new System.Windows.Forms.TextBox();
            this.textBoxLowerCloseSpd = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.toolStrip.SuspendLayout();
            this.tableLayoutPanelAttributes.SuspendLayout();
            this.panelAttributes.SuspendLayout();
            this.panelUpperBlade.SuspendLayout();
            this.tableLayoutPanelUpperBlade.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelFlicker.SuspendLayout();
            this.tableLayoutPanelFlicker.SuspendLayout();
            this.panelLowerBlade.SuspendLayout();
            this.tableLayoutPanelLowerBlade.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnNew,
            this.toolStripBtnOpen});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip.Size = new System.Drawing.Size(680, 25);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip";
            // 
            // toolStripBtnNew
            // 
            this.toolStripBtnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBtnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnNew.Name = "toolStripBtnNew";
            this.toolStripBtnNew.Size = new System.Drawing.Size(35, 22);
            this.toolStripBtnNew.Text = "New";
            this.toolStripBtnNew.Click += new System.EventHandler(this.onNewLSB);
            // 
            // toolStripBtnOpen
            // 
            this.toolStripBtnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBtnOpen.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnOpen.Image")));
            this.toolStripBtnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnOpen.Name = "toolStripBtnOpen";
            this.toolStripBtnOpen.Size = new System.Drawing.Size(40, 22);
            this.toolStripBtnOpen.Text = "Open";
            this.toolStripBtnOpen.Click += new System.EventHandler(this.onOpenLSB);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "LSB files|*.lsb";
            this.openFileDialog.Title = "Open LSB File";
            // 
            // tableLayoutPanelAttributes
            // 
            this.tableLayoutPanelAttributes.ColumnCount = 2;
            this.tableLayoutPanelAttributes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.89338F));
            this.tableLayoutPanelAttributes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.10662F));
            this.tableLayoutPanelAttributes.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanelAttributes.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanelAttributes.Controls.Add(this.textBoxAppearance, 1, 0);
            this.tableLayoutPanelAttributes.Controls.Add(this.textBoxSound, 1, 1);
            this.tableLayoutPanelAttributes.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanelAttributes.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanelAttributes.Controls.Add(this.checkBoxFlicker, 1, 3);
            this.tableLayoutPanelAttributes.Controls.Add(this.checkBoxDblBlade, 1, 2);
            this.tableLayoutPanelAttributes.Enabled = false;
            this.tableLayoutPanelAttributes.Location = new System.Drawing.Point(6, 3);
            this.tableLayoutPanelAttributes.Name = "tableLayoutPanelAttributes";
            this.tableLayoutPanelAttributes.RowCount = 4;
            this.tableLayoutPanelAttributes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.61905F));
            this.tableLayoutPanelAttributes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.38095F));
            this.tableLayoutPanelAttributes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanelAttributes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanelAttributes.Size = new System.Drawing.Size(619, 110);
            this.tableLayoutPanelAttributes.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Appearance";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sound";
            // 
            // textBoxAppearance
            // 
            this.textBoxAppearance.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxAppearance.Location = new System.Drawing.Point(89, 3);
            this.textBoxAppearance.Name = "textBoxAppearance";
            this.textBoxAppearance.Size = new System.Drawing.Size(274, 20);
            this.textBoxAppearance.TabIndex = 2;
            this.textBoxAppearance.TextChanged += new System.EventHandler(this.control_ChangesMade);
            // 
            // textBoxSound
            // 
            this.textBoxSound.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxSound.Location = new System.Drawing.Point(89, 32);
            this.textBoxSound.Name = "textBoxSound";
            this.textBoxSound.Size = new System.Drawing.Size(274, 20);
            this.textBoxSound.TabIndex = 3;
            this.textBoxSound.TextChanged += new System.EventHandler(this.control_ChangesMade);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Double Bladed";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Light Flicker";
            // 
            // checkBoxFlicker
            // 
            this.checkBoxFlicker.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBoxFlicker.AutoSize = true;
            this.checkBoxFlicker.Location = new System.Drawing.Point(89, 89);
            this.checkBoxFlicker.Name = "checkBoxFlicker";
            this.checkBoxFlicker.Size = new System.Drawing.Size(15, 14);
            this.checkBoxFlicker.TabIndex = 7;
            this.checkBoxFlicker.UseVisualStyleBackColor = true;
            this.checkBoxFlicker.CheckedChanged += new System.EventHandler(this.checkBoxFlicker_CheckedChanged);
            // 
            // checkBoxDblBlade
            // 
            this.checkBoxDblBlade.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBoxDblBlade.AutoSize = true;
            this.checkBoxDblBlade.Location = new System.Drawing.Point(89, 63);
            this.checkBoxDblBlade.Name = "checkBoxDblBlade";
            this.checkBoxDblBlade.Size = new System.Drawing.Size(15, 14);
            this.checkBoxDblBlade.TabIndex = 8;
            this.checkBoxDblBlade.UseVisualStyleBackColor = true;
            this.checkBoxDblBlade.CheckedChanged += new System.EventHandler(this.checkBoxDblBlade_CheckedChanged);
            // 
            // panelAttributes
            // 
            this.panelAttributes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelAttributes.Controls.Add(this.tableLayoutPanelAttributes);
            this.panelAttributes.Location = new System.Drawing.Point(13, 16);
            this.panelAttributes.Name = "panelAttributes";
            this.panelAttributes.Size = new System.Drawing.Size(654, 124);
            this.panelAttributes.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lightsaber Attributes";
            // 
            // panelUpperBlade
            // 
            this.panelUpperBlade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelUpperBlade.Controls.Add(this.tableLayoutPanelUpperBlade);
            this.panelUpperBlade.Location = new System.Drawing.Point(13, 159);
            this.panelUpperBlade.Name = "panelUpperBlade";
            this.panelUpperBlade.Size = new System.Drawing.Size(324, 176);
            this.panelUpperBlade.TabIndex = 3;
            // 
            // tableLayoutPanelUpperBlade
            // 
            this.tableLayoutPanelUpperBlade.ColumnCount = 2;
            this.tableLayoutPanelUpperBlade.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.18301F));
            this.tableLayoutPanelUpperBlade.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.81699F));
            this.tableLayoutPanelUpperBlade.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanelUpperBlade.Controls.Add(this.label8, 0, 1);
            this.tableLayoutPanelUpperBlade.Controls.Add(this.label9, 0, 2);
            this.tableLayoutPanelUpperBlade.Controls.Add(this.label10, 0, 3);
            this.tableLayoutPanelUpperBlade.Controls.Add(this.label11, 0, 4);
            this.tableLayoutPanelUpperBlade.Controls.Add(this.textBoxUpperShdr, 1, 0);
            this.tableLayoutPanelUpperBlade.Controls.Add(this.textBoxUpperLength, 1, 1);
            this.tableLayoutPanelUpperBlade.Controls.Add(this.textBoxUpperWidth, 1, 2);
            this.tableLayoutPanelUpperBlade.Controls.Add(this.textBoxUpperOpenSpd, 1, 3);
            this.tableLayoutPanelUpperBlade.Controls.Add(this.textBoxUpperCloseSpd, 1, 4);
            this.tableLayoutPanelUpperBlade.Enabled = false;
            this.tableLayoutPanelUpperBlade.Location = new System.Drawing.Point(6, 3);
            this.tableLayoutPanelUpperBlade.Name = "tableLayoutPanelUpperBlade";
            this.tableLayoutPanelUpperBlade.RowCount = 5;
            this.tableLayoutPanelUpperBlade.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.5625F));
            this.tableLayoutPanelUpperBlade.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.4375F));
            this.tableLayoutPanelUpperBlade.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanelUpperBlade.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanelUpperBlade.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelUpperBlade.Size = new System.Drawing.Size(306, 157);
            this.tableLayoutPanelUpperBlade.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Shader";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Length";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Width";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Open Rate";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 134);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Close Rate";
            // 
            // textBoxUpperShdr
            // 
            this.textBoxUpperShdr.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBoxUpperShdr.Location = new System.Drawing.Point(77, 6);
            this.textBoxUpperShdr.Name = "textBoxUpperShdr";
            this.textBoxUpperShdr.Size = new System.Drawing.Size(226, 20);
            this.textBoxUpperShdr.TabIndex = 5;
            this.textBoxUpperShdr.TextChanged += new System.EventHandler(this.control_ChangesMade);
            // 
            // textBoxUpperLength
            // 
            this.textBoxUpperLength.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxUpperLength.Location = new System.Drawing.Point(77, 38);
            this.textBoxUpperLength.Name = "textBoxUpperLength";
            this.textBoxUpperLength.Size = new System.Drawing.Size(58, 20);
            this.textBoxUpperLength.TabIndex = 6;
            this.textBoxUpperLength.TextChanged += new System.EventHandler(this.control_ChangesMade);
            // 
            // textBoxUpperWidth
            // 
            this.textBoxUpperWidth.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxUpperWidth.Location = new System.Drawing.Point(77, 67);
            this.textBoxUpperWidth.Name = "textBoxUpperWidth";
            this.textBoxUpperWidth.Size = new System.Drawing.Size(58, 20);
            this.textBoxUpperWidth.TabIndex = 7;
            this.textBoxUpperWidth.TextChanged += new System.EventHandler(this.control_ChangesMade);
            // 
            // textBoxUpperOpenSpd
            // 
            this.textBoxUpperOpenSpd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxUpperOpenSpd.Location = new System.Drawing.Point(77, 97);
            this.textBoxUpperOpenSpd.Name = "textBoxUpperOpenSpd";
            this.textBoxUpperOpenSpd.Size = new System.Drawing.Size(58, 20);
            this.textBoxUpperOpenSpd.TabIndex = 8;
            this.textBoxUpperOpenSpd.TextChanged += new System.EventHandler(this.control_ChangesMade);
            // 
            // textBoxUpperCloseSpd
            // 
            this.textBoxUpperCloseSpd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxUpperCloseSpd.Location = new System.Drawing.Point(77, 130);
            this.textBoxUpperCloseSpd.Name = "textBoxUpperCloseSpd";
            this.textBoxUpperCloseSpd.Size = new System.Drawing.Size(58, 20);
            this.textBoxUpperCloseSpd.TabIndex = 9;
            this.textBoxUpperCloseSpd.TextChanged += new System.EventHandler(this.control_ChangesMade);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Upper Blade";
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelFlicker);
            this.panelMain.Controls.Add(this.label18);
            this.panelMain.Controls.Add(this.panelLowerBlade);
            this.panelMain.Controls.Add(this.label12);
            this.panelMain.Controls.Add(this.label3);
            this.panelMain.Controls.Add(this.label6);
            this.panelMain.Controls.Add(this.panelAttributes);
            this.panelMain.Controls.Add(this.panelUpperBlade);
            this.panelMain.Location = new System.Drawing.Point(0, 40);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(676, 501);
            this.panelMain.TabIndex = 4;
            // 
            // panelFlicker
            // 
            this.panelFlicker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelFlicker.Controls.Add(this.tableLayoutPanelFlicker);
            this.panelFlicker.Location = new System.Drawing.Point(13, 354);
            this.panelFlicker.Name = "panelFlicker";
            this.panelFlicker.Size = new System.Drawing.Size(654, 130);
            this.panelFlicker.TabIndex = 6;
            // 
            // tableLayoutPanelFlicker
            // 
            this.tableLayoutPanelFlicker.ColumnCount = 4;
            this.tableLayoutPanelFlicker.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.79638F));
            this.tableLayoutPanelFlicker.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.20362F));
            this.tableLayoutPanelFlicker.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tableLayoutPanelFlicker.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 342F));
            this.tableLayoutPanelFlicker.Controls.Add(this.label20, 0, 1);
            this.tableLayoutPanelFlicker.Controls.Add(this.textBoxFlickerTimeMin, 1, 1);
            this.tableLayoutPanelFlicker.Controls.Add(this.label24, 0, 0);
            this.tableLayoutPanelFlicker.Controls.Add(this.textBoxFlickerRangeMin, 1, 0);
            this.tableLayoutPanelFlicker.Controls.Add(this.label25, 2, 0);
            this.tableLayoutPanelFlicker.Controls.Add(this.textBoxFlickerRangeMax, 3, 0);
            this.tableLayoutPanelFlicker.Controls.Add(this.label21, 2, 1);
            this.tableLayoutPanelFlicker.Controls.Add(this.textBoxFlickerTimeMax, 3, 1);
            this.tableLayoutPanelFlicker.Controls.Add(this.label23, 0, 2);
            this.tableLayoutPanelFlicker.Controls.Add(this.buttonFlickerColor, 1, 2);
            this.tableLayoutPanelFlicker.Controls.Add(this.label22, 0, 3);
            this.tableLayoutPanelFlicker.Controls.Add(this.checkBoxFlickerAware, 1, 3);
            this.tableLayoutPanelFlicker.Enabled = false;
            this.tableLayoutPanelFlicker.Location = new System.Drawing.Point(6, 3);
            this.tableLayoutPanelFlicker.Name = "tableLayoutPanelFlicker";
            this.tableLayoutPanelFlicker.RowCount = 4;
            this.tableLayoutPanelFlicker.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.45763F));
            this.tableLayoutPanelFlicker.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.54237F));
            this.tableLayoutPanelFlicker.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanelFlicker.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanelFlicker.Size = new System.Drawing.Size(636, 113);
            this.tableLayoutPanelFlicker.TabIndex = 0;
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(40, 35);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(53, 13);
            this.label20.TabIndex = 1;
            this.label20.Text = "Time Min.";
            // 
            // textBoxFlickerTimeMin
            // 
            this.textBoxFlickerTimeMin.Location = new System.Drawing.Point(99, 30);
            this.textBoxFlickerTimeMin.Name = "textBoxFlickerTimeMin";
            this.textBoxFlickerTimeMin.Size = new System.Drawing.Size(113, 20);
            this.textBoxFlickerTimeMin.TabIndex = 5;
            this.textBoxFlickerTimeMin.TextChanged += new System.EventHandler(this.control_ChangesMade);
            // 
            // label24
            // 
            this.label24.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(31, 7);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(62, 13);
            this.label24.TabIndex = 10;
            this.label24.Text = "Range Min.";
            // 
            // textBoxFlickerRangeMin
            // 
            this.textBoxFlickerRangeMin.Location = new System.Drawing.Point(99, 3);
            this.textBoxFlickerRangeMin.Name = "textBoxFlickerRangeMin";
            this.textBoxFlickerRangeMin.Size = new System.Drawing.Size(113, 20);
            this.textBoxFlickerRangeMin.TabIndex = 12;
            this.textBoxFlickerRangeMin.TextChanged += new System.EventHandler(this.control_ChangesMade);
            // 
            // label25
            // 
            this.label25.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(225, 7);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(65, 13);
            this.label25.TabIndex = 11;
            this.label25.Text = "Range Max.";
            // 
            // textBoxFlickerRangeMax
            // 
            this.textBoxFlickerRangeMax.Location = new System.Drawing.Point(296, 3);
            this.textBoxFlickerRangeMax.Name = "textBoxFlickerRangeMax";
            this.textBoxFlickerRangeMax.Size = new System.Drawing.Size(122, 20);
            this.textBoxFlickerRangeMax.TabIndex = 13;
            this.textBoxFlickerRangeMax.TextChanged += new System.EventHandler(this.control_ChangesMade);
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(234, 35);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(56, 13);
            this.label21.TabIndex = 2;
            this.label21.Text = "Time Max.";
            // 
            // textBoxFlickerTimeMax
            // 
            this.textBoxFlickerTimeMax.Location = new System.Drawing.Point(296, 30);
            this.textBoxFlickerTimeMax.Name = "textBoxFlickerTimeMax";
            this.textBoxFlickerTimeMax.Size = new System.Drawing.Size(122, 20);
            this.textBoxFlickerTimeMax.TabIndex = 6;
            this.textBoxFlickerTimeMax.TextChanged += new System.EventHandler(this.control_ChangesMade);
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(8, 64);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(85, 13);
            this.label23.TabIndex = 8;
            this.label23.Text = "Secondary Color";
            // 
            // buttonFlickerColor
            // 
            this.buttonFlickerColor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonFlickerColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonFlickerColor.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonFlickerColor.Location = new System.Drawing.Point(99, 60);
            this.buttonFlickerColor.Name = "buttonFlickerColor";
            this.buttonFlickerColor.Size = new System.Drawing.Size(113, 22);
            this.buttonFlickerColor.TabIndex = 9;
            this.buttonFlickerColor.UseVisualStyleBackColor = true;
            this.buttonFlickerColor.TextChanged += new System.EventHandler(this.control_ChangesMade);
            this.buttonFlickerColor.Click += new System.EventHandler(this.buttonFlickerColor_Click);
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(4, 92);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(89, 13);
            this.label22.TabIndex = 3;
            this.label22.Text = "Day/Night Aware";
            // 
            // checkBoxFlickerAware
            // 
            this.checkBoxFlickerAware.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxFlickerAware.AutoSize = true;
            this.checkBoxFlickerAware.Location = new System.Drawing.Point(99, 88);
            this.checkBoxFlickerAware.Name = "checkBoxFlickerAware";
            this.checkBoxFlickerAware.Size = new System.Drawing.Size(113, 22);
            this.checkBoxFlickerAware.TabIndex = 7;
            this.checkBoxFlickerAware.UseVisualStyleBackColor = true;
            this.checkBoxFlickerAware.CheckedChanged += new System.EventHandler(this.control_ChangesMade);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(16, 338);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(90, 13);
            this.label18.TabIndex = 5;
            this.label18.Text = "Lightsaber Flicker";
            // 
            // panelLowerBlade
            // 
            this.panelLowerBlade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelLowerBlade.Controls.Add(this.tableLayoutPanelLowerBlade);
            this.panelLowerBlade.Location = new System.Drawing.Point(343, 159);
            this.panelLowerBlade.Name = "panelLowerBlade";
            this.panelLowerBlade.Size = new System.Drawing.Size(324, 176);
            this.panelLowerBlade.TabIndex = 4;
            // 
            // tableLayoutPanelLowerBlade
            // 
            this.tableLayoutPanelLowerBlade.ColumnCount = 2;
            this.tableLayoutPanelLowerBlade.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.18301F));
            this.tableLayoutPanelLowerBlade.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.81699F));
            this.tableLayoutPanelLowerBlade.Controls.Add(this.label13, 0, 0);
            this.tableLayoutPanelLowerBlade.Controls.Add(this.label14, 0, 1);
            this.tableLayoutPanelLowerBlade.Controls.Add(this.label15, 0, 2);
            this.tableLayoutPanelLowerBlade.Controls.Add(this.label16, 0, 3);
            this.tableLayoutPanelLowerBlade.Controls.Add(this.label17, 0, 4);
            this.tableLayoutPanelLowerBlade.Controls.Add(this.textBoxLowerShdr, 1, 0);
            this.tableLayoutPanelLowerBlade.Controls.Add(this.textBoxLowerLength, 1, 1);
            this.tableLayoutPanelLowerBlade.Controls.Add(this.textBoxLowerWidth, 1, 2);
            this.tableLayoutPanelLowerBlade.Controls.Add(this.textBoxLowerOpenSpd, 1, 3);
            this.tableLayoutPanelLowerBlade.Controls.Add(this.textBoxLowerCloseSpd, 1, 4);
            this.tableLayoutPanelLowerBlade.Enabled = false;
            this.tableLayoutPanelLowerBlade.Location = new System.Drawing.Point(6, 3);
            this.tableLayoutPanelLowerBlade.Name = "tableLayoutPanelLowerBlade";
            this.tableLayoutPanelLowerBlade.RowCount = 5;
            this.tableLayoutPanelLowerBlade.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.5625F));
            this.tableLayoutPanelLowerBlade.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.4375F));
            this.tableLayoutPanelLowerBlade.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanelLowerBlade.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanelLowerBlade.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelLowerBlade.Size = new System.Drawing.Size(306, 157);
            this.tableLayoutPanelLowerBlade.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(30, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Shader";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(31, 42);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Length";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(36, 71);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "Width";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 101);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 13);
            this.label16.TabIndex = 3;
            this.label16.Text = "Open Rate";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 134);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 13);
            this.label17.TabIndex = 4;
            this.label17.Text = "Close Rate";
            // 
            // textBoxLowerShdr
            // 
            this.textBoxLowerShdr.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBoxLowerShdr.Location = new System.Drawing.Point(77, 6);
            this.textBoxLowerShdr.Name = "textBoxLowerShdr";
            this.textBoxLowerShdr.Size = new System.Drawing.Size(226, 20);
            this.textBoxLowerShdr.TabIndex = 5;
            this.textBoxLowerShdr.TextChanged += new System.EventHandler(this.control_ChangesMade);
            // 
            // textBoxLowerLength
            // 
            this.textBoxLowerLength.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxLowerLength.Location = new System.Drawing.Point(77, 38);
            this.textBoxLowerLength.Name = "textBoxLowerLength";
            this.textBoxLowerLength.Size = new System.Drawing.Size(58, 20);
            this.textBoxLowerLength.TabIndex = 6;
            this.textBoxLowerLength.TextChanged += new System.EventHandler(this.control_ChangesMade);
            // 
            // textBoxLowerWidth
            // 
            this.textBoxLowerWidth.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxLowerWidth.Location = new System.Drawing.Point(77, 67);
            this.textBoxLowerWidth.Name = "textBoxLowerWidth";
            this.textBoxLowerWidth.Size = new System.Drawing.Size(58, 20);
            this.textBoxLowerWidth.TabIndex = 7;
            this.textBoxLowerWidth.TextChanged += new System.EventHandler(this.control_ChangesMade);
            // 
            // textBoxLowerOpenSpd
            // 
            this.textBoxLowerOpenSpd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxLowerOpenSpd.Location = new System.Drawing.Point(77, 97);
            this.textBoxLowerOpenSpd.Name = "textBoxLowerOpenSpd";
            this.textBoxLowerOpenSpd.Size = new System.Drawing.Size(58, 20);
            this.textBoxLowerOpenSpd.TabIndex = 8;
            this.textBoxLowerOpenSpd.TextChanged += new System.EventHandler(this.control_ChangesMade);
            // 
            // textBoxLowerCloseSpd
            // 
            this.textBoxLowerCloseSpd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxLowerCloseSpd.Location = new System.Drawing.Point(77, 130);
            this.textBoxLowerCloseSpd.Name = "textBoxLowerCloseSpd";
            this.textBoxLowerCloseSpd.Size = new System.Drawing.Size(58, 20);
            this.textBoxLowerCloseSpd.TabIndex = 9;
            this.textBoxLowerCloseSpd.TextChanged += new System.EventHandler(this.control_ChangesMade);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(340, 143);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Lower Blade";
            // 
            // LsbPlugin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(680, 553);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.toolStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Name = "LsbPlugin";
            this.Text = "Lightsaber Blade Editor";
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.tableLayoutPanelAttributes.ResumeLayout(false);
            this.tableLayoutPanelAttributes.PerformLayout();
            this.panelAttributes.ResumeLayout(false);
            this.panelUpperBlade.ResumeLayout(false);
            this.tableLayoutPanelUpperBlade.ResumeLayout(false);
            this.tableLayoutPanelUpperBlade.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelFlicker.ResumeLayout(false);
            this.tableLayoutPanelFlicker.ResumeLayout(false);
            this.tableLayoutPanelFlicker.PerformLayout();
            this.panelLowerBlade.ResumeLayout(false);
            this.tableLayoutPanelLowerBlade.ResumeLayout(false);
            this.tableLayoutPanelLowerBlade.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripBtnNew;
        private System.Windows.Forms.ToolStripButton toolStripBtnOpen;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelAttributes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAppearance;
        private System.Windows.Forms.TextBox textBoxSound;
        private System.Windows.Forms.Panel panelAttributes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBoxFlicker;
        private System.Windows.Forms.Panel panelUpperBlade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelUpperBlade;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxUpperShdr;
        private System.Windows.Forms.TextBox textBoxUpperLength;
        private System.Windows.Forms.TextBox textBoxUpperWidth;
        private System.Windows.Forms.TextBox textBoxUpperOpenSpd;
        private System.Windows.Forms.TextBox textBoxUpperCloseSpd;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox checkBoxDblBlade;
        private System.Windows.Forms.Panel panelLowerBlade;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelLowerBlade;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBoxLowerShdr;
        private System.Windows.Forms.TextBox textBoxLowerLength;
        private System.Windows.Forms.TextBox textBoxLowerWidth;
        private System.Windows.Forms.TextBox textBoxLowerOpenSpd;
        private System.Windows.Forms.TextBox textBoxLowerCloseSpd;
        private System.Windows.Forms.Panel panelFlicker;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelFlicker;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBoxFlickerTimeMin;
        private System.Windows.Forms.TextBox textBoxFlickerTimeMax;
        private System.Windows.Forms.CheckBox checkBoxFlickerAware;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button buttonFlickerColor;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox textBoxFlickerRangeMin;
        private System.Windows.Forms.TextBox textBoxFlickerRangeMax;
    }
}

