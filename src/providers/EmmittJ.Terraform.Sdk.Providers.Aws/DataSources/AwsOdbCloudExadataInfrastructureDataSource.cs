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
    public required TerraformProperty<TerraformProperty<string>> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The number of storage servers requested for the Exadata infrastructure.
    /// </summary>
    [TerraformPropertyName("activated_storage_count")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> ActivatedStorageCount => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "activated_storage_count");

    /// <summary>
    /// The number of storage servers requested for the Exadata infrastructure.
    /// </summary>
    [TerraformPropertyName("additional_storage_count")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> AdditionalStorageCount => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "additional_storage_count");

    /// <summary>
    /// The Amazon Resource Name (ARN) for the Exadata infrastructure.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// he name of the Availability Zone (AZ) where the Exadata infrastructure is located.
    /// </summary>
    [TerraformPropertyName("availability_zone")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AvailabilityZone => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "availability_zone");

    /// <summary>
    /// The AZ ID of the AZ where the Exadata infrastructure is located.
    /// </summary>
    [TerraformPropertyName("availability_zone_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AvailabilityZoneId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "availability_zone_id");

    /// <summary>
    /// The amount of available storage, in gigabytes (GB), for the Exadata infrastructure.
    /// </summary>
    [TerraformPropertyName("available_storage_size_in_gbs")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> AvailableStorageSizeInGbs => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "available_storage_size_in_gbs");

    /// <summary>
    /// The number of database servers for the Exadata infrastructure.
    /// </summary>
    [TerraformPropertyName("compute_count")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> ComputeCount => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "compute_count");

    /// <summary>
    /// The OCI model compute model used when you create or clone an instance: ECPU or
    /// OCPU. An ECPU is an abstracted measure of compute resources. ECPUs are based on
    /// the number of cores elastically allocated from a pool of compute and storage
    /// servers. An OCPU is a legacy physical measure of compute resources. OCPUs are
    /// based on the physical core of a processor with hyper-threading enabled.
    /// </summary>
    [TerraformPropertyName("compute_model")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ComputeModel => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "compute_model");

    /// <summary>
    /// The total number of CPU cores that are allocated to the Exadata infrastructure.
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
    /// The email addresses of contacts to receive notification from Oracle about maintenance updates for the Exadata infrastructure.
    /// </summary>
    [TerraformPropertyName("customer_contacts_to_send_to_oci")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<object>>> CustomerContactsToSendToOci => new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>(ResourceAddress, "customer_contacts_to_send_to_oci");

    /// <summary>
    /// The size of the Exadata infrastructure&#39;s data disk group, in terabytes (TB).
    /// </summary>
    [TerraformPropertyName("data_storage_size_in_tbs")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> DataStorageSizeInTbs => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "data_storage_size_in_tbs");

    /// <summary>
    /// The database server model type of the Exadata infrastructure. For the list of valid model names, use the ListDbSystemShapes operation.
    /// </summary>
    [TerraformPropertyName("database_server_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DatabaseServerType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "database_server_type");

    /// <summary>
    /// The database server model type of the Exadata infrastructure. For the list of
    /// valid model names, use the ListDbSystemShapes operation.
    /// </summary>
    [TerraformPropertyName("db_node_storage_size_in_gbs")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> DbNodeStorageSizeInGbs => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "db_node_storage_size_in_gbs");

    /// <summary>
    /// The version of the Exadata infrastructure.
    /// </summary>
    [TerraformPropertyName("db_server_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DbServerVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "db_server_version");

    /// <summary>
    /// The display name of the Exadata infrastructure.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DisplayName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "display_name");

    /// <summary>
    /// The Oracle Cloud Identifier (OCID) of the last maintenance run for the Exadata infrastructure.
    /// </summary>
    [TerraformPropertyName("last_maintenance_run_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LastMaintenanceRunId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "last_maintenance_run_id");

    /// <summary>
    ///  The scheduling details for the maintenance window. Patching and system updates take place during the maintenance window 
    /// </summary>
    [TerraformPropertyName("maintenance_window")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> MaintenanceWindow => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "maintenance_window");

    /// <summary>
    /// The total number of CPU cores available on the Exadata infrastructure.
    /// </summary>
    [TerraformPropertyName("max_cpu_count")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> MaxCpuCount => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "max_cpu_count");

    /// <summary>
    /// The total amount of data disk group storage, in terabytes (TB), that&#39;s available on the Exadata infrastructure.
    /// </summary>
    [TerraformPropertyName("max_data_storage_in_tbs")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> MaxDataStorageInTbs => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "max_data_storage_in_tbs");

    /// <summary>
    /// The total amount of local node storage, in gigabytes (GB), that&#39;s available on the Exadata infrastructure.
    /// </summary>
    [TerraformPropertyName("max_db_node_storage_size_in_gbs")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> MaxDbNodeStorageSizeInGbs => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "max_db_node_storage_size_in_gbs");

    /// <summary>
    /// The total amount of memory, in gigabytes (GB), that&#39;s available on the Exadata infrastructure.
    /// </summary>
    [TerraformPropertyName("max_memory_in_gbs")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> MaxMemoryInGbs => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "max_memory_in_gbs");

    /// <summary>
    /// The amount of memory, in gigabytes (GB), that&#39;s allocated on the Exadata infrastructure.
    /// </summary>
    [TerraformPropertyName("memory_size_in_gbs")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> MemorySizeInGbs => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "memory_size_in_gbs");

    /// <summary>
    /// The monthly software version of the database servers installed on the Exadata infrastructure.
    /// </summary>
    [TerraformPropertyName("monthly_db_server_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> MonthlyDbServerVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "monthly_db_server_version");

    /// <summary>
    /// The monthly software version of the storage servers installed on the Exadata infrastructure.
    /// </summary>
    [TerraformPropertyName("monthly_storage_server_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> MonthlyStorageServerVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "monthly_storage_server_version");

    /// <summary>
    /// The OCID of the next maintenance run for the Exadata infrastructure.
    /// </summary>
    [TerraformPropertyName("next_maintenance_run_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NextMaintenanceRunId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "next_maintenance_run_id");

    /// <summary>
    /// The name of the OCI resource anchor for the Exadata infrastructure.
    /// </summary>
    [TerraformPropertyName("oci_resource_anchor_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OciResourceAnchorName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "oci_resource_anchor_name");

    /// <summary>
    /// The HTTPS link to the Exadata infrastructure in OCI.
    /// </summary>
    [TerraformPropertyName("oci_url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OciUrl => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "oci_url");

    /// <summary>
    /// The OCID of the Exadata infrastructure in OCI.
    /// </summary>
    [TerraformPropertyName("ocid")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Ocid => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ocid");

    /// <summary>
    /// The amount of progress made on the current operation on the Exadata infrastructure expressed as a percentage.
    /// </summary>
    [TerraformPropertyName("percent_progress")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> PercentProgress => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "percent_progress");

    /// <summary>
    /// The model name of the Exadata infrastructure.
    /// </summary>
    [TerraformPropertyName("shape")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Shape => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "shape");

    /// <summary>
    /// The status of the Exadata infrastructure.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Status => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status");

    /// <summary>
    /// Additional information about the status of the Exadata infrastructure.
    /// </summary>
    [TerraformPropertyName("status_reason")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StatusReason => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status_reason");

    /// <summary>
    /// he number of storage servers that are activated for the Exadata infrastructure.
    /// </summary>
    [TerraformPropertyName("storage_count")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> StorageCount => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "storage_count");

    /// <summary>
    /// The storage server model type of the Exadata infrastructure. For the list of valid model names, use the ListDbSystemShapes operation.
    /// </summary>
    [TerraformPropertyName("storage_server_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StorageServerType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "storage_server_type");

    /// <summary>
    /// The software version of the storage servers on the Exadata infrastructure.
    /// </summary>
    [TerraformPropertyName("storage_server_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StorageServerVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "storage_server_version");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The total amount of storage, in gigabytes (GB), on the the Exadata infrastructure.
    /// </summary>
    [TerraformPropertyName("total_storage_size_in_gbs")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> TotalStorageSizeInGbs => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "total_storage_size_in_gbs");

}
