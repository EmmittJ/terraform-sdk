using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public class AwsEc2TransitGatewayVpcAttachmentDataSourceFilterBlock : ITerraformBlock
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
public class AwsEc2TransitGatewayVpcAttachmentDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a aws_ec2_transit_gateway_vpc_attachment.
/// </summary>
public class AwsEc2TransitGatewayVpcAttachmentDataSource : TerraformDataSource
{
    public AwsEc2TransitGatewayVpcAttachmentDataSource(string name) : base("aws_ec2_transit_gateway_vpc_attachment", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

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
    public TerraformSet<TerraformBlock<AwsEc2TransitGatewayVpcAttachmentDataSourceFilterBlock>>? Filter { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsEc2TransitGatewayVpcAttachmentDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The appliance_mode_support attribute.
    /// </summary>
    [TerraformPropertyName("appliance_mode_support")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ApplianceModeSupport => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "appliance_mode_support");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The dns_support attribute.
    /// </summary>
    [TerraformPropertyName("dns_support")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DnsSupport => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "dns_support");

    /// <summary>
    /// The ipv6_support attribute.
    /// </summary>
    [TerraformPropertyName("ipv6_support")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Ipv6Support => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ipv6_support");

    /// <summary>
    /// The security_group_referencing_support attribute.
    /// </summary>
    [TerraformPropertyName("security_group_referencing_support")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SecurityGroupReferencingSupport => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "security_group_referencing_support");

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [TerraformPropertyName("subnet_ids")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> SubnetIds => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "subnet_ids");

    /// <summary>
    /// The transit_gateway_id attribute.
    /// </summary>
    [TerraformPropertyName("transit_gateway_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TransitGatewayId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "transit_gateway_id");

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformPropertyName("vpc_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VpcId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "vpc_id");

    /// <summary>
    /// The vpc_owner_id attribute.
    /// </summary>
    [TerraformPropertyName("vpc_owner_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VpcOwnerId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "vpc_owner_id");

}
