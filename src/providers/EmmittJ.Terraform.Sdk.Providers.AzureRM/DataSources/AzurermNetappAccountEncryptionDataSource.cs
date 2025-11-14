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
public class AzurermNetappAccountEncryptionDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_netapp_account_encryption.
/// </summary>
public class AzurermNetappAccountEncryptionDataSource : TerraformDataSource
{
    public AzurermNetappAccountEncryptionDataSource(string name) : base("azurerm_netapp_account_encryption", name)
    {
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermNetappAccountEncryptionDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The cross_tenant_key_vault_resource_id attribute.
    /// </summary>
    [TerraformArgument("cross_tenant_key_vault_resource_id")]
    public TerraformValue<string> CrossTenantKeyVaultResourceId
    {
        get => new TerraformReference<string>(this, "cross_tenant_key_vault_resource_id");
    }

    /// <summary>
    /// The encryption_key attribute.
    /// </summary>
    [TerraformArgument("encryption_key")]
    public TerraformValue<string> EncryptionKey
    {
        get => new TerraformReference<string>(this, "encryption_key");
    }

    /// <summary>
    /// The federated_client_id attribute.
    /// </summary>
    [TerraformArgument("federated_client_id")]
    public TerraformValue<string> FederatedClientId
    {
        get => new TerraformReference<string>(this, "federated_client_id");
    }

    /// <summary>
    /// The system_assigned_identity_principal_id attribute.
    /// </summary>
    [TerraformArgument("system_assigned_identity_principal_id")]
    public TerraformValue<string> SystemAssignedIdentityPrincipalId
    {
        get => new TerraformReference<string>(this, "system_assigned_identity_principal_id");
    }

    /// <summary>
    /// The user_assigned_identity_id attribute.
    /// </summary>
    [TerraformArgument("user_assigned_identity_id")]
    public TerraformValue<string> UserAssignedIdentityId
    {
        get => new TerraformReference<string>(this, "user_assigned_identity_id");
    }

}
