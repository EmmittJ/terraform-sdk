using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for contact in .
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
        get => new TerraformReference<string>(this, "email");
        set => SetArgument("email", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The phone attribute.
    /// </summary>
    public TerraformValue<string>? Phone
    {
        get => new TerraformReference<string>(this, "phone");
        set => SetArgument("phone", value);
    }

}

/// <summary>
/// Block type for network_acls in .
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
        get => new TerraformReference<string>(this, "bypass");
        set => SetArgument("bypass", value);
    }

    /// <summary>
    /// The default_action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultAction is required")]
    public required TerraformValue<string> DefaultAction
    {
        get => new TerraformReference<string>(this, "default_action");
        set => SetArgument("default_action", value);
    }

    /// <summary>
    /// The ip_rules attribute.
    /// </summary>
    public TerraformSet<string>? IpRules
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "ip_rules").ResolveNodes(ctx));
        set => SetArgument("ip_rules", value);
    }

    /// <summary>
    /// The virtual_network_subnet_ids attribute.
    /// </summary>
    public TerraformSet<string>? VirtualNetworkSubnetIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "virtual_network_subnet_ids").ResolveNodes(ctx));
        set => SetArgument("virtual_network_subnet_ids", value);
    }

}

/// <summary>
/// Block type for timeouts in .
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
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
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "access_policy").ResolveNodes(ctx));
        set => SetArgument("access_policy", value);
    }

    /// <summary>
    /// The enable_rbac_authorization attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<bool> EnableRbacAuthorization
    {
        get => new TerraformReference<bool>(this, "enable_rbac_authorization");
        set => SetArgument("enable_rbac_authorization", value);
    }

    /// <summary>
    /// The enabled_for_deployment attribute.
    /// </summary>
    public TerraformValue<bool>? EnabledForDeployment
    {
        get => new TerraformReference<bool>(this, "enabled_for_deployment");
        set => SetArgument("enabled_for_deployment", value);
    }

    /// <summary>
    /// The enabled_for_disk_encryption attribute.
    /// </summary>
    public TerraformValue<bool>? EnabledForDiskEncryption
    {
        get => new TerraformReference<bool>(this, "enabled_for_disk_encryption");
        set => SetArgument("enabled_for_disk_encryption", value);
    }

    /// <summary>
    /// The enabled_for_template_deployment attribute.
    /// </summary>
    public TerraformValue<bool>? EnabledForTemplateDeployment
    {
        get => new TerraformReference<bool>(this, "enabled_for_template_deployment");
        set => SetArgument("enabled_for_template_deployment", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? PublicNetworkAccessEnabled
    {
        get => new TerraformReference<bool>(this, "public_network_access_enabled");
        set => SetArgument("public_network_access_enabled", value);
    }

    /// <summary>
    /// The purge_protection_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? PurgeProtectionEnabled
    {
        get => new TerraformReference<bool>(this, "purge_protection_enabled");
        set => SetArgument("purge_protection_enabled", value);
    }

    /// <summary>
    /// The rbac_authorization_enabled attribute.
    /// </summary>
    public TerraformValue<bool> RbacAuthorizationEnabled
    {
        get => new TerraformReference<bool>(this, "rbac_authorization_enabled");
        set => SetArgument("rbac_authorization_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SkuName is required")]
    public required TerraformValue<string> SkuName
    {
        get => new TerraformReference<string>(this, "sku_name");
        set => SetArgument("sku_name", value);
    }

    /// <summary>
    /// The soft_delete_retention_days attribute.
    /// </summary>
    public TerraformValue<double>? SoftDeleteRetentionDays
    {
        get => new TerraformReference<double>(this, "soft_delete_retention_days");
        set => SetArgument("soft_delete_retention_days", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TenantId is required")]
    public required TerraformValue<string> TenantId
    {
        get => new TerraformReference<string>(this, "tenant_id");
        set => SetArgument("tenant_id", value);
    }

    /// <summary>
    /// The vault_uri attribute.
    /// </summary>
    public TerraformValue<string> VaultUri
    {
        get => new TerraformReference<string>(this, "vault_uri");
    }

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
