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
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? CreateReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The locations attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Locations
        => CreateReference("locations");

}
