﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MicroCoin {
	internal static class Constants {
		public const string NCoinVersion = "0.1";
		public const int DefaultMainNetPort = 4004;
		public const int DefaultMainNetRpcPort = 4003;
		public const int DefaultMainNetMinerPort = 4009;
		public const int DefaultTestNetPort = 4104;
		public const int DefaultTestNetRpcPort = 4103;
		public const int DefaultTestNetMinerPort = 4109;
		public const int AccountsPerBlock = 5;
		public const int OpHashByteLength = 32;
	}
}
