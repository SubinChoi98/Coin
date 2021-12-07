
namespace Coin
{
    partial class OrderBookForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.marketPanel = new System.Windows.Forms.Panel();
            this.marketGridPanel = new System.Windows.Forms.Panel();
            this.marketGrid = new System.Windows.Forms.DataGridView();
            this.marketGrid_CoinCodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marketGrid_CoinNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marketGrid_MarketPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marketGrid_ChangePriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marketGrid_TradePriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marketGrid_TradePrice_OriginColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marketGrid_ChangeStatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marketGridHeaderBorderPanel = new System.Windows.Forms.Panel();
            this.marketFuntionPanel = new System.Windows.Forms.Panel();
            this.marketSearchButton = new System.Windows.Forms.Button();
            this.searchCoinTextBox = new System.Windows.Forms.TextBox();
            this.searchCoinLabel = new System.Windows.Forms.Label();
            this.orderbookPanel = new System.Windows.Forms.Panel();
            this.bidPanel = new System.Windows.Forms.Panel();
            this.bidOrderBooksPanel = new System.Windows.Forms.Panel();
            this.emptyPanel = new System.Windows.Forms.Panel();
            this.askPanel = new System.Windows.Forms.Panel();
            this.askOrderBooksPanel = new System.Windows.Forms.Panel();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.InvestmentPageButton = new System.Windows.Forms.Button();
            this.bidOrderbookUnit7 = new Coin.BidOrderbookUnit();
            this.bidOrderbookUnit6 = new Coin.BidOrderbookUnit();
            this.bidOrderbookUnit5 = new Coin.BidOrderbookUnit();
            this.bidOrderbookUnit4 = new Coin.BidOrderbookUnit();
            this.bidOrderbookUnit3 = new Coin.BidOrderbookUnit();
            this.bidOrderbookUnit2 = new Coin.BidOrderbookUnit();
            this.bidOrderbookUnit1 = new Coin.BidOrderbookUnit();
            this.bidOrderbookUnit0 = new Coin.BidOrderbookUnit();
            this.askOrderbookUnit0 = new Coin.AskOrderbookUnit();
            this.askOrderbookUnit1 = new Coin.AskOrderbookUnit();
            this.askOrderbookUnit2 = new Coin.AskOrderbookUnit();
            this.askOrderbookUnit3 = new Coin.AskOrderbookUnit();
            this.askOrderbookUnit4 = new Coin.AskOrderbookUnit();
            this.askOrderbookUnit5 = new Coin.AskOrderbookUnit();
            this.askOrderbookUnit6 = new Coin.AskOrderbookUnit();
            this.askOrderbookUnit7 = new Coin.AskOrderbookUnit();
            this.tableLayoutPanel.SuspendLayout();
            this.marketPanel.SuspendLayout();
            this.marketGridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marketGrid)).BeginInit();
            this.marketFuntionPanel.SuspendLayout();
            this.orderbookPanel.SuspendLayout();
            this.bidPanel.SuspendLayout();
            this.bidOrderBooksPanel.SuspendLayout();
            this.askPanel.SuspendLayout();
            this.askOrderBooksPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 580F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.marketPanel, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.orderbookPanel, 0, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(1138, 814);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // marketPanel
            // 
            this.marketPanel.BackColor = System.Drawing.Color.White;
            this.marketPanel.Controls.Add(this.marketGridPanel);
            this.marketPanel.Controls.Add(this.marketFuntionPanel);
            this.marketPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.marketPanel.Location = new System.Drawing.Point(585, 4);
            this.marketPanel.Margin = new System.Windows.Forms.Padding(5, 4, 10, 10);
            this.marketPanel.Name = "marketPanel";
            this.marketPanel.Size = new System.Drawing.Size(543, 800);
            this.marketPanel.TabIndex = 2;
            // 
            // marketGridPanel
            // 
            this.marketGridPanel.AutoScroll = true;
            this.marketGridPanel.BackColor = System.Drawing.Color.Transparent;
            this.marketGridPanel.Controls.Add(this.marketGrid);
            this.marketGridPanel.Controls.Add(this.marketGridHeaderBorderPanel);
            this.marketGridPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.marketGridPanel.Location = new System.Drawing.Point(0, 47);
            this.marketGridPanel.Margin = new System.Windows.Forms.Padding(0);
            this.marketGridPanel.Name = "marketGridPanel";
            this.marketGridPanel.Padding = new System.Windows.Forms.Padding(10, 0, 10, 6);
            this.marketGridPanel.Size = new System.Drawing.Size(543, 753);
            this.marketGridPanel.TabIndex = 0;
            // 
            // marketGrid
            // 
            this.marketGrid.AllowUserToAddRows = false;
            this.marketGrid.AllowUserToDeleteRows = false;
            this.marketGrid.AllowUserToResizeRows = false;
            this.marketGrid.BackgroundColor = System.Drawing.Color.White;
            this.marketGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.marketGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.marketGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.marketGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.marketGrid.ColumnHeadersHeight = 32;
            this.marketGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.marketGrid_CoinCodeColumn,
            this.marketGrid_CoinNameColumn,
            this.marketGrid_MarketPriceColumn,
            this.marketGrid_ChangePriceColumn,
            this.marketGrid_TradePriceColumn,
            this.marketGrid_TradePrice_OriginColumn,
            this.marketGrid_ChangeStatusColumn});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.marketGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.marketGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.marketGrid.EnableHeadersVisualStyles = false;
            this.marketGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.marketGrid.Location = new System.Drawing.Point(10, 1);
            this.marketGrid.MultiSelect = false;
            this.marketGrid.Name = "marketGrid";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.marketGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.marketGrid.RowHeadersVisible = false;
            this.marketGrid.RowTemplate.Height = 30;
            this.marketGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.marketGrid.Size = new System.Drawing.Size(523, 746);
            this.marketGrid.TabIndex = 0;
            this.marketGrid.TabStop = false;
            this.marketGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.marketGrid_CellClick);
            this.marketGrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.marketGrid_DataBindingComplete);
            // 
            // marketGrid_CoinCodeColumn
            // 
            this.marketGrid_CoinCodeColumn.DataPropertyName = "CoinCode";
            this.marketGrid_CoinCodeColumn.HeaderText = "코인코드(숨김)";
            this.marketGrid_CoinCodeColumn.Name = "marketGrid_CoinCodeColumn";
            this.marketGrid_CoinCodeColumn.ReadOnly = true;
            this.marketGrid_CoinCodeColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.marketGrid_CoinCodeColumn.Visible = false;
            // 
            // marketGrid_CoinNameColumn
            // 
            this.marketGrid_CoinNameColumn.DataPropertyName = "CoinName";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.marketGrid_CoinNameColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.marketGrid_CoinNameColumn.HeaderText = "코인";
            this.marketGrid_CoinNameColumn.Name = "marketGrid_CoinNameColumn";
            this.marketGrid_CoinNameColumn.ReadOnly = true;
            this.marketGrid_CoinNameColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.marketGrid_CoinNameColumn.Width = 140;
            // 
            // marketGrid_MarketPriceColumn
            // 
            this.marketGrid_MarketPriceColumn.DataPropertyName = "MarketPrice";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.marketGrid_MarketPriceColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.marketGrid_MarketPriceColumn.HeaderText = "현재가";
            this.marketGrid_MarketPriceColumn.Name = "marketGrid_MarketPriceColumn";
            this.marketGrid_MarketPriceColumn.ReadOnly = true;
            this.marketGrid_MarketPriceColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.marketGrid_MarketPriceColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // marketGrid_ChangePriceColumn
            // 
            this.marketGrid_ChangePriceColumn.DataPropertyName = "ChangePrice";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.marketGrid_ChangePriceColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.marketGrid_ChangePriceColumn.HeaderText = "전일대비";
            this.marketGrid_ChangePriceColumn.Name = "marketGrid_ChangePriceColumn";
            this.marketGrid_ChangePriceColumn.ReadOnly = true;
            this.marketGrid_ChangePriceColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.marketGrid_ChangePriceColumn.Width = 140;
            // 
            // marketGrid_TradePriceColumn
            // 
            this.marketGrid_TradePriceColumn.DataPropertyName = "TradePrice";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.marketGrid_TradePriceColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.marketGrid_TradePriceColumn.HeaderText = "거래대금";
            this.marketGrid_TradePriceColumn.Name = "marketGrid_TradePriceColumn";
            this.marketGrid_TradePriceColumn.ReadOnly = true;
            this.marketGrid_TradePriceColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.marketGrid_TradePriceColumn.Width = 120;
            // 
            // marketGrid_TradePrice_OriginColumn
            // 
            this.marketGrid_TradePrice_OriginColumn.DataPropertyName = "TradePrice_Origin";
            this.marketGrid_TradePrice_OriginColumn.HeaderText = "거래대금(숨김)";
            this.marketGrid_TradePrice_OriginColumn.Name = "marketGrid_TradePrice_OriginColumn";
            this.marketGrid_TradePrice_OriginColumn.ReadOnly = true;
            this.marketGrid_TradePrice_OriginColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.marketGrid_TradePrice_OriginColumn.Visible = false;
            // 
            // marketGrid_ChangeStatusColumn
            // 
            this.marketGrid_ChangeStatusColumn.DataPropertyName = "ChangeStatus";
            this.marketGrid_ChangeStatusColumn.HeaderText = "증감상태(숨김)";
            this.marketGrid_ChangeStatusColumn.Name = "marketGrid_ChangeStatusColumn";
            this.marketGrid_ChangeStatusColumn.ReadOnly = true;
            this.marketGrid_ChangeStatusColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.marketGrid_ChangeStatusColumn.Visible = false;
            // 
            // marketGridHeaderBorderPanel
            // 
            this.marketGridHeaderBorderPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.marketGridHeaderBorderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.marketGridHeaderBorderPanel.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.marketGridHeaderBorderPanel.Location = new System.Drawing.Point(10, 0);
            this.marketGridHeaderBorderPanel.Margin = new System.Windows.Forms.Padding(0);
            this.marketGridHeaderBorderPanel.Name = "marketGridHeaderBorderPanel";
            this.marketGridHeaderBorderPanel.Size = new System.Drawing.Size(523, 1);
            this.marketGridHeaderBorderPanel.TabIndex = 0;
            // 
            // marketFuntionPanel
            // 
            this.marketFuntionPanel.BackColor = System.Drawing.Color.White;
            this.marketFuntionPanel.Controls.Add(this.InvestmentPageButton);
            this.marketFuntionPanel.Controls.Add(this.marketSearchButton);
            this.marketFuntionPanel.Controls.Add(this.searchCoinTextBox);
            this.marketFuntionPanel.Controls.Add(this.searchCoinLabel);
            this.marketFuntionPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.marketFuntionPanel.Location = new System.Drawing.Point(0, 0);
            this.marketFuntionPanel.Margin = new System.Windows.Forms.Padding(0);
            this.marketFuntionPanel.Name = "marketFuntionPanel";
            this.marketFuntionPanel.Size = new System.Drawing.Size(543, 47);
            this.marketFuntionPanel.TabIndex = 0;
            // 
            // marketSearchButton
            // 
            this.marketSearchButton.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.marketSearchButton.Location = new System.Drawing.Point(453, 7);
            this.marketSearchButton.Name = "marketSearchButton";
            this.marketSearchButton.Size = new System.Drawing.Size(80, 32);
            this.marketSearchButton.TabIndex = 3;
            this.marketSearchButton.Text = "목록 갱신";
            this.marketSearchButton.UseVisualStyleBackColor = true;
            this.marketSearchButton.Click += new System.EventHandler(this.marketSearchButton_Click);
            // 
            // searchCoinTextBox
            // 
            this.searchCoinTextBox.BackColor = System.Drawing.Color.White;
            this.searchCoinTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchCoinTextBox.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.searchCoinTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.searchCoinTextBox.Location = new System.Drawing.Point(72, 11);
            this.searchCoinTextBox.Name = "searchCoinTextBox";
            this.searchCoinTextBox.Size = new System.Drawing.Size(163, 25);
            this.searchCoinTextBox.TabIndex = 2;
            this.searchCoinTextBox.TextChanged += new System.EventHandler(this.searchCoinTextBox_TextChanged);
            // 
            // searchCoinLabel
            // 
            this.searchCoinLabel.AutoSize = true;
            this.searchCoinLabel.BackColor = System.Drawing.Color.Transparent;
            this.searchCoinLabel.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.searchCoinLabel.ForeColor = System.Drawing.Color.DimGray;
            this.searchCoinLabel.Location = new System.Drawing.Point(15, 15);
            this.searchCoinLabel.Margin = new System.Windows.Forms.Padding(0);
            this.searchCoinLabel.Name = "searchCoinLabel";
            this.searchCoinLabel.Size = new System.Drawing.Size(47, 17);
            this.searchCoinLabel.TabIndex = 0;
            this.searchCoinLabel.Text = "코인명";
            // 
            // orderbookPanel
            // 
            this.orderbookPanel.Controls.Add(this.bidPanel);
            this.orderbookPanel.Controls.Add(this.askPanel);
            this.orderbookPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.orderbookPanel.Location = new System.Drawing.Point(10, 4);
            this.orderbookPanel.Margin = new System.Windows.Forms.Padding(10, 4, 5, 10);
            this.orderbookPanel.Name = "orderbookPanel";
            this.orderbookPanel.Size = new System.Drawing.Size(565, 800);
            this.orderbookPanel.TabIndex = 1;
            // 
            // bidPanel
            // 
            this.bidPanel.Controls.Add(this.bidOrderBooksPanel);
            this.bidPanel.Controls.Add(this.emptyPanel);
            this.bidPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bidPanel.Location = new System.Drawing.Point(0, 400);
            this.bidPanel.Name = "bidPanel";
            this.bidPanel.Size = new System.Drawing.Size(565, 400);
            this.bidPanel.TabIndex = 1;
            // 
            // bidOrderBooksPanel
            // 
            this.bidOrderBooksPanel.Controls.Add(this.bidOrderbookUnit7);
            this.bidOrderBooksPanel.Controls.Add(this.bidOrderbookUnit6);
            this.bidOrderBooksPanel.Controls.Add(this.bidOrderbookUnit5);
            this.bidOrderBooksPanel.Controls.Add(this.bidOrderbookUnit4);
            this.bidOrderBooksPanel.Controls.Add(this.bidOrderbookUnit3);
            this.bidOrderBooksPanel.Controls.Add(this.bidOrderbookUnit2);
            this.bidOrderBooksPanel.Controls.Add(this.bidOrderbookUnit1);
            this.bidOrderBooksPanel.Controls.Add(this.bidOrderbookUnit0);
            this.bidOrderBooksPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bidOrderBooksPanel.Location = new System.Drawing.Point(140, 0);
            this.bidOrderBooksPanel.Name = "bidOrderBooksPanel";
            this.bidOrderBooksPanel.Size = new System.Drawing.Size(425, 400);
            this.bidOrderBooksPanel.TabIndex = 3;
            // 
            // emptyPanel
            // 
            this.emptyPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.emptyPanel.Location = new System.Drawing.Point(0, 0);
            this.emptyPanel.Name = "emptyPanel";
            this.emptyPanel.Size = new System.Drawing.Size(140, 400);
            this.emptyPanel.TabIndex = 2;
            // 
            // askPanel
            // 
            this.askPanel.Controls.Add(this.askOrderBooksPanel);
            this.askPanel.Controls.Add(this.infoPanel);
            this.askPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.askPanel.Location = new System.Drawing.Point(0, 0);
            this.askPanel.Name = "askPanel";
            this.askPanel.Size = new System.Drawing.Size(565, 400);
            this.askPanel.TabIndex = 0;
            // 
            // askOrderBooksPanel
            // 
            this.askOrderBooksPanel.Controls.Add(this.askOrderbookUnit0);
            this.askOrderBooksPanel.Controls.Add(this.askOrderbookUnit1);
            this.askOrderBooksPanel.Controls.Add(this.askOrderbookUnit2);
            this.askOrderBooksPanel.Controls.Add(this.askOrderbookUnit3);
            this.askOrderBooksPanel.Controls.Add(this.askOrderbookUnit4);
            this.askOrderBooksPanel.Controls.Add(this.askOrderbookUnit5);
            this.askOrderBooksPanel.Controls.Add(this.askOrderbookUnit6);
            this.askOrderBooksPanel.Controls.Add(this.askOrderbookUnit7);
            this.askOrderBooksPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.askOrderBooksPanel.Location = new System.Drawing.Point(0, 0);
            this.askOrderBooksPanel.Name = "askOrderBooksPanel";
            this.askOrderBooksPanel.Size = new System.Drawing.Size(425, 400);
            this.askOrderBooksPanel.TabIndex = 0;
            // 
            // infoPanel
            // 
            this.infoPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.infoPanel.Location = new System.Drawing.Point(425, 0);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(140, 400);
            this.infoPanel.TabIndex = 1;
            // 
            // InvestmentPageButton
            // 
            this.InvestmentPageButton.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.InvestmentPageButton.Location = new System.Drawing.Point(367, 7);
            this.InvestmentPageButton.Name = "InvestmentPageButton";
            this.InvestmentPageButton.Size = new System.Drawing.Size(80, 32);
            this.InvestmentPageButton.TabIndex = 4;
            this.InvestmentPageButton.Text = "투자 내역";
            this.InvestmentPageButton.UseVisualStyleBackColor = true;
            this.InvestmentPageButton.Click += new System.EventHandler(this.InvestmentPageButton_Click);
            // 
            // bidOrderbookUnit7
            // 
            this.bidOrderbookUnit7.Dock = System.Windows.Forms.DockStyle.Top;
            this.bidOrderbookUnit7.Location = new System.Drawing.Point(0, 350);
            this.bidOrderbookUnit7.Name = "bidOrderbookUnit7";
            this.bidOrderbookUnit7.Size = new System.Drawing.Size(425, 50);
            this.bidOrderbookUnit7.TabIndex = 7;
            // 
            // bidOrderbookUnit6
            // 
            this.bidOrderbookUnit6.Dock = System.Windows.Forms.DockStyle.Top;
            this.bidOrderbookUnit6.Location = new System.Drawing.Point(0, 300);
            this.bidOrderbookUnit6.Name = "bidOrderbookUnit6";
            this.bidOrderbookUnit6.Size = new System.Drawing.Size(425, 50);
            this.bidOrderbookUnit6.TabIndex = 6;
            // 
            // bidOrderbookUnit5
            // 
            this.bidOrderbookUnit5.Dock = System.Windows.Forms.DockStyle.Top;
            this.bidOrderbookUnit5.Location = new System.Drawing.Point(0, 250);
            this.bidOrderbookUnit5.Name = "bidOrderbookUnit5";
            this.bidOrderbookUnit5.Size = new System.Drawing.Size(425, 50);
            this.bidOrderbookUnit5.TabIndex = 5;
            // 
            // bidOrderbookUnit4
            // 
            this.bidOrderbookUnit4.Dock = System.Windows.Forms.DockStyle.Top;
            this.bidOrderbookUnit4.Location = new System.Drawing.Point(0, 200);
            this.bidOrderbookUnit4.Name = "bidOrderbookUnit4";
            this.bidOrderbookUnit4.Size = new System.Drawing.Size(425, 50);
            this.bidOrderbookUnit4.TabIndex = 4;
            // 
            // bidOrderbookUnit3
            // 
            this.bidOrderbookUnit3.Dock = System.Windows.Forms.DockStyle.Top;
            this.bidOrderbookUnit3.Location = new System.Drawing.Point(0, 150);
            this.bidOrderbookUnit3.Name = "bidOrderbookUnit3";
            this.bidOrderbookUnit3.Size = new System.Drawing.Size(425, 50);
            this.bidOrderbookUnit3.TabIndex = 3;
            // 
            // bidOrderbookUnit2
            // 
            this.bidOrderbookUnit2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bidOrderbookUnit2.Location = new System.Drawing.Point(0, 100);
            this.bidOrderbookUnit2.Name = "bidOrderbookUnit2";
            this.bidOrderbookUnit2.Size = new System.Drawing.Size(425, 50);
            this.bidOrderbookUnit2.TabIndex = 2;
            // 
            // bidOrderbookUnit1
            // 
            this.bidOrderbookUnit1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bidOrderbookUnit1.Location = new System.Drawing.Point(0, 50);
            this.bidOrderbookUnit1.Name = "bidOrderbookUnit1";
            this.bidOrderbookUnit1.Size = new System.Drawing.Size(425, 50);
            this.bidOrderbookUnit1.TabIndex = 1;
            // 
            // bidOrderbookUnit0
            // 
            this.bidOrderbookUnit0.Dock = System.Windows.Forms.DockStyle.Top;
            this.bidOrderbookUnit0.Location = new System.Drawing.Point(0, 0);
            this.bidOrderbookUnit0.Name = "bidOrderbookUnit0";
            this.bidOrderbookUnit0.Size = new System.Drawing.Size(425, 50);
            this.bidOrderbookUnit0.TabIndex = 0;
            // 
            // askOrderbookUnit0
            // 
            this.askOrderbookUnit0.Dock = System.Windows.Forms.DockStyle.Top;
            this.askOrderbookUnit0.Location = new System.Drawing.Point(0, 350);
            this.askOrderbookUnit0.Name = "askOrderbookUnit0";
            this.askOrderbookUnit0.Size = new System.Drawing.Size(425, 50);
            this.askOrderbookUnit0.TabIndex = 7;
            // 
            // askOrderbookUnit1
            // 
            this.askOrderbookUnit1.Dock = System.Windows.Forms.DockStyle.Top;
            this.askOrderbookUnit1.Location = new System.Drawing.Point(0, 300);
            this.askOrderbookUnit1.Name = "askOrderbookUnit1";
            this.askOrderbookUnit1.Size = new System.Drawing.Size(425, 50);
            this.askOrderbookUnit1.TabIndex = 6;
            // 
            // askOrderbookUnit2
            // 
            this.askOrderbookUnit2.Dock = System.Windows.Forms.DockStyle.Top;
            this.askOrderbookUnit2.Location = new System.Drawing.Point(0, 250);
            this.askOrderbookUnit2.Name = "askOrderbookUnit2";
            this.askOrderbookUnit2.Size = new System.Drawing.Size(425, 50);
            this.askOrderbookUnit2.TabIndex = 5;
            // 
            // askOrderbookUnit3
            // 
            this.askOrderbookUnit3.Dock = System.Windows.Forms.DockStyle.Top;
            this.askOrderbookUnit3.Location = new System.Drawing.Point(0, 200);
            this.askOrderbookUnit3.Name = "askOrderbookUnit3";
            this.askOrderbookUnit3.Size = new System.Drawing.Size(425, 50);
            this.askOrderbookUnit3.TabIndex = 4;
            // 
            // askOrderbookUnit4
            // 
            this.askOrderbookUnit4.Dock = System.Windows.Forms.DockStyle.Top;
            this.askOrderbookUnit4.Location = new System.Drawing.Point(0, 150);
            this.askOrderbookUnit4.Name = "askOrderbookUnit4";
            this.askOrderbookUnit4.Size = new System.Drawing.Size(425, 50);
            this.askOrderbookUnit4.TabIndex = 3;
            // 
            // askOrderbookUnit5
            // 
            this.askOrderbookUnit5.Dock = System.Windows.Forms.DockStyle.Top;
            this.askOrderbookUnit5.Location = new System.Drawing.Point(0, 100);
            this.askOrderbookUnit5.Name = "askOrderbookUnit5";
            this.askOrderbookUnit5.Size = new System.Drawing.Size(425, 50);
            this.askOrderbookUnit5.TabIndex = 2;
            // 
            // askOrderbookUnit6
            // 
            this.askOrderbookUnit6.Dock = System.Windows.Forms.DockStyle.Top;
            this.askOrderbookUnit6.Location = new System.Drawing.Point(0, 50);
            this.askOrderbookUnit6.Name = "askOrderbookUnit6";
            this.askOrderbookUnit6.Size = new System.Drawing.Size(425, 50);
            this.askOrderbookUnit6.TabIndex = 1;
            // 
            // askOrderbookUnit7
            // 
            this.askOrderbookUnit7.Dock = System.Windows.Forms.DockStyle.Top;
            this.askOrderbookUnit7.Location = new System.Drawing.Point(0, 0);
            this.askOrderbookUnit7.Name = "askOrderbookUnit7";
            this.askOrderbookUnit7.Size = new System.Drawing.Size(425, 50);
            this.askOrderbookUnit7.TabIndex = 0;
            // 
            // OrderBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1138, 814);
            this.Controls.Add(this.tableLayoutPanel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1154, 853);
            this.MinimumSize = new System.Drawing.Size(1154, 853);
            this.Name = "OrderBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderBook";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel.ResumeLayout(false);
            this.marketPanel.ResumeLayout(false);
            this.marketGridPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.marketGrid)).EndInit();
            this.marketFuntionPanel.ResumeLayout(false);
            this.marketFuntionPanel.PerformLayout();
            this.orderbookPanel.ResumeLayout(false);
            this.bidPanel.ResumeLayout(false);
            this.bidOrderBooksPanel.ResumeLayout(false);
            this.askPanel.ResumeLayout(false);
            this.askOrderBooksPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Panel orderbookPanel;
        private System.Windows.Forms.Panel marketPanel;
        private System.Windows.Forms.Panel marketGridPanel;
        private System.Windows.Forms.DataGridView marketGrid;
        private System.Windows.Forms.Panel marketGridHeaderBorderPanel;
        private System.Windows.Forms.Panel marketFuntionPanel;
        private System.Windows.Forms.Button marketSearchButton;
        private System.Windows.Forms.TextBox searchCoinTextBox;
        private System.Windows.Forms.Label searchCoinLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn marketGrid_CoinCodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marketGrid_CoinNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marketGrid_MarketPriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marketGrid_ChangePriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marketGrid_TradePriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marketGrid_TradePrice_OriginColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marketGrid_ChangeStatusColumn;
        private System.Windows.Forms.Panel bidPanel;
        private System.Windows.Forms.Panel askPanel;
        private System.Windows.Forms.Panel askOrderBooksPanel;
        private AskOrderbookUnit askOrderbookUnit7;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Panel bidOrderBooksPanel;
        private BidOrderbookUnit bidOrderbookUnit7;
        private BidOrderbookUnit bidOrderbookUnit6;
        private BidOrderbookUnit bidOrderbookUnit5;
        private BidOrderbookUnit bidOrderbookUnit4;
        private BidOrderbookUnit bidOrderbookUnit3;
        private BidOrderbookUnit bidOrderbookUnit2;
        private BidOrderbookUnit bidOrderbookUnit1;
        private BidOrderbookUnit bidOrderbookUnit0;
        private System.Windows.Forms.Panel emptyPanel;
        private AskOrderbookUnit askOrderbookUnit0;
        private AskOrderbookUnit askOrderbookUnit1;
        private AskOrderbookUnit askOrderbookUnit2;
        private AskOrderbookUnit askOrderbookUnit3;
        private AskOrderbookUnit askOrderbookUnit4;
        private AskOrderbookUnit askOrderbookUnit5;
        private AskOrderbookUnit askOrderbookUnit6;
        private System.Windows.Forms.Button InvestmentPageButton;
    }
}

