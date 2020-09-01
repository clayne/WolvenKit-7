using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeNodeGreetingReactionSceneDecoratorDefinition : CBehTreeNodeReactionSceneDefinitionDecorator
	{
		[Ordinal(1)] [RED("maxDistance")] 		public CFloat MaxDistance { get; set;}

		[Ordinal(2)] [RED("minDistance")] 		public CFloat MinDistance { get; set;}

		public CBehTreeNodeGreetingReactionSceneDecoratorDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehTreeNodeGreetingReactionSceneDecoratorDefinition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}