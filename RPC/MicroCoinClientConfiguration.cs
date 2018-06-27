using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using MicroCoin.DTO;

namespace MicroCoin.RPC {
	public class MicroCoinClientConfiguration {
		public MicroCoinNetwork Network { get; set; } // For Future
		public string Server { get; set; }
		public int Port { get; set; }
		public string User { get; set; } // For future
		public string Password { get; set; } // For future

		public static MicroCoinClientConfiguration DefaultMainNet => new MicroCoinClientConfiguration {
			Network = MicroCoinNetwork.MainNet,
			Server = "localhost",
			Port = Constants.DefaultMainNetRpcPort,
			User = null,
			Password = null
		};

		public static MicroCoinClientConfiguration DefaultTestNet => new MicroCoinClientConfiguration {
			Network = MicroCoinNetwork.Testnet,
			Server = "localhost",
			Port = Constants.DefaultTestNetRpcPort,
			User = null,
			Password = null
		};
	} 
}
