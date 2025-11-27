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
        get => new TerraformReference<double>(this, "custom_action_timeout_in_mins");
        set => SetArgument("custom_action_timeout_in_mins", value);
    }

    /// <summary>
    /// The days_of_week attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> DaysOfWeek
    {
        get => TerraformSet<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformMap<object>>>(this, "days_of_week").ResolveNodes(ctx));
        set => SetArgument("days_of_week", value);
    }

    /// <summary>
    /// The hours_of_day attribute.
    /// </summary>
    public TerraformSet<double> HoursOfDay
    {
        get => TerraformSet<double>.Lazy(ctx => new TerraformReference<TerraformSet<double>>(this, "hours_of_day").ResolveNodes(ctx));
        set => SetArgument("hours_of_day", value);
    }

    /// <summary>
    /// The is_custom_action_timeout_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IsCustomActionTimeoutEnabled is required")]
    public required TerraformValue<bool> IsCustomActionTimeoutEnabled
    {
        get => new TerraformReference<bool>(this, "is_custom_action_timeout_enabled");
        set => SetArgument("is_custom_action_timeout_enabled", value);
    }

    /// <summary>
    /// The lead_time_in_weeks attribute.
    /// </summary>
    public TerraformValue<double> LeadTimeInWeeks
    {
        get => new TerraformReference<double>(this, "lead_time_in_weeks");
        set => SetArgument("lead_time_in_weeks", value);
    }

    /// <summary>
    /// The months attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> Months
    {
        get => TerraformSet<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformMap<object>>>(this, "months").ResolveNodes(ctx));
        set => SetArgument("months", value);
    }

    /// <summary>
    /// The patching_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PatchingMode is required")]
    public required TerraformValue<string> PatchingMode
    {
        get => new TerraformReference<string>(this, "patching_mode");
        set => SetArgument("patching_mode", value);
    }

    /// <summary>
    /// The preference attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Preference is required")]
    public required TerraformValue<string> Preference
    {
        get => new TerraformReference<string>(this, "preference");
        set => SetArgument("preference", value);
    }

    /// <summary>
    /// The weeks_of_month attribute.
    /// </summary>
    public TerraformSet<double> WeeksOfMonth
    {
        get => TerraformSet<double>.Lazy(ctx => new TerraformReference<TerraformSet<double>>(this, "weeks_of_month").ResolveNodes(ctx));
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
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
        get => new TerraformReference<string>(this, "availability_zone");
        set => SetArgument("availability_zone", value);
    }

    /// <summary>
    ///  The AZ ID of the AZ where the Exadata infrastructure is located. Changing this will force terraform to create new resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AvailabilityZoneId is required")]
    public required TerraformValue<string> AvailabilityZoneId
    {
        get => new TerraformReference<string>(this, "availability_zone_id");
        set => SetArgument("availability_zone_id", value);
    }

    /// <summary>
    ///  The number of compute instances that the Exadata infrastructure is located
    /// </summary>
    public TerraformValue<double> ComputeCount
    {
        get => new TerraformReference<double>(this, "compute_count");
        set => SetArgument("compute_count", value);
    }

    /// <summary>
    /// The email addresses of contacts to receive notification from Oracle about maintenance updates for the Exadata infrastructure. Changing this will force terraform to create new resource
    /// </summary>
    public TerraformSet<TerraformMap<object>>? CustomerContactsToSendToOci
    {
        get => TerraformSet<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformMap<object>>>(this, "customer_contacts_to_send_to_oci").ResolveNodes(ctx));
        set => SetArgument("customer_contacts_to_send_to_oci", value);
    }

    /// <summary>
    /// The database server model type of the Exadata infrastructure. For the list of valid model names, use the ListDbSystemShapes operation
    /// </summary>
    public TerraformValue<string>? DatabaseServerType
    {
        get => new TerraformReference<string>(this, "database_server_type");
        set => SetArgument("database_server_type", value);
    }

    /// <summary>
    /// The user-friendly name for the Exadata infrastructure. Changing this will force terraform to create a new resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The model name of the Exadata infrastructure. Changing this will force terraform to create new resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Shape is required")]
    public required TerraformValue<string> Shape
    {
        get => new TerraformReference<string>(this, "shape");
        set => SetArgument("shape", value);
    }

    /// <summary>
    /// TThe number of storage servers that are activated for the Exadata infrastructure
    /// </summary>
    public TerraformValue<double> StorageCount
    {
        get => new TerraformReference<double>(this, "storage_count");
        set => SetArgument("storage_count", value);
    }

    /// <summary>
    /// The storage server model type of the Exadata infrastructure. For the list of valid model names, use the ListDbSystemShapes operation
    /// </summary>
    public TerraformValue<string>? StorageServerType
    {
        get => new TerraformReference<string>(this, "storage_server_type");
        set => SetArgument("storage_server_type", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The number of storage servers requested for the Exadata infrastructure
    /// </summary>
    public TerraformValue<double> ActivatedStorageCount
    {
        get => new TerraformReference<double>(this, "activated_storage_count");
    }

    /// <summary>
    ///  The number of storage servers requested for the Exadata infrastructure
    /// </summary>
    public TerraformValue<double> AdditionalStorageCount
    {
        get => new TerraformReference<double>(this, "additional_storage_count");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The amount of available storage, in gigabytes (GB), for the Exadata infrastructure
    /// </summary>
    public TerraformValue<double> AvailableStorageSizeInGbs
    {
        get => new TerraformReference<double>(this, "available_storage_size_in_gbs");
    }

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
    {
        get => new TerraformReference<string>(this, "compute_model");
    }

    /// <summary>
    /// The total number of CPU cores that are allocated to the Exadata infrastructure
    /// </summary>
    public TerraformValue<double> CpuCount
    {
        get => new TerraformReference<double>(this, "cpu_count");
    }

    /// <summary>
    /// The time when the Exadata infrastructure was created.
    /// </summary>
    public TerraformValue<string> CreatedAt
    {
        get => new TerraformReference<string>(this, "created_at");
    }

    /// <summary>
    /// The size of the Exadata infrastructure&#39;s data disk group, in terabytes (TB)
    /// </summary>
    public TerraformValue<double> DataStorageSizeInTbs
    {
        get => new TerraformReference<double>(this, "data_storage_size_in_tbs");
    }

    /// <summary>
    /// The size of the Exadata infrastructure&#39;s local node storage, in gigabytes (GB)
    /// </summary>
    public TerraformValue<double> DbNodeStorageSizeInGbs
    {
        get => new TerraformReference<double>(this, "db_node_storage_size_in_gbs");
    }

    /// <summary>
    /// The software version of the database servers (dom0) in the Exadata infrastructure
    /// </summary>
    public TerraformValue<string> DbServerVersion
    {
        get => new TerraformReference<string>(this, "db_server_version");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The Oracle Cloud Identifier (OCID) of the last maintenance run for the Exadata infrastructure
    /// </summary>
    public TerraformValue<string> LastMaintenanceRunId
    {
        get => new TerraformReference<string>(this, "last_maintenance_run_id");
    }

    /// <summary>
    /// The total number of CPU cores available on the Exadata infrastructure
    /// </summary>
    public TerraformValue<double> MaxCpuCount
    {
        get => new TerraformReference<double>(this, "max_cpu_count");
    }

    /// <summary>
    /// The total amount of data disk group storage, in terabytes (TB), that&#39;s available on the Exadata infrastructure
    /// </summary>
    public TerraformValue<double> MaxDataStorageInTbs
    {
        get => new TerraformReference<double>(this, "max_data_storage_in_tbs");
    }

    /// <summary>
    /// The total amount of local node storage, in gigabytes (GB), that&#39;s available on the Exadata infrastructure
    /// </summary>
    public TerraformValue<double> MaxDbNodeStorageSizeInGbs
    {
        get => new TerraformReference<double>(this, "max_db_node_storage_size_in_gbs");
    }

    /// <summary>
    /// The total amount of memory in gigabytes (GB) available on the Exadata infrastructure
    /// </summary>
    public TerraformValue<double> MaxMemoryInGbs
    {
        get => new TerraformReference<double>(this, "max_memory_in_gbs");
    }

    /// <summary>
    /// The amount of memory, in gigabytes (GB), that&#39;s allocated on the Exadata infrastructure
    /// </summary>
    public TerraformValue<double> MemorySizeInGbs
    {
        get => new TerraformReference<double>(this, "memory_size_in_gbs");
    }

    /// <summary>
    /// The monthly software version of the database servers in the Exadata infrastructure
    /// </summary>
    public TerraformValue<string> MonthlyDbServerVersion
    {
        get => new TerraformReference<string>(this, "monthly_db_server_version");
    }

    /// <summary>
    /// The monthly software version of the storage servers installed on the Exadata infrastructure
    /// </summary>
    public TerraformValue<string> MonthlyStorageServerVersion
    {
        get => new TerraformReference<string>(this, "monthly_storage_server_version");
    }

    /// <summary>
    /// The OCID of the next maintenance run for the Exadata infrastructure
    /// </summary>
    public TerraformValue<string> NextMaintenanceRunId
    {
        get => new TerraformReference<string>(this, "next_maintenance_run_id");
    }

    /// <summary>
    /// The name of the OCI resource anchor for the Exadata infrastructure
    /// </summary>
    public TerraformValue<string> OciResourceAnchorName
    {
        get => new TerraformReference<string>(this, "oci_resource_anchor_name");
    }

    /// <summary>
    /// The HTTPS link to the Exadata infrastructure in OCI
    /// </summary>
    public TerraformValue<string> OciUrl
    {
        get => new TerraformReference<string>(this, "oci_url");
    }

    /// <summary>
    /// The OCID of the Exadata infrastructure
    /// </summary>
    public TerraformValue<string> Ocid
    {
        get => new TerraformReference<string>(this, "ocid");
    }

    /// <summary>
    /// The amount of progress made on the current operation on the Exadata infrastructure, expressed as a percentage
    /// </summary>
    public TerraformValue<double> PercentProgress
    {
        get => new TerraformReference<double>(this, "percent_progress");
    }

    /// <summary>
    /// The current status of the Exadata infrastructure
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

    /// <summary>
    /// Additional information about the status of the Exadata infrastructure
    /// </summary>
    public TerraformValue<string> StatusReason
    {
        get => new TerraformReference<string>(this, "status_reason");
    }

    /// <summary>
    /// The software version of the storage servers on the Exadata infrastructure.
    /// </summary>
    public TerraformValue<string> StorageServerVersion
    {
        get => new TerraformReference<string>(this, "storage_server_version");
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
    }

    /// <summary>
    /// The total amount of storage, in gigabytes (GB), on the Exadata infrastructure.
    /// </summary>
    public TerraformValue<double> TotalStorageSizeInGbs
    {
        get => new TerraformReference<double>(this, "total_storage_size_in_gbs");
    }

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
