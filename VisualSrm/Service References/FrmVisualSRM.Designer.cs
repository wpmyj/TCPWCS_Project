﻿namespace Test
{
    partial class FrmVisualSRM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVisualSRM));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmBGate = new System.Windows.Forms.ComboBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.tBContainerID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lsBRunning = new System.Windows.Forms.ListBox();
            this.lbIsNewTask = new System.Windows.Forms.Label();
            this.lbTaskId = new System.Windows.Forms.Label();
            this.lbToCeng = new System.Windows.Forms.Label();
            this.lbFromCeng = new System.Windows.Forms.Label();
            this.lbToLie = new System.Windows.Forms.Label();
            this.lbFromLie = new System.Windows.Forms.Label();
            this.lbToPai = new System.Windows.Forms.Label();
            this.lbfromPai = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_Alert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(62)))), ((int)(((byte)(38)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "虚拟堆垛机";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(381, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 133);
            this.button1.TabIndex = 2;
            this.button1.Text = "通电";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 484);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "当前任务完成";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmBGate);
            this.panel1.Controls.Add(this.btnSend);
            this.panel1.Controls.Add(this.tBContainerID);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lsBRunning);
            this.panel1.Controls.Add(this.lbIsNewTask);
            this.panel1.Controls.Add(this.lbTaskId);
            this.panel1.Controls.Add(this.lbToCeng);
            this.panel1.Controls.Add(this.lbFromCeng);
            this.panel1.Controls.Add(this.lbToLie);
            this.panel1.Controls.Add(this.lbFromLie);
            this.panel1.Controls.Add(this.lbToPai);
            this.panel1.Controls.Add(this.lbfromPai);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(62, 170);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 308);
            this.panel1.TabIndex = 4;
            // 
            // cmBGate
            // 
            this.cmBGate.FormattingEnabled = true;
            this.cmBGate.Items.AddRange(new object[] {
            "10301",
            "11901"});
            this.cmBGate.Location = new System.Drawing.Point(253, -6);
            this.cmBGate.Name = "cmBGate";
            this.cmBGate.Size = new System.Drawing.Size(65, 20);
            this.cmBGate.TabIndex = 18;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(253, 46);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(66, 23);
            this.btnSend.TabIndex = 17;
            this.btnSend.Text = "条码发送";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tBContainerID
            // 
            this.tBContainerID.Font = new System.Drawing.Font("宋体", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tBContainerID.Location = new System.Drawing.Point(210, 20);
            this.tBContainerID.Name = "tBContainerID";
            this.tBContainerID.Size = new System.Drawing.Size(108, 19);
            this.tBContainerID.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(208, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 12);
            this.label8.TabIndex = 15;
            this.label8.Text = "阅读器:";
            // 
            // lsBRunning
            // 
            this.lsBRunning.FormattingEnabled = true;
            this.lsBRunning.ItemHeight = 12;
            this.lsBRunning.Location = new System.Drawing.Point(4, 159);
            this.lsBRunning.Name = "lsBRunning";
            this.lsBRunning.Size = new System.Drawing.Size(314, 148);
            this.lsBRunning.TabIndex = 14;
            // 
            // lbIsNewTask
            // 
            this.lbIsNewTask.AutoSize = true;
            this.lbIsNewTask.Location = new System.Drawing.Point(223, 121);
            this.lbIsNewTask.Name = "lbIsNewTask";
            this.lbIsNewTask.Size = new System.Drawing.Size(59, 12);
            this.lbIsNewTask.TabIndex = 13;
            this.lbIsNewTask.Text = "是否下发:";
            // 
            // lbTaskId
            // 
            this.lbTaskId.AutoSize = true;
            this.lbTaskId.Location = new System.Drawing.Point(223, 89);
            this.lbTaskId.Name = "lbTaskId";
            this.lbTaskId.Size = new System.Drawing.Size(47, 12);
            this.lbTaskId.TabIndex = 12;
            this.lbTaskId.Text = "任务号:";
            // 
            // lbToCeng
            // 
            this.lbToCeng.AutoSize = true;
            this.lbToCeng.Location = new System.Drawing.Point(163, 121);
            this.lbToCeng.Name = "lbToCeng";
            this.lbToCeng.Size = new System.Drawing.Size(17, 12);
            this.lbToCeng.TabIndex = 11;
            this.lbToCeng.Text = "00";
            // 
            // lbFromCeng
            // 
            this.lbFromCeng.AutoSize = true;
            this.lbFromCeng.Location = new System.Drawing.Point(72, 121);
            this.lbFromCeng.Name = "lbFromCeng";
            this.lbFromCeng.Size = new System.Drawing.Size(17, 12);
            this.lbFromCeng.TabIndex = 10;
            this.lbFromCeng.Text = "00";
            // 
            // lbToLie
            // 
            this.lbToLie.AutoSize = true;
            this.lbToLie.Location = new System.Drawing.Point(163, 89);
            this.lbToLie.Name = "lbToLie";
            this.lbToLie.Size = new System.Drawing.Size(17, 12);
            this.lbToLie.TabIndex = 9;
            this.lbToLie.Text = "00";
            // 
            // lbFromLie
            // 
            this.lbFromLie.AutoSize = true;
            this.lbFromLie.Location = new System.Drawing.Point(72, 89);
            this.lbFromLie.Name = "lbFromLie";
            this.lbFromLie.Size = new System.Drawing.Size(17, 12);
            this.lbFromLie.TabIndex = 8;
            this.lbFromLie.Text = "00";
            // 
            // lbToPai
            // 
            this.lbToPai.AutoSize = true;
            this.lbToPai.Location = new System.Drawing.Point(163, 60);
            this.lbToPai.Name = "lbToPai";
            this.lbToPai.Size = new System.Drawing.Size(17, 12);
            this.lbToPai.TabIndex = 7;
            this.lbToPai.Text = "00";
            // 
            // lbfromPai
            // 
            this.lbfromPai.AutoSize = true;
            this.lbfromPai.Location = new System.Drawing.Point(72, 60);
            this.lbfromPai.Name = "lbfromPai";
            this.lbfromPai.Size = new System.Drawing.Size(17, 12);
            this.lbfromPai.TabIndex = 6;
            this.lbfromPai.Text = "00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 12);
            this.label7.TabIndex = 5;
            this.label7.Text = "列:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "层:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "排:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(161, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "目标位:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "起始位:";
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "当前指令";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "载货台货物左后超差",
            "行走停准失败",
            "行走电机运行超时",
            "起升变频器故障"});
            this.comboBox1.Location = new System.Drawing.Point(196, 484);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 20);
            this.comboBox1.TabIndex = 5;
            // 
            // btn_Alert
            // 
            this.btn_Alert.Location = new System.Drawing.Point(302, 484);
            this.btn_Alert.Name = "btn_Alert";
            this.btn_Alert.Size = new System.Drawing.Size(67, 23);
            this.btn_Alert.TabIndex = 6;
            this.btn_Alert.Text = "报警";
            this.btn_Alert.UseVisualStyleBackColor = true;
            this.btn_Alert.Click += new System.EventHandler(this.button3_Click);
            // 
            // FrmVisualSRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(381, 517);
            this.Controls.Add(this.btn_Alert);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmVisualSRM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VisualSRM";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmVisualSRM_FormClosed);
            this.Load += new System.EventHandler(this.FrmVisualSRM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbIsNewTask;
        private System.Windows.Forms.Label lbTaskId;
        private System.Windows.Forms.Label lbToCeng;
        private System.Windows.Forms.Label lbFromCeng;
        private System.Windows.Forms.Label lbToLie;
        private System.Windows.Forms.Label lbFromLie;
        private System.Windows.Forms.Label lbToPai;
        private System.Windows.Forms.Label lbfromPai;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lsBRunning;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_Alert;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox tBContainerID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmBGate;
    }
}