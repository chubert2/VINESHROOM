using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using VINESHROOM.Players;
using VINESHROOM.Projectiles;

namespace VINESHROOM.Buffs
{
    class VineBuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Saucy");
            Description.SetDefault("The Vineshroom is following you");
            Main.buffNoTimeDisplay[Type] = true;
            Main.vanityPet[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.buffTime[buffIndex] = 18000;
            player.GetModPlayer<VinePlayer>().vinePet = true;
            bool petProjectileNotSpawned = player.ownedProjectileCounts[mod.ProjectileType("VineProjectile")] <= 0;
            if (petProjectileNotSpawned && player.whoAmI == Main.myPlayer)
            {
                Projectile.NewProjectile(player.position.X + (float)(player.width / 2), player.position.Y + (float)(player.height / 2), 0f, 0f, mod.ProjectileType("VineProjectile"), 0, 0f, player.whoAmI, 0f, 0f);
            }
        }
    }
}
