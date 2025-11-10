using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsDefaultSubnetTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

}

/// <summary>
/// Manages a aws_default_subnet resource.
/// </summary>
public class AwsDefaultSubnet : TerraformResource
{
    public AwsDefaultSubnet(string name) : base("aws_default_subnet", name)
    {
    }

    /// <summary>
    /// The assign_ipv6_address_on_creation attribute.
    /// </summary>
    [TerraformPropertyName("assign_ipv6_address_on_creation")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AssignIpv6AddressOnCreation { get; set; }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AvailabilityZone is required")]
    [TerraformPropertyName("availability_zone")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AvailabilityZone { get; set; }

    /// <summary>
    /// The customer_owned_ipv4_pool attribute.
    /// </summary>
    [TerraformPropertyName("customer_owned_ipv4_pool")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CustomerOwnedIpv4Pool { get; set; }

    /// <summary>
    /// The enable_dns64 attribute.
    /// </summary>
    [TerraformPropertyName("enable_dns64")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableDns64 { get; set; }

    /// <summary>
    /// The enable_resource_name_dns_a_record_on_launch attribute.
    /// </summary>
    [TerraformPropertyName("enable_resource_name_dns_a_record_on_launch")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableResourceNameDnsARecordOnLaunch { get; set; }

    /// <summary>
    /// The enable_resource_name_dns_aaaa_record_on_launch attribute.
    /// </summary>
    [TerraformPropertyName("enable_resource_name_dns_aaaa_record_on_launch")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableResourceNameDnsAaaaRecordOnLaunch { get; set; }

    /// <summary>
    /// The force_destroy attribute.
    /// </summary>
    [TerraformPropertyName("force_destroy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ForceDestroy { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The ipv6_cidr_block attribute.
    /// </summary>
    [TerraformPropertyName("ipv6_cidr_block")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Ipv6CidrBlock { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ipv6_cidr_block");

    /// <summary>
    /// The ipv6_native attribute.
    /// </summary>
    [TerraformPropertyName("ipv6_native")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Ipv6Native { get; set; }

    /// <summary>
    /// The map_customer_owned_ip_on_launch attribute.
    /// </summary>
    [TerraformPropertyName("map_customer_owned_ip_on_launch")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? MapCustomerOwnedIpOnLaunch { get; set; }

    /// <summary>
    /// The map_public_ip_on_launch attribute.
    /// </summary>
    [TerraformPropertyName("map_public_ip_on_launch")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? MapPublicIpOnLaunch { get; set; }

    /// <summary>
    /// The private_dns_hostname_type_on_launch attribute.
    /// </summary>
    [TerraformPropertyName("private_dns_hostname_type_on_launch")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> PrivateDnsHostnameTypeOnLaunch { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "private_dns_hostname_type_on_launch");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsDefaultSubnetTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The availability_zone_id attribute.
    /// </summary>
    [TerraformPropertyName("availability_zone_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AvailabilityZoneId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "availability_zone_id");

    /// <summary>
    /// The cidr_block attribute.
    /// </summary>
    [TerraformPropertyName("cidr_block")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CidrBlock => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "cidr_block");

    /// <summary>
    /// The enable_lni_at_device_index attribute.
    /// </summary>
    [TerraformPropertyName("enable_lni_at_device_index")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> EnableLniAtDeviceIndex => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "enable_lni_at_device_index");

    /// <summary>
    /// The existing_default_subnet attribute.
    /// </summary>
    [TerraformPropertyName("existing_default_subnet")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> ExistingDefaultSubnet => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "existing_default_subnet");

    /// <summary>
    /// The ipv6_cidr_block_association_id attribute.
    /// </summary>
    [TerraformPropertyName("ipv6_cidr_block_association_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Ipv6CidrBlockAssociationId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ipv6_cidr_block_association_id");

    /// <summary>
    /// The outpost_arn attribute.
    /// </summary>
    [TerraformPropertyName("outpost_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OutpostArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "outpost_arn");

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [TerraformPropertyName("owner_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OwnerId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "owner_id");

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformPropertyName("vpc_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VpcId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "vpc_id");

}
