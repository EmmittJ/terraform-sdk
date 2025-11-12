using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for encryption_key in .
/// Nesting mode: list
/// </summary>
public partial class AzurermManagedLustreFileSystemEncryptionKeyBlock() : TerraformBlock("encryption_key")
{
    /// <summary>
    /// The key_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyUrl is required")]
    [TerraformProperty("key_url")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> KeyUrl { get; set; }

    /// <summary>
    /// The source_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceVaultId is required")]
    [TerraformProperty("source_vault_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SourceVaultId { get; set; }

}

/// <summary>
/// Block type for hsm_setting in .
/// Nesting mode: list
/// </summary>
public partial class AzurermManagedLustreFileSystemHsmSettingBlock() : TerraformBlock("hsm_setting")
{
    /// <summary>
    /// The container_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerId is required")]
    [TerraformProperty("container_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ContainerId { get; set; }

    /// <summary>
    /// The import_prefix attribute.
    /// </summary>
    [TerraformProperty("import_prefix")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ImportPrefix { get; set; }

    /// <summary>
    /// The logging_container_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoggingContainerId is required")]
    [TerraformProperty("logging_container_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> LoggingContainerId { get; set; }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public partial class AzurermManagedLustreFileSystemIdentityBlock() : TerraformBlock("identity")
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityIds is required")]
    [TerraformProperty("identity_ids")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> IdentityIds { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for maintenance_window in .
/// Nesting mode: list
/// </summary>
public partial class AzurermManagedLustreFileSystemMaintenanceWindowBlock() : TerraformBlock("maintenance_window")
{
    /// <summary>
    /// The day_of_week attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DayOfWeek is required")]
    [TerraformProperty("day_of_week")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DayOfWeek { get; set; }

    /// <summary>
    /// The time_of_day_in_utc attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeOfDayInUtc is required")]
    [TerraformProperty("time_of_day_in_utc")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TimeOfDayInUtc { get; set; }

}

/// <summary>
/// Block type for root_squash in .
/// Nesting mode: list
/// </summary>
public partial class AzurermManagedLustreFileSystemRootSquashBlock() : TerraformBlock("root_squash")
{
    /// <summary>
    /// The mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    [TerraformProperty("mode")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Mode { get; set; }

    /// <summary>
    /// The no_squash_nids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NoSquashNids is required")]
    [TerraformProperty("no_squash_nids")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> NoSquashNids { get; set; }

    /// <summary>
    /// The squash_gid attribute.
    /// </summary>
    [TerraformProperty("squash_gid")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? SquashGid { get; set; }

    /// <summary>
    /// The squash_uid attribute.
    /// </summary>
    [TerraformProperty("squash_uid")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? SquashUid { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermManagedLustreFileSystemTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_managed_lustre_file_system resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermManagedLustreFileSystem : TerraformResource
{
    public AzurermManagedLustreFileSystem(string name) : base("azurerm_managed_lustre_file_system", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SkuName is required")]
    [TerraformProperty("sku_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SkuName { get; set; }

    /// <summary>
    /// The storage_capacity_in_tb attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageCapacityInTb is required")]
    [TerraformProperty("storage_capacity_in_tb")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> StorageCapacityInTb { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    [TerraformProperty("subnet_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SubnetId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Zones is required")]
    [TerraformProperty("zones")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> Zones { get; set; }

    /// <summary>
    /// Block for encryption_key.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionKey block(s) allowed")]
    [TerraformProperty("encryption_key")]
    public TerraformList<AzurermManagedLustreFileSystemEncryptionKeyBlock> EncryptionKey { get; set; } = new();

    /// <summary>
    /// Block for hsm_setting.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HsmSetting block(s) allowed")]
    [TerraformProperty("hsm_setting")]
    public TerraformList<AzurermManagedLustreFileSystemHsmSettingBlock> HsmSetting { get; set; } = new();

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformProperty("identity")]
    public TerraformList<AzurermManagedLustreFileSystemIdentityBlock> Identity { get; set; } = new();

    /// <summary>
    /// Block for maintenance_window.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaintenanceWindow is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 MaintenanceWindow block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceWindow block(s) allowed")]
    [TerraformProperty("maintenance_window")]
    public required TerraformList<AzurermManagedLustreFileSystemMaintenanceWindowBlock> MaintenanceWindow { get; set; } = new();

    /// <summary>
    /// Block for root_squash.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RootSquash block(s) allowed")]
    [TerraformProperty("root_squash")]
    public TerraformList<AzurermManagedLustreFileSystemRootSquashBlock> RootSquash { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermManagedLustreFileSystemTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The mgs_address attribute.
    /// </summary>
    [TerraformProperty("mgs_address")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> MgsAddress { get; }

}
