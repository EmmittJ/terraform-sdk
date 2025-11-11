using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_odb_cloud_exadata_infrastructure.
/// </summary>
public class AwsOdbCloudExadataInfrastructureDataSource : TerraformDataSource
{
    public AwsOdbCloudExadataInfrastructureDataSource(string name) : base("aws_odb_cloud_exadata_infrastructure", name)
    {
    }

    /// <summary>
    /// The unique identifier of the Exadata infrastructure.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformPropertyName("id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The number of storage servers requested for the Exadata infrastructure.
    /// </summary>
    [TerraformPropertyName("activated_storage_count")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> ActivatedStorageCount => new TerraformReference(this, "activated_storage_count");

    /// <summary>
    /// The number of storage servers requested for the Exadata infrastructure.
    /// </summary>
    [TerraformPropertyName("additional_storage_count")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> AdditionalStorageCount => new TerraformReference(this, "additional_storage_count");

    /// <summary>
    /// The Amazon Resource Name (ARN) for the Exadata infrastructure.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// he name of the Availability Zone (AZ) where the Exadata infrastructure is located.
    /// </summary>
    [TerraformPropertyName("availability_zone")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AvailabilityZone => new TerraformReference(this, "availability_zone");

    /// <summary>
    /// The AZ ID of the AZ where the Exadata infrastructure is located.
    /// </summary>
    [TerraformPropertyName("availability_zone_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AvailabilityZoneId => new TerraformReference(this, "availability_zone_id");

    /// <summary>
    /// The amount of available storage, in gigabytes (GB), for the Exadata infrastructure.
    /// </summary>
    [TerraformPropertyName("available_storage_size_in_gbs")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> AvailableStorageSizeInGbs => new TerraformReference(this, "available_storage_size_in_gbs");

    /// <summary>
    /// The number of database servers for the Exadata infrastructure.
    /// </summary>
    [TerraformPropertyName("compute_count")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> ComputeCount => new TerraformReference(this, "compute_count");

    /// <summary>
    /// The OCI model compute model used when you create or clone an instance: ECPU or
    /// OCPU. An ECPU is an abstracted measure of compute resources. ECPUs are based on
    /// the number of cores elastically allocated from a pool of compute and storage
    /// servers. An OCPU is a legacy physical measure of compute resources. OCPUs are
    /// based on the physical core of a processor with hyper-threading enabled.
    /// </summary>
    [TerraformPropertyName("compute_model")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ComputeModel => new TerraformReference(this, "compute_model");

    /// <summary>
    /// The total number of CPU cores that are allocated to the Exadata infrastructure.
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
    /// The email addresses of contacts to receive notification from Oracle about maintenance updates for the Exadata infrastructure.
    /// </summary>
    [TerraformPropertyName("customer_contacts_to_send_to_oci")]
    // Output-only attribute - read-only reference
    public TerraformSet<object> CustomerContactsToSendToOci => new TerraformReference(this, "customer_contacts_to_send_to_oci");

    /// <summary>
    /// The size of the Exadata infrastructure&#39;s data disk group, in terabytes (TB).
    /// </summary>
    [TerraformPropertyName("data_storage_size_in_tbs")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> DataStorageSizeInTbs => new TerraformReference(this, "data_storage_size_in_tbs");

    /// <summary>
    /// The database server model type of the Exadata infrastructure. For the list of valid model names, use the ListDbSystemShapes operation.
    /// </summary>
    [TerraformPropertyName("database_server_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DatabaseServerType => new TerraformReference(this, "database_server_type");

    /// <summary>
    /// The database server model type of the Exadata infrastructure. For the list of
    /// valid model names, use the ListDbSystemShapes operation.
    /// </summary>
    [TerraformPropertyName("db_node_storage_size_in_gbs")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> DbNodeStorageSizeInGbs => new TerraformReference(this, "db_node_storage_size_in_gbs");

    /// <summary>
    /// The version of the Exadata infrastructure.
    /// </summary>
    [TerraformPropertyName("db_server_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DbServerVersion => new TerraformReference(this, "db_server_version");

    /// <summary>
    /// The display name of the Exadata infrastructure.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DisplayName => new TerraformReference(this, "display_name");

    /// <summary>
    /// The Oracle Cloud Identifier (OCID) of the last maintenance run for the Exadata infrastructure.
    /// </summary>
    [TerraformPropertyName("last_maintenance_run_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LastMaintenanceRunId => new TerraformReference(this, "last_maintenance_run_id");

    /// <summary>
    ///  The scheduling details for the maintenance window. Patching and system updates take place during the maintenance window 
    /// </summary>
    [TerraformPropertyName("maintenance_window")]
    // Output-only attribute - read-only reference
    public TerraformList<object> MaintenanceWindow => new TerraformReference(this, "maintenance_window");

    /// <summary>
    /// The total number of CPU cores available on the Exadata infrastructure.
    /// </summary>
    [TerraformPropertyName("max_cpu_count")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> MaxCpuCount => new TerraformReference(this, "max_cpu_count");

    /// <summary>
    /// The total amount of data disk group storage, in terabytes (TB), that&#39;s available on the Exadata infrastructure.
    /// </summary>
    [TerraformPropertyName("max_data_storage_in_tbs")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> MaxDataStorageInTbs => new TerraformReference(this, "max_data_storage_in_tbs");

    /// <summary>
    /// The total amount of local node storage, in gigabytes (GB), that&#39;s available on the Exadata infrastructure.
    /// </summary>
    [TerraformPropertyName("max_db_node_storage_size_in_gbs")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> MaxDbNodeStorageSizeInGbs => new TerraformReference(this, "max_db_node_storage_size_in_gbs");

    /// <summary>
    /// The total amount of memory, in gigabytes (GB), that&#39;s available on the Exadata infrastructure.
    /// </summary>
    [TerraformPropertyName("max_memory_in_gbs")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> MaxMemoryInGbs => new TerraformReference(this, "max_memory_in_gbs");

    /// <summary>
    /// The amount of memory, in gigabytes (GB), that&#39;s allocated on the Exadata infrastructure.
    /// </summary>
    [TerraformPropertyName("memory_size_in_gbs")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> MemorySizeInGbs => new TerraformReference(this, "memory_size_in_gbs");

    /// <summary>
    /// The monthly software version of the database servers installed on the Exadata infrastructure.
    /// </summary>
    [TerraformPropertyName("monthly_db_server_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> MonthlyDbServerVersion => new TerraformReference(this, "monthly_db_server_version");

    /// <summary>
    /// The monthly software version of the storage servers installed on the Exadata infrastructure.
    /// </summary>
    [TerraformPropertyName("monthly_storage_server_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> MonthlyStorageServerVersion => new TerraformReference(this, "monthly_storage_server_version");

    /// <summary>
    /// The OCID of the next maintenance run for the Exadata infrastructure.
    /// </summary>
    [TerraformPropertyName("next_maintenance_run_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> NextMaintenanceRunId => new TerraformReference(this, "next_maintenance_run_id");

    /// <summary>
    /// The name of the OCI resource anchor for the Exadata infrastructure.
    /// </summary>
    [TerraformPropertyName("oci_resource_anchor_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OciResourceAnchorName => new TerraformReference(this, "oci_resource_anchor_name");

    /// <summary>
    /// The HTTPS link to the Exadata infrastructure in OCI.
    /// </summary>
    [TerraformPropertyName("oci_url")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OciUrl => new TerraformReference(this, "oci_url");

    /// <summary>
    /// The OCID of the Exadata infrastructure in OCI.
    /// </summary>
    [TerraformPropertyName("ocid")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Ocid => new TerraformReference(this, "ocid");

    /// <summary>
    /// The amount of progress made on the current operation on the Exadata infrastructure expressed as a percentage.
    /// </summary>
    [TerraformPropertyName("percent_progress")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> PercentProgress => new TerraformReference(this, "percent_progress");

    /// <summary>
    /// The model name of the Exadata infrastructure.
    /// </summary>
    [TerraformPropertyName("shape")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Shape => new TerraformReference(this, "shape");

    /// <summary>
    /// The status of the Exadata infrastructure.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Status => new TerraformReference(this, "status");

    /// <summary>
    /// Additional information about the status of the Exadata infrastructure.
    /// </summary>
    [TerraformPropertyName("status_reason")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> StatusReason => new TerraformReference(this, "status_reason");

    /// <summary>
    /// he number of storage servers that are activated for the Exadata infrastructure.
    /// </summary>
    [TerraformPropertyName("storage_count")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> StorageCount => new TerraformReference(this, "storage_count");

    /// <summary>
    /// The storage server model type of the Exadata infrastructure. For the list of valid model names, use the ListDbSystemShapes operation.
    /// </summary>
    [TerraformPropertyName("storage_server_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> StorageServerType => new TerraformReference(this, "storage_server_type");

    /// <summary>
    /// The software version of the storage servers on the Exadata infrastructure.
    /// </summary>
    [TerraformPropertyName("storage_server_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> StorageServerVersion => new TerraformReference(this, "storage_server_version");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Tags => new TerraformReference(this, "tags");

    /// <summary>
    /// The total amount of storage, in gigabytes (GB), on the the Exadata infrastructure.
    /// </summary>
    [TerraformPropertyName("total_storage_size_in_gbs")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> TotalStorageSizeInGbs => new TerraformReference(this, "total_storage_size_in_gbs");

}
