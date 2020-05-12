using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using VINESHROOM.Players;

namespace VINESHROOM.Projectiles
{
	public class VineProjectile : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("VineProjectile");
			Main.projFrames[projectile.type] = 14;
			Main.projPet[projectile.type] = true;
		}

		public override void SetDefaults()
		{
			projectile.CloneDefaults(ProjectileID.BabyGrinch);
			aiType = ProjectileID.BabyGrinch;
			projectile.height = 64;
		}

		public override bool PreAI()
		{
			Player player = Main.player[projectile.owner];
			player.grinch = false; // Relic from aiType
			return true;
		}

		public override void AI()
		{
			Player player = Main.player[projectile.owner];
			VinePlayer modPlayer = player.GetModPlayer<VinePlayer>();
			if (player.dead)
			{
				modPlayer.vinePet = false;
			}
			if (modPlayer.vinePet)
			{
				projectile.timeLeft = 2;
			}
		}
	}
}