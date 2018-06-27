﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MicroCoin.DTO {

	/// <summary>
	/// An "Operation object" is a JSON object with information about an operation.
	/// </summary>
	public class OperationDTO : MicroCoinDTO {

		/// <summary>
		/// Operation hash used to find this operation in the blockchain. (HEXASTRING).
		/// </summary>
		[JsonProperty("ophash")]
		public string Ophash { get; set; }


		/// <summary>
		/// If operation is invalid, value=false  (optional)
		/// </summary>
		[JsonProperty("valid")]
		[DefaultValue(null)]
		public bool? Valid { get; set; }

		/// <summary>
		/// If operation is invalid, an error description (optional)
		/// </summary>
		[JsonProperty("errors")]
		[DefaultValue(null)]
		public string Errors { get; set; }

		/// <summary>
		/// Block number (only when valid) 
		/// </summary>
		[JsonProperty("block")]
		public uint? Block { get; set; }

		/// <summary>
		/// Block timestamp (only when valid) 
		/// </summary>
		[JsonProperty("time")]
		[DefaultValue(null)]
		public uint? Time { get; set; }

		/// <summary>
		/// Operation index inside a block(0..operations-1). Note: If opblock = -1 means that is a blockchain reward (only when valid)
		/// </summary>
		[JsonProperty("opblock")]
		[DefaultValue(null)]
		public int? OperationBlock { get; set; }

		/// <summary>
		/// Return null when operation is not included on a blockchain yet, 0 means that is included in highest block and so on... (New on Build 1.4.3)
		/// </summary>
		[JsonProperty("maturation")]
		public uint? Maturation { get; set; }

		/// <summary>
		/// Operation type.
		/// </summary>
		[JsonProperty("optype")]
		public OperationType Type { get; set; }


		/// <summary>
		/// Operation sub-type.
		/// </summary>
		[JsonProperty("subtype")]
		public OperationSubType SubType { get; set; }

		/// <summary>
		/// Account affected by this operation.Note: A transaction has 2 affected accounts.
		/// </summary>
		[JsonProperty("account")]
		public int Account { get; set; }

		/// <summary>
		/// Account affected by this operation.Note: A transaction has 2 affected accounts.
		/// </summary>
		[JsonProperty("optxt")]
		public string TypeDescriptor { get; set; }

		/// <summary>
		/// Amount of coins transferred from sender_account to dest_account (Only apply when optype = 1) (MCC)
		/// </summary>
		[JsonProperty("amount")]
		public decimal Amount { get; set; }

		/// <summary>
		/// Fee of this operation (MCC)
		/// </summary>
		[JsonProperty("fee")]
		public decimal Fee { get; set; }

		/// <summary>
		/// Balance of account after this block is introduced in the Blockchain (MCC).
		/// </summary>
		/// <remarks>
		/// balance is a calculation based on current safebox account balance and previous operations, it's only returned on pending operations and account operations
		/// </remarks>
		[JsonProperty("balance")]
		public decimal Balance { get; set; }

		/// <summary>
		/// Sender account in a transaction (optype = 1)
		/// </summary>
		[JsonProperty("sender_account")]
		public uint SenderAccount { get; set; }

		/// <summary>
		/// Destination account in a transaction (optype = 1)
		/// </summary>
		[JsonProperty("dest_account")]
		public uint DestAccount { get; set; }

		/// <summary>
		/// Account that signed operation, and pays network fee.
		/// </summary>
		[JsonProperty("signer_account")]
		public int SignerAccount { get; set; }

		/// <summary>
		/// Encoded public key used in either a change key operation (optype = 2) or a list account for sale (privat sale)operation. (HEXASTRING).
		/// </summary>
		/// <remarks>See decodepubkey to deconstruct datatype.</remarks>
		[JsonProperty("enc_pubkey")]
		public string EncPubKey { get; set; }

		/// <summary>
		/// Operation payload in hex format
		/// </summary>
		[JsonProperty("payload")]
		[JsonConverter(typeof(HexBinaryConverter))]
		public byte[] PayLoad { get; set; }

		/// <summary>
		/// Operation hash calculated using V1 algorithm. Only provided for operations before V2 activation. (HEXASTRING).
		/// </summary>
		[JsonProperty("old_ophash")]
		public string V1_Ophash { get; set; }

	}
}
