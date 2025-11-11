using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for maintenance_window in .
/// Nesting mode: list
/// </summary>
public class AwsOdbCloudExadataInfrastructureMaintenanceWindowBlock
{
    /// <summary>
    /// The custom_action_timeout_in_mins attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomActionTimeoutInMins is required")]
    [TerraformPropertyName("custom_action_timeout_in_mins")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> CustomActionTimeoutInMins { get; set; }

    /// <summary>
    /// The days_of_week attribute.
    /// </summary>
    [TerraformPropertyName("days_of_week")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformSet<object> DaysOfWeek { get; set; } = default!;

    /// <summary>
    /// The hours_of_day attribute.
    /// </summary>
    [TerraformPropertyName("hours_of_day")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformSet<double> HoursOfDay { get; set; } = default!;

    /// <summary>
    /// The is_custom_action_timeout_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IsCustomActionTimeoutEnabled is required")]
    [TerraformPropertyName("is_custom_action_timeout_enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> IsCustomActionTimeoutEnabled { get; set; }

    /// <summary>
    /// The lead_time_in_weeks attribute.
    /// </summary>
    [TerraformPropertyName("lead_time_in_weeks")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> LeadTimeInWeeks { get; set; } = default!;

    /// <summary>
    /// The months attribute.
    /// </summary>
    [TerraformPropertyName("months")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformSet<object> Months { get; set; } = default!;

    /// <summary>
    /// The patching_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PatchingMode is required")]
    [TerraformPropertyName("patching_mode")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> PatchingMode { get; set; }

    /// <summary>
    /// The preference attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Preference is required")]
    [TerraformPropertyName("preference")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Preference { get; set; }

    /// <summary>
    /// The weeks_of_month attribute.
    /// </summary>
    [TerraformPropertyName("weeks_of_month")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformSet<double> WeeksOfMonth { get; set; } = default!;

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsOdbCloudExadataInfrastructureTimeoutsBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_odb_cloud_exadata_infrastructure resource.
/// </summary>
public class AwsOdbCloudExadataInfrastructure : TerraformResource
{
    public AwsOdbCloudExadataInfrastructure(string name) : base("aws_odb_cloud_exadata_infrastructure", name)
    {
    }

    /// <summary>
    /// The name of the Availability Zone (AZ) where the Exadata infrastructure is located. Changing this will force terraform to create new resource
    /// </summary>
    [TerraformPropertyName("availability_zone")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> AvailabilityZone { get; set; } = default!;

    /// <summary>
    ///  The AZ ID of the AZ where the Exadata infrastructure is located. Changing this will force terraform to create new resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AvailabilityZoneId is required")]
    [TerraformPropertyName("availability_zone_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> AvailabilityZoneId { get; set; }

    /// <summary>
    ///  The number of compute instances that the Exadata infrastructure is located
    /// </summary>
    [TerraformPropertyName("compute_count")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> ComputeCount { get; set; } = default!;

    /// <summary>
    /// The email addresses of contacts to receive notification from Oracle about maintenance updates for the Exadata infrastructure. Changing this will force terraform to create new resource
    /// </summary>
    [TerraformPropertyName("customer_contacts_to_send_to_oci")]
    // Optional argument - user may or may not set a value
    public TerraformSet<object>? CustomerContactsToSendToOci { get; set; }

    /// <summary>
    /// The database server model type of the Exadata infrastructure. For the list of valid model names, use the ListDbSystemShapes operation
    /// </summary>
    [TerraformPropertyName("database_server_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DatabaseServerType { get; set; }

    /// <summary>
    /// The user-friendly name for the Exadata infrastructure. Changing this will force terraform to create a new resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformPropertyName("display_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The model name of the Exadata infrastructure. Changing this will force terraform to create new resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Shape is required")]
    [TerraformPropertyName("shape")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Shape { get; set; }

    /// <summary>
    /// TThe number of storage servers that are activated for the Exadata infrastructure
    /// </summary>
    [TerraformPropertyName("storage_count")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> StorageCount { get; set; } = default!;

    /// <summary>
    /// The storage server model type of the Exadata infrastructure. For the list of valid model names, use the ListDbSystemShapes operation
    /// </summary>
    [TerraformPropertyName("storage_server_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? StorageServerType { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for maintenance_window.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("maintenance_window")]
    public TerraformList<TerraformBlock<AwsOdbCloudExadataInfrastructureMaintenanceWindowBlock>>? MaintenanceWindow { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsOdbCloudExadataInfrastructureTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The number of storage servers requested for the Exadata infrastructure
    /// </summary>
    [TerraformPropertyName("activated_storage_count")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> ActivatedStorageCount => new TerraformReference(this, "activated_storage_count");

    /// <summary>
    ///  The number of storage servers requested for the Exadata infrastructure
    /// </summary>
    [TerraformPropertyName("additional_storage_count")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> AdditionalStorageCount => new TerraformReference(this, "additional_storage_count");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The amount of available storage, in gigabytes (GB), for the Exadata infrastructure
    /// </summary>
    [TerraformPropertyName("available_storage_size_in_gbs")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> AvailableStorageSizeInGbs => new TerraformReference(this, "available_storage_size_in_gbs");

    /// <summary>
    /// The OCI model compute model used when you create or clone an
    ///   instance: ECPU or OCPU. An ECPU is an abstracted measure of
    ///  compute resources. ECPUs are based on the number of cores
    ///  elastically allocated from a pool of compute and storage servers.
    ///   An OCPU is a legacy physical measure of compute resources. OCPUs
    ///  are based on the physical core of a processor with
    ///   hyper-threading enabled.
    /// </summary>
    [TerraformPropertyName("compute_model")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ComputeModel => new TerraformReference(this, "compute_model");

    /// <summary>
    /// The total number of CPU cores that are allocated to the Exadata infrastructure
    /// </summary>
    [TerraformPropertyName("cpu_count")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> CpuCount => new TerraformReference(this, "cpu_count");

    /// <summary>
    /// The time when the Exadata infrastructure was created.
    /// </summary>
    [TerraformPropertyName("created_at")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreatedAt => new TerraformReference(this, "created_at");

    /// <summary>
    /// The size of the Exadata infrastructure&#39;s data disk group, in terabytes (TB)
    /// </summary>
    [TerraformPropertyName("data_storage_size_in_tbs")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> DataStorageSizeInTbs => new TerraformReference(this, "data_storage_size_in_tbs");

    /// <summary>
    /// The size of the Exadata infrastructure&#39;s local node storage, in gigabytes (GB)
    /// </summary>
    [TerraformPropertyName("db_node_storage_size_in_gbs")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> DbNodeStorageSizeInGbs => new TerraformReference(this, "db_node_storage_size_in_gbs");

    /// <summary>
    /// The software version of the database servers (dom0) in the Exadata infrastructure
    /// </summary>
    [TerraformPropertyName("db_server_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DbServerVersion => new TerraformReference(this, "db_server_version");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Id => new TerraformReference(this, "id");

    /// <summary>
    /// The Oracle Cloud Identifier (OCID) of the last maintenance run for the Exadata infrastructure
    /// </summary>
    [TerraformPropertyName("last_maintenance_run_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LastMaintenanceRunId => new TerraformReference(this, "last_maintenance_run_id");

    /// <summary>
    /// The total number of CPU cores available on the Exadata infrastructure
    /// </summary>
    [TerraformPropertyName("max_cpu_count")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> MaxCpuCount => new TerraformReference(this, "max_cpu_count");

    /// <summary>
    /// The total amount of data disk group storage, in terabytes (TB), that&#39;s available on the Exadata infrastructure
    /// </summary>
    [TerraformPropertyName("max_data_storage_in_tbs")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> MaxDataStorageInTbs => new TerraformReference(this, "max_data_storage_in_tbs");

    /// <summary>
    /// The total amount of local node storage, in gigabytes (GB), that&#39;s available on the Exadata infrastructure
    /// </summary>
    [TerraformPropertyName("max_db_node_storage_size_in_gbs")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> MaxDbNodeStorageSizeInGbs => new TerraformReference(this, "max_db_node_storage_size_in_gbs");

    /// <summary>
    /// The total amount of memory in gigabytes (GB) available on the Exadata infrastructure
    /// </summary>
    [TerraformPropertyName("max_memory_in_gbs")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> MaxMemoryInGbs => new TerraformReference(this, "max_memory_in_gbs");

    /// <summary>
    /// The amount of memory, in gigabytes (GB), that&#39;s allocated on the Exadata infrastructure
    /// </summary>
    [TerraformPropertyName("memory_size_in_gbs")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> MemorySizeInGbs => new TerraformReference(this, "memory_size_in_gbs");

    /// <summary>
    /// The monthly software version of the database servers in the Exadata infrastructure
    /// </summary>
    [TerraformPropertyName("monthly_db_server_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> MonthlyDbServerVersion => new TerraformReference(this, "monthly_db_server_version");

    /// <summary>
    /// The monthly software version of the storage servers installed on the Exadata infrastructure
    /// </summary>
    [TerraformPropertyName("monthly_storage_server_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> MonthlyStorageServerVersion => new TerraformReference(this, "monthly_storage_server_version");

    /// <summary>
    /// The OCID of the next maintenance run for the Exadata infrastructure
    /// </summary>
    [TerraformPropertyName("next_maintenance_run_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> NextMaintenanceRunId => new TerraformReference(this, "next_maintenance_run_id");

    /// <summary>
    /// The name of the OCI resource anchor for the Exadata infrastructure
    /// </summary>
    [TerraformPropertyName("oci_resource_anchor_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OciResourceAnchorName => new TerraformReference(this, "oci_resource_anchor_name");

    /// <summary>
    /// The HTTPS link to the Exadata infrastructure in OCI
    /// </summary>
    [TerraformPropertyName("oci_url")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OciUrl => new TerraformReference(this, "oci_url");

    /// <summary>
    /// The OCID of the Exadata infrastructure
    /// </summary>
    [TerraformPropertyName("ocid")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Ocid => new TerraformReference(this, "ocid");

    /// <summary>
    /// The amount of progress made on the current operation on the Exadata infrastructure, expressed as a percentage
    /// </summary>
    [TerraformPropertyName("percent_progress")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> PercentProgress => new TerraformReference(this, "percent_progress");

    /// <summary>
    /// The current status of the Exadata infrastructure
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Status => new TerraformReference(this, "status");

    /// <summary>
    /// Additional information about the status of the Exadata infrastructure
    /// </summary>
    [TerraformPropertyName("status_reason")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> StatusReason => new TerraformReference(this, "status_reason");

    /// <summary>
    /// The software version of the storage servers on the Exadata infrastructure.
    /// </summary>
    [TerraformPropertyName("storage_server_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> StorageServerVersion => new TerraformReference(this, "storage_server_version");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> TagsAll => new TerraformReference(this, "tags_all");

    /// <summary>
    /// The total amount of storage, in gigabytes (GB), on the Exadata infrastructure.
    /// </summary>
    [TerraformPropertyName("total_storage_size_in_gbs")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> TotalStorageSizeInGbs => new TerraformReference(this, "total_storage_size_in_gbs");

}
