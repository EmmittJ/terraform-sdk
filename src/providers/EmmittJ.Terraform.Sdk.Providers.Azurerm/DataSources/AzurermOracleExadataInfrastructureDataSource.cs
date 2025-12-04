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
        get => GetArgument<TerraformValue<string>>("read");
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
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The activated_storage_count attribute.
    /// </summary>
    public TerraformValue<double> ActivatedStorageCount
        => AsReference("activated_storage_count");

    /// <summary>
    /// The additional_storage_count attribute.
    /// </summary>
    public TerraformValue<double> AdditionalStorageCount
        => AsReference("additional_storage_count");

    /// <summary>
    /// The available_storage_size_in_gbs attribute.
    /// </summary>
    public TerraformValue<double> AvailableStorageSizeInGbs
        => AsReference("available_storage_size_in_gbs");

    /// <summary>
    /// The compute_count attribute.
    /// </summary>
    public TerraformValue<double> ComputeCount
        => AsReference("compute_count");

    /// <summary>
    /// The compute_model attribute.
    /// </summary>
    public TerraformValue<string> ComputeModel
        => AsReference("compute_model");

    /// <summary>
    /// The cpu_count attribute.
    /// </summary>
    public TerraformValue<double> CpuCount
        => AsReference("cpu_count");

    /// <summary>
    /// The customer_contacts attribute.
    /// </summary>
    public TerraformList<string> CustomerContacts
        => AsReference("customer_contacts");

    /// <summary>
    /// The data_storage_size_in_tbs attribute.
    /// </summary>
    public TerraformValue<double> DataStorageSizeInTbs
        => AsReference("data_storage_size_in_tbs");

    /// <summary>
    /// The database_server_type attribute.
    /// </summary>
    public TerraformValue<string> DatabaseServerType
        => AsReference("database_server_type");

    /// <summary>
    /// The db_node_storage_size_in_gbs attribute.
    /// </summary>
    public TerraformValue<double> DbNodeStorageSizeInGbs
        => AsReference("db_node_storage_size_in_gbs");

    /// <summary>
    /// The db_server_version attribute.
    /// </summary>
    public TerraformValue<string> DbServerVersion
        => AsReference("db_server_version");

    /// <summary>
    /// The defined_file_system_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> DefinedFileSystemConfiguration
        => AsReference("defined_file_system_configuration");

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformValue<string> DisplayName
        => AsReference("display_name");

    /// <summary>
    /// The estimated_patching_time attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> EstimatedPatchingTime
        => AsReference("estimated_patching_time");

    /// <summary>
    /// The last_maintenance_run_id attribute.
    /// </summary>
    public TerraformValue<string> LastMaintenanceRunId
        => AsReference("last_maintenance_run_id");

    /// <summary>
    /// The lifecycle_details attribute.
    /// </summary>
    public TerraformValue<string> LifecycleDetails
        => AsReference("lifecycle_details");

    /// <summary>
    /// The lifecycle_state attribute.
    /// </summary>
    public TerraformValue<string> LifecycleState
        => AsReference("lifecycle_state");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => AsReference("location");

    /// <summary>
    /// The maintenance_window attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> MaintenanceWindow
        => AsReference("maintenance_window");

    /// <summary>
    /// The max_cpu_count attribute.
    /// </summary>
    public TerraformValue<double> MaxCpuCount
        => AsReference("max_cpu_count");

    /// <summary>
    /// The max_data_storage_in_tbs attribute.
    /// </summary>
    public TerraformValue<double> MaxDataStorageInTbs
        => AsReference("max_data_storage_in_tbs");

    /// <summary>
    /// The max_db_node_storage_size_in_gbs attribute.
    /// </summary>
    public TerraformValue<double> MaxDbNodeStorageSizeInGbs
        => AsReference("max_db_node_storage_size_in_gbs");

    /// <summary>
    /// The max_memory_in_gbs attribute.
    /// </summary>
    public TerraformValue<double> MaxMemoryInGbs
        => AsReference("max_memory_in_gbs");

    /// <summary>
    /// The memory_size_in_gbs attribute.
    /// </summary>
    public TerraformValue<double> MemorySizeInGbs
        => AsReference("memory_size_in_gbs");

    /// <summary>
    /// The monthly_db_server_version attribute.
    /// </summary>
    public TerraformValue<string> MonthlyDbServerVersion
        => AsReference("monthly_db_server_version");

    /// <summary>
    /// The monthly_storage_server_version attribute.
    /// </summary>
    public TerraformValue<string> MonthlyStorageServerVersion
        => AsReference("monthly_storage_server_version");

    /// <summary>
    /// The next_maintenance_run_id attribute.
    /// </summary>
    public TerraformValue<string> NextMaintenanceRunId
        => AsReference("next_maintenance_run_id");

    /// <summary>
    /// The oci_url attribute.
    /// </summary>
    public TerraformValue<string> OciUrl
        => AsReference("oci_url");

    /// <summary>
    /// The ocid attribute.
    /// </summary>
    public TerraformValue<string> Ocid
        => AsReference("ocid");

    /// <summary>
    /// The shape attribute.
    /// </summary>
    public TerraformValue<string> Shape
        => AsReference("shape");

    /// <summary>
    /// The storage_count attribute.
    /// </summary>
    public TerraformValue<double> StorageCount
        => AsReference("storage_count");

    /// <summary>
    /// The storage_server_type attribute.
    /// </summary>
    public TerraformValue<string> StorageServerType
        => AsReference("storage_server_type");

    /// <summary>
    /// The storage_server_version attribute.
    /// </summary>
    public TerraformValue<string> StorageServerVersion
        => AsReference("storage_server_version");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => AsReference("tags");

    /// <summary>
    /// The time_created attribute.
    /// </summary>
    public TerraformValue<string> TimeCreated
        => AsReference("time_created");

    /// <summary>
    /// The total_storage_size_in_gbs attribute.
    /// </summary>
    public TerraformValue<double> TotalStorageSizeInGbs
        => AsReference("total_storage_size_in_gbs");

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public TerraformList<string> Zones
        => AsReference("zones");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermOracleExadataInfrastructureDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermOracleExadataInfrastructureDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
