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
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The activated_storage_count attribute.
    /// </summary>
    public TerraformValue<double> ActivatedStorageCount
        => CreateReference("activated_storage_count");

    /// <summary>
    /// The additional_storage_count attribute.
    /// </summary>
    public TerraformValue<double> AdditionalStorageCount
        => CreateReference("additional_storage_count");

    /// <summary>
    /// The available_storage_size_in_gbs attribute.
    /// </summary>
    public TerraformValue<double> AvailableStorageSizeInGbs
        => CreateReference("available_storage_size_in_gbs");

    /// <summary>
    /// The compute_count attribute.
    /// </summary>
    public TerraformValue<double> ComputeCount
        => CreateReference("compute_count");

    /// <summary>
    /// The compute_model attribute.
    /// </summary>
    public TerraformValue<string> ComputeModel
        => CreateReference("compute_model");

    /// <summary>
    /// The cpu_count attribute.
    /// </summary>
    public TerraformValue<double> CpuCount
        => CreateReference("cpu_count");

    /// <summary>
    /// The customer_contacts attribute.
    /// </summary>
    public TerraformList<string> CustomerContacts
        => CreateReference("customer_contacts");

    /// <summary>
    /// The data_storage_size_in_tbs attribute.
    /// </summary>
    public TerraformValue<double> DataStorageSizeInTbs
        => CreateReference("data_storage_size_in_tbs");

    /// <summary>
    /// The database_server_type attribute.
    /// </summary>
    public TerraformValue<string> DatabaseServerType
        => CreateReference("database_server_type");

    /// <summary>
    /// The db_node_storage_size_in_gbs attribute.
    /// </summary>
    public TerraformValue<double> DbNodeStorageSizeInGbs
        => CreateReference("db_node_storage_size_in_gbs");

    /// <summary>
    /// The db_server_version attribute.
    /// </summary>
    public TerraformValue<string> DbServerVersion
        => CreateReference("db_server_version");

    /// <summary>
    /// The defined_file_system_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> DefinedFileSystemConfiguration
        => CreateReference("defined_file_system_configuration");

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformValue<string> DisplayName
        => CreateReference("display_name");

    /// <summary>
    /// The estimated_patching_time attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> EstimatedPatchingTime
        => CreateReference("estimated_patching_time");

    /// <summary>
    /// The last_maintenance_run_id attribute.
    /// </summary>
    public TerraformValue<string> LastMaintenanceRunId
        => CreateReference("last_maintenance_run_id");

    /// <summary>
    /// The lifecycle_details attribute.
    /// </summary>
    public TerraformValue<string> LifecycleDetails
        => CreateReference("lifecycle_details");

    /// <summary>
    /// The lifecycle_state attribute.
    /// </summary>
    public TerraformValue<string> LifecycleState
        => CreateReference("lifecycle_state");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => CreateReference("location");

    /// <summary>
    /// The maintenance_window attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> MaintenanceWindow
        => CreateReference("maintenance_window");

    /// <summary>
    /// The max_cpu_count attribute.
    /// </summary>
    public TerraformValue<double> MaxCpuCount
        => CreateReference("max_cpu_count");

    /// <summary>
    /// The max_data_storage_in_tbs attribute.
    /// </summary>
    public TerraformValue<double> MaxDataStorageInTbs
        => CreateReference("max_data_storage_in_tbs");

    /// <summary>
    /// The max_db_node_storage_size_in_gbs attribute.
    /// </summary>
    public TerraformValue<double> MaxDbNodeStorageSizeInGbs
        => CreateReference("max_db_node_storage_size_in_gbs");

    /// <summary>
    /// The max_memory_in_gbs attribute.
    /// </summary>
    public TerraformValue<double> MaxMemoryInGbs
        => CreateReference("max_memory_in_gbs");

    /// <summary>
    /// The memory_size_in_gbs attribute.
    /// </summary>
    public TerraformValue<double> MemorySizeInGbs
        => CreateReference("memory_size_in_gbs");

    /// <summary>
    /// The monthly_db_server_version attribute.
    /// </summary>
    public TerraformValue<string> MonthlyDbServerVersion
        => CreateReference("monthly_db_server_version");

    /// <summary>
    /// The monthly_storage_server_version attribute.
    /// </summary>
    public TerraformValue<string> MonthlyStorageServerVersion
        => CreateReference("monthly_storage_server_version");

    /// <summary>
    /// The next_maintenance_run_id attribute.
    /// </summary>
    public TerraformValue<string> NextMaintenanceRunId
        => CreateReference("next_maintenance_run_id");

    /// <summary>
    /// The oci_url attribute.
    /// </summary>
    public TerraformValue<string> OciUrl
        => CreateReference("oci_url");

    /// <summary>
    /// The ocid attribute.
    /// </summary>
    public TerraformValue<string> Ocid
        => CreateReference("ocid");

    /// <summary>
    /// The shape attribute.
    /// </summary>
    public TerraformValue<string> Shape
        => CreateReference("shape");

    /// <summary>
    /// The storage_count attribute.
    /// </summary>
    public TerraformValue<double> StorageCount
        => CreateReference("storage_count");

    /// <summary>
    /// The storage_server_type attribute.
    /// </summary>
    public TerraformValue<string> StorageServerType
        => CreateReference("storage_server_type");

    /// <summary>
    /// The storage_server_version attribute.
    /// </summary>
    public TerraformValue<string> StorageServerVersion
        => CreateReference("storage_server_version");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => CreateReference("tags");

    /// <summary>
    /// The time_created attribute.
    /// </summary>
    public TerraformValue<string> TimeCreated
        => CreateReference("time_created");

    /// <summary>
    /// The total_storage_size_in_gbs attribute.
    /// </summary>
    public TerraformValue<double> TotalStorageSizeInGbs
        => CreateReference("total_storage_size_in_gbs");

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public TerraformList<string> Zones
        => CreateReference("zones");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermOracleExadataInfrastructureDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermOracleExadataInfrastructureDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
