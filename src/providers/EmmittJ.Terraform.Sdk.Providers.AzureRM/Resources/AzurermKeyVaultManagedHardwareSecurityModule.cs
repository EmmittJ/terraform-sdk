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
    [TerraformArgument("bypass")]
    public required TerraformValue<string> Bypass
    {
        get => new TerraformReference<string>(this, "bypass");
        set => SetArgument("bypass", value);
    }

    /// <summary>
    /// The default_action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultAction is required")]
    [TerraformArgument("default_action")]
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
/// Manages a azurerm_key_vault_managed_hardware_security_module resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermKeyVaultManagedHardwareSecurityModule : TerraformResource
{
    public AzurermKeyVaultManagedHardwareSecurityModule(string name) : base("azurerm_key_vault_managed_hardware_security_module", name)
    {
    }

    /// <summary>
    /// The admin_object_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdminObjectIds is required")]
    [TerraformArgument("admin_object_ids")]
    public required TerraformSet<string> AdminObjectIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "admin_object_ids").ResolveNodes(ctx));
        set => SetArgument("admin_object_ids", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformArgument("location")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformArgument("public_network_access_enabled")]
    public TerraformValue<bool>? PublicNetworkAccessEnabled
    {
        get => new TerraformReference<bool>(this, "public_network_access_enabled");
        set => SetArgument("public_network_access_enabled", value);
    }

    /// <summary>
    /// The purge_protection_enabled attribute.
    /// </summary>
    [TerraformArgument("purge_protection_enabled")]
    public TerraformValue<bool>? PurgeProtectionEnabled
    {
        get => new TerraformReference<bool>(this, "purge_protection_enabled");
        set => SetArgument("purge_protection_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The security_domain_key_vault_certificate_ids attribute.
    /// </summary>
    [TerraformArgument("security_domain_key_vault_certificate_ids")]
    public TerraformList<string>? SecurityDomainKeyVaultCertificateIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "security_domain_key_vault_certificate_ids").ResolveNodes(ctx));
        set => SetArgument("security_domain_key_vault_certificate_ids", value);
    }

    /// <summary>
    /// The security_domain_quorum attribute.
    /// </summary>
    [TerraformArgument("security_domain_quorum")]
    public TerraformValue<double>? SecurityDomainQuorum
    {
        get => new TerraformReference<double>(this, "security_domain_quorum");
        set => SetArgument("security_domain_quorum", value);
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SkuName is required")]
    [TerraformArgument("sku_name")]
    public required TerraformValue<string> SkuName
    {
        get => new TerraformReference<string>(this, "sku_name");
        set => SetArgument("sku_name", value);
    }

    /// <summary>
    /// The soft_delete_retention_days attribute.
    /// </summary>
    [TerraformArgument("soft_delete_retention_days")]
    public TerraformValue<double>? SoftDeleteRetentionDays
    {
        get => new TerraformReference<double>(this, "soft_delete_retention_days");
        set => SetArgument("soft_delete_retention_days", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TenantId is required")]
    [TerraformArgument("tenant_id")]
    public required TerraformValue<string> TenantId
    {
        get => new TerraformReference<string>(this, "tenant_id");
        set => SetArgument("tenant_id", value);
    }

    /// <summary>
    /// Block for network_acls.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkAcls block(s) allowed")]
    [TerraformArgument("network_acls")]
    public TerraformList<AzurermKeyVaultManagedHardwareSecurityModuleNetworkAclsBlock> NetworkAcls { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermKeyVaultManagedHardwareSecurityModuleTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The hsm_uri attribute.
    /// </summary>
    [TerraformArgument("hsm_uri")]
    public TerraformValue<string> HsmUri
    {
        get => new TerraformReference<string>(this, "hsm_uri");
    }

    /// <summary>
    /// The security_domain_encrypted_data attribute.
    /// </summary>
    [TerraformArgument("security_domain_encrypted_data")]
    public TerraformValue<string> SecurityDomainEncryptedData
    {
        get => new TerraformReference<string>(this, "security_domain_encrypted_data");
    }

}
