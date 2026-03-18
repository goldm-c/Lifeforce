using Terraria;
using Terraria.ModLoader;

namespace Lifeforce
{
	public class LfPlayer : ModPlayer
	{
		public float sanguineDamage = 0f;
		public float sanguineLifesteal = 0f;
		public float sanguineLifeConsumption = 0f;
		public float sanguineKnockback = 0f;
		public float sanguineSpeed = 0f;
		public int sanguineCrit = 0;
		public int sanguineArmorPenetration = 0;
		
		public override void ResetEffects()
		{
			sanguineDamage = 0f;
			sanguineLifesteal = 0f;
			sanguineLifeConsumption = 0f;
			sanguineKnockback = 0f;
			sanguineSpeed = 0f;
			sanguineCrit = 0;
			sanguineArmorPenetration = 0;
		}
	}
}