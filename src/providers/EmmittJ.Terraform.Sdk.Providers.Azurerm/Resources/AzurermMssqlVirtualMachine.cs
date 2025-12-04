using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for assessment in AzurermMssqlVirtualMachine.
/// Nesting mode: list
/// </summary>
public class AzurermMssqlVirtualMachineAssessmentBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "assessment";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The run_immediately attribute.
    /// </summary>
    public TerraformValue<bool>? RunImmediately
    {
        get => GetArgument<TerraformValue<bool>>("run_immediately");
        set => SetArgument("run_immediately", value);
    }

    /// <summary>
    /// Schedule block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Schedule block(s) allowed")]
    public TerraformList<AzurermMssqlVirtualMachineAssessmentBlockScheduleBlock>? Schedule
    {
        get => GetArgument<TerraformList<AzurermMssqlVirtualMachineAssessmentBlockScheduleBlock>>("schedule");
        set => SetArgument("schedule", value);
    }

}

/// <summary>
/// Block type for schedule in AzurermMssqlVirtualMachineAssessmentBlock.
/// Nesting mode: list
/// </summary>
public class AzurermMssqlVirtualMachineAssessmentBlockScheduleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "schedule";

    /// <summary>
    /// The day_of_week attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DayOfWeek is required")]
    public required TerraformValue<string> DayOfWeek
    {
        get => GetArgument<TerraformValue<string>>("day_of_week");
        set => SetArgument("day_of_week", value);
    }

    /// <summary>
    /// The monthly_occurrence attribute.
    /// </summary>
    public TerraformValue<double>? MonthlyOccurrence
    {
        get => GetArgument<TerraformValue<double>>("monthly_occurrence");
        set => SetArgument("monthly_occurrence", value);
    }

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartTime is required")]
    public required TerraformValue<string> StartTime
    {
        get => GetArgument<TerraformValue<string>>("start_time");
        set => SetArgument("start_time", value);
    }

    /// <summary>
    /// The weekly_interval attribute.
    /// </summary>
    public TerraformValue<double>? WeeklyInterval
    {
        get => GetArgument<TerraformValue<double>>("weekly_interval");
        set => SetArgument("weekly_interval", value);
    }

}


/// <summary>
/// Block type for auto_backup in AzurermMssqlVirtualMachine.
/// Nesting mode: list
/// </summary>
public class AzurermMssqlVirtualMachineAutoBackupBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "auto_backup";

    /// <summary>
    /// The encryption_enabled attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<bool>? EncryptionEnabled
    {
        get => GetArgument<TerraformValue<bool>>("encryption_enabled");
        set => SetArgument("encryption_enabled", value);
    }

    /// <summary>
    /// The encryption_password attribute.
    /// </summary>
    public TerraformValue<string>? EncryptionPassword
    {
        get => GetArgument<TerraformValue<string>>("encryption_password");
        set => SetArgument("encryption_password", value);
    }

    /// <summary>
    /// The retention_period_in_days attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RetentionPeriodInDays is required")]
    public required TerraformValue<double> RetentionPeriodInDays
    {
        get => GetArgument<TerraformValue<double>>("retention_period_in_days");
        set => SetArgument("retention_period_in_days", value);
    }

    /// <summary>
    /// The storage_account_access_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountAccessKey is required")]
    public required TerraformValue<string> StorageAccountAccessKey
    {
        get => GetArgument<TerraformValue<string>>("storage_account_access_key");
        set => SetArgument("storage_account_access_key", value);
    }

    /// <summary>
    /// The storage_blob_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageBlobEndpoint is required")]
    public required TerraformValue<string> StorageBlobEndpoint
    {
        get => GetArgument<TerraformValue<string>>("storage_blob_endpoint");
        set => SetArgument("storage_blob_endpoint", value);
    }

    /// <summary>
    /// The system_databases_backup_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? SystemDatabasesBackupEnabled
    {
        get => GetArgument<TerraformValue<bool>>("system_databases_backup_enabled");
        set => SetArgument("system_databases_backup_enabled", value);
    }

    /// <summary>
    /// ManualSchedule block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ManualSchedule block(s) allowed")]
    public TerraformList<AzurermMssqlVirtualMachineAutoBackupBlockManualScheduleBlock>? ManualSchedule
    {
        get => GetArgument<TerraformList<AzurermMssqlVirtualMachineAutoBackupBlockManualScheduleBlock>>("manual_schedule");
        set => SetArgument("manual_schedule", value);
    }

}

/// <summary>
/// Block type for manual_schedule in AzurermMssqlVirtualMachineAutoBackupBlock.
/// Nesting mode: list
/// </summary>
public class AzurermMssqlVirtualMachineAutoBackupBlockManualScheduleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "manual_schedule";

    /// <summary>
    /// The days_of_week attribute.
    /// </summary>
    public TerraformSet<string>? DaysOfWeek
    {
        get => GetArgument<TerraformSet<string>>("days_of_week");
        set => SetArgument("days_of_week", value);
    }

    /// <summary>
    /// The full_backup_frequency attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FullBackupFrequency is required")]
    public required TerraformValue<string> FullBackupFrequency
    {
        get => GetArgument<TerraformValue<string>>("full_backup_frequency");
        set => SetArgument("full_backup_frequency", value);
    }

    /// <summary>
    /// The full_backup_start_hour attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FullBackupStartHour is required")]
    public required TerraformValue<double> FullBackupStartHour
    {
        get => GetArgument<TerraformValue<double>>("full_backup_start_hour");
        set => SetArgument("full_backup_start_hour", value);
    }

    /// <summary>
    /// The full_backup_window_in_hours attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FullBackupWindowInHours is required")]
    public required TerraformValue<double> FullBackupWindowInHours
    {
        get => GetArgument<TerraformValue<double>>("full_backup_window_in_hours");
        set => SetArgument("full_backup_window_in_hours", value);
    }

    /// <summary>
    /// The log_backup_frequency_in_minutes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogBackupFrequencyInMinutes is required")]
    public required TerraformValue<double> LogBackupFrequencyInMinutes
    {
        get => GetArgument<TerraformValue<double>>("log_backup_frequency_in_minutes");
        set => SetArgument("log_backup_frequency_in_minutes", value);
    }

}


/// <summary>
/// Block type for auto_patching in AzurermMssqlVirtualMachine.
/// Nesting mode: list
/// </summary>
public class AzurermMssqlVirtualMachineAutoPatchingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "auto_patching";

    /// <summary>
    /// The day_of_week attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DayOfWeek is required")]
    public required TerraformValue<string> DayOfWeek
    {
        get => GetArgument<TerraformValue<string>>("day_of_week");
        set => SetArgument("day_of_week", value);
    }

    /// <summary>
    /// The maintenance_window_duration_in_minutes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaintenanceWindowDurationInMinutes is required")]
    public required TerraformValue<double> MaintenanceWindowDurationInMinutes
    {
        get => GetArgument<TerraformValue<double>>("maintenance_window_duration_in_minutes");
        set => SetArgument("maintenance_window_duration_in_minutes", value);
    }

    /// <summary>
    /// The maintenance_window_starting_hour attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaintenanceWindowStartingHour is required")]
    public required TerraformValue<double> MaintenanceWindowStartingHour
    {
        get => GetArgument<TerraformValue<double>>("maintenance_window_starting_hour");
        set => SetArgument("maintenance_window_starting_hour", value);
    }

}


/// <summary>
/// Block type for key_vault_credential in AzurermMssqlVirtualMachine.
/// Nesting mode: list
/// </summary>
public class AzurermMssqlVirtualMachineKeyVaultCredentialBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "key_vault_credential";

    /// <summary>
    /// The key_vault_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultUrl is required")]
    public required TerraformValue<string> KeyVaultUrl
    {
        get => GetArgument<TerraformValue<string>>("key_vault_url");
        set => SetArgument("key_vault_url", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The service_principal_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServicePrincipalName is required")]
    public required TerraformValue<string> ServicePrincipalName
    {
        get => GetArgument<TerraformValue<string>>("service_principal_name");
        set => SetArgument("service_principal_name", value);
    }

    /// <summary>
    /// The service_principal_secret attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServicePrincipalSecret is required")]
    public required TerraformValue<string> ServicePrincipalSecret
    {
        get => GetArgument<TerraformValue<string>>("service_principal_secret");
        set => SetArgument("service_principal_secret", value);
    }

}


/// <summary>
/// Block type for sql_instance in AzurermMssqlVirtualMachine.
/// Nesting mode: list
/// </summary>
public class AzurermMssqlVirtualMachineSqlInstanceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sql_instance";

    /// <summary>
    /// The adhoc_workloads_optimization_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? AdhocWorkloadsOptimizationEnabled
    {
        get => GetArgument<TerraformValue<bool>>("adhoc_workloads_optimization_enabled");
        set => SetArgument("adhoc_workloads_optimization_enabled", value);
    }

    /// <summary>
    /// The collation attribute.
    /// </summary>
    public TerraformValue<string>? Collation
    {
        get => GetArgument<TerraformValue<string>>("collation");
        set => SetArgument("collation", value);
    }

    /// <summary>
    /// The instant_file_initialization_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? InstantFileInitializationEnabled
    {
        get => GetArgument<TerraformValue<bool>>("instant_file_initialization_enabled");
        set => SetArgument("instant_file_initialization_enabled", value);
    }

    /// <summary>
    /// The lock_pages_in_memory_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? LockPagesInMemoryEnabled
    {
        get => GetArgument<TerraformValue<bool>>("lock_pages_in_memory_enabled");
        set => SetArgument("lock_pages_in_memory_enabled", value);
    }

    /// <summary>
    /// The max_dop attribute.
    /// </summary>
    public TerraformValue<double>? MaxDop
    {
        get => GetArgument<TerraformValue<double>>("max_dop");
        set => SetArgument("max_dop", value);
    }

    /// <summary>
    /// The max_server_memory_mb attribute.
    /// </summary>
    public TerraformValue<double>? MaxServerMemoryMb
    {
        get => GetArgument<TerraformValue<double>>("max_server_memory_mb");
        set => SetArgument("max_server_memory_mb", value);
    }

    /// <summary>
    /// The min_server_memory_mb attribute.
    /// </summary>
    public TerraformValue<double>? MinServerMemoryMb
    {
        get => GetArgument<TerraformValue<double>>("min_server_memory_mb");
        set => SetArgument("min_server_memory_mb", value);
    }

}


/// <summary>
/// Block type for storage_configuration in AzurermMssqlVirtualMachine.
/// Nesting mode: list
/// </summary>
public class AzurermMssqlVirtualMachineStorageConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "storage_configuration";

    /// <summary>
    /// The disk_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DiskType is required")]
    public required TerraformValue<string> DiskType
    {
        get => GetArgument<TerraformValue<string>>("disk_type");
        set => SetArgument("disk_type", value);
    }

    /// <summary>
    /// The storage_workload_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageWorkloadType is required")]
    public required TerraformValue<string> StorageWorkloadType
    {
        get => GetArgument<TerraformValue<string>>("storage_workload_type");
        set => SetArgument("storage_workload_type", value);
    }

    /// <summary>
    /// The system_db_on_data_disk_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? SystemDbOnDataDiskEnabled
    {
        get => GetArgument<TerraformValue<bool>>("system_db_on_data_disk_enabled");
        set => SetArgument("system_db_on_data_disk_enabled", value);
    }

    /// <summary>
    /// DataSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataSettings block(s) allowed")]
    public TerraformList<AzurermMssqlVirtualMachineStorageConfigurationBlockDataSettingsBlock>? DataSettings
    {
        get => GetArgument<TerraformList<AzurermMssqlVirtualMachineStorageConfigurationBlockDataSettingsBlock>>("data_settings");
        set => SetArgument("data_settings", value);
    }

    /// <summary>
    /// LogSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LogSettings block(s) allowed")]
    public TerraformList<AzurermMssqlVirtualMachineStorageConfigurationBlockLogSettingsBlock>? LogSettings
    {
        get => GetArgument<TerraformList<AzurermMssqlVirtualMachineStorageConfigurationBlockLogSettingsBlock>>("log_settings");
        set => SetArgument("log_settings", value);
    }

    /// <summary>
    /// TempDbSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TempDbSettings block(s) allowed")]
    public TerraformList<AzurermMssqlVirtualMachineStorageConfigurationBlockTempDbSettingsBlock>? TempDbSettings
    {
        get => GetArgument<TerraformList<AzurermMssqlVirtualMachineStorageConfigurationBlockTempDbSettingsBlock>>("temp_db_settings");
        set => SetArgument("temp_db_settings", value);
    }

}

/// <summary>
/// Block type for data_settings in AzurermMssqlVirtualMachineStorageConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AzurermMssqlVirtualMachineStorageConfigurationBlockDataSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "data_settings";

    /// <summary>
    /// The default_file_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultFilePath is required")]
    public required TerraformValue<string> DefaultFilePath
    {
        get => GetArgument<TerraformValue<string>>("default_file_path");
        set => SetArgument("default_file_path", value);
    }

    /// <summary>
    /// The luns attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Luns is required")]
    public TerraformList<double>? Luns
    {
        get => GetArgument<TerraformList<double>>("luns");
        set => SetArgument("luns", value);
    }

}

/// <summary>
/// Block type for log_settings in AzurermMssqlVirtualMachineStorageConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AzurermMssqlVirtualMachineStorageConfigurationBlockLogSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "log_settings";

    /// <summary>
    /// The default_file_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultFilePath is required")]
    public required TerraformValue<string> DefaultFilePath
    {
        get => GetArgument<TerraformValue<string>>("default_file_path");
        set => SetArgument("default_file_path", value);
    }

    /// <summary>
    /// The luns attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Luns is required")]
    public TerraformList<double>? Luns
    {
        get => GetArgument<TerraformList<double>>("luns");
        set => SetArgument("luns", value);
    }

}

/// <summary>
/// Block type for temp_db_settings in AzurermMssqlVirtualMachineStorageConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AzurermMssqlVirtualMachineStorageConfigurationBlockTempDbSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "temp_db_settings";

    /// <summary>
    /// The data_file_count attribute.
    /// </summary>
    public TerraformValue<double>? DataFileCount
    {
        get => GetArgument<TerraformValue<double>>("data_file_count");
        set => SetArgument("data_file_count", value);
    }

    /// <summary>
    /// The data_file_growth_in_mb attribute.
    /// </summary>
    public TerraformValue<double>? DataFileGrowthInMb
    {
        get => GetArgument<TerraformValue<double>>("data_file_growth_in_mb");
        set => SetArgument("data_file_growth_in_mb", value);
    }

    /// <summary>
    /// The data_file_size_mb attribute.
    /// </summary>
    public TerraformValue<double>? DataFileSizeMb
    {
        get => GetArgument<TerraformValue<double>>("data_file_size_mb");
        set => SetArgument("data_file_size_mb", value);
    }

    /// <summary>
    /// The default_file_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultFilePath is required")]
    public required TerraformValue<string> DefaultFilePath
    {
        get => GetArgument<TerraformValue<string>>("default_file_path");
        set => SetArgument("default_file_path", value);
    }

    /// <summary>
    /// The log_file_growth_mb attribute.
    /// </summary>
    public TerraformValue<double>? LogFileGrowthMb
    {
        get => GetArgument<TerraformValue<double>>("log_file_growth_mb");
        set => SetArgument("log_file_growth_mb", value);
    }

    /// <summary>
    /// The log_file_size_mb attribute.
    /// </summary>
    public TerraformValue<double>? LogFileSizeMb
    {
        get => GetArgument<TerraformValue<double>>("log_file_size_mb");
        set => SetArgument("log_file_size_mb", value);
    }

    /// <summary>
    /// The luns attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Luns is required")]
    public TerraformList<double>? Luns
    {
        get => GetArgument<TerraformList<double>>("luns");
        set => SetArgument("luns", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermMssqlVirtualMachine.
/// Nesting mode: single
/// </summary>
public class AzurermMssqlVirtualMachineTimeoutsBlock : TerraformBlock
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
/// Block type for wsfc_domain_credential in AzurermMssqlVirtualMachine.
/// Nesting mode: list
/// </summary>
public class AzurermMssqlVirtualMachineWsfcDomainCredentialBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "wsfc_domain_credential";

    /// <summary>
    /// The cluster_bootstrap_account_password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterBootstrapAccountPassword is required")]
    public required TerraformValue<string> ClusterBootstrapAccountPassword
    {
        get => GetArgument<TerraformValue<string>>("cluster_bootstrap_account_password");
        set => SetArgument("cluster_bootstrap_account_password", value);
    }

    /// <summary>
    /// The cluster_operator_account_password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterOperatorAccountPassword is required")]
    public required TerraformValue<string> ClusterOperatorAccountPassword
    {
        get => GetArgument<TerraformValue<string>>("cluster_operator_account_password");
        set => SetArgument("cluster_operator_account_password", value);
    }

    /// <summary>
    /// The sql_service_account_password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SqlServiceAccountPassword is required")]
    public required TerraformValue<string> SqlServiceAccountPassword
    {
        get => GetArgument<TerraformValue<string>>("sql_service_account_password");
        set => SetArgument("sql_service_account_password", value);
    }

}


/// <summary>
/// Represents a azurerm_mssql_virtual_machine Terraform resource.
/// Manages a azurerm_mssql_virtual_machine resource.
/// </summary>
public partial class AzurermMssqlVirtualMachine(string name) : TerraformResource("azurerm_mssql_virtual_machine", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The r_services_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? RServicesEnabled
    {
        get => GetArgument<TerraformValue<bool>>("r_services_enabled");
        set => SetArgument("r_services_enabled", value);
    }

    /// <summary>
    /// The sql_connectivity_port attribute.
    /// </summary>
    public TerraformValue<double>? SqlConnectivityPort
    {
        get => GetArgument<TerraformValue<double>>("sql_connectivity_port");
        set => SetArgument("sql_connectivity_port", value);
    }

    /// <summary>
    /// The sql_connectivity_type attribute.
    /// </summary>
    public TerraformValue<string>? SqlConnectivityType
    {
        get => GetArgument<TerraformValue<string>>("sql_connectivity_type");
        set => SetArgument("sql_connectivity_type", value);
    }

    /// <summary>
    /// The sql_connectivity_update_password attribute.
    /// </summary>
    public TerraformValue<string>? SqlConnectivityUpdatePassword
    {
        get => GetArgument<TerraformValue<string>>("sql_connectivity_update_password");
        set => SetArgument("sql_connectivity_update_password", value);
    }

    /// <summary>
    /// The sql_connectivity_update_username attribute.
    /// </summary>
    public TerraformValue<string>? SqlConnectivityUpdateUsername
    {
        get => GetArgument<TerraformValue<string>>("sql_connectivity_update_username");
        set => SetArgument("sql_connectivity_update_username", value);
    }

    /// <summary>
    /// The sql_license_type attribute.
    /// </summary>
    public TerraformValue<string>? SqlLicenseType
    {
        get => GetArgument<TerraformValue<string>>("sql_license_type");
        set => SetArgument("sql_license_type", value);
    }

    /// <summary>
    /// The sql_virtual_machine_group_id attribute.
    /// </summary>
    public TerraformValue<string>? SqlVirtualMachineGroupId
    {
        get => GetArgument<TerraformValue<string>>("sql_virtual_machine_group_id");
        set => SetArgument("sql_virtual_machine_group_id", value);
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
    /// The virtual_machine_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualMachineId is required")]
    public required TerraformValue<string> VirtualMachineId
    {
        get => GetArgument<TerraformValue<string>>("virtual_machine_id");
        set => SetArgument("virtual_machine_id", value);
    }

    /// <summary>
    /// Assessment block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Assessment block(s) allowed")]
    public TerraformList<AzurermMssqlVirtualMachineAssessmentBlock>? Assessment
    {
        get => GetArgument<TerraformList<AzurermMssqlVirtualMachineAssessmentBlock>>("assessment");
        set => SetArgument("assessment", value);
    }

    /// <summary>
    /// AutoBackup block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoBackup block(s) allowed")]
    public TerraformList<AzurermMssqlVirtualMachineAutoBackupBlock>? AutoBackup
    {
        get => GetArgument<TerraformList<AzurermMssqlVirtualMachineAutoBackupBlock>>("auto_backup");
        set => SetArgument("auto_backup", value);
    }

    /// <summary>
    /// AutoPatching block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoPatching block(s) allowed")]
    public TerraformList<AzurermMssqlVirtualMachineAutoPatchingBlock>? AutoPatching
    {
        get => GetArgument<TerraformList<AzurermMssqlVirtualMachineAutoPatchingBlock>>("auto_patching");
        set => SetArgument("auto_patching", value);
    }

    /// <summary>
    /// KeyVaultCredential block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KeyVaultCredential block(s) allowed")]
    public TerraformList<AzurermMssqlVirtualMachineKeyVaultCredentialBlock>? KeyVaultCredential
    {
        get => GetArgument<TerraformList<AzurermMssqlVirtualMachineKeyVaultCredentialBlock>>("key_vault_credential");
        set => SetArgument("key_vault_credential", value);
    }

    /// <summary>
    /// SqlInstance block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SqlInstance block(s) allowed")]
    public TerraformList<AzurermMssqlVirtualMachineSqlInstanceBlock>? SqlInstance
    {
        get => GetArgument<TerraformList<AzurermMssqlVirtualMachineSqlInstanceBlock>>("sql_instance");
        set => SetArgument("sql_instance", value);
    }

    /// <summary>
    /// StorageConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageConfiguration block(s) allowed")]
    public TerraformList<AzurermMssqlVirtualMachineStorageConfigurationBlock>? StorageConfiguration
    {
        get => GetArgument<TerraformList<AzurermMssqlVirtualMachineStorageConfigurationBlock>>("storage_configuration");
        set => SetArgument("storage_configuration", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermMssqlVirtualMachineTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermMssqlVirtualMachineTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// WsfcDomainCredential block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WsfcDomainCredential block(s) allowed")]
    public TerraformList<AzurermMssqlVirtualMachineWsfcDomainCredentialBlock>? WsfcDomainCredential
    {
        get => GetArgument<TerraformList<AzurermMssqlVirtualMachineWsfcDomainCredentialBlock>>("wsfc_domain_credential");
        set => SetArgument("wsfc_domain_credential", value);
    }

}
