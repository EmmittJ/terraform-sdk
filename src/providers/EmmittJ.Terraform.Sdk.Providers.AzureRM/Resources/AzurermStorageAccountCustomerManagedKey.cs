using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermStorageAccountCustomerManagedKeyTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

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
    [TerraformArgument("federated_identity_client_id")]
    public TerraformValue<string>? FederatedIdentityClientId
    {
        get => new TerraformReference<string>(this, "federated_identity_client_id");
        set => SetArgument("federated_identity_client_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The key_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyName is required")]
    [TerraformArgument("key_name")]
    public required TerraformValue<string> KeyName
    {
        get => new TerraformReference<string>(this, "key_name");
        set => SetArgument("key_name", value);
    }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [TerraformArgument("key_vault_id")]
    public TerraformValue<string>? KeyVaultId
    {
        get => new TerraformReference<string>(this, "key_vault_id");
        set => SetArgument("key_vault_id", value);
    }

    /// <summary>
    /// The key_vault_uri attribute.
    /// </summary>
    [TerraformArgument("key_vault_uri")]
    public TerraformValue<string> KeyVaultUri
    {
        get => new TerraformReference<string>(this, "key_vault_uri");
        set => SetArgument("key_vault_uri", value);
    }

    /// <summary>
    /// The key_version attribute.
    /// </summary>
    [TerraformArgument("key_version")]
    public TerraformValue<string>? KeyVersion
    {
        get => new TerraformReference<string>(this, "key_version");
        set => SetArgument("key_version", value);
    }

    /// <summary>
    /// The managed_hsm_key_id attribute.
    /// </summary>
    [TerraformArgument("managed_hsm_key_id")]
    public TerraformValue<string>? ManagedHsmKeyId
    {
        get => new TerraformReference<string>(this, "managed_hsm_key_id");
        set => SetArgument("managed_hsm_key_id", value);
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountId is required")]
    [TerraformArgument("storage_account_id")]
    public required TerraformValue<string> StorageAccountId
    {
        get => new TerraformReference<string>(this, "storage_account_id");
        set => SetArgument("storage_account_id", value);
    }

    /// <summary>
    /// The user_assigned_identity_id attribute.
    /// </summary>
    [TerraformArgument("user_assigned_identity_id")]
    public TerraformValue<string>? UserAssignedIdentityId
    {
        get => new TerraformReference<string>(this, "user_assigned_identity_id");
        set => SetArgument("user_assigned_identity_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermStorageAccountCustomerManagedKeyTimeoutsBlock Timeouts { get; set; } = new();

}
