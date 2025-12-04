using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for contact in AzurermKeyVault.
/// Nesting mode: set
/// </summary>
[Obsolete("This block is deprecated.")]
public class AzurermKeyVaultContactBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "contact";

    /// <summary>
    /// The email attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Email is required")]
    public required TerraformValue<string> Email
    {
        get => GetRequiredArgument<TerraformValue<string>>("email");
        set => SetArgument("email", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The phone attribute.
    /// </summary>
    public TerraformValue<string>? Phone
    {
        get => GetArgument<TerraformValue<string>>("phone");
        set => SetArgument("phone", value);
    }

}


/// <summary>
/// Block type for network_acls in AzurermKeyVault.
/// Nesting mode: list
/// </summary>
public class AzurermKeyVaultNetworkAclsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_acls";

    /// <summary>
    /// The bypass attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bypass is required")]
    public required TerraformValue<string> Bypass
    {
        get => GetRequiredArgument<TerraformValue<string>>("bypass");
        set => SetArgument("bypass", value);
    }

    /// <summary>
    /// The default_action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultAction is required")]
    public required TerraformValue<string> DefaultAction
    {
        get => GetRequiredArgument<TerraformValue<string>>("default_action");
        set => SetArgument("default_action", value);
    }

    /// <summary>
    /// The ip_rules attribute.
    /// </summary>
    public TerraformSet<string>? IpRules
    {
        get => GetArgument<TerraformSet<string>>("ip_rules");
        set => SetArgument("ip_rules", value);
    }

    /// <summary>
    /// The virtual_network_subnet_ids attribute.
    /// </summary>
    public TerraformSet<string>? VirtualNetworkSubnetIds
    {
        get => GetArgument<TerraformSet<string>>("virtual_network_subnet_ids");
        set => SetArgument("virtual_network_subnet_ids", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermKeyVault.
/// Nesting mode: single
/// </summary>
public class AzurermKeyVaultTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_key_vault Terraform resource.
/// Manages a azurerm_key_vault resource.
/// </summary>
public partial class AzurermKeyVault(string name) : TerraformResource("azurerm_key_vault", name)
{
    /// <summary>
    /// The access_policy attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> AccessPolicy
    {
        get => GetArgument<TerraformList<TerraformMap<object>>>("access_policy") ?? AsReference("access_policy");
        set => SetArgument("access_policy", value);
    }

    /// <summary>
    /// The enable_rbac_authorization attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<bool> EnableRbacAuthorization
    {
        get => GetArgument<TerraformValue<bool>>("enable_rbac_authorization") ?? AsReference("enable_rbac_authorization");
        set => SetArgument("enable_rbac_authorization", value);
    }

    /// <summary>
    /// The enabled_for_deployment attribute.
    /// </summary>
    public TerraformValue<bool>? EnabledForDeployment
    {
        get => GetArgument<TerraformValue<bool>>("enabled_for_deployment");
        set => SetArgument("enabled_for_deployment", value);
    }

    /// <summary>
    /// The enabled_for_disk_encryption attribute.
    /// </summary>
    public TerraformValue<bool>? EnabledForDiskEncryption
    {
        get => GetArgument<TerraformValue<bool>>("enabled_for_disk_encryption");
        set => SetArgument("enabled_for_disk_encryption", value);
    }

    /// <summary>
    /// The enabled_for_template_deployment attribute.
    /// </summary>
    public TerraformValue<bool>? EnabledForTemplateDeployment
    {
        get => GetArgument<TerraformValue<bool>>("enabled_for_template_deployment");
        set => SetArgument("enabled_for_template_deployment", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
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
    /// The purge_protection_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? PurgeProtectionEnabled
    {
        get => GetArgument<TerraformValue<bool>>("purge_protection_enabled");
        set => SetArgument("purge_protection_enabled", value);
    }

    /// <summary>
    /// The rbac_authorization_enabled attribute.
    /// </summary>
    public TerraformValue<bool> RbacAuthorizationEnabled
    {
        get => GetArgument<TerraformValue<bool>>("rbac_authorization_enabled") ?? AsReference("rbac_authorization_enabled");
        set => SetArgument("rbac_authorization_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SkuName is required")]
    public required TerraformValue<string> SkuName
    {
        get => GetRequiredArgument<TerraformValue<string>>("sku_name");
        set => SetArgument("sku_name", value);
    }

    /// <summary>
    /// The soft_delete_retention_days attribute.
    /// </summary>
    public TerraformValue<double>? SoftDeleteRetentionDays
    {
        get => GetArgument<TerraformValue<double>>("soft_delete_retention_days");
        set => SetArgument("soft_delete_retention_days", value);
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
    /// The tenant_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TenantId is required")]
    public required TerraformValue<string> TenantId
    {
        get => GetRequiredArgument<TerraformValue<string>>("tenant_id");
        set => SetArgument("tenant_id", value);
    }

    /// <summary>
    /// The vault_uri attribute.
    /// </summary>
    public TerraformValue<string> VaultUri
        => AsReference("vault_uri");

    /// <summary>
    /// Contact block (nesting mode: set).
    /// </summary>
    [Obsolete("This block is deprecated.")]
    public TerraformSet<AzurermKeyVaultContactBlock>? Contact
    {
        get => GetArgument<TerraformSet<AzurermKeyVaultContactBlock>>("contact");
        set => SetArgument("contact", value);
    }

    /// <summary>
    /// NetworkAcls block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkAcls block(s) allowed")]
    public TerraformList<AzurermKeyVaultNetworkAclsBlock>? NetworkAcls
    {
        get => GetArgument<TerraformList<AzurermKeyVaultNetworkAclsBlock>>("network_acls");
        set => SetArgument("network_acls", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermKeyVaultTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermKeyVaultTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
