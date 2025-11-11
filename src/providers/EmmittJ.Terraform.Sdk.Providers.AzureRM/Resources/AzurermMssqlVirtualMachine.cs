using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for assessment in .
/// Nesting mode: list
/// </summary>
public partial class AzurermMssqlVirtualMachineAssessmentBlock : TerraformBlockBase
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The run_immediately attribute.
    /// </summary>
    [TerraformProperty("run_immediately")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? RunImmediately { get; set; }

}

/// <summary>
/// Block type for auto_backup in .
/// Nesting mode: list
/// </summary>
public partial class AzurermMssqlVirtualMachineAutoBackupBlock : TerraformBlockBase
{
    /// <summary>
    /// The encryption_enabled attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformProperty("encryption_enabled")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> EncryptionEnabled { get; set; }

    /// <summary>
    /// The encryption_password attribute.
    /// </summary>
    [TerraformProperty("encryption_password")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? EncryptionPassword { get; set; }

    /// <summary>
    /// The retention_period_in_days attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RetentionPeriodInDays is required")]
    [TerraformProperty("retention_period_in_days")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> RetentionPeriodInDays { get; set; }

    /// <summary>
    /// The storage_account_access_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountAccessKey is required")]
    [TerraformProperty("storage_account_access_key")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> StorageAccountAccessKey { get; set; }

    /// <summary>
    /// The storage_blob_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageBlobEndpoint is required")]
    [TerraformProperty("storage_blob_endpoint")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> StorageBlobEndpoint { get; set; }

    /// <summary>
    /// The system_databases_backup_enabled attribute.
    /// </summary>
    [TerraformProperty("system_databases_backup_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? SystemDatabasesBackupEnabled { get; set; }

}

/// <summary>
/// Block type for auto_patching in .
/// Nesting mode: list
/// </summary>
public partial class AzurermMssqlVirtualMachineAutoPatchingBlock : TerraformBlockBase
{
    /// <summary>
    /// The day_of_week attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DayOfWeek is required")]
    [TerraformProperty("day_of_week")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DayOfWeek { get; set; }

    /// <summary>
    /// The maintenance_window_duration_in_minutes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaintenanceWindowDurationInMinutes is required")]
    [TerraformProperty("maintenance_window_duration_in_minutes")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> MaintenanceWindowDurationInMinutes { get; set; }

    /// <summary>
    /// The maintenance_window_starting_hour attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaintenanceWindowStartingHour is required")]
    [TerraformProperty("maintenance_window_starting_hour")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> MaintenanceWindowStartingHour { get; set; }

}

/// <summary>
/// Block type for key_vault_credential in .
/// Nesting mode: list
/// </summary>
public partial class AzurermMssqlVirtualMachineKeyVaultCredentialBlock : TerraformBlockBase
{
    /// <summary>
    /// The key_vault_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultUrl is required")]
    [TerraformProperty("key_vault_url")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> KeyVaultUrl { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The service_principal_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServicePrincipalName is required")]
    [TerraformProperty("service_principal_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ServicePrincipalName { get; set; }

    /// <summary>
    /// The service_principal_secret attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServicePrincipalSecret is required")]
    [TerraformProperty("service_principal_secret")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ServicePrincipalSecret { get; set; }

}

/// <summary>
/// Block type for sql_instance in .
/// Nesting mode: list
/// </summary>
public partial class AzurermMssqlVirtualMachineSqlInstanceBlock : TerraformBlockBase
{
    /// <summary>
    /// The adhoc_workloads_optimization_enabled attribute.
    /// </summary>
    [TerraformProperty("adhoc_workloads_optimization_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? AdhocWorkloadsOptimizationEnabled { get; set; }

    /// <summary>
    /// The collation attribute.
    /// </summary>
    [TerraformProperty("collation")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Collation { get; set; }

    /// <summary>
    /// The instant_file_initialization_enabled attribute.
    /// </summary>
    [TerraformProperty("instant_file_initialization_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? InstantFileInitializationEnabled { get; set; }

    /// <summary>
    /// The lock_pages_in_memory_enabled attribute.
    /// </summary>
    [TerraformProperty("lock_pages_in_memory_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? LockPagesInMemoryEnabled { get; set; }

    /// <summary>
    /// The max_dop attribute.
    /// </summary>
    [TerraformProperty("max_dop")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? MaxDop { get; set; }

    /// <summary>
    /// The max_server_memory_mb attribute.
    /// </summary>
    [TerraformProperty("max_server_memory_mb")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? MaxServerMemoryMb { get; set; }

    /// <summary>
    /// The min_server_memory_mb attribute.
    /// </summary>
    [TerraformProperty("min_server_memory_mb")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? MinServerMemoryMb { get; set; }

}

/// <summary>
/// Block type for storage_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AzurermMssqlVirtualMachineStorageConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The disk_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DiskType is required")]
    [TerraformProperty("disk_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DiskType { get; set; }

    /// <summary>
    /// The storage_workload_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageWorkloadType is required")]
    [TerraformProperty("storage_workload_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> StorageWorkloadType { get; set; }

    /// <summary>
    /// The system_db_on_data_disk_enabled attribute.
    /// </summary>
    [TerraformProperty("system_db_on_data_disk_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? SystemDbOnDataDiskEnabled { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermMssqlVirtualMachineTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for wsfc_domain_credential in .
/// Nesting mode: list
/// </summary>
public partial class AzurermMssqlVirtualMachineWsfcDomainCredentialBlock : TerraformBlockBase
{
    /// <summary>
    /// The cluster_bootstrap_account_password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterBootstrapAccountPassword is required")]
    [TerraformProperty("cluster_bootstrap_account_password")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ClusterBootstrapAccountPassword { get; set; }

    /// <summary>
    /// The cluster_operator_account_password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterOperatorAccountPassword is required")]
    [TerraformProperty("cluster_operator_account_password")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ClusterOperatorAccountPassword { get; set; }

    /// <summary>
    /// The sql_service_account_password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SqlServiceAccountPassword is required")]
    [TerraformProperty("sql_service_account_password")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> SqlServiceAccountPassword { get; set; }

}

/// <summary>
/// Manages a azurerm_mssql_virtual_machine resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermMssqlVirtualMachine : TerraformResource
{
    public AzurermMssqlVirtualMachine(string name) : base("azurerm_mssql_virtual_machine", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The r_services_enabled attribute.
    /// </summary>
    [TerraformProperty("r_services_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? RServicesEnabled { get; set; }

    /// <summary>
    /// The sql_connectivity_port attribute.
    /// </summary>
    [TerraformProperty("sql_connectivity_port")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? SqlConnectivityPort { get; set; }

    /// <summary>
    /// The sql_connectivity_type attribute.
    /// </summary>
    [TerraformProperty("sql_connectivity_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SqlConnectivityType { get; set; }

    /// <summary>
    /// The sql_connectivity_update_password attribute.
    /// </summary>
    [TerraformProperty("sql_connectivity_update_password")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SqlConnectivityUpdatePassword { get; set; }

    /// <summary>
    /// The sql_connectivity_update_username attribute.
    /// </summary>
    [TerraformProperty("sql_connectivity_update_username")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SqlConnectivityUpdateUsername { get; set; }

    /// <summary>
    /// The sql_license_type attribute.
    /// </summary>
    [TerraformProperty("sql_license_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SqlLicenseType { get; set; }

    /// <summary>
    /// The sql_virtual_machine_group_id attribute.
    /// </summary>
    [TerraformProperty("sql_virtual_machine_group_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SqlVirtualMachineGroupId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The virtual_machine_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualMachineId is required")]
    [TerraformProperty("virtual_machine_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> VirtualMachineId { get; set; }

    /// <summary>
    /// Block for assessment.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Assessment block(s) allowed")]
    [TerraformProperty("assessment")]
    public TerraformList<TerraformBlock<AzurermMssqlVirtualMachineAssessmentBlock>>? Assessment { get; set; }

    /// <summary>
    /// Block for auto_backup.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoBackup block(s) allowed")]
    [TerraformProperty("auto_backup")]
    public TerraformList<TerraformBlock<AzurermMssqlVirtualMachineAutoBackupBlock>>? AutoBackup { get; set; }

    /// <summary>
    /// Block for auto_patching.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoPatching block(s) allowed")]
    [TerraformProperty("auto_patching")]
    public TerraformList<TerraformBlock<AzurermMssqlVirtualMachineAutoPatchingBlock>>? AutoPatching { get; set; }

    /// <summary>
    /// Block for key_vault_credential.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KeyVaultCredential block(s) allowed")]
    [TerraformProperty("key_vault_credential")]
    public TerraformList<TerraformBlock<AzurermMssqlVirtualMachineKeyVaultCredentialBlock>>? KeyVaultCredential { get; set; }

    /// <summary>
    /// Block for sql_instance.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SqlInstance block(s) allowed")]
    [TerraformProperty("sql_instance")]
    public TerraformList<TerraformBlock<AzurermMssqlVirtualMachineSqlInstanceBlock>>? SqlInstance { get; set; }

    /// <summary>
    /// Block for storage_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageConfiguration block(s) allowed")]
    [TerraformProperty("storage_configuration")]
    public TerraformList<TerraformBlock<AzurermMssqlVirtualMachineStorageConfigurationBlock>>? StorageConfiguration { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermMssqlVirtualMachineTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for wsfc_domain_credential.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WsfcDomainCredential block(s) allowed")]
    [TerraformProperty("wsfc_domain_credential")]
    public TerraformList<TerraformBlock<AzurermMssqlVirtualMachineWsfcDomainCredentialBlock>>? WsfcDomainCredential { get; set; }

}
