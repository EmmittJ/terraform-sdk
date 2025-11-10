using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public class AwsVpnConnectionDataSourceFilterBlock : ITerraformBlock
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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The vpn_connection_id attribute.
    /// </summary>
    [TerraformPropertyName("vpn_connection_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> VpnConnectionId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "vpn_connection_id");

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("filter")]
    public TerraformSet<TerraformBlock<AwsVpnConnectionDataSourceFilterBlock>>? Filter { get; set; } = new();

    /// <summary>
    /// The category attribute.
    /// </summary>
    [TerraformPropertyName("category")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Category => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "category");

    /// <summary>
    /// The core_network_arn attribute.
    /// </summary>
    [TerraformPropertyName("core_network_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CoreNetworkArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "core_network_arn");

    /// <summary>
    /// The core_network_attachment_arn attribute.
    /// </summary>
    [TerraformPropertyName("core_network_attachment_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CoreNetworkAttachmentArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "core_network_attachment_arn");

    /// <summary>
    /// The customer_gateway_configuration attribute.
    /// </summary>
    [TerraformPropertyName("customer_gateway_configuration")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CustomerGatewayConfiguration => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "customer_gateway_configuration");

    /// <summary>
    /// The customer_gateway_id attribute.
    /// </summary>
    [TerraformPropertyName("customer_gateway_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CustomerGatewayId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "customer_gateway_id");

    /// <summary>
    /// The gateway_association_state attribute.
    /// </summary>
    [TerraformPropertyName("gateway_association_state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> GatewayAssociationState => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "gateway_association_state");

    /// <summary>
    /// The pre_shared_key_arn attribute.
    /// </summary>
    [TerraformPropertyName("pre_shared_key_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PreSharedKeyArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "pre_shared_key_arn");

    /// <summary>
    /// The routes attribute.
    /// </summary>
    [TerraformPropertyName("routes")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Routes => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "routes");

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> State => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The transit_gateway_id attribute.
    /// </summary>
    [TerraformPropertyName("transit_gateway_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TransitGatewayId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "transit_gateway_id");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Type => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "type");

    /// <summary>
    /// The vgw_telemetries attribute.
    /// </summary>
    [TerraformPropertyName("vgw_telemetries")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> VgwTelemetries => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "vgw_telemetries");

    /// <summary>
    /// The vpn_gateway_id attribute.
    /// </summary>
    [TerraformPropertyName("vpn_gateway_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VpnGatewayId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "vpn_gateway_id");

}
