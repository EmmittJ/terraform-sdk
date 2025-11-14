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
/// Block type for long_term_backup_schedule in .
/// Nesting mode: list
/// </summary>
public class AzurermOracleAutonomousDatabaseLongTermBackupScheduleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "long_term_backup_schedule";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformArgument("enabled")]
    public required TerraformValue<bool> Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The repeat_cadence attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepeatCadence is required")]
    [TerraformArgument("repeat_cadence")]
    public required TerraformValue<string> RepeatCadence
    {
        get => new TerraformReference<string>(this, "repeat_cadence");
        set => SetArgument("repeat_cadence", value);
    }

    /// <summary>
    /// The retention_period_in_days attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RetentionPeriodInDays is required")]
    [TerraformArgument("retention_period_in_days")]
    public required TerraformValue<double> RetentionPeriodInDays
    {
        get => new TerraformReference<double>(this, "retention_period_in_days");
        set => SetArgument("retention_period_in_days", value);
    }

    /// <summary>
    /// The time_of_backup attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeOfBackup is required")]
    [TerraformArgument("time_of_backup")]
    public required TerraformValue<string> TimeOfBackup
    {
        get => new TerraformReference<string>(this, "time_of_backup");
        set => SetArgument("time_of_backup", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermOracleAutonomousDatabaseTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_oracle_autonomous_database resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermOracleAutonomousDatabase : TerraformResource
{
    public AzurermOracleAutonomousDatabase(string name) : base("azurerm_oracle_autonomous_database", name)
    {
    }

    /// <summary>
    /// The admin_password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdminPassword is required")]
    [TerraformArgument("admin_password")]
    public required TerraformValue<string> AdminPassword
    {
        get => new TerraformReference<string>(this, "admin_password");
        set => SetArgument("admin_password", value);
    }

    /// <summary>
    /// The allowed_ips attribute.
    /// </summary>
    [TerraformArgument("allowed_ips")]
    public TerraformSet<string>? AllowedIps
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "allowed_ips").ResolveNodes(ctx));
        set => SetArgument("allowed_ips", value);
    }

    /// <summary>
    /// The auto_scaling_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutoScalingEnabled is required")]
    [TerraformArgument("auto_scaling_enabled")]
    public required TerraformValue<bool> AutoScalingEnabled
    {
        get => new TerraformReference<bool>(this, "auto_scaling_enabled");
        set => SetArgument("auto_scaling_enabled", value);
    }

    /// <summary>
    /// The auto_scaling_for_storage_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutoScalingForStorageEnabled is required")]
    [TerraformArgument("auto_scaling_for_storage_enabled")]
    public required TerraformValue<bool> AutoScalingForStorageEnabled
    {
        get => new TerraformReference<bool>(this, "auto_scaling_for_storage_enabled");
        set => SetArgument("auto_scaling_for_storage_enabled", value);
    }

    /// <summary>
    /// The backup_retention_period_in_days attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupRetentionPeriodInDays is required")]
    [TerraformArgument("backup_retention_period_in_days")]
    public required TerraformValue<double> BackupRetentionPeriodInDays
    {
        get => new TerraformReference<double>(this, "backup_retention_period_in_days");
        set => SetArgument("backup_retention_period_in_days", value);
    }

    /// <summary>
    /// The character_set attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CharacterSet is required")]
    [TerraformArgument("character_set")]
    public required TerraformValue<string> CharacterSet
    {
        get => new TerraformReference<string>(this, "character_set");
        set => SetArgument("character_set", value);
    }

    /// <summary>
    /// The compute_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComputeCount is required")]
    [TerraformArgument("compute_count")]
    public required TerraformValue<double> ComputeCount
    {
        get => new TerraformReference<double>(this, "compute_count");
        set => SetArgument("compute_count", value);
    }

    /// <summary>
    /// The compute_model attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComputeModel is required")]
    [TerraformArgument("compute_model")]
    public required TerraformValue<string> ComputeModel
    {
        get => new TerraformReference<string>(this, "compute_model");
        set => SetArgument("compute_model", value);
    }

    /// <summary>
    /// The customer_contacts attribute.
    /// </summary>
    [TerraformArgument("customer_contacts")]
    public TerraformList<string> CustomerContacts
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "customer_contacts").ResolveNodes(ctx));
        set => SetArgument("customer_contacts", value);
    }

    /// <summary>
    /// The data_storage_size_in_tbs attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataStorageSizeInTbs is required")]
    [TerraformArgument("data_storage_size_in_tbs")]
    public required TerraformValue<double> DataStorageSizeInTbs
    {
        get => new TerraformReference<double>(this, "data_storage_size_in_tbs");
        set => SetArgument("data_storage_size_in_tbs", value);
    }

    /// <summary>
    /// The db_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DbVersion is required")]
    [TerraformArgument("db_version")]
    public required TerraformValue<string> DbVersion
    {
        get => new TerraformReference<string>(this, "db_version");
        set => SetArgument("db_version", value);
    }

    /// <summary>
    /// The db_workload attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DbWorkload is required")]
    [TerraformArgument("db_workload")]
    public required TerraformValue<string> DbWorkload
    {
        get => new TerraformReference<string>(this, "db_workload");
        set => SetArgument("db_workload", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformArgument("display_name")]
    public required TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
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
    /// The license_model attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LicenseModel is required")]
    [TerraformArgument("license_model")]
    public required TerraformValue<string> LicenseModel
    {
        get => new TerraformReference<string>(this, "license_model");
        set => SetArgument("license_model", value);
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
    /// The mtls_connection_required attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MtlsConnectionRequired is required")]
    [TerraformArgument("mtls_connection_required")]
    public required TerraformValue<bool> MtlsConnectionRequired
    {
        get => new TerraformReference<bool>(this, "mtls_connection_required");
        set => SetArgument("mtls_connection_required", value);
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
    /// The national_character_set attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NationalCharacterSet is required")]
    [TerraformArgument("national_character_set")]
    public required TerraformValue<string> NationalCharacterSet
    {
        get => new TerraformReference<string>(this, "national_character_set");
        set => SetArgument("national_character_set", value);
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
    /// The subnet_id attribute.
    /// </summary>
    [TerraformArgument("subnet_id")]
    public TerraformValue<string>? SubnetId
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
    /// The virtual_network_id attribute.
    /// </summary>
    [TerraformArgument("virtual_network_id")]
    public TerraformValue<string>? VirtualNetworkId
    {
        get => new TerraformReference<string>(this, "virtual_network_id");
        set => SetArgument("virtual_network_id", value);
    }

    /// <summary>
    /// Block for long_term_backup_schedule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LongTermBackupSchedule block(s) allowed")]
    [TerraformArgument("long_term_backup_schedule")]
    public TerraformList<AzurermOracleAutonomousDatabaseLongTermBackupScheduleBlock> LongTermBackupSchedule { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermOracleAutonomousDatabaseTimeoutsBlock Timeouts { get; set; } = new();

}
