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
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// The run_immediately attribute.
    /// </summary>
    public TerraformProperty<bool>? RunImmediately
    {
        set => SetProperty("run_immediately", value);
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
        set => SetProperty("encryption_enabled", value);
    }

    /// <summary>
    /// The encryption_password attribute.
    /// </summary>
    public TerraformProperty<string>? EncryptionPassword
    {
        set => SetProperty("encryption_password", value);
    }

    /// <summary>
    /// The retention_period_in_days attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RetentionPeriodInDays is required")]
    public required TerraformProperty<double> RetentionPeriodInDays
    {
        set => SetProperty("retention_period_in_days", value);
    }

    /// <summary>
    /// The storage_account_access_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountAccessKey is required")]
    public required TerraformProperty<string> StorageAccountAccessKey
    {
        set => SetProperty("storage_account_access_key", value);
    }

    /// <summary>
    /// The storage_blob_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageBlobEndpoint is required")]
    public required TerraformProperty<string> StorageBlobEndpoint
    {
        set => SetProperty("storage_blob_endpoint", value);
    }

    /// <summary>
    /// The system_databases_backup_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? SystemDatabasesBackupEnabled
    {
        set => SetProperty("system_databases_backup_enabled", value);
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
        set => SetProperty("day_of_week", value);
    }

    /// <summary>
    /// The maintenance_window_duration_in_minutes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaintenanceWindowDurationInMinutes is required")]
    public required TerraformProperty<double> MaintenanceWindowDurationInMinutes
    {
        set => SetProperty("maintenance_window_duration_in_minutes", value);
    }

    /// <summary>
    /// The maintenance_window_starting_hour attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaintenanceWindowStartingHour is required")]
    public required TerraformProperty<double> MaintenanceWindowStartingHour
    {
        set => SetProperty("maintenance_window_starting_hour", value);
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
        set => SetProperty("key_vault_url", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The service_principal_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServicePrincipalName is required")]
    public required TerraformProperty<string> ServicePrincipalName
    {
        set => SetProperty("service_principal_name", value);
    }

    /// <summary>
    /// The service_principal_secret attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServicePrincipalSecret is required")]
    public required TerraformProperty<string> ServicePrincipalSecret
    {
        set => SetProperty("service_principal_secret", value);
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
        set => SetProperty("adhoc_workloads_optimization_enabled", value);
    }

    /// <summary>
    /// The collation attribute.
    /// </summary>
    public TerraformProperty<string>? Collation
    {
        set => SetProperty("collation", value);
    }

    /// <summary>
    /// The instant_file_initialization_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? InstantFileInitializationEnabled
    {
        set => SetProperty("instant_file_initialization_enabled", value);
    }

    /// <summary>
    /// The lock_pages_in_memory_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? LockPagesInMemoryEnabled
    {
        set => SetProperty("lock_pages_in_memory_enabled", value);
    }

    /// <summary>
    /// The max_dop attribute.
    /// </summary>
    public TerraformProperty<double>? MaxDop
    {
        set => SetProperty("max_dop", value);
    }

    /// <summary>
    /// The max_server_memory_mb attribute.
    /// </summary>
    public TerraformProperty<double>? MaxServerMemoryMb
    {
        set => SetProperty("max_server_memory_mb", value);
    }

    /// <summary>
    /// The min_server_memory_mb attribute.
    /// </summary>
    public TerraformProperty<double>? MinServerMemoryMb
    {
        set => SetProperty("min_server_memory_mb", value);
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
        set => SetProperty("disk_type", value);
    }

    /// <summary>
    /// The storage_workload_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageWorkloadType is required")]
    public required TerraformProperty<string> StorageWorkloadType
    {
        set => SetProperty("storage_workload_type", value);
    }

    /// <summary>
    /// The system_db_on_data_disk_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? SystemDbOnDataDiskEnabled
    {
        set => SetProperty("system_db_on_data_disk_enabled", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        set => SetProperty("cluster_bootstrap_account_password", value);
    }

    /// <summary>
    /// The cluster_operator_account_password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterOperatorAccountPassword is required")]
    public required TerraformProperty<string> ClusterOperatorAccountPassword
    {
        set => SetProperty("cluster_operator_account_password", value);
    }

    /// <summary>
    /// The sql_service_account_password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SqlServiceAccountPassword is required")]
    public required TerraformProperty<string> SqlServiceAccountPassword
    {
        set => SetProperty("sql_service_account_password", value);
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
        SetOutput("id");
        SetOutput("r_services_enabled");
        SetOutput("sql_connectivity_port");
        SetOutput("sql_connectivity_type");
        SetOutput("sql_connectivity_update_password");
        SetOutput("sql_connectivity_update_username");
        SetOutput("sql_license_type");
        SetOutput("sql_virtual_machine_group_id");
        SetOutput("tags");
        SetOutput("virtual_machine_id");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The r_services_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> RServicesEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("r_services_enabled");
        set => SetProperty("r_services_enabled", value);
    }

    /// <summary>
    /// The sql_connectivity_port attribute.
    /// </summary>
    public TerraformProperty<double> SqlConnectivityPort
    {
        get => GetRequiredOutput<TerraformProperty<double>>("sql_connectivity_port");
        set => SetProperty("sql_connectivity_port", value);
    }

    /// <summary>
    /// The sql_connectivity_type attribute.
    /// </summary>
    public TerraformProperty<string> SqlConnectivityType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sql_connectivity_type");
        set => SetProperty("sql_connectivity_type", value);
    }

    /// <summary>
    /// The sql_connectivity_update_password attribute.
    /// </summary>
    public TerraformProperty<string> SqlConnectivityUpdatePassword
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sql_connectivity_update_password");
        set => SetProperty("sql_connectivity_update_password", value);
    }

    /// <summary>
    /// The sql_connectivity_update_username attribute.
    /// </summary>
    public TerraformProperty<string> SqlConnectivityUpdateUsername
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sql_connectivity_update_username");
        set => SetProperty("sql_connectivity_update_username", value);
    }

    /// <summary>
    /// The sql_license_type attribute.
    /// </summary>
    public TerraformProperty<string> SqlLicenseType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sql_license_type");
        set => SetProperty("sql_license_type", value);
    }

    /// <summary>
    /// The sql_virtual_machine_group_id attribute.
    /// </summary>
    public TerraformProperty<string> SqlVirtualMachineGroupId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sql_virtual_machine_group_id");
        set => SetProperty("sql_virtual_machine_group_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The virtual_machine_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualMachineId is required")]
    public required TerraformProperty<string> VirtualMachineId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("virtual_machine_id");
        set => SetProperty("virtual_machine_id", value);
    }

    /// <summary>
    /// Block for assessment.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Assessment block(s) allowed")]
    public List<AzurermMssqlVirtualMachineAssessmentBlock>? Assessment
    {
        set => SetProperty("assessment", value);
    }

    /// <summary>
    /// Block for auto_backup.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoBackup block(s) allowed")]
    public List<AzurermMssqlVirtualMachineAutoBackupBlock>? AutoBackup
    {
        set => SetProperty("auto_backup", value);
    }

    /// <summary>
    /// Block for auto_patching.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoPatching block(s) allowed")]
    public List<AzurermMssqlVirtualMachineAutoPatchingBlock>? AutoPatching
    {
        set => SetProperty("auto_patching", value);
    }

    /// <summary>
    /// Block for key_vault_credential.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KeyVaultCredential block(s) allowed")]
    public List<AzurermMssqlVirtualMachineKeyVaultCredentialBlock>? KeyVaultCredential
    {
        set => SetProperty("key_vault_credential", value);
    }

    /// <summary>
    /// Block for sql_instance.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SqlInstance block(s) allowed")]
    public List<AzurermMssqlVirtualMachineSqlInstanceBlock>? SqlInstance
    {
        set => SetProperty("sql_instance", value);
    }

    /// <summary>
    /// Block for storage_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageConfiguration block(s) allowed")]
    public List<AzurermMssqlVirtualMachineStorageConfigurationBlock>? StorageConfiguration
    {
        set => SetProperty("storage_configuration", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermMssqlVirtualMachineTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for wsfc_domain_credential.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WsfcDomainCredential block(s) allowed")]
    public List<AzurermMssqlVirtualMachineWsfcDomainCredentialBlock>? WsfcDomainCredential
    {
        set => SetProperty("wsfc_domain_credential", value);
    }

}
