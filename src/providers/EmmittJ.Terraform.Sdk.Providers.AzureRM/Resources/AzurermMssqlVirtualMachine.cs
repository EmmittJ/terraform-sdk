using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for assessment in .
/// Nesting mode: list
/// </summary>
public class AzurermMssqlVirtualMachineAssessmentBlock : ITerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Enabled { get; set; }

    /// <summary>
    /// The run_immediately attribute.
    /// </summary>
    [TerraformPropertyName("run_immediately")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? RunImmediately { get; set; }

}

/// <summary>
/// Block type for auto_backup in .
/// Nesting mode: list
/// </summary>
public class AzurermMssqlVirtualMachineAutoBackupBlock : ITerraformBlock
{
    /// <summary>
    /// The encryption_enabled attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformPropertyName("encryption_enabled")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> EncryptionEnabled { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>("", "encryption_enabled");

    /// <summary>
    /// The encryption_password attribute.
    /// </summary>
    [TerraformPropertyName("encryption_password")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? EncryptionPassword { get; set; }

    /// <summary>
    /// The retention_period_in_days attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RetentionPeriodInDays is required")]
    [TerraformPropertyName("retention_period_in_days")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> RetentionPeriodInDays { get; set; }

    /// <summary>
    /// The storage_account_access_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountAccessKey is required")]
    [TerraformPropertyName("storage_account_access_key")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> StorageAccountAccessKey { get; set; }

    /// <summary>
    /// The storage_blob_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageBlobEndpoint is required")]
    [TerraformPropertyName("storage_blob_endpoint")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> StorageBlobEndpoint { get; set; }

    /// <summary>
    /// The system_databases_backup_enabled attribute.
    /// </summary>
    [TerraformPropertyName("system_databases_backup_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? SystemDatabasesBackupEnabled { get; set; }

}

/// <summary>
/// Block type for auto_patching in .
/// Nesting mode: list
/// </summary>
public class AzurermMssqlVirtualMachineAutoPatchingBlock : ITerraformBlock
{
    /// <summary>
    /// The day_of_week attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DayOfWeek is required")]
    [TerraformPropertyName("day_of_week")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DayOfWeek { get; set; }

    /// <summary>
    /// The maintenance_window_duration_in_minutes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaintenanceWindowDurationInMinutes is required")]
    [TerraformPropertyName("maintenance_window_duration_in_minutes")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> MaintenanceWindowDurationInMinutes { get; set; }

    /// <summary>
    /// The maintenance_window_starting_hour attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaintenanceWindowStartingHour is required")]
    [TerraformPropertyName("maintenance_window_starting_hour")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> MaintenanceWindowStartingHour { get; set; }

}

/// <summary>
/// Block type for key_vault_credential in .
/// Nesting mode: list
/// </summary>
public class AzurermMssqlVirtualMachineKeyVaultCredentialBlock : ITerraformBlock
{
    /// <summary>
    /// The key_vault_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultUrl is required")]
    [TerraformPropertyName("key_vault_url")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> KeyVaultUrl { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The service_principal_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServicePrincipalName is required")]
    [TerraformPropertyName("service_principal_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ServicePrincipalName { get; set; }

    /// <summary>
    /// The service_principal_secret attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServicePrincipalSecret is required")]
    [TerraformPropertyName("service_principal_secret")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ServicePrincipalSecret { get; set; }

}

/// <summary>
/// Block type for sql_instance in .
/// Nesting mode: list
/// </summary>
public class AzurermMssqlVirtualMachineSqlInstanceBlock : ITerraformBlock
{
    /// <summary>
    /// The adhoc_workloads_optimization_enabled attribute.
    /// </summary>
    [TerraformPropertyName("adhoc_workloads_optimization_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AdhocWorkloadsOptimizationEnabled { get; set; }

    /// <summary>
    /// The collation attribute.
    /// </summary>
    [TerraformPropertyName("collation")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Collation { get; set; }

    /// <summary>
    /// The instant_file_initialization_enabled attribute.
    /// </summary>
    [TerraformPropertyName("instant_file_initialization_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? InstantFileInitializationEnabled { get; set; }

    /// <summary>
    /// The lock_pages_in_memory_enabled attribute.
    /// </summary>
    [TerraformPropertyName("lock_pages_in_memory_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? LockPagesInMemoryEnabled { get; set; }

    /// <summary>
    /// The max_dop attribute.
    /// </summary>
    [TerraformPropertyName("max_dop")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MaxDop { get; set; }

    /// <summary>
    /// The max_server_memory_mb attribute.
    /// </summary>
    [TerraformPropertyName("max_server_memory_mb")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MaxServerMemoryMb { get; set; }

    /// <summary>
    /// The min_server_memory_mb attribute.
    /// </summary>
    [TerraformPropertyName("min_server_memory_mb")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MinServerMemoryMb { get; set; }

}

/// <summary>
/// Block type for storage_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermMssqlVirtualMachineStorageConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The disk_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DiskType is required")]
    [TerraformPropertyName("disk_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DiskType { get; set; }

    /// <summary>
    /// The storage_workload_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageWorkloadType is required")]
    [TerraformPropertyName("storage_workload_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> StorageWorkloadType { get; set; }

    /// <summary>
    /// The system_db_on_data_disk_enabled attribute.
    /// </summary>
    [TerraformPropertyName("system_db_on_data_disk_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? SystemDbOnDataDiskEnabled { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMssqlVirtualMachineTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Block type for wsfc_domain_credential in .
/// Nesting mode: list
/// </summary>
public class AzurermMssqlVirtualMachineWsfcDomainCredentialBlock : ITerraformBlock
{
    /// <summary>
    /// The cluster_bootstrap_account_password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterBootstrapAccountPassword is required")]
    [TerraformPropertyName("cluster_bootstrap_account_password")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ClusterBootstrapAccountPassword { get; set; }

    /// <summary>
    /// The cluster_operator_account_password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterOperatorAccountPassword is required")]
    [TerraformPropertyName("cluster_operator_account_password")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ClusterOperatorAccountPassword { get; set; }

    /// <summary>
    /// The sql_service_account_password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SqlServiceAccountPassword is required")]
    [TerraformPropertyName("sql_service_account_password")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SqlServiceAccountPassword { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The r_services_enabled attribute.
    /// </summary>
    [TerraformPropertyName("r_services_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? RServicesEnabled { get; set; }

    /// <summary>
    /// The sql_connectivity_port attribute.
    /// </summary>
    [TerraformPropertyName("sql_connectivity_port")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? SqlConnectivityPort { get; set; }

    /// <summary>
    /// The sql_connectivity_type attribute.
    /// </summary>
    [TerraformPropertyName("sql_connectivity_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SqlConnectivityType { get; set; }

    /// <summary>
    /// The sql_connectivity_update_password attribute.
    /// </summary>
    [TerraformPropertyName("sql_connectivity_update_password")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SqlConnectivityUpdatePassword { get; set; }

    /// <summary>
    /// The sql_connectivity_update_username attribute.
    /// </summary>
    [TerraformPropertyName("sql_connectivity_update_username")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SqlConnectivityUpdateUsername { get; set; }

    /// <summary>
    /// The sql_license_type attribute.
    /// </summary>
    [TerraformPropertyName("sql_license_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SqlLicenseType { get; set; }

    /// <summary>
    /// The sql_virtual_machine_group_id attribute.
    /// </summary>
    [TerraformPropertyName("sql_virtual_machine_group_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SqlVirtualMachineGroupId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The virtual_machine_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualMachineId is required")]
    [TerraformPropertyName("virtual_machine_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> VirtualMachineId { get; set; }

    /// <summary>
    /// Block for assessment.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Assessment block(s) allowed")]
    [TerraformPropertyName("assessment")]
    public TerraformList<TerraformBlock<AzurermMssqlVirtualMachineAssessmentBlock>>? Assessment { get; set; } = new();

    /// <summary>
    /// Block for auto_backup.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoBackup block(s) allowed")]
    [TerraformPropertyName("auto_backup")]
    public TerraformList<TerraformBlock<AzurermMssqlVirtualMachineAutoBackupBlock>>? AutoBackup { get; set; } = new();

    /// <summary>
    /// Block for auto_patching.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoPatching block(s) allowed")]
    [TerraformPropertyName("auto_patching")]
    public TerraformList<TerraformBlock<AzurermMssqlVirtualMachineAutoPatchingBlock>>? AutoPatching { get; set; } = new();

    /// <summary>
    /// Block for key_vault_credential.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KeyVaultCredential block(s) allowed")]
    [TerraformPropertyName("key_vault_credential")]
    public TerraformList<TerraformBlock<AzurermMssqlVirtualMachineKeyVaultCredentialBlock>>? KeyVaultCredential { get; set; } = new();

    /// <summary>
    /// Block for sql_instance.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SqlInstance block(s) allowed")]
    [TerraformPropertyName("sql_instance")]
    public TerraformList<TerraformBlock<AzurermMssqlVirtualMachineSqlInstanceBlock>>? SqlInstance { get; set; } = new();

    /// <summary>
    /// Block for storage_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageConfiguration block(s) allowed")]
    [TerraformPropertyName("storage_configuration")]
    public TerraformList<TerraformBlock<AzurermMssqlVirtualMachineStorageConfigurationBlock>>? StorageConfiguration { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermMssqlVirtualMachineTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Block for wsfc_domain_credential.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WsfcDomainCredential block(s) allowed")]
    [TerraformPropertyName("wsfc_domain_credential")]
    public TerraformList<TerraformBlock<AzurermMssqlVirtualMachineWsfcDomainCredentialBlock>>? WsfcDomainCredential { get; set; } = new();

}
