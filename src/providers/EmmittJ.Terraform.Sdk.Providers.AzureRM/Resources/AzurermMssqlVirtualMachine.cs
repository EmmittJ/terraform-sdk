using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for assessment in .
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
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The run_immediately attribute.
    /// </summary>
    public TerraformValue<bool>? RunImmediately
    {
        get => new TerraformReference<bool>(this, "run_immediately");
        set => SetArgument("run_immediately", value);
    }

}

/// <summary>
/// Block type for auto_backup in .
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
    public TerraformValue<bool> EncryptionEnabled
    {
        get => new TerraformReference<bool>(this, "encryption_enabled");
        set => SetArgument("encryption_enabled", value);
    }

    /// <summary>
    /// The encryption_password attribute.
    /// </summary>
    public TerraformValue<string>? EncryptionPassword
    {
        get => new TerraformReference<string>(this, "encryption_password");
        set => SetArgument("encryption_password", value);
    }

    /// <summary>
    /// The retention_period_in_days attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RetentionPeriodInDays is required")]
    public required TerraformValue<double> RetentionPeriodInDays
    {
        get => new TerraformReference<double>(this, "retention_period_in_days");
        set => SetArgument("retention_period_in_days", value);
    }

    /// <summary>
    /// The storage_account_access_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountAccessKey is required")]
    public required TerraformValue<string> StorageAccountAccessKey
    {
        get => new TerraformReference<string>(this, "storage_account_access_key");
        set => SetArgument("storage_account_access_key", value);
    }

    /// <summary>
    /// The storage_blob_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageBlobEndpoint is required")]
    public required TerraformValue<string> StorageBlobEndpoint
    {
        get => new TerraformReference<string>(this, "storage_blob_endpoint");
        set => SetArgument("storage_blob_endpoint", value);
    }

    /// <summary>
    /// The system_databases_backup_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? SystemDatabasesBackupEnabled
    {
        get => new TerraformReference<bool>(this, "system_databases_backup_enabled");
        set => SetArgument("system_databases_backup_enabled", value);
    }

}

/// <summary>
/// Block type for auto_patching in .
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
        get => new TerraformReference<string>(this, "day_of_week");
        set => SetArgument("day_of_week", value);
    }

    /// <summary>
    /// The maintenance_window_duration_in_minutes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaintenanceWindowDurationInMinutes is required")]
    public required TerraformValue<double> MaintenanceWindowDurationInMinutes
    {
        get => new TerraformReference<double>(this, "maintenance_window_duration_in_minutes");
        set => SetArgument("maintenance_window_duration_in_minutes", value);
    }

    /// <summary>
    /// The maintenance_window_starting_hour attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaintenanceWindowStartingHour is required")]
    public required TerraformValue<double> MaintenanceWindowStartingHour
    {
        get => new TerraformReference<double>(this, "maintenance_window_starting_hour");
        set => SetArgument("maintenance_window_starting_hour", value);
    }

}

/// <summary>
/// Block type for key_vault_credential in .
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
        get => new TerraformReference<string>(this, "key_vault_url");
        set => SetArgument("key_vault_url", value);
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
    /// The service_principal_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServicePrincipalName is required")]
    public required TerraformValue<string> ServicePrincipalName
    {
        get => new TerraformReference<string>(this, "service_principal_name");
        set => SetArgument("service_principal_name", value);
    }

    /// <summary>
    /// The service_principal_secret attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServicePrincipalSecret is required")]
    public required TerraformValue<string> ServicePrincipalSecret
    {
        get => new TerraformReference<string>(this, "service_principal_secret");
        set => SetArgument("service_principal_secret", value);
    }

}

/// <summary>
/// Block type for sql_instance in .
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
        get => new TerraformReference<bool>(this, "adhoc_workloads_optimization_enabled");
        set => SetArgument("adhoc_workloads_optimization_enabled", value);
    }

    /// <summary>
    /// The collation attribute.
    /// </summary>
    public TerraformValue<string>? Collation
    {
        get => new TerraformReference<string>(this, "collation");
        set => SetArgument("collation", value);
    }

    /// <summary>
    /// The instant_file_initialization_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? InstantFileInitializationEnabled
    {
        get => new TerraformReference<bool>(this, "instant_file_initialization_enabled");
        set => SetArgument("instant_file_initialization_enabled", value);
    }

    /// <summary>
    /// The lock_pages_in_memory_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? LockPagesInMemoryEnabled
    {
        get => new TerraformReference<bool>(this, "lock_pages_in_memory_enabled");
        set => SetArgument("lock_pages_in_memory_enabled", value);
    }

    /// <summary>
    /// The max_dop attribute.
    /// </summary>
    public TerraformValue<double>? MaxDop
    {
        get => new TerraformReference<double>(this, "max_dop");
        set => SetArgument("max_dop", value);
    }

    /// <summary>
    /// The max_server_memory_mb attribute.
    /// </summary>
    public TerraformValue<double>? MaxServerMemoryMb
    {
        get => new TerraformReference<double>(this, "max_server_memory_mb");
        set => SetArgument("max_server_memory_mb", value);
    }

    /// <summary>
    /// The min_server_memory_mb attribute.
    /// </summary>
    public TerraformValue<double>? MinServerMemoryMb
    {
        get => new TerraformReference<double>(this, "min_server_memory_mb");
        set => SetArgument("min_server_memory_mb", value);
    }

}

/// <summary>
/// Block type for storage_configuration in .
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
        get => new TerraformReference<string>(this, "disk_type");
        set => SetArgument("disk_type", value);
    }

    /// <summary>
    /// The storage_workload_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageWorkloadType is required")]
    public required TerraformValue<string> StorageWorkloadType
    {
        get => new TerraformReference<string>(this, "storage_workload_type");
        set => SetArgument("storage_workload_type", value);
    }

    /// <summary>
    /// The system_db_on_data_disk_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? SystemDbOnDataDiskEnabled
    {
        get => new TerraformReference<bool>(this, "system_db_on_data_disk_enabled");
        set => SetArgument("system_db_on_data_disk_enabled", value);
    }

}

/// <summary>
/// Block type for timeouts in .
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Block type for wsfc_domain_credential in .
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
        get => new TerraformReference<string>(this, "cluster_bootstrap_account_password");
        set => SetArgument("cluster_bootstrap_account_password", value);
    }

    /// <summary>
    /// The cluster_operator_account_password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterOperatorAccountPassword is required")]
    public required TerraformValue<string> ClusterOperatorAccountPassword
    {
        get => new TerraformReference<string>(this, "cluster_operator_account_password");
        set => SetArgument("cluster_operator_account_password", value);
    }

    /// <summary>
    /// The sql_service_account_password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SqlServiceAccountPassword is required")]
    public required TerraformValue<string> SqlServiceAccountPassword
    {
        get => new TerraformReference<string>(this, "sql_service_account_password");
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
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The r_services_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? RServicesEnabled
    {
        get => new TerraformReference<bool>(this, "r_services_enabled");
        set => SetArgument("r_services_enabled", value);
    }

    /// <summary>
    /// The sql_connectivity_port attribute.
    /// </summary>
    public TerraformValue<double>? SqlConnectivityPort
    {
        get => new TerraformReference<double>(this, "sql_connectivity_port");
        set => SetArgument("sql_connectivity_port", value);
    }

    /// <summary>
    /// The sql_connectivity_type attribute.
    /// </summary>
    public TerraformValue<string>? SqlConnectivityType
    {
        get => new TerraformReference<string>(this, "sql_connectivity_type");
        set => SetArgument("sql_connectivity_type", value);
    }

    /// <summary>
    /// The sql_connectivity_update_password attribute.
    /// </summary>
    public TerraformValue<string>? SqlConnectivityUpdatePassword
    {
        get => new TerraformReference<string>(this, "sql_connectivity_update_password");
        set => SetArgument("sql_connectivity_update_password", value);
    }

    /// <summary>
    /// The sql_connectivity_update_username attribute.
    /// </summary>
    public TerraformValue<string>? SqlConnectivityUpdateUsername
    {
        get => new TerraformReference<string>(this, "sql_connectivity_update_username");
        set => SetArgument("sql_connectivity_update_username", value);
    }

    /// <summary>
    /// The sql_license_type attribute.
    /// </summary>
    public TerraformValue<string>? SqlLicenseType
    {
        get => new TerraformReference<string>(this, "sql_license_type");
        set => SetArgument("sql_license_type", value);
    }

    /// <summary>
    /// The sql_virtual_machine_group_id attribute.
    /// </summary>
    public TerraformValue<string>? SqlVirtualMachineGroupId
    {
        get => new TerraformReference<string>(this, "sql_virtual_machine_group_id");
        set => SetArgument("sql_virtual_machine_group_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The virtual_machine_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualMachineId is required")]
    public required TerraformValue<string> VirtualMachineId
    {
        get => new TerraformReference<string>(this, "virtual_machine_id");
        set => SetArgument("virtual_machine_id", value);
    }

    /// <summary>
    /// Assessment block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Assessment block(s) allowed")]
    public AzurermMssqlVirtualMachineAssessmentBlock? Assessment
    {
        get => GetArgument<AzurermMssqlVirtualMachineAssessmentBlock>("assessment");
        set => SetArgument("assessment", value);
    }

    /// <summary>
    /// AutoBackup block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoBackup block(s) allowed")]
    public AzurermMssqlVirtualMachineAutoBackupBlock? AutoBackup
    {
        get => GetArgument<AzurermMssqlVirtualMachineAutoBackupBlock>("auto_backup");
        set => SetArgument("auto_backup", value);
    }

    /// <summary>
    /// AutoPatching block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoPatching block(s) allowed")]
    public AzurermMssqlVirtualMachineAutoPatchingBlock? AutoPatching
    {
        get => GetArgument<AzurermMssqlVirtualMachineAutoPatchingBlock>("auto_patching");
        set => SetArgument("auto_patching", value);
    }

    /// <summary>
    /// KeyVaultCredential block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KeyVaultCredential block(s) allowed")]
    public AzurermMssqlVirtualMachineKeyVaultCredentialBlock? KeyVaultCredential
    {
        get => GetArgument<AzurermMssqlVirtualMachineKeyVaultCredentialBlock>("key_vault_credential");
        set => SetArgument("key_vault_credential", value);
    }

    /// <summary>
    /// SqlInstance block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SqlInstance block(s) allowed")]
    public AzurermMssqlVirtualMachineSqlInstanceBlock? SqlInstance
    {
        get => GetArgument<AzurermMssqlVirtualMachineSqlInstanceBlock>("sql_instance");
        set => SetArgument("sql_instance", value);
    }

    /// <summary>
    /// StorageConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageConfiguration block(s) allowed")]
    public AzurermMssqlVirtualMachineStorageConfigurationBlock? StorageConfiguration
    {
        get => GetArgument<AzurermMssqlVirtualMachineStorageConfigurationBlock>("storage_configuration");
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
    public AzurermMssqlVirtualMachineWsfcDomainCredentialBlock? WsfcDomainCredential
    {
        get => GetArgument<AzurermMssqlVirtualMachineWsfcDomainCredentialBlock>("wsfc_domain_credential");
        set => SetArgument("wsfc_domain_credential", value);
    }

}
