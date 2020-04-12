namespace OrderFormsApp
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.appleCheckBox = new System.Windows.Forms.CheckBox();
            this.eggsCheckBox = new System.Windows.Forms.CheckBox();
            this.milkCheckBox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入要修改的订单号：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(255, 119);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(80, 25);
            this.textBox1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(402, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "修改后订单的客户：";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(550, 119);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 25);
            this.textBox3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "修改后订单的Items：";
            // 
            // appleCheckBox
            // 
            this.appleCheckBox.AutoSize = true;
            this.appleCheckBox.Location = new System.Drawing.Point(322, 226);
            this.appleCheckBox.Name = "appleCheckBox";
            this.appleCheckBox.Size = new System.Drawing.Size(69, 19);
            this.appleCheckBox.TabIndex = 7;
            this.appleCheckBox.Text = "apple";
            this.appleCheckBox.UseVisualStyleBackColor = true;
            // 
            // eggsCheckBox
            // 
            this.eggsCheckBox.AutoSize = true;
            this.eggsCheckBox.Location = new System.Drawing.Point(438, 226);
            this.eggsCheckBox.Name = "eggsCheckBox";
            this.eggsCheckBox.Size = new System.Drawing.Size(61, 19);
            this.eggsCheckBox.TabIndex = 8;
            this.eggsCheckBox.Text = "eggs";
            this.eggsCheckBox.UseVisualStyleBackColor = true;
            // 
            // milkCheckBox
            // 
            this.milkCheckBox.AutoSize = true;
            this.milkCheckBox.Location = new System.Drawing.Point(554, 227);
            this.milkCheckBox.Name = "milkCheckBox";
            this.milkCheckBox.Size = new System.Drawing.Size(61, 19);
            this.milkCheckBox.TabIndex = 9;
            this.milkCheckBox.Text = "milk";
            this.milkCheckBox.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(337, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 37);
            this.button1.TabIndex = 10;
            this.button1.Text = "确认修改";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.milkCheckBox);
            this.Controls.Add(this.eggsCheckBox);
            this.Controls.Add(this.appleCheckBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "修改订单";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox appleCheckBox;
        private System.Windows.Forms.CheckBox eggsCheckBox;
        private System.Windows.Forms.CheckBox milkCheckBox;
        private System.Windows.Forms.Button button1;
    }
}