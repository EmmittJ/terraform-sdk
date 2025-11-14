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
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermOracleExadataInfrastructureDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

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
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermOracleExadataInfrastructureDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The activated_storage_count attribute.
    /// </summary>
    [TerraformArgument("activated_storage_count")]
    public TerraformValue<double> ActivatedStorageCount
    {
        get => new TerraformReference<double>(this, "activated_storage_count");
    }

    /// <summary>
    /// The additional_storage_count attribute.
    /// </summary>
    [TerraformArgument("additional_storage_count")]
    public TerraformValue<double> AdditionalStorageCount
    {
        get => new TerraformReference<double>(this, "additional_storage_count");
    }

    /// <summary>
    /// The available_storage_size_in_gbs attribute.
    /// </summary>
    [TerraformArgument("available_storage_size_in_gbs")]
    public TerraformValue<double> AvailableStorageSizeInGbs
    {
        get => new TerraformReference<double>(this, "available_storage_size_in_gbs");
    }

    /// <summary>
    /// The compute_count attribute.
    /// </summary>
    [TerraformArgument("compute_count")]
    public TerraformValue<double> ComputeCount
    {
        get => new TerraformReference<double>(this, "compute_count");
    }

    /// <summary>
    /// The compute_model attribute.
    /// </summary>
    [TerraformArgument("compute_model")]
    public TerraformValue<string> ComputeModel
    {
        get => new TerraformReference<string>(this, "compute_model");
    }

    /// <summary>
    /// The cpu_count attribute.
    /// </summary>
    [TerraformArgument("cpu_count")]
    public TerraformValue<double> CpuCount
    {
        get => new TerraformReference<double>(this, "cpu_count");
    }

    /// <summary>
    /// The customer_contacts attribute.
    /// </summary>
    [TerraformArgument("customer_contacts")]
    public TerraformList<string> CustomerContacts
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "customer_contacts").ResolveNodes(ctx));
    }

    /// <summary>
    /// The data_storage_size_in_tbs attribute.
    /// </summary>
    [TerraformArgument("data_storage_size_in_tbs")]
    public TerraformValue<double> DataStorageSizeInTbs
    {
        get => new TerraformReference<double>(this, "data_storage_size_in_tbs");
    }

    /// <summary>
    /// The database_server_type attribute.
    /// </summary>
    [TerraformArgument("database_server_type")]
    public TerraformValue<string> DatabaseServerType
    {
        get => new TerraformReference<string>(this, "database_server_type");
    }

    /// <summary>
    /// The db_node_storage_size_in_gbs attribute.
    /// </summary>
    [TerraformArgument("db_node_storage_size_in_gbs")]
    public TerraformValue<double> DbNodeStorageSizeInGbs
    {
        get => new TerraformReference<double>(this, "db_node_storage_size_in_gbs");
    }

    /// <summary>
    /// The db_server_version attribute.
    /// </summary>
    [TerraformArgument("db_server_version")]
    public TerraformValue<string> DbServerVersion
    {
        get => new TerraformReference<string>(this, "db_server_version");
    }

    /// <summary>
    /// The defined_file_system_configuration attribute.
    /// </summary>
    [TerraformArgument("defined_file_system_configuration")]
    public TerraformList<object> DefinedFileSystemConfiguration
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "defined_file_system_configuration").ResolveNodes(ctx));
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformArgument("display_name")]
    public TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
    }

    /// <summary>
    /// The estimated_patching_time attribute.
    /// </summary>
    [TerraformArgument("estimated_patching_time")]
    public TerraformList<object> EstimatedPatchingTime
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "estimated_patching_time").ResolveNodes(ctx));
    }

    /// <summary>
    /// The last_maintenance_run_id attribute.
    /// </summary>
    [TerraformArgument("last_maintenance_run_id")]
    public TerraformValue<string> LastMaintenanceRunId
    {
        get => new TerraformReference<string>(this, "last_maintenance_run_id");
    }

    /// <summary>
    /// The lifecycle_details attribute.
    /// </summary>
    [TerraformArgument("lifecycle_details")]
    public TerraformValue<string> LifecycleDetails
    {
        get => new TerraformReference<string>(this, "lifecycle_details");
    }

    /// <summary>
    /// The lifecycle_state attribute.
    /// </summary>
    [TerraformArgument("lifecycle_state")]
    public TerraformValue<string> LifecycleState
    {
        get => new TerraformReference<string>(this, "lifecycle_state");
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformArgument("location")]
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The maintenance_window attribute.
    /// </summary>
    [TerraformArgument("maintenance_window")]
    public TerraformList<object> MaintenanceWindow
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "maintenance_window").ResolveNodes(ctx));
    }

    /// <summary>
    /// The max_cpu_count attribute.
    /// </summary>
    [TerraformArgument("max_cpu_count")]
    public TerraformValue<double> MaxCpuCount
    {
        get => new TerraformReference<double>(this, "max_cpu_count");
    }

    /// <summary>
    /// The max_data_storage_in_tbs attribute.
    /// </summary>
    [TerraformArgument("max_data_storage_in_tbs")]
    public TerraformValue<double> MaxDataStorageInTbs
    {
        get => new TerraformReference<double>(this, "max_data_storage_in_tbs");
    }

    /// <summary>
    /// The max_db_node_storage_size_in_gbs attribute.
    /// </summary>
    [TerraformArgument("max_db_node_storage_size_in_gbs")]
    public TerraformValue<double> MaxDbNodeStorageSizeInGbs
    {
        get => new TerraformReference<double>(this, "max_db_node_storage_size_in_gbs");
    }

    /// <summary>
    /// The max_memory_in_gbs attribute.
    /// </summary>
    [TerraformArgument("max_memory_in_gbs")]
    public TerraformValue<double> MaxMemoryInGbs
    {
        get => new TerraformReference<double>(this, "max_memory_in_gbs");
    }

    /// <summary>
    /// The memory_size_in_gbs attribute.
    /// </summary>
    [TerraformArgument("memory_size_in_gbs")]
    public TerraformValue<double> MemorySizeInGbs
    {
        get => new TerraformReference<double>(this, "memory_size_in_gbs");
    }

    /// <summary>
    /// The monthly_db_server_version attribute.
    /// </summary>
    [TerraformArgument("monthly_db_server_version")]
    public TerraformValue<string> MonthlyDbServerVersion
    {
        get => new TerraformReference<string>(this, "monthly_db_server_version");
    }

    /// <summary>
    /// The monthly_storage_server_version attribute.
    /// </summary>
    [TerraformArgument("monthly_storage_server_version")]
    public TerraformValue<string> MonthlyStorageServerVersion
    {
        get => new TerraformReference<string>(this, "monthly_storage_server_version");
    }

    /// <summary>
    /// The next_maintenance_run_id attribute.
    /// </summary>
    [TerraformArgument("next_maintenance_run_id")]
    public TerraformValue<string> NextMaintenanceRunId
    {
        get => new TerraformReference<string>(this, "next_maintenance_run_id");
    }

    /// <summary>
    /// The oci_url attribute.
    /// </summary>
    [TerraformArgument("oci_url")]
    public TerraformValue<string> OciUrl
    {
        get => new TerraformReference<string>(this, "oci_url");
    }

    /// <summary>
    /// The ocid attribute.
    /// </summary>
    [TerraformArgument("ocid")]
    public TerraformValue<string> Ocid
    {
        get => new TerraformReference<string>(this, "ocid");
    }

    /// <summary>
    /// The shape attribute.
    /// </summary>
    [TerraformArgument("shape")]
    public TerraformValue<string> Shape
    {
        get => new TerraformReference<string>(this, "shape");
    }

    /// <summary>
    /// The storage_count attribute.
    /// </summary>
    [TerraformArgument("storage_count")]
    public TerraformValue<double> StorageCount
    {
        get => new TerraformReference<double>(this, "storage_count");
    }

    /// <summary>
    /// The storage_server_type attribute.
    /// </summary>
    [TerraformArgument("storage_server_type")]
    public TerraformValue<string> StorageServerType
    {
        get => new TerraformReference<string>(this, "storage_server_type");
    }

    /// <summary>
    /// The storage_server_version attribute.
    /// </summary>
    [TerraformArgument("storage_server_version")]
    public TerraformValue<string> StorageServerVersion
    {
        get => new TerraformReference<string>(this, "storage_server_version");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The time_created attribute.
    /// </summary>
    [TerraformArgument("time_created")]
    public TerraformValue<string> TimeCreated
    {
        get => new TerraformReference<string>(this, "time_created");
    }

    /// <summary>
    /// The total_storage_size_in_gbs attribute.
    /// </summary>
    [TerraformArgument("total_storage_size_in_gbs")]
    public TerraformValue<double> TotalStorageSizeInGbs
    {
        get => new TerraformReference<double>(this, "total_storage_size_in_gbs");
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    [TerraformArgument("zones")]
    public TerraformList<string> Zones
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "zones").ResolveNodes(ctx));
    }

}
