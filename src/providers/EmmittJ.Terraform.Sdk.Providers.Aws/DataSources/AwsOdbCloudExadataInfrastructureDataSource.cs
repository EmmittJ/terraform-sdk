using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_odb_cloud_exadata_infrastructure.
/// </summary>
public partial class AwsOdbCloudExadataInfrastructureDataSource : TerraformDataSource
{
    public AwsOdbCloudExadataInfrastructureDataSource(string name) : base("aws_odb_cloud_exadata_infrastructure", name)
    {
    }

    /// <summary>
    /// The unique identifier of the Exadata infrastructure.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformProperty("id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The number of storage servers requested for the Exadata infrastructure.
    /// </summary>
    [TerraformProperty("activated_storage_count")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> ActivatedStorageCount { get; }

    /// <summary>
    /// The number of storage servers requested for the Exadata infrastructure.
    /// </summary>
    [TerraformProperty("additional_storage_count")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> AdditionalStorageCount { get; }

    /// <summary>
    /// The Amazon Resource Name (ARN) for the Exadata infrastructure.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// he name of the Availability Zone (AZ) where the Exadata infrastructure is located.
    /// </summary>
    [TerraformProperty("availability_zone")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AvailabilityZone { get; }

    /// <summary>
    /// The AZ ID of the AZ where the Exadata infrastructure is located.
    /// </summary>
    [TerraformProperty("availability_zone_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AvailabilityZoneId { get; }

    /// <summary>
    /// The amount of available storage, in gigabytes (GB), for the Exadata infrastructure.
    /// </summary>
    [TerraformProperty("available_storage_size_in_gbs")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> AvailableStorageSizeInGbs { get; }

    /// <summary>
    /// The number of database servers for the Exadata infrastructure.
    /// </summary>
    [TerraformProperty("compute_count")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> ComputeCount { get; }

    /// <summary>
    /// The OCI model compute model used when you create or clone an instance: ECPU or
    /// OCPU. An ECPU is an abstracted measure of compute resources. ECPUs are based on
    /// the number of cores elastically allocated from a pool of compute and storage
    /// servers. An OCPU is a legacy physical measure of compute resources. OCPUs are
    /// based on the physical core of a processor with hyper-threading enabled.
    /// </summary>
    [TerraformProperty("compute_model")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ComputeModel { get; }

    /// <summary>
    /// The total number of CPU cores that are allocated to the Exadata infrastructure.
    /// </summary>
    [TerraformProperty("cpu_count")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> CpuCount { get; }

    /// <summary>
    /// The time when the Exadata infrastructure was created.
    /// </summary>
    [TerraformProperty("created_at")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreatedAt { get; }

    /// <summary>
    /// The email addresses of contacts to receive notification from Oracle about maintenance updates for the Exadata infrastructure.
    /// </summary>
    [TerraformProperty("customer_contacts_to_send_to_oci")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<object> CustomerContactsToSendToOci { get; }

    /// <summary>
    /// The size of the Exadata infrastructure&#39;s data disk group, in terabytes (TB).
    /// </summary>
    [TerraformProperty("data_storage_size_in_tbs")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> DataStorageSizeInTbs { get; }

    /// <summary>
    /// The database server model type of the Exadata infrastructure. For the list of valid model names, use the ListDbSystemShapes operation.
    /// </summary>
    [TerraformProperty("database_server_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DatabaseServerType { get; }

    /// <summary>
    /// The database server model type of the Exadata infrastructure. For the list of
    /// valid model names, use the ListDbSystemShapes operation.
    /// </summary>
    [TerraformProperty("db_node_storage_size_in_gbs")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> DbNodeStorageSizeInGbs { get; }

    /// <summary>
    /// The version of the Exadata infrastructure.
    /// </summary>
    [TerraformProperty("db_server_version")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DbServerVersion { get; }

    /// <summary>
    /// The display name of the Exadata infrastructure.
    /// </summary>
    [TerraformProperty("display_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DisplayName { get; }

    /// <summary>
    /// The Oracle Cloud Identifier (OCID) of the last maintenance run for the Exadata infrastructure.
    /// </summary>
    [TerraformProperty("last_maintenance_run_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LastMaintenanceRunId { get; }

    /// <summary>
    ///  The scheduling details for the maintenance window. Patching and system updates take place during the maintenance window 
    /// </summary>
    [TerraformProperty("maintenance_window")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> MaintenanceWindow { get; }

    /// <summary>
    /// The total number of CPU cores available on the Exadata infrastructure.
    /// </summary>
    [TerraformProperty("max_cpu_count")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> MaxCpuCount { get; }

    /// <summary>
    /// The total amount of data disk group storage, in terabytes (TB), that&#39;s available on the Exadata infrastructure.
    /// </summary>
    [TerraformProperty("max_data_storage_in_tbs")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> MaxDataStorageInTbs { get; }

    /// <summary>
    /// The total amount of local node storage, in gigabytes (GB), that&#39;s available on the Exadata infrastructure.
    /// </summary>
    [TerraformProperty("max_db_node_storage_size_in_gbs")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> MaxDbNodeStorageSizeInGbs { get; }

    /// <summary>
    /// The total amount of memory, in gigabytes (GB), that&#39;s available on the Exadata infrastructure.
    /// </summary>
    [TerraformProperty("max_memory_in_gbs")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> MaxMemoryInGbs { get; }

    /// <summary>
    /// The amount of memory, in gigabytes (GB), that&#39;s allocated on the Exadata infrastructure.
    /// </summary>
    [TerraformProperty("memory_size_in_gbs")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> MemorySizeInGbs { get; }

    /// <summary>
    /// The monthly software version of the database servers installed on the Exadata infrastructure.
    /// </summary>
    [TerraformProperty("monthly_db_server_version")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> MonthlyDbServerVersion { get; }

    /// <summary>
    /// The monthly software version of the storage servers installed on the Exadata infrastructure.
    /// </summary>
    [TerraformProperty("monthly_storage_server_version")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> MonthlyStorageServerVersion { get; }

    /// <summary>
    /// The OCID of the next maintenance run for the Exadata infrastructure.
    /// </summary>
    [TerraformProperty("next_maintenance_run_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> NextMaintenanceRunId { get; }

    /// <summary>
    /// The name of the OCI resource anchor for the Exadata infrastructure.
    /// </summary>
    [TerraformProperty("oci_resource_anchor_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> OciResourceAnchorName { get; }

    /// <summary>
    /// The HTTPS link to the Exadata infrastructure in OCI.
    /// </summary>
    [TerraformProperty("oci_url")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> OciUrl { get; }

    /// <summary>
    /// The OCID of the Exadata infrastructure in OCI.
    /// </summary>
    [TerraformProperty("ocid")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Ocid { get; }

    /// <summary>
    /// The amount of progress made on the current operation on the Exadata infrastructure expressed as a percentage.
    /// </summary>
    [TerraformProperty("percent_progress")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> PercentProgress { get; }

    /// <summary>
    /// The model name of the Exadata infrastructure.
    /// </summary>
    [TerraformProperty("shape")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Shape { get; }

    /// <summary>
    /// The status of the Exadata infrastructure.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Status { get; }

    /// <summary>
    /// Additional information about the status of the Exadata infrastructure.
    /// </summary>
    [TerraformProperty("status_reason")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> StatusReason { get; }

    /// <summary>
    /// he number of storage servers that are activated for the Exadata infrastructure.
    /// </summary>
    [TerraformProperty("storage_count")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> StorageCount { get; }

    /// <summary>
    /// The storage server model type of the Exadata infrastructure. For the list of valid model names, use the ListDbSystemShapes operation.
    /// </summary>
    [TerraformProperty("storage_server_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> StorageServerType { get; }

    /// <summary>
    /// The software version of the storage servers on the Exadata infrastructure.
    /// </summary>
    [TerraformProperty("storage_server_version")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> StorageServerVersion { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Tags { get; }

    /// <summary>
    /// The total amount of storage, in gigabytes (GB), on the the Exadata infrastructure.
    /// </summary>
    [TerraformProperty("total_storage_size_in_gbs")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> TotalStorageSizeInGbs { get; }

}
