using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public class AwsEc2TransitGatewayPeeringAttachmentDataSourceFilterBlock : ITerraformBlock
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
public class AwsEc2TransitGatewayPeeringAttachmentDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a aws_ec2_transit_gateway_peering_attachment.
/// </summary>
public class AwsEc2TransitGatewayPeeringAttachmentDataSource : TerraformDataSource
{
    public AwsEc2TransitGatewayPeeringAttachmentDataSource(string name) : base("aws_ec2_transit_gateway_peering_attachment", name)
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
    public TerraformSet<TerraformBlock<AwsEc2TransitGatewayPeeringAttachmentDataSourceFilterBlock>>? Filter { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsEc2TransitGatewayPeeringAttachmentDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The peer_account_id attribute.
    /// </summary>
    [TerraformPropertyName("peer_account_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PeerAccountId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "peer_account_id");

    /// <summary>
    /// The peer_region attribute.
    /// </summary>
    [TerraformPropertyName("peer_region")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PeerRegion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "peer_region");

    /// <summary>
    /// The peer_transit_gateway_id attribute.
    /// </summary>
    [TerraformPropertyName("peer_transit_gateway_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PeerTransitGatewayId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "peer_transit_gateway_id");

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> State => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state");

    /// <summary>
    /// The transit_gateway_id attribute.
    /// </summary>
    [TerraformPropertyName("transit_gateway_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TransitGatewayId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "transit_gateway_id");

}
