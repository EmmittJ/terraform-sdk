using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsEipTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a aws_eip resource.
/// </summary>
public class AwsEip : TerraformResource
{
    public AwsEip(string name) : base("aws_eip", name)
    {
    }

    /// <summary>
    /// The address attribute.
    /// </summary>
    [TerraformPropertyName("address")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Address { get; set; }

    /// <summary>
    /// The associate_with_private_ip attribute.
    /// </summary>
    [TerraformPropertyName("associate_with_private_ip")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AssociateWithPrivateIp { get; set; }

    /// <summary>
    /// The customer_owned_ipv4_pool attribute.
    /// </summary>
    [TerraformPropertyName("customer_owned_ipv4_pool")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CustomerOwnedIpv4Pool { get; set; }

    /// <summary>
    /// The domain attribute.
    /// </summary>
    [TerraformPropertyName("domain")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Domain { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "domain");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The instance attribute.
    /// </summary>
    [TerraformPropertyName("instance")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Instance { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "instance");

    /// <summary>
    /// The ipam_pool_id attribute.
    /// </summary>
    [TerraformPropertyName("ipam_pool_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> IpamPoolId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ipam_pool_id");

    /// <summary>
    /// The network_border_group attribute.
    /// </summary>
    [TerraformPropertyName("network_border_group")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> NetworkBorderGroup { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "network_border_group");

    /// <summary>
    /// The network_interface attribute.
    /// </summary>
    [TerraformPropertyName("network_interface")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> NetworkInterface { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "network_interface");

    /// <summary>
    /// The public_ipv4_pool attribute.
    /// </summary>
    [TerraformPropertyName("public_ipv4_pool")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> PublicIpv4Pool { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "public_ipv4_pool");

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
    public TerraformBlock<AwsEipTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The allocation_id attribute.
    /// </summary>
    [TerraformPropertyName("allocation_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AllocationId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "allocation_id");

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
    /// The public_ip attribute.
    /// </summary>
    [TerraformPropertyName("public_ip")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PublicIp => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "public_ip");

}
