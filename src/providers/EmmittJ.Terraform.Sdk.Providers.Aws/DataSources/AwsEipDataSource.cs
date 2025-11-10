using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public class AwsEipDataSourceFilterBlock : ITerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    [TerraformPropertyName("values")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Values { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsEipDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a aws_eip.
/// </summary>
public class AwsEipDataSource : TerraformDataSource
{
    public AwsEipDataSource(string name) : base("aws_eip", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The public_ip attribute.
    /// </summary>
    [TerraformPropertyName("public_ip")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> PublicIp { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "public_ip");

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("filter")]
    public TerraformSet<TerraformBlock<AwsEipDataSourceFilterBlock>>? Filter { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsEipDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The association_id attribute.
    /// </summary>
    [TerraformPropertyName("association_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AssociationId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "association_id");

    /// <summary>
    /// The carrier_ip attribute.
    /// </summary>
    [TerraformPropertyName("carrier_ip")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CarrierIp => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "carrier_ip");

    /// <summary>
    /// The customer_owned_ip attribute.
    /// </summary>
    [TerraformPropertyName("customer_owned_ip")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CustomerOwnedIp => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "customer_owned_ip");

    /// <summary>
    /// The customer_owned_ipv4_pool attribute.
    /// </summary>
    [TerraformPropertyName("customer_owned_ipv4_pool")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CustomerOwnedIpv4Pool => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "customer_owned_ipv4_pool");

    /// <summary>
    /// The domain attribute.
    /// </summary>
    [TerraformPropertyName("domain")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Domain => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "domain");

    /// <summary>
    /// The instance_id attribute.
    /// </summary>
    [TerraformPropertyName("instance_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> InstanceId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "instance_id");

    /// <summary>
    /// The ipam_pool_id attribute.
    /// </summary>
    [TerraformPropertyName("ipam_pool_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> IpamPoolId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ipam_pool_id");

    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    [TerraformPropertyName("network_interface_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NetworkInterfaceId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "network_interface_id");

    /// <summary>
    /// The network_interface_owner_id attribute.
    /// </summary>
    [TerraformPropertyName("network_interface_owner_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NetworkInterfaceOwnerId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "network_interface_owner_id");

    /// <summary>
    /// The private_dns attribute.
    /// </summary>
    [TerraformPropertyName("private_dns")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrivateDns => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "private_dns");

    /// <summary>
    /// The private_ip attribute.
    /// </summary>
    [TerraformPropertyName("private_ip")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrivateIp => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "private_ip");

    /// <summary>
    /// The ptr_record attribute.
    /// </summary>
    [TerraformPropertyName("ptr_record")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PtrRecord => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ptr_record");

    /// <summary>
    /// The public_dns attribute.
    /// </summary>
    [TerraformPropertyName("public_dns")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PublicDns => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "public_dns");

    /// <summary>
    /// The public_ipv4_pool attribute.
    /// </summary>
    [TerraformPropertyName("public_ipv4_pool")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PublicIpv4Pool => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "public_ipv4_pool");

}
