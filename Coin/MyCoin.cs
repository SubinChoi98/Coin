using Coin.Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coin
{
    internal partial class MyCoin : Form
    {
        private string apiAccessKey = "";
        private string apiSecretKey = "";

        public MyCoin(string _apiAccessKey, string _apiSecretKey)
        {
            apiAccessKey = _apiAccessKey;
            apiSecretKey = _apiSecretKey;
            InitializeComponent();

            GetUpbitAccount();

            tableLayoutPanel1.Paint += ShadowPanel.Draw;
        }

        private List<UpbitAPI.Accounts> Accounts { get; set; }
        private void GetUpbitAccount()
        {
            UpbitAPISample MyUpbit = new UpbitAPISample(apiAccessKey, apiSecretKey);
            var accountResponse = MyUpbit.GetAccounts();
            Accounts = new List<UpbitAPI.Accounts>();
            DataTable table = new DataTable();

            table.Columns.Add("currency", typeof(string));
            table.Columns.Add("balance", typeof(string));
            table.Columns.Add("locked", typeof(string));
            table.Columns.Add("avg_buy_price", typeof(string));
            table.Columns.Add("avg_buy_price_modified", typeof(bool));
            table.Columns.Add("unit_currency", typeof(string));

            dataGridView1.DataSource = table;
            foreach (UpbitAPI.Accounts.Response accounts in accountResponse)
            {
                DataRow row = table.NewRow();
                row["currency"] = accounts.currency;
                row["balance"] = accounts.balance;
                row["locked"] = accounts.locked;
                row["avg_buy_price"] = accounts.avg_buy_price;
                row["avg_buy_price_modified"] = accounts.avg_buy_price_modified;
                row["unit_currency"] = accounts.unit_currency;

                table.Rows.Add(row);
            }
            

        }

    }
}
