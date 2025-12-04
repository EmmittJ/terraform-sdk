using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for identity in AzurermDataProtectionBackupVault.
/// Nesting mode: list
/// </summary>
public class AzurermDataProtectionBackupVaultIdentityBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermDataProtectionBackupVault.
/// Nesting mode: single
/// </summary>
public class AzurermDataProtectionBackupVaultTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_data_protection_backup_vault Terraform resource.
/// Manages a azurerm_data_protection_backup_vault resource.
/// </summary>
public partial class AzurermDataProtectionBackupVault(string name) : TerraformResource("azurerm_data_protection_backup_vault", name)
{
    /// <summary>
    /// The cross_region_restore_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? CrossRegionRestoreEnabled
    {
        get => GetArgument<TerraformValue<bool>>("cross_region_restore_enabled");
        set => SetArgument("cross_region_restore_enabled", value);
    }

    /// <summary>
    /// The datastore_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatastoreType is required")]
    public required TerraformValue<string> DatastoreType
    {
        get => GetRequiredArgument<TerraformValue<string>>("datastore_type");
        set => SetArgument("datastore_type", value);
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
    /// The immutability attribute.
    /// </summary>
    public TerraformValue<string>? Immutability
    {
        get => GetArgument<TerraformValue<string>>("immutability");
        set => SetArgument("immutability", value);
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
    /// The redundancy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Redundancy is required")]
    public required TerraformValue<string> Redundancy
    {
        get => GetRequiredArgument<TerraformValue<string>>("redundancy");
        set => SetArgument("redundancy", value);
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
    /// The retention_duration_in_days attribute.
    /// </summary>
    public TerraformValue<double>? RetentionDurationInDays
    {
        get => GetArgument<TerraformValue<double>>("retention_duration_in_days");
        set => SetArgument("retention_duration_in_days", value);
    }

    /// <summary>
    /// The soft_delete attribute.
    /// </summary>
    public TerraformValue<string>? SoftDelete
    {
        get => GetArgument<TerraformValue<string>>("soft_delete");
        set => SetArgument("soft_delete", value);
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
    /// Identity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public TerraformList<AzurermDataProtectionBackupVaultIdentityBlock>? Identity
    {
        get => GetArgument<TerraformList<AzurermDataProtectionBackupVaultIdentityBlock>>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermDataProtectionBackupVaultTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermDataProtectionBackupVaultTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
