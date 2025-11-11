using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_odb_db_node.
/// </summary>
public partial class AwsOdbDbNodeDataSource : TerraformDataSource
{
    public AwsOdbDbNodeDataSource(string name) : base("aws_odb_db_node", name)
    {
    }

    /// <summary>
    /// The cloud_vm_cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CloudVmClusterId is required")]
    [TerraformProperty("cloud_vm_cluster_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> CloudVmClusterId { get; set; }

    /// <summary>
    /// The id attribute.
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
    /// Additional information about the planned maintenance.
    /// </summary>
    [TerraformProperty("additional_details")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AdditionalDetails { get; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The Oracle Cloud ID (OCID) of the backup IP address that&#39;s associated with the DB node.
    /// </summary>
    [TerraformProperty("backup_ip_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> BackupIpId { get; }

    /// <summary>
    /// The OCID of the second backup VNIC.
    /// </summary>
    [TerraformProperty("backup_vnic2_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> BackupVnic2Id { get; }

    /// <summary>
    /// The OCID of the backup VNIC.
    /// </summary>
    [TerraformProperty("backup_vnic_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> BackupVnicId { get; }

    /// <summary>
    /// Number of CPU cores enabled on the DB node.
    /// </summary>
    [TerraformProperty("cpu_core_count")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> CpuCoreCount { get; }

    /// <summary>
    /// The date and time when the DB node was created.
    /// </summary>
    [TerraformProperty("created_at")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreatedAt { get; }

    /// <summary>
    /// The unique identifier of the DB server that is associated with the DB node.
    /// </summary>
    [TerraformProperty("db_server_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DbServerId { get; }

    /// <summary>
    /// The amount of local node storage, in gigabytes (GBs), allocated on the DB node.
    /// </summary>
    [TerraformProperty("db_storage_size_in_gbs")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> DbStorageSizeInGbs { get; }

    /// <summary>
    /// The OCID of the DB system.
    /// </summary>
    [TerraformProperty("db_system_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DbSystemId { get; }

    /// <summary>
    /// The name of the fault domain the instance is contained in.
    /// </summary>
    [TerraformProperty("fault_domain")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> FaultDomain { get; }

    /// <summary>
    /// The floating IP address assigned to the DB node.
    /// </summary>
    [TerraformProperty("floating_ip_address")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> FloatingIpAddress { get; }

    /// <summary>
    /// The OCID of the host IP address that&#39;s associated with the DB node.
    /// </summary>
    [TerraformProperty("host_ip_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> HostIpId { get; }

    /// <summary>
    /// The host name for the DB node.
    /// </summary>
    [TerraformProperty("hostname")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Hostname { get; }

    /// <summary>
    /// The type of database node maintenance. Either VMDB_REBOOT_MIGRATION or EXADBXS_REBOOT_MIGRATION.
    /// </summary>
    [TerraformProperty("maintenance_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> MaintenanceType { get; }

    /// <summary>
    /// The allocated memory in GBs on the DB node.
    /// </summary>
    [TerraformProperty("memory_size_in_gbs")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> MemorySizeInGbs { get; }

    /// <summary>
    /// The name of the OCI resource anchor for the DB node.
    /// </summary>
    [TerraformProperty("oci_resource_anchor_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> OciResourceAnchorName { get; }

    /// <summary>
    /// The OCID of the DB node.
    /// </summary>
    [TerraformProperty("ocid")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Ocid { get; }

    /// <summary>
    /// The private IP address assigned to the DB node.
    /// </summary>
    [TerraformProperty("private_ip_address")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PrivateIpAddress { get; }

    /// <summary>
    /// The size (in GB) of the block storage volume allocation for the DB system.
    /// </summary>
    [TerraformProperty("software_storage_size_in_gbs")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> SoftwareStorageSizeInGbs { get; }

    /// <summary>
    /// The current status of the DB node.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Status { get; }

    /// <summary>
    /// Additional information about the status of the DB node.
    /// </summary>
    [TerraformProperty("status_reason")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> StatusReason { get; }

    /// <summary>
    /// End date and time of maintenance window.
    /// </summary>
    [TerraformProperty("time_maintenance_window_end")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> TimeMaintenanceWindowEnd { get; }

    /// <summary>
    /// Start date and time of maintenance window.
    /// </summary>
    [TerraformProperty("time_maintenance_window_start")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> TimeMaintenanceWindowStart { get; }

    /// <summary>
    /// The total number of CPU cores reserved on the DB node.
    /// </summary>
    [TerraformProperty("total_cpu_core_count")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> TotalCpuCoreCount { get; }

    /// <summary>
    /// The OCID of the second VNIC.
    /// </summary>
    [TerraformProperty("vnic2_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Vnic2Id { get; }

    /// <summary>
    /// The OCID of the VNIC.
    /// </summary>
    [TerraformProperty("vnic_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> VnicId { get; }

}
