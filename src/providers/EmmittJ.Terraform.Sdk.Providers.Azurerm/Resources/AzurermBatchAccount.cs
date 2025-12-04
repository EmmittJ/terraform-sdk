using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for identity in AzurermBatchAccount.
/// Nesting mode: list
/// </summary>
public class AzurermBatchAccountIdentityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "identity";

    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    public TerraformSet<string>? IdentityIds
    {
        get => GetArgument<TerraformSet<string>>("identity_ids");
        set => SetArgument("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformValue<string> PrincipalId
        => AsReference("principal_id");

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformValue<string> TenantId
        => AsReference("tenant_id");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for key_vault_reference in AzurermBatchAccount.
/// Nesting mode: list
/// </summary>
public class AzurermBatchAccountKeyVaultReferenceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "key_vault_reference";

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    public required TerraformValue<string> Url
    {
        get => GetArgument<TerraformValue<string>>("url");
        set => SetArgument("url", value);
    }

}


/// <summary>
/// Block type for network_profile in AzurermBatchAccount.
/// Nesting mode: list
/// </summary>
public class AzurermBatchAccountNetworkProfileBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_profile";

    /// <summary>
    /// AccountAccess block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AccountAccess block(s) allowed")]
    public TerraformList<AzurermBatchAccountNetworkProfileBlockAccountAccessBlock>? AccountAccess
    {
        get => GetArgument<TerraformList<AzurermBatchAccountNetworkProfileBlockAccountAccessBlock>>("account_access");
        set => SetArgument("account_access", value);
    }

    /// <summary>
    /// NodeManagementAccess block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodeManagementAccess block(s) allowed")]
    public TerraformList<AzurermBatchAccountNetworkProfileBlockNodeManagementAccessBlock>? NodeManagementAccess
    {
        get => GetArgument<TerraformList<AzurermBatchAccountNetworkProfileBlockNodeManagementAccessBlock>>("node_management_access");
        set => SetArgument("node_management_access", value);
    }

}

/// <summary>
/// Block type for account_access in AzurermBatchAccountNetworkProfileBlock.
/// Nesting mode: list
/// </summary>
public class AzurermBatchAccountNetworkProfileBlockAccountAccessBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "account_access";

    /// <summary>
    /// The default_action attribute.
    /// </summary>
    public TerraformValue<string>? DefaultAction
    {
        get => GetArgument<TerraformValue<string>>("default_action");
        set => SetArgument("default_action", value);
    }

    /// <summary>
    /// IpRule block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermBatchAccountNetworkProfileBlockAccountAccessBlockIpRuleBlock>? IpRule
    {
        get => GetArgument<TerraformList<AzurermBatchAccountNetworkProfileBlockAccountAccessBlockIpRuleBlock>>("ip_rule");
        set => SetArgument("ip_rule", value);
    }

}

/// <summary>
/// Block type for ip_rule in AzurermBatchAccountNetworkProfileBlockAccountAccessBlock.
/// Nesting mode: list
/// </summary>
public class AzurermBatchAccountNetworkProfileBlockAccountAccessBlockIpRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ip_rule";

    /// <summary>
    /// The action attribute.
    /// </summary>
    public TerraformValue<string>? Action
    {
        get => GetArgument<TerraformValue<string>>("action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// The ip_range attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpRange is required")]
    public required TerraformValue<string> IpRange
    {
        get => GetArgument<TerraformValue<string>>("ip_range");
        set => SetArgument("ip_range", value);
    }

}

/// <summary>
/// Block type for node_management_access in AzurermBatchAccountNetworkProfileBlock.
/// Nesting mode: list
/// </summary>
public class AzurermBatchAccountNetworkProfileBlockNodeManagementAccessBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "node_management_access";

    /// <summary>
    /// The default_action attribute.
    /// </summary>
    public TerraformValue<string>? DefaultAction
    {
        get => GetArgument<TerraformValue<string>>("default_action");
        set => SetArgument("default_action", value);
    }

    /// <summary>
    /// IpRule block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermBatchAccountNetworkProfileBlockNodeManagementAccessBlockIpRuleBlock>? IpRule
    {
        get => GetArgument<TerraformList<AzurermBatchAccountNetworkProfileBlockNodeManagementAccessBlockIpRuleBlock>>("ip_rule");
        set => SetArgument("ip_rule", value);
    }

}

/// <summary>
/// Block type for ip_rule in AzurermBatchAccountNetworkProfileBlockNodeManagementAccessBlock.
/// Nesting mode: list
/// </summary>
public class AzurermBatchAccountNetworkProfileBlockNodeManagementAccessBlockIpRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ip_rule";

    /// <summary>
    /// The action attribute.
    /// </summary>
    public TerraformValue<string>? Action
    {
        get => GetArgument<TerraformValue<string>>("action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// The ip_range attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpRange is required")]
    public required TerraformValue<string> IpRange
    {
        get => GetArgument<TerraformValue<string>>("ip_range");
        set => SetArgument("ip_range", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermBatchAccount.
/// Nesting mode: single
/// </summary>
public class AzurermBatchAccountTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_batch_account Terraform resource.
/// Manages a azurerm_batch_account resource.
/// </summary>
public partial class AzurermBatchAccount(string name) : TerraformResource("azurerm_batch_account", name)
{
    /// <summary>
    /// The allowed_authentication_modes attribute.
    /// </summary>
    public TerraformSet<string>? AllowedAuthenticationModes
    {
        get => GetArgument<TerraformSet<string>>("allowed_authentication_modes");
        set => SetArgument("allowed_authentication_modes", value);
    }

    /// <summary>
    /// The encryption attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>>? Encryption
    {
        get => GetArgument<TerraformList<TerraformMap<object>>>("encryption");
        set => SetArgument("encryption", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The pool_allocation_mode attribute.
    /// </summary>
    public TerraformValue<string>? PoolAllocationMode
    {
        get => GetArgument<TerraformValue<string>>("pool_allocation_mode");
        set => SetArgument("pool_allocation_mode", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? PublicNetworkAccessEnabled
    {
        get => GetArgument<TerraformValue<bool>>("public_network_access_enabled");
        set => SetArgument("public_network_access_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The storage_account_authentication_mode attribute.
    /// </summary>
    public TerraformValue<string>? StorageAccountAuthenticationMode
    {
        get => GetArgument<TerraformValue<string>>("storage_account_authentication_mode");
        set => SetArgument("storage_account_authentication_mode", value);
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    public TerraformValue<string>? StorageAccountId
    {
        get => GetArgument<TerraformValue<string>>("storage_account_id");
        set => SetArgument("storage_account_id", value);
    }

    /// <summary>
    /// The storage_account_node_identity attribute.
    /// </summary>
    public TerraformValue<string>? StorageAccountNodeIdentity
    {
        get => GetArgument<TerraformValue<string>>("storage_account_node_identity");
        set => SetArgument("storage_account_node_identity", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The account_endpoint attribute.
    /// </summary>
    public TerraformValue<string> AccountEndpoint
        => AsReference("account_endpoint");

    /// <summary>
    /// The primary_access_key attribute.
    /// </summary>
    public TerraformValue<string> PrimaryAccessKey
        => AsReference("primary_access_key");

    /// <summary>
    /// The secondary_access_key attribute.
    /// </summary>
    public TerraformValue<string> SecondaryAccessKey
        => AsReference("secondary_access_key");

    /// <summary>
    /// Identity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public TerraformList<AzurermBatchAccountIdentityBlock>? Identity
    {
        get => GetArgument<TerraformList<AzurermBatchAccountIdentityBlock>>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// KeyVaultReference block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KeyVaultReference block(s) allowed")]
    public TerraformList<AzurermBatchAccountKeyVaultReferenceBlock>? KeyVaultReference
    {
        get => GetArgument<TerraformList<AzurermBatchAccountKeyVaultReferenceBlock>>("key_vault_reference");
        set => SetArgument("key_vault_reference", value);
    }

    /// <summary>
    /// NetworkProfile block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkProfile block(s) allowed")]
    public TerraformList<AzurermBatchAccountNetworkProfileBlock>? NetworkProfile
    {
        get => GetArgument<TerraformList<AzurermBatchAccountNetworkProfileBlock>>("network_profile");
        set => SetArgument("network_profile", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermBatchAccountTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermBatchAccountTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
