using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for assessment in .
/// Nesting mode: list
/// </summary>
public class AzurermMssqlVirtualMachineAssessmentBlock : TerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => WithProperty("enabled", value);
    }

    /// <summary>
    /// The run_immediately attribute.
    /// </summary>
    public TerraformProperty<bool>? RunImmediately
    {
        get => GetProperty<TerraformProperty<bool>>("run_immediately");
        set => WithProperty("run_immediately", value);
    }

}

/// <summary>
/// Block type for auto_backup in .
/// Nesting mode: list
/// </summary>
public class AzurermMssqlVirtualMachineAutoBackupBlock : TerraformBlock
{
    /// <summary>
    /// The encryption_enabled attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<bool>? EncryptionEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("encryption_enabled");
        set => WithProperty("encryption_enabled", value);
    }

    /// <summary>
    /// The encryption_password attribute.
    /// </summary>
    public TerraformProperty<string>? EncryptionPassword
    {
        get => GetProperty<TerraformProperty<string>>("encryption_password");
        set => WithProperty("encryption_password", value);
    }

    /// <summary>
    /// The retention_period_in_days attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RetentionPeriodInDays is required")]
    public required TerraformProperty<double> RetentionPeriodInDays
    {
        get => GetProperty<TerraformProperty<double>>("retention_period_in_days");
        set => WithProperty("retention_period_in_days", value);
    }

    /// <summary>
    /// The storage_account_access_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountAccessKey is required")]
    public required TerraformProperty<string> StorageAccountAccessKey
    {
        get => GetProperty<TerraformProperty<string>>("storage_account_access_key");
        set => WithProperty("storage_account_access_key", value);
    }

    /// <summary>
    /// The storage_blob_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageBlobEndpoint is required")]
    public required TerraformProperty<string> StorageBlobEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("storage_blob_endpoint");
        set => WithProperty("storage_blob_endpoint", value);
    }

    /// <summary>
    /// The system_databases_backup_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? SystemDatabasesBackupEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("system_databases_backup_enabled");
        set => WithProperty("system_databases_backup_enabled", value);
    }

}

/// <summary>
/// Block type for auto_patching in .
/// Nesting mode: list
/// </summary>
public class AzurermMssqlVirtualMachineAutoPatchingBlock : TerraformBlock
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
    /// The maintenance_window_duration_in_minutes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaintenanceWindowDurationInMinutes is required")]
    public required TerraformProperty<double> MaintenanceWindowDurationInMinutes
    {
        get => GetProperty<TerraformProperty<double>>("maintenance_window_duration_in_minutes");
        set => WithProperty("maintenance_window_duration_in_minutes", value);
    }

    /// <summary>
    /// The maintenance_window_starting_hour attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaintenanceWindowStartingHour is required")]
    public required TerraformProperty<double> MaintenanceWindowStartingHour
    {
        get => GetProperty<TerraformProperty<double>>("maintenance_window_starting_hour");
        set => WithProperty("maintenance_window_starting_hour", value);
    }

}

/// <summary>
/// Block type for key_vault_credential in .
/// Nesting mode: list
/// </summary>
public class AzurermMssqlVirtualMachineKeyVaultCredentialBlock : TerraformBlock
{
    /// <summary>
    /// The key_vault_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultUrl is required")]
    public required TerraformProperty<string> KeyVaultUrl
    {
        get => GetProperty<TerraformProperty<string>>("key_vault_url");
        set => WithProperty("key_vault_url", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The service_principal_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServicePrincipalName is required")]
    public required TerraformProperty<string> ServicePrincipalName
    {
        get => GetProperty<TerraformProperty<string>>("service_principal_name");
        set => WithProperty("service_principal_name", value);
    }

    /// <summary>
    /// The service_principal_secret attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServicePrincipalSecret is required")]
    public required TerraformProperty<string> ServicePrincipalSecret
    {
        get => GetProperty<TerraformProperty<string>>("service_principal_secret");
        set => WithProperty("service_principal_secret", value);
    }

}

/// <summary>
/// Block type for sql_instance in .
/// Nesting mode: list
/// </summary>
public class AzurermMssqlVirtualMachineSqlInstanceBlock : TerraformBlock
{
    /// <summary>
    /// The adhoc_workloads_optimization_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? AdhocWorkloadsOptimizationEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("adhoc_workloads_optimization_enabled");
        set => WithProperty("adhoc_workloads_optimization_enabled", value);
    }

    /// <summary>
    /// The collation attribute.
    /// </summary>
    public TerraformProperty<string>? Collation
    {
        get => GetProperty<TerraformProperty<string>>("collation");
        set => WithProperty("collation", value);
    }

    /// <summary>
    /// The instant_file_initialization_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? InstantFileInitializationEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("instant_file_initialization_enabled");
        set => WithProperty("instant_file_initialization_enabled", value);
    }

    /// <summary>
    /// The lock_pages_in_memory_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? LockPagesInMemoryEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("lock_pages_in_memory_enabled");
        set => WithProperty("lock_pages_in_memory_enabled", value);
    }

    /// <summary>
    /// The max_dop attribute.
    /// </summary>
    public TerraformProperty<double>? MaxDop
    {
        get => GetProperty<TerraformProperty<double>>("max_dop");
        set => WithProperty("max_dop", value);
    }

    /// <summary>
    /// The max_server_memory_mb attribute.
    /// </summary>
    public TerraformProperty<double>? MaxServerMemoryMb
    {
        get => GetProperty<TerraformProperty<double>>("max_server_memory_mb");
        set => WithProperty("max_server_memory_mb", value);
    }

    /// <summary>
    /// The min_server_memory_mb attribute.
    /// </summary>
    public TerraformProperty<double>? MinServerMemoryMb
    {
        get => GetProperty<TerraformProperty<double>>("min_server_memory_mb");
        set => WithProperty("min_server_memory_mb", value);
    }

}

/// <summary>
/// Block type for storage_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermMssqlVirtualMachineStorageConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The disk_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DiskType is required")]
    public required TerraformProperty<string> DiskType
    {
        get => GetProperty<TerraformProperty<string>>("disk_type");
        set => WithProperty("disk_type", value);
    }

    /// <summary>
    /// The storage_workload_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageWorkloadType is required")]
    public required TerraformProperty<string> StorageWorkloadType
    {
        get => GetProperty<TerraformProperty<string>>("storage_workload_type");
        set => WithProperty("storage_workload_type", value);
    }

    /// <summary>
    /// The system_db_on_data_disk_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? SystemDbOnDataDiskEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("system_db_on_data_disk_enabled");
        set => WithProperty("system_db_on_data_disk_enabled", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMssqlVirtualMachineTimeoutsBlock : TerraformBlock
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
/// Block type for wsfc_domain_credential in .
/// Nesting mode: list
/// </summary>
public class AzurermMssqlVirtualMachineWsfcDomainCredentialBlock : TerraformBlock
{
    /// <summary>
    /// The cluster_bootstrap_account_password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterBootstrapAccountPassword is required")]
    public required TerraformProperty<string> ClusterBootstrapAccountPassword
    {
        get => GetProperty<TerraformProperty<string>>("cluster_bootstrap_account_password");
        set => WithProperty("cluster_bootstrap_account_password", value);
    }

    /// <summary>
    /// The cluster_operator_account_password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterOperatorAccountPassword is required")]
    public required TerraformProperty<string> ClusterOperatorAccountPassword
    {
        get => GetProperty<TerraformProperty<string>>("cluster_operator_account_password");
        set => WithProperty("cluster_operator_account_password", value);
    }

    /// <summary>
    /// The sql_service_account_password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SqlServiceAccountPassword is required")]
    public required TerraformProperty<string> SqlServiceAccountPassword
    {
        get => GetProperty<TerraformProperty<string>>("sql_service_account_password");
        set => WithProperty("sql_service_account_password", value);
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
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The r_services_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? RServicesEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("r_services_enabled");
        set => this.WithProperty("r_services_enabled", value);
    }

    /// <summary>
    /// The sql_connectivity_port attribute.
    /// </summary>
    public TerraformProperty<double>? SqlConnectivityPort
    {
        get => GetProperty<TerraformProperty<double>>("sql_connectivity_port");
        set => this.WithProperty("sql_connectivity_port", value);
    }

    /// <summary>
    /// The sql_connectivity_type attribute.
    /// </summary>
    public TerraformProperty<string>? SqlConnectivityType
    {
        get => GetProperty<TerraformProperty<string>>("sql_connectivity_type");
        set => this.WithProperty("sql_connectivity_type", value);
    }

    /// <summary>
    /// The sql_connectivity_update_password attribute.
    /// </summary>
    public TerraformProperty<string>? SqlConnectivityUpdatePassword
    {
        get => GetProperty<TerraformProperty<string>>("sql_connectivity_update_password");
        set => this.WithProperty("sql_connectivity_update_password", value);
    }

    /// <summary>
    /// The sql_connectivity_update_username attribute.
    /// </summary>
    public TerraformProperty<string>? SqlConnectivityUpdateUsername
    {
        get => GetProperty<TerraformProperty<string>>("sql_connectivity_update_username");
        set => this.WithProperty("sql_connectivity_update_username", value);
    }

    /// <summary>
    /// The sql_license_type attribute.
    /// </summary>
    public TerraformProperty<string>? SqlLicenseType
    {
        get => GetProperty<TerraformProperty<string>>("sql_license_type");
        set => this.WithProperty("sql_license_type", value);
    }

    /// <summary>
    /// The sql_virtual_machine_group_id attribute.
    /// </summary>
    public TerraformProperty<string>? SqlVirtualMachineGroupId
    {
        get => GetProperty<TerraformProperty<string>>("sql_virtual_machine_group_id");
        set => this.WithProperty("sql_virtual_machine_group_id", value);
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
    /// The virtual_machine_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualMachineId is required")]
    public required TerraformProperty<string> VirtualMachineId
    {
        get => GetProperty<TerraformProperty<string>>("virtual_machine_id");
        set => this.WithProperty("virtual_machine_id", value);
    }

    /// <summary>
    /// Block for assessment.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Assessment block(s) allowed")]
    public List<AzurermMssqlVirtualMachineAssessmentBlock>? Assessment
    {
        get => GetProperty<List<AzurermMssqlVirtualMachineAssessmentBlock>>("assessment");
        set => this.WithProperty("assessment", value);
    }

    /// <summary>
    /// Block for auto_backup.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoBackup block(s) allowed")]
    public List<AzurermMssqlVirtualMachineAutoBackupBlock>? AutoBackup
    {
        get => GetProperty<List<AzurermMssqlVirtualMachineAutoBackupBlock>>("auto_backup");
        set => this.WithProperty("auto_backup", value);
    }

    /// <summary>
    /// Block for auto_patching.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoPatching block(s) allowed")]
    public List<AzurermMssqlVirtualMachineAutoPatchingBlock>? AutoPatching
    {
        get => GetProperty<List<AzurermMssqlVirtualMachineAutoPatchingBlock>>("auto_patching");
        set => this.WithProperty("auto_patching", value);
    }

    /// <summary>
    /// Block for key_vault_credential.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KeyVaultCredential block(s) allowed")]
    public List<AzurermMssqlVirtualMachineKeyVaultCredentialBlock>? KeyVaultCredential
    {
        get => GetProperty<List<AzurermMssqlVirtualMachineKeyVaultCredentialBlock>>("key_vault_credential");
        set => this.WithProperty("key_vault_credential", value);
    }

    /// <summary>
    /// Block for sql_instance.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SqlInstance block(s) allowed")]
    public List<AzurermMssqlVirtualMachineSqlInstanceBlock>? SqlInstance
    {
        get => GetProperty<List<AzurermMssqlVirtualMachineSqlInstanceBlock>>("sql_instance");
        set => this.WithProperty("sql_instance", value);
    }

    /// <summary>
    /// Block for storage_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageConfiguration block(s) allowed")]
    public List<AzurermMssqlVirtualMachineStorageConfigurationBlock>? StorageConfiguration
    {
        get => GetProperty<List<AzurermMssqlVirtualMachineStorageConfigurationBlock>>("storage_configuration");
        set => this.WithProperty("storage_configuration", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermMssqlVirtualMachineTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermMssqlVirtualMachineTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for wsfc_domain_credential.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WsfcDomainCredential block(s) allowed")]
    public List<AzurermMssqlVirtualMachineWsfcDomainCredentialBlock>? WsfcDomainCredential
    {
        get => GetProperty<List<AzurermMssqlVirtualMachineWsfcDomainCredentialBlock>>("wsfc_domain_credential");
        set => this.WithProperty("wsfc_domain_credential", value);
    }

}
