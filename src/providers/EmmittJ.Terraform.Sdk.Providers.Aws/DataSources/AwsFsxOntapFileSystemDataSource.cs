using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_fsx_ontap_file_system.
/// </summary>
public partial class AwsFsxOntapFileSystemDataSource : TerraformDataSource
{
    public AwsFsxOntapFileSystemDataSource(string name) : base("aws_fsx_ontap_file_system", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformProperty("id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The automatic_backup_retention_days attribute.
    /// </summary>
    [TerraformProperty("automatic_backup_retention_days")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> AutomaticBackupRetentionDays { get; }

    /// <summary>
    /// The daily_automatic_backup_start_time attribute.
    /// </summary>
    [TerraformProperty("daily_automatic_backup_start_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DailyAutomaticBackupStartTime { get; }

    /// <summary>
    /// The deployment_type attribute.
    /// </summary>
    [TerraformProperty("deployment_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DeploymentType { get; }

    /// <summary>
    /// The disk_iops_configuration attribute.
    /// </summary>
    [TerraformProperty("disk_iops_configuration")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> DiskIopsConfiguration { get; }

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    [TerraformProperty("dns_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DnsName { get; }

    /// <summary>
    /// The endpoint_ip_address_range attribute.
    /// </summary>
    [TerraformProperty("endpoint_ip_address_range")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> EndpointIpAddressRange { get; }

    /// <summary>
    /// The endpoints attribute.
    /// </summary>
    [TerraformProperty("endpoints")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Endpoints { get; }

    /// <summary>
    /// The ha_pairs attribute.
    /// </summary>
    [TerraformProperty("ha_pairs")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> HaPairs { get; }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformProperty("kms_key_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> KmsKeyId { get; }

    /// <summary>
    /// The network_interface_ids attribute.
    /// </summary>
    [TerraformProperty("network_interface_ids")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> NetworkInterfaceIds { get; }

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [TerraformProperty("owner_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> OwnerId { get; }

    /// <summary>
    /// The preferred_subnet_id attribute.
    /// </summary>
    [TerraformProperty("preferred_subnet_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PreferredSubnetId { get; }

    /// <summary>
    /// The route_table_ids attribute.
    /// </summary>
    [TerraformProperty("route_table_ids")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<string> RouteTableIds { get; }

    /// <summary>
    /// The storage_capacity attribute.
    /// </summary>
    [TerraformProperty("storage_capacity")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> StorageCapacity { get; }

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    [TerraformProperty("storage_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> StorageType { get; }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [TerraformProperty("subnet_ids")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> SubnetIds { get; }

    /// <summary>
    /// The throughput_capacity attribute.
    /// </summary>
    [TerraformProperty("throughput_capacity")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> ThroughputCapacity { get; }

    /// <summary>
    /// The throughput_capacity_per_ha_pair attribute.
    /// </summary>
    [TerraformProperty("throughput_capacity_per_ha_pair")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> ThroughputCapacityPerHaPair { get; }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformProperty("vpc_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> VpcId { get; }

    /// <summary>
    /// The weekly_maintenance_start_time attribute.
    /// </summary>
    [TerraformProperty("weekly_maintenance_start_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> WeeklyMaintenanceStartTime { get; }

}
