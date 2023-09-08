using System.ComponentModel;

namespace WarframeInventory.Enums
{
    public enum StatusWarframe
    {
        [Description("The blueprint of this Warframe is owned")]
        BlueprintOwned = 1,
        [Description("The Warframe is being built")]
        BeingBuilt = 2,
        [Description("The Warframe is fully built and owned")]
        Owned = 3
    }
}
