using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_alloydb_locations Terraform data source.
/// Retrieves information about a google_alloydb_locations.
/// </summary>
public partial class GoogleAlloydbLocationsDataSource(string name) : TerraformDataSource("google_alloydb_locations", name)
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
    /// Project ID of the project.
    /// </summary>
    public TerraformValue<string>? Project
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
