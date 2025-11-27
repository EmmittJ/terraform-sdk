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
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The workload_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkloadUri is required")]
    public required TerraformValue<string> WorkloadUri
    {
        get => new TerraformReference<string>(this, "workload_uri");
        set => SetArgument("workload_uri", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// The workload_properties attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> WorkloadProperties
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "workload_properties").ResolveNodes(ctx));
    }

    /// <summary>
    /// The workload_reference attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> WorkloadReference
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "workload_reference").ResolveNodes(ctx));
    }

}
