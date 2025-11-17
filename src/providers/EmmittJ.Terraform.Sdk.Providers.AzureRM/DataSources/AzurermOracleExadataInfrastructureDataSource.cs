using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermOracleExadataInfrastructureDataSource.
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
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_oracle_exadata_infrastructure Terraform data source.
/// Retrieves information about a azurerm_oracle_exadata_infrastructure.
/// </summary>
public partial class AzurermOracleExadataInfrastructureDataSource(string name) : TerraformDataSource("azurerm_oracle_exadata_infrastructure", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The activated_storage_count attribute.
    /// </summary>
    public TerraformValue<double> ActivatedStorageCount
    {
        get => new TerraformReference<double>(this, "activated_storage_count");
    }

    /// <summary>
    /// The additional_storage_count attribute.
    /// </summary>
    public TerraformValue<double> AdditionalStorageCount
    {
        get => new TerraformReference<double>(this, "additional_storage_count");
    }

    /// <summary>
    /// The available_storage_size_in_gbs attribute.
    /// </summary>
    public TerraformValue<double> AvailableStorageSizeInGbs
    {
        get => new TerraformReference<double>(this, "available_storage_size_in_gbs");
    }

    /// <summary>
    /// The compute_count attribute.
    /// </summary>
    public TerraformValue<double> ComputeCount
    {
        get => new TerraformReference<double>(this, "compute_count");
    }

    /// <summary>
    /// The compute_model attribute.
    /// </summary>
    public TerraformValue<string> ComputeModel
    {
        get => new TerraformReference<string>(this, "compute_model");
    }

    /// <summary>
    /// The cpu_count attribute.
    /// </summary>
    public TerraformValue<double> CpuCount
    {
        get => new TerraformReference<double>(this, "cpu_count");
    }

    /// <summary>
    /// The customer_contacts attribute.
    /// </summary>
    public TerraformList<string> CustomerContacts
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "customer_contacts").ResolveNodes(ctx));
    }

    /// <summary>
    /// The data_storage_size_in_tbs attribute.
    /// </summary>
    public TerraformValue<double> DataStorageSizeInTbs
    {
        get => new TerraformReference<double>(this, "data_storage_size_in_tbs");
    }

    /// <summary>
    /// The database_server_type attribute.
    /// </summary>
    public TerraformValue<string> DatabaseServerType
    {
        get => new TerraformReference<string>(this, "database_server_type");
    }

    /// <summary>
    /// The db_node_storage_size_in_gbs attribute.
    /// </summary>
    public TerraformValue<double> DbNodeStorageSizeInGbs
    {
        get => new TerraformReference<double>(this, "db_node_storage_size_in_gbs");
    }

    /// <summary>
    /// The db_server_version attribute.
    /// </summary>
    public TerraformValue<string> DbServerVersion
    {
        get => new TerraformReference<string>(this, "db_server_version");
    }

    /// <summary>
    /// The defined_file_system_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> DefinedFileSystemConfiguration
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "defined_file_system_configuration").ResolveNodes(ctx));
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
    }

    /// <summary>
    /// The estimated_patching_time attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> EstimatedPatchingTime
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "estimated_patching_time").ResolveNodes(ctx));
    }

    /// <summary>
    /// The last_maintenance_run_id attribute.
    /// </summary>
    public TerraformValue<string> LastMaintenanceRunId
    {
        get => new TerraformReference<string>(this, "last_maintenance_run_id");
    }

    /// <summary>
    /// The lifecycle_details attribute.
    /// </summary>
    public TerraformValue<string> LifecycleDetails
    {
        get => new TerraformReference<string>(this, "lifecycle_details");
    }

    /// <summary>
    /// The lifecycle_state attribute.
    /// </summary>
    public TerraformValue<string> LifecycleState
    {
        get => new TerraformReference<string>(this, "lifecycle_state");
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The maintenance_window attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> MaintenanceWindow
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "maintenance_window").ResolveNodes(ctx));
    }

    /// <summary>
    /// The max_cpu_count attribute.
    /// </summary>
    public TerraformValue<double> MaxCpuCount
    {
        get => new TerraformReference<double>(this, "max_cpu_count");
    }

    /// <summary>
    /// The max_data_storage_in_tbs attribute.
    /// </summary>
    public TerraformValue<double> MaxDataStorageInTbs
    {
        get => new TerraformReference<double>(this, "max_data_storage_in_tbs");
    }

    /// <summary>
    /// The max_db_node_storage_size_in_gbs attribute.
    /// </summary>
    public TerraformValue<double> MaxDbNodeStorageSizeInGbs
    {
        get => new TerraformReference<double>(this, "max_db_node_storage_size_in_gbs");
    }

    /// <summary>
    /// The max_memory_in_gbs attribute.
    /// </summary>
    public TerraformValue<double> MaxMemoryInGbs
    {
        get => new TerraformReference<double>(this, "max_memory_in_gbs");
    }

    /// <summary>
    /// The memory_size_in_gbs attribute.
    /// </summary>
    public TerraformValue<double> MemorySizeInGbs
    {
        get => new TerraformReference<double>(this, "memory_size_in_gbs");
    }

    /// <summary>
    /// The monthly_db_server_version attribute.
    /// </summary>
    public TerraformValue<string> MonthlyDbServerVersion
    {
        get => new TerraformReference<string>(this, "monthly_db_server_version");
    }

    /// <summary>
    /// The monthly_storage_server_version attribute.
    /// </summary>
    public TerraformValue<string> MonthlyStorageServerVersion
    {
        get => new TerraformReference<string>(this, "monthly_storage_server_version");
    }

    /// <summary>
    /// The next_maintenance_run_id attribute.
    /// </summary>
    public TerraformValue<string> NextMaintenanceRunId
    {
        get => new TerraformReference<string>(this, "next_maintenance_run_id");
    }

    /// <summary>
    /// The oci_url attribute.
    /// </summary>
    public TerraformValue<string> OciUrl
    {
        get => new TerraformReference<string>(this, "oci_url");
    }

    /// <summary>
    /// The ocid attribute.
    /// </summary>
    public TerraformValue<string> Ocid
    {
        get => new TerraformReference<string>(this, "ocid");
    }

    /// <summary>
    /// The shape attribute.
    /// </summary>
    public TerraformValue<string> Shape
    {
        get => new TerraformReference<string>(this, "shape");
    }

    /// <summary>
    /// The storage_count attribute.
    /// </summary>
    public TerraformValue<double> StorageCount
    {
        get => new TerraformReference<double>(this, "storage_count");
    }

    /// <summary>
    /// The storage_server_type attribute.
    /// </summary>
    public TerraformValue<string> StorageServerType
    {
        get => new TerraformReference<string>(this, "storage_server_type");
    }

    /// <summary>
    /// The storage_server_version attribute.
    /// </summary>
    public TerraformValue<string> StorageServerVersion
    {
        get => new TerraformReference<string>(this, "storage_server_version");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The time_created attribute.
    /// </summary>
    public TerraformValue<string> TimeCreated
    {
        get => new TerraformReference<string>(this, "time_created");
    }

    /// <summary>
    /// The total_storage_size_in_gbs attribute.
    /// </summary>
    public TerraformValue<double> TotalStorageSizeInGbs
    {
        get => new TerraformReference<double>(this, "total_storage_size_in_gbs");
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public TerraformList<string> Zones
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "zones").ResolveNodes(ctx));
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermOracleExadataInfrastructureDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermOracleExadataInfrastructureDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
