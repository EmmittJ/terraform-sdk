using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_data_factory_linked_service_azure_blob_storage resource.
/// </summary>
public class AzurermDataFactoryLinkedServiceAzureBlobStorage : TerraformResource
{
    public AzurermDataFactoryLinkedServiceAzureBlobStorage(string name) : base("azurerm_data_factory_linked_service_azure_blob_storage", name)
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
    /// The connection_string attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ConnectionString
    {
        get => GetProperty<TerraformLiteralProperty<string>>("connection_string");
        set => this.WithProperty("connection_string", value);
    }

    /// <summary>
    /// The connection_string_insecure attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ConnectionStringInsecure
    {
        get => GetProperty<TerraformLiteralProperty<string>>("connection_string_insecure");
        set => this.WithProperty("connection_string_insecure", value);
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
    /// The sas_uri attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SasUri
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sas_uri");
        set => this.WithProperty("sas_uri", value);
    }

    /// <summary>
    /// The service_endpoint attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ServiceEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_endpoint");
        set => this.WithProperty("service_endpoint", value);
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
    /// The storage_kind attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? StorageKind
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_kind");
        set => this.WithProperty("storage_kind", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TenantId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tenant_id");
        set => this.WithProperty("tenant_id", value);
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
