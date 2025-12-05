using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_apphub_discovered_workload Terraform data source.
/// Retrieves information about a google_apphub_discovered_workload.
/// </summary>
public partial class GoogleApphubDiscoveredWorkloadDataSource(string name) : TerraformDataSource("google_apphub_discovered_workload", name)
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The workload_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkloadUri is required")]
    public required TerraformValue<string> WorkloadUri
    {
        get => GetRequiredArgument<TerraformValue<string>>("workload_uri");
        set => SetArgument("workload_uri", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
        => CreateReference("name");

    /// <summary>
    /// The workload_properties attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> WorkloadProperties
        => CreateReference("workload_properties");

    /// <summary>
    /// The workload_reference attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> WorkloadReference
        => CreateReference("workload_reference");

}
