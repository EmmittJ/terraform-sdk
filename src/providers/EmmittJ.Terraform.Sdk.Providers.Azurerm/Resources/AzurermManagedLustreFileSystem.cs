using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for encryption_key in AzurermManagedLustreFileSystem.
/// Nesting mode: list
/// </summary>
public class AzurermManagedLustreFileSystemEncryptionKeyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "encryption_key";

    /// <summary>
    /// The key_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyUrl is required")]
    public required TerraformValue<string> KeyUrl
    {
        get => GetRequiredArgument<TerraformValue<string>>("key_url");
        set => SetArgument("key_url", value);
    }

    /// <summary>
    /// The source_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceVaultId is required")]
    public required TerraformValue<string> SourceVaultId
    {
        get => GetRequiredArgument<TerraformValue<string>>("source_vault_id");
        set => SetArgument("source_vault_id", value);
    }

}


/// <summary>
/// Block type for hsm_setting in AzurermManagedLustreFileSystem.
/// Nesting mode: list
/// </summary>
public class AzurermManagedLustreFileSystemHsmSettingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "hsm_setting";

    /// <summary>
    /// The container_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerId is required")]
    public required TerraformValue<string> ContainerId
    {
        get => GetRequiredArgument<TerraformValue<string>>("container_id");
        set => SetArgument("container_id", value);
    }

    /// <summary>
    /// The import_prefix attribute.
    /// </summary>
    public TerraformValue<string>? ImportPrefix
    {
        get => GetArgument<TerraformValue<string>>("import_prefix");
        set => SetArgument("import_prefix", value);
    }

    /// <summary>
    /// The logging_container_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoggingContainerId is required")]
    public required TerraformValue<string> LoggingContainerId
    {
        get => GetRequiredArgument<TerraformValue<string>>("logging_container_id");
        set => SetArgument("logging_container_id", value);
    }

}


/// <summary>
/// Block type for identity in AzurermManagedLustreFileSystem.
/// Nesting mode: list
/// </summary>
public class AzurermManagedLustreFileSystemIdentityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "identity";

    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityIds is required")]
    public required TerraformSet<string> IdentityIds
    {
        get => GetRequiredArgument<TerraformSet<string>>("identity_ids");
        set => SetArgument("identity_ids", value);
    }

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
/// Block type for maintenance_window in AzurermManagedLustreFileSystem.
/// Nesting mode: list
/// </summary>
public class AzurermManagedLustreFileSystemMaintenanceWindowBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "maintenance_window";

    /// <summary>
    /// The day_of_week attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DayOfWeek is required")]
    public required TerraformValue<string> DayOfWeek
    {
        get => GetRequiredArgument<TerraformValue<string>>("day_of_week");
        set => SetArgument("day_of_week", value);
    }

    /// <summary>
    /// The time_of_day_in_utc attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeOfDayInUtc is required")]
    public required TerraformValue<string> TimeOfDayInUtc
    {
        get => GetRequiredArgument<TerraformValue<string>>("time_of_day_in_utc");
        set => SetArgument("time_of_day_in_utc", value);
    }

}


/// <summary>
/// Block type for root_squash in AzurermManagedLustreFileSystem.
/// Nesting mode: list
/// </summary>
public class AzurermManagedLustreFileSystemRootSquashBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "root_squash";

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    public required TerraformValue<string> Mode
    {
        get => GetRequiredArgument<TerraformValue<string>>("mode");
        set => SetArgument("mode", value);
    }

    /// <summary>
    /// The no_squash_nids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NoSquashNids is required")]
    public required TerraformValue<string> NoSquashNids
    {
        get => GetRequiredArgument<TerraformValue<string>>("no_squash_nids");
        set => SetArgument("no_squash_nids", value);
    }

    /// <summary>
    /// The squash_gid attribute.
    /// </summary>
    public TerraformValue<double>? SquashGid
    {
        get => GetArgument<TerraformValue<double>>("squash_gid");
        set => SetArgument("squash_gid", value);
    }

    /// <summary>
    /// The squash_uid attribute.
    /// </summary>
    public TerraformValue<double>? SquashUid
    {
        get => GetArgument<TerraformValue<double>>("squash_uid");
        set => SetArgument("squash_uid", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermManagedLustreFileSystem.
/// Nesting mode: single
/// </summary>
public class AzurermManagedLustreFileSystemTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_managed_lustre_file_system Terraform resource.
/// Manages a azurerm_managed_lustre_file_system resource.
/// </summary>
public partial class AzurermManagedLustreFileSystem(string name) : TerraformResource("azurerm_managed_lustre_file_system", name)
{
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
    /// The storage_capacity_in_tb attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageCapacityInTb is required")]
    public required TerraformValue<double> StorageCapacityInTb
    {
        get => GetRequiredArgument<TerraformValue<double>>("storage_capacity_in_tb");
        set => SetArgument("storage_capacity_in_tb", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformValue<string> SubnetId
    {
        get => GetRequiredArgument<TerraformValue<string>>("subnet_id");
        set => SetArgument("subnet_id", value);
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
    /// The zones attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Zones is required")]
    public required TerraformSet<string> Zones
    {
        get => GetRequiredArgument<TerraformSet<string>>("zones");
        set => SetArgument("zones", value);
    }

    /// <summary>
    /// The mgs_address attribute.
    /// </summary>
    public TerraformValue<string> MgsAddress
        => AsReference("mgs_address");

    /// <summary>
    /// EncryptionKey block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionKey block(s) allowed")]
    public TerraformList<AzurermManagedLustreFileSystemEncryptionKeyBlock>? EncryptionKey
    {
        get => GetArgument<TerraformList<AzurermManagedLustreFileSystemEncryptionKeyBlock>>("encryption_key");
        set => SetArgument("encryption_key", value);
    }

    /// <summary>
    /// HsmSetting block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HsmSetting block(s) allowed")]
    public TerraformList<AzurermManagedLustreFileSystemHsmSettingBlock>? HsmSetting
    {
        get => GetArgument<TerraformList<AzurermManagedLustreFileSystemHsmSettingBlock>>("hsm_setting");
        set => SetArgument("hsm_setting", value);
    }

    /// <summary>
    /// Identity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public TerraformList<AzurermManagedLustreFileSystemIdentityBlock>? Identity
    {
        get => GetArgument<TerraformList<AzurermManagedLustreFileSystemIdentityBlock>>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// MaintenanceWindow block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaintenanceWindow is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 MaintenanceWindow block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceWindow block(s) allowed")]
    public required TerraformList<AzurermManagedLustreFileSystemMaintenanceWindowBlock> MaintenanceWindow
    {
        get => GetRequiredArgument<TerraformList<AzurermManagedLustreFileSystemMaintenanceWindowBlock>>("maintenance_window");
        set => SetArgument("maintenance_window", value);
    }

    /// <summary>
    /// RootSquash block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RootSquash block(s) allowed")]
    public TerraformList<AzurermManagedLustreFileSystemRootSquashBlock>? RootSquash
    {
        get => GetArgument<TerraformList<AzurermManagedLustreFileSystemRootSquashBlock>>("root_squash");
        set => SetArgument("root_squash", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermManagedLustreFileSystemTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermManagedLustreFileSystemTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
