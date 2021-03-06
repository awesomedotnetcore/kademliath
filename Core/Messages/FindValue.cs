﻿using System;

namespace Kademliath.Core.Messages
{
	/// <summary>
	/// Represents a request to get a value.
	/// Receiver should either send key or a node list.
	/// </summary>
	[Serializable]
	public class FindValue : Message
	{
		public Id Key { get; }		
		
		/// <summary>
		/// Make a new FindValue message.
		/// </summary>
		/// <param name="nodeId"></param>
		/// <param name="wantedKey"></param>
		public FindValue(Id nodeId, Id wantedKey) : base(nodeId)
		{
			Key = wantedKey;
		}
		
		public override string GetName()
		{
			return "FIND_VALUE";
		}
	}
}
