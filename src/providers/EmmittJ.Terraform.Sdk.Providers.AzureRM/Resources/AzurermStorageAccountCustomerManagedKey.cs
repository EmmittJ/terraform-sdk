using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermStorageAccountCustomerManagedKeyTimeoutsBlock : ITerraformBlock
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
/// Manages a azurerm_storage_account_customer_managed_key resource.
/// </summary>
public class AzurermStorageAccountCustomerManagedKey : TerraformResource
{
    public AzurermStorageAccountCustomerManagedKey(string name) : base("azurerm_storage_account_customer_managed_key", name)
    {
    }

    /// <summary>
    /// The federated_identity_client_id attribute.
    /// </summary>
    [TerraformPropertyName("federated_identity_client_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? FederatedIdentityClientId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The key_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyName is required")]
    [TerraformPropertyName("key_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> KeyName { get; set; }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [TerraformPropertyName("key_vault_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? KeyVaultId { get; set; }

    /// <summary>
    /// The key_vault_uri attribute.
    /// </summary>
    [TerraformPropertyName("key_vault_uri")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> KeyVaultUri { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "key_vault_uri");

    /// <summary>
    /// The key_version attribute.
    /// </summary>
    [TerraformPropertyName("key_version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? KeyVersion { get; set; }

    /// <summary>
    /// The managed_hsm_key_id attribute.
    /// </summary>
    [TerraformPropertyName("managed_hsm_key_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ManagedHsmKeyId { get; set; }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountId is required")]
    [TerraformPropertyName("storage_account_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> StorageAccountId { get; set; }

    /// <summary>
    /// The user_assigned_identity_id attribute.
    /// </summary>
    [TerraformPropertyName("user_assigned_identity_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? UserAssignedIdentityId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermStorageAccountCustomerManagedKeyTimeoutsBlock>? Timeouts { get; set; } = new();

}
