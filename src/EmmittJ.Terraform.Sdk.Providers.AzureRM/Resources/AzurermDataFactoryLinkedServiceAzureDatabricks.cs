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
    public TerraformProperty<string>? AccessToken
    {
        get => GetProperty<TerraformProperty<string>>("access_token");
        set => this.WithProperty("access_token", value);
    }

    /// <summary>
    /// The adb_domain attribute.
    /// </summary>
    public TerraformProperty<string>? AdbDomain
    {
        get => GetProperty<TerraformProperty<string>>("adb_domain");
        set => this.WithProperty("adb_domain", value);
    }

    /// <summary>
    /// The additional_properties attribute.
    /// </summary>
    public TerraformMapProperty<string>? AdditionalProperties
    {
        get => GetProperty<TerraformMapProperty<string>>("additional_properties");
        set => this.WithProperty("additional_properties", value);
    }

    /// <summary>
    /// The annotations attribute.
    /// </summary>
    public TerraformProperty<List<string>>? Annotations
    {
        get => GetProperty<TerraformProperty<List<string>>>("annotations");
        set => this.WithProperty("annotations", value);
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
    /// The existing_cluster_id attribute.
    /// </summary>
    public TerraformProperty<string>? ExistingClusterId
    {
        get => GetProperty<TerraformProperty<string>>("existing_cluster_id");
        set => this.WithProperty("existing_cluster_id", value);
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
    /// The integration_runtime_name attribute.
    /// </summary>
    public TerraformProperty<string>? IntegrationRuntimeName
    {
        get => GetProperty<TerraformProperty<string>>("integration_runtime_name");
        set => this.WithProperty("integration_runtime_name", value);
    }

    /// <summary>
    /// The msi_work_space_resource_id attribute.
    /// </summary>
    public TerraformProperty<string>? MsiWorkSpaceResourceId
    {
        get => GetProperty<TerraformProperty<string>>("msi_work_space_resource_id");
        set => this.WithProperty("msi_work_space_resource_id", value);
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
    /// The parameters attribute.
    /// </summary>
    public TerraformMapProperty<string>? Parameters
    {
        get => GetProperty<TerraformMapProperty<string>>("parameters");
        set => this.WithProperty("parameters", value);
    }

}
