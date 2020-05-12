using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using VINESHROOM.Projectiles;
using VINESHROOM.Buffs;

namespace VINESHROOM.Items
{
	public class VineItem : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Vineshroom");
			Tooltip.SetDefault("Summons stale memes");
		}

		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.BabyGrinchMischiefWhistle);
			item.shoot = mod.ProjectileType("VineProjectile");
			item.buffType = mod.BuffType("VineBuff");
			item.rare = 6;
		}

		public override void UseStyle(Player player)
		{
			if (player.whoAmI == Main.myPlayer && player.itemTime == 0)
			{
				player.AddBuff(item.buffType, 36000, true);
			}
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Mushroom, 10);
			recipe.AddIngredient(ItemID.GlowingMushroom, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}