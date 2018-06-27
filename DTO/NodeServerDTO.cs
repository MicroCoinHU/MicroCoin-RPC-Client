using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MicroCoin.DTO {
	/// <summary>
	/// Embedded JSON object describing a nodes list of servers
	/// </summary>
	public class NodeServerDTO : MicroCoinDTO {
		[JsonProperty("ip")]
		public string IP { get; set; }

		[JsonProperty("port")]
		public uint Port { get; set; }

		[JsonProperty("lastcon")]
		public uint LastConnect { get; set; }

		[JsonProperty("attempts")]
		public uint Attempts { get; set; }
		
	}
}
