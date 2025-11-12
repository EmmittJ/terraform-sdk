using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public partial class AwsVpnConnectionDataSourceFilterBlock() : TerraformBlock("filter")
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
/// Retrieves information about a aws_vpn_connection.
/// </summary>
public partial class AwsVpnConnectionDataSource : TerraformDataSource
{
    public AwsVpnConnectionDataSource(string name) : base("aws_vpn_connection", name)
    {
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The vpn_connection_id attribute.
    /// </summary>
    [TerraformProperty("vpn_connection_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> VpnConnectionId { get; set; }

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("filter")]
    public TerraformSet<AwsVpnConnectionDataSourceFilterBlock> Filter { get; set; } = new();

    /// <summary>
    /// The category attribute.
    /// </summary>
    [TerraformProperty("category")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Category { get; }

    /// <summary>
    /// The core_network_arn attribute.
    /// </summary>
    [TerraformProperty("core_network_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CoreNetworkArn { get; }

    /// <summary>
    /// The core_network_attachment_arn attribute.
    /// </summary>
    [TerraformProperty("core_network_attachment_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CoreNetworkAttachmentArn { get; }

    /// <summary>
    /// The customer_gateway_configuration attribute.
    /// </summary>
    [TerraformProperty("customer_gateway_configuration")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CustomerGatewayConfiguration { get; }

    /// <summary>
    /// The customer_gateway_id attribute.
    /// </summary>
    [TerraformProperty("customer_gateway_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CustomerGatewayId { get; }

    /// <summary>
    /// The gateway_association_state attribute.
    /// </summary>
    [TerraformProperty("gateway_association_state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> GatewayAssociationState { get; }

    /// <summary>
    /// The pre_shared_key_arn attribute.
    /// </summary>
    [TerraformProperty("pre_shared_key_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PreSharedKeyArn { get; }

    /// <summary>
    /// The routes attribute.
    /// </summary>
    [TerraformProperty("routes")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Routes { get; }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Tags { get; }

    /// <summary>
    /// The transit_gateway_id attribute.
    /// </summary>
    [TerraformProperty("transit_gateway_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> TransitGatewayId { get; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformProperty("type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Type { get; }

    /// <summary>
    /// The vgw_telemetries attribute.
    /// </summary>
    [TerraformProperty("vgw_telemetries")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> VgwTelemetries { get; }

    /// <summary>
    /// The vpn_gateway_id attribute.
    /// </summary>
    [TerraformProperty("vpn_gateway_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> VpnGatewayId { get; }

}
