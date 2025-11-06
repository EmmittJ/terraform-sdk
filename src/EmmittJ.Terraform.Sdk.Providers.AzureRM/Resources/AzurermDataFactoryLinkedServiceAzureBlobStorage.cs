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
    /// The connection_string attribute.
    /// </summary>
    public string? ConnectionString
    {
        get => GetProperty<TerraformLiteralProperty<string>>("connection_string")?.Value;
        set => this.WithProperty("connection_string", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The connection_string_insecure attribute.
    /// </summary>
    public string? ConnectionStringInsecure
    {
        get => GetProperty<TerraformLiteralProperty<string>>("connection_string_insecure")?.Value;
        set => this.WithProperty("connection_string_insecure", value == null ? null : new TerraformLiteralProperty<string>(value));
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

    /// <summary>
    /// The sas_uri attribute.
    /// </summary>
    public string? SasUri
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sas_uri")?.Value;
        set => this.WithProperty("sas_uri", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The service_endpoint attribute.
    /// </summary>
    public string? ServiceEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_endpoint")?.Value;
        set => this.WithProperty("service_endpoint", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The service_principal_id attribute.
    /// </summary>
    public string? ServicePrincipalId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_principal_id")?.Value;
        set => this.WithProperty("service_principal_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The service_principal_key attribute.
    /// </summary>
    public string? ServicePrincipalKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_principal_key")?.Value;
        set => this.WithProperty("service_principal_key", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The storage_kind attribute.
    /// </summary>
    public string? StorageKind
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_kind")?.Value;
        set => this.WithProperty("storage_kind", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public string? TenantId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tenant_id")?.Value;
        set => this.WithProperty("tenant_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The use_managed_identity attribute.
    /// </summary>
    public bool? UseManagedIdentity
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("use_managed_identity")?.Value;
        set => this.WithProperty("use_managed_identity", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

}
