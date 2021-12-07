using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebSocketSharp;
using Coin.Entity;
using Coin.Library;
using System.Globalization;

namespace Coin
{
    public partial class OrderBookForm : Form
    {
        // 업비트 API access key
        private string apiAccessKey = "";
        private string apiSecretKey = "";

        // 그리드 데이터 테이블
        private DataTable marketTable;

        // 데이터 소스
        private List<Market> marketsCol;

        // 호가 창
        Dictionary<int, AskOrderbookUnit> askControls;
        Dictionary<int, BidOrderbookUnit> bidControls;

        public OrderBookForm(string _apiAccessKey, string _apiSecretKey)
        {
            apiAccessKey = _apiAccessKey;
            apiSecretKey = _apiSecretKey;
            InitializeComponent();

            // 패널 그림자
            tableLayoutPanel.Paint += ShadowPanel.Draw;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                marketsCol = new List<Market>();
                askControls = new Dictionary<int, AskOrderbookUnit>();
                bidControls = new Dictionary<int, BidOrderbookUnit>();

                askControls.Add(0, askOrderbookUnit0);
                askControls.Add(1, askOrderbookUnit1);
                askControls.Add(2, askOrderbookUnit2);
                askControls.Add(3, askOrderbookUnit3);
                askControls.Add(4, askOrderbookUnit4);
                askControls.Add(5, askOrderbookUnit5);
                askControls.Add(6, askOrderbookUnit6);
                askControls.Add(7, askOrderbookUnit7);

                bidControls.Add(0, bidOrderbookUnit0);
                bidControls.Add(1, bidOrderbookUnit1);
                bidControls.Add(2, bidOrderbookUnit2);
                bidControls.Add(3, bidOrderbookUnit3);
                bidControls.Add(4, bidOrderbookUnit4);
                bidControls.Add(5, bidOrderbookUnit5);
                bidControls.Add(6, bidOrderbookUnit6);
                bidControls.Add(7, bidOrderbookUnit7);

                // 데이터 테이블 초기화
                SetCoinDataTable();

                // 초기 코인 목록 조회
                GetCoins();

                // 목록 갱신
                ApplyTradeSetInfo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region 컨트롤 이벤트

        /// <summary>
        /// 코인 목록을 새로 가져옵니다.
        /// </summary>
        private void marketSearchButton_Click(object sender, EventArgs e)
        {
            // 코인 목록 조회
            GetCoins();

            // 목록 갱신
            ApplyTradeSetInfo();
        }

        /// <summary>
        /// 그리드의 데이터가 바인딩 완료되면 손익에 따라 색상을 변경합니다.
        /// </summary>
        private void marketGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // 상태에 따른 색상 변경
            PaintingRowStatus(sender as DataGridView);
            marketGrid.ClearSelection();
        }

        /// <summary>
        /// 코인을 검색할 때 그리드 목록을 필터합니다.
        /// </summary>
        private void searchCoinTextBox_TextChanged(object sender, EventArgs e)
        {
            marketTable.DefaultView.RowFilter = $"1 = 1 AND (CoinName LIKE '%{searchCoinTextBox.Text}%' OR CoinCode LIKE '%{searchCoinTextBox.Text}%')";

            marketGrid.ClearSelection();
        }

        /// <summary>
        /// 코인을 선택하면 호가(Orderbook)값을 가져와 뿌려줍니다.
        /// </summary>
        private void marketGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            try
            {
                SuspendLayout();

                UpbitAPIWithSocket upbitAPI = new UpbitAPIWithSocket(apiAccessKey, apiSecretKey);
                string orderbookResponse = upbitAPI.GetOrderbook(Convert.ToString(marketGrid.Rows[e.RowIndex].Cells["marketGrid_CoinCodeColumn"].Value));

                JArray jArray = JArray.Parse(orderbookResponse);
                JObject jObject = JObject.FromObject(jArray[0]);

                Market market = marketsCol.Where(w => w.CoinCode == jObject["market"].ToString()).FirstOrDefault();

                for (int i = 0; i < jObject["orderbook_units"].Count(); i++)
                {
                    if (i < askControls.Count)
                    {
                        askControls[i].SetData(market.PrevClosingPrice, Convert.ToDecimal(jObject["orderbook_units"][i]["ask_price"].ToString()), Convert.ToDecimal(double.Parse(jObject["orderbook_units"][i]["ask_size"].ToString(), CultureInfo.InvariantCulture)));
                        bidControls[i].SetData(market.PrevClosingPrice, Convert.ToDecimal(jObject["orderbook_units"][i]["bid_price"].ToString()), Convert.ToDecimal(double.Parse(jObject["orderbook_units"][i]["bid_size"].ToString(), CultureInfo.InvariantCulture)));
                    }
                }

                ResumeLayout(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region 데이터 테이블 초기화 및 설정

        /// <summary>
        /// 코인 데이터 테이블을 초기화합니다.
        /// </summary>
        private void SetCoinDataTable()
        {
            marketTable = new DataTable();
            marketTable.Columns.Add("CoinCode", Type.GetType("System.String"));
            marketTable.Columns.Add("CoinName", Type.GetType("System.String"));
            marketTable.Columns.Add("MarketPrice", Type.GetType("System.String"));
            marketTable.Columns.Add("ChangePrice", Type.GetType("System.String"));
            marketTable.Columns.Add("TradePrice", Type.GetType("System.String"));
            marketTable.Columns.Add("TradePrice_Origin", Type.GetType("System.Decimal"));
            marketTable.Columns.Add("ChangeStatus", Type.GetType("System.String"));

            marketTable.DefaultView.Sort = "TradePrice_Origin DESC";
            marketGrid.DataSource = marketTable.DefaultView;
            marketGrid.CurrentCell = null;
            marketGrid.FirstDisplayedCell = null;
        }

        /// <summary>
        /// 트레이드 셋 값을 반영합니다.
        /// </summary>
        private void ApplyTradeSetInfo()
        {
            if (marketsCol == null || marketsCol.Count == 0)
            {
                marketTable.Rows.Clear();
            }
            else
            {
                foreach (var item in marketsCol)
                {
                    DataRow row = marketTable.AsEnumerable()
                                    .Where(w => w.Field<string>("CoinCode") == item.CoinCode)
                                    .FirstOrDefault();

                    if (row == null)
                    {
                        row = marketTable.NewRow();
                        row["CoinCode"] = item.CoinCode;

                        marketTable.Rows.Add(row);
                    }

                    row["CoinName"] = $"{item.CoinName}({item.SimbolCode})";

                    if (item.MarketPrice < 1M)
                    {
                        row["MarketPrice"] = GlobalArgs.GetDisplayAmount(item.MarketPrice, 4);
                    }
                    else if (item.MarketPrice < 100M)
                    {
                        row["MarketPrice"] = GlobalArgs.GetDisplayAmount(item.MarketPrice, 2);
                    }
                    else
                    {
                        row["MarketPrice"] = GlobalArgs.GetDisplayAmount(item.MarketPrice, 0);
                    }

                    if (item.MarketPrice < 1M)
                    {
                        row["ChangePrice"] = $"{GlobalArgs.GetDisplayAmount(item.ChangePrice, 4)}({GlobalArgs.GetDisplayAmount(item.ChangeRate, 2)}%)";
                    }
                    else if (item.MarketPrice < 100M)
                    {
                        row["ChangePrice"] = $"{GlobalArgs.GetDisplayAmount(item.ChangePrice, 2)}({GlobalArgs.GetDisplayAmount(item.ChangeRate, 2)}%)";
                    }
                    else
                    {
                        row["ChangePrice"] = $"{GlobalArgs.GetDisplayAmount(item.ChangePrice, 0)}({GlobalArgs.GetDisplayAmount(item.ChangeRate, 2)}%)";
                    }

                    row["TradePrice"] = $"{GlobalArgs.GetDisplayAmount(decimal.Round(decimal.Divide(item.TradePrice, 1000000M)), 0)}백만";
                    row["TradePrice_Origin"] = item.TradePrice;
                    row["ChangeStatus"] = item.ChangeStatus;
                }
            }
        }

        #endregion

        #region API Action

        /// <summary>
        /// 코인 목록을 새로 가져옵니다.
        /// </summary>
        private void GetCoins()
        {
            try
            {
                UpbitAPIWithSocket upbitAPI = new UpbitAPIWithSocket(apiAccessKey, apiSecretKey);

                // 마켓 코드 조회
                if (marketsCol.Count == 0)
                {
                    JArray marketsResponse = JArray.Parse(upbitAPI.GetMarkets());

                    foreach (JObject response in marketsResponse)
                    {
                        if (response["market"].ToString().StartsWith("KRW-"))
                        {
                            Market market = new Market()
                            {
                                CoinCode = response["market"].ToString(),
                                SimbolCode = response["market"].ToString().Replace("KRW-", ""),
                                CoinName = response["korean_name"].ToString()
                            };

                            marketsCol.Add(market);
                        }
                    }
                }

                // 현재가 정보
                JArray tickersResponse = JArray.Parse(upbitAPI.GetTicker(string.Join(",", marketsCol.Select(s => s.CoinCode))));

                foreach (JObject response in tickersResponse)
                {
                    Market market = marketsCol.Where(w => w.CoinCode == response["market"].ToString()).FirstOrDefault();

                    if (market != null)
                    {
                        market.MarketPrice = Convert.ToDecimal(response["trade_price"].ToString());
                        market.ChangePrice = Convert.ToDecimal(response["signed_change_price"].ToString());
                        market.ChangeRate = decimal.Multiply(Convert.ToDecimal(response["signed_change_rate"].ToString()), 100M);
                        market.TradePrice = Convert.ToDecimal(response["acc_trade_price_24h"].ToString());
                        market.ChangeStatus = response["change"].ToString();
                        market.PrevClosingPrice = Convert.ToDecimal(response["prev_closing_price"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Function

        /// <summary>
        /// 데이터 값에 따라 내용의 전경색을 변경합니다.
        /// <param name="grid">대상 그리드 뷰 컨트롤 인스턴스</param>
        /// </summary>
        private void PaintingRowStatus(DataGridView grid)
        {
            string columnName1 = "marketGrid_MarketPriceColumn";
            string columnName2 = "marketGrid_ChangePriceColumn";

            foreach (DataGridViewRow row in grid.Rows)
            {
                // 수익금에 따른 색 변경
                if (Convert.ToString(row.Cells["marketGrid_ChangeStatusColumn"].Value) == "FALL")
                {
                    row.Cells[columnName1].Style.ForeColor = GlobalArgs.LossColor;
                    row.Cells[columnName2].Style.ForeColor = GlobalArgs.LossColor;
                    row.Cells[columnName1].Style.SelectionForeColor = GlobalArgs.LossColor;
                    row.Cells[columnName2].Style.SelectionForeColor = GlobalArgs.LossColor;
                }
                else if (Convert.ToString(row.Cells["marketGrid_ChangeStatusColumn"].Value) == "RISE")
                {
                    row.Cells[columnName1].Style.ForeColor = GlobalArgs.ProfitColor;
                    row.Cells[columnName2].Style.ForeColor = GlobalArgs.ProfitColor;
                    row.Cells[columnName1].Style.SelectionForeColor = GlobalArgs.ProfitColor;
                    row.Cells[columnName2].Style.SelectionForeColor = GlobalArgs.ProfitColor;
                }
                else
                {
                    row.Cells[columnName1].Style.ForeColor = GlobalArgs.NormalColor;
                    row.Cells[columnName2].Style.ForeColor = GlobalArgs.NormalColor;
                    row.Cells[columnName1].Style.SelectionForeColor = GlobalArgs.NormalColor;
                    row.Cells[columnName2].Style.SelectionForeColor = GlobalArgs.NormalColor;
                }
            }
        }

        #endregion

        private void InvestmentPageButton_Click(object sender, EventArgs e)
        {
            new MyCoin(apiAccessKey, apiSecretKey).ShowDialog();
        }
    }
}
