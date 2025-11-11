using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsEfsMountTargetTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

}

/// <summary>
/// Manages a aws_efs_mount_target resource.
/// </summary>
public partial class AwsEfsMountTarget : TerraformResource
{
    public AwsEfsMountTarget(string name) : base("aws_efs_mount_target", name)
    {
    }

    /// <summary>
    /// The file_system_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FileSystemId is required")]
    [TerraformProperty("file_system_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> FileSystemId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The ip_address attribute.
    /// </summary>
    [TerraformProperty("ip_address")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> IpAddress { get; set; }

    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    [TerraformProperty("ip_address_type")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> IpAddressType { get; set; }

    /// <summary>
    /// The ipv6_address attribute.
    /// </summary>
    [TerraformProperty("ipv6_address")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Ipv6Address { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    [TerraformProperty("security_groups")]
    // Optional+Computed - source generator will implement get/set
    public TerraformSet<string> SecurityGroups { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    [TerraformProperty("subnet_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> SubnetId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AwsEfsMountTargetTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The availability_zone_id attribute.
    /// </summary>
    [TerraformProperty("availability_zone_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> AvailabilityZoneId { get; }

    /// <summary>
    /// The availability_zone_name attribute.
    /// </summary>
    [TerraformProperty("availability_zone_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> AvailabilityZoneName { get; }

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    [TerraformProperty("dns_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DnsName { get; }

    /// <summary>
    /// The file_system_arn attribute.
    /// </summary>
    [TerraformProperty("file_system_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> FileSystemArn { get; }

    /// <summary>
    /// The mount_target_dns_name attribute.
    /// </summary>
    [TerraformProperty("mount_target_dns_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> MountTargetDnsName { get; }

    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    [TerraformProperty("network_interface_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> NetworkInterfaceId { get; }

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [TerraformProperty("owner_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> OwnerId { get; }

}
