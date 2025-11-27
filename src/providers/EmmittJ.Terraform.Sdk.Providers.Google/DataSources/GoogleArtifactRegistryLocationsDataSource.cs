using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_artifact_registry_locations Terraform data source.
/// Retrieves information about a google_artifact_registry_locations.
/// </summary>
public partial class GoogleArtifactRegistryLocationsDataSource(string name) : TerraformDataSource("google_artifact_registry_locations", name)
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
    public TerraformList<string> Locations
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "locations").ResolveNodes(ctx));
    }

}
