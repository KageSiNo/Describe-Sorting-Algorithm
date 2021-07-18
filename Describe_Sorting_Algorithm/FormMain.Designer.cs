namespace Describe_Sorting_Algorithm
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lbComparisons = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbSwaps = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbElap = new System.Windows.Forms.Label();
            this.groupBoxControl = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.nudValue = new System.Windows.Forms.NumericUpDown();
            this.lbCapicity = new System.Windows.Forms.Label();
            this.pnlRadioes = new System.Windows.Forms.Panel();
            this.radioBtnHeap = new System.Windows.Forms.RadioButton();
            this.radioBtnQuick = new System.Windows.Forms.RadioButton();
            this.radioBtnBubble = new System.Windows.Forms.RadioButton();
            this.radioBtnMerge = new System.Windows.Forms.RadioButton();
            this.radioBtnInsertion = new System.Windows.Forms.RadioButton();
            this.radioBtnSelection = new System.Windows.Forms.RadioButton();
            this.lbFPS = new System.Windows.Forms.Label();
            this.trackBarFPS = new System.Windows.Forms.TrackBar();
            this.btnCreateRnd = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTxbAlg = new System.Windows.Forms.RichTextBox();
            this.pnlMain.SuspendLayout();
            this.groupBoxControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudValue)).BeginInit();
            this.pnlRadioes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFPS)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.lbComparisons);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.lbSwaps);
            this.pnlMain.Controls.Add(this.label8);
            this.pnlMain.Controls.Add(this.label2);
            this.pnlMain.Controls.Add(this.lbElap);
            resources.ApplyResources(this.pnlMain, "pnlMain");
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelMain_Paint);
            // 
            // lbComparisons
            // 
            resources.ApplyResources(this.lbComparisons, "lbComparisons");
            this.lbComparisons.BackColor = System.Drawing.Color.Transparent;
            this.lbComparisons.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbComparisons.Name = "lbComparisons";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Name = "label1";
            // 
            // lbSwaps
            // 
            resources.ApplyResources(this.lbSwaps, "lbSwaps");
            this.lbSwaps.BackColor = System.Drawing.Color.Transparent;
            this.lbSwaps.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbSwaps.Name = "lbSwaps";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label8.Name = "label8";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Name = "label2";
            // 
            // lbElap
            // 
            resources.ApplyResources(this.lbElap, "lbElap");
            this.lbElap.BackColor = System.Drawing.Color.Transparent;
            this.lbElap.ForeColor = System.Drawing.Color.Blue;
            this.lbElap.Name = "lbElap";
            // 
            // groupBoxControl
            // 
            this.groupBoxControl.Controls.Add(this.btnReset);
            this.groupBoxControl.Controls.Add(this.nudValue);
            this.groupBoxControl.Controls.Add(this.lbCapicity);
            this.groupBoxControl.Controls.Add(this.pnlRadioes);
            this.groupBoxControl.Controls.Add(this.lbFPS);
            this.groupBoxControl.Controls.Add(this.trackBarFPS);
            this.groupBoxControl.Controls.Add(this.btnCreateRnd);
            this.groupBoxControl.Controls.Add(this.btnRun);
            this.groupBoxControl.ForeColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.groupBoxControl, "groupBoxControl");
            this.groupBoxControl.Name = "groupBoxControl";
            this.groupBoxControl.TabStop = false;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.btnReset, "btnReset");
            this.btnReset.Name = "btnReset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // nudValue
            // 
            this.nudValue.BackColor = System.Drawing.Color.DimGray;
            this.nudValue.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.nudValue, "nudValue");
            this.nudValue.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudValue.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudValue.Name = "nudValue";
            this.nudValue.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lbCapicity
            // 
            resources.ApplyResources(this.lbCapicity, "lbCapicity");
            this.lbCapicity.Name = "lbCapicity";
            // 
            // pnlRadioes
            // 
            this.pnlRadioes.Controls.Add(this.radioBtnHeap);
            this.pnlRadioes.Controls.Add(this.radioBtnQuick);
            this.pnlRadioes.Controls.Add(this.radioBtnBubble);
            this.pnlRadioes.Controls.Add(this.radioBtnMerge);
            this.pnlRadioes.Controls.Add(this.radioBtnInsertion);
            this.pnlRadioes.Controls.Add(this.radioBtnSelection);
            resources.ApplyResources(this.pnlRadioes, "pnlRadioes");
            this.pnlRadioes.Name = "pnlRadioes";
            // 
            // radioBtnHeap
            // 
            resources.ApplyResources(this.radioBtnHeap, "radioBtnHeap");
            this.radioBtnHeap.Name = "radioBtnHeap";
            this.radioBtnHeap.UseVisualStyleBackColor = true;
            this.radioBtnHeap.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioBtnQuick
            // 
            resources.ApplyResources(this.radioBtnQuick, "radioBtnQuick");
            this.radioBtnQuick.Name = "radioBtnQuick";
            this.radioBtnQuick.UseVisualStyleBackColor = true;
            this.radioBtnQuick.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioBtnBubble
            // 
            resources.ApplyResources(this.radioBtnBubble, "radioBtnBubble");
            this.radioBtnBubble.Name = "radioBtnBubble";
            this.radioBtnBubble.UseVisualStyleBackColor = true;
            this.radioBtnBubble.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioBtnMerge
            // 
            resources.ApplyResources(this.radioBtnMerge, "radioBtnMerge");
            this.radioBtnMerge.Name = "radioBtnMerge";
            this.radioBtnMerge.UseVisualStyleBackColor = true;
            this.radioBtnMerge.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioBtnInsertion
            // 
            resources.ApplyResources(this.radioBtnInsertion, "radioBtnInsertion");
            this.radioBtnInsertion.Name = "radioBtnInsertion";
            this.radioBtnInsertion.UseVisualStyleBackColor = true;
            this.radioBtnInsertion.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioBtnSelection
            // 
            resources.ApplyResources(this.radioBtnSelection, "radioBtnSelection");
            this.radioBtnSelection.Checked = true;
            this.radioBtnSelection.Name = "radioBtnSelection";
            this.radioBtnSelection.TabStop = true;
            this.radioBtnSelection.UseVisualStyleBackColor = true;
            this.radioBtnSelection.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // lbFPS
            // 
            resources.ApplyResources(this.lbFPS, "lbFPS");
            this.lbFPS.Name = "lbFPS";
            // 
            // trackBarFPS
            // 
            resources.ApplyResources(this.trackBarFPS, "trackBarFPS");
            this.trackBarFPS.Maximum = 200;
            this.trackBarFPS.Minimum = 10;
            this.trackBarFPS.Name = "trackBarFPS";
            this.trackBarFPS.Value = 60;
            this.trackBarFPS.Scroll += new System.EventHandler(this.trackBarFPS_Scroll);
            // 
            // btnCreateRnd
            // 
            this.btnCreateRnd.BackColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.btnCreateRnd, "btnCreateRnd");
            this.btnCreateRnd.Name = "btnCreateRnd";
            this.btnCreateRnd.UseVisualStyleBackColor = false;
            this.btnCreateRnd.Click += new System.EventHandler(this.btnCreateRnd_Click);
            // 
            // btnRun
            // 
            this.btnRun.BackColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.btnRun, "btnRun");
            this.btnRun.Name = "btnRun";
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richTxbAlg);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // richTxbAlg
            // 
            this.richTxbAlg.BackColor = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this.richTxbAlg, "richTxbAlg");
            this.richTxbAlg.ForeColor = System.Drawing.SystemColors.Window;
            this.richTxbAlg.Name = "richTxbAlg";
            this.richTxbAlg.ReadOnly = true;
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxControl);
            this.Controls.Add(this.pnlMain);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "FormMain";
            this.Load += new System.EventHandler(this.FmMain_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.groupBoxControl.ResumeLayout(false);
            this.groupBoxControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudValue)).EndInit();
            this.pnlRadioes.ResumeLayout(false);
            this.pnlRadioes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFPS)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.GroupBox groupBoxControl;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnCreateRnd;
        private System.Windows.Forms.TrackBar trackBarFPS;
        private System.Windows.Forms.Label lbFPS;
        private System.Windows.Forms.Panel pnlRadioes;
        private System.Windows.Forms.RadioButton radioBtnHeap;
        private System.Windows.Forms.RadioButton radioBtnQuick;
        private System.Windows.Forms.RadioButton radioBtnBubble;
        private System.Windows.Forms.RadioButton radioBtnMerge;
        private System.Windows.Forms.RadioButton radioBtnInsertion;
        private System.Windows.Forms.RadioButton radioBtnSelection;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbElap;
        private System.Windows.Forms.Label lbSwaps;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbComparisons;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox richTxbAlg;
        private System.Windows.Forms.NumericUpDown nudValue;
        private System.Windows.Forms.Label lbCapicity;
        private System.Windows.Forms.Button btnReset;
    }
}

