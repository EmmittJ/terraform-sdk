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
    public required TerraformProperty<TerraformProperty<string>> CloudVmClusterId { get; set; }

    /// <summary>
    /// The id attribute.
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
    /// Additional information about the planned maintenance.
    /// </summary>
    [TerraformPropertyName("additional_details")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AdditionalDetails => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "additional_details");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The Oracle Cloud ID (OCID) of the backup IP address that&#39;s associated with the DB node.
    /// </summary>
    [TerraformPropertyName("backup_ip_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> BackupIpId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "backup_ip_id");

    /// <summary>
    /// The OCID of the second backup VNIC.
    /// </summary>
    [TerraformPropertyName("backup_vnic2_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> BackupVnic2Id => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "backup_vnic2_id");

    /// <summary>
    /// The OCID of the backup VNIC.
    /// </summary>
    [TerraformPropertyName("backup_vnic_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> BackupVnicId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "backup_vnic_id");

    /// <summary>
    /// Number of CPU cores enabled on the DB node.
    /// </summary>
    [TerraformPropertyName("cpu_core_count")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> CpuCoreCount => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "cpu_core_count");

    /// <summary>
    /// The date and time when the DB node was created.
    /// </summary>
    [TerraformPropertyName("created_at")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreatedAt => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "created_at");

    /// <summary>
    /// The unique identifier of the DB server that is associated with the DB node.
    /// </summary>
    [TerraformPropertyName("db_server_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DbServerId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "db_server_id");

    /// <summary>
    /// The amount of local node storage, in gigabytes (GBs), allocated on the DB node.
    /// </summary>
    [TerraformPropertyName("db_storage_size_in_gbs")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> DbStorageSizeInGbs => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "db_storage_size_in_gbs");

    /// <summary>
    /// The OCID of the DB system.
    /// </summary>
    [TerraformPropertyName("db_system_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DbSystemId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "db_system_id");

    /// <summary>
    /// The name of the fault domain the instance is contained in.
    /// </summary>
    [TerraformPropertyName("fault_domain")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> FaultDomain => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "fault_domain");

    /// <summary>
    /// The floating IP address assigned to the DB node.
    /// </summary>
    [TerraformPropertyName("floating_ip_address")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> FloatingIpAddress => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "floating_ip_address");

    /// <summary>
    /// The OCID of the host IP address that&#39;s associated with the DB node.
    /// </summary>
    [TerraformPropertyName("host_ip_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> HostIpId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "host_ip_id");

    /// <summary>
    /// The host name for the DB node.
    /// </summary>
    [TerraformPropertyName("hostname")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Hostname => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "hostname");

    /// <summary>
    /// The type of database node maintenance. Either VMDB_REBOOT_MIGRATION or EXADBXS_REBOOT_MIGRATION.
    /// </summary>
    [TerraformPropertyName("maintenance_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> MaintenanceType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "maintenance_type");

    /// <summary>
    /// The allocated memory in GBs on the DB node.
    /// </summary>
    [TerraformPropertyName("memory_size_in_gbs")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> MemorySizeInGbs => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "memory_size_in_gbs");

    /// <summary>
    /// The name of the OCI resource anchor for the DB node.
    /// </summary>
    [TerraformPropertyName("oci_resource_anchor_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OciResourceAnchorName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "oci_resource_anchor_name");

    /// <summary>
    /// The OCID of the DB node.
    /// </summary>
    [TerraformPropertyName("ocid")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Ocid => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ocid");

    /// <summary>
    /// The private IP address assigned to the DB node.
    /// </summary>
    [TerraformPropertyName("private_ip_address")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrivateIpAddress => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "private_ip_address");

    /// <summary>
    /// The size (in GB) of the block storage volume allocation for the DB system.
    /// </summary>
    [TerraformPropertyName("software_storage_size_in_gbs")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> SoftwareStorageSizeInGbs => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "software_storage_size_in_gbs");

    /// <summary>
    /// The current status of the DB node.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Status => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status");

    /// <summary>
    /// Additional information about the status of the DB node.
    /// </summary>
    [TerraformPropertyName("status_reason")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StatusReason => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status_reason");

    /// <summary>
    /// End date and time of maintenance window.
    /// </summary>
    [TerraformPropertyName("time_maintenance_window_end")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TimeMaintenanceWindowEnd => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "time_maintenance_window_end");

    /// <summary>
    /// Start date and time of maintenance window.
    /// </summary>
    [TerraformPropertyName("time_maintenance_window_start")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TimeMaintenanceWindowStart => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "time_maintenance_window_start");

    /// <summary>
    /// The total number of CPU cores reserved on the DB node.
    /// </summary>
    [TerraformPropertyName("total_cpu_core_count")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> TotalCpuCoreCount => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "total_cpu_core_count");

    /// <summary>
    /// The OCID of the second VNIC.
    /// </summary>
    [TerraformPropertyName("vnic2_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Vnic2Id => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "vnic2_id");

    /// <summary>
    /// The OCID of the VNIC.
    /// </summary>
    [TerraformPropertyName("vnic_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VnicId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "vnic_id");

}
