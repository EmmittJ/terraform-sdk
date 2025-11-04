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
        this.DeclareOutput("name");
        this.DeclareOutput("workload_properties");
        this.DeclareOutput("workload_reference");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The workload_uri attribute.
    /// </summary>
    public string? WorkloadUri
    {
        get => GetProperty<TerraformLiteralProperty<string>>("workload_uri")?.Value;
        set => this.WithProperty("workload_uri", value == null ? null : new TerraformLiteralProperty<string>(value));
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
