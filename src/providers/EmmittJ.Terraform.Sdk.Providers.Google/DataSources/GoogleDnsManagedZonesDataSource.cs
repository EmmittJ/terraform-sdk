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
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// The managed_zones attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ManagedZones
        => AsReference("managed_zones");

}
