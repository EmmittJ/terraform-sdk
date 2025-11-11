using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermOracleExadataInfrastructureDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_oracle_exadata_infrastructure.
/// </summary>
public partial class AzurermOracleExadataInfrastructureDataSource : TerraformDataSource
{
    public AzurermOracleExadataInfrastructureDataSource(string name) : base("azurerm_oracle_exadata_infrastructure", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermOracleExadataInfrastructureDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The activated_storage_count attribute.
    /// </summary>
    [TerraformProperty("activated_storage_count")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> ActivatedStorageCount { get; }

    /// <summary>
    /// The additional_storage_count attribute.
    /// </summary>
    [TerraformProperty("additional_storage_count")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> AdditionalStorageCount { get; }

    /// <summary>
    /// The available_storage_size_in_gbs attribute.
    /// </summary>
    [TerraformProperty("available_storage_size_in_gbs")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> AvailableStorageSizeInGbs { get; }

    /// <summary>
    /// The compute_count attribute.
    /// </summary>
    [TerraformProperty("compute_count")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> ComputeCount { get; }

    /// <summary>
    /// The compute_model attribute.
    /// </summary>
    [TerraformProperty("compute_model")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ComputeModel { get; }

    /// <summary>
    /// The cpu_count attribute.
    /// </summary>
    [TerraformProperty("cpu_count")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> CpuCount { get; }

    /// <summary>
    /// The customer_contacts attribute.
    /// </summary>
    [TerraformProperty("customer_contacts")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> CustomerContacts { get; }

    /// <summary>
    /// The data_storage_size_in_tbs attribute.
    /// </summary>
    [TerraformProperty("data_storage_size_in_tbs")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> DataStorageSizeInTbs { get; }

    /// <summary>
    /// The database_server_type attribute.
    /// </summary>
    [TerraformProperty("database_server_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DatabaseServerType { get; }

    /// <summary>
    /// The db_node_storage_size_in_gbs attribute.
    /// </summary>
    [TerraformProperty("db_node_storage_size_in_gbs")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> DbNodeStorageSizeInGbs { get; }

    /// <summary>
    /// The db_server_version attribute.
    /// </summary>
    [TerraformProperty("db_server_version")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DbServerVersion { get; }

    /// <summary>
    /// The defined_file_system_configuration attribute.
    /// </summary>
    [TerraformProperty("defined_file_system_configuration")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> DefinedFileSystemConfiguration { get; }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformProperty("display_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DisplayName { get; }

    /// <summary>
    /// The estimated_patching_time attribute.
    /// </summary>
    [TerraformProperty("estimated_patching_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> EstimatedPatchingTime { get; }

    /// <summary>
    /// The last_maintenance_run_id attribute.
    /// </summary>
    [TerraformProperty("last_maintenance_run_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LastMaintenanceRunId { get; }

    /// <summary>
    /// The lifecycle_details attribute.
    /// </summary>
    [TerraformProperty("lifecycle_details")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LifecycleDetails { get; }

    /// <summary>
    /// The lifecycle_state attribute.
    /// </summary>
    [TerraformProperty("lifecycle_state")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LifecycleState { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Location { get; }

    /// <summary>
    /// The maintenance_window attribute.
    /// </summary>
    [TerraformProperty("maintenance_window")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> MaintenanceWindow { get; }

    /// <summary>
    /// The max_cpu_count attribute.
    /// </summary>
    [TerraformProperty("max_cpu_count")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> MaxCpuCount { get; }

    /// <summary>
    /// The max_data_storage_in_tbs attribute.
    /// </summary>
    [TerraformProperty("max_data_storage_in_tbs")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> MaxDataStorageInTbs { get; }

    /// <summary>
    /// The max_db_node_storage_size_in_gbs attribute.
    /// </summary>
    [TerraformProperty("max_db_node_storage_size_in_gbs")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> MaxDbNodeStorageSizeInGbs { get; }

    /// <summary>
    /// The max_memory_in_gbs attribute.
    /// </summary>
    [TerraformProperty("max_memory_in_gbs")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> MaxMemoryInGbs { get; }

    /// <summary>
    /// The memory_size_in_gbs attribute.
    /// </summary>
    [TerraformProperty("memory_size_in_gbs")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> MemorySizeInGbs { get; }

    /// <summary>
    /// The monthly_db_server_version attribute.
    /// </summary>
    [TerraformProperty("monthly_db_server_version")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> MonthlyDbServerVersion { get; }

    /// <summary>
    /// The monthly_storage_server_version attribute.
    /// </summary>
    [TerraformProperty("monthly_storage_server_version")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> MonthlyStorageServerVersion { get; }

    /// <summary>
    /// The next_maintenance_run_id attribute.
    /// </summary>
    [TerraformProperty("next_maintenance_run_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> NextMaintenanceRunId { get; }

    /// <summary>
    /// The oci_url attribute.
    /// </summary>
    [TerraformProperty("oci_url")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> OciUrl { get; }

    /// <summary>
    /// The ocid attribute.
    /// </summary>
    [TerraformProperty("ocid")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Ocid { get; }

    /// <summary>
    /// The shape attribute.
    /// </summary>
    [TerraformProperty("shape")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Shape { get; }

    /// <summary>
    /// The storage_count attribute.
    /// </summary>
    [TerraformProperty("storage_count")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> StorageCount { get; }

    /// <summary>
    /// The storage_server_type attribute.
    /// </summary>
    [TerraformProperty("storage_server_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> StorageServerType { get; }

    /// <summary>
    /// The storage_server_version attribute.
    /// </summary>
    [TerraformProperty("storage_server_version")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> StorageServerVersion { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> Tags { get; }

    /// <summary>
    /// The time_created attribute.
    /// </summary>
    [TerraformProperty("time_created")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> TimeCreated { get; }

    /// <summary>
    /// The total_storage_size_in_gbs attribute.
    /// </summary>
    [TerraformProperty("total_storage_size_in_gbs")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> TotalStorageSizeInGbs { get; }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    [TerraformProperty("zones")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> Zones { get; }

}
