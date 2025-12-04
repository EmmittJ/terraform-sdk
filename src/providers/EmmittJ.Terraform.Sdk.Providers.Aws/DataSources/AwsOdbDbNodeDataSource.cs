using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_odb_db_node Terraform data source.
/// Retrieves information about a aws_odb_db_node.
/// </summary>
public partial class AwsOdbDbNodeDataSource(string name) : TerraformDataSource("aws_odb_db_node", name)
{
    /// <summary>
    /// The cloud_vm_cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CloudVmClusterId is required")]
    public required TerraformValue<string> CloudVmClusterId
    {
        get => GetRequiredArgument<TerraformValue<string>>("cloud_vm_cluster_id");
        set => SetArgument("cloud_vm_cluster_id", value);
    }

    /// <summary>
    /// The id attribute.
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
    /// Additional information about the planned maintenance.
    /// </summary>
    public TerraformValue<string> AdditionalDetails
        => AsReference("additional_details");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The Oracle Cloud ID (OCID) of the backup IP address that&#39;s associated with the DB node.
    /// </summary>
    public TerraformValue<string> BackupIpId
        => AsReference("backup_ip_id");

    /// <summary>
    /// The OCID of the second backup VNIC.
    /// </summary>
    public TerraformValue<string> BackupVnic2Id
        => AsReference("backup_vnic2_id");

    /// <summary>
    /// The OCID of the backup VNIC.
    /// </summary>
    public TerraformValue<string> BackupVnicId
        => AsReference("backup_vnic_id");

    /// <summary>
    /// Number of CPU cores enabled on the DB node.
    /// </summary>
    public TerraformValue<double> CpuCoreCount
        => AsReference("cpu_core_count");

    /// <summary>
    /// The date and time when the DB node was created.
    /// </summary>
    public TerraformValue<string> CreatedAt
        => AsReference("created_at");

    /// <summary>
    /// The unique identifier of the DB server that is associated with the DB node.
    /// </summary>
    public TerraformValue<string> DbServerId
        => AsReference("db_server_id");

    /// <summary>
    /// The amount of local node storage, in gigabytes (GBs), allocated on the DB node.
    /// </summary>
    public TerraformValue<double> DbStorageSizeInGbs
        => AsReference("db_storage_size_in_gbs");

    /// <summary>
    /// The OCID of the DB system.
    /// </summary>
    public TerraformValue<string> DbSystemId
        => AsReference("db_system_id");

    /// <summary>
    /// The name of the fault domain the instance is contained in.
    /// </summary>
    public TerraformValue<string> FaultDomain
        => AsReference("fault_domain");

    /// <summary>
    /// The floating IP address assigned to the DB node.
    /// </summary>
    public TerraformValue<string> FloatingIpAddress
        => AsReference("floating_ip_address");

    /// <summary>
    /// The OCID of the host IP address that&#39;s associated with the DB node.
    /// </summary>
    public TerraformValue<string> HostIpId
        => AsReference("host_ip_id");

    /// <summary>
    /// The host name for the DB node.
    /// </summary>
    public TerraformValue<string> Hostname
        => AsReference("hostname");

    /// <summary>
    /// The type of database node maintenance. Either VMDB_REBOOT_MIGRATION or EXADBXS_REBOOT_MIGRATION.
    /// </summary>
    public TerraformValue<string> MaintenanceType
        => AsReference("maintenance_type");

    /// <summary>
    /// The allocated memory in GBs on the DB node.
    /// </summary>
    public TerraformValue<double> MemorySizeInGbs
        => AsReference("memory_size_in_gbs");

    /// <summary>
    /// The name of the OCI resource anchor for the DB node.
    /// </summary>
    public TerraformValue<string> OciResourceAnchorName
        => AsReference("oci_resource_anchor_name");

    /// <summary>
    /// The OCID of the DB node.
    /// </summary>
    public TerraformValue<string> Ocid
        => AsReference("ocid");

    /// <summary>
    /// The private IP address assigned to the DB node.
    /// </summary>
    public TerraformValue<string> PrivateIpAddress
        => AsReference("private_ip_address");

    /// <summary>
    /// The size (in GB) of the block storage volume allocation for the DB system.
    /// </summary>
    public TerraformValue<double> SoftwareStorageSizeInGbs
        => AsReference("software_storage_size_in_gbs");

    /// <summary>
    /// The current status of the DB node.
    /// </summary>
    public TerraformValue<string> Status
        => AsReference("status");

    /// <summary>
    /// Additional information about the status of the DB node.
    /// </summary>
    public TerraformValue<string> StatusReason
        => AsReference("status_reason");

    /// <summary>
    /// End date and time of maintenance window.
    /// </summary>
    public TerraformValue<string> TimeMaintenanceWindowEnd
        => AsReference("time_maintenance_window_end");

    /// <summary>
    /// Start date and time of maintenance window.
    /// </summary>
    public TerraformValue<string> TimeMaintenanceWindowStart
        => AsReference("time_maintenance_window_start");

    /// <summary>
    /// The total number of CPU cores reserved on the DB node.
    /// </summary>
    public TerraformValue<double> TotalCpuCoreCount
        => AsReference("total_cpu_core_count");

    /// <summary>
    /// The OCID of the second VNIC.
    /// </summary>
    public TerraformValue<string> Vnic2Id
        => AsReference("vnic2_id");

    /// <summary>
    /// The OCID of the VNIC.
    /// </summary>
    public TerraformValue<string> VnicId
        => AsReference("vnic_id");

}
