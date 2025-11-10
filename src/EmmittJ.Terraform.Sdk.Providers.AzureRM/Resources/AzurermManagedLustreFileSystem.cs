using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for encryption_key in .
/// Nesting mode: list
/// </summary>
public class AzurermManagedLustreFileSystemEncryptionKeyBlock : TerraformBlock
{
    /// <summary>
    /// The key_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyUrl is required")]
    public required TerraformProperty<string> KeyUrl
    {
        get => GetProperty<TerraformProperty<string>>("key_url");
        set => WithProperty("key_url", value);
    }

    /// <summary>
    /// The source_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceVaultId is required")]
    public required TerraformProperty<string> SourceVaultId
    {
        get => GetProperty<TerraformProperty<string>>("source_vault_id");
        set => WithProperty("source_vault_id", value);
    }

}

/// <summary>
/// Block type for hsm_setting in .
/// Nesting mode: list
/// </summary>
public class AzurermManagedLustreFileSystemHsmSettingBlock : TerraformBlock
{
    /// <summary>
    /// The container_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerId is required")]
    public required TerraformProperty<string> ContainerId
    {
        get => GetProperty<TerraformProperty<string>>("container_id");
        set => WithProperty("container_id", value);
    }

    /// <summary>
    /// The import_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? ImportPrefix
    {
        get => GetProperty<TerraformProperty<string>>("import_prefix");
        set => WithProperty("import_prefix", value);
    }

    /// <summary>
    /// The logging_container_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoggingContainerId is required")]
    public required TerraformProperty<string> LoggingContainerId
    {
        get => GetProperty<TerraformProperty<string>>("logging_container_id");
        set => WithProperty("logging_container_id", value);
    }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermManagedLustreFileSystemIdentityBlock : TerraformBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityIds is required")]
    public HashSet<TerraformProperty<string>>? IdentityIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("identity_ids");
        set => WithProperty("identity_ids", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for maintenance_window in .
/// Nesting mode: list
/// </summary>
public class AzurermManagedLustreFileSystemMaintenanceWindowBlock : TerraformBlock
{
    /// <summary>
    /// The day_of_week attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DayOfWeek is required")]
    public required TerraformProperty<string> DayOfWeek
    {
        get => GetProperty<TerraformProperty<string>>("day_of_week");
        set => WithProperty("day_of_week", value);
    }

    /// <summary>
    /// The time_of_day_in_utc attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeOfDayInUtc is required")]
    public required TerraformProperty<string> TimeOfDayInUtc
    {
        get => GetProperty<TerraformProperty<string>>("time_of_day_in_utc");
        set => WithProperty("time_of_day_in_utc", value);
    }

}

/// <summary>
/// Block type for root_squash in .
/// Nesting mode: list
/// </summary>
public class AzurermManagedLustreFileSystemRootSquashBlock : TerraformBlock
{
    /// <summary>
    /// The mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    public required TerraformProperty<string> Mode
    {
        get => GetProperty<TerraformProperty<string>>("mode");
        set => WithProperty("mode", value);
    }

    /// <summary>
    /// The no_squash_nids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NoSquashNids is required")]
    public required TerraformProperty<string> NoSquashNids
    {
        get => GetProperty<TerraformProperty<string>>("no_squash_nids");
        set => WithProperty("no_squash_nids", value);
    }

    /// <summary>
    /// The squash_gid attribute.
    /// </summary>
    public TerraformProperty<double>? SquashGid
    {
        get => GetProperty<TerraformProperty<double>>("squash_gid");
        set => WithProperty("squash_gid", value);
    }

    /// <summary>
    /// The squash_uid attribute.
    /// </summary>
    public TerraformProperty<double>? SquashUid
    {
        get => GetProperty<TerraformProperty<double>>("squash_uid");
        set => WithProperty("squash_uid", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermManagedLustreFileSystemTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_managed_lustre_file_system resource.
/// </summary>
public class AzurermManagedLustreFileSystem : TerraformResource
{
    public AzurermManagedLustreFileSystem(string name) : base("azurerm_managed_lustre_file_system", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("mgs_address");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SkuName is required")]
    public required TerraformProperty<string> SkuName
    {
        get => GetProperty<TerraformProperty<string>>("sku_name");
        set => this.WithProperty("sku_name", value);
    }

    /// <summary>
    /// The storage_capacity_in_tb attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageCapacityInTb is required")]
    public required TerraformProperty<double> StorageCapacityInTb
    {
        get => GetProperty<TerraformProperty<double>>("storage_capacity_in_tb");
        set => this.WithProperty("storage_capacity_in_tb", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformProperty<string> SubnetId
    {
        get => GetProperty<TerraformProperty<string>>("subnet_id");
        set => this.WithProperty("subnet_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Zones is required")]
    public HashSet<TerraformProperty<string>>? Zones
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("zones");
        set => this.WithProperty("zones", value);
    }

    /// <summary>
    /// Block for encryption_key.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionKey block(s) allowed")]
    public List<AzurermManagedLustreFileSystemEncryptionKeyBlock>? EncryptionKey
    {
        get => GetProperty<List<AzurermManagedLustreFileSystemEncryptionKeyBlock>>("encryption_key");
        set => this.WithProperty("encryption_key", value);
    }

    /// <summary>
    /// Block for hsm_setting.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HsmSetting block(s) allowed")]
    public List<AzurermManagedLustreFileSystemHsmSettingBlock>? HsmSetting
    {
        get => GetProperty<List<AzurermManagedLustreFileSystemHsmSettingBlock>>("hsm_setting");
        set => this.WithProperty("hsm_setting", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermManagedLustreFileSystemIdentityBlock>? Identity
    {
        get => GetProperty<List<AzurermManagedLustreFileSystemIdentityBlock>>("identity");
        set => this.WithProperty("identity", value);
    }

    /// <summary>
    /// Block for maintenance_window.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 MaintenanceWindow block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceWindow block(s) allowed")]
    public List<AzurermManagedLustreFileSystemMaintenanceWindowBlock>? MaintenanceWindow
    {
        get => GetProperty<List<AzurermManagedLustreFileSystemMaintenanceWindowBlock>>("maintenance_window");
        set => this.WithProperty("maintenance_window", value);
    }

    /// <summary>
    /// Block for root_squash.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RootSquash block(s) allowed")]
    public List<AzurermManagedLustreFileSystemRootSquashBlock>? RootSquash
    {
        get => GetProperty<List<AzurermManagedLustreFileSystemRootSquashBlock>>("root_squash");
        set => this.WithProperty("root_squash", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermManagedLustreFileSystemTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermManagedLustreFileSystemTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The mgs_address attribute.
    /// </summary>
    public TerraformExpression MgsAddress => this["mgs_address"];

}
