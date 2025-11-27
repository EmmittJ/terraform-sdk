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
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
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
    /// The number of storage servers requested for the Exadata infrastructure.
    /// </summary>
    public TerraformValue<double> ActivatedStorageCount
    {
        get => new TerraformReference<double>(this, "activated_storage_count");
    }

    /// <summary>
    /// The number of storage servers requested for the Exadata infrastructure.
    /// </summary>
    public TerraformValue<double> AdditionalStorageCount
    {
        get => new TerraformReference<double>(this, "additional_storage_count");
    }

    /// <summary>
    /// The Amazon Resource Name (ARN) for the Exadata infrastructure.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// he name of the Availability Zone (AZ) where the Exadata infrastructure is located.
    /// </summary>
    public TerraformValue<string> AvailabilityZone
    {
        get => new TerraformReference<string>(this, "availability_zone");
    }

    /// <summary>
    /// The AZ ID of the AZ where the Exadata infrastructure is located.
    /// </summary>
    public TerraformValue<string> AvailabilityZoneId
    {
        get => new TerraformReference<string>(this, "availability_zone_id");
    }

    /// <summary>
    /// The amount of available storage, in gigabytes (GB), for the Exadata infrastructure.
    /// </summary>
    public TerraformValue<double> AvailableStorageSizeInGbs
    {
        get => new TerraformReference<double>(this, "available_storage_size_in_gbs");
    }

    /// <summary>
    /// The number of database servers for the Exadata infrastructure.
    /// </summary>
    public TerraformValue<double> ComputeCount
    {
        get => new TerraformReference<double>(this, "compute_count");
    }

    /// <summary>
    /// The OCI model compute model used when you create or clone an instance: ECPU or
    /// OCPU. An ECPU is an abstracted measure of compute resources. ECPUs are based on
    /// the number of cores elastically allocated from a pool of compute and storage
    /// servers. An OCPU is a legacy physical measure of compute resources. OCPUs are
    /// based on the physical core of a processor with hyper-threading enabled.
    /// </summary>
    public TerraformValue<string> ComputeModel
    {
        get => new TerraformReference<string>(this, "compute_model");
    }

    /// <summary>
    /// The total number of CPU cores that are allocated to the Exadata infrastructure.
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
    /// The email addresses of contacts to receive notification from Oracle about maintenance updates for the Exadata infrastructure.
    /// </summary>
    public TerraformSet<TerraformMap<object>> CustomerContactsToSendToOci
    {
        get => TerraformSet<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformMap<object>>>(this, "customer_contacts_to_send_to_oci").ResolveNodes(ctx));
    }

    /// <summary>
    /// The size of the Exadata infrastructure&#39;s data disk group, in terabytes (TB).
    /// </summary>
    public TerraformValue<double> DataStorageSizeInTbs
    {
        get => new TerraformReference<double>(this, "data_storage_size_in_tbs");
    }

    /// <summary>
    /// The database server model type of the Exadata infrastructure. For the list of valid model names, use the ListDbSystemShapes operation.
    /// </summary>
    public TerraformValue<string> DatabaseServerType
    {
        get => new TerraformReference<string>(this, "database_server_type");
    }

    /// <summary>
    /// The database server model type of the Exadata infrastructure. For the list of
    /// valid model names, use the ListDbSystemShapes operation.
    /// </summary>
    public TerraformValue<double> DbNodeStorageSizeInGbs
    {
        get => new TerraformReference<double>(this, "db_node_storage_size_in_gbs");
    }

    /// <summary>
    /// The version of the Exadata infrastructure.
    /// </summary>
    public TerraformValue<string> DbServerVersion
    {
        get => new TerraformReference<string>(this, "db_server_version");
    }

    /// <summary>
    /// The display name of the Exadata infrastructure.
    /// </summary>
    public TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
    }

    /// <summary>
    /// The Oracle Cloud Identifier (OCID) of the last maintenance run for the Exadata infrastructure.
    /// </summary>
    public TerraformValue<string> LastMaintenanceRunId
    {
        get => new TerraformReference<string>(this, "last_maintenance_run_id");
    }

    /// <summary>
    ///  The scheduling details for the maintenance window. Patching and system updates take place during the maintenance window 
    /// </summary>
    public TerraformList<TerraformMap<object>> MaintenanceWindow
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "maintenance_window").ResolveNodes(ctx));
    }

    /// <summary>
    /// The total number of CPU cores available on the Exadata infrastructure.
    /// </summary>
    public TerraformValue<double> MaxCpuCount
    {
        get => new TerraformReference<double>(this, "max_cpu_count");
    }

    /// <summary>
    /// The total amount of data disk group storage, in terabytes (TB), that&#39;s available on the Exadata infrastructure.
    /// </summary>
    public TerraformValue<double> MaxDataStorageInTbs
    {
        get => new TerraformReference<double>(this, "max_data_storage_in_tbs");
    }

    /// <summary>
    /// The total amount of local node storage, in gigabytes (GB), that&#39;s available on the Exadata infrastructure.
    /// </summary>
    public TerraformValue<double> MaxDbNodeStorageSizeInGbs
    {
        get => new TerraformReference<double>(this, "max_db_node_storage_size_in_gbs");
    }

    /// <summary>
    /// The total amount of memory, in gigabytes (GB), that&#39;s available on the Exadata infrastructure.
    /// </summary>
    public TerraformValue<double> MaxMemoryInGbs
    {
        get => new TerraformReference<double>(this, "max_memory_in_gbs");
    }

    /// <summary>
    /// The amount of memory, in gigabytes (GB), that&#39;s allocated on the Exadata infrastructure.
    /// </summary>
    public TerraformValue<double> MemorySizeInGbs
    {
        get => new TerraformReference<double>(this, "memory_size_in_gbs");
    }

    /// <summary>
    /// The monthly software version of the database servers installed on the Exadata infrastructure.
    /// </summary>
    public TerraformValue<string> MonthlyDbServerVersion
    {
        get => new TerraformReference<string>(this, "monthly_db_server_version");
    }

    /// <summary>
    /// The monthly software version of the storage servers installed on the Exadata infrastructure.
    /// </summary>
    public TerraformValue<string> MonthlyStorageServerVersion
    {
        get => new TerraformReference<string>(this, "monthly_storage_server_version");
    }

    /// <summary>
    /// The OCID of the next maintenance run for the Exadata infrastructure.
    /// </summary>
    public TerraformValue<string> NextMaintenanceRunId
    {
        get => new TerraformReference<string>(this, "next_maintenance_run_id");
    }

    /// <summary>
    /// The name of the OCI resource anchor for the Exadata infrastructure.
    /// </summary>
    public TerraformValue<string> OciResourceAnchorName
    {
        get => new TerraformReference<string>(this, "oci_resource_anchor_name");
    }

    /// <summary>
    /// The HTTPS link to the Exadata infrastructure in OCI.
    /// </summary>
    public TerraformValue<string> OciUrl
    {
        get => new TerraformReference<string>(this, "oci_url");
    }

    /// <summary>
    /// The OCID of the Exadata infrastructure in OCI.
    /// </summary>
    public TerraformValue<string> Ocid
    {
        get => new TerraformReference<string>(this, "ocid");
    }

    /// <summary>
    /// The amount of progress made on the current operation on the Exadata infrastructure expressed as a percentage.
    /// </summary>
    public TerraformValue<double> PercentProgress
    {
        get => new TerraformReference<double>(this, "percent_progress");
    }

    /// <summary>
    /// The model name of the Exadata infrastructure.
    /// </summary>
    public TerraformValue<string> Shape
    {
        get => new TerraformReference<string>(this, "shape");
    }

    /// <summary>
    /// The status of the Exadata infrastructure.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

    /// <summary>
    /// Additional information about the status of the Exadata infrastructure.
    /// </summary>
    public TerraformValue<string> StatusReason
    {
        get => new TerraformReference<string>(this, "status_reason");
    }

    /// <summary>
    /// he number of storage servers that are activated for the Exadata infrastructure.
    /// </summary>
    public TerraformValue<double> StorageCount
    {
        get => new TerraformReference<double>(this, "storage_count");
    }

    /// <summary>
    /// The storage server model type of the Exadata infrastructure. For the list of valid model names, use the ListDbSystemShapes operation.
    /// </summary>
    public TerraformValue<string> StorageServerType
    {
        get => new TerraformReference<string>(this, "storage_server_type");
    }

    /// <summary>
    /// The software version of the storage servers on the Exadata infrastructure.
    /// </summary>
    public TerraformValue<string> StorageServerVersion
    {
        get => new TerraformReference<string>(this, "storage_server_version");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The total amount of storage, in gigabytes (GB), on the the Exadata infrastructure.
    /// </summary>
    public TerraformValue<double> TotalStorageSizeInGbs
    {
        get => new TerraformReference<double>(this, "total_storage_size_in_gbs");
    }

}
