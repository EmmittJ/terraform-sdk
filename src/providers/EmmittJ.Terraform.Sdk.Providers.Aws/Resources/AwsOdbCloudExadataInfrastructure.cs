using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for maintenance_window in .
/// Nesting mode: list
/// </summary>
public class AwsOdbCloudExadataInfrastructureMaintenanceWindowBlock : ITerraformBlock
{
    /// <summary>
    /// The custom_action_timeout_in_mins attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomActionTimeoutInMins is required")]
    [TerraformPropertyName("custom_action_timeout_in_mins")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> CustomActionTimeoutInMins { get; set; }

    /// <summary>
    /// The days_of_week attribute.
    /// </summary>
    [TerraformPropertyName("days_of_week")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<object>>> DaysOfWeek { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>("", "days_of_week");

    /// <summary>
    /// The hours_of_day attribute.
    /// </summary>
    [TerraformPropertyName("hours_of_day")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<double>>> HoursOfDay { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<double>>>("", "hours_of_day");

    /// <summary>
    /// The is_custom_action_timeout_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IsCustomActionTimeoutEnabled is required")]
    [TerraformPropertyName("is_custom_action_timeout_enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> IsCustomActionTimeoutEnabled { get; set; }

    /// <summary>
    /// The lead_time_in_weeks attribute.
    /// </summary>
    [TerraformPropertyName("lead_time_in_weeks")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> LeadTimeInWeeks { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "lead_time_in_weeks");

    /// <summary>
    /// The months attribute.
    /// </summary>
    [TerraformPropertyName("months")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<object>>> Months { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>("", "months");

    /// <summary>
    /// The patching_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PatchingMode is required")]
    [TerraformPropertyName("patching_mode")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> PatchingMode { get; set; }

    /// <summary>
    /// The preference attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Preference is required")]
    [TerraformPropertyName("preference")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Preference { get; set; }

    /// <summary>
    /// The weeks_of_month attribute.
    /// </summary>
    [TerraformPropertyName("weeks_of_month")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<double>>> WeeksOfMonth { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<double>>>("", "weeks_of_month");

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsOdbCloudExadataInfrastructureTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> AvailabilityZone { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "availability_zone");

    /// <summary>
    ///  The AZ ID of the AZ where the Exadata infrastructure is located. Changing this will force terraform to create new resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AvailabilityZoneId is required")]
    [TerraformPropertyName("availability_zone_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AvailabilityZoneId { get; set; }

    /// <summary>
    ///  The number of compute instances that the Exadata infrastructure is located
    /// </summary>
    [TerraformPropertyName("compute_count")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> ComputeCount { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "compute_count");

    /// <summary>
    /// The email addresses of contacts to receive notification from Oracle about maintenance updates for the Exadata infrastructure. Changing this will force terraform to create new resource
    /// </summary>
    [TerraformPropertyName("customer_contacts_to_send_to_oci")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<object>>>? CustomerContactsToSendToOci { get; set; }

    /// <summary>
    /// The database server model type of the Exadata infrastructure. For the list of valid model names, use the ListDbSystemShapes operation
    /// </summary>
    [TerraformPropertyName("database_server_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DatabaseServerType { get; set; }

    /// <summary>
    /// The user-friendly name for the Exadata infrastructure. Changing this will force terraform to create a new resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformPropertyName("display_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DisplayName { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The model name of the Exadata infrastructure. Changing this will force terraform to create new resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Shape is required")]
    [TerraformPropertyName("shape")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Shape { get; set; }

    /// <summary>
    /// TThe number of storage servers that are activated for the Exadata infrastructure
    /// </summary>
    [TerraformPropertyName("storage_count")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> StorageCount { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "storage_count");

    /// <summary>
    /// The storage server model type of the Exadata infrastructure. For the list of valid model names, use the ListDbSystemShapes operation
    /// </summary>
    [TerraformPropertyName("storage_server_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? StorageServerType { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// Block for maintenance_window.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("maintenance_window")]
    public TerraformList<TerraformBlock<AwsOdbCloudExadataInfrastructureMaintenanceWindowBlock>>? MaintenanceWindow { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsOdbCloudExadataInfrastructureTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The number of storage servers requested for the Exadata infrastructure
    /// </summary>
    [TerraformPropertyName("activated_storage_count")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> ActivatedStorageCount => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "activated_storage_count");

    /// <summary>
    ///  The number of storage servers requested for the Exadata infrastructure
    /// </summary>
    [TerraformPropertyName("additional_storage_count")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> AdditionalStorageCount => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "additional_storage_count");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The amount of available storage, in gigabytes (GB), for the Exadata infrastructure
    /// </summary>
    [TerraformPropertyName("available_storage_size_in_gbs")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> AvailableStorageSizeInGbs => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "available_storage_size_in_gbs");

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
    public TerraformProperty<TerraformProperty<string>> ComputeModel => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "compute_model");

    /// <summary>
    /// The total number of CPU cores that are allocated to the Exadata infrastructure
    /// </summary>
    [TerraformPropertyName("cpu_count")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> CpuCount => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "cpu_count");

    /// <summary>
    /// The time when the Exadata infrastructure was created.
    /// </summary>
    [TerraformPropertyName("created_at")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreatedAt => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "created_at");

    /// <summary>
    /// The size of the Exadata infrastructure&#39;s data disk group, in terabytes (TB)
    /// </summary>
    [TerraformPropertyName("data_storage_size_in_tbs")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> DataStorageSizeInTbs => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "data_storage_size_in_tbs");

    /// <summary>
    /// The size of the Exadata infrastructure&#39;s local node storage, in gigabytes (GB)
    /// </summary>
    [TerraformPropertyName("db_node_storage_size_in_gbs")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> DbNodeStorageSizeInGbs => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "db_node_storage_size_in_gbs");

    /// <summary>
    /// The software version of the database servers (dom0) in the Exadata infrastructure
    /// </summary>
    [TerraformPropertyName("db_server_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DbServerVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "db_server_version");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The Oracle Cloud Identifier (OCID) of the last maintenance run for the Exadata infrastructure
    /// </summary>
    [TerraformPropertyName("last_maintenance_run_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LastMaintenanceRunId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "last_maintenance_run_id");

    /// <summary>
    /// The total number of CPU cores available on the Exadata infrastructure
    /// </summary>
    [TerraformPropertyName("max_cpu_count")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> MaxCpuCount => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "max_cpu_count");

    /// <summary>
    /// The total amount of data disk group storage, in terabytes (TB), that&#39;s available on the Exadata infrastructure
    /// </summary>
    [TerraformPropertyName("max_data_storage_in_tbs")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> MaxDataStorageInTbs => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "max_data_storage_in_tbs");

    /// <summary>
    /// The total amount of local node storage, in gigabytes (GB), that&#39;s available on the Exadata infrastructure
    /// </summary>
    [TerraformPropertyName("max_db_node_storage_size_in_gbs")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> MaxDbNodeStorageSizeInGbs => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "max_db_node_storage_size_in_gbs");

    /// <summary>
    /// The total amount of memory in gigabytes (GB) available on the Exadata infrastructure
    /// </summary>
    [TerraformPropertyName("max_memory_in_gbs")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> MaxMemoryInGbs => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "max_memory_in_gbs");

    /// <summary>
    /// The amount of memory, in gigabytes (GB), that&#39;s allocated on the Exadata infrastructure
    /// </summary>
    [TerraformPropertyName("memory_size_in_gbs")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> MemorySizeInGbs => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "memory_size_in_gbs");

    /// <summary>
    /// The monthly software version of the database servers in the Exadata infrastructure
    /// </summary>
    [TerraformPropertyName("monthly_db_server_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> MonthlyDbServerVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "monthly_db_server_version");

    /// <summary>
    /// The monthly software version of the storage servers installed on the Exadata infrastructure
    /// </summary>
    [TerraformPropertyName("monthly_storage_server_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> MonthlyStorageServerVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "monthly_storage_server_version");

    /// <summary>
    /// The OCID of the next maintenance run for the Exadata infrastructure
    /// </summary>
    [TerraformPropertyName("next_maintenance_run_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NextMaintenanceRunId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "next_maintenance_run_id");

    /// <summary>
    /// The name of the OCI resource anchor for the Exadata infrastructure
    /// </summary>
    [TerraformPropertyName("oci_resource_anchor_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OciResourceAnchorName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "oci_resource_anchor_name");

    /// <summary>
    /// The HTTPS link to the Exadata infrastructure in OCI
    /// </summary>
    [TerraformPropertyName("oci_url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OciUrl => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "oci_url");

    /// <summary>
    /// The OCID of the Exadata infrastructure
    /// </summary>
    [TerraformPropertyName("ocid")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Ocid => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ocid");

    /// <summary>
    /// The amount of progress made on the current operation on the Exadata infrastructure, expressed as a percentage
    /// </summary>
    [TerraformPropertyName("percent_progress")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> PercentProgress => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "percent_progress");

    /// <summary>
    /// The current status of the Exadata infrastructure
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Status => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status");

    /// <summary>
    /// Additional information about the status of the Exadata infrastructure
    /// </summary>
    [TerraformPropertyName("status_reason")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StatusReason => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status_reason");

    /// <summary>
    /// The software version of the storage servers on the Exadata infrastructure.
    /// </summary>
    [TerraformPropertyName("storage_server_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StorageServerVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "storage_server_version");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// The total amount of storage, in gigabytes (GB), on the Exadata infrastructure.
    /// </summary>
    [TerraformPropertyName("total_storage_size_in_gbs")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> TotalStorageSizeInGbs => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "total_storage_size_in_gbs");

}
