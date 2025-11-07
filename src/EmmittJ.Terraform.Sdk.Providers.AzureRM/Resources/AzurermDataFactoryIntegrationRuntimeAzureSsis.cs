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
    public TerraformProperty<string>? CredentialName
    {
        get => GetProperty<TerraformProperty<string>>("credential_name");
        set => this.WithProperty("credential_name", value);
    }

    /// <summary>
    /// The data_factory_id attribute.
    /// </summary>
    public TerraformProperty<string>? DataFactoryId
    {
        get => GetProperty<TerraformProperty<string>>("data_factory_id");
        set => this.WithProperty("data_factory_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The edition attribute.
    /// </summary>
    public TerraformProperty<string>? Edition
    {
        get => GetProperty<TerraformProperty<string>>("edition");
        set => this.WithProperty("edition", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The license_type attribute.
    /// </summary>
    public TerraformProperty<string>? LicenseType
    {
        get => GetProperty<TerraformProperty<string>>("license_type");
        set => this.WithProperty("license_type", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The max_parallel_executions_per_node attribute.
    /// </summary>
    public TerraformProperty<double>? MaxParallelExecutionsPerNode
    {
        get => GetProperty<TerraformProperty<double>>("max_parallel_executions_per_node");
        set => this.WithProperty("max_parallel_executions_per_node", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The node_size attribute.
    /// </summary>
    public TerraformProperty<string>? NodeSize
    {
        get => GetProperty<TerraformProperty<string>>("node_size");
        set => this.WithProperty("node_size", value);
    }

    /// <summary>
    /// The number_of_nodes attribute.
    /// </summary>
    public TerraformProperty<double>? NumberOfNodes
    {
        get => GetProperty<TerraformProperty<double>>("number_of_nodes");
        set => this.WithProperty("number_of_nodes", value);
    }

}
