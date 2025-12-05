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
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The number of storage servers requested for the Exadata infrastructure.
    /// </summary>
    public TerraformValue<double> ActivatedStorageCount
        => CreateReference("activated_storage_count");

    /// <summary>
    /// The number of storage servers requested for the Exadata infrastructure.
    /// </summary>
    public TerraformValue<double> AdditionalStorageCount
        => CreateReference("additional_storage_count");

    /// <summary>
    /// The Amazon Resource Name (ARN) for the Exadata infrastructure.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// he name of the Availability Zone (AZ) where the Exadata infrastructure is located.
    /// </summary>
    public TerraformValue<string> AvailabilityZone
        => CreateReference("availability_zone");

    /// <summary>
    /// The AZ ID of the AZ where the Exadata infrastructure is located.
    /// </summary>
    public TerraformValue<string> AvailabilityZoneId
        => CreateReference("availability_zone_id");

    /// <summary>
    /// The amount of available storage, in gigabytes (GB), for the Exadata infrastructure.
    /// </summary>
    public TerraformValue<double> AvailableStorageSizeInGbs
        => CreateReference("available_storage_size_in_gbs");

    /// <summary>
    /// The number of database servers for the Exadata infrastructure.
    /// </summary>
    public TerraformValue<double> ComputeCount
        => CreateReference("compute_count");

    /// <summary>
    /// The OCI model compute model used when you create or clone an instance: ECPU or
    /// OCPU. An ECPU is an abstracted measure of compute resources. ECPUs are based on
    /// the number of cores elastically allocated from a pool of compute and storage
    /// servers. An OCPU is a legacy physical measure of compute resources. OCPUs are
    /// based on the physical core of a processor with hyper-threading enabled.
    /// </summary>
    public TerraformValue<string> ComputeModel
        => CreateReference("compute_model");

    /// <summary>
    /// The total number of CPU cores that are allocated to the Exadata infrastructure.
    /// </summary>
    public TerraformValue<double> CpuCount
        => CreateReference("cpu_count");

    /// <summary>
    /// The time when the Exadata infrastructure was created.
    /// </summary>
    public TerraformValue<string> CreatedAt
        => CreateReference("created_at");

    /// <summary>
    /// The email addresses of contacts to receive notification from Oracle about maintenance updates for the Exadata infrastructure.
    /// </summary>
    public TerraformSet<TerraformMap<object>> CustomerContactsToSendToOci
        => CreateReference("customer_contacts_to_send_to_oci");

    /// <summary>
    /// The size of the Exadata infrastructure&#39;s data disk group, in terabytes (TB).
    /// </summary>
    public TerraformValue<double> DataStorageSizeInTbs
        => CreateReference("data_storage_size_in_tbs");

    /// <summary>
    /// The database server model type of the Exadata infrastructure. For the list of valid model names, use the ListDbSystemShapes operation.
    /// </summary>
    public TerraformValue<string> DatabaseServerType
        => CreateReference("database_server_type");

    /// <summary>
    /// The database server model type of the Exadata infrastructure. For the list of
    /// valid model names, use the ListDbSystemShapes operation.
    /// </summary>
    public TerraformValue<double> DbNodeStorageSizeInGbs
        => CreateReference("db_node_storage_size_in_gbs");

    /// <summary>
    /// The version of the Exadata infrastructure.
    /// </summary>
    public TerraformValue<string> DbServerVersion
        => CreateReference("db_server_version");

    /// <summary>
    /// The display name of the Exadata infrastructure.
    /// </summary>
    public TerraformValue<string> DisplayName
        => CreateReference("display_name");

    /// <summary>
    /// The Oracle Cloud Identifier (OCID) of the last maintenance run for the Exadata infrastructure.
    /// </summary>
    public TerraformValue<string> LastMaintenanceRunId
        => CreateReference("last_maintenance_run_id");

    /// <summary>
    ///  The scheduling details for the maintenance window. Patching and system updates take place during the maintenance window 
    /// </summary>
    public TerraformList<TerraformMap<object>> MaintenanceWindow
        => CreateReference("maintenance_window");

    /// <summary>
    /// The total number of CPU cores available on the Exadata infrastructure.
    /// </summary>
    public TerraformValue<double> MaxCpuCount
        => CreateReference("max_cpu_count");

    /// <summary>
    /// The total amount of data disk group storage, in terabytes (TB), that&#39;s available on the Exadata infrastructure.
    /// </summary>
    public TerraformValue<double> MaxDataStorageInTbs
        => CreateReference("max_data_storage_in_tbs");

    /// <summary>
    /// The total amount of local node storage, in gigabytes (GB), that&#39;s available on the Exadata infrastructure.
    /// </summary>
    public TerraformValue<double> MaxDbNodeStorageSizeInGbs
        => CreateReference("max_db_node_storage_size_in_gbs");

    /// <summary>
    /// The total amount of memory, in gigabytes (GB), that&#39;s available on the Exadata infrastructure.
    /// </summary>
    public TerraformValue<double> MaxMemoryInGbs
        => CreateReference("max_memory_in_gbs");

    /// <summary>
    /// The amount of memory, in gigabytes (GB), that&#39;s allocated on the Exadata infrastructure.
    /// </summary>
    public TerraformValue<double> MemorySizeInGbs
        => CreateReference("memory_size_in_gbs");

    /// <summary>
    /// The monthly software version of the database servers installed on the Exadata infrastructure.
    /// </summary>
    public TerraformValue<string> MonthlyDbServerVersion
        => CreateReference("monthly_db_server_version");

    /// <summary>
    /// The monthly software version of the storage servers installed on the Exadata infrastructure.
    /// </summary>
    public TerraformValue<string> MonthlyStorageServerVersion
        => CreateReference("monthly_storage_server_version");

    /// <summary>
    /// The OCID of the next maintenance run for the Exadata infrastructure.
    /// </summary>
    public TerraformValue<string> NextMaintenanceRunId
        => CreateReference("next_maintenance_run_id");

    /// <summary>
    /// The name of the OCI resource anchor for the Exadata infrastructure.
    /// </summary>
    public TerraformValue<string> OciResourceAnchorName
        => CreateReference("oci_resource_anchor_name");

    /// <summary>
    /// The HTTPS link to the Exadata infrastructure in OCI.
    /// </summary>
    public TerraformValue<string> OciUrl
        => CreateReference("oci_url");

    /// <summary>
    /// The OCID of the Exadata infrastructure in OCI.
    /// </summary>
    public TerraformValue<string> Ocid
        => CreateReference("ocid");

    /// <summary>
    /// The amount of progress made on the current operation on the Exadata infrastructure expressed as a percentage.
    /// </summary>
    public TerraformValue<double> PercentProgress
        => CreateReference("percent_progress");

    /// <summary>
    /// The model name of the Exadata infrastructure.
    /// </summary>
    public TerraformValue<string> Shape
        => CreateReference("shape");

    /// <summary>
    /// The status of the Exadata infrastructure.
    /// </summary>
    public TerraformValue<string> Status
        => CreateReference("status");

    /// <summary>
    /// Additional information about the status of the Exadata infrastructure.
    /// </summary>
    public TerraformValue<string> StatusReason
        => CreateReference("status_reason");

    /// <summary>
    /// he number of storage servers that are activated for the Exadata infrastructure.
    /// </summary>
    public TerraformValue<double> StorageCount
        => CreateReference("storage_count");

    /// <summary>
    /// The storage server model type of the Exadata infrastructure. For the list of valid model names, use the ListDbSystemShapes operation.
    /// </summary>
    public TerraformValue<string> StorageServerType
        => CreateReference("storage_server_type");

    /// <summary>
    /// The software version of the storage servers on the Exadata infrastructure.
    /// </summary>
    public TerraformValue<string> StorageServerVersion
        => CreateReference("storage_server_version");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => CreateReference("tags");

    /// <summary>
    /// The total amount of storage, in gigabytes (GB), on the the Exadata infrastructure.
    /// </summary>
    public TerraformValue<double> TotalStorageSizeInGbs
        => CreateReference("total_storage_size_in_gbs");

}
