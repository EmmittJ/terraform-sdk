using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public class AwsEc2ClientVpnEndpointDataSourceFilterBlock
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
public class AwsEc2ClientVpnEndpointDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a aws_ec2_client_vpn_endpoint.
/// </summary>
public class AwsEc2ClientVpnEndpointDataSource : TerraformDataSource
{
    public AwsEc2ClientVpnEndpointDataSource(string name) : base("aws_ec2_client_vpn_endpoint", name)
    {
    }

    /// <summary>
    /// The client_vpn_endpoint_id attribute.
    /// </summary>
    [TerraformPropertyName("client_vpn_endpoint_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ClientVpnEndpointId { get; set; } = default!;

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
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("filter")]
    public TerraformSet<TerraformBlock<AwsEc2ClientVpnEndpointDataSourceFilterBlock>>? Filter { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsEc2ClientVpnEndpointDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The authentication_options attribute.
    /// </summary>
    [TerraformPropertyName("authentication_options")]
    // Output-only attribute - read-only reference
    public TerraformList<object> AuthenticationOptions => new TerraformReference(this, "authentication_options");

    /// <summary>
    /// The client_cidr_block attribute.
    /// </summary>
    [TerraformPropertyName("client_cidr_block")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ClientCidrBlock => new TerraformReference(this, "client_cidr_block");

    /// <summary>
    /// The client_connect_options attribute.
    /// </summary>
    [TerraformPropertyName("client_connect_options")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ClientConnectOptions => new TerraformReference(this, "client_connect_options");

    /// <summary>
    /// The client_login_banner_options attribute.
    /// </summary>
    [TerraformPropertyName("client_login_banner_options")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ClientLoginBannerOptions => new TerraformReference(this, "client_login_banner_options");

    /// <summary>
    /// The client_route_enforcement_options attribute.
    /// </summary>
    [TerraformPropertyName("client_route_enforcement_options")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ClientRouteEnforcementOptions => new TerraformReference(this, "client_route_enforcement_options");

    /// <summary>
    /// The connection_log_options attribute.
    /// </summary>
    [TerraformPropertyName("connection_log_options")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ConnectionLogOptions => new TerraformReference(this, "connection_log_options");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Description => new TerraformReference(this, "description");

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    [TerraformPropertyName("dns_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DnsName => new TerraformReference(this, "dns_name");

    /// <summary>
    /// The dns_servers attribute.
    /// </summary>
    [TerraformPropertyName("dns_servers")]
    // Output-only attribute - read-only reference
    public TerraformList<string> DnsServers => new TerraformReference(this, "dns_servers");

    /// <summary>
    /// The endpoint_ip_address_type attribute.
    /// </summary>
    [TerraformPropertyName("endpoint_ip_address_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> EndpointIpAddressType => new TerraformReference(this, "endpoint_ip_address_type");

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [TerraformPropertyName("security_group_ids")]
    // Output-only attribute - read-only reference
    public TerraformList<string> SecurityGroupIds => new TerraformReference(this, "security_group_ids");

    /// <summary>
    /// The self_service_portal attribute.
    /// </summary>
    [TerraformPropertyName("self_service_portal")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SelfServicePortal => new TerraformReference(this, "self_service_portal");

    /// <summary>
    /// The self_service_portal_url attribute.
    /// </summary>
    [TerraformPropertyName("self_service_portal_url")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SelfServicePortalUrl => new TerraformReference(this, "self_service_portal_url");

    /// <summary>
    /// The server_certificate_arn attribute.
    /// </summary>
    [TerraformPropertyName("server_certificate_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ServerCertificateArn => new TerraformReference(this, "server_certificate_arn");

    /// <summary>
    /// The session_timeout_hours attribute.
    /// </summary>
    [TerraformPropertyName("session_timeout_hours")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> SessionTimeoutHours => new TerraformReference(this, "session_timeout_hours");

    /// <summary>
    /// The split_tunnel attribute.
    /// </summary>
    [TerraformPropertyName("split_tunnel")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> SplitTunnel => new TerraformReference(this, "split_tunnel");

    /// <summary>
    /// The traffic_ip_address_type attribute.
    /// </summary>
    [TerraformPropertyName("traffic_ip_address_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TrafficIpAddressType => new TerraformReference(this, "traffic_ip_address_type");

    /// <summary>
    /// The transport_protocol attribute.
    /// </summary>
    [TerraformPropertyName("transport_protocol")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TransportProtocol => new TerraformReference(this, "transport_protocol");

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformPropertyName("vpc_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> VpcId => new TerraformReference(this, "vpc_id");

    /// <summary>
    /// The vpn_port attribute.
    /// </summary>
    [TerraformPropertyName("vpn_port")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> VpnPort => new TerraformReference(this, "vpn_port");

}
