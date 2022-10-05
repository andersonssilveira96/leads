using System.ComponentModel;

namespace Leads.Domain.Enums
{
    public enum Category
    {
        Painters = 1,

        [Description("Interior Painters")]
        InteriorPainters,

        [Description("General Building Work")]
        GeneralBuildingWork,

        [Description("Home Renovations")]
        HomeRenovations
    }
}
