using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_apphub_discovered_workload.
/// </summary>
public class GoogleApphubDiscoveredWorkloadDataSource : TerraformDataSource
{
    public GoogleApphubDiscoveredWorkloadDataSource(string name) : base("google_apphub_discovered_workload", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("name");
        SetOutput("workload_properties");
        SetOutput("workload_reference");
        SetOutput("id");
        SetOutput("location");
        SetOutput("project");
        SetOutput("workload_uri");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// The workload_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkloadUri is required")]
    public required TerraformProperty<string> WorkloadUri
    {
        get => GetRequiredOutput<TerraformProperty<string>>("workload_uri");
        set => SetProperty("workload_uri", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The workload_properties attribute.
    /// </summary>
    public TerraformExpression WorkloadProperties => this["workload_properties"];

    /// <summary>
    /// The workload_reference attribute.
    /// </summary>
    public TerraformExpression WorkloadReference => this["workload_reference"];

}
