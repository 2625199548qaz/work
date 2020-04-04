namespace CayleyTree
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.trackBar_th2 = new System.Windows.Forms.TrackBar();
            this.trackBar_th1 = new System.Windows.Forms.TrackBar();
            this.trackBar_per2 = new System.Windows.Forms.TrackBar();
            this.trackBar_per1 = new System.Windows.Forms.TrackBar();
            this.trackBar_len = new System.Windows.Forms.TrackBar();
            this.trackBar_n = new System.Windows.Forms.TrackBar();
            this.comboBox_pen = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_th2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_th1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_per2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_per1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_len)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_n)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(847, 431);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "draw";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.trackBar_th2);
            this.panel1.Controls.Add(this.trackBar_th1);
            this.panel1.Controls.Add(this.trackBar_per2);
            this.panel1.Controls.Add(this.trackBar_per1);
            this.panel1.Controls.Add(this.trackBar_len);
            this.panel1.Controls.Add(this.trackBar_n);
            this.panel1.Controls.Add(this.comboBox_pen);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1030, 506);
            this.panel1.TabIndex = 2;
            // 
            // trackBar_th2
            // 
            this.trackBar_th2.Location = new System.Drawing.Point(905, 291);
            this.trackBar_th2.Maximum = 20;
            this.trackBar_th2.Name = "trackBar_th2";
            this.trackBar_th2.Size = new System.Drawing.Size(104, 56);
            this.trackBar_th2.TabIndex = 20;
            // 
            // trackBar_th1
            // 
            this.trackBar_th1.Location = new System.Drawing.Point(905, 233);
            this.trackBar_th1.Maximum = 30;
            this.trackBar_th1.Name = "trackBar_th1";
            this.trackBar_th1.Size = new System.Drawing.Size(104, 56);
            this.trackBar_th1.TabIndex = 19;
            // 
            // trackBar_per2
            // 
            this.trackBar_per2.Location = new System.Drawing.Point(905, 171);
            this.trackBar_per2.Maximum = 7;
            this.trackBar_per2.Name = "trackBar_per2";
            this.trackBar_per2.Size = new System.Drawing.Size(104, 56);
            this.trackBar_per2.TabIndex = 18;
            // 
            // trackBar_per1
            // 
            this.trackBar_per1.Location = new System.Drawing.Point(905, 109);
            this.trackBar_per1.Maximum = 6;
            this.trackBar_per1.Name = "trackBar_per1";
            this.trackBar_per1.Size = new System.Drawing.Size(104, 56);
            this.trackBar_per1.TabIndex = 17;
            // 
            // trackBar_len
            // 
            this.trackBar_len.Location = new System.Drawing.Point(905, 47);
            this.trackBar_len.Maximum = 100;
            this.trackBar_len.Name = "trackBar_len";
            this.trackBar_len.Size = new System.Drawing.Size(104, 56);
            this.trackBar_len.TabIndex = 16;
            // 
            // trackBar_n
            // 
            this.trackBar_n.Location = new System.Drawing.Point(905, 3);
            this.trackBar_n.Name = "trackBar_n";
            this.trackBar_n.Size = new System.Drawing.Size(104, 56);
            this.trackBar_n.TabIndex = 15;
            // 
            // comboBox_pen
            // 
            this.comboBox_pen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_pen.FormattingEnabled = true;
            this.comboBox_pen.Items.AddRange(new object[] {
            "红色",
            "黄色",
            "蓝色",
            "绿色"});
            this.comboBox_pen.Location = new System.Drawing.Point(900, 353);
            this.comboBox_pen.Name = "comboBox_pen";
            this.comboBox_pen.Size = new System.Drawing.Size(121, 23);
            this.comboBox_pen.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(802, 361);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "画笔颜色：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(802, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "左分支角度：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(803, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "右分支角度：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(803, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "左分支长度比：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(803, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "右分支长度比：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(817, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "主干长度：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(817, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "递归深度：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 505);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_th2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_th1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_per2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_per1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_len)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_n)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_pen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBar_th2;
        private System.Windows.Forms.TrackBar trackBar_th1;
        private System.Windows.Forms.TrackBar trackBar_per2;
        private System.Windows.Forms.TrackBar trackBar_per1;
        private System.Windows.Forms.TrackBar trackBar_len;
        private System.Windows.Forms.TrackBar trackBar_n;
    }
}

