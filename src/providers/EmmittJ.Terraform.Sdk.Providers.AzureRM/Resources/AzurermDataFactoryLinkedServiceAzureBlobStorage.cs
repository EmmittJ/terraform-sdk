using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for key_vault_sas_token in .
/// Nesting mode: list
/// </summary>
public partial class AzurermDataFactoryLinkedServiceAzureBlobStorageKeyVaultSasTokenBlock() : TerraformBlock("key_vault_sas_token")
{
    /// <summary>
    /// The linked_service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LinkedServiceName is required")]
    [TerraformProperty("linked_service_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> LinkedServiceName { get; set; }

    /// <summary>
    /// The secret_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretName is required")]
    [TerraformProperty("secret_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SecretName { get; set; }

}

/// <summary>
/// Block type for service_principal_linked_key_vault_key in .
/// Nesting mode: list
/// </summary>
public partial class AzurermDataFactoryLinkedServiceAzureBlobStorageServicePrincipalLinkedKeyVaultKeyBlock() : TerraformBlock("service_principal_linked_key_vault_key")
{
    /// <summary>
    /// The linked_service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LinkedServiceName is required")]
    [TerraformProperty("linked_service_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> LinkedServiceName { get; set; }

    /// <summary>
    /// The secret_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretName is required")]
    [TerraformProperty("secret_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SecretName { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermDataFactoryLinkedServiceAzureBlobStorageTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_data_factory_linked_service_azure_blob_storage resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermDataFactoryLinkedServiceAzureBlobStorage : TerraformResource
{
    public AzurermDataFactoryLinkedServiceAzureBlobStorage(string name) : base("azurerm_data_factory_linked_service_azure_blob_storage", name)
    {
    }

    /// <summary>
    /// The additional_properties attribute.
    /// </summary>
    [TerraformProperty("additional_properties")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? AdditionalProperties { get; set; }

    /// <summary>
    /// The annotations attribute.
    /// </summary>
    [TerraformProperty("annotations")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? Annotations { get; set; }

    /// <summary>
    /// The connection_string attribute.
    /// </summary>
    [TerraformProperty("connection_string")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ConnectionString { get; set; }

    /// <summary>
    /// The connection_string_insecure attribute.
    /// </summary>
    [TerraformProperty("connection_string_insecure")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ConnectionStringInsecure { get; set; }

    /// <summary>
    /// The data_factory_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataFactoryId is required")]
    [TerraformProperty("data_factory_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DataFactoryId { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The integration_runtime_name attribute.
    /// </summary>
    [TerraformProperty("integration_runtime_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? IntegrationRuntimeName { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    [TerraformProperty("parameters")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Parameters { get; set; }

    /// <summary>
    /// The sas_uri attribute.
    /// </summary>
    [TerraformProperty("sas_uri")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SasUri { get; set; }

    /// <summary>
    /// The service_endpoint attribute.
    /// </summary>
    [TerraformProperty("service_endpoint")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ServiceEndpoint { get; set; }

    /// <summary>
    /// The service_principal_id attribute.
    /// </summary>
    [TerraformProperty("service_principal_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ServicePrincipalId { get; set; }

    /// <summary>
    /// The service_principal_key attribute.
    /// </summary>
    [TerraformProperty("service_principal_key")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ServicePrincipalKey { get; set; }

    /// <summary>
    /// The storage_kind attribute.
    /// </summary>
    [TerraformProperty("storage_kind")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? StorageKind { get; set; }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [TerraformProperty("tenant_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TenantId { get; set; }

    /// <summary>
    /// The use_managed_identity attribute.
    /// </summary>
    [TerraformProperty("use_managed_identity")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? UseManagedIdentity { get; set; }

    /// <summary>
    /// Block for key_vault_sas_token.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KeyVaultSasToken block(s) allowed")]
    [TerraformProperty("key_vault_sas_token")]
    public TerraformList<AzurermDataFactoryLinkedServiceAzureBlobStorageKeyVaultSasTokenBlock> KeyVaultSasToken { get; set; } = new();

    /// <summary>
    /// Block for service_principal_linked_key_vault_key.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServicePrincipalLinkedKeyVaultKey block(s) allowed")]
    [TerraformProperty("service_principal_linked_key_vault_key")]
    public TerraformList<AzurermDataFactoryLinkedServiceAzureBlobStorageServicePrincipalLinkedKeyVaultKeyBlock> ServicePrincipalLinkedKeyVaultKey { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermDataFactoryLinkedServiceAzureBlobStorageTimeoutsBlock Timeouts { get; set; } = new();

}
