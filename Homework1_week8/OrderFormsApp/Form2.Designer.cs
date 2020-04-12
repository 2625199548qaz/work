namespace OrderFormsApp
{
    partial class Form2
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.appleCheckBox = new System.Windows.Forms.CheckBox();
            this.milkCheckBox = new System.Windows.Forms.CheckBox();
            this.eggsCheckBox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(157, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 25);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(424, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(509, 59);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 25);
            this.textBox2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Items:";
            // 
            // appleCheckBox
            // 
            this.appleCheckBox.AutoSize = true;
            this.appleCheckBox.Location = new System.Drawing.Point(263, 159);
            this.appleCheckBox.Name = "appleCheckBox";
            this.appleCheckBox.Size = new System.Drawing.Size(69, 19);
            this.appleCheckBox.TabIndex = 5;
            this.appleCheckBox.Text = "apple";
            this.appleCheckBox.UseVisualStyleBackColor = true;
            // 
            // milkCheckBox
            // 
            this.milkCheckBox.AutoSize = true;
            this.milkCheckBox.Location = new System.Drawing.Point(477, 159);
            this.milkCheckBox.Name = "milkCheckBox";
            this.milkCheckBox.Size = new System.Drawing.Size(61, 19);
            this.milkCheckBox.TabIndex = 6;
            this.milkCheckBox.Text = "milk";
            this.milkCheckBox.UseVisualStyleBackColor = true;
            // 
            // eggsCheckBox
            // 
            this.eggsCheckBox.AutoSize = true;
            this.eggsCheckBox.Location = new System.Drawing.Point(370, 159);
            this.eggsCheckBox.Name = "eggsCheckBox";
            this.eggsCheckBox.Size = new System.Drawing.Size(61, 19);
            this.eggsCheckBox.TabIndex = 7;
            this.eggsCheckBox.Text = "eggs";
            this.eggsCheckBox.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(320, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 34);
            this.button1.TabIndex = 8;
            this.button1.Text = "确认添加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.eggsCheckBox);
            this.Controls.Add(this.milkCheckBox);
            this.Controls.Add(this.appleCheckBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "添加订单信息";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox appleCheckBox;
        private System.Windows.Forms.CheckBox milkCheckBox;
        private System.Windows.Forms.CheckBox eggsCheckBox;
        private System.Windows.Forms.Button button1;
    }
}