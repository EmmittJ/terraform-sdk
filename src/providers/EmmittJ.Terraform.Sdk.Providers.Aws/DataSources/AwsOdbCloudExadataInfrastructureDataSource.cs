using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_odb_cloud_exadata_infrastructure Terraform data source.
/// Retrieves information about a aws_odb_cloud_exadata_infrastructure.
/// </summary>
public partial class AwsOdbCloudExadataInfrastructureDataSource(string name) : TerraformDataSource("aws_odb_cloud_exadata_infrastructure", name)
{
    /// <summary>
    /// The unique identifier of the Exadata infrastructure.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => GetRequiredArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The number of storage servers requested for the Exadata infrastructure.
    /// </summary>
    public TerraformValue<double> ActivatedStorageCount
        => AsReference("activated_storage_count");

    /// <summary>
    /// The number of storage servers requested for the Exadata infrastructure.
    /// </summary>
    public TerraformValue<double> AdditionalStorageCount
        => AsReference("additional_storage_count");

    /// <summary>
    /// The Amazon Resource Name (ARN) for the Exadata infrastructure.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// he name of the Availability Zone (AZ) where the Exadata infrastructure is located.
    /// </summary>
    public TerraformValue<string> AvailabilityZone
        => AsReference("availability_zone");

    /// <summary>
    /// The AZ ID of the AZ where the Exadata infrastructure is located.
    /// </summary>
    public TerraformValue<string> AvailabilityZoneId
        => AsReference("availability_zone_id");

    /// <summary>
    /// The amount of available storage, in gigabytes (GB), for the Exadata infrastructure.
    /// </summary>
    public TerraformValue<double> AvailableStorageSizeInGbs
        => AsReference("available_storage_size_in_gbs");

    /// <summary>
    /// The number of database servers for the Exadata infrastructure.
    /// </summary>
    public TerraformValue<double> ComputeCount
        => AsReference("compute_count");

    /// <summary>
    /// The OCI model compute model used when you create or clone an instance: ECPU or
    /// OCPU. An ECPU is an abstracted measure of compute resources. ECPUs are based on
    /// the number of cores elastically allocated from a pool of compute and storage
    /// servers. An OCPU is a legacy physical measure of compute resources. OCPUs are
    /// based on the physical core of a processor with hyper-threading enabled.
    /// </summary>
    public TerraformValue<string> ComputeModel
        => AsReference("compute_model");

    /// <summary>
    /// The total number of CPU cores that are allocated to the Exadata infrastructure.
    /// </summary>
    public TerraformValue<double> CpuCount
        => AsReference("cpu_count");

    /// <summary>
    /// The time when the Exadata infrastructure was created.
    /// </summary>
    public TerraformValue<string> CreatedAt
        => AsReference("created_at");

    /// <summary>
    /// The email addresses of contacts to receive notification from Oracle about maintenance updates for the Exadata infrastructure.
    /// </summary>
    public TerraformSet<TerraformMap<object>> CustomerContactsToSendToOci
        => AsReference("customer_contacts_to_send_to_oci");

    /// <summary>
    /// The size of the Exadata infrastructure&#39;s data disk group, in terabytes (TB).
    /// </summary>
    public TerraformValue<double> DataStorageSizeInTbs
        => AsReference("data_storage_size_in_tbs");

    /// <summary>
    /// The database server model type of the Exadata infrastructure. For the list of valid model names, use the ListDbSystemShapes operation.
    /// </summary>
    public TerraformValue<string> DatabaseServerType
        => AsReference("database_server_type");

    /// <summary>
    /// The database server model type of the Exadata infrastructure. For the list of
    /// valid model names, use the ListDbSystemShapes operation.
    /// </summary>
    public TerraformValue<double> DbNodeStorageSizeInGbs
        => AsReference("db_node_storage_size_in_gbs");

    /// <summary>
    /// The version of the Exadata infrastructure.
    /// </summary>
    public TerraformValue<string> DbServerVersion
        => AsReference("db_server_version");

    /// <summary>
    /// The display name of the Exadata infrastructure.
    /// </summary>
    public TerraformValue<string> DisplayName
        => AsReference("display_name");

    /// <summary>
    /// The Oracle Cloud Identifier (OCID) of the last maintenance run for the Exadata infrastructure.
    /// </summary>
    public TerraformValue<string> LastMaintenanceRunId
        => AsReference("last_maintenance_run_id");

    /// <summary>
    ///  The scheduling details for the maintenance window. Patching and system updates take place during the maintenance window 
    /// </summary>
    public TerraformList<TerraformMap<object>> MaintenanceWindow
        => AsReference("maintenance_window");

    /// <summary>
    /// The total number of CPU cores available on the Exadata infrastructure.
    /// </summary>
    public TerraformValue<double> MaxCpuCount
        => AsReference("max_cpu_count");

    /// <summary>
    /// The total amount of data disk group storage, in terabytes (TB), that&#39;s available on the Exadata infrastructure.
    /// </summary>
    public TerraformValue<double> MaxDataStorageInTbs
        => AsReference("max_data_storage_in_tbs");

    /// <summary>
    /// The total amount of local node storage, in gigabytes (GB), that&#39;s available on the Exadata infrastructure.
    /// </summary>
    public TerraformValue<double> MaxDbNodeStorageSizeInGbs
        => AsReference("max_db_node_storage_size_in_gbs");

    /// <summary>
    /// The total amount of memory, in gigabytes (GB), that&#39;s available on the Exadata infrastructure.
    /// </summary>
    public TerraformValue<double> MaxMemoryInGbs
        => AsReference("max_memory_in_gbs");

    /// <summary>
    /// The amount of memory, in gigabytes (GB), that&#39;s allocated on the Exadata infrastructure.
    /// </summary>
    public TerraformValue<double> MemorySizeInGbs
        => AsReference("memory_size_in_gbs");

    /// <summary>
    /// The monthly software version of the database servers installed on the Exadata infrastructure.
    /// </summary>
    public TerraformValue<string> MonthlyDbServerVersion
        => AsReference("monthly_db_server_version");

    /// <summary>
    /// The monthly software version of the storage servers installed on the Exadata infrastructure.
    /// </summary>
    public TerraformValue<string> MonthlyStorageServerVersion
        => AsReference("monthly_storage_server_version");

    /// <summary>
    /// The OCID of the next maintenance run for the Exadata infrastructure.
    /// </summary>
    public TerraformValue<string> NextMaintenanceRunId
        => AsReference("next_maintenance_run_id");

    /// <summary>
    /// The name of the OCI resource anchor for the Exadata infrastructure.
    /// </summary>
    public TerraformValue<string> OciResourceAnchorName
        => AsReference("oci_resource_anchor_name");

    /// <summary>
    /// The HTTPS link to the Exadata infrastructure in OCI.
    /// </summary>
    public TerraformValue<string> OciUrl
        => AsReference("oci_url");

    /// <summary>
    /// The OCID of the Exadata infrastructure in OCI.
    /// </summary>
    public TerraformValue<string> Ocid
        => AsReference("ocid");

    /// <summary>
    /// The amount of progress made on the current operation on the Exadata infrastructure expressed as a percentage.
    /// </summary>
    public TerraformValue<double> PercentProgress
        => AsReference("percent_progress");

    /// <summary>
    /// The model name of the Exadata infrastructure.
    /// </summary>
    public TerraformValue<string> Shape
        => AsReference("shape");

    /// <summary>
    /// The status of the Exadata infrastructure.
    /// </summary>
    public TerraformValue<string> Status
        => AsReference("status");

    /// <summary>
    /// Additional information about the status of the Exadata infrastructure.
    /// </summary>
    public TerraformValue<string> StatusReason
        => AsReference("status_reason");

    /// <summary>
    /// he number of storage servers that are activated for the Exadata infrastructure.
    /// </summary>
    public TerraformValue<double> StorageCount
        => AsReference("storage_count");

    /// <summary>
    /// The storage server model type of the Exadata infrastructure. For the list of valid model names, use the ListDbSystemShapes operation.
    /// </summary>
    public TerraformValue<string> StorageServerType
        => AsReference("storage_server_type");

    /// <summary>
    /// The software version of the storage servers on the Exadata infrastructure.
    /// </summary>
    public TerraformValue<string> StorageServerVersion
        => AsReference("storage_server_version");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => AsReference("tags");

    /// <summary>
    /// The total amount of storage, in gigabytes (GB), on the the Exadata infrastructure.
    /// </summary>
    public TerraformValue<double> TotalStorageSizeInGbs
        => AsReference("total_storage_size_in_gbs");

}
