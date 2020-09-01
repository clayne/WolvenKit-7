using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3FireballProjectile : W3AdvancedProjectile
	{
		[Ordinal(1)] [RED("("initFxName")] 		public CName InitFxName { get; set;}

		[Ordinal(2)] [RED("("onCollisionFxName")] 		public CName OnCollisionFxName { get; set;}

		[Ordinal(3)] [RED("("spawnEntityTemplate")] 		public CHandle<CEntityTemplate> SpawnEntityTemplate { get; set;}

		[Ordinal(4)] [RED("("decreasePlayerDmgBy")] 		public CFloat DecreasePlayerDmgBy { get; set;}

		[Ordinal(5)] [RED("("projectileHitGround")] 		public CBool ProjectileHitGround { get; set;}

		public W3FireballProjectile(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3FireballProjectile(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}