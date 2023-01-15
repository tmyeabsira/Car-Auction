namespace Car_Auction
{
    partial class AllBids
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnNewBid = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnReferesh = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(83, 230);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(640, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnNewBid
            // 
            this.btnNewBid.Location = new System.Drawing.Point(94, 172);
            this.btnNewBid.Name = "btnNewBid";
            this.btnNewBid.Size = new System.Drawing.Size(75, 23);
            this.btnNewBid.TabIndex = 1;
            this.btnNewBid.Text = "New Bid";
            this.btnNewBid.UseVisualStyleBackColor = true;
            this.btnNewBid.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(684, 57);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(35, 13);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "label1";
            // 
            // btnReferesh
            // 
            this.btnReferesh.Location = new System.Drawing.Point(348, 171);
            this.btnReferesh.Name = "btnReferesh";
            this.btnReferesh.Size = new System.Drawing.Size(75, 23);
            this.btnReferesh.TabIndex = 3;
            this.btnReferesh.Text = "Refresh";
            this.btnReferesh.UseVisualStyleBackColor = true;
            this.btnReferesh.Click += new System.EventHandler(this.btnReferesh_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // AllBids
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReferesh);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnNewBid);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AllBids";
            this.Text = "AllBids";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnNewBid;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnReferesh;
        private System.Windows.Forms.Timer timer;
    }
}