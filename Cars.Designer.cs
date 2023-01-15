namespace Car_Auction
{
    partial class Cars
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnNew = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnBid = new System.Windows.Forms.Button();
            this.btnCurrentBids = new System.Windows.Forms.Button();
            this.lblBalance = new System.Windows.Forms.Label();
            this.Bid = new System.Windows.Forms.GroupBox();
            this.btnYourCars = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Bid.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(66, 272);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(672, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(75, 53);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(661, 27);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(27, 13);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "user";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(168, 108);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(586, 179);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(613, 216);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnBid
            // 
            this.btnBid.Location = new System.Drawing.Point(0, 25);
            this.btnBid.Name = "btnBid";
            this.btnBid.Size = new System.Drawing.Size(75, 23);
            this.btnBid.TabIndex = 6;
            this.btnBid.Text = "Bid";
            this.btnBid.UseVisualStyleBackColor = true;
            this.btnBid.Click += new System.EventHandler(this.btnBid_Click);
            // 
            // btnCurrentBids
            // 
            this.btnCurrentBids.Location = new System.Drawing.Point(79, 49);
            this.btnCurrentBids.Name = "btnCurrentBids";
            this.btnCurrentBids.Size = new System.Drawing.Size(75, 23);
            this.btnCurrentBids.TabIndex = 8;
            this.btnCurrentBids.Text = "Current Bids";
            this.btnCurrentBids.UseVisualStyleBackColor = true;
            this.btnCurrentBids.Click += new System.EventHandler(this.btnCurrentBids_Click);
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(610, 58);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(83, 13);
            this.lblBalance.TabIndex = 9;
            this.lblBalance.Text = "Current Balance";
            // 
            // Bid
            // 
            this.Bid.Controls.Add(this.btnCurrentBids);
            this.Bid.Controls.Add(this.btnBid);
            this.Bid.Location = new System.Drawing.Point(332, 93);
            this.Bid.Name = "Bid";
            this.Bid.Size = new System.Drawing.Size(173, 90);
            this.Bid.TabIndex = 10;
            this.Bid.TabStop = false;
            this.Bid.Text = "Bid";
            this.Bid.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnYourCars
            // 
            this.btnYourCars.Location = new System.Drawing.Point(613, 108);
            this.btnYourCars.Name = "btnYourCars";
            this.btnYourCars.Size = new System.Drawing.Size(75, 23);
            this.btnYourCars.TabIndex = 11;
            this.btnYourCars.Text = "Your Cars";
            this.btnYourCars.UseVisualStyleBackColor = true;
            this.btnYourCars.Click += new System.EventHandler(this.btnYourCars_Click);
            // 
            // Cars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnYourCars);
            this.Controls.Add(this.Bid);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Cars";
            this.Text = "Cars";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Bid.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnBid;
        private System.Windows.Forms.Button btnCurrentBids;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.GroupBox Bid;
        private System.Windows.Forms.Button btnYourCars;
    }
}