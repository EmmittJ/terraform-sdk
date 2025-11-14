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
public class AzurermKeyVaultDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_key_vault.
/// </summary>
public class AzurermKeyVaultDataSource : TerraformDataSource
{
    public AzurermKeyVaultDataSource(string name) : base("azurerm_key_vault", name)
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermKeyVaultDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The access_policy attribute.
    /// </summary>
    [TerraformArgument("access_policy")]
    public TerraformList<object> AccessPolicy
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "access_policy").ResolveNodes(ctx));
    }

    /// <summary>
    /// The enable_rbac_authorization attribute.
    /// </summary>
    [TerraformArgument("enable_rbac_authorization")]
    public TerraformValue<bool> EnableRbacAuthorization
    {
        get => new TerraformReference<bool>(this, "enable_rbac_authorization");
    }

    /// <summary>
    /// The enabled_for_deployment attribute.
    /// </summary>
    [TerraformArgument("enabled_for_deployment")]
    public TerraformValue<bool> EnabledForDeployment
    {
        get => new TerraformReference<bool>(this, "enabled_for_deployment");
    }

    /// <summary>
    /// The enabled_for_disk_encryption attribute.
    /// </summary>
    [TerraformArgument("enabled_for_disk_encryption")]
    public TerraformValue<bool> EnabledForDiskEncryption
    {
        get => new TerraformReference<bool>(this, "enabled_for_disk_encryption");
    }

    /// <summary>
    /// The enabled_for_template_deployment attribute.
    /// </summary>
    [TerraformArgument("enabled_for_template_deployment")]
    public TerraformValue<bool> EnabledForTemplateDeployment
    {
        get => new TerraformReference<bool>(this, "enabled_for_template_deployment");
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformArgument("location")]
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The network_acls attribute.
    /// </summary>
    [TerraformArgument("network_acls")]
    public TerraformList<object> NetworkAcls
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "network_acls").ResolveNodes(ctx));
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformArgument("public_network_access_enabled")]
    public TerraformValue<bool> PublicNetworkAccessEnabled
    {
        get => new TerraformReference<bool>(this, "public_network_access_enabled");
    }

    /// <summary>
    /// The purge_protection_enabled attribute.
    /// </summary>
    [TerraformArgument("purge_protection_enabled")]
    public TerraformValue<bool> PurgeProtectionEnabled
    {
        get => new TerraformReference<bool>(this, "purge_protection_enabled");
    }

    /// <summary>
    /// The rbac_authorization_enabled attribute.
    /// </summary>
    [TerraformArgument("rbac_authorization_enabled")]
    public TerraformValue<bool> RbacAuthorizationEnabled
    {
        get => new TerraformReference<bool>(this, "rbac_authorization_enabled");
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [TerraformArgument("sku_name")]
    public TerraformValue<string> SkuName
    {
        get => new TerraformReference<string>(this, "sku_name");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [TerraformArgument("tenant_id")]
    public TerraformValue<string> TenantId
    {
        get => new TerraformReference<string>(this, "tenant_id");
    }

    /// <summary>
    /// The vault_uri attribute.
    /// </summary>
    [TerraformArgument("vault_uri")]
    public TerraformValue<string> VaultUri
    {
        get => new TerraformReference<string>(this, "vault_uri");
    }

}
