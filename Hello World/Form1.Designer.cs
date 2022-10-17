namespace Hello_World
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnSay = new System.Windows.Forms.Button();
            this.labelHelloWorld = new System.Windows.Forms.Label();
            this.Count = new System.Windows.Forms.Button();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnSay
            // 
            this.btnSay.Location = new System.Drawing.Point(69, 75);
            this.btnSay.Name = "btnSay";
            this.btnSay.Size = new System.Drawing.Size(189, 66);
            this.btnSay.TabIndex = 0;
            this.btnSay.Text = "Say Hello World";
            this.btnSay.UseVisualStyleBackColor = true;
            this.btnSay.Click += new System.EventHandler(this.btnSay_Click);
            // 
            // labelHelloWorld
            // 
            this.labelHelloWorld.AutoSize = true;
            this.labelHelloWorld.Location = new System.Drawing.Point(133, 231);
            this.labelHelloWorld.Name = "labelHelloWorld";
            this.labelHelloWorld.Size = new System.Drawing.Size(33, 12);
            this.labelHelloWorld.TabIndex = 1;
            this.labelHelloWorld.Text = "label1";
            // 
            // Count
            // 
            this.Count.Location = new System.Drawing.Point(391, 75);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(189, 66);
            this.Count.TabIndex = 2;
            this.Count.Text = "Count";
            this.Count.UseVisualStyleBackColor = true;
            this.Count.Click += new System.EventHandler(this.Count_Click);
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(466, 231);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(33, 12);
            this.labelCount.TabIndex = 3;
            this.labelCount.Text = "label2";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(786, 193);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(51, 12);
            this.labelTime.TabIndex = 4;
            this.labelTime.Text = "labelTime";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 424);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.labelHelloWorld);
            this.Controls.Add(this.btnSay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSay;
        private System.Windows.Forms.Label labelHelloWorld;
        private System.Windows.Forms.Button Count;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timer1;
    }
}

