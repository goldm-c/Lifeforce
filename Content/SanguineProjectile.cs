using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lifeforce.Content
{
	public class SanguineProjectile : GlobalProjectile
	{
		public int lifeConsumption = 0;
		public int lifesteal = 0;
		
		public override bool InstancePerEntity => true;
	}
}