using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;
using Lifeforce.Content.Projectiles;
using Microsoft.Xna.Framework;

namespace Lifeforce.Content.Items
{
	public class PoundingHeart : SanguineItem
	{

		public override void SetDefaults()
		{
			base.SetDefaults();
			lifesteal = 2;
			lifeConsumption = 5;
			Item.damage = 20;
			Item.width = 32;
			Item.height = 32;
			Item.useTime = 30;
			Item.useAnimation = 30;
			Item.useStyle = ItemUseStyleID.HoldUp;
			Item.noMelee = true;
			Item.knockBack = 8;
			Item.value = Item.buyPrice(silver: 40);
			Item.rare = ItemRarityID.Green;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = false;
			
			Item.shoot = ModContent.ProjectileType<Heartbeat>();
		}
		
		public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback) {
			// NewProjectile returns the index of the projectile it creates in the NewProjectile array.
			int projectileID = Projectile.NewProjectile(source, position, velocity, type, damage, knockback, player.whoAmI);
			Projectile projectile = Main.projectile[projectileID];
			
			SanguineProjectile sProjectile = projectile.GetGlobalProjectile<SanguineProjectile>();

			sProjectile.lifesteal = lifesteal;
			sProjectile.lifeConsumption = lifeConsumption;

			// We do not want vanilla to spawn a duplicate projectile.
			return false;
		}
	}
}
