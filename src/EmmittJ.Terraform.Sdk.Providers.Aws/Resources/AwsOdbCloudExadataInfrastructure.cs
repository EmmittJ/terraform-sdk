using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

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
        this.DeclareOutput("activated_storage_count");
        this.DeclareOutput("additional_storage_count");
        this.DeclareOutput("arn");
        this.DeclareOutput("available_storage_size_in_gbs");
        this.DeclareOutput("compute_model");
        this.DeclareOutput("cpu_count");
        this.DeclareOutput("created_at");
        this.DeclareOutput("data_storage_size_in_tbs");
        this.DeclareOutput("db_node_storage_size_in_gbs");
        this.DeclareOutput("db_server_version");
        this.DeclareOutput("id");
        this.DeclareOutput("last_maintenance_run_id");
        this.DeclareOutput("max_cpu_count");
        this.DeclareOutput("max_data_storage_in_tbs");
        this.DeclareOutput("max_db_node_storage_size_in_gbs");
        this.DeclareOutput("max_memory_in_gbs");
        this.DeclareOutput("memory_size_in_gbs");
        this.DeclareOutput("monthly_db_server_version");
        this.DeclareOutput("monthly_storage_server_version");
        this.DeclareOutput("next_maintenance_run_id");
        this.DeclareOutput("oci_resource_anchor_name");
        this.DeclareOutput("oci_url");
        this.DeclareOutput("ocid");
        this.DeclareOutput("percent_progress");
        this.DeclareOutput("status");
        this.DeclareOutput("status_reason");
        this.DeclareOutput("storage_server_version");
        this.DeclareOutput("tags_all");
        this.DeclareOutput("total_storage_size_in_gbs");
    }

    /// <summary>
    /// The name of the Availability Zone (AZ) where the Exadata infrastructure is located. Changing this will force terraform to create new resource
    /// </summary>
    public TerraformProperty<string>? AvailabilityZone
    {
        get => GetProperty<TerraformProperty<string>>("availability_zone");
        set => this.WithProperty("availability_zone", value);
    }

    /// <summary>
    ///  The AZ ID of the AZ where the Exadata infrastructure is located. Changing this will force terraform to create new resource
    /// </summary>
    public TerraformProperty<string>? AvailabilityZoneId
    {
        get => GetProperty<TerraformProperty<string>>("availability_zone_id");
        set => this.WithProperty("availability_zone_id", value);
    }

    /// <summary>
    ///  The number of compute instances that the Exadata infrastructure is located
    /// </summary>
    public TerraformProperty<double>? ComputeCount
    {
        get => GetProperty<TerraformProperty<double>>("compute_count");
        set => this.WithProperty("compute_count", value);
    }

    /// <summary>
    /// The email addresses of contacts to receive notification from Oracle about maintenance updates for the Exadata infrastructure. Changing this will force terraform to create new resource
    /// </summary>
    public TerraformProperty<HashSet<object>>? CustomerContactsToSendToOci
    {
        get => GetProperty<TerraformProperty<HashSet<object>>>("customer_contacts_to_send_to_oci");
        set => this.WithProperty("customer_contacts_to_send_to_oci", value);
    }

    /// <summary>
    /// The database server model type of the Exadata infrastructure. For the list of valid model names, use the ListDbSystemShapes operation
    /// </summary>
    public TerraformProperty<string>? DatabaseServerType
    {
        get => GetProperty<TerraformProperty<string>>("database_server_type");
        set => this.WithProperty("database_server_type", value);
    }

    /// <summary>
    /// The user-friendly name for the Exadata infrastructure. Changing this will force terraform to create a new resource
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The model name of the Exadata infrastructure. Changing this will force terraform to create new resource
    /// </summary>
    public TerraformProperty<string>? Shape
    {
        get => GetProperty<TerraformProperty<string>>("shape");
        set => this.WithProperty("shape", value);
    }

    /// <summary>
    /// TThe number of storage servers that are activated for the Exadata infrastructure
    /// </summary>
    public TerraformProperty<double>? StorageCount
    {
        get => GetProperty<TerraformProperty<double>>("storage_count");
        set => this.WithProperty("storage_count", value);
    }

    /// <summary>
    /// The storage server model type of the Exadata infrastructure. For the list of valid model names, use the ListDbSystemShapes operation
    /// </summary>
    public TerraformProperty<string>? StorageServerType
    {
        get => GetProperty<TerraformProperty<string>>("storage_server_type");
        set => this.WithProperty("storage_server_type", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
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
