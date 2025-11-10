using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for key_vault_sas_token in .
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryLinkedServiceAzureBlobStorageKeyVaultSasTokenBlock : TerraformBlock
{
    /// <summary>
    /// The linked_service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LinkedServiceName is required")]
    public required TerraformProperty<string> LinkedServiceName
    {
        get => GetProperty<TerraformProperty<string>>("linked_service_name");
        set => WithProperty("linked_service_name", value);
    }

    /// <summary>
    /// The secret_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretName is required")]
    public required TerraformProperty<string> SecretName
    {
        get => GetProperty<TerraformProperty<string>>("secret_name");
        set => WithProperty("secret_name", value);
    }

}

/// <summary>
/// Block type for service_principal_linked_key_vault_key in .
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryLinkedServiceAzureBlobStorageServicePrincipalLinkedKeyVaultKeyBlock : TerraformBlock
{
    /// <summary>
    /// The linked_service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LinkedServiceName is required")]
    public required TerraformProperty<string> LinkedServiceName
    {
        get => GetProperty<TerraformProperty<string>>("linked_service_name");
        set => WithProperty("linked_service_name", value);
    }

    /// <summary>
    /// The secret_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretName is required")]
    public required TerraformProperty<string> SecretName
    {
        get => GetProperty<TerraformProperty<string>>("secret_name");
        set => WithProperty("secret_name", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDataFactoryLinkedServiceAzureBlobStorageTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

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
    public Dictionary<string, TerraformProperty<string>>? AdditionalProperties
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("additional_properties");
        set => this.WithProperty("additional_properties", value);
    }

    /// <summary>
    /// The annotations attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Annotations
    {
        get => GetProperty<List<TerraformProperty<string>>>("annotations");
        set => this.WithProperty("annotations", value);
    }

    /// <summary>
    /// The connection_string attribute.
    /// </summary>
    public TerraformProperty<string>? ConnectionString
    {
        get => GetProperty<TerraformProperty<string>>("connection_string");
        set => this.WithProperty("connection_string", value);
    }

    /// <summary>
    /// The connection_string_insecure attribute.
    /// </summary>
    public TerraformProperty<string>? ConnectionStringInsecure
    {
        get => GetProperty<TerraformProperty<string>>("connection_string_insecure");
        set => this.WithProperty("connection_string_insecure", value);
    }

    /// <summary>
    /// The data_factory_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataFactoryId is required")]
    public required TerraformProperty<string> DataFactoryId
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Parameters
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("parameters");
        set => this.WithProperty("parameters", value);
    }

    /// <summary>
    /// The sas_uri attribute.
    /// </summary>
    public TerraformProperty<string>? SasUri
    {
        get => GetProperty<TerraformProperty<string>>("sas_uri");
        set => this.WithProperty("sas_uri", value);
    }

    /// <summary>
    /// The service_endpoint attribute.
    /// </summary>
    public TerraformProperty<string>? ServiceEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("service_endpoint");
        set => this.WithProperty("service_endpoint", value);
    }

    /// <summary>
    /// The service_principal_id attribute.
    /// </summary>
    public TerraformProperty<string>? ServicePrincipalId
    {
        get => GetProperty<TerraformProperty<string>>("service_principal_id");
        set => this.WithProperty("service_principal_id", value);
    }

    /// <summary>
    /// The service_principal_key attribute.
    /// </summary>
    public TerraformProperty<string>? ServicePrincipalKey
    {
        get => GetProperty<TerraformProperty<string>>("service_principal_key");
        set => this.WithProperty("service_principal_key", value);
    }

    /// <summary>
    /// The storage_kind attribute.
    /// </summary>
    public TerraformProperty<string>? StorageKind
    {
        get => GetProperty<TerraformProperty<string>>("storage_kind");
        set => this.WithProperty("storage_kind", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        get => GetProperty<TerraformProperty<string>>("tenant_id");
        set => this.WithProperty("tenant_id", value);
    }

    /// <summary>
    /// The use_managed_identity attribute.
    /// </summary>
    public TerraformProperty<bool>? UseManagedIdentity
    {
        get => GetProperty<TerraformProperty<bool>>("use_managed_identity");
        set => this.WithProperty("use_managed_identity", value);
    }

    /// <summary>
    /// Block for key_vault_sas_token.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KeyVaultSasToken block(s) allowed")]
    public List<AzurermDataFactoryLinkedServiceAzureBlobStorageKeyVaultSasTokenBlock>? KeyVaultSasToken
    {
        get => GetProperty<List<AzurermDataFactoryLinkedServiceAzureBlobStorageKeyVaultSasTokenBlock>>("key_vault_sas_token");
        set => this.WithProperty("key_vault_sas_token", value);
    }

    /// <summary>
    /// Block for service_principal_linked_key_vault_key.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServicePrincipalLinkedKeyVaultKey block(s) allowed")]
    public List<AzurermDataFactoryLinkedServiceAzureBlobStorageServicePrincipalLinkedKeyVaultKeyBlock>? ServicePrincipalLinkedKeyVaultKey
    {
        get => GetProperty<List<AzurermDataFactoryLinkedServiceAzureBlobStorageServicePrincipalLinkedKeyVaultKeyBlock>>("service_principal_linked_key_vault_key");
        set => this.WithProperty("service_principal_linked_key_vault_key", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermDataFactoryLinkedServiceAzureBlobStorageTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermDataFactoryLinkedServiceAzureBlobStorageTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
