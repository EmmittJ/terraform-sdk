using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for disk_iops_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsFsxOntapFileSystemDiskIopsConfigurationBlock() : TerraformBlock("disk_iops_configuration")
{
    /// <summary>
    /// The iops attribute.
    /// </summary>
    [TerraformProperty("iops")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> Iops { get; set; }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [TerraformProperty("mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Mode { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsFsxOntapFileSystemTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_fsx_ontap_file_system resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsFsxOntapFileSystem : TerraformResource
{
    public AwsFsxOntapFileSystem(string name) : base("aws_fsx_ontap_file_system", name)
    {
    }

    /// <summary>
    /// The automatic_backup_retention_days attribute.
    /// </summary>
    [TerraformProperty("automatic_backup_retention_days")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? AutomaticBackupRetentionDays { get; set; }

    /// <summary>
    /// The daily_automatic_backup_start_time attribute.
    /// </summary>
    [TerraformProperty("daily_automatic_backup_start_time")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> DailyAutomaticBackupStartTime { get; set; }

    /// <summary>
    /// The deployment_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeploymentType is required")]
    [TerraformProperty("deployment_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DeploymentType { get; set; }

    /// <summary>
    /// The endpoint_ip_address_range attribute.
    /// </summary>
    [TerraformProperty("endpoint_ip_address_range")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> EndpointIpAddressRange { get; set; }

    /// <summary>
    /// The fsx_admin_password attribute.
    /// </summary>
    [TerraformProperty("fsx_admin_password")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? FsxAdminPassword { get; set; }

    /// <summary>
    /// The ha_pairs attribute.
    /// </summary>
    [TerraformProperty("ha_pairs")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> HaPairs { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformProperty("kms_key_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> KmsKeyId { get; set; }

    /// <summary>
    /// The preferred_subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PreferredSubnetId is required")]
    [TerraformProperty("preferred_subnet_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PreferredSubnetId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The route_table_ids attribute.
    /// </summary>
    [TerraformProperty("route_table_ids")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> RouteTableIds { get; set; }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [TerraformProperty("security_group_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? SecurityGroupIds { get; set; }

    /// <summary>
    /// The storage_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageCapacity is required")]
    [TerraformProperty("storage_capacity")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> StorageCapacity { get; set; }

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    [TerraformProperty("storage_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? StorageType { get; set; }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    [TerraformProperty("subnet_ids")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<string>? SubnetIds { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The throughput_capacity attribute.
    /// </summary>
    [TerraformProperty("throughput_capacity")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> ThroughputCapacity { get; set; }

    /// <summary>
    /// The throughput_capacity_per_ha_pair attribute.
    /// </summary>
    [TerraformProperty("throughput_capacity_per_ha_pair")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> ThroughputCapacityPerHaPair { get; set; }

    /// <summary>
    /// The weekly_maintenance_start_time attribute.
    /// </summary>
    [TerraformProperty("weekly_maintenance_start_time")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> WeeklyMaintenanceStartTime { get; set; }

    /// <summary>
    /// Block for disk_iops_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DiskIopsConfiguration block(s) allowed")]
    [TerraformProperty("disk_iops_configuration")]
    public TerraformList<AwsFsxOntapFileSystemDiskIopsConfigurationBlock> DiskIopsConfiguration { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsFsxOntapFileSystemTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    [TerraformProperty("dns_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DnsName { get; }

    /// <summary>
    /// The endpoints attribute.
    /// </summary>
    [TerraformProperty("endpoints")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Endpoints { get; }

    /// <summary>
    /// The network_interface_ids attribute.
    /// </summary>
    [TerraformProperty("network_interface_ids")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> NetworkInterfaceIds { get; }

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [TerraformProperty("owner_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> OwnerId { get; }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformProperty("vpc_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> VpcId { get; }

}
