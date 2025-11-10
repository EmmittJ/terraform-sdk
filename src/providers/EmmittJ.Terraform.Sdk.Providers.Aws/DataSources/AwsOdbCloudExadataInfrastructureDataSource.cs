using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_odb_cloud_exadata_infrastructure.
/// </summary>
public class AwsOdbCloudExadataInfrastructureDataSource : TerraformDataSource
{
    public AwsOdbCloudExadataInfrastructureDataSource(string name) : base("aws_odb_cloud_exadata_infrastructure", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("activated_storage_count");
        this.WithOutput("additional_storage_count");
        this.WithOutput("arn");
        this.WithOutput("availability_zone");
        this.WithOutput("availability_zone_id");
        this.WithOutput("available_storage_size_in_gbs");
        this.WithOutput("compute_count");
        this.WithOutput("compute_model");
        this.WithOutput("cpu_count");
        this.WithOutput("created_at");
        this.WithOutput("customer_contacts_to_send_to_oci");
        this.WithOutput("data_storage_size_in_tbs");
        this.WithOutput("database_server_type");
        this.WithOutput("db_node_storage_size_in_gbs");
        this.WithOutput("db_server_version");
        this.WithOutput("display_name");
        this.WithOutput("last_maintenance_run_id");
        this.WithOutput("maintenance_window");
        this.WithOutput("max_cpu_count");
        this.WithOutput("max_data_storage_in_tbs");
        this.WithOutput("max_db_node_storage_size_in_gbs");
        this.WithOutput("max_memory_in_gbs");
        this.WithOutput("memory_size_in_gbs");
        this.WithOutput("monthly_db_server_version");
        this.WithOutput("monthly_storage_server_version");
        this.WithOutput("next_maintenance_run_id");
        this.WithOutput("oci_resource_anchor_name");
        this.WithOutput("oci_url");
        this.WithOutput("ocid");
        this.WithOutput("percent_progress");
        this.WithOutput("shape");
        this.WithOutput("status");
        this.WithOutput("status_reason");
        this.WithOutput("storage_count");
        this.WithOutput("storage_server_type");
        this.WithOutput("storage_server_version");
        this.WithOutput("tags");
        this.WithOutput("total_storage_size_in_gbs");
    }

    /// <summary>
    /// The unique identifier of the Exadata infrastructure.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformProperty<string> Id
    {
        get => GetRequiredProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
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
    /// The number of storage servers requested for the Exadata infrastructure.
    /// </summary>
    public TerraformExpression ActivatedStorageCount => this["activated_storage_count"];

    /// <summary>
    /// The number of storage servers requested for the Exadata infrastructure.
    /// </summary>
    public TerraformExpression AdditionalStorageCount => this["additional_storage_count"];

    /// <summary>
    /// The Amazon Resource Name (ARN) for the Exadata infrastructure.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// he name of the Availability Zone (AZ) where the Exadata infrastructure is located.
    /// </summary>
    public TerraformExpression AvailabilityZone => this["availability_zone"];

    /// <summary>
    /// The AZ ID of the AZ where the Exadata infrastructure is located.
    /// </summary>
    public TerraformExpression AvailabilityZoneId => this["availability_zone_id"];

    /// <summary>
    /// The amount of available storage, in gigabytes (GB), for the Exadata infrastructure.
    /// </summary>
    public TerraformExpression AvailableStorageSizeInGbs => this["available_storage_size_in_gbs"];

    /// <summary>
    /// The number of database servers for the Exadata infrastructure.
    /// </summary>
    public TerraformExpression ComputeCount => this["compute_count"];

    /// <summary>
    /// The OCI model compute model used when you create or clone an instance: ECPU or
    /// OCPU. An ECPU is an abstracted measure of compute resources. ECPUs are based on
    /// the number of cores elastically allocated from a pool of compute and storage
    /// servers. An OCPU is a legacy physical measure of compute resources. OCPUs are
    /// based on the physical core of a processor with hyper-threading enabled.
    /// </summary>
    public TerraformExpression ComputeModel => this["compute_model"];

    /// <summary>
    /// The total number of CPU cores that are allocated to the Exadata infrastructure.
    /// </summary>
    public TerraformExpression CpuCount => this["cpu_count"];

    /// <summary>
    /// The time when the Exadata infrastructure was created.
    /// </summary>
    public TerraformExpression CreatedAt => this["created_at"];

    /// <summary>
    /// The email addresses of contacts to receive notification from Oracle about maintenance updates for the Exadata infrastructure.
    /// </summary>
    public TerraformExpression CustomerContactsToSendToOci => this["customer_contacts_to_send_to_oci"];

    /// <summary>
    /// The size of the Exadata infrastructure&#39;s data disk group, in terabytes (TB).
    /// </summary>
    public TerraformExpression DataStorageSizeInTbs => this["data_storage_size_in_tbs"];

    /// <summary>
    /// The database server model type of the Exadata infrastructure. For the list of valid model names, use the ListDbSystemShapes operation.
    /// </summary>
    public TerraformExpression DatabaseServerType => this["database_server_type"];

    /// <summary>
    /// The database server model type of the Exadata infrastructure. For the list of
    /// valid model names, use the ListDbSystemShapes operation.
    /// </summary>
    public TerraformExpression DbNodeStorageSizeInGbs => this["db_node_storage_size_in_gbs"];

    /// <summary>
    /// The version of the Exadata infrastructure.
    /// </summary>
    public TerraformExpression DbServerVersion => this["db_server_version"];

    /// <summary>
    /// The display name of the Exadata infrastructure.
    /// </summary>
    public TerraformExpression DisplayName => this["display_name"];

    /// <summary>
    /// The Oracle Cloud Identifier (OCID) of the last maintenance run for the Exadata infrastructure.
    /// </summary>
    public TerraformExpression LastMaintenanceRunId => this["last_maintenance_run_id"];

    /// <summary>
    ///  The scheduling details for the maintenance window. Patching and system updates take place during the maintenance window 
    /// </summary>
    public TerraformExpression MaintenanceWindow => this["maintenance_window"];

    /// <summary>
    /// The total number of CPU cores available on the Exadata infrastructure.
    /// </summary>
    public TerraformExpression MaxCpuCount => this["max_cpu_count"];

    /// <summary>
    /// The total amount of data disk group storage, in terabytes (TB), that&#39;s available on the Exadata infrastructure.
    /// </summary>
    public TerraformExpression MaxDataStorageInTbs => this["max_data_storage_in_tbs"];

    /// <summary>
    /// The total amount of local node storage, in gigabytes (GB), that&#39;s available on the Exadata infrastructure.
    /// </summary>
    public TerraformExpression MaxDbNodeStorageSizeInGbs => this["max_db_node_storage_size_in_gbs"];

    /// <summary>
    /// The total amount of memory, in gigabytes (GB), that&#39;s available on the Exadata infrastructure.
    /// </summary>
    public TerraformExpression MaxMemoryInGbs => this["max_memory_in_gbs"];

    /// <summary>
    /// The amount of memory, in gigabytes (GB), that&#39;s allocated on the Exadata infrastructure.
    /// </summary>
    public TerraformExpression MemorySizeInGbs => this["memory_size_in_gbs"];

    /// <summary>
    /// The monthly software version of the database servers installed on the Exadata infrastructure.
    /// </summary>
    public TerraformExpression MonthlyDbServerVersion => this["monthly_db_server_version"];

    /// <summary>
    /// The monthly software version of the storage servers installed on the Exadata infrastructure.
    /// </summary>
    public TerraformExpression MonthlyStorageServerVersion => this["monthly_storage_server_version"];

    /// <summary>
    /// The OCID of the next maintenance run for the Exadata infrastructure.
    /// </summary>
    public TerraformExpression NextMaintenanceRunId => this["next_maintenance_run_id"];

    /// <summary>
    /// The name of the OCI resource anchor for the Exadata infrastructure.
    /// </summary>
    public TerraformExpression OciResourceAnchorName => this["oci_resource_anchor_name"];

    /// <summary>
    /// The HTTPS link to the Exadata infrastructure in OCI.
    /// </summary>
    public TerraformExpression OciUrl => this["oci_url"];

    /// <summary>
    /// The OCID of the Exadata infrastructure in OCI.
    /// </summary>
    public TerraformExpression Ocid => this["ocid"];

    /// <summary>
    /// The amount of progress made on the current operation on the Exadata infrastructure expressed as a percentage.
    /// </summary>
    public TerraformExpression PercentProgress => this["percent_progress"];

    /// <summary>
    /// The model name of the Exadata infrastructure.
    /// </summary>
    public TerraformExpression Shape => this["shape"];

    /// <summary>
    /// The status of the Exadata infrastructure.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// Additional information about the status of the Exadata infrastructure.
    /// </summary>
    public TerraformExpression StatusReason => this["status_reason"];

    /// <summary>
    /// he number of storage servers that are activated for the Exadata infrastructure.
    /// </summary>
    public TerraformExpression StorageCount => this["storage_count"];

    /// <summary>
    /// The storage server model type of the Exadata infrastructure. For the list of valid model names, use the ListDbSystemShapes operation.
    /// </summary>
    public TerraformExpression StorageServerType => this["storage_server_type"];

    /// <summary>
    /// The software version of the storage servers on the Exadata infrastructure.
    /// </summary>
    public TerraformExpression StorageServerVersion => this["storage_server_version"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The total amount of storage, in gigabytes (GB), on the the Exadata infrastructure.
    /// </summary>
    public TerraformExpression TotalStorageSizeInGbs => this["total_storage_size_in_gbs"];

}
