using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ID;

namespace Lifeforce.Content.Items
{
	public class VampireFangs : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 34;
			Item.height = 14;
			Item.rare = ItemRarityID.LightRed;
			Item.value = Item.buyPrice(gold: 10);
			Item.accessory = true;
		}
		
		public override void UpdateAccessory(Player player, bool hideVisual) 
		{
			player.GetModPlayer<LfPlayer>().sanguineLifesteal += 1f;
		}
	}
}