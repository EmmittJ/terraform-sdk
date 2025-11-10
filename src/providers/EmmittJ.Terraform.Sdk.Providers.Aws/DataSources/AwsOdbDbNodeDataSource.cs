using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_odb_db_node.
/// </summary>
public class AwsOdbDbNodeDataSource : TerraformDataSource
{
    public AwsOdbDbNodeDataSource(string name) : base("aws_odb_db_node", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("additional_details");
        this.WithOutput("arn");
        this.WithOutput("backup_ip_id");
        this.WithOutput("backup_vnic2_id");
        this.WithOutput("backup_vnic_id");
        this.WithOutput("cpu_core_count");
        this.WithOutput("created_at");
        this.WithOutput("db_server_id");
        this.WithOutput("db_storage_size_in_gbs");
        this.WithOutput("db_system_id");
        this.WithOutput("fault_domain");
        this.WithOutput("floating_ip_address");
        this.WithOutput("host_ip_id");
        this.WithOutput("hostname");
        this.WithOutput("maintenance_type");
        this.WithOutput("memory_size_in_gbs");
        this.WithOutput("oci_resource_anchor_name");
        this.WithOutput("ocid");
        this.WithOutput("private_ip_address");
        this.WithOutput("software_storage_size_in_gbs");
        this.WithOutput("status");
        this.WithOutput("status_reason");
        this.WithOutput("time_maintenance_window_end");
        this.WithOutput("time_maintenance_window_start");
        this.WithOutput("total_cpu_core_count");
        this.WithOutput("vnic2_id");
        this.WithOutput("vnic_id");
    }

    /// <summary>
    /// The cloud_vm_cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CloudVmClusterId is required")]
    public required TerraformProperty<string> CloudVmClusterId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("cloud_vm_cluster_id");
        set => this.WithProperty("cloud_vm_cluster_id", value);
    }

    /// <summary>
    /// The id attribute.
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
    /// Additional information about the planned maintenance.
    /// </summary>
    public TerraformExpression AdditionalDetails => this["additional_details"];

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The Oracle Cloud ID (OCID) of the backup IP address that&#39;s associated with the DB node.
    /// </summary>
    public TerraformExpression BackupIpId => this["backup_ip_id"];

    /// <summary>
    /// The OCID of the second backup VNIC.
    /// </summary>
    public TerraformExpression BackupVnic2Id => this["backup_vnic2_id"];

    /// <summary>
    /// The OCID of the backup VNIC.
    /// </summary>
    public TerraformExpression BackupVnicId => this["backup_vnic_id"];

    /// <summary>
    /// Number of CPU cores enabled on the DB node.
    /// </summary>
    public TerraformExpression CpuCoreCount => this["cpu_core_count"];

    /// <summary>
    /// The date and time when the DB node was created.
    /// </summary>
    public TerraformExpression CreatedAt => this["created_at"];

    /// <summary>
    /// The unique identifier of the DB server that is associated with the DB node.
    /// </summary>
    public TerraformExpression DbServerId => this["db_server_id"];

    /// <summary>
    /// The amount of local node storage, in gigabytes (GBs), allocated on the DB node.
    /// </summary>
    public TerraformExpression DbStorageSizeInGbs => this["db_storage_size_in_gbs"];

    /// <summary>
    /// The OCID of the DB system.
    /// </summary>
    public TerraformExpression DbSystemId => this["db_system_id"];

    /// <summary>
    /// The name of the fault domain the instance is contained in.
    /// </summary>
    public TerraformExpression FaultDomain => this["fault_domain"];

    /// <summary>
    /// The floating IP address assigned to the DB node.
    /// </summary>
    public TerraformExpression FloatingIpAddress => this["floating_ip_address"];

    /// <summary>
    /// The OCID of the host IP address that&#39;s associated with the DB node.
    /// </summary>
    public TerraformExpression HostIpId => this["host_ip_id"];

    /// <summary>
    /// The host name for the DB node.
    /// </summary>
    public TerraformExpression Hostname => this["hostname"];

    /// <summary>
    /// The type of database node maintenance. Either VMDB_REBOOT_MIGRATION or EXADBXS_REBOOT_MIGRATION.
    /// </summary>
    public TerraformExpression MaintenanceType => this["maintenance_type"];

    /// <summary>
    /// The allocated memory in GBs on the DB node.
    /// </summary>
    public TerraformExpression MemorySizeInGbs => this["memory_size_in_gbs"];

    /// <summary>
    /// The name of the OCI resource anchor for the DB node.
    /// </summary>
    public TerraformExpression OciResourceAnchorName => this["oci_resource_anchor_name"];

    /// <summary>
    /// The OCID of the DB node.
    /// </summary>
    public TerraformExpression Ocid => this["ocid"];

    /// <summary>
    /// The private IP address assigned to the DB node.
    /// </summary>
    public TerraformExpression PrivateIpAddress => this["private_ip_address"];

    /// <summary>
    /// The size (in GB) of the block storage volume allocation for the DB system.
    /// </summary>
    public TerraformExpression SoftwareStorageSizeInGbs => this["software_storage_size_in_gbs"];

    /// <summary>
    /// The current status of the DB node.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// Additional information about the status of the DB node.
    /// </summary>
    public TerraformExpression StatusReason => this["status_reason"];

    /// <summary>
    /// End date and time of maintenance window.
    /// </summary>
    public TerraformExpression TimeMaintenanceWindowEnd => this["time_maintenance_window_end"];

    /// <summary>
    /// Start date and time of maintenance window.
    /// </summary>
    public TerraformExpression TimeMaintenanceWindowStart => this["time_maintenance_window_start"];

    /// <summary>
    /// The total number of CPU cores reserved on the DB node.
    /// </summary>
    public TerraformExpression TotalCpuCoreCount => this["total_cpu_core_count"];

    /// <summary>
    /// The OCID of the second VNIC.
    /// </summary>
    public TerraformExpression Vnic2Id => this["vnic2_id"];

    /// <summary>
    /// The OCID of the VNIC.
    /// </summary>
    public TerraformExpression VnicId => this["vnic_id"];

}
