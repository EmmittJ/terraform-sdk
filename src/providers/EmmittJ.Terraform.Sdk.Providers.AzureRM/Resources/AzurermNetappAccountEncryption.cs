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
public class AzurermNetappAccountEncryptionTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_netapp_account_encryption resource.
/// </summary>
public class AzurermNetappAccountEncryption : TerraformResource
{
    public AzurermNetappAccountEncryption(string name) : base("azurerm_netapp_account_encryption", name)
    {
    }

    /// <summary>
    /// The full resource ID of the cross-tenant key vault. Required when using federated_client_id for cross-tenant scenarios.
    /// </summary>
    [TerraformArgument("cross_tenant_key_vault_resource_id")]
    public TerraformValue<string>? CrossTenantKeyVaultResourceId
    {
        get => new TerraformReference<string>(this, "cross_tenant_key_vault_resource_id");
        set => SetArgument("cross_tenant_key_vault_resource_id", value);
    }

    /// <summary>
    /// The versionless encryption key url.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EncryptionKey is required")]
    [TerraformArgument("encryption_key")]
    public required TerraformValue<string> EncryptionKey
    {
        get => new TerraformReference<string>(this, "encryption_key");
        set => SetArgument("encryption_key", value);
    }

    /// <summary>
    /// The Client ID of the multi-tenant Entra ID application used to access cross-tenant key vaults.
    /// </summary>
    [TerraformArgument("federated_client_id")]
    public TerraformValue<string>? FederatedClientId
    {
        get => new TerraformReference<string>(this, "federated_client_id");
        set => SetArgument("federated_client_id", value);
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
    /// The ID of the NetApp Account where encryption will be set.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetappAccountId is required")]
    [TerraformArgument("netapp_account_id")]
    public required TerraformValue<string> NetappAccountId
    {
        get => new TerraformReference<string>(this, "netapp_account_id");
        set => SetArgument("netapp_account_id", value);
    }

    /// <summary>
    /// The Principal ID of the System Assigned Identity to use for encryption.
    /// </summary>
    [TerraformArgument("system_assigned_identity_principal_id")]
    public TerraformValue<string>? SystemAssignedIdentityPrincipalId
    {
        get => new TerraformReference<string>(this, "system_assigned_identity_principal_id");
        set => SetArgument("system_assigned_identity_principal_id", value);
    }

    /// <summary>
    /// The resource ID of the User Assigned Identity to use for encryption.
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
    public AzurermNetappAccountEncryptionTimeoutsBlock Timeouts { get; set; } = new();

}
