using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public partial class AwsEc2TransitGatewayAttachmentDataSourceFilterBlock : TerraformBlockBase
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
/// Retrieves information about a aws_ec2_transit_gateway_attachment.
/// </summary>
public partial class AwsEc2TransitGatewayAttachmentDataSource : TerraformDataSource
{
    public AwsEc2TransitGatewayAttachmentDataSource(string name) : base("aws_ec2_transit_gateway_attachment", name)
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
    /// The transit_gateway_attachment_id attribute.
    /// </summary>
    [TerraformProperty("transit_gateway_attachment_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> TransitGatewayAttachmentId { get; set; }

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("filter")]
    public TerraformSet<TerraformBlock<AwsEc2TransitGatewayAttachmentDataSourceFilterBlock>>? Filter { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The association_state attribute.
    /// </summary>
    [TerraformProperty("association_state")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> AssociationState { get; }

    /// <summary>
    /// The association_transit_gateway_route_table_id attribute.
    /// </summary>
    [TerraformProperty("association_transit_gateway_route_table_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> AssociationTransitGatewayRouteTableId { get; }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    [TerraformProperty("resource_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ResourceId { get; }

    /// <summary>
    /// The resource_owner_id attribute.
    /// </summary>
    [TerraformProperty("resource_owner_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ResourceOwnerId { get; }

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    [TerraformProperty("resource_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ResourceType { get; }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> State { get; }

    /// <summary>
    /// The transit_gateway_id attribute.
    /// </summary>
    [TerraformProperty("transit_gateway_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> TransitGatewayId { get; }

    /// <summary>
    /// The transit_gateway_owner_id attribute.
    /// </summary>
    [TerraformProperty("transit_gateway_owner_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> TransitGatewayOwnerId { get; }

}
