using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public class AwsVpnConnectionDataSourceFilterBlock
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
/// Retrieves information about a aws_vpn_connection.
/// </summary>
public class AwsVpnConnectionDataSource : TerraformDataSource
{
    public AwsVpnConnectionDataSource(string name) : base("aws_vpn_connection", name)
    {
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The vpn_connection_id attribute.
    /// </summary>
    [TerraformPropertyName("vpn_connection_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> VpnConnectionId { get; set; } = default!;

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("filter")]
    public TerraformSet<TerraformBlock<AwsVpnConnectionDataSourceFilterBlock>>? Filter { get; set; }

    /// <summary>
    /// The category attribute.
    /// </summary>
    [TerraformPropertyName("category")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Category => new TerraformReference(this, "category");

    /// <summary>
    /// The core_network_arn attribute.
    /// </summary>
    [TerraformPropertyName("core_network_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CoreNetworkArn => new TerraformReference(this, "core_network_arn");

    /// <summary>
    /// The core_network_attachment_arn attribute.
    /// </summary>
    [TerraformPropertyName("core_network_attachment_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CoreNetworkAttachmentArn => new TerraformReference(this, "core_network_attachment_arn");

    /// <summary>
    /// The customer_gateway_configuration attribute.
    /// </summary>
    [TerraformPropertyName("customer_gateway_configuration")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CustomerGatewayConfiguration => new TerraformReference(this, "customer_gateway_configuration");

    /// <summary>
    /// The customer_gateway_id attribute.
    /// </summary>
    [TerraformPropertyName("customer_gateway_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CustomerGatewayId => new TerraformReference(this, "customer_gateway_id");

    /// <summary>
    /// The gateway_association_state attribute.
    /// </summary>
    [TerraformPropertyName("gateway_association_state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> GatewayAssociationState => new TerraformReference(this, "gateway_association_state");

    /// <summary>
    /// The pre_shared_key_arn attribute.
    /// </summary>
    [TerraformPropertyName("pre_shared_key_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PreSharedKeyArn => new TerraformReference(this, "pre_shared_key_arn");

    /// <summary>
    /// The routes attribute.
    /// </summary>
    [TerraformPropertyName("routes")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Routes => new TerraformReference(this, "routes");

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> State => new TerraformReference(this, "state");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Tags => new TerraformReference(this, "tags");

    /// <summary>
    /// The transit_gateway_id attribute.
    /// </summary>
    [TerraformPropertyName("transit_gateway_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TransitGatewayId => new TerraformReference(this, "transit_gateway_id");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Type => new TerraformReference(this, "type");

    /// <summary>
    /// The vgw_telemetries attribute.
    /// </summary>
    [TerraformPropertyName("vgw_telemetries")]
    // Output-only attribute - read-only reference
    public TerraformList<object> VgwTelemetries => new TerraformReference(this, "vgw_telemetries");

    /// <summary>
    /// The vpn_gateway_id attribute.
    /// </summary>
    [TerraformPropertyName("vpn_gateway_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> VpnGatewayId => new TerraformReference(this, "vpn_gateway_id");

}
