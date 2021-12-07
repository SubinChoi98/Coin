using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coin.Entity
{
    public class Market
    {
        /// <summary>
        /// 코인 코드
        /// </summary>
        public string CoinCode { get; set; }

        /// <summary>
        /// 코인 코드(약어)
        /// </summary>
        public string SimbolCode { get; set; }

        /// <summary>
        /// 코인명
        /// </summary>
        public string CoinName { get; set; }

        /// <summary>
        /// 현재가
        /// </summary>
        public decimal MarketPrice { get; set; }

        /// <summary>
        /// 전일대비
        /// </summary>
        public decimal ChangePrice { get; set; }

        /// <summary>
        /// 전일대비(%)
        /// </summary>
        public decimal ChangeRate { get; set; }

        /// <summary>
        /// 거래대금
        /// </summary>
        public decimal TradePrice { get; set; }

        /// <summary>
        /// 보합(EVEN), 상승(RISE), 하락(FALL) 값
        /// </summary>
        public string ChangeStatus { get; set; }

        /// <summary>
        /// 전일 종가
        /// </summary>
        public decimal PrevClosingPrice { get; set; }
    }
}
