using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameInput;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using static Terraria.ModLoader.ModContent;

namespace VINESHROOM.Players
{
    class VinePlayer : ModPlayer
    {
        public bool vinePet;

        public override void ResetEffects()
        {
            vinePet = false;
        }
    }
}
