using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public class AwsEc2TransitGatewayMulticastDomainDataSourceFilterBlock : ITerraformBlock
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
public class AwsEc2TransitGatewayMulticastDomainDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

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
    /// The transit_gateway_multicast_domain_id attribute.
    /// </summary>
    [TerraformPropertyName("transit_gateway_multicast_domain_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> TransitGatewayMulticastDomainId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "transit_gateway_multicast_domain_id");

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("filter")]
    public TerraformSet<TerraformBlock<AwsEc2TransitGatewayMulticastDomainDataSourceFilterBlock>>? Filter { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsEc2TransitGatewayMulticastDomainDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The associations attribute.
    /// </summary>
    [TerraformPropertyName("associations")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Associations => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "associations");

    /// <summary>
    /// The auto_accept_shared_associations attribute.
    /// </summary>
    [TerraformPropertyName("auto_accept_shared_associations")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AutoAcceptSharedAssociations => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "auto_accept_shared_associations");

    /// <summary>
    /// The igmpv2_support attribute.
    /// </summary>
    [TerraformPropertyName("igmpv2_support")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Igmpv2Support => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "igmpv2_support");

    /// <summary>
    /// The members attribute.
    /// </summary>
    [TerraformPropertyName("members")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Members => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "members");

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [TerraformPropertyName("owner_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OwnerId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "owner_id");

    /// <summary>
    /// The sources attribute.
    /// </summary>
    [TerraformPropertyName("sources")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Sources => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "sources");

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> State => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state");

    /// <summary>
    /// The static_sources_support attribute.
    /// </summary>
    [TerraformPropertyName("static_sources_support")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StaticSourcesSupport => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "static_sources_support");

    /// <summary>
    /// The transit_gateway_attachment_id attribute.
    /// </summary>
    [TerraformPropertyName("transit_gateway_attachment_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TransitGatewayAttachmentId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "transit_gateway_attachment_id");

    /// <summary>
    /// The transit_gateway_id attribute.
    /// </summary>
    [TerraformPropertyName("transit_gateway_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TransitGatewayId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "transit_gateway_id");

}
