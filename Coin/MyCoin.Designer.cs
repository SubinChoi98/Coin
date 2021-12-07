namespace Coin
{
    partial class MyCoin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.currencyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lockedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avgbuypriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avgbuypricemodifiedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.unitcurrencyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.responseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.currencyDataGridViewTextBoxColumn,
            this.balanceDataGridViewTextBoxColumn,
            this.lockedDataGridViewTextBoxColumn,
            this.avgbuypriceDataGridViewTextBoxColumn,
            this.avgbuypricemodifiedDataGridViewCheckBoxColumn,
            this.unitcurrencyDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.responseBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("굴림", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(819, 402);
            this.dataGridView1.TabIndex = 12;
            // 
            // currencyDataGridViewTextBoxColumn
            // 
            this.currencyDataGridViewTextBoxColumn.DataPropertyName = "currency";
            this.currencyDataGridViewTextBoxColumn.HeaderText = "currency";
            this.currencyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.currencyDataGridViewTextBoxColumn.Name = "currencyDataGridViewTextBoxColumn";
            this.currencyDataGridViewTextBoxColumn.Width = 125;
            // 
            // balanceDataGridViewTextBoxColumn
            // 
            this.balanceDataGridViewTextBoxColumn.DataPropertyName = "balance";
            this.balanceDataGridViewTextBoxColumn.HeaderText = "balance";
            this.balanceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.balanceDataGridViewTextBoxColumn.Name = "balanceDataGridViewTextBoxColumn";
            this.balanceDataGridViewTextBoxColumn.Width = 125;
            // 
            // lockedDataGridViewTextBoxColumn
            // 
            this.lockedDataGridViewTextBoxColumn.DataPropertyName = "locked";
            this.lockedDataGridViewTextBoxColumn.HeaderText = "locked";
            this.lockedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lockedDataGridViewTextBoxColumn.Name = "lockedDataGridViewTextBoxColumn";
            this.lockedDataGridViewTextBoxColumn.Width = 125;
            // 
            // avgbuypriceDataGridViewTextBoxColumn
            // 
            this.avgbuypriceDataGridViewTextBoxColumn.DataPropertyName = "avg_buy_price";
            this.avgbuypriceDataGridViewTextBoxColumn.HeaderText = "avg_buy_price";
            this.avgbuypriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.avgbuypriceDataGridViewTextBoxColumn.Name = "avgbuypriceDataGridViewTextBoxColumn";
            this.avgbuypriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // avgbuypricemodifiedDataGridViewCheckBoxColumn
            // 
            this.avgbuypricemodifiedDataGridViewCheckBoxColumn.DataPropertyName = "avg_buy_price_modified";
            this.avgbuypricemodifiedDataGridViewCheckBoxColumn.HeaderText = "avg_buy_price_modified";
            this.avgbuypricemodifiedDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.avgbuypricemodifiedDataGridViewCheckBoxColumn.Name = "avgbuypricemodifiedDataGridViewCheckBoxColumn";
            this.avgbuypricemodifiedDataGridViewCheckBoxColumn.Width = 125;
            // 
            // unitcurrencyDataGridViewTextBoxColumn
            // 
            this.unitcurrencyDataGridViewTextBoxColumn.DataPropertyName = "unit_currency";
            this.unitcurrencyDataGridViewTextBoxColumn.HeaderText = "unit_currency";
            this.unitcurrencyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.unitcurrencyDataGridViewTextBoxColumn.Name = "unitcurrencyDataGridViewTextBoxColumn";
            this.unitcurrencyDataGridViewTextBoxColumn.Width = 125;
            // 
            // responseBindingSource
            // 
            this.responseBindingSource.DataSource = typeof(Coin.UpbitAPI.Accounts.Response);
            // 
            // accountsBindingSource
            // 
            this.accountsBindingSource.DataSource = typeof(Coin.UpbitAPI.Accounts);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(839, 422);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(819, 402);
            this.panel1.TabIndex = 0;
            // 
            // MyCoin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(839, 422);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MyCoin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyCoin";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.responseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource responseBindingSource;
        private System.Windows.Forms.BindingSource accountsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn currencyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lockedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn avgbuypriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn avgbuypricemodifiedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitcurrencyDataGridViewTextBoxColumn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
    }
}