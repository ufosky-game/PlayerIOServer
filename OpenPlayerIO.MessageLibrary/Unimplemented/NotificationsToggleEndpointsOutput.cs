using PlayerIOClient.Helpers;
using ProtoBuf;

namespace OpenPlayerIO.Messages.Unimplemented
{
	[ProtoContract]
	public class NotificationsToggleEndpointsOutput
	{
		[ProtoMember(1)]
		public string Version { get; set; }

		[ProtoMember(2)]
		public Message Endpoints { get; set; }
	}
}
