using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SAttachmentReplacement : CVariable
	{
		[Ordinal(1)] [RED("oldName")] 		public CName OldName { get; set;}

		[Ordinal(2)] [RED("oldClass")] 		public CName OldClass { get; set;}

		[Ordinal(3)] [RED("newName")] 		public CName NewName { get; set;}

		[Ordinal(4)] [RED("newClass")] 		public CName NewClass { get; set;}

		public SAttachmentReplacement(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SAttachmentReplacement(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}