using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for maintenance_window in AwsOdbCloudExadataInfrastructure.
/// Nesting mode: list
/// </summary>
public class AwsOdbCloudExadataInfrastructureMaintenanceWindowBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "maintenance_window";

    /// <summary>
    /// The custom_action_timeout_in_mins attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomActionTimeoutInMins is required")]
    public required TerraformValue<double> CustomActionTimeoutInMins
    {
        get => GetRequiredArgument<TerraformValue<double>>("custom_action_timeout_in_mins");
        set => SetArgument("custom_action_timeout_in_mins", value);
    }

    /// <summary>
    /// The days_of_week attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> DaysOfWeek
    {
        get => GetArgument<TerraformSet<TerraformMap<object>>>("days_of_week") ?? CreateReference("days_of_week");
        set => SetArgument("days_of_week", value);
    }

    /// <summary>
    /// The hours_of_day attribute.
    /// </summary>
    public TerraformSet<double> HoursOfDay
    {
        get => GetArgument<TerraformSet<double>>("hours_of_day") ?? CreateReference("hours_of_day");
        set => SetArgument("hours_of_day", value);
    }

    /// <summary>
    /// The is_custom_action_timeout_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IsCustomActionTimeoutEnabled is required")]
    public required TerraformValue<bool> IsCustomActionTimeoutEnabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("is_custom_action_timeout_enabled");
        set => SetArgument("is_custom_action_timeout_enabled", value);
    }

    /// <summary>
    /// The lead_time_in_weeks attribute.
    /// </summary>
    public TerraformValue<double> LeadTimeInWeeks
    {
        get => GetArgument<TerraformValue<double>>("lead_time_in_weeks") ?? CreateReference("lead_time_in_weeks");
        set => SetArgument("lead_time_in_weeks", value);
    }

    /// <summary>
    /// The months attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> Months
    {
        get => GetArgument<TerraformSet<TerraformMap<object>>>("months") ?? CreateReference("months");
        set => SetArgument("months", value);
    }

    /// <summary>
    /// The patching_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PatchingMode is required")]
    public required TerraformValue<string> PatchingMode
    {
        get => GetRequiredArgument<TerraformValue<string>>("patching_mode");
        set => SetArgument("patching_mode", value);
    }

    /// <summary>
    /// The preference attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Preference is required")]
    public required TerraformValue<string> Preference
    {
        get => GetRequiredArgument<TerraformValue<string>>("preference");
        set => SetArgument("preference", value);
    }

    /// <summary>
    /// The weeks_of_month attribute.
    /// </summary>
    public TerraformSet<double> WeeksOfMonth
    {
        get => GetArgument<TerraformSet<double>>("weeks_of_month") ?? CreateReference("weeks_of_month");
        set => SetArgument("weeks_of_month", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsOdbCloudExadataInfrastructure.
/// Nesting mode: single
/// </summary>
public class AwsOdbCloudExadataInfrastructureTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_odb_cloud_exadata_infrastructure Terraform resource.
/// Manages a aws_odb_cloud_exadata_infrastructure resource.
/// </summary>
public partial class AwsOdbCloudExadataInfrastructure(string name) : TerraformResource("aws_odb_cloud_exadata_infrastructure", name)
{
    /// <summary>
    /// The name of the Availability Zone (AZ) where the Exadata infrastructure is located. Changing this will force terraform to create new resource
    /// </summary>
    public TerraformValue<string> AvailabilityZone
    {
        get => GetArgument<TerraformValue<string>>("availability_zone") ?? CreateReference("availability_zone");
        set => SetArgument("availability_zone", value);
    }

    /// <summary>
    ///  The AZ ID of the AZ where the Exadata infrastructure is located. Changing this will force terraform to create new resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AvailabilityZoneId is required")]
    public required TerraformValue<string> AvailabilityZoneId
    {
        get => GetRequiredArgument<TerraformValue<string>>("availability_zone_id");
        set => SetArgument("availability_zone_id", value);
    }

    /// <summary>
    ///  The number of compute instances that the Exadata infrastructure is located
    /// </summary>
    public TerraformValue<double> ComputeCount
    {
        get => GetArgument<TerraformValue<double>>("compute_count") ?? CreateReference("compute_count");
        set => SetArgument("compute_count", value);
    }

    /// <summary>
    /// The email addresses of contacts to receive notification from Oracle about maintenance updates for the Exadata infrastructure. Changing this will force terraform to create new resource
    /// </summary>
    public TerraformSet<TerraformMap<object>>? CustomerContactsToSendToOci
    {
        get => GetArgument<TerraformSet<TerraformMap<object>>>("customer_contacts_to_send_to_oci");
        set => SetArgument("customer_contacts_to_send_to_oci", value);
    }

    /// <summary>
    /// The database server model type of the Exadata infrastructure. For the list of valid model names, use the ListDbSystemShapes operation
    /// </summary>
    public TerraformValue<string>? DatabaseServerType
    {
        get => GetArgument<TerraformValue<string>>("database_server_type");
        set => SetArgument("database_server_type", value);
    }

    /// <summary>
    /// The user-friendly name for the Exadata infrastructure. Changing this will force terraform to create a new resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => GetRequiredArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The model name of the Exadata infrastructure. Changing this will force terraform to create new resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Shape is required")]
    public required TerraformValue<string> Shape
    {
        get => GetRequiredArgument<TerraformValue<string>>("shape");
        set => SetArgument("shape", value);
    }

    /// <summary>
    /// TThe number of storage servers that are activated for the Exadata infrastructure
    /// </summary>
    public TerraformValue<double> StorageCount
    {
        get => GetArgument<TerraformValue<double>>("storage_count") ?? CreateReference("storage_count");
        set => SetArgument("storage_count", value);
    }

    /// <summary>
    /// The storage server model type of the Exadata infrastructure. For the list of valid model names, use the ListDbSystemShapes operation
    /// </summary>
    public TerraformValue<string>? StorageServerType
    {
        get => GetArgument<TerraformValue<string>>("storage_server_type");
        set => SetArgument("storage_server_type", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The number of storage servers requested for the Exadata infrastructure
    /// </summary>
    public TerraformValue<double> ActivatedStorageCount
        => CreateReference("activated_storage_count");

    /// <summary>
    ///  The number of storage servers requested for the Exadata infrastructure
    /// </summary>
    public TerraformValue<double> AdditionalStorageCount
        => CreateReference("additional_storage_count");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The amount of available storage, in gigabytes (GB), for the Exadata infrastructure
    /// </summary>
    public TerraformValue<double> AvailableStorageSizeInGbs
        => CreateReference("available_storage_size_in_gbs");

    /// <summary>
    /// The OCI model compute model used when you create or clone an
    ///   instance: ECPU or OCPU. An ECPU is an abstracted measure of
    ///  compute resources. ECPUs are based on the number of cores
    ///  elastically allocated from a pool of compute and storage servers.
    ///   An OCPU is a legacy physical measure of compute resources. OCPUs
    ///  are based on the physical core of a processor with
    ///   hyper-threading enabled.
    /// </summary>
    public TerraformValue<string> ComputeModel
        => CreateReference("compute_model");

    /// <summary>
    /// The total number of CPU cores that are allocated to the Exadata infrastructure
    /// </summary>
    public TerraformValue<double> CpuCount
        => CreateReference("cpu_count");

    /// <summary>
    /// The time when the Exadata infrastructure was created.
    /// </summary>
    public TerraformValue<string> CreatedAt
        => CreateReference("created_at");

    /// <summary>
    /// The size of the Exadata infrastructure&#39;s data disk group, in terabytes (TB)
    /// </summary>
    public TerraformValue<double> DataStorageSizeInTbs
        => CreateReference("data_storage_size_in_tbs");

    /// <summary>
    /// The size of the Exadata infrastructure&#39;s local node storage, in gigabytes (GB)
    /// </summary>
    public TerraformValue<double> DbNodeStorageSizeInGbs
        => CreateReference("db_node_storage_size_in_gbs");

    /// <summary>
    /// The software version of the database servers (dom0) in the Exadata infrastructure
    /// </summary>
    public TerraformValue<string> DbServerVersion
        => CreateReference("db_server_version");

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => CreateReference("id");

    /// <summary>
    /// The Oracle Cloud Identifier (OCID) of the last maintenance run for the Exadata infrastructure
    /// </summary>
    public TerraformValue<string> LastMaintenanceRunId
        => CreateReference("last_maintenance_run_id");

    /// <summary>
    /// The total number of CPU cores available on the Exadata infrastructure
    /// </summary>
    public TerraformValue<double> MaxCpuCount
        => CreateReference("max_cpu_count");

    /// <summary>
    /// The total amount of data disk group storage, in terabytes (TB), that&#39;s available on the Exadata infrastructure
    /// </summary>
    public TerraformValue<double> MaxDataStorageInTbs
        => CreateReference("max_data_storage_in_tbs");

    /// <summary>
    /// The total amount of local node storage, in gigabytes (GB), that&#39;s available on the Exadata infrastructure
    /// </summary>
    public TerraformValue<double> MaxDbNodeStorageSizeInGbs
        => CreateReference("max_db_node_storage_size_in_gbs");

    /// <summary>
    /// The total amount of memory in gigabytes (GB) available on the Exadata infrastructure
    /// </summary>
    public TerraformValue<double> MaxMemoryInGbs
        => CreateReference("max_memory_in_gbs");

    /// <summary>
    /// The amount of memory, in gigabytes (GB), that&#39;s allocated on the Exadata infrastructure
    /// </summary>
    public TerraformValue<double> MemorySizeInGbs
        => CreateReference("memory_size_in_gbs");

    /// <summary>
    /// The monthly software version of the database servers in the Exadata infrastructure
    /// </summary>
    public TerraformValue<string> MonthlyDbServerVersion
        => CreateReference("monthly_db_server_version");

    /// <summary>
    /// The monthly software version of the storage servers installed on the Exadata infrastructure
    /// </summary>
    public TerraformValue<string> MonthlyStorageServerVersion
        => CreateReference("monthly_storage_server_version");

    /// <summary>
    /// The OCID of the next maintenance run for the Exadata infrastructure
    /// </summary>
    public TerraformValue<string> NextMaintenanceRunId
        => CreateReference("next_maintenance_run_id");

    /// <summary>
    /// The name of the OCI resource anchor for the Exadata infrastructure
    /// </summary>
    public TerraformValue<string> OciResourceAnchorName
        => CreateReference("oci_resource_anchor_name");

    /// <summary>
    /// The HTTPS link to the Exadata infrastructure in OCI
    /// </summary>
    public TerraformValue<string> OciUrl
        => CreateReference("oci_url");

    /// <summary>
    /// The OCID of the Exadata infrastructure
    /// </summary>
    public TerraformValue<string> Ocid
        => CreateReference("ocid");

    /// <summary>
    /// The amount of progress made on the current operation on the Exadata infrastructure, expressed as a percentage
    /// </summary>
    public TerraformValue<double> PercentProgress
        => CreateReference("percent_progress");

    /// <summary>
    /// The current status of the Exadata infrastructure
    /// </summary>
    public TerraformValue<string> Status
        => CreateReference("status");

    /// <summary>
    /// Additional information about the status of the Exadata infrastructure
    /// </summary>
    public TerraformValue<string> StatusReason
        => CreateReference("status_reason");

    /// <summary>
    /// The software version of the storage servers on the Exadata infrastructure.
    /// </summary>
    public TerraformValue<string> StorageServerVersion
        => CreateReference("storage_server_version");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
        => CreateReference("tags_all");

    /// <summary>
    /// The total amount of storage, in gigabytes (GB), on the Exadata infrastructure.
    /// </summary>
    public TerraformValue<double> TotalStorageSizeInGbs
        => CreateReference("total_storage_size_in_gbs");

    /// <summary>
    /// MaintenanceWindow block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsOdbCloudExadataInfrastructureMaintenanceWindowBlock>? MaintenanceWindow
    {
        get => GetArgument<TerraformList<AwsOdbCloudExadataInfrastructureMaintenanceWindowBlock>>("maintenance_window");
        set => SetArgument("maintenance_window", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsOdbCloudExadataInfrastructureTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsOdbCloudExadataInfrastructureTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
