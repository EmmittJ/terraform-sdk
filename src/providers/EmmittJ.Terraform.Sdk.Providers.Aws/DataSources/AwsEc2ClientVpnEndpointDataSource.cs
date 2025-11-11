using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public partial class AwsEc2ClientVpnEndpointDataSourceFilterBlock : TerraformBlockBase
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
public partial class AwsEc2ClientVpnEndpointDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a aws_ec2_client_vpn_endpoint.
/// </summary>
public partial class AwsEc2ClientVpnEndpointDataSource : TerraformDataSource
{
    public AwsEc2ClientVpnEndpointDataSource(string name) : base("aws_ec2_client_vpn_endpoint", name)
    {
    }

    /// <summary>
    /// The client_vpn_endpoint_id attribute.
    /// </summary>
    [TerraformProperty("client_vpn_endpoint_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ClientVpnEndpointId { get; set; }

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
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("filter")]
    public partial TerraformSet<TerraformBlock<AwsEc2ClientVpnEndpointDataSourceFilterBlock>>? Filter { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsEc2ClientVpnEndpointDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The authentication_options attribute.
    /// </summary>
    [TerraformProperty("authentication_options")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> AuthenticationOptions { get; }

    /// <summary>
    /// The client_cidr_block attribute.
    /// </summary>
    [TerraformProperty("client_cidr_block")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ClientCidrBlock { get; }

    /// <summary>
    /// The client_connect_options attribute.
    /// </summary>
    [TerraformProperty("client_connect_options")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ClientConnectOptions { get; }

    /// <summary>
    /// The client_login_banner_options attribute.
    /// </summary>
    [TerraformProperty("client_login_banner_options")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ClientLoginBannerOptions { get; }

    /// <summary>
    /// The client_route_enforcement_options attribute.
    /// </summary>
    [TerraformProperty("client_route_enforcement_options")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ClientRouteEnforcementOptions { get; }

    /// <summary>
    /// The connection_log_options attribute.
    /// </summary>
    [TerraformProperty("connection_log_options")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ConnectionLogOptions { get; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Description { get; }

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    [TerraformProperty("dns_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DnsName { get; }

    /// <summary>
    /// The dns_servers attribute.
    /// </summary>
    [TerraformProperty("dns_servers")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> DnsServers { get; }

    /// <summary>
    /// The endpoint_ip_address_type attribute.
    /// </summary>
    [TerraformProperty("endpoint_ip_address_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> EndpointIpAddressType { get; }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [TerraformProperty("security_group_ids")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> SecurityGroupIds { get; }

    /// <summary>
    /// The self_service_portal attribute.
    /// </summary>
    [TerraformProperty("self_service_portal")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SelfServicePortal { get; }

    /// <summary>
    /// The self_service_portal_url attribute.
    /// </summary>
    [TerraformProperty("self_service_portal_url")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SelfServicePortalUrl { get; }

    /// <summary>
    /// The server_certificate_arn attribute.
    /// </summary>
    [TerraformProperty("server_certificate_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ServerCertificateArn { get; }

    /// <summary>
    /// The session_timeout_hours attribute.
    /// </summary>
    [TerraformProperty("session_timeout_hours")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> SessionTimeoutHours { get; }

    /// <summary>
    /// The split_tunnel attribute.
    /// </summary>
    [TerraformProperty("split_tunnel")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> SplitTunnel { get; }

    /// <summary>
    /// The traffic_ip_address_type attribute.
    /// </summary>
    [TerraformProperty("traffic_ip_address_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> TrafficIpAddressType { get; }

    /// <summary>
    /// The transport_protocol attribute.
    /// </summary>
    [TerraformProperty("transport_protocol")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> TransportProtocol { get; }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformProperty("vpc_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> VpcId { get; }

    /// <summary>
    /// The vpn_port attribute.
    /// </summary>
    [TerraformProperty("vpn_port")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> VpnPort { get; }

}
