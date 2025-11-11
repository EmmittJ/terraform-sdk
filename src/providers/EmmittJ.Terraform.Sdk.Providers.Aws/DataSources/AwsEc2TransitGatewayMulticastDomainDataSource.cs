using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public class AwsEc2TransitGatewayMulticastDomainDataSourceFilterBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    [TerraformPropertyName("values")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> Values { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsEc2TransitGatewayMulticastDomainDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a aws_ec2_transit_gateway_multicast_domain.
/// </summary>
public class AwsEc2TransitGatewayMulticastDomainDataSource : TerraformDataSource
{
    public AwsEc2TransitGatewayMulticastDomainDataSource(string name) : base("aws_ec2_transit_gateway_multicast_domain", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Tags { get; set; } = default!;

    /// <summary>
    /// The transit_gateway_multicast_domain_id attribute.
    /// </summary>
    [TerraformPropertyName("transit_gateway_multicast_domain_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> TransitGatewayMulticastDomainId { get; set; } = default!;

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("filter")]
    public TerraformSet<TerraformBlock<AwsEc2TransitGatewayMulticastDomainDataSourceFilterBlock>>? Filter { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsEc2TransitGatewayMulticastDomainDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The associations attribute.
    /// </summary>
    [TerraformPropertyName("associations")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Associations => new TerraformReference(this, "associations");

    /// <summary>
    /// The auto_accept_shared_associations attribute.
    /// </summary>
    [TerraformPropertyName("auto_accept_shared_associations")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AutoAcceptSharedAssociations => new TerraformReference(this, "auto_accept_shared_associations");

    /// <summary>
    /// The igmpv2_support attribute.
    /// </summary>
    [TerraformPropertyName("igmpv2_support")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Igmpv2Support => new TerraformReference(this, "igmpv2_support");

    /// <summary>
    /// The members attribute.
    /// </summary>
    [TerraformPropertyName("members")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Members => new TerraformReference(this, "members");

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [TerraformPropertyName("owner_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OwnerId => new TerraformReference(this, "owner_id");

    /// <summary>
    /// The sources attribute.
    /// </summary>
    [TerraformPropertyName("sources")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Sources => new TerraformReference(this, "sources");

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> State => new TerraformReference(this, "state");

    /// <summary>
    /// The static_sources_support attribute.
    /// </summary>
    [TerraformPropertyName("static_sources_support")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> StaticSourcesSupport => new TerraformReference(this, "static_sources_support");

    /// <summary>
    /// The transit_gateway_attachment_id attribute.
    /// </summary>
    [TerraformPropertyName("transit_gateway_attachment_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TransitGatewayAttachmentId => new TerraformReference(this, "transit_gateway_attachment_id");

    /// <summary>
    /// The transit_gateway_id attribute.
    /// </summary>
    [TerraformPropertyName("transit_gateway_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TransitGatewayId => new TerraformReference(this, "transit_gateway_id");

}
