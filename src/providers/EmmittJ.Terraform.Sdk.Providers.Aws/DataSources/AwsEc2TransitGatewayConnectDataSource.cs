using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public partial class AwsEc2TransitGatewayConnectDataSourceFilterBlock() : TerraformBlock("filter")
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    [TerraformProperty("values")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> Values { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsEc2TransitGatewayConnectDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a aws_ec2_transit_gateway_connect.
/// </summary>
public partial class AwsEc2TransitGatewayConnectDataSource : TerraformDataSource
{
    public AwsEc2TransitGatewayConnectDataSource(string name) : base("aws_ec2_transit_gateway_connect", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// The transit_gateway_connect_id attribute.
    /// </summary>
    [TerraformProperty("transit_gateway_connect_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> TransitGatewayConnectId { get; set; }

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("filter")]
    public TerraformSet<AwsEc2TransitGatewayConnectDataSourceFilterBlock> Filter { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsEc2TransitGatewayConnectDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [TerraformProperty("protocol")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Protocol { get; }

    /// <summary>
    /// The transit_gateway_id attribute.
    /// </summary>
    [TerraformProperty("transit_gateway_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> TransitGatewayId { get; }

    /// <summary>
    /// The transport_attachment_id attribute.
    /// </summary>
    [TerraformProperty("transport_attachment_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> TransportAttachmentId { get; }

}
