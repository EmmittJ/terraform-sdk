using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

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
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Represents a azurerm_key_vault Terraform data source.
/// Retrieves information about a azurerm_key_vault.
/// </summary>
public partial class AzurermKeyVaultDataSource(string name) : TerraformDataSource("azurerm_key_vault", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The access_policy attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> AccessPolicy
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "access_policy").ResolveNodes(ctx));
    }

    /// <summary>
    /// The enable_rbac_authorization attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<bool> EnableRbacAuthorization
    {
        get => new TerraformReference<bool>(this, "enable_rbac_authorization");
    }

    /// <summary>
    /// The enabled_for_deployment attribute.
    /// </summary>
    public TerraformValue<bool> EnabledForDeployment
    {
        get => new TerraformReference<bool>(this, "enabled_for_deployment");
    }

    /// <summary>
    /// The enabled_for_disk_encryption attribute.
    /// </summary>
    public TerraformValue<bool> EnabledForDiskEncryption
    {
        get => new TerraformReference<bool>(this, "enabled_for_disk_encryption");
    }

    /// <summary>
    /// The enabled_for_template_deployment attribute.
    /// </summary>
    public TerraformValue<bool> EnabledForTemplateDeployment
    {
        get => new TerraformReference<bool>(this, "enabled_for_template_deployment");
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The network_acls attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> NetworkAcls
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "network_acls").ResolveNodes(ctx));
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformValue<bool> PublicNetworkAccessEnabled
    {
        get => new TerraformReference<bool>(this, "public_network_access_enabled");
    }

    /// <summary>
    /// The purge_protection_enabled attribute.
    /// </summary>
    public TerraformValue<bool> PurgeProtectionEnabled
    {
        get => new TerraformReference<bool>(this, "purge_protection_enabled");
    }

    /// <summary>
    /// The rbac_authorization_enabled attribute.
    /// </summary>
    public TerraformValue<bool> RbacAuthorizationEnabled
    {
        get => new TerraformReference<bool>(this, "rbac_authorization_enabled");
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    public TerraformValue<string> SkuName
    {
        get => new TerraformReference<string>(this, "sku_name");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformValue<string> TenantId
    {
        get => new TerraformReference<string>(this, "tenant_id");
    }

    /// <summary>
    /// The vault_uri attribute.
    /// </summary>
    public TerraformValue<string> VaultUri
    {
        get => new TerraformReference<string>(this, "vault_uri");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermKeyVaultDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermKeyVaultDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
