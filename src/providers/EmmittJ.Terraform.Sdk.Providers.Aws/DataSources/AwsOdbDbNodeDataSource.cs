using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_odb_db_node.
/// </summary>
public class AwsOdbDbNodeDataSource : TerraformDataSource
{
    public AwsOdbDbNodeDataSource(string name) : base("aws_odb_db_node", name)
    {
    }

    /// <summary>
    /// The cloud_vm_cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CloudVmClusterId is required")]
    [TerraformPropertyName("cloud_vm_cluster_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> CloudVmClusterId { get; set; }

    /// <summary>
    /// The id attribute.
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
    /// Additional information about the planned maintenance.
    /// </summary>
    [TerraformPropertyName("additional_details")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AdditionalDetails => new TerraformReference(this, "additional_details");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The Oracle Cloud ID (OCID) of the backup IP address that&#39;s associated with the DB node.
    /// </summary>
    [TerraformPropertyName("backup_ip_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> BackupIpId => new TerraformReference(this, "backup_ip_id");

    /// <summary>
    /// The OCID of the second backup VNIC.
    /// </summary>
    [TerraformPropertyName("backup_vnic2_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> BackupVnic2Id => new TerraformReference(this, "backup_vnic2_id");

    /// <summary>
    /// The OCID of the backup VNIC.
    /// </summary>
    [TerraformPropertyName("backup_vnic_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> BackupVnicId => new TerraformReference(this, "backup_vnic_id");

    /// <summary>
    /// Number of CPU cores enabled on the DB node.
    /// </summary>
    [TerraformPropertyName("cpu_core_count")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> CpuCoreCount => new TerraformReference(this, "cpu_core_count");

    /// <summary>
    /// The date and time when the DB node was created.
    /// </summary>
    [TerraformPropertyName("created_at")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreatedAt => new TerraformReference(this, "created_at");

    /// <summary>
    /// The unique identifier of the DB server that is associated with the DB node.
    /// </summary>
    [TerraformPropertyName("db_server_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DbServerId => new TerraformReference(this, "db_server_id");

    /// <summary>
    /// The amount of local node storage, in gigabytes (GBs), allocated on the DB node.
    /// </summary>
    [TerraformPropertyName("db_storage_size_in_gbs")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> DbStorageSizeInGbs => new TerraformReference(this, "db_storage_size_in_gbs");

    /// <summary>
    /// The OCID of the DB system.
    /// </summary>
    [TerraformPropertyName("db_system_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DbSystemId => new TerraformReference(this, "db_system_id");

    /// <summary>
    /// The name of the fault domain the instance is contained in.
    /// </summary>
    [TerraformPropertyName("fault_domain")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> FaultDomain => new TerraformReference(this, "fault_domain");

    /// <summary>
    /// The floating IP address assigned to the DB node.
    /// </summary>
    [TerraformPropertyName("floating_ip_address")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> FloatingIpAddress => new TerraformReference(this, "floating_ip_address");

    /// <summary>
    /// The OCID of the host IP address that&#39;s associated with the DB node.
    /// </summary>
    [TerraformPropertyName("host_ip_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> HostIpId => new TerraformReference(this, "host_ip_id");

    /// <summary>
    /// The host name for the DB node.
    /// </summary>
    [TerraformPropertyName("hostname")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Hostname => new TerraformReference(this, "hostname");

    /// <summary>
    /// The type of database node maintenance. Either VMDB_REBOOT_MIGRATION or EXADBXS_REBOOT_MIGRATION.
    /// </summary>
    [TerraformPropertyName("maintenance_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> MaintenanceType => new TerraformReference(this, "maintenance_type");

    /// <summary>
    /// The allocated memory in GBs on the DB node.
    /// </summary>
    [TerraformPropertyName("memory_size_in_gbs")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> MemorySizeInGbs => new TerraformReference(this, "memory_size_in_gbs");

    /// <summary>
    /// The name of the OCI resource anchor for the DB node.
    /// </summary>
    [TerraformPropertyName("oci_resource_anchor_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OciResourceAnchorName => new TerraformReference(this, "oci_resource_anchor_name");

    /// <summary>
    /// The OCID of the DB node.
    /// </summary>
    [TerraformPropertyName("ocid")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Ocid => new TerraformReference(this, "ocid");

    /// <summary>
    /// The private IP address assigned to the DB node.
    /// </summary>
    [TerraformPropertyName("private_ip_address")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrivateIpAddress => new TerraformReference(this, "private_ip_address");

    /// <summary>
    /// The size (in GB) of the block storage volume allocation for the DB system.
    /// </summary>
    [TerraformPropertyName("software_storage_size_in_gbs")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> SoftwareStorageSizeInGbs => new TerraformReference(this, "software_storage_size_in_gbs");

    /// <summary>
    /// The current status of the DB node.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Status => new TerraformReference(this, "status");

    /// <summary>
    /// Additional information about the status of the DB node.
    /// </summary>
    [TerraformPropertyName("status_reason")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> StatusReason => new TerraformReference(this, "status_reason");

    /// <summary>
    /// End date and time of maintenance window.
    /// </summary>
    [TerraformPropertyName("time_maintenance_window_end")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TimeMaintenanceWindowEnd => new TerraformReference(this, "time_maintenance_window_end");

    /// <summary>
    /// Start date and time of maintenance window.
    /// </summary>
    [TerraformPropertyName("time_maintenance_window_start")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TimeMaintenanceWindowStart => new TerraformReference(this, "time_maintenance_window_start");

    /// <summary>
    /// The total number of CPU cores reserved on the DB node.
    /// </summary>
    [TerraformPropertyName("total_cpu_core_count")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> TotalCpuCoreCount => new TerraformReference(this, "total_cpu_core_count");

    /// <summary>
    /// The OCID of the second VNIC.
    /// </summary>
    [TerraformPropertyName("vnic2_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Vnic2Id => new TerraformReference(this, "vnic2_id");

    /// <summary>
    /// The OCID of the VNIC.
    /// </summary>
    [TerraformPropertyName("vnic_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> VnicId => new TerraformReference(this, "vnic_id");

}
