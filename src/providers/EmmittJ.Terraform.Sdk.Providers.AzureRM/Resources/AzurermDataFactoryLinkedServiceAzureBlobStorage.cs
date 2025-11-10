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
        set => SetProperty("linked_service_name", value);
    }

    /// <summary>
    /// The secret_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretName is required")]
    public required TerraformProperty<string> SecretName
    {
        set => SetProperty("secret_name", value);
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
        set => SetProperty("linked_service_name", value);
    }

    /// <summary>
    /// The secret_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretName is required")]
    public required TerraformProperty<string> SecretName
    {
        set => SetProperty("secret_name", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_data_factory_linked_service_azure_blob_storage resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermDataFactoryLinkedServiceAzureBlobStorage : TerraformResource
{
    public AzurermDataFactoryLinkedServiceAzureBlobStorage(string name) : base("azurerm_data_factory_linked_service_azure_blob_storage", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("additional_properties");
        SetOutput("annotations");
        SetOutput("connection_string");
        SetOutput("connection_string_insecure");
        SetOutput("data_factory_id");
        SetOutput("description");
        SetOutput("id");
        SetOutput("integration_runtime_name");
        SetOutput("name");
        SetOutput("parameters");
        SetOutput("sas_uri");
        SetOutput("service_endpoint");
        SetOutput("service_principal_id");
        SetOutput("service_principal_key");
        SetOutput("storage_kind");
        SetOutput("tenant_id");
        SetOutput("use_managed_identity");
    }

    /// <summary>
    /// The additional_properties attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> AdditionalProperties
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("additional_properties");
        set => SetProperty("additional_properties", value);
    }

    /// <summary>
    /// The annotations attribute.
    /// </summary>
    public List<TerraformProperty<string>> Annotations
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("annotations");
        set => SetProperty("annotations", value);
    }

    /// <summary>
    /// The connection_string attribute.
    /// </summary>
    public TerraformProperty<string> ConnectionString
    {
        get => GetRequiredOutput<TerraformProperty<string>>("connection_string");
        set => SetProperty("connection_string", value);
    }

    /// <summary>
    /// The connection_string_insecure attribute.
    /// </summary>
    public TerraformProperty<string> ConnectionStringInsecure
    {
        get => GetRequiredOutput<TerraformProperty<string>>("connection_string_insecure");
        set => SetProperty("connection_string_insecure", value);
    }

    /// <summary>
    /// The data_factory_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataFactoryId is required")]
    public required TerraformProperty<string> DataFactoryId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("data_factory_id");
        set => SetProperty("data_factory_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
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
    /// The integration_runtime_name attribute.
    /// </summary>
    public TerraformProperty<string> IntegrationRuntimeName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("integration_runtime_name");
        set => SetProperty("integration_runtime_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Parameters
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("parameters");
        set => SetProperty("parameters", value);
    }

    /// <summary>
    /// The sas_uri attribute.
    /// </summary>
    public TerraformProperty<string> SasUri
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sas_uri");
        set => SetProperty("sas_uri", value);
    }

    /// <summary>
    /// The service_endpoint attribute.
    /// </summary>
    public TerraformProperty<string> ServiceEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service_endpoint");
        set => SetProperty("service_endpoint", value);
    }

    /// <summary>
    /// The service_principal_id attribute.
    /// </summary>
    public TerraformProperty<string> ServicePrincipalId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service_principal_id");
        set => SetProperty("service_principal_id", value);
    }

    /// <summary>
    /// The service_principal_key attribute.
    /// </summary>
    public TerraformProperty<string> ServicePrincipalKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service_principal_key");
        set => SetProperty("service_principal_key", value);
    }

    /// <summary>
    /// The storage_kind attribute.
    /// </summary>
    public TerraformProperty<string> StorageKind
    {
        get => GetRequiredOutput<TerraformProperty<string>>("storage_kind");
        set => SetProperty("storage_kind", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string> TenantId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("tenant_id");
        set => SetProperty("tenant_id", value);
    }

    /// <summary>
    /// The use_managed_identity attribute.
    /// </summary>
    public TerraformProperty<bool> UseManagedIdentity
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("use_managed_identity");
        set => SetProperty("use_managed_identity", value);
    }

    /// <summary>
    /// Block for key_vault_sas_token.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KeyVaultSasToken block(s) allowed")]
    public List<AzurermDataFactoryLinkedServiceAzureBlobStorageKeyVaultSasTokenBlock>? KeyVaultSasToken
    {
        set => SetProperty("key_vault_sas_token", value);
    }

    /// <summary>
    /// Block for service_principal_linked_key_vault_key.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServicePrincipalLinkedKeyVaultKey block(s) allowed")]
    public List<AzurermDataFactoryLinkedServiceAzureBlobStorageServicePrincipalLinkedKeyVaultKeyBlock>? ServicePrincipalLinkedKeyVaultKey
    {
        set => SetProperty("service_principal_linked_key_vault_key", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermDataFactoryLinkedServiceAzureBlobStorageTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
