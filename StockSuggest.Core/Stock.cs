using System.Collections.Generic;
using System;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace StockSuggest.Core
{
	public class Stock
	{
		public string symbol { get; set; }
		public string AverageDailyVolume { get; set; }
		public string Change { get; set; }
		public string DaysLow { get; set; }
		public string DaysHigh { get; set; }
		public string YearLow { get; set; }
		public string YearHigh { get; set; }
		public string MarketCapitalization { get; set; }
		public string LastTradePriceOnly { get; set; }
		public string DaysRange { get; set; }
		public string Name { get; set; }
		public string Symbol { get; set; }
		public string Volume { get; set; }
		public string StockExchange { get; set; }
	}

	public class Results
	{
		public List<Stock> quote { get; set; }
	}

	public class Query
	{
		public int count { get; set; }
		public string created { get; set; }
		public string lang { get; set; }
		public Results results { get; set; }
	}

	public class StockQuote
	{
		public Query query { get; set; }
	}

	public class Stocks
	{
		public static List<Stock> GetStocks()
		{
			List<Stock> stocks = new List<Stock> ();
			stocks.Add (new Stock () { Name = "Yahoo Inc.", LastTradePriceOnly = "38.6999", Change = "-0.9601", symbol ="YHOO", StockExchange = "Nasdaq" });
			stocks.Add (new Stock () { Name = "Apple Inc.", LastTradePriceOnly = "8.6999", Change = "-3.9601", symbol ="AAPL", StockExchange = "New York" });
			stocks.Add (new Stock () { Name = "Company Inc.", LastTradePriceOnly = "1080.6999", Change = "+100.1601", symbol ="CTEL", StockExchange = "Nasdaq" });
			stocks.Add (new Stock () { Name = "Google Inc.", LastTradePriceOnly = "3.6999", Change = "+1.9601", symbol ="GOOG", StockExchange = "Nasdaq" });
			stocks.Add (new Stock () { Name = "Yahoo Inc.", LastTradePriceOnly = "38.6999", Change = "-0.9601", symbol ="YHOO", StockExchange = "Nasdaq" });
			stocks.Add (new Stock () { Name = "Apple Inc.", LastTradePriceOnly = "8.6999", Change = "-3.9601", symbol ="AAPL", StockExchange = "New York" });
			stocks.Add (new Stock () { Name = "Company Inc.", LastTradePriceOnly = "1080.6999", Change = "+100.1601", symbol ="CTEL", StockExchange = "Nasdaq" });
			stocks.Add (new Stock () { Name = "Google Inc.", LastTradePriceOnly = "3.6999", Change = "+1.9601", symbol ="GOOG", StockExchange = "Nasdaq" });
			stocks.Add (new Stock () { Name = "Yahoo Inc.", LastTradePriceOnly = "38.6999", Change = "-0.9601", symbol ="YHOO", StockExchange = "Nasdaq" });
			stocks.Add (new Stock () { Name = "Apple Inc.", LastTradePriceOnly = "8.6999", Change = "-3.9601", symbol ="AAPL", StockExchange = "New York" });
			stocks.Add (new Stock () { Name = "Company Inc.", LastTradePriceOnly = "1080.6999", Change = "+100.1601", symbol ="CTEL", StockExchange = "Nasdaq" });
			stocks.Add (new Stock () { Name = "Google Inc.", LastTradePriceOnly = "3.6999", Change = "+1.9601", symbol ="GOOG", StockExchange = "Nasdaq" });
			stocks.Add (new Stock () { Name = "Yahoo Inc.", LastTradePriceOnly = "38.6999", Change = "-0.9601", symbol ="YHOO", StockExchange = "Nasdaq" });
			stocks.Add (new Stock () { Name = "Apple Inc.", LastTradePriceOnly = "8.6999", Change = "-3.9601", symbol ="AAPL", StockExchange = "New York" });
			stocks.Add (new Stock () { Name = "Company Inc.", LastTradePriceOnly = "1080.6999", Change = "+100.1601", symbol ="CTEL", StockExchange = "Nasdaq" });
			stocks.Add (new Stock () { Name = "Google Inc.", LastTradePriceOnly = "3.6999", Change = "+1.9601", symbol ="GOOG", StockExchange = "Nasdaq" });
			stocks.Add (new Stock () { Name = "Yahoo Inc.", LastTradePriceOnly = "38.6999", Change = "-0.9601", symbol ="YHOO", StockExchange = "Nasdaq" });
			stocks.Add (new Stock () { Name = "Apple Inc.", LastTradePriceOnly = "8.6999", Change = "-3.9601", symbol ="AAPL", StockExchange = "New York" });
			stocks.Add (new Stock () { Name = "Company Inc.", LastTradePriceOnly = "1080.6999", Change = "+100.1601", symbol ="CTEL", StockExchange = "Nasdaq" });
			stocks.Add (new Stock () { Name = "Google Inc.", LastTradePriceOnly = "3.6999", Change = "+1.9601", symbol ="GOOG", StockExchange = "Nasdaq" });
			stocks.Add (new Stock () { Name = "Yahoo Inc.", LastTradePriceOnly = "38.6999", Change = "-0.9601", symbol ="YHOO", StockExchange = "Nasdaq" });
			stocks.Add (new Stock () { Name = "Apple Inc.", LastTradePriceOnly = "8.6999", Change = "-3.9601", symbol ="AAPL", StockExchange = "New York" });
			stocks.Add (new Stock () { Name = "Company Inc.", LastTradePriceOnly = "1080.6999", Change = "+100.1601", symbol ="CTEL", StockExchange = "Nasdaq" });
			stocks.Add (new Stock () { Name = "Google Inc.", LastTradePriceOnly = "3.6999", Change = "+1.9601", symbol ="GOOG", StockExchange = "Nasdaq" });
			stocks.Add (new Stock () { Name = "Yahoo Inc.", LastTradePriceOnly = "38.6999", Change = "-0.9601", symbol ="YHOO", StockExchange = "Nasdaq" });
			stocks.Add (new Stock () { Name = "Apple Inc.", LastTradePriceOnly = "8.6999", Change = "-3.9601", symbol ="AAPL", StockExchange = "New York" });
			stocks.Add (new Stock () { Name = "Company Inc.", LastTradePriceOnly = "1080.6999", Change = "+100.1601", symbol ="CTEL", StockExchange = "Nasdaq" });
			stocks.Add (new Stock () { Name = "Google Inc.", LastTradePriceOnly = "3.6999", Change = "+1.9601", symbol ="GOOG", StockExchange = "Nasdaq" });
			stocks.Add (new Stock () { Name = "Yahoo Inc.", LastTradePriceOnly = "38.6999", Change = "-0.9601", symbol ="YHOO", StockExchange = "Nasdaq" });
			stocks.Add (new Stock () { Name = "Apple Inc.", LastTradePriceOnly = "8.6999", Change = "-3.9601", symbol ="AAPL", StockExchange = "New York" });
			stocks.Add (new Stock () { Name = "Company Inc.", LastTradePriceOnly = "1080.6999", Change = "+100.1601", symbol ="CTEL", StockExchange = "Nasdaq" });
			stocks.Add (new Stock () { Name = "Google Inc.", LastTradePriceOnly = "3.6999", Change = "+1.9601", symbol ="GOOG", StockExchange = "Nasdaq" });
			stocks.Add (new Stock () { Name = "Yahoo Inc.", LastTradePriceOnly = "38.6999", Change = "-0.9601", symbol ="YHOO", StockExchange = "Nasdaq" });
			stocks.Add (new Stock () { Name = "Apple Inc.", LastTradePriceOnly = "8.6999", Change = "-3.9601", symbol ="AAPL", StockExchange = "New York" });
			stocks.Add (new Stock () { Name = "Company Inc.", LastTradePriceOnly = "1080.6999", Change = "+100.1601", symbol ="CTEL", StockExchange = "Nasdaq" });
			stocks.Add (new Stock () { Name = "Google Inc.", LastTradePriceOnly = "3.6999", Change = "+1.9601", symbol ="GOOG", StockExchange = "Nasdaq" });
			return stocks;
		}

        public static async Task<List<Stock>> GetHotStocks()
		{
			List<Stock> stocks = new List<Stock> ();
			UriBuilder builder = new UriBuilder("http://query.yahooapis.com/v1/public/yql");
			builder.Port = -1;
			String query = "q=select%20*%20from%20yahoo.finance.quote%20where%20symbol%20in%20(%22YHOO%22%2C%22AAPL%22%2C%22GOOG%22%2C%22MSFT%22)"
				+ "&format=json"
				+ "&env=store%3A%2F%2Fdatatables.org%2Falltableswithkeys"
				+ "&callback=";
			builder.Query = query;
		
			string url = builder.ToString();
			HttpClient client = new HttpClient();
            HttpResponseMessage response =  await client.GetAsync (url);
			if (response.IsSuccessStatusCode) 
			{
                string json =  await response.Content.ReadAsStringAsync ();
				StockQuote stock = JsonConvert.DeserializeObject<StockQuote> (json);
				stocks = stock.query.results.quote;
			}
			return stocks;
		}
	}
}

