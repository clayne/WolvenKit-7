using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CExtAnimDialogKeyPoseDuration : CExtAnimDurationEvent
	{
		[Ordinal(1)] [RED("("transition")] 		public CBool Transition { get; set;}

		[Ordinal(2)] [RED("("keyPose")] 		public CBool KeyPose { get; set;}

		public CExtAnimDialogKeyPoseDuration(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CExtAnimDialogKeyPoseDuration(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}