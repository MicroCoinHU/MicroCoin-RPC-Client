using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MicroCoin.DTO {
	/// <summary>
	/// JSON-RPC Error result
	/// </summary>
	public class ErrorResultDTO : MicroCoinDTO {
		[JsonProperty("code")]
		public ErrorCode ErrorCode { get; set; }

		[JsonProperty("message")]
		public string Message { get; set; }
	}

}
