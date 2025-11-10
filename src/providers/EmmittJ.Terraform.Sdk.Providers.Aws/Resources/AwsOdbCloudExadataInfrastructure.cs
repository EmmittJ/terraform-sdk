using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for maintenance_window in .
/// Nesting mode: list
/// </summary>
public class AwsOdbCloudExadataInfrastructureMaintenanceWindowBlock : TerraformBlock
{
    /// <summary>
    /// The custom_action_timeout_in_mins attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomActionTimeoutInMins is required")]
    public required TerraformProperty<double> CustomActionTimeoutInMins
    {
        set => SetProperty("custom_action_timeout_in_mins", value);
    }

    /// <summary>
    /// The days_of_week attribute.
    /// </summary>
    public HashSet<TerraformProperty<object>>? DaysOfWeek
    {
        set => SetProperty("days_of_week", value);
    }

    /// <summary>
    /// The hours_of_day attribute.
    /// </summary>
    public HashSet<TerraformProperty<double>>? HoursOfDay
    {
        set => SetProperty("hours_of_day", value);
    }

    /// <summary>
    /// The is_custom_action_timeout_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IsCustomActionTimeoutEnabled is required")]
    public required TerraformProperty<bool> IsCustomActionTimeoutEnabled
    {
        set => SetProperty("is_custom_action_timeout_enabled", value);
    }

    /// <summary>
    /// The lead_time_in_weeks attribute.
    /// </summary>
    public TerraformProperty<double>? LeadTimeInWeeks
    {
        set => SetProperty("lead_time_in_weeks", value);
    }

    /// <summary>
    /// The months attribute.
    /// </summary>
    public HashSet<TerraformProperty<object>>? Months
    {
        set => SetProperty("months", value);
    }

    /// <summary>
    /// The patching_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PatchingMode is required")]
    public required TerraformProperty<string> PatchingMode
    {
        set => SetProperty("patching_mode", value);
    }

    /// <summary>
    /// The preference attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Preference is required")]
    public required TerraformProperty<string> Preference
    {
        set => SetProperty("preference", value);
    }

    /// <summary>
    /// The weeks_of_month attribute.
    /// </summary>
    public HashSet<TerraformProperty<double>>? WeeksOfMonth
    {
        set => SetProperty("weeks_of_month", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsOdbCloudExadataInfrastructureTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_odb_cloud_exadata_infrastructure resource.
/// </summary>
public class AwsOdbCloudExadataInfrastructure : TerraformResource
{
    public AwsOdbCloudExadataInfrastructure(string name) : base("aws_odb_cloud_exadata_infrastructure", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("activated_storage_count");
        SetOutput("additional_storage_count");
        SetOutput("arn");
        SetOutput("available_storage_size_in_gbs");
        SetOutput("compute_model");
        SetOutput("cpu_count");
        SetOutput("created_at");
        SetOutput("data_storage_size_in_tbs");
        SetOutput("db_node_storage_size_in_gbs");
        SetOutput("db_server_version");
        SetOutput("id");
        SetOutput("last_maintenance_run_id");
        SetOutput("max_cpu_count");
        SetOutput("max_data_storage_in_tbs");
        SetOutput("max_db_node_storage_size_in_gbs");
        SetOutput("max_memory_in_gbs");
        SetOutput("memory_size_in_gbs");
        SetOutput("monthly_db_server_version");
        SetOutput("monthly_storage_server_version");
        SetOutput("next_maintenance_run_id");
        SetOutput("oci_resource_anchor_name");
        SetOutput("oci_url");
        SetOutput("ocid");
        SetOutput("percent_progress");
        SetOutput("status");
        SetOutput("status_reason");
        SetOutput("storage_server_version");
        SetOutput("tags_all");
        SetOutput("total_storage_size_in_gbs");
        SetOutput("availability_zone");
        SetOutput("availability_zone_id");
        SetOutput("compute_count");
        SetOutput("customer_contacts_to_send_to_oci");
        SetOutput("database_server_type");
        SetOutput("display_name");
        SetOutput("region");
        SetOutput("shape");
        SetOutput("storage_count");
        SetOutput("storage_server_type");
        SetOutput("tags");
    }

    /// <summary>
    /// The name of the Availability Zone (AZ) where the Exadata infrastructure is located. Changing this will force terraform to create new resource
    /// </summary>
    public TerraformProperty<string> AvailabilityZone
    {
        get => GetRequiredOutput<TerraformProperty<string>>("availability_zone");
        set => SetProperty("availability_zone", value);
    }

    /// <summary>
    ///  The AZ ID of the AZ where the Exadata infrastructure is located. Changing this will force terraform to create new resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AvailabilityZoneId is required")]
    public required TerraformProperty<string> AvailabilityZoneId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("availability_zone_id");
        set => SetProperty("availability_zone_id", value);
    }

    /// <summary>
    ///  The number of compute instances that the Exadata infrastructure is located
    /// </summary>
    public TerraformProperty<double> ComputeCount
    {
        get => GetRequiredOutput<TerraformProperty<double>>("compute_count");
        set => SetProperty("compute_count", value);
    }

    /// <summary>
    /// The email addresses of contacts to receive notification from Oracle about maintenance updates for the Exadata infrastructure. Changing this will force terraform to create new resource
    /// </summary>
    public HashSet<TerraformProperty<object>> CustomerContactsToSendToOci
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<object>>>("customer_contacts_to_send_to_oci");
        set => SetProperty("customer_contacts_to_send_to_oci", value);
    }

    /// <summary>
    /// The database server model type of the Exadata infrastructure. For the list of valid model names, use the ListDbSystemShapes operation
    /// </summary>
    public TerraformProperty<string> DatabaseServerType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("database_server_type");
        set => SetProperty("database_server_type", value);
    }

    /// <summary>
    /// The user-friendly name for the Exadata infrastructure. Changing this will force terraform to create a new resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The model name of the Exadata infrastructure. Changing this will force terraform to create new resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Shape is required")]
    public required TerraformProperty<string> Shape
    {
        get => GetRequiredOutput<TerraformProperty<string>>("shape");
        set => SetProperty("shape", value);
    }

    /// <summary>
    /// TThe number of storage servers that are activated for the Exadata infrastructure
    /// </summary>
    public TerraformProperty<double> StorageCount
    {
        get => GetRequiredOutput<TerraformProperty<double>>("storage_count");
        set => SetProperty("storage_count", value);
    }

    /// <summary>
    /// The storage server model type of the Exadata infrastructure. For the list of valid model names, use the ListDbSystemShapes operation
    /// </summary>
    public TerraformProperty<string> StorageServerType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("storage_server_type");
        set => SetProperty("storage_server_type", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// Block for maintenance_window.
    /// Nesting mode: list
    /// </summary>
    public List<AwsOdbCloudExadataInfrastructureMaintenanceWindowBlock>? MaintenanceWindow
    {
        set => SetProperty("maintenance_window", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsOdbCloudExadataInfrastructureTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The number of storage servers requested for the Exadata infrastructure
    /// </summary>
    public TerraformExpression ActivatedStorageCount => this["activated_storage_count"];

    /// <summary>
    ///  The number of storage servers requested for the Exadata infrastructure
    /// </summary>
    public TerraformExpression AdditionalStorageCount => this["additional_storage_count"];

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The amount of available storage, in gigabytes (GB), for the Exadata infrastructure
    /// </summary>
    public TerraformExpression AvailableStorageSizeInGbs => this["available_storage_size_in_gbs"];

    /// <summary>
    /// The OCI model compute model used when you create or clone an
    ///   instance: ECPU or OCPU. An ECPU is an abstracted measure of
    ///  compute resources. ECPUs are based on the number of cores
    ///  elastically allocated from a pool of compute and storage servers.
    ///   An OCPU is a legacy physical measure of compute resources. OCPUs
    ///  are based on the physical core of a processor with
    ///   hyper-threading enabled.
    /// </summary>
    public TerraformExpression ComputeModel => this["compute_model"];

    /// <summary>
    /// The total number of CPU cores that are allocated to the Exadata infrastructure
    /// </summary>
    public TerraformExpression CpuCount => this["cpu_count"];

    /// <summary>
    /// The time when the Exadata infrastructure was created.
    /// </summary>
    public TerraformExpression CreatedAt => this["created_at"];

    /// <summary>
    /// The size of the Exadata infrastructure&#39;s data disk group, in terabytes (TB)
    /// </summary>
    public TerraformExpression DataStorageSizeInTbs => this["data_storage_size_in_tbs"];

    /// <summary>
    /// The size of the Exadata infrastructure&#39;s local node storage, in gigabytes (GB)
    /// </summary>
    public TerraformExpression DbNodeStorageSizeInGbs => this["db_node_storage_size_in_gbs"];

    /// <summary>
    /// The software version of the database servers (dom0) in the Exadata infrastructure
    /// </summary>
    public TerraformExpression DbServerVersion => this["db_server_version"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The Oracle Cloud Identifier (OCID) of the last maintenance run for the Exadata infrastructure
    /// </summary>
    public TerraformExpression LastMaintenanceRunId => this["last_maintenance_run_id"];

    /// <summary>
    /// The total number of CPU cores available on the Exadata infrastructure
    /// </summary>
    public TerraformExpression MaxCpuCount => this["max_cpu_count"];

    /// <summary>
    /// The total amount of data disk group storage, in terabytes (TB), that&#39;s available on the Exadata infrastructure
    /// </summary>
    public TerraformExpression MaxDataStorageInTbs => this["max_data_storage_in_tbs"];

    /// <summary>
    /// The total amount of local node storage, in gigabytes (GB), that&#39;s available on the Exadata infrastructure
    /// </summary>
    public TerraformExpression MaxDbNodeStorageSizeInGbs => this["max_db_node_storage_size_in_gbs"];

    /// <summary>
    /// The total amount of memory in gigabytes (GB) available on the Exadata infrastructure
    /// </summary>
    public TerraformExpression MaxMemoryInGbs => this["max_memory_in_gbs"];

    /// <summary>
    /// The amount of memory, in gigabytes (GB), that&#39;s allocated on the Exadata infrastructure
    /// </summary>
    public TerraformExpression MemorySizeInGbs => this["memory_size_in_gbs"];

    /// <summary>
    /// The monthly software version of the database servers in the Exadata infrastructure
    /// </summary>
    public TerraformExpression MonthlyDbServerVersion => this["monthly_db_server_version"];

    /// <summary>
    /// The monthly software version of the storage servers installed on the Exadata infrastructure
    /// </summary>
    public TerraformExpression MonthlyStorageServerVersion => this["monthly_storage_server_version"];

    /// <summary>
    /// The OCID of the next maintenance run for the Exadata infrastructure
    /// </summary>
    public TerraformExpression NextMaintenanceRunId => this["next_maintenance_run_id"];

    /// <summary>
    /// The name of the OCI resource anchor for the Exadata infrastructure
    /// </summary>
    public TerraformExpression OciResourceAnchorName => this["oci_resource_anchor_name"];

    /// <summary>
    /// The HTTPS link to the Exadata infrastructure in OCI
    /// </summary>
    public TerraformExpression OciUrl => this["oci_url"];

    /// <summary>
    /// The OCID of the Exadata infrastructure
    /// </summary>
    public TerraformExpression Ocid => this["ocid"];

    /// <summary>
    /// The amount of progress made on the current operation on the Exadata infrastructure, expressed as a percentage
    /// </summary>
    public TerraformExpression PercentProgress => this["percent_progress"];

    /// <summary>
    /// The current status of the Exadata infrastructure
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// Additional information about the status of the Exadata infrastructure
    /// </summary>
    public TerraformExpression StatusReason => this["status_reason"];

    /// <summary>
    /// The software version of the storage servers on the Exadata infrastructure.
    /// </summary>
    public TerraformExpression StorageServerVersion => this["storage_server_version"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

    /// <summary>
    /// The total amount of storage, in gigabytes (GB), on the Exadata infrastructure.
    /// </summary>
    public TerraformExpression TotalStorageSizeInGbs => this["total_storage_size_in_gbs"];

}
