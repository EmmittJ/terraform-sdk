using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_efs_mount_target.
/// </summary>
public class AwsEfsMountTargetDataSource : TerraformDataSource
{
    public AwsEfsMountTargetDataSource(string name) : base("aws_efs_mount_target", name)
    {
    }

    /// <summary>
    /// The access_point_id attribute.
    /// </summary>
    [TerraformPropertyName("access_point_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AccessPointId { get; set; }

    /// <summary>
    /// The file_system_id attribute.
    /// </summary>
    [TerraformPropertyName("file_system_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> FileSystemId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "file_system_id");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The mount_target_id attribute.
    /// </summary>
    [TerraformPropertyName("mount_target_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> MountTargetId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "mount_target_id");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The availability_zone_id attribute.
    /// </summary>
    [TerraformPropertyName("availability_zone_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AvailabilityZoneId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "availability_zone_id");

    /// <summary>
    /// The availability_zone_name attribute.
    /// </summary>
    [TerraformPropertyName("availability_zone_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AvailabilityZoneName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "availability_zone_name");

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    [TerraformPropertyName("dns_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DnsName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "dns_name");

    /// <summary>
    /// The file_system_arn attribute.
    /// </summary>
    [TerraformPropertyName("file_system_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> FileSystemArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "file_system_arn");

    /// <summary>
    /// The ip_address attribute.
    /// </summary>
    [TerraformPropertyName("ip_address")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> IpAddress => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ip_address");

    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    [TerraformPropertyName("ip_address_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> IpAddressType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ip_address_type");

    /// <summary>
    /// The ipv6_address attribute.
    /// </summary>
    [TerraformPropertyName("ipv6_address")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Ipv6Address => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ipv6_address");

    /// <summary>
    /// The mount_target_dns_name attribute.
    /// </summary>
    [TerraformPropertyName("mount_target_dns_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> MountTargetDnsName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "mount_target_dns_name");

    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    [TerraformPropertyName("network_interface_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NetworkInterfaceId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "network_interface_id");

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [TerraformPropertyName("owner_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OwnerId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "owner_id");

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    [TerraformPropertyName("security_groups")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> SecurityGroups => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "security_groups");

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformPropertyName("subnet_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SubnetId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "subnet_id");

}
