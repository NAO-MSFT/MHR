namespace Get_KB_Info
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.webView1 = new Microsoft.Toolkit.Forms.UI.Controls.WebView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtTBURL = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.clmLoad = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmURL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAppliesTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.webView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // webView1
            // 
            this.webView1.Location = new System.Drawing.Point(186, 304);
            this.webView1.MinimumSize = new System.Drawing.Size(20, 18);
            this.webView1.Name = "webView1";
            this.webView1.Size = new System.Drawing.Size(904, 224);
            this.webView1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmLoad,
            this.clmURL,
            this.clmTitle,
            this.Column1,
            this.clmAppliesTo,
            this.clmOS});
            this.dataGridView1.Location = new System.Drawing.Point(186, -3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(904, 292);
            this.dataGridView1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(-3, -3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add URLs";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(-3, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(190, 32);
            this.button2.TabIndex = 6;
            this.button2.Text = "Get Information";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtTBURL
            // 
            this.txtTBURL.Location = new System.Drawing.Point(186, 288);
            this.txtTBURL.Name = "txtTBURL";
            this.txtTBURL.Size = new System.Drawing.Size(904, 19);
            this.txtTBURL.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(-3, 54);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(190, 32);
            this.button3.TabIndex = 8;
            this.button3.Text = "Stop";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // clmLoad
            // 
            this.clmLoad.HeaderText = "";
            this.clmLoad.Name = "clmLoad";
            this.clmLoad.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmLoad.Width = 30;
            // 
            // clmURL
            // 
            this.clmURL.HeaderText = "URL";
            this.clmURL.Name = "clmURL";
            this.clmURL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmURL.Width = 250;
            // 
            // clmTitle
            // 
            this.clmTitle.HeaderText = "Web Page Title";
            this.clmTitle.Name = "clmTitle";
            this.clmTitle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmTitle.Width = 250;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "First Published Date";
            this.Column1.Name = "Column1";
            this.Column1.Width = 80;
            // 
            // clmAppliesTo
            // 
            this.clmAppliesTo.HeaderText = "Last Updated Data";
            this.clmAppliesTo.Name = "clmAppliesTo";
            this.clmAppliesTo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmAppliesTo.Width = 80;
            // 
            // clmOS
            // 
            this.clmOS.HeaderText = "Applies to";
            this.clmOS.Name = "clmOS";
            this.clmOS.Width = 170;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 531);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtTBURL);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.webView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.webView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Toolkit.Forms.UI.Controls.WebView webView1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtTBURL;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmLoad;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmURL;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAppliesTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOS;
    }
}

