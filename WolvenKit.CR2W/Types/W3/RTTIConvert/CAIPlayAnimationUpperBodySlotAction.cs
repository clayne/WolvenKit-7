using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAIPlayAnimationUpperBodySlotAction : IActionDecorator
	{
		[Ordinal(1)] [RED("animName")] 		public CName AnimName { get; set;}

		[Ordinal(2)] [RED("interruptScriptedActionOnSlotAnimEnd")] 		public CBool InterruptScriptedActionOnSlotAnimEnd { get; set;}

		public CAIPlayAnimationUpperBodySlotAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAIPlayAnimationUpperBodySlotAction(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}