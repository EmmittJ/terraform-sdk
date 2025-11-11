using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_efs_mount_target.
/// </summary>
public partial class AwsEfsMountTargetDataSource : TerraformDataSource
{
    public AwsEfsMountTargetDataSource(string name) : base("aws_efs_mount_target", name)
    {
    }

    /// <summary>
    /// The access_point_id attribute.
    /// </summary>
    [TerraformProperty("access_point_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AccessPointId { get; set; }

    /// <summary>
    /// The file_system_id attribute.
    /// </summary>
    [TerraformProperty("file_system_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> FileSystemId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The mount_target_id attribute.
    /// </summary>
    [TerraformProperty("mount_target_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> MountTargetId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The availability_zone_id attribute.
    /// </summary>
    [TerraformProperty("availability_zone_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AvailabilityZoneId { get; }

    /// <summary>
    /// The availability_zone_name attribute.
    /// </summary>
    [TerraformProperty("availability_zone_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AvailabilityZoneName { get; }

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    [TerraformProperty("dns_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DnsName { get; }

    /// <summary>
    /// The file_system_arn attribute.
    /// </summary>
    [TerraformProperty("file_system_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> FileSystemArn { get; }

    /// <summary>
    /// The ip_address attribute.
    /// </summary>
    [TerraformProperty("ip_address")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> IpAddress { get; }

    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    [TerraformProperty("ip_address_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> IpAddressType { get; }

    /// <summary>
    /// The ipv6_address attribute.
    /// </summary>
    [TerraformProperty("ipv6_address")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Ipv6Address { get; }

    /// <summary>
    /// The mount_target_dns_name attribute.
    /// </summary>
    [TerraformProperty("mount_target_dns_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> MountTargetDnsName { get; }

    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    [TerraformProperty("network_interface_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> NetworkInterfaceId { get; }

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [TerraformProperty("owner_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> OwnerId { get; }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    [TerraformProperty("security_groups")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> SecurityGroups { get; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformProperty("subnet_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SubnetId { get; }

}
