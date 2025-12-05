using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermKeyVaultDataSource.
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
        get => GetArgument<TerraformValue<string>>("read");
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
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The access_policy attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> AccessPolicy
        => CreateReference("access_policy");

    /// <summary>
    /// The enable_rbac_authorization attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<bool> EnableRbacAuthorization
        => CreateReference("enable_rbac_authorization");

    /// <summary>
    /// The enabled_for_deployment attribute.
    /// </summary>
    public TerraformValue<bool> EnabledForDeployment
        => CreateReference("enabled_for_deployment");

    /// <summary>
    /// The enabled_for_disk_encryption attribute.
    /// </summary>
    public TerraformValue<bool> EnabledForDiskEncryption
        => CreateReference("enabled_for_disk_encryption");

    /// <summary>
    /// The enabled_for_template_deployment attribute.
    /// </summary>
    public TerraformValue<bool> EnabledForTemplateDeployment
        => CreateReference("enabled_for_template_deployment");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => CreateReference("location");

    /// <summary>
    /// The network_acls attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> NetworkAcls
        => CreateReference("network_acls");

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformValue<bool> PublicNetworkAccessEnabled
        => CreateReference("public_network_access_enabled");

    /// <summary>
    /// The purge_protection_enabled attribute.
    /// </summary>
    public TerraformValue<bool> PurgeProtectionEnabled
        => CreateReference("purge_protection_enabled");

    /// <summary>
    /// The rbac_authorization_enabled attribute.
    /// </summary>
    public TerraformValue<bool> RbacAuthorizationEnabled
        => CreateReference("rbac_authorization_enabled");

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    public TerraformValue<string> SkuName
        => CreateReference("sku_name");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => CreateReference("tags");

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformValue<string> TenantId
        => CreateReference("tenant_id");

    /// <summary>
    /// The vault_uri attribute.
    /// </summary>
    public TerraformValue<string> VaultUri
        => CreateReference("vault_uri");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermKeyVaultDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermKeyVaultDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
