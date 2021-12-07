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
    public partial class BidOrderbookUnit : UserControl
    {
        public BidOrderbookUnit()
        {
            InitializeComponent();
        }

        public void SetData(decimal prevClosingPrice, decimal price, decimal size)
        {
            bidVolumeLabel.Text = GlobalArgs.GetDisplayAmount(size, 3);

            if (price < 1M)
            {
                bidPriceLabel.Text = GlobalArgs.GetDisplayAmount(price, 4);
            }
            else if (price < 100M)
            {
                bidPriceLabel.Text = GlobalArgs.GetDisplayAmount(price, 2);
            }
            else
            {
                bidPriceLabel.Text = GlobalArgs.GetDisplayAmount(price, 0);
            }

            decimal rate = decimal.Multiply(decimal.Divide(decimal.Subtract(price, prevClosingPrice), prevClosingPrice), 100M);

            if (rate > 0M)
            {
                bidRateLabel.Text = $"+{GlobalArgs.GetDisplayAmount(rate, 2)}%";

                bidPriceLabel.ForeColor = GlobalArgs.ProfitColor;
                bidRateLabel.ForeColor = GlobalArgs.ProfitColor;
            }
            else if (rate < 0M)
            {
                bidRateLabel.Text = $"{GlobalArgs.GetDisplayAmount(rate, 2)}%";

                bidPriceLabel.ForeColor = GlobalArgs.LossColor;
                bidRateLabel.ForeColor = GlobalArgs.LossColor;
            }
            else
            {
                bidRateLabel.Text = $"{GlobalArgs.GetDisplayAmount(rate, 2)}%";

                bidPriceLabel.ForeColor = GlobalArgs.NormalColor;
                bidRateLabel.ForeColor = GlobalArgs.NormalColor;
            }
        }
    }
}
