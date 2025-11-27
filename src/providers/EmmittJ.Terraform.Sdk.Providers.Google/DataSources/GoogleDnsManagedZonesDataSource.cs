using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_dns_managed_zones Terraform data source.
/// Retrieves information about a google_dns_managed_zones.
/// </summary>
public partial class GoogleDnsManagedZonesDataSource(string name) : TerraformDataSource("google_dns_managed_zones", name)
{
    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The managed_zones attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ManagedZones
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "managed_zones").ResolveNodes(ctx));
    }

}
