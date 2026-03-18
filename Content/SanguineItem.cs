using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;
using System.Collections.Generic;
using System;

namespace Lifeforce.Content
{

	public abstract class SanguineItem : ModItem
	{
		protected int lifeConsumption = 0;
		protected int lifesteal = 0;
		
		public override void SetDefaults()
		{
			Item.DamageType = ModContent.GetInstance<SanguineClass>();
		}
		
		public override void ModifyTooltips(List<TooltipLine> tooltips) {
			string lctext = Language.GetTextValue("Mods.Lifeforce.Common.ConsumesXLifeText");
			string lstext = Language.GetTextValue("Mods.Lifeforce.Common.StealsXLifeText");
			tooltips.Insert(5, new TooltipLine(Mod, "ConsumesXLife", string.Format(lctext, lifeConsumption.ToString())));
			tooltips.Insert(6, new TooltipLine(Mod, "StealsXLife", string.Format(lstext, lifesteal.ToString())));
		}
		
		public virtual void ModifyLifesteal(float scale) //Not used yet.
		{
			lifesteal += (int)Math.Round(scale);
		}
		
		public virtual void ModifyLifeConsumption(float scale) //Not used yet.
		{
			lifeConsumption += (int)Math.Round(scale);
		}
		
		public override bool? UseItem(Player player) {
			player.statLife -= lifeConsumption;
			return true;
		}
		
		
	}
}
	