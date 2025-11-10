using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for key_vault_sas_token in .
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryLinkedServiceAzureBlobStorageKeyVaultSasTokenBlock : ITerraformBlock
{
    /// <summary>
    /// The linked_service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LinkedServiceName is required")]
    [TerraformPropertyName("linked_service_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> LinkedServiceName { get; set; }

    /// <summary>
    /// The secret_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretName is required")]
    [TerraformPropertyName("secret_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SecretName { get; set; }

}

/// <summary>
/// Block type for service_principal_linked_key_vault_key in .
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryLinkedServiceAzureBlobStorageServicePrincipalLinkedKeyVaultKeyBlock : ITerraformBlock
{
    /// <summary>
    /// The linked_service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LinkedServiceName is required")]
    [TerraformPropertyName("linked_service_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> LinkedServiceName { get; set; }

    /// <summary>
    /// The secret_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretName is required")]
    [TerraformPropertyName("secret_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SecretName { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDataFactoryLinkedServiceAzureBlobStorageTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_data_factory_linked_service_azure_blob_storage resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermDataFactoryLinkedServiceAzureBlobStorage : TerraformResource
{
    public AzurermDataFactoryLinkedServiceAzureBlobStorage(string name) : base("azurerm_data_factory_linked_service_azure_blob_storage", name)
    {
    }

    /// <summary>
    /// The additional_properties attribute.
    /// </summary>
    [TerraformPropertyName("additional_properties")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? AdditionalProperties { get; set; }

    /// <summary>
    /// The annotations attribute.
    /// </summary>
    [TerraformPropertyName("annotations")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? Annotations { get; set; }

    /// <summary>
    /// The connection_string attribute.
    /// </summary>
    [TerraformPropertyName("connection_string")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ConnectionString { get; set; }

    /// <summary>
    /// The connection_string_insecure attribute.
    /// </summary>
    [TerraformPropertyName("connection_string_insecure")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ConnectionStringInsecure { get; set; }

    /// <summary>
    /// The data_factory_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataFactoryId is required")]
    [TerraformPropertyName("data_factory_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DataFactoryId { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The integration_runtime_name attribute.
    /// </summary>
    [TerraformPropertyName("integration_runtime_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? IntegrationRuntimeName { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    [TerraformPropertyName("parameters")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Parameters { get; set; }

    /// <summary>
    /// The sas_uri attribute.
    /// </summary>
    [TerraformPropertyName("sas_uri")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SasUri { get; set; }

    /// <summary>
    /// The service_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("service_endpoint")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ServiceEndpoint { get; set; }

    /// <summary>
    /// The service_principal_id attribute.
    /// </summary>
    [TerraformPropertyName("service_principal_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ServicePrincipalId { get; set; }

    /// <summary>
    /// The service_principal_key attribute.
    /// </summary>
    [TerraformPropertyName("service_principal_key")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ServicePrincipalKey { get; set; }

    /// <summary>
    /// The storage_kind attribute.
    /// </summary>
    [TerraformPropertyName("storage_kind")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? StorageKind { get; set; }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [TerraformPropertyName("tenant_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TenantId { get; set; }

    /// <summary>
    /// The use_managed_identity attribute.
    /// </summary>
    [TerraformPropertyName("use_managed_identity")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? UseManagedIdentity { get; set; }

    /// <summary>
    /// Block for key_vault_sas_token.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KeyVaultSasToken block(s) allowed")]
    [TerraformPropertyName("key_vault_sas_token")]
    public TerraformList<TerraformBlock<AzurermDataFactoryLinkedServiceAzureBlobStorageKeyVaultSasTokenBlock>>? KeyVaultSasToken { get; set; } = new();

    /// <summary>
    /// Block for service_principal_linked_key_vault_key.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServicePrincipalLinkedKeyVaultKey block(s) allowed")]
    [TerraformPropertyName("service_principal_linked_key_vault_key")]
    public TerraformList<TerraformBlock<AzurermDataFactoryLinkedServiceAzureBlobStorageServicePrincipalLinkedKeyVaultKeyBlock>>? ServicePrincipalLinkedKeyVaultKey { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermDataFactoryLinkedServiceAzureBlobStorageTimeoutsBlock>? Timeouts { get; set; } = new();

}
