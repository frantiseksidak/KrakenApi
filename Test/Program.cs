/*
Copyright(c) 2016 Markus Trenkwalder

Permission is hereby granted, free of charge, to any person obtaining
a copy of this software and associated documentation files (the
"Software"), to deal in the Software without restriction, including
without limitation the rights to use, copy, modify, merge, publish,
distribute, sublicense, and/or sell copies of the Software, and to
permit persons to whom the Software is furnished to do so, subject to
the following conditions:

The above copyright notice and this permission notice shall be
included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY
CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE
SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/

using KrakenApi;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        private const string krakenKey = "";
        private const string krakenSecret = "";

        private static void Main(string[] args)
        {
            MainAsync(args).GetAwaiter().GetResult();
        }

        private static async Task MainAsync(string[] args)
        {
            Kraken kraken = new Kraken(krakenKey, krakenSecret, 2500);
            var time = await kraken.GetServerTimeAsync();
            //var assets = await kraken.GetAssetInfoAsync();
            //var assets = await kraken.GetAssetPairsAsync();
            //var ticker = await kraken.GetTickerAsync("XXBTZEUR");
            //var ohlc = await kraken.GetOHLCAsync("XXBTZEUR", 1440);
            //var orderbook = await kraken.GetOrderBookAsync("XXBTZEUR");
            //var trades = await kraken.GetRecentTradesAsync("XXBTZEUR");
            //var spread = await kraken.GetRecentSpreadAsync("XXBTZEUR");
            //var accountBalance = await kraken.GetAccountBalanceAsync();
            //var tradeBalance = await kraken.GetTradeBalanceAsync();
            //var openOrders = await kraken.GetOpenOrdersAsync();
            //var closedOrders = await kraken.GetClosedOrdersAsync();
            //var orders = await kraken.QueryOrdersAsync(new string[] { "x" });
            //var trades = await kraken.GetTradesHistoryAsync();
            //var openPositions = await kraken.GetOpenPositionsAsync(new string[] { "x" });
            //var ledgers = await kraken.GetLedgersAsync();
            //var volume = await kraken.GetTradeVolumeAsync(new string[] { "XXBTZEUR", "XXBTZUSD" }, true);

            //var order = new KrakenOrder();
            //order.Pair = "XXBTZEUR";
            //order.Type = "buy";
            //order.OrderType = "market";
            //order.Volume = 0.01m;
            //order.Validate = true;
            //var result = await kraken.AddOrderAsync(order);

            //var depositMethods = await kraken.GetDepositMethodsAsync(asset: "ZEUR");
            //var depositStatus = await kraken.GetDepositStatusAsync("ZEUR", "Fidor Bank AG (SEPA)");
        }
    }
}