using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_data_factory_linked_service_azure_databricks resource.
/// </summary>
public class AzurermDataFactoryLinkedServiceAzureDatabricks : TerraformResource
{
    public AzurermDataFactoryLinkedServiceAzureDatabricks(string name) : base("azurerm_data_factory_linked_service_azure_databricks", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The access_token attribute.
    /// </summary>
    public string? AccessToken
    {
        get => GetProperty<TerraformLiteralProperty<string>>("access_token")?.Value;
        set => this.WithProperty("access_token", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The adb_domain attribute.
    /// </summary>
    public string? AdbDomain
    {
        get => GetProperty<TerraformLiteralProperty<string>>("adb_domain")?.Value;
        set => this.WithProperty("adb_domain", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The additional_properties attribute.
    /// </summary>
    public Dictionary<string, string>? AdditionalProperties
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("additional_properties")?.Value;
        set => this.WithProperty("additional_properties", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The annotations attribute.
    /// </summary>
    public List<string>? Annotations
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("annotations")?.Value;
        set => this.WithProperty("annotations", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
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
    /// The existing_cluster_id attribute.
    /// </summary>
    public string? ExistingClusterId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("existing_cluster_id")?.Value;
        set => this.WithProperty("existing_cluster_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The integration_runtime_name attribute.
    /// </summary>
    public string? IntegrationRuntimeName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("integration_runtime_name")?.Value;
        set => this.WithProperty("integration_runtime_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The msi_work_space_resource_id attribute.
    /// </summary>
    public string? MsiWorkSpaceResourceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("msi_work_space_resource_id")?.Value;
        set => this.WithProperty("msi_work_space_resource_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The parameters attribute.
    /// </summary>
    public Dictionary<string, string>? Parameters
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("parameters")?.Value;
        set => this.WithProperty("parameters", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

}
