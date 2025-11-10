using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsNatGatewayTimeoutsBlock : ITerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a aws_nat_gateway resource.
/// </summary>
public class AwsNatGateway : TerraformResource
{
    public AwsNatGateway(string name) : base("aws_nat_gateway", name)
    {
    }

    /// <summary>
    /// The allocation_id attribute.
    /// </summary>
    [TerraformPropertyName("allocation_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AllocationId { get; set; }

    /// <summary>
    /// The connectivity_type attribute.
    /// </summary>
    [TerraformPropertyName("connectivity_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ConnectivityType { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The private_ip attribute.
    /// </summary>
    [TerraformPropertyName("private_ip")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> PrivateIp { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "private_ip");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The secondary_allocation_ids attribute.
    /// </summary>
    [TerraformPropertyName("secondary_allocation_ids")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> SecondaryAllocationIds { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "secondary_allocation_ids");

    /// <summary>
    /// The secondary_private_ip_address_count attribute.
    /// </summary>
    [TerraformPropertyName("secondary_private_ip_address_count")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> SecondaryPrivateIpAddressCount { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "secondary_private_ip_address_count");

    /// <summary>
    /// The secondary_private_ip_addresses attribute.
    /// </summary>
    [TerraformPropertyName("secondary_private_ip_addresses")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> SecondaryPrivateIpAddresses { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "secondary_private_ip_addresses");

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    [TerraformPropertyName("subnet_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SubnetId { get; set; }

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
    public TerraformBlock<AwsNatGatewayTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The association_id attribute.
    /// </summary>
    [TerraformPropertyName("association_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AssociationId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "association_id");

    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    [TerraformPropertyName("network_interface_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NetworkInterfaceId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "network_interface_id");

    /// <summary>
    /// The public_ip attribute.
    /// </summary>
    [TerraformPropertyName("public_ip")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PublicIp => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "public_ip");

}
