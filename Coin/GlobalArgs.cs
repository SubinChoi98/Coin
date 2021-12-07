using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coin
{
    public class GlobalArgs
    {
        // 색상
        public static Color NormalColor = Color.FromArgb(24, 24, 24);
        public static Color ProfitColor = Color.LightCoral;
        public static Color LossColor = Color.FromArgb(84, 162, 223);

        /// <summary>
        /// 문자열로 구성된 금액값에 3자리 콤마를 적용합니다.
        /// </summary>
        /// <param name="val">금액</param>
        /// <param name="decimals">[선택적 인자] 표현할 소수점 자릿수</param>
        /// <returns>3자리 콤마 포멧이 적용된 문자 값</returns>
        public static string GetComma(decimal val, int decimals = 0)
        {
            string valString = Convert.ToString(val);

            if (string.IsNullOrEmpty(valString))
            {
                return valString;
            }

            try
            {
                string[] valArray = valString.Split('.');

                if (valArray.Length == 2)
                {
                    if (string.IsNullOrEmpty(valArray[1]) || long.Parse(valArray[1]) == 0)
                    {
                        if (decimals > 0)
                        {
                            return $"{long.Parse(valArray[0]):#,##0}.{string.Empty.PadRight(decimals, '0')}";
                        }
                        else
                        {
                            return $"{long.Parse(valArray[0]):#,##0}";
                        }
                    }
                    else
                    {
                        return $"{(valArray[0].StartsWith("-") ? "-" : "")}{Math.Abs(long.Parse(valArray[0])):#,##0}.{valArray[1].PadRight(decimals, '0')}";
                    }
                }
                else if (valArray.Length == 1)
                {
                    if (decimals > 0)
                    {
                        return $"{long.Parse(valArray[0]):#,##0}.{string.Empty.PadRight(decimals, '0')}";
                    }
                    else
                    {
                        return $"{long.Parse(valArray[0]):#,##0}";
                    }
                }
                else
                {
                    return valString;
                }
            }
            catch
            {
                return valString;
            }
        }

        /// <summary>
        /// 화면에 표시할 금액 값입니다.
        /// </summary>
        /// <param name="val">금액 값</param>
        /// <param name="decimals">[선택적 인자] 표현할 소수점 자릿수</param>
        /// <param name="isCeiling">[선택적 인자] 올림처리 여부</param>
        /// <returns>3자리 콤마 포멧이 적용된 문자 값</returns>
        public static string GetDisplayAmount(decimal val, int decimals = 2, bool isCeiling = false)
        {
            if (decimals >= 0)
            {
                // 절대값 기준 0.xx 대 금액은 파라미터 값과 관계없이 소수점 4자리까지 표현
                if ((val > -0.001M && val < 0M) || (val < 0.001M && val > 0M))
                {
                    decimals = 4;
                }

                // 금액 조정
                decimal precision = Convert.ToDecimal(Math.Pow(10.0, decimals));

                if (!isCeiling)
                {
                    if (val > 0M)
                    {
                        // 양수: 지정한 소수점 이하 버림 처리
                        val = decimal.Divide(decimal.Truncate(decimal.Multiply(val, precision)), precision);
                    }
                    else if (val < 0M)
                    {
                        // 음수: 지정한 소수점 이하 올림 처리
                        val = decimal.Divide(decimal.Floor(decimal.Multiply(val, precision)), precision);
                    }
                }
                else
                {
                    val = decimal.Divide(decimal.Ceiling(decimal.Multiply(val, precision)), precision);
                }
            }

            return GetComma(val, decimals < 0 ? 0 : decimals);
        }

    }
}
