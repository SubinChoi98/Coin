using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using System.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Web;

namespace Coin.Library
{
    public class UpbitAPIWithSocket
    {
        public MyHttpClient httpClient;
        public UpbitAPIWithSocket(string accessKey, string secretKey)
        {
            this.httpClient = new MyHttpClient(accessKey, secretKey);
        }

        public class MyHttpClient : HttpClient
        {
            private string _accessKey;
            public string AccessKey
            {
                get { return _accessKey; }
                set { _accessKey = value; }
            }
            private string _secretKey;
            public string SecretKey
            {
                get { return _secretKey; }
                set { _secretKey = value; }
            }
            public MyHttpClient(string accessKey, string secretKey)
            {
                if (string.IsNullOrWhiteSpace(accessKey)) { throw new ArgumentNullException("accessKey"); }
                if (string.IsNullOrWhiteSpace(secretKey)) { throw new ArgumentNullException("secretKey"); }
                _accessKey = accessKey;
                _secretKey = secretKey;
            }
        }

        public string GetApiKey()
        {
            string url = "https://api.upbit.com/v1/api_keys";
            return CallAPI_NoParam(url, HttpMethod.Get);
        }

        public string GetAccount()
        {
            string url = "https://api.upbit.com/v1/accounts";
            return CallAPI_NoParam(url, HttpMethod.Get);
        }
        public string GetTicker(string markets)
        {
            string url = "https://api.upbit.com/v1/ticker";
            return CallAPI_WithParam(url, new NameValueCollection { { "markets", markets } }, HttpMethod.Get);
        }
        public string GetMarkets()
        {
            string url = "https://api.upbit.com/v1/market/all";
            return CallAPI_NoParam(url, HttpMethod.Get);
        }
        public string GetAllOrder()
        {
            string url = "https://api.upbit.com/v1/orders";
            return CallAPI_NoParam(url, HttpMethod.Get);
        }
        public string GetOrder(string uuid)
        {
            string url = "https://api.upbit.com/v1/order";
            return CallAPI_WithParam(url, new NameValueCollection { { "uuid", uuid } }, HttpMethod.Get);
        }
        //public string MakeOrder(string market, UpbitOrderSide side, decimal volume, decimal price, UpbitOrderType ord_type = UpbitOrderType.limit)
        public string MakeOrder(string market, string side, decimal volume, decimal price, string ord_type)
        {
            string url = "https://api.upbit.com/v1/orders";
            if (price == 0.0M)
            {
                return CallAPI_WithParam(url, new NameValueCollection { { "market", market }, { "side", side }, { "volume", volume.ToString() }, { "ord_type", ord_type } }, HttpMethod.Post);
            }
            else
            {
                //return CallAPI_WithParam(url, new NameValueCollection { { "market", market }, { "side", side.ToString() }, { "volume", volume.ToString() }, { "price", price.ToString() }, { "ord_type", ord_type.ToString() } }, HttpMethod.Post);
                return CallAPI_WithParam(url, new NameValueCollection { { "market", market }, { "side", side }, { "volume", volume.ToString() }, { "price", price.ToString() }, { "ord_type", ord_type } }, HttpMethod.Post);
            }
        }
        public string CancelOrder(string uuid)
        {
            string url = "https://api.upbit.com/v1/order";
            return CallAPI_WithParam(url, new NameValueCollection { { "uuid", uuid } }, HttpMethod.Delete);
        }
        public string GetOrderbook(string markets)
        {
            string url = "https://api.upbit.com/v1/orderbook";
            return CallAPI_WithParam(url, new NameValueCollection { { "markets", markets } }, HttpMethod.Get);
        }
        public string GetOrderChance(string market)
        {
            string url = "https://api.upbit.com/v1/orders/chance";
            return CallAPI_WithParam(url, new NameValueCollection { { "market", market } }, HttpMethod.Get);
        }

        public string GetCandles_Minute(string market, UpbitMinuteCandleType unit, DateTime to = default(DateTime), int count = 1)
        {
            string url = "https://api.upbit.com/v1/candles/minutes/" + (int)unit;
            return CallAPI_WithParam(url, new NameValueCollection { { "market", market }, { "to", (to == default(DateTime)) ? DateTime2String(DateTime.Now) : DateTime2String(to) }, { "count", count.ToString() } }, HttpMethod.Get);
        }
        public string GetCandles_Day(string market, DateTime to = default(DateTime), int count = 1)
        {
            string url = "https://api.upbit.com/v1/candles/days";
            return CallAPI_WithParam(url, new NameValueCollection { { "market", market }, { "to", (to == default(DateTime)) ? DateTime2String(DateTime.Now) : DateTime2String(to) }, { "count", count.ToString() } }, HttpMethod.Get);
        }
        public string GetCandles_Week(string market, DateTime to = default(DateTime), int count = 1)
        {
            string url = "https://api.upbit.com/v1/candles/weeks";
            return CallAPI_WithParam(url, new NameValueCollection { { "market", market }, { "to", (to == default(DateTime)) ? DateTime2String(DateTime.Now) : DateTime2String(to) }, { "count", count.ToString() } }, HttpMethod.Get);
        }
        public string GetCandles_Month(string market, DateTime to = default(DateTime), int count = 1)
        {
            string url = "https://api.upbit.com/v1/candles/months";
            return CallAPI_WithParam(url, new NameValueCollection { { "market", market }, { "to", (to == default(DateTime)) ? DateTime2String(DateTime.Now) : DateTime2String(to) }, { "count", count.ToString() } }, HttpMethod.Get);
        }
        public string GetTicks(string market, int count = 1)
        {
            string url = "https://api.upbit.com/v1/trades/ticks";
            return CallAPI_WithParam(url, new NameValueCollection { { "market", market }, { "count", count.ToString() } }, HttpMethod.Get);
        }

        private string CallAPI_NoParam(string url, HttpMethod httpMethod)
        {
            var requestMessage = new HttpRequestMessage(httpMethod, new Uri(url));
            requestMessage.Headers.Authorization = new AuthenticationHeaderValue("Bearer", JWT_NoParameter());

            //var response = httpClient.SendAsync(requestMessage).Result;
            //var contents = response.Content.ReadAsStringAsync().Result;
            //return contents;
            try
            {
                var response = httpClient.SendAsync(requestMessage).Result;
                var contents = response.Content.ReadAsStringAsync().Result;
                return contents;
            }
            catch (HttpRequestException exception)
            {
                //HttpRequestException when calling the API
                Thread.Sleep(10000);  //  10초 대기
                return "";
            }
            catch (Exception exception)
            {
                //Unhandled exception when calling the API
                // Here it's up to you if you want to throw or return Retry/Fail, im choosing to FAIL.
                Thread.Sleep(10000);  // 10초 대기
                return ""; ;
            }


        }
        private string CallAPI_WithParam(string url, NameValueCollection nvc, HttpMethod httpMethod)
        {
            var requestMessage = new HttpRequestMessage(httpMethod, new Uri(url + "?" + ToQueryString(nvc, true)));
            requestMessage.Headers.Authorization = new AuthenticationHeaderValue("Bearer", JWT_WithParameter(nvc));

            //var response = httpClient.SendAsync(requestMessage).Result;
            //var contents = response.Content.ReadAsStringAsync().Result;
            //return contents;
            try
            {
                var response = httpClient.SendAsync(requestMessage).Result;
                var contents = response.Content.ReadAsStringAsync().Result;
                return contents;
            }
            catch (HttpRequestException exception)
            {
                //HttpRequestException when calling the API
                Thread.Sleep(10000);  //  10초 대기
                return "";
            }
            catch (Exception exception)
            {
                //Unhandled exception when calling the API
                // Here it's up to you if you want to throw or return Retry/Fail, im choosing to FAIL.
                Thread.Sleep(10000);  //  10초 대기
                return "";
            }
        }

        private string JWT_NoParameter()
        {
            //TimeSpan diff = DateTime.Now - new DateTime(1970, 1, 1);
            var nonce = Guid.NewGuid().ToString();//Convert.ToInt64(diff.TotalMilliseconds);
            var payload = new JwtPayload { { "access_key", httpClient.AccessKey }, { "nonce", nonce } };
            byte[] keyBytes = Encoding.Default.GetBytes(httpClient.SecretKey);
            var securityKey = new Microsoft.IdentityModel.Tokens.SymmetricSecurityKey(keyBytes);
            var credentials = new Microsoft.IdentityModel.Tokens.SigningCredentials(securityKey, "HS256");
            var header = new JwtHeader(credentials);
            var secToken = new JwtSecurityToken(header, payload);

            var jwtToken = new JwtSecurityTokenHandler().WriteToken(secToken);
            var authorizationToken = jwtToken;
            return authorizationToken;
        }
        private string JWT_WithParameter(NameValueCollection nvc)
        {
            //TimeSpan diff = DateTime.Now - new DateTime(1970, 1, 1);
            var nonce = Guid.NewGuid().ToString();//Convert.ToInt64(diff.TotalMilliseconds);

            string queryString = ToQueryString(nvc, false);
            var payload = new JwtPayload { { "access_key", httpClient.AccessKey }, { "nonce", nonce }, { "query", queryString } };
            byte[] keyBytes = Encoding.Default.GetBytes(httpClient.SecretKey);
            var securityKey = new Microsoft.IdentityModel.Tokens.SymmetricSecurityKey(keyBytes);
            var credentials = new Microsoft.IdentityModel.Tokens.SigningCredentials(securityKey, "HS256");
            var header = new JwtHeader(credentials);
            var secToken = new JwtSecurityToken(header, payload);

            var jwtToken = new JwtSecurityTokenHandler().WriteToken(secToken);
            var authorizationToken = jwtToken;
            return authorizationToken;
        }
        private string ToQueryString(NameValueCollection nvc, bool isURI)
        {
            var array = (from key in nvc.AllKeys
                         from value in nvc.GetValues(key)
                         select string.Format("{0}={1}", (isURI) ? HttpUtility.UrlEncode(key) : key, (isURI) ? HttpUtility.UrlEncode(value) : value))
                .ToArray();

            return string.Join("&", array);
        }
        private string DateTime2String(DateTime to)
        {
            return to.ToString("s") + "+09:00";
        }
        public enum UpbitMinuteCandleType { _1 = 1, _3 = 3, _5 = 5, _10 = 10, _15 = 15, _30 = 30, _60 = 60, _240 = 240 }
        public enum UpbitOrderSide { ask, bid }
        public enum UpbitOrderType { limit }
    }
}
