namespace WinRestClient
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
            this.label1 = new System.Windows.Forms.Label();
            this.TBReqURI = new System.Windows.Forms.TextBox();
            this.btnRunRESTmethod = new System.Windows.Forms.Button();
            this.TBResponse = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TBApiKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Req URI";
            // 
            // TBReqURI
            // 
            this.TBReqURI.Location = new System.Drawing.Point(116, 31);
            this.TBReqURI.Name = "TBReqURI";
            this.TBReqURI.Size = new System.Drawing.Size(474, 20);
            this.TBReqURI.TabIndex = 1;
            this.TBReqURI.Text = "http://localhost:15717/api/Customer";
            // 
            // btnRunRESTmethod
            // 
            this.btnRunRESTmethod.Location = new System.Drawing.Point(597, 31);
            this.btnRunRESTmethod.Name = "btnRunRESTmethod";
            this.btnRunRESTmethod.Size = new System.Drawing.Size(75, 52);
            this.btnRunRESTmethod.TabIndex = 2;
            this.btnRunRESTmethod.Text = "GO!";
            this.btnRunRESTmethod.UseVisualStyleBackColor = true;
            this.btnRunRESTmethod.Click += new System.EventHandler(this.btnRunRESTmethod_Click);
            // 
            // TBResponse
            // 
            this.TBResponse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBResponse.Location = new System.Drawing.Point(116, 134);
            this.TBResponse.Multiline = true;
            this.TBResponse.Name = "TBResponse";
            this.TBResponse.Size = new System.Drawing.Size(555, 176);
            this.TBResponse.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Response";
            // 
            // TBApiKey
            // 
            this.TBApiKey.Location = new System.Drawing.Point(117, 63);
            this.TBApiKey.Name = "TBApiKey";
            this.TBApiKey.Size = new System.Drawing.Size(474, 20);
            this.TBApiKey.TabIndex = 6;
            this.TBApiKey.Text = "DFSDFSD7G8FGDF87GDF8F";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "API Key";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 334);
            this.Controls.Add(this.TBApiKey);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBResponse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRunRESTmethod);
            this.Controls.Add(this.TBReqURI);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "REST Client - C#";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBReqURI;
        private System.Windows.Forms.Button btnRunRESTmethod;
        private System.Windows.Forms.TextBox TBResponse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBApiKey;
        private System.Windows.Forms.Label label3;
    }
}

