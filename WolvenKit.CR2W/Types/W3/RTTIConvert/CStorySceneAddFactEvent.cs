using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStorySceneAddFactEvent : CStorySceneEvent
	{
		[Ordinal(1)] [RED("factId")] 		public CString FactId { get; set;}

		[Ordinal(2)] [RED("expireTime")] 		public CInt32 ExpireTime { get; set;}

		[Ordinal(3)] [RED("factValue")] 		public CInt32 FactValue { get; set;}
#if NGE_VERSION
		[Ordinal(4)] [RED("telemetryEvent")] 		public CBool TelemetryEvent { get; set;}
#endif

		public CStorySceneAddFactEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CStorySceneAddFactEvent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}