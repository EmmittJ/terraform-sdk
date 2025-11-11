using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public class AwsEc2TransitGatewayAttachmentDataSourceFilterBlock
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
/// Retrieves information about a aws_ec2_transit_gateway_attachment.
/// </summary>
public class AwsEc2TransitGatewayAttachmentDataSource : TerraformDataSource
{
    public AwsEc2TransitGatewayAttachmentDataSource(string name) : base("aws_ec2_transit_gateway_attachment", name)
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
    /// The transit_gateway_attachment_id attribute.
    /// </summary>
    [TerraformPropertyName("transit_gateway_attachment_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> TransitGatewayAttachmentId { get; set; } = default!;

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("filter")]
    public TerraformSet<TerraformBlock<AwsEc2TransitGatewayAttachmentDataSourceFilterBlock>>? Filter { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The association_state attribute.
    /// </summary>
    [TerraformPropertyName("association_state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AssociationState => new TerraformReference(this, "association_state");

    /// <summary>
    /// The association_transit_gateway_route_table_id attribute.
    /// </summary>
    [TerraformPropertyName("association_transit_gateway_route_table_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AssociationTransitGatewayRouteTableId => new TerraformReference(this, "association_transit_gateway_route_table_id");

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    [TerraformPropertyName("resource_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ResourceId => new TerraformReference(this, "resource_id");

    /// <summary>
    /// The resource_owner_id attribute.
    /// </summary>
    [TerraformPropertyName("resource_owner_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ResourceOwnerId => new TerraformReference(this, "resource_owner_id");

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    [TerraformPropertyName("resource_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ResourceType => new TerraformReference(this, "resource_type");

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> State => new TerraformReference(this, "state");

    /// <summary>
    /// The transit_gateway_id attribute.
    /// </summary>
    [TerraformPropertyName("transit_gateway_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TransitGatewayId => new TerraformReference(this, "transit_gateway_id");

    /// <summary>
    /// The transit_gateway_owner_id attribute.
    /// </summary>
    [TerraformPropertyName("transit_gateway_owner_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TransitGatewayOwnerId => new TerraformReference(this, "transit_gateway_owner_id");

}
