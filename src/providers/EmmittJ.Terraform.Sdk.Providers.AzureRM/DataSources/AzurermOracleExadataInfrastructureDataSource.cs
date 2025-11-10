using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermOracleExadataInfrastructureDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_oracle_exadata_infrastructure.
/// </summary>
public class AzurermOracleExadataInfrastructureDataSource : TerraformDataSource
{
    public AzurermOracleExadataInfrastructureDataSource(string name) : base("azurerm_oracle_exadata_infrastructure", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("activated_storage_count");
        SetOutput("additional_storage_count");
        SetOutput("available_storage_size_in_gbs");
        SetOutput("compute_count");
        SetOutput("compute_model");
        SetOutput("cpu_count");
        SetOutput("customer_contacts");
        SetOutput("data_storage_size_in_tbs");
        SetOutput("database_server_type");
        SetOutput("db_node_storage_size_in_gbs");
        SetOutput("db_server_version");
        SetOutput("defined_file_system_configuration");
        SetOutput("display_name");
        SetOutput("estimated_patching_time");
        SetOutput("last_maintenance_run_id");
        SetOutput("lifecycle_details");
        SetOutput("lifecycle_state");
        SetOutput("location");
        SetOutput("maintenance_window");
        SetOutput("max_cpu_count");
        SetOutput("max_data_storage_in_tbs");
        SetOutput("max_db_node_storage_size_in_gbs");
        SetOutput("max_memory_in_gbs");
        SetOutput("memory_size_in_gbs");
        SetOutput("monthly_db_server_version");
        SetOutput("monthly_storage_server_version");
        SetOutput("next_maintenance_run_id");
        SetOutput("oci_url");
        SetOutput("ocid");
        SetOutput("shape");
        SetOutput("storage_count");
        SetOutput("storage_server_type");
        SetOutput("storage_server_version");
        SetOutput("tags");
        SetOutput("time_created");
        SetOutput("total_storage_size_in_gbs");
        SetOutput("zones");
        SetOutput("id");
        SetOutput("name");
        SetOutput("resource_group_name");
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermOracleExadataInfrastructureDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The activated_storage_count attribute.
    /// </summary>
    public TerraformExpression ActivatedStorageCount => this["activated_storage_count"];

    /// <summary>
    /// The additional_storage_count attribute.
    /// </summary>
    public TerraformExpression AdditionalStorageCount => this["additional_storage_count"];

    /// <summary>
    /// The available_storage_size_in_gbs attribute.
    /// </summary>
    public TerraformExpression AvailableStorageSizeInGbs => this["available_storage_size_in_gbs"];

    /// <summary>
    /// The compute_count attribute.
    /// </summary>
    public TerraformExpression ComputeCount => this["compute_count"];

    /// <summary>
    /// The compute_model attribute.
    /// </summary>
    public TerraformExpression ComputeModel => this["compute_model"];

    /// <summary>
    /// The cpu_count attribute.
    /// </summary>
    public TerraformExpression CpuCount => this["cpu_count"];

    /// <summary>
    /// The customer_contacts attribute.
    /// </summary>
    public TerraformExpression CustomerContacts => this["customer_contacts"];

    /// <summary>
    /// The data_storage_size_in_tbs attribute.
    /// </summary>
    public TerraformExpression DataStorageSizeInTbs => this["data_storage_size_in_tbs"];

    /// <summary>
    /// The database_server_type attribute.
    /// </summary>
    public TerraformExpression DatabaseServerType => this["database_server_type"];

    /// <summary>
    /// The db_node_storage_size_in_gbs attribute.
    /// </summary>
    public TerraformExpression DbNodeStorageSizeInGbs => this["db_node_storage_size_in_gbs"];

    /// <summary>
    /// The db_server_version attribute.
    /// </summary>
    public TerraformExpression DbServerVersion => this["db_server_version"];

    /// <summary>
    /// The defined_file_system_configuration attribute.
    /// </summary>
    public TerraformExpression DefinedFileSystemConfiguration => this["defined_file_system_configuration"];

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformExpression DisplayName => this["display_name"];

    /// <summary>
    /// The estimated_patching_time attribute.
    /// </summary>
    public TerraformExpression EstimatedPatchingTime => this["estimated_patching_time"];

    /// <summary>
    /// The last_maintenance_run_id attribute.
    /// </summary>
    public TerraformExpression LastMaintenanceRunId => this["last_maintenance_run_id"];

    /// <summary>
    /// The lifecycle_details attribute.
    /// </summary>
    public TerraformExpression LifecycleDetails => this["lifecycle_details"];

    /// <summary>
    /// The lifecycle_state attribute.
    /// </summary>
    public TerraformExpression LifecycleState => this["lifecycle_state"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The maintenance_window attribute.
    /// </summary>
    public TerraformExpression MaintenanceWindow => this["maintenance_window"];

    /// <summary>
    /// The max_cpu_count attribute.
    /// </summary>
    public TerraformExpression MaxCpuCount => this["max_cpu_count"];

    /// <summary>
    /// The max_data_storage_in_tbs attribute.
    /// </summary>
    public TerraformExpression MaxDataStorageInTbs => this["max_data_storage_in_tbs"];

    /// <summary>
    /// The max_db_node_storage_size_in_gbs attribute.
    /// </summary>
    public TerraformExpression MaxDbNodeStorageSizeInGbs => this["max_db_node_storage_size_in_gbs"];

    /// <summary>
    /// The max_memory_in_gbs attribute.
    /// </summary>
    public TerraformExpression MaxMemoryInGbs => this["max_memory_in_gbs"];

    /// <summary>
    /// The memory_size_in_gbs attribute.
    /// </summary>
    public TerraformExpression MemorySizeInGbs => this["memory_size_in_gbs"];

    /// <summary>
    /// The monthly_db_server_version attribute.
    /// </summary>
    public TerraformExpression MonthlyDbServerVersion => this["monthly_db_server_version"];

    /// <summary>
    /// The monthly_storage_server_version attribute.
    /// </summary>
    public TerraformExpression MonthlyStorageServerVersion => this["monthly_storage_server_version"];

    /// <summary>
    /// The next_maintenance_run_id attribute.
    /// </summary>
    public TerraformExpression NextMaintenanceRunId => this["next_maintenance_run_id"];

    /// <summary>
    /// The oci_url attribute.
    /// </summary>
    public TerraformExpression OciUrl => this["oci_url"];

    /// <summary>
    /// The ocid attribute.
    /// </summary>
    public TerraformExpression Ocid => this["ocid"];

    /// <summary>
    /// The shape attribute.
    /// </summary>
    public TerraformExpression Shape => this["shape"];

    /// <summary>
    /// The storage_count attribute.
    /// </summary>
    public TerraformExpression StorageCount => this["storage_count"];

    /// <summary>
    /// The storage_server_type attribute.
    /// </summary>
    public TerraformExpression StorageServerType => this["storage_server_type"];

    /// <summary>
    /// The storage_server_version attribute.
    /// </summary>
    public TerraformExpression StorageServerVersion => this["storage_server_version"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The time_created attribute.
    /// </summary>
    public TerraformExpression TimeCreated => this["time_created"];

    /// <summary>
    /// The total_storage_size_in_gbs attribute.
    /// </summary>
    public TerraformExpression TotalStorageSizeInGbs => this["total_storage_size_in_gbs"];

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public TerraformExpression Zones => this["zones"];

}
