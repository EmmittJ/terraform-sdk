using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermOracleExadataInfrastructureDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

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
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermOracleExadataInfrastructureDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The activated_storage_count attribute.
    /// </summary>
    [TerraformPropertyName("activated_storage_count")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> ActivatedStorageCount => new TerraformReference(this, "activated_storage_count");

    /// <summary>
    /// The additional_storage_count attribute.
    /// </summary>
    [TerraformPropertyName("additional_storage_count")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> AdditionalStorageCount => new TerraformReference(this, "additional_storage_count");

    /// <summary>
    /// The available_storage_size_in_gbs attribute.
    /// </summary>
    [TerraformPropertyName("available_storage_size_in_gbs")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> AvailableStorageSizeInGbs => new TerraformReference(this, "available_storage_size_in_gbs");

    /// <summary>
    /// The compute_count attribute.
    /// </summary>
    [TerraformPropertyName("compute_count")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> ComputeCount => new TerraformReference(this, "compute_count");

    /// <summary>
    /// The compute_model attribute.
    /// </summary>
    [TerraformPropertyName("compute_model")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ComputeModel => new TerraformReference(this, "compute_model");

    /// <summary>
    /// The cpu_count attribute.
    /// </summary>
    [TerraformPropertyName("cpu_count")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> CpuCount => new TerraformReference(this, "cpu_count");

    /// <summary>
    /// The customer_contacts attribute.
    /// </summary>
    [TerraformPropertyName("customer_contacts")]
    // Output-only attribute - read-only reference
    public TerraformList<string> CustomerContacts => new TerraformReference(this, "customer_contacts");

    /// <summary>
    /// The data_storage_size_in_tbs attribute.
    /// </summary>
    [TerraformPropertyName("data_storage_size_in_tbs")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> DataStorageSizeInTbs => new TerraformReference(this, "data_storage_size_in_tbs");

    /// <summary>
    /// The database_server_type attribute.
    /// </summary>
    [TerraformPropertyName("database_server_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DatabaseServerType => new TerraformReference(this, "database_server_type");

    /// <summary>
    /// The db_node_storage_size_in_gbs attribute.
    /// </summary>
    [TerraformPropertyName("db_node_storage_size_in_gbs")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> DbNodeStorageSizeInGbs => new TerraformReference(this, "db_node_storage_size_in_gbs");

    /// <summary>
    /// The db_server_version attribute.
    /// </summary>
    [TerraformPropertyName("db_server_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DbServerVersion => new TerraformReference(this, "db_server_version");

    /// <summary>
    /// The defined_file_system_configuration attribute.
    /// </summary>
    [TerraformPropertyName("defined_file_system_configuration")]
    // Output-only attribute - read-only reference
    public TerraformList<object> DefinedFileSystemConfiguration => new TerraformReference(this, "defined_file_system_configuration");

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DisplayName => new TerraformReference(this, "display_name");

    /// <summary>
    /// The estimated_patching_time attribute.
    /// </summary>
    [TerraformPropertyName("estimated_patching_time")]
    // Output-only attribute - read-only reference
    public TerraformList<object> EstimatedPatchingTime => new TerraformReference(this, "estimated_patching_time");

    /// <summary>
    /// The last_maintenance_run_id attribute.
    /// </summary>
    [TerraformPropertyName("last_maintenance_run_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LastMaintenanceRunId => new TerraformReference(this, "last_maintenance_run_id");

    /// <summary>
    /// The lifecycle_details attribute.
    /// </summary>
    [TerraformPropertyName("lifecycle_details")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LifecycleDetails => new TerraformReference(this, "lifecycle_details");

    /// <summary>
    /// The lifecycle_state attribute.
    /// </summary>
    [TerraformPropertyName("lifecycle_state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LifecycleState => new TerraformReference(this, "lifecycle_state");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Location => new TerraformReference(this, "location");

    /// <summary>
    /// The maintenance_window attribute.
    /// </summary>
    [TerraformPropertyName("maintenance_window")]
    // Output-only attribute - read-only reference
    public TerraformList<object> MaintenanceWindow => new TerraformReference(this, "maintenance_window");

    /// <summary>
    /// The max_cpu_count attribute.
    /// </summary>
    [TerraformPropertyName("max_cpu_count")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> MaxCpuCount => new TerraformReference(this, "max_cpu_count");

    /// <summary>
    /// The max_data_storage_in_tbs attribute.
    /// </summary>
    [TerraformPropertyName("max_data_storage_in_tbs")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> MaxDataStorageInTbs => new TerraformReference(this, "max_data_storage_in_tbs");

    /// <summary>
    /// The max_db_node_storage_size_in_gbs attribute.
    /// </summary>
    [TerraformPropertyName("max_db_node_storage_size_in_gbs")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> MaxDbNodeStorageSizeInGbs => new TerraformReference(this, "max_db_node_storage_size_in_gbs");

    /// <summary>
    /// The max_memory_in_gbs attribute.
    /// </summary>
    [TerraformPropertyName("max_memory_in_gbs")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> MaxMemoryInGbs => new TerraformReference(this, "max_memory_in_gbs");

    /// <summary>
    /// The memory_size_in_gbs attribute.
    /// </summary>
    [TerraformPropertyName("memory_size_in_gbs")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> MemorySizeInGbs => new TerraformReference(this, "memory_size_in_gbs");

    /// <summary>
    /// The monthly_db_server_version attribute.
    /// </summary>
    [TerraformPropertyName("monthly_db_server_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> MonthlyDbServerVersion => new TerraformReference(this, "monthly_db_server_version");

    /// <summary>
    /// The monthly_storage_server_version attribute.
    /// </summary>
    [TerraformPropertyName("monthly_storage_server_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> MonthlyStorageServerVersion => new TerraformReference(this, "monthly_storage_server_version");

    /// <summary>
    /// The next_maintenance_run_id attribute.
    /// </summary>
    [TerraformPropertyName("next_maintenance_run_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> NextMaintenanceRunId => new TerraformReference(this, "next_maintenance_run_id");

    /// <summary>
    /// The oci_url attribute.
    /// </summary>
    [TerraformPropertyName("oci_url")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OciUrl => new TerraformReference(this, "oci_url");

    /// <summary>
    /// The ocid attribute.
    /// </summary>
    [TerraformPropertyName("ocid")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Ocid => new TerraformReference(this, "ocid");

    /// <summary>
    /// The shape attribute.
    /// </summary>
    [TerraformPropertyName("shape")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Shape => new TerraformReference(this, "shape");

    /// <summary>
    /// The storage_count attribute.
    /// </summary>
    [TerraformPropertyName("storage_count")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> StorageCount => new TerraformReference(this, "storage_count");

    /// <summary>
    /// The storage_server_type attribute.
    /// </summary>
    [TerraformPropertyName("storage_server_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> StorageServerType => new TerraformReference(this, "storage_server_type");

    /// <summary>
    /// The storage_server_version attribute.
    /// </summary>
    [TerraformPropertyName("storage_server_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> StorageServerVersion => new TerraformReference(this, "storage_server_version");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Tags => new TerraformReference(this, "tags");

    /// <summary>
    /// The time_created attribute.
    /// </summary>
    [TerraformPropertyName("time_created")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TimeCreated => new TerraformReference(this, "time_created");

    /// <summary>
    /// The total_storage_size_in_gbs attribute.
    /// </summary>
    [TerraformPropertyName("total_storage_size_in_gbs")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> TotalStorageSizeInGbs => new TerraformReference(this, "total_storage_size_in_gbs");

    /// <summary>
    /// The zones attribute.
    /// </summary>
    [TerraformPropertyName("zones")]
    // Output-only attribute - read-only reference
    public TerraformList<string> Zones => new TerraformReference(this, "zones");

}
