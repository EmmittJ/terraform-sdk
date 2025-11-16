using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermKeyVaultManagedHardwareSecurityModuleDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_key_vault_managed_hardware_security_module Terraform data source.
/// Retrieves information about a azurerm_key_vault_managed_hardware_security_module.
/// </summary>
public partial class AzurermKeyVaultManagedHardwareSecurityModuleDataSource(string name) : TerraformDataSource("azurerm_key_vault_managed_hardware_security_module", name)
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
    /// The admin_object_ids attribute.
    /// </summary>
    public TerraformList<string> AdminObjectIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "admin_object_ids").ResolveNodes(ctx));
    }

    /// <summary>
    /// The hsm_uri attribute.
    /// </summary>
    public TerraformValue<string> HsmUri
    {
        get => new TerraformReference<string>(this, "hsm_uri");
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The purge_protection_enabled attribute.
    /// </summary>
    public TerraformValue<bool> PurgeProtectionEnabled
    {
        get => new TerraformReference<bool>(this, "purge_protection_enabled");
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    public TerraformValue<string> SkuName
    {
        get => new TerraformReference<string>(this, "sku_name");
    }

    /// <summary>
    /// The soft_delete_retention_days attribute.
    /// </summary>
    public TerraformValue<double> SoftDeleteRetentionDays
    {
        get => new TerraformReference<double>(this, "soft_delete_retention_days");
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
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermKeyVaultManagedHardwareSecurityModuleDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermKeyVaultManagedHardwareSecurityModuleDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
