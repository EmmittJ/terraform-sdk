using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for network_acls in .
/// Nesting mode: list
/// </summary>
public class AzurermKeyVaultManagedHardwareSecurityModuleNetworkAclsBlock : TerraformBlock
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

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermKeyVaultManagedHardwareSecurityModuleTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_key_vault_managed_hardware_security_module Terraform resource.
/// Manages a azurerm_key_vault_managed_hardware_security_module resource.
/// </summary>
public partial class AzurermKeyVaultManagedHardwareSecurityModule(string name) : TerraformResource("azurerm_key_vault_managed_hardware_security_module", name)
{
    /// <summary>
    /// The admin_object_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdminObjectIds is required")]
    public required TerraformSet<string> AdminObjectIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "admin_object_ids").ResolveNodes(ctx));
        set => SetArgument("admin_object_ids", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The security_domain_key_vault_certificate_ids attribute.
    /// </summary>
    public TerraformList<string>? SecurityDomainKeyVaultCertificateIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "security_domain_key_vault_certificate_ids").ResolveNodes(ctx));
        set => SetArgument("security_domain_key_vault_certificate_ids", value);
    }

    /// <summary>
    /// The security_domain_quorum attribute.
    /// </summary>
    public TerraformValue<double>? SecurityDomainQuorum
    {
        get => new TerraformReference<double>(this, "security_domain_quorum");
        set => SetArgument("security_domain_quorum", value);
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
    /// The hsm_uri attribute.
    /// </summary>
    public TerraformValue<string> HsmUri
    {
        get => new TerraformReference<string>(this, "hsm_uri");
    }

    /// <summary>
    /// The security_domain_encrypted_data attribute.
    /// </summary>
    public TerraformValue<string> SecurityDomainEncryptedData
    {
        get => new TerraformReference<string>(this, "security_domain_encrypted_data");
    }

    /// <summary>
    /// NetworkAcls block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkAcls block(s) allowed")]
    public TerraformList<AzurermKeyVaultManagedHardwareSecurityModuleNetworkAclsBlock>? NetworkAcls
    {
        get => GetArgument<TerraformList<AzurermKeyVaultManagedHardwareSecurityModuleNetworkAclsBlock>>("network_acls");
        set => SetArgument("network_acls", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermKeyVaultManagedHardwareSecurityModuleTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermKeyVaultManagedHardwareSecurityModuleTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
