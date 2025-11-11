using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public partial class AwsEc2TransitGatewayMulticastDomainDataSourceFilterBlock : TerraformBlockBase
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    [TerraformProperty("values")]
    // Required argument - source generator will implement get/set
    public required TerraformSet<string> Values { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsEc2TransitGatewayMulticastDomainDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a aws_ec2_transit_gateway_multicast_domain.
/// </summary>
public partial class AwsEc2TransitGatewayMulticastDomainDataSource : TerraformDataSource
{
    public AwsEc2TransitGatewayMulticastDomainDataSource(string name) : base("aws_ec2_transit_gateway_multicast_domain", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// The transit_gateway_multicast_domain_id attribute.
    /// </summary>
    [TerraformProperty("transit_gateway_multicast_domain_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> TransitGatewayMulticastDomainId { get; set; }

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("filter")]
    public TerraformSet<TerraformBlock<AwsEc2TransitGatewayMulticastDomainDataSourceFilterBlock>>? Filter { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AwsEc2TransitGatewayMulticastDomainDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The associations attribute.
    /// </summary>
    [TerraformProperty("associations")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Associations { get; }

    /// <summary>
    /// The auto_accept_shared_associations attribute.
    /// </summary>
    [TerraformProperty("auto_accept_shared_associations")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> AutoAcceptSharedAssociations { get; }

    /// <summary>
    /// The igmpv2_support attribute.
    /// </summary>
    [TerraformProperty("igmpv2_support")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Igmpv2Support { get; }

    /// <summary>
    /// The members attribute.
    /// </summary>
    [TerraformProperty("members")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Members { get; }

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [TerraformProperty("owner_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> OwnerId { get; }

    /// <summary>
    /// The sources attribute.
    /// </summary>
    [TerraformProperty("sources")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Sources { get; }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> State { get; }

    /// <summary>
    /// The static_sources_support attribute.
    /// </summary>
    [TerraformProperty("static_sources_support")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> StaticSourcesSupport { get; }

    /// <summary>
    /// The transit_gateway_attachment_id attribute.
    /// </summary>
    [TerraformProperty("transit_gateway_attachment_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> TransitGatewayAttachmentId { get; }

    /// <summary>
    /// The transit_gateway_id attribute.
    /// </summary>
    [TerraformProperty("transit_gateway_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> TransitGatewayId { get; }

}
