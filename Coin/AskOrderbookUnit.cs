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
    public partial class AskOrderbookUnit : UserControl
    {
        public AskOrderbookUnit()
        {
            InitializeComponent();
        }

        public void SetData(decimal prevClosingPrice, decimal price, decimal size)
        {
            askVolumeLabel.Text = GlobalArgs.GetDisplayAmount(size, 3);

            if (price < 1M)
            {
                askPriceLabel.Text = GlobalArgs.GetDisplayAmount(price, 4);
            }
            else if (price < 100M)
            {
                askPriceLabel.Text = GlobalArgs.GetDisplayAmount(price, 2);
            }
            else
            {
                askPriceLabel.Text = GlobalArgs.GetDisplayAmount(price, 0);
            }

            decimal rate = decimal.Multiply(decimal.Divide(decimal.Subtract(price, prevClosingPrice), prevClosingPrice), 100M);

            if (rate > 0M)
            {
                askRateLabel.Text = $"+{GlobalArgs.GetDisplayAmount(rate, 2)}%";

                askPriceLabel.ForeColor = GlobalArgs.ProfitColor;
                askRateLabel.ForeColor = GlobalArgs.ProfitColor;
            }
            else if (rate < 0M)
            {
                askRateLabel.Text = $"{GlobalArgs.GetDisplayAmount(rate, 2)}%";

                askPriceLabel.ForeColor = GlobalArgs.LossColor;
                askRateLabel.ForeColor = GlobalArgs.LossColor;
            }
            else
            {
                askRateLabel.Text = $"{GlobalArgs.GetDisplayAmount(rate, 2)}%";

                askPriceLabel.ForeColor = GlobalArgs.NormalColor;
                askRateLabel.ForeColor = GlobalArgs.NormalColor;
            }
        }
    }
}
