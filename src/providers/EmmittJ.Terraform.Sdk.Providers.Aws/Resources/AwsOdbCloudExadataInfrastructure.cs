using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for maintenance_window in .
/// Nesting mode: list
/// </summary>
public partial class AwsOdbCloudExadataInfrastructureMaintenanceWindowBlock : TerraformBlockBase
{
    /// <summary>
    /// The custom_action_timeout_in_mins attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomActionTimeoutInMins is required")]
    [TerraformProperty("custom_action_timeout_in_mins")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> CustomActionTimeoutInMins { get; set; }

    /// <summary>
    /// The days_of_week attribute.
    /// </summary>
    [TerraformProperty("days_of_week")]
    // Optional+Computed - source generator will implement get/set
    public TerraformSet<object> DaysOfWeek { get; set; }

    /// <summary>
    /// The hours_of_day attribute.
    /// </summary>
    [TerraformProperty("hours_of_day")]
    // Optional+Computed - source generator will implement get/set
    public TerraformSet<double> HoursOfDay { get; set; }

    /// <summary>
    /// The is_custom_action_timeout_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IsCustomActionTimeoutEnabled is required")]
    [TerraformProperty("is_custom_action_timeout_enabled")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<bool> IsCustomActionTimeoutEnabled { get; set; }

    /// <summary>
    /// The lead_time_in_weeks attribute.
    /// </summary>
    [TerraformProperty("lead_time_in_weeks")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> LeadTimeInWeeks { get; set; }

    /// <summary>
    /// The months attribute.
    /// </summary>
    [TerraformProperty("months")]
    // Optional+Computed - source generator will implement get/set
    public TerraformSet<object> Months { get; set; }

    /// <summary>
    /// The patching_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PatchingMode is required")]
    [TerraformProperty("patching_mode")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> PatchingMode { get; set; }

    /// <summary>
    /// The preference attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Preference is required")]
    [TerraformProperty("preference")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Preference { get; set; }

    /// <summary>
    /// The weeks_of_month attribute.
    /// </summary>
    [TerraformProperty("weeks_of_month")]
    // Optional+Computed - source generator will implement get/set
    public TerraformSet<double> WeeksOfMonth { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsOdbCloudExadataInfrastructureTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_odb_cloud_exadata_infrastructure resource.
/// </summary>
public partial class AwsOdbCloudExadataInfrastructure : TerraformResource
{
    public AwsOdbCloudExadataInfrastructure(string name) : base("aws_odb_cloud_exadata_infrastructure", name)
    {
    }

    /// <summary>
    /// The name of the Availability Zone (AZ) where the Exadata infrastructure is located. Changing this will force terraform to create new resource
    /// </summary>
    [TerraformProperty("availability_zone")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> AvailabilityZone { get; set; }

    /// <summary>
    ///  The AZ ID of the AZ where the Exadata infrastructure is located. Changing this will force terraform to create new resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AvailabilityZoneId is required")]
    [TerraformProperty("availability_zone_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> AvailabilityZoneId { get; set; }

    /// <summary>
    ///  The number of compute instances that the Exadata infrastructure is located
    /// </summary>
    [TerraformProperty("compute_count")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> ComputeCount { get; set; }

    /// <summary>
    /// The email addresses of contacts to receive notification from Oracle about maintenance updates for the Exadata infrastructure. Changing this will force terraform to create new resource
    /// </summary>
    [TerraformProperty("customer_contacts_to_send_to_oci")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<object>? CustomerContactsToSendToOci { get; set; }

    /// <summary>
    /// The database server model type of the Exadata infrastructure. For the list of valid model names, use the ListDbSystemShapes operation
    /// </summary>
    [TerraformProperty("database_server_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DatabaseServerType { get; set; }

    /// <summary>
    /// The user-friendly name for the Exadata infrastructure. Changing this will force terraform to create a new resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformProperty("display_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The model name of the Exadata infrastructure. Changing this will force terraform to create new resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Shape is required")]
    [TerraformProperty("shape")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Shape { get; set; }

    /// <summary>
    /// TThe number of storage servers that are activated for the Exadata infrastructure
    /// </summary>
    [TerraformProperty("storage_count")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> StorageCount { get; set; }

    /// <summary>
    /// The storage server model type of the Exadata infrastructure. For the list of valid model names, use the ListDbSystemShapes operation
    /// </summary>
    [TerraformProperty("storage_server_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? StorageServerType { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for maintenance_window.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("maintenance_window")]
    public TerraformList<TerraformBlock<AwsOdbCloudExadataInfrastructureMaintenanceWindowBlock>>? MaintenanceWindow { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AwsOdbCloudExadataInfrastructureTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The number of storage servers requested for the Exadata infrastructure
    /// </summary>
    [TerraformProperty("activated_storage_count")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> ActivatedStorageCount { get; }

    /// <summary>
    ///  The number of storage servers requested for the Exadata infrastructure
    /// </summary>
    [TerraformProperty("additional_storage_count")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> AdditionalStorageCount { get; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The amount of available storage, in gigabytes (GB), for the Exadata infrastructure
    /// </summary>
    [TerraformProperty("available_storage_size_in_gbs")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> AvailableStorageSizeInGbs { get; }

    /// <summary>
    /// The OCI model compute model used when you create or clone an
    ///   instance: ECPU or OCPU. An ECPU is an abstracted measure of
    ///  compute resources. ECPUs are based on the number of cores
    ///  elastically allocated from a pool of compute and storage servers.
    ///   An OCPU is a legacy physical measure of compute resources. OCPUs
    ///  are based on the physical core of a processor with
    ///   hyper-threading enabled.
    /// </summary>
    [TerraformProperty("compute_model")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ComputeModel { get; }

    /// <summary>
    /// The total number of CPU cores that are allocated to the Exadata infrastructure
    /// </summary>
    [TerraformProperty("cpu_count")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> CpuCount { get; }

    /// <summary>
    /// The time when the Exadata infrastructure was created.
    /// </summary>
    [TerraformProperty("created_at")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreatedAt { get; }

    /// <summary>
    /// The size of the Exadata infrastructure&#39;s data disk group, in terabytes (TB)
    /// </summary>
    [TerraformProperty("data_storage_size_in_tbs")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> DataStorageSizeInTbs { get; }

    /// <summary>
    /// The size of the Exadata infrastructure&#39;s local node storage, in gigabytes (GB)
    /// </summary>
    [TerraformProperty("db_node_storage_size_in_gbs")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> DbNodeStorageSizeInGbs { get; }

    /// <summary>
    /// The software version of the database servers (dom0) in the Exadata infrastructure
    /// </summary>
    [TerraformProperty("db_server_version")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DbServerVersion { get; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Id { get; }

    /// <summary>
    /// The Oracle Cloud Identifier (OCID) of the last maintenance run for the Exadata infrastructure
    /// </summary>
    [TerraformProperty("last_maintenance_run_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LastMaintenanceRunId { get; }

    /// <summary>
    /// The total number of CPU cores available on the Exadata infrastructure
    /// </summary>
    [TerraformProperty("max_cpu_count")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> MaxCpuCount { get; }

    /// <summary>
    /// The total amount of data disk group storage, in terabytes (TB), that&#39;s available on the Exadata infrastructure
    /// </summary>
    [TerraformProperty("max_data_storage_in_tbs")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> MaxDataStorageInTbs { get; }

    /// <summary>
    /// The total amount of local node storage, in gigabytes (GB), that&#39;s available on the Exadata infrastructure
    /// </summary>
    [TerraformProperty("max_db_node_storage_size_in_gbs")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> MaxDbNodeStorageSizeInGbs { get; }

    /// <summary>
    /// The total amount of memory in gigabytes (GB) available on the Exadata infrastructure
    /// </summary>
    [TerraformProperty("max_memory_in_gbs")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> MaxMemoryInGbs { get; }

    /// <summary>
    /// The amount of memory, in gigabytes (GB), that&#39;s allocated on the Exadata infrastructure
    /// </summary>
    [TerraformProperty("memory_size_in_gbs")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> MemorySizeInGbs { get; }

    /// <summary>
    /// The monthly software version of the database servers in the Exadata infrastructure
    /// </summary>
    [TerraformProperty("monthly_db_server_version")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> MonthlyDbServerVersion { get; }

    /// <summary>
    /// The monthly software version of the storage servers installed on the Exadata infrastructure
    /// </summary>
    [TerraformProperty("monthly_storage_server_version")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> MonthlyStorageServerVersion { get; }

    /// <summary>
    /// The OCID of the next maintenance run for the Exadata infrastructure
    /// </summary>
    [TerraformProperty("next_maintenance_run_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> NextMaintenanceRunId { get; }

    /// <summary>
    /// The name of the OCI resource anchor for the Exadata infrastructure
    /// </summary>
    [TerraformProperty("oci_resource_anchor_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> OciResourceAnchorName { get; }

    /// <summary>
    /// The HTTPS link to the Exadata infrastructure in OCI
    /// </summary>
    [TerraformProperty("oci_url")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> OciUrl { get; }

    /// <summary>
    /// The OCID of the Exadata infrastructure
    /// </summary>
    [TerraformProperty("ocid")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Ocid { get; }

    /// <summary>
    /// The amount of progress made on the current operation on the Exadata infrastructure, expressed as a percentage
    /// </summary>
    [TerraformProperty("percent_progress")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> PercentProgress { get; }

    /// <summary>
    /// The current status of the Exadata infrastructure
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Status { get; }

    /// <summary>
    /// Additional information about the status of the Exadata infrastructure
    /// </summary>
    [TerraformProperty("status_reason")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> StatusReason { get; }

    /// <summary>
    /// The software version of the storage servers on the Exadata infrastructure.
    /// </summary>
    [TerraformProperty("storage_server_version")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> StorageServerVersion { get; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> TagsAll { get; }

    /// <summary>
    /// The total amount of storage, in gigabytes (GB), on the Exadata infrastructure.
    /// </summary>
    [TerraformProperty("total_storage_size_in_gbs")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> TotalStorageSizeInGbs { get; }

}
