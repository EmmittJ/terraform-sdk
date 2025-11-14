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
/// Block type for encryption_key in .
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
    [TerraformArgument("key_url")]
    public required TerraformValue<string> KeyUrl
    {
        get => new TerraformReference<string>(this, "key_url");
        set => SetArgument("key_url", value);
    }

    /// <summary>
    /// The source_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceVaultId is required")]
    [TerraformArgument("source_vault_id")]
    public required TerraformValue<string> SourceVaultId
    {
        get => new TerraformReference<string>(this, "source_vault_id");
        set => SetArgument("source_vault_id", value);
    }

}

/// <summary>
/// Block type for hsm_setting in .
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
    [TerraformArgument("container_id")]
    public required TerraformValue<string> ContainerId
    {
        get => new TerraformReference<string>(this, "container_id");
        set => SetArgument("container_id", value);
    }

    /// <summary>
    /// The import_prefix attribute.
    /// </summary>
    [TerraformArgument("import_prefix")]
    public TerraformValue<string>? ImportPrefix
    {
        get => new TerraformReference<string>(this, "import_prefix");
        set => SetArgument("import_prefix", value);
    }

    /// <summary>
    /// The logging_container_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoggingContainerId is required")]
    [TerraformArgument("logging_container_id")]
    public required TerraformValue<string> LoggingContainerId
    {
        get => new TerraformReference<string>(this, "logging_container_id");
        set => SetArgument("logging_container_id", value);
    }

}

/// <summary>
/// Block type for identity in .
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
    [TerraformArgument("identity_ids")]
    public required TerraformSet<string> IdentityIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "identity_ids").ResolveNodes(ctx));
        set => SetArgument("identity_ids", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformArgument("type")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for maintenance_window in .
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
    [TerraformArgument("day_of_week")]
    public required TerraformValue<string> DayOfWeek
    {
        get => new TerraformReference<string>(this, "day_of_week");
        set => SetArgument("day_of_week", value);
    }

    /// <summary>
    /// The time_of_day_in_utc attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeOfDayInUtc is required")]
    [TerraformArgument("time_of_day_in_utc")]
    public required TerraformValue<string> TimeOfDayInUtc
    {
        get => new TerraformReference<string>(this, "time_of_day_in_utc");
        set => SetArgument("time_of_day_in_utc", value);
    }

}

/// <summary>
/// Block type for root_squash in .
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
    [TerraformArgument("mode")]
    public required TerraformValue<string> Mode
    {
        get => new TerraformReference<string>(this, "mode");
        set => SetArgument("mode", value);
    }

    /// <summary>
    /// The no_squash_nids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NoSquashNids is required")]
    [TerraformArgument("no_squash_nids")]
    public required TerraformValue<string> NoSquashNids
    {
        get => new TerraformReference<string>(this, "no_squash_nids");
        set => SetArgument("no_squash_nids", value);
    }

    /// <summary>
    /// The squash_gid attribute.
    /// </summary>
    [TerraformArgument("squash_gid")]
    public TerraformValue<double>? SquashGid
    {
        get => new TerraformReference<double>(this, "squash_gid");
        set => SetArgument("squash_gid", value);
    }

    /// <summary>
    /// The squash_uid attribute.
    /// </summary>
    [TerraformArgument("squash_uid")]
    public TerraformValue<double>? SquashUid
    {
        get => new TerraformReference<double>(this, "squash_uid");
        set => SetArgument("squash_uid", value);
    }

}

/// <summary>
/// Block type for timeouts in .
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
/// Manages a azurerm_managed_lustre_file_system resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermManagedLustreFileSystem : TerraformResource
{
    public AzurermManagedLustreFileSystem(string name) : base("azurerm_managed_lustre_file_system", name)
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
    /// The storage_capacity_in_tb attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageCapacityInTb is required")]
    [TerraformArgument("storage_capacity_in_tb")]
    public required TerraformValue<double> StorageCapacityInTb
    {
        get => new TerraformReference<double>(this, "storage_capacity_in_tb");
        set => SetArgument("storage_capacity_in_tb", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    [TerraformArgument("subnet_id")]
    public required TerraformValue<string> SubnetId
    {
        get => new TerraformReference<string>(this, "subnet_id");
        set => SetArgument("subnet_id", value);
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
    /// The zones attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Zones is required")]
    [TerraformArgument("zones")]
    public required TerraformSet<string> Zones
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "zones").ResolveNodes(ctx));
        set => SetArgument("zones", value);
    }

    /// <summary>
    /// Block for encryption_key.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionKey block(s) allowed")]
    [TerraformArgument("encryption_key")]
    public TerraformList<AzurermManagedLustreFileSystemEncryptionKeyBlock> EncryptionKey { get; set; } = new();

    /// <summary>
    /// Block for hsm_setting.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HsmSetting block(s) allowed")]
    [TerraformArgument("hsm_setting")]
    public TerraformList<AzurermManagedLustreFileSystemHsmSettingBlock> HsmSetting { get; set; } = new();

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformArgument("identity")]
    public TerraformList<AzurermManagedLustreFileSystemIdentityBlock> Identity { get; set; } = new();

    /// <summary>
    /// Block for maintenance_window.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaintenanceWindow is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 MaintenanceWindow block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceWindow block(s) allowed")]
    [TerraformArgument("maintenance_window")]
    public required TerraformList<AzurermManagedLustreFileSystemMaintenanceWindowBlock> MaintenanceWindow { get; set; } = new();

    /// <summary>
    /// Block for root_squash.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RootSquash block(s) allowed")]
    [TerraformArgument("root_squash")]
    public TerraformList<AzurermManagedLustreFileSystemRootSquashBlock> RootSquash { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermManagedLustreFileSystemTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The mgs_address attribute.
    /// </summary>
    [TerraformArgument("mgs_address")]
    public TerraformValue<string> MgsAddress
    {
        get => new TerraformReference<string>(this, "mgs_address");
    }

}
