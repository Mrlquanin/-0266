
namespace 第七周作业
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(621, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 91);
            this.button1.TabIndex = 0;
            this.button1.Text = "绘图";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "按如下所示输入";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(65, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 21);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "递归深度";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(65, 141);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(120, 21);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "主干长度";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(65, 230);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(120, 21);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "右分支长度比";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(65, 302);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(120, 21);
            this.textBox4.TabIndex = 5;
            this.textBox4.Text = "左分支长度比";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(475, 85);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(119, 21);
            this.textBox5.TabIndex = 6;
            this.textBox5.Text = "右分支角度";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(475, 171);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(119, 21);
            this.textBox6.TabIndex = 7;
            this.textBox6.Text = "左分支角度";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(475, 244);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(161, 21);
            this.textBox7.TabIndex = 8;
            this.textBox7.Text = "画笔颜色(用英语小写)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
    }
}

