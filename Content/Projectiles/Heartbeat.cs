using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lifeforce.Content.Projectiles
{
	public class Heartbeat : ModProjectile
	{
		public override void SetDefaults() {
			Projectile.width = 16;
			Projectile.height = 16;
			Projectile.DamageType = ModContent.GetInstance<SanguineClass>();
			Projectile.friendly = true;
			Projectile.penetrate = -1;
			Projectile.timeLeft = 80;
			Projectile.tileCollide = false;
			Projectile.ignoreWater = true;
		}
		
		public override void AI() {
			Player player = Main.player[Projectile.owner];
			Projectile.width = (80-Projectile.timeLeft)*2+16;
			Projectile.height = (80-Projectile.timeLeft)*2+16;
			Projectile.position.X = player.Center.X-((40-Projectile.timeLeft/2)*2)-8;
			Projectile.position.Y = player.Center.Y-((40-Projectile.timeLeft/2)*2)-8;
		}
		
		public override void OnHitNPC(NPC target, NPC.HitInfo hit, int damageDone)
		{
			Player player = Main.player[Projectile.owner];
			SanguineProjectile sProjectile = Projectile.GetGlobalProjectile<SanguineProjectile>();
			
			if (!target.SpawnedFromStatue && !target.immortal) //target.immortal is used by Target Dummies
			{
				player.statLife += sProjectile.lifesteal;
			}
		}
	}
}
	