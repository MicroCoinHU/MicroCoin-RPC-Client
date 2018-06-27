using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace MicroCoin {
	public class MicroCoinException : ApplicationException {
		public MicroCoinException(string error) : base(error)  {			
		}
	}
}
