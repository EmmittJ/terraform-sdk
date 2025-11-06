using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_data_factory_integration_runtime_azure_ssis resource.
/// </summary>
public class AzurermDataFactoryIntegrationRuntimeAzureSsis : TerraformResource
{
    public AzurermDataFactoryIntegrationRuntimeAzureSsis(string name) : base("azurerm_data_factory_integration_runtime_azure_ssis", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The credential_name attribute.
    /// </summary>
    public string? CredentialName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("credential_name")?.Value;
        set => this.WithProperty("credential_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The data_factory_id attribute.
    /// </summary>
    public string? DataFactoryId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("data_factory_id")?.Value;
        set => this.WithProperty("data_factory_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The edition attribute.
    /// </summary>
    public string? Edition
    {
        get => GetProperty<TerraformLiteralProperty<string>>("edition")?.Value;
        set => this.WithProperty("edition", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The license_type attribute.
    /// </summary>
    public string? LicenseType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("license_type")?.Value;
        set => this.WithProperty("license_type", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The max_parallel_executions_per_node attribute.
    /// </summary>
    public double? MaxParallelExecutionsPerNode
    {
        get => GetProperty<TerraformLiteralProperty<double>>("max_parallel_executions_per_node")?.Value;
        set => this.WithProperty("max_parallel_executions_per_node", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The node_size attribute.
    /// </summary>
    public string? NodeSize
    {
        get => GetProperty<TerraformLiteralProperty<string>>("node_size")?.Value;
        set => this.WithProperty("node_size", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The number_of_nodes attribute.
    /// </summary>
    public double? NumberOfNodes
    {
        get => GetProperty<TerraformLiteralProperty<double>>("number_of_nodes")?.Value;
        set => this.WithProperty("number_of_nodes", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

}
