using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermOracleExadataInfrastructureDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_oracle_exadata_infrastructure.
/// </summary>
public class AzurermOracleExadataInfrastructureDataSource : TerraformDataSource
{
    public AzurermOracleExadataInfrastructureDataSource(string name) : base("azurerm_oracle_exadata_infrastructure", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermOracleExadataInfrastructureDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The activated_storage_count attribute.
    /// </summary>
    [TerraformPropertyName("activated_storage_count")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> ActivatedStorageCount => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "activated_storage_count");

    /// <summary>
    /// The additional_storage_count attribute.
    /// </summary>
    [TerraformPropertyName("additional_storage_count")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> AdditionalStorageCount => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "additional_storage_count");

    /// <summary>
    /// The available_storage_size_in_gbs attribute.
    /// </summary>
    [TerraformPropertyName("available_storage_size_in_gbs")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> AvailableStorageSizeInGbs => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "available_storage_size_in_gbs");

    /// <summary>
    /// The compute_count attribute.
    /// </summary>
    [TerraformPropertyName("compute_count")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> ComputeCount => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "compute_count");

    /// <summary>
    /// The compute_model attribute.
    /// </summary>
    [TerraformPropertyName("compute_model")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ComputeModel => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "compute_model");

    /// <summary>
    /// The cpu_count attribute.
    /// </summary>
    [TerraformPropertyName("cpu_count")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> CpuCount => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "cpu_count");

    /// <summary>
    /// The customer_contacts attribute.
    /// </summary>
    [TerraformPropertyName("customer_contacts")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> CustomerContacts => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "customer_contacts");

    /// <summary>
    /// The data_storage_size_in_tbs attribute.
    /// </summary>
    [TerraformPropertyName("data_storage_size_in_tbs")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> DataStorageSizeInTbs => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "data_storage_size_in_tbs");

    /// <summary>
    /// The database_server_type attribute.
    /// </summary>
    [TerraformPropertyName("database_server_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DatabaseServerType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "database_server_type");

    /// <summary>
    /// The db_node_storage_size_in_gbs attribute.
    /// </summary>
    [TerraformPropertyName("db_node_storage_size_in_gbs")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> DbNodeStorageSizeInGbs => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "db_node_storage_size_in_gbs");

    /// <summary>
    /// The db_server_version attribute.
    /// </summary>
    [TerraformPropertyName("db_server_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DbServerVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "db_server_version");

    /// <summary>
    /// The defined_file_system_configuration attribute.
    /// </summary>
    [TerraformPropertyName("defined_file_system_configuration")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> DefinedFileSystemConfiguration => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "defined_file_system_configuration");

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DisplayName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "display_name");

    /// <summary>
    /// The estimated_patching_time attribute.
    /// </summary>
    [TerraformPropertyName("estimated_patching_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> EstimatedPatchingTime => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "estimated_patching_time");

    /// <summary>
    /// The last_maintenance_run_id attribute.
    /// </summary>
    [TerraformPropertyName("last_maintenance_run_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LastMaintenanceRunId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "last_maintenance_run_id");

    /// <summary>
    /// The lifecycle_details attribute.
    /// </summary>
    [TerraformPropertyName("lifecycle_details")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LifecycleDetails => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "lifecycle_details");

    /// <summary>
    /// The lifecycle_state attribute.
    /// </summary>
    [TerraformPropertyName("lifecycle_state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LifecycleState => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "lifecycle_state");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Location => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "location");

    /// <summary>
    /// The maintenance_window attribute.
    /// </summary>
    [TerraformPropertyName("maintenance_window")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> MaintenanceWindow => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "maintenance_window");

    /// <summary>
    /// The max_cpu_count attribute.
    /// </summary>
    [TerraformPropertyName("max_cpu_count")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> MaxCpuCount => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "max_cpu_count");

    /// <summary>
    /// The max_data_storage_in_tbs attribute.
    /// </summary>
    [TerraformPropertyName("max_data_storage_in_tbs")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> MaxDataStorageInTbs => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "max_data_storage_in_tbs");

    /// <summary>
    /// The max_db_node_storage_size_in_gbs attribute.
    /// </summary>
    [TerraformPropertyName("max_db_node_storage_size_in_gbs")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> MaxDbNodeStorageSizeInGbs => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "max_db_node_storage_size_in_gbs");

    /// <summary>
    /// The max_memory_in_gbs attribute.
    /// </summary>
    [TerraformPropertyName("max_memory_in_gbs")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> MaxMemoryInGbs => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "max_memory_in_gbs");

    /// <summary>
    /// The memory_size_in_gbs attribute.
    /// </summary>
    [TerraformPropertyName("memory_size_in_gbs")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> MemorySizeInGbs => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "memory_size_in_gbs");

    /// <summary>
    /// The monthly_db_server_version attribute.
    /// </summary>
    [TerraformPropertyName("monthly_db_server_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> MonthlyDbServerVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "monthly_db_server_version");

    /// <summary>
    /// The monthly_storage_server_version attribute.
    /// </summary>
    [TerraformPropertyName("monthly_storage_server_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> MonthlyStorageServerVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "monthly_storage_server_version");

    /// <summary>
    /// The next_maintenance_run_id attribute.
    /// </summary>
    [TerraformPropertyName("next_maintenance_run_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NextMaintenanceRunId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "next_maintenance_run_id");

    /// <summary>
    /// The oci_url attribute.
    /// </summary>
    [TerraformPropertyName("oci_url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OciUrl => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "oci_url");

    /// <summary>
    /// The ocid attribute.
    /// </summary>
    [TerraformPropertyName("ocid")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Ocid => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ocid");

    /// <summary>
    /// The shape attribute.
    /// </summary>
    [TerraformPropertyName("shape")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Shape => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "shape");

    /// <summary>
    /// The storage_count attribute.
    /// </summary>
    [TerraformPropertyName("storage_count")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> StorageCount => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "storage_count");

    /// <summary>
    /// The storage_server_type attribute.
    /// </summary>
    [TerraformPropertyName("storage_server_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StorageServerType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "storage_server_type");

    /// <summary>
    /// The storage_server_version attribute.
    /// </summary>
    [TerraformPropertyName("storage_server_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StorageServerVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "storage_server_version");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The time_created attribute.
    /// </summary>
    [TerraformPropertyName("time_created")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TimeCreated => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "time_created");

    /// <summary>
    /// The total_storage_size_in_gbs attribute.
    /// </summary>
    [TerraformPropertyName("total_storage_size_in_gbs")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> TotalStorageSizeInGbs => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "total_storage_size_in_gbs");

    /// <summary>
    /// The zones attribute.
    /// </summary>
    [TerraformPropertyName("zones")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> Zones => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "zones");

}
