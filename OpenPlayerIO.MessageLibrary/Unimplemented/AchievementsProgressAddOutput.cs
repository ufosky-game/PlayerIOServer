using PlayerIOClient.Helpers;
using ProtoBuf;

namespace OpenPlayerIO.Messages.Unimplemented
{
	[ProtoContract]
	public class AchievementsProgressAddOutput
	{
		[ProtoMember(1)]
		public Message Achievement { get; set; }

		[ProtoMember(2)]
		public bool CompletedNow { get; set; }
	}
}
