using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public class AwsEc2ClientVpnEndpointDataSourceFilterBlock : ITerraformBlock
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
public class AwsEc2ClientVpnEndpointDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ClientVpnEndpointId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "client_vpn_endpoint_id");

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
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("filter")]
    public TerraformSet<TerraformBlock<AwsEc2ClientVpnEndpointDataSourceFilterBlock>>? Filter { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsEc2ClientVpnEndpointDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The authentication_options attribute.
    /// </summary>
    [TerraformPropertyName("authentication_options")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> AuthenticationOptions => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "authentication_options");

    /// <summary>
    /// The client_cidr_block attribute.
    /// </summary>
    [TerraformPropertyName("client_cidr_block")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ClientCidrBlock => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "client_cidr_block");

    /// <summary>
    /// The client_connect_options attribute.
    /// </summary>
    [TerraformPropertyName("client_connect_options")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ClientConnectOptions => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "client_connect_options");

    /// <summary>
    /// The client_login_banner_options attribute.
    /// </summary>
    [TerraformPropertyName("client_login_banner_options")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ClientLoginBannerOptions => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "client_login_banner_options");

    /// <summary>
    /// The client_route_enforcement_options attribute.
    /// </summary>
    [TerraformPropertyName("client_route_enforcement_options")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ClientRouteEnforcementOptions => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "client_route_enforcement_options");

    /// <summary>
    /// The connection_log_options attribute.
    /// </summary>
    [TerraformPropertyName("connection_log_options")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ConnectionLogOptions => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "connection_log_options");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    [TerraformPropertyName("dns_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DnsName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "dns_name");

    /// <summary>
    /// The dns_servers attribute.
    /// </summary>
    [TerraformPropertyName("dns_servers")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> DnsServers => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "dns_servers");

    /// <summary>
    /// The endpoint_ip_address_type attribute.
    /// </summary>
    [TerraformPropertyName("endpoint_ip_address_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EndpointIpAddressType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "endpoint_ip_address_type");

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [TerraformPropertyName("security_group_ids")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> SecurityGroupIds => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "security_group_ids");

    /// <summary>
    /// The self_service_portal attribute.
    /// </summary>
    [TerraformPropertyName("self_service_portal")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SelfServicePortal => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "self_service_portal");

    /// <summary>
    /// The self_service_portal_url attribute.
    /// </summary>
    [TerraformPropertyName("self_service_portal_url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SelfServicePortalUrl => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "self_service_portal_url");

    /// <summary>
    /// The server_certificate_arn attribute.
    /// </summary>
    [TerraformPropertyName("server_certificate_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ServerCertificateArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "server_certificate_arn");

    /// <summary>
    /// The session_timeout_hours attribute.
    /// </summary>
    [TerraformPropertyName("session_timeout_hours")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> SessionTimeoutHours => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "session_timeout_hours");

    /// <summary>
    /// The split_tunnel attribute.
    /// </summary>
    [TerraformPropertyName("split_tunnel")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> SplitTunnel => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "split_tunnel");

    /// <summary>
    /// The traffic_ip_address_type attribute.
    /// </summary>
    [TerraformPropertyName("traffic_ip_address_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TrafficIpAddressType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "traffic_ip_address_type");

    /// <summary>
    /// The transport_protocol attribute.
    /// </summary>
    [TerraformPropertyName("transport_protocol")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TransportProtocol => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "transport_protocol");

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformPropertyName("vpc_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VpcId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "vpc_id");

    /// <summary>
    /// The vpn_port attribute.
    /// </summary>
    [TerraformPropertyName("vpn_port")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> VpnPort => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "vpn_port");

}
