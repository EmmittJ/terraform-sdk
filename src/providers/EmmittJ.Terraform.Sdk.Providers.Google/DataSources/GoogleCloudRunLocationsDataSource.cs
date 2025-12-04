using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_cloud_run_locations Terraform data source.
/// Retrieves information about a google_cloud_run_locations.
/// </summary>
public partial class GoogleCloudRunLocationsDataSource(string name) : TerraformDataSource("google_cloud_run_locations", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? AsReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The locations attribute.
    /// </summary>
    public TerraformList<string> Locations
        => AsReference("locations");

}
