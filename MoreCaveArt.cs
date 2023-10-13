using Vintagestory.API.Client;
using Vintagestory.API.Common;
using Vintagestory.API.Config;
using Vintagestory.API.Server;

namespace MoreCaveArt
{
    public class MoreCaveArtMod : ModSystem
    {
        public override void Start(ICoreAPI api)
        {
            GlobalConstants.CaveArtColsPerRow = 7;
        }
    }
}