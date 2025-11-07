using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_data_factory_linked_service_kusto resource.
/// </summary>
public class AzurermDataFactoryLinkedServiceKusto : TerraformResource
{
    public AzurermDataFactoryLinkedServiceKusto(string name) : base("azurerm_data_factory_linked_service_kusto", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The additional_properties attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? AdditionalProperties
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("additional_properties");
        set => this.WithProperty("additional_properties", value);
    }

    /// <summary>
    /// The annotations attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? Annotations
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("annotations");
        set => this.WithProperty("annotations", value);
    }

    /// <summary>
    /// The data_factory_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DataFactoryId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("data_factory_id");
        set => this.WithProperty("data_factory_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The integration_runtime_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? IntegrationRuntimeName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("integration_runtime_name");
        set => this.WithProperty("integration_runtime_name", value);
    }

    /// <summary>
    /// The kusto_database_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? KustoDatabaseName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kusto_database_name");
        set => this.WithProperty("kusto_database_name", value);
    }

    /// <summary>
    /// The kusto_endpoint attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? KustoEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kusto_endpoint");
        set => this.WithProperty("kusto_endpoint", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Parameters
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("parameters");
        set => this.WithProperty("parameters", value);
    }

    /// <summary>
    /// The service_principal_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ServicePrincipalId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_principal_id");
        set => this.WithProperty("service_principal_id", value);
    }

    /// <summary>
    /// The service_principal_key attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ServicePrincipalKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_principal_key");
        set => this.WithProperty("service_principal_key", value);
    }

    /// <summary>
    /// The tenant attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Tenant
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tenant");
        set => this.WithProperty("tenant", value);
    }

    /// <summary>
    /// The use_managed_identity attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? UseManagedIdentity
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("use_managed_identity");
        set => this.WithProperty("use_managed_identity", value);
    }

}
