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
    [TerraformArgument("enabled")]
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The run_immediately attribute.
    /// </summary>
    [TerraformArgument("run_immediately")]
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
    [TerraformArgument("encryption_enabled")]
    public TerraformValue<bool> EncryptionEnabled
    {
        get => new TerraformReference<bool>(this, "encryption_enabled");
        set => SetArgument("encryption_enabled", value);
    }

    /// <summary>
    /// The encryption_password attribute.
    /// </summary>
    [TerraformArgument("encryption_password")]
    public TerraformValue<string>? EncryptionPassword
    {
        get => new TerraformReference<string>(this, "encryption_password");
        set => SetArgument("encryption_password", value);
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
    /// The storage_account_access_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountAccessKey is required")]
    [TerraformArgument("storage_account_access_key")]
    public required TerraformValue<string> StorageAccountAccessKey
    {
        get => new TerraformReference<string>(this, "storage_account_access_key");
        set => SetArgument("storage_account_access_key", value);
    }

    /// <summary>
    /// The storage_blob_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageBlobEndpoint is required")]
    [TerraformArgument("storage_blob_endpoint")]
    public required TerraformValue<string> StorageBlobEndpoint
    {
        get => new TerraformReference<string>(this, "storage_blob_endpoint");
        set => SetArgument("storage_blob_endpoint", value);
    }

    /// <summary>
    /// The system_databases_backup_enabled attribute.
    /// </summary>
    [TerraformArgument("system_databases_backup_enabled")]
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
    [TerraformArgument("day_of_week")]
    public required TerraformValue<string> DayOfWeek
    {
        get => new TerraformReference<string>(this, "day_of_week");
        set => SetArgument("day_of_week", value);
    }

    /// <summary>
    /// The maintenance_window_duration_in_minutes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaintenanceWindowDurationInMinutes is required")]
    [TerraformArgument("maintenance_window_duration_in_minutes")]
    public required TerraformValue<double> MaintenanceWindowDurationInMinutes
    {
        get => new TerraformReference<double>(this, "maintenance_window_duration_in_minutes");
        set => SetArgument("maintenance_window_duration_in_minutes", value);
    }

    /// <summary>
    /// The maintenance_window_starting_hour attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaintenanceWindowStartingHour is required")]
    [TerraformArgument("maintenance_window_starting_hour")]
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
    [TerraformArgument("key_vault_url")]
    public required TerraformValue<string> KeyVaultUrl
    {
        get => new TerraformReference<string>(this, "key_vault_url");
        set => SetArgument("key_vault_url", value);
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
    /// The service_principal_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServicePrincipalName is required")]
    [TerraformArgument("service_principal_name")]
    public required TerraformValue<string> ServicePrincipalName
    {
        get => new TerraformReference<string>(this, "service_principal_name");
        set => SetArgument("service_principal_name", value);
    }

    /// <summary>
    /// The service_principal_secret attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServicePrincipalSecret is required")]
    [TerraformArgument("service_principal_secret")]
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
    [TerraformArgument("adhoc_workloads_optimization_enabled")]
    public TerraformValue<bool>? AdhocWorkloadsOptimizationEnabled
    {
        get => new TerraformReference<bool>(this, "adhoc_workloads_optimization_enabled");
        set => SetArgument("adhoc_workloads_optimization_enabled", value);
    }

    /// <summary>
    /// The collation attribute.
    /// </summary>
    [TerraformArgument("collation")]
    public TerraformValue<string>? Collation
    {
        get => new TerraformReference<string>(this, "collation");
        set => SetArgument("collation", value);
    }

    /// <summary>
    /// The instant_file_initialization_enabled attribute.
    /// </summary>
    [TerraformArgument("instant_file_initialization_enabled")]
    public TerraformValue<bool>? InstantFileInitializationEnabled
    {
        get => new TerraformReference<bool>(this, "instant_file_initialization_enabled");
        set => SetArgument("instant_file_initialization_enabled", value);
    }

    /// <summary>
    /// The lock_pages_in_memory_enabled attribute.
    /// </summary>
    [TerraformArgument("lock_pages_in_memory_enabled")]
    public TerraformValue<bool>? LockPagesInMemoryEnabled
    {
        get => new TerraformReference<bool>(this, "lock_pages_in_memory_enabled");
        set => SetArgument("lock_pages_in_memory_enabled", value);
    }

    /// <summary>
    /// The max_dop attribute.
    /// </summary>
    [TerraformArgument("max_dop")]
    public TerraformValue<double>? MaxDop
    {
        get => new TerraformReference<double>(this, "max_dop");
        set => SetArgument("max_dop", value);
    }

    /// <summary>
    /// The max_server_memory_mb attribute.
    /// </summary>
    [TerraformArgument("max_server_memory_mb")]
    public TerraformValue<double>? MaxServerMemoryMb
    {
        get => new TerraformReference<double>(this, "max_server_memory_mb");
        set => SetArgument("max_server_memory_mb", value);
    }

    /// <summary>
    /// The min_server_memory_mb attribute.
    /// </summary>
    [TerraformArgument("min_server_memory_mb")]
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
    [TerraformArgument("disk_type")]
    public required TerraformValue<string> DiskType
    {
        get => new TerraformReference<string>(this, "disk_type");
        set => SetArgument("disk_type", value);
    }

    /// <summary>
    /// The storage_workload_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageWorkloadType is required")]
    [TerraformArgument("storage_workload_type")]
    public required TerraformValue<string> StorageWorkloadType
    {
        get => new TerraformReference<string>(this, "storage_workload_type");
        set => SetArgument("storage_workload_type", value);
    }

    /// <summary>
    /// The system_db_on_data_disk_enabled attribute.
    /// </summary>
    [TerraformArgument("system_db_on_data_disk_enabled")]
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
    [TerraformArgument("cluster_bootstrap_account_password")]
    public required TerraformValue<string> ClusterBootstrapAccountPassword
    {
        get => new TerraformReference<string>(this, "cluster_bootstrap_account_password");
        set => SetArgument("cluster_bootstrap_account_password", value);
    }

    /// <summary>
    /// The cluster_operator_account_password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterOperatorAccountPassword is required")]
    [TerraformArgument("cluster_operator_account_password")]
    public required TerraformValue<string> ClusterOperatorAccountPassword
    {
        get => new TerraformReference<string>(this, "cluster_operator_account_password");
        set => SetArgument("cluster_operator_account_password", value);
    }

    /// <summary>
    /// The sql_service_account_password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SqlServiceAccountPassword is required")]
    [TerraformArgument("sql_service_account_password")]
    public required TerraformValue<string> SqlServiceAccountPassword
    {
        get => new TerraformReference<string>(this, "sql_service_account_password");
        set => SetArgument("sql_service_account_password", value);
    }

}

/// <summary>
/// Manages a azurerm_mssql_virtual_machine resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermMssqlVirtualMachine : TerraformResource
{
    public AzurermMssqlVirtualMachine(string name) : base("azurerm_mssql_virtual_machine", name)
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
    /// The r_services_enabled attribute.
    /// </summary>
    [TerraformArgument("r_services_enabled")]
    public TerraformValue<bool>? RServicesEnabled
    {
        get => new TerraformReference<bool>(this, "r_services_enabled");
        set => SetArgument("r_services_enabled", value);
    }

    /// <summary>
    /// The sql_connectivity_port attribute.
    /// </summary>
    [TerraformArgument("sql_connectivity_port")]
    public TerraformValue<double>? SqlConnectivityPort
    {
        get => new TerraformReference<double>(this, "sql_connectivity_port");
        set => SetArgument("sql_connectivity_port", value);
    }

    /// <summary>
    /// The sql_connectivity_type attribute.
    /// </summary>
    [TerraformArgument("sql_connectivity_type")]
    public TerraformValue<string>? SqlConnectivityType
    {
        get => new TerraformReference<string>(this, "sql_connectivity_type");
        set => SetArgument("sql_connectivity_type", value);
    }

    /// <summary>
    /// The sql_connectivity_update_password attribute.
    /// </summary>
    [TerraformArgument("sql_connectivity_update_password")]
    public TerraformValue<string>? SqlConnectivityUpdatePassword
    {
        get => new TerraformReference<string>(this, "sql_connectivity_update_password");
        set => SetArgument("sql_connectivity_update_password", value);
    }

    /// <summary>
    /// The sql_connectivity_update_username attribute.
    /// </summary>
    [TerraformArgument("sql_connectivity_update_username")]
    public TerraformValue<string>? SqlConnectivityUpdateUsername
    {
        get => new TerraformReference<string>(this, "sql_connectivity_update_username");
        set => SetArgument("sql_connectivity_update_username", value);
    }

    /// <summary>
    /// The sql_license_type attribute.
    /// </summary>
    [TerraformArgument("sql_license_type")]
    public TerraformValue<string>? SqlLicenseType
    {
        get => new TerraformReference<string>(this, "sql_license_type");
        set => SetArgument("sql_license_type", value);
    }

    /// <summary>
    /// The sql_virtual_machine_group_id attribute.
    /// </summary>
    [TerraformArgument("sql_virtual_machine_group_id")]
    public TerraformValue<string>? SqlVirtualMachineGroupId
    {
        get => new TerraformReference<string>(this, "sql_virtual_machine_group_id");
        set => SetArgument("sql_virtual_machine_group_id", value);
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
    /// The virtual_machine_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualMachineId is required")]
    [TerraformArgument("virtual_machine_id")]
    public required TerraformValue<string> VirtualMachineId
    {
        get => new TerraformReference<string>(this, "virtual_machine_id");
        set => SetArgument("virtual_machine_id", value);
    }

    /// <summary>
    /// Block for assessment.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Assessment block(s) allowed")]
    [TerraformArgument("assessment")]
    public TerraformList<AzurermMssqlVirtualMachineAssessmentBlock> Assessment { get; set; } = new();

    /// <summary>
    /// Block for auto_backup.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoBackup block(s) allowed")]
    [TerraformArgument("auto_backup")]
    public TerraformList<AzurermMssqlVirtualMachineAutoBackupBlock> AutoBackup { get; set; } = new();

    /// <summary>
    /// Block for auto_patching.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoPatching block(s) allowed")]
    [TerraformArgument("auto_patching")]
    public TerraformList<AzurermMssqlVirtualMachineAutoPatchingBlock> AutoPatching { get; set; } = new();

    /// <summary>
    /// Block for key_vault_credential.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KeyVaultCredential block(s) allowed")]
    [TerraformArgument("key_vault_credential")]
    public TerraformList<AzurermMssqlVirtualMachineKeyVaultCredentialBlock> KeyVaultCredential { get; set; } = new();

    /// <summary>
    /// Block for sql_instance.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SqlInstance block(s) allowed")]
    [TerraformArgument("sql_instance")]
    public TerraformList<AzurermMssqlVirtualMachineSqlInstanceBlock> SqlInstance { get; set; } = new();

    /// <summary>
    /// Block for storage_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageConfiguration block(s) allowed")]
    [TerraformArgument("storage_configuration")]
    public TerraformList<AzurermMssqlVirtualMachineStorageConfigurationBlock> StorageConfiguration { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermMssqlVirtualMachineTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Block for wsfc_domain_credential.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WsfcDomainCredential block(s) allowed")]
    [TerraformArgument("wsfc_domain_credential")]
    public TerraformList<AzurermMssqlVirtualMachineWsfcDomainCredentialBlock> WsfcDomainCredential { get; set; } = new();

}
