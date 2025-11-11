using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for assessment in .
/// Nesting mode: list
/// </summary>
public class AzurermMssqlVirtualMachineAssessmentBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The run_immediately attribute.
    /// </summary>
    [TerraformPropertyName("run_immediately")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? RunImmediately { get; set; }

}

/// <summary>
/// Block type for auto_backup in .
/// Nesting mode: list
/// </summary>
public class AzurermMssqlVirtualMachineAutoBackupBlock
{
    /// <summary>
    /// The encryption_enabled attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformPropertyName("encryption_enabled")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> EncryptionEnabled { get; set; } = default!;

    /// <summary>
    /// The encryption_password attribute.
    /// </summary>
    [TerraformPropertyName("encryption_password")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? EncryptionPassword { get; set; }

    /// <summary>
    /// The retention_period_in_days attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RetentionPeriodInDays is required")]
    [TerraformPropertyName("retention_period_in_days")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> RetentionPeriodInDays { get; set; }

    /// <summary>
    /// The storage_account_access_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountAccessKey is required")]
    [TerraformPropertyName("storage_account_access_key")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> StorageAccountAccessKey { get; set; }

    /// <summary>
    /// The storage_blob_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageBlobEndpoint is required")]
    [TerraformPropertyName("storage_blob_endpoint")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> StorageBlobEndpoint { get; set; }

    /// <summary>
    /// The system_databases_backup_enabled attribute.
    /// </summary>
    [TerraformPropertyName("system_databases_backup_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? SystemDatabasesBackupEnabled { get; set; }

}

/// <summary>
/// Block type for auto_patching in .
/// Nesting mode: list
/// </summary>
public class AzurermMssqlVirtualMachineAutoPatchingBlock
{
    /// <summary>
    /// The day_of_week attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DayOfWeek is required")]
    [TerraformPropertyName("day_of_week")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DayOfWeek { get; set; }

    /// <summary>
    /// The maintenance_window_duration_in_minutes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaintenanceWindowDurationInMinutes is required")]
    [TerraformPropertyName("maintenance_window_duration_in_minutes")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> MaintenanceWindowDurationInMinutes { get; set; }

    /// <summary>
    /// The maintenance_window_starting_hour attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaintenanceWindowStartingHour is required")]
    [TerraformPropertyName("maintenance_window_starting_hour")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> MaintenanceWindowStartingHour { get; set; }

}

/// <summary>
/// Block type for key_vault_credential in .
/// Nesting mode: list
/// </summary>
public class AzurermMssqlVirtualMachineKeyVaultCredentialBlock
{
    /// <summary>
    /// The key_vault_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultUrl is required")]
    [TerraformPropertyName("key_vault_url")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> KeyVaultUrl { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The service_principal_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServicePrincipalName is required")]
    [TerraformPropertyName("service_principal_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ServicePrincipalName { get; set; }

    /// <summary>
    /// The service_principal_secret attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServicePrincipalSecret is required")]
    [TerraformPropertyName("service_principal_secret")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ServicePrincipalSecret { get; set; }

}

/// <summary>
/// Block type for sql_instance in .
/// Nesting mode: list
/// </summary>
public class AzurermMssqlVirtualMachineSqlInstanceBlock
{
    /// <summary>
    /// The adhoc_workloads_optimization_enabled attribute.
    /// </summary>
    [TerraformPropertyName("adhoc_workloads_optimization_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AdhocWorkloadsOptimizationEnabled { get; set; }

    /// <summary>
    /// The collation attribute.
    /// </summary>
    [TerraformPropertyName("collation")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Collation { get; set; }

    /// <summary>
    /// The instant_file_initialization_enabled attribute.
    /// </summary>
    [TerraformPropertyName("instant_file_initialization_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? InstantFileInitializationEnabled { get; set; }

    /// <summary>
    /// The lock_pages_in_memory_enabled attribute.
    /// </summary>
    [TerraformPropertyName("lock_pages_in_memory_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? LockPagesInMemoryEnabled { get; set; }

    /// <summary>
    /// The max_dop attribute.
    /// </summary>
    [TerraformPropertyName("max_dop")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MaxDop { get; set; }

    /// <summary>
    /// The max_server_memory_mb attribute.
    /// </summary>
    [TerraformPropertyName("max_server_memory_mb")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MaxServerMemoryMb { get; set; }

    /// <summary>
    /// The min_server_memory_mb attribute.
    /// </summary>
    [TerraformPropertyName("min_server_memory_mb")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MinServerMemoryMb { get; set; }

}

/// <summary>
/// Block type for storage_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermMssqlVirtualMachineStorageConfigurationBlock
{
    /// <summary>
    /// The disk_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DiskType is required")]
    [TerraformPropertyName("disk_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DiskType { get; set; }

    /// <summary>
    /// The storage_workload_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageWorkloadType is required")]
    [TerraformPropertyName("storage_workload_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> StorageWorkloadType { get; set; }

    /// <summary>
    /// The system_db_on_data_disk_enabled attribute.
    /// </summary>
    [TerraformPropertyName("system_db_on_data_disk_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? SystemDbOnDataDiskEnabled { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMssqlVirtualMachineTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for wsfc_domain_credential in .
/// Nesting mode: list
/// </summary>
public class AzurermMssqlVirtualMachineWsfcDomainCredentialBlock
{
    /// <summary>
    /// The cluster_bootstrap_account_password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterBootstrapAccountPassword is required")]
    [TerraformPropertyName("cluster_bootstrap_account_password")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ClusterBootstrapAccountPassword { get; set; }

    /// <summary>
    /// The cluster_operator_account_password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterOperatorAccountPassword is required")]
    [TerraformPropertyName("cluster_operator_account_password")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ClusterOperatorAccountPassword { get; set; }

    /// <summary>
    /// The sql_service_account_password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SqlServiceAccountPassword is required")]
    [TerraformPropertyName("sql_service_account_password")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> SqlServiceAccountPassword { get; set; }

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
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The r_services_enabled attribute.
    /// </summary>
    [TerraformPropertyName("r_services_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? RServicesEnabled { get; set; }

    /// <summary>
    /// The sql_connectivity_port attribute.
    /// </summary>
    [TerraformPropertyName("sql_connectivity_port")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? SqlConnectivityPort { get; set; }

    /// <summary>
    /// The sql_connectivity_type attribute.
    /// </summary>
    [TerraformPropertyName("sql_connectivity_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SqlConnectivityType { get; set; }

    /// <summary>
    /// The sql_connectivity_update_password attribute.
    /// </summary>
    [TerraformPropertyName("sql_connectivity_update_password")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SqlConnectivityUpdatePassword { get; set; }

    /// <summary>
    /// The sql_connectivity_update_username attribute.
    /// </summary>
    [TerraformPropertyName("sql_connectivity_update_username")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SqlConnectivityUpdateUsername { get; set; }

    /// <summary>
    /// The sql_license_type attribute.
    /// </summary>
    [TerraformPropertyName("sql_license_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SqlLicenseType { get; set; }

    /// <summary>
    /// The sql_virtual_machine_group_id attribute.
    /// </summary>
    [TerraformPropertyName("sql_virtual_machine_group_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SqlVirtualMachineGroupId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The virtual_machine_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualMachineId is required")]
    [TerraformPropertyName("virtual_machine_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> VirtualMachineId { get; set; }

    /// <summary>
    /// Block for assessment.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Assessment block(s) allowed")]
    [TerraformPropertyName("assessment")]
    public TerraformList<TerraformBlock<AzurermMssqlVirtualMachineAssessmentBlock>>? Assessment { get; set; }

    /// <summary>
    /// Block for auto_backup.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoBackup block(s) allowed")]
    [TerraformPropertyName("auto_backup")]
    public TerraformList<TerraformBlock<AzurermMssqlVirtualMachineAutoBackupBlock>>? AutoBackup { get; set; }

    /// <summary>
    /// Block for auto_patching.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoPatching block(s) allowed")]
    [TerraformPropertyName("auto_patching")]
    public TerraformList<TerraformBlock<AzurermMssqlVirtualMachineAutoPatchingBlock>>? AutoPatching { get; set; }

    /// <summary>
    /// Block for key_vault_credential.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KeyVaultCredential block(s) allowed")]
    [TerraformPropertyName("key_vault_credential")]
    public TerraformList<TerraformBlock<AzurermMssqlVirtualMachineKeyVaultCredentialBlock>>? KeyVaultCredential { get; set; }

    /// <summary>
    /// Block for sql_instance.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SqlInstance block(s) allowed")]
    [TerraformPropertyName("sql_instance")]
    public TerraformList<TerraformBlock<AzurermMssqlVirtualMachineSqlInstanceBlock>>? SqlInstance { get; set; }

    /// <summary>
    /// Block for storage_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageConfiguration block(s) allowed")]
    [TerraformPropertyName("storage_configuration")]
    public TerraformList<TerraformBlock<AzurermMssqlVirtualMachineStorageConfigurationBlock>>? StorageConfiguration { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermMssqlVirtualMachineTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for wsfc_domain_credential.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WsfcDomainCredential block(s) allowed")]
    [TerraformPropertyName("wsfc_domain_credential")]
    public TerraformList<TerraformBlock<AzurermMssqlVirtualMachineWsfcDomainCredentialBlock>>? WsfcDomainCredential { get; set; }

}
