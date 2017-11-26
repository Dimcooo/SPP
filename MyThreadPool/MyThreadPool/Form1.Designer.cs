namespace MyThreadPool
{
    partial class Form1
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
            this.minNumbTask = new System.Windows.Forms.TextBox();
            this.btnMakeThrdPl = new System.Windows.Forms.Button();
            this.maxNumbTask = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFrstMeth = new System.Windows.Forms.Button();
            this.btnSecMeth = new System.Windows.Forms.Button();
            this.btnThrdMeth = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // minNumbTask
            // 
            this.minNumbTask.Location = new System.Drawing.Point(43, 37);
            this.minNumbTask.Multiline = true;
            this.minNumbTask.Name = "minNumbTask";
            this.minNumbTask.Size = new System.Drawing.Size(156, 22);
            this.minNumbTask.TabIndex = 0;
            // 
            // btnMakeThrdPl
            // 
            this.btnMakeThrdPl.Location = new System.Drawing.Point(43, 149);
            this.btnMakeThrdPl.Name = "btnMakeThrdPl";
            this.btnMakeThrdPl.Size = new System.Drawing.Size(156, 45);
            this.btnMakeThrdPl.TabIndex = 1;
            this.btnMakeThrdPl.Text = "Create ThreadPool";
            this.btnMakeThrdPl.UseVisualStyleBackColor = true;
            this.btnMakeThrdPl.Click += new System.EventHandler(this.button1_Click);
            // 
            // maxNumbTask
            // 
            this.maxNumbTask.Location = new System.Drawing.Point(43, 89);
            this.maxNumbTask.Multiline = true;
            this.maxNumbTask.Name = "maxNumbTask";
            this.maxNumbTask.Size = new System.Drawing.Size(156, 22);
            this.maxNumbTask.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Min numb or threads";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Man numb or threads";
            // 
            // btnFrstMeth
            // 
            this.btnFrstMeth.Location = new System.Drawing.Point(242, 149);
            this.btnFrstMeth.Name = "btnFrstMeth";
            this.btnFrstMeth.Size = new System.Drawing.Size(135, 28);
            this.btnFrstMeth.TabIndex = 5;
            this.btnFrstMeth.Text = "Do something";
            this.btnFrstMeth.UseVisualStyleBackColor = true;
            this.btnFrstMeth.Click += new System.EventHandler(this.btnFrstMeth_Click);
            // 
            // btnSecMeth
            // 
            this.btnSecMeth.Location = new System.Drawing.Point(242, 199);
            this.btnSecMeth.Name = "btnSecMeth";
            this.btnSecMeth.Size = new System.Drawing.Size(135, 32);
            this.btnSecMeth.TabIndex = 6;
            this.btnSecMeth.Text = "Do something";
            this.btnSecMeth.UseVisualStyleBackColor = true;
            this.btnSecMeth.Click += new System.EventHandler(this.btnSecMeth_Click);
            // 
            // btnThrdMeth
            // 
            this.btnThrdMeth.Location = new System.Drawing.Point(245, 253);
            this.btnThrdMeth.Name = "btnThrdMeth";
            this.btnThrdMeth.Size = new System.Drawing.Size(132, 30);
            this.btnThrdMeth.TabIndex = 7;
            this.btnThrdMeth.Text = "Do Something";
            this.btnThrdMeth.UseVisualStyleBackColor = true;
            this.btnThrdMeth.Click += new System.EventHandler(this.btnThrdMeth_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 314);
            this.Controls.Add(this.btnThrdMeth);
            this.Controls.Add(this.btnSecMeth);
            this.Controls.Add(this.btnFrstMeth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maxNumbTask);
            this.Controls.Add(this.btnMakeThrdPl);
            this.Controls.Add(this.minNumbTask);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox minNumbTask;
        private System.Windows.Forms.Button btnMakeThrdPl;
        private System.Windows.Forms.TextBox maxNumbTask;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFrstMeth;
        private System.Windows.Forms.Button btnSecMeth;
        private System.Windows.Forms.Button btnThrdMeth;
    }
}

