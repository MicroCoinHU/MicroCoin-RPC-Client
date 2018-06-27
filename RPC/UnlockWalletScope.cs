using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MicroCoin.RPC {
	public class UnlockWalletScope : IDisposable {
		private readonly IMicroCoinClient _client;
		private readonly bool _ignore;

		internal UnlockWalletScope(IMicroCoinClient client, string password) {
			_client = client;
			_ignore = !_client.NodeStatus().Locked;
			if (!_ignore) {
				if (!_client.Unlock(password)) {
					throw new MicroCoinRPCException("Unable to unlock wallet");
				}
			}
		}

		public void Dispose() {
			if (!_ignore) {
				if (!_client.Lock()) {
					throw new MicroCoinRPCException("Unable to lock wallet");
				}
			}
		}
	}

}
