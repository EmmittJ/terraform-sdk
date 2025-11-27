using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_compute_interconnect_locations Terraform data source.
/// Retrieves information about a google_compute_interconnect_locations.
/// </summary>
public partial class GoogleComputeInterconnectLocationsDataSource(string name) : TerraformDataSource("google_compute_interconnect_locations", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The locations attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Locations
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "locations").ResolveNodes(ctx));
    }

}
