using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for authentication_options in .
/// Nesting mode: set
/// </summary>
public partial class AwsEc2ClientVpnEndpointAuthenticationOptionsBlock : TerraformBlockBase
{
    /// <summary>
    /// The active_directory_id attribute.
    /// </summary>
    [TerraformProperty("active_directory_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ActiveDirectoryId { get; set; }

    /// <summary>
    /// The root_certificate_chain_arn attribute.
    /// </summary>
    [TerraformProperty("root_certificate_chain_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RootCertificateChainArn { get; set; }

    /// <summary>
    /// The saml_provider_arn attribute.
    /// </summary>
    [TerraformProperty("saml_provider_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SamlProviderArn { get; set; }

    /// <summary>
    /// The self_service_saml_provider_arn attribute.
    /// </summary>
    [TerraformProperty("self_service_saml_provider_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SelfServiceSamlProviderArn { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for client_connect_options in .
/// Nesting mode: list
/// </summary>
public partial class AwsEc2ClientVpnEndpointClientConnectOptionsBlock : TerraformBlockBase
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> Enabled { get; set; }

    /// <summary>
    /// The lambda_function_arn attribute.
    /// </summary>
    [TerraformProperty("lambda_function_arn")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> LambdaFunctionArn { get; set; }

}

/// <summary>
/// Block type for client_login_banner_options in .
/// Nesting mode: list
/// </summary>
public partial class AwsEc2ClientVpnEndpointClientLoginBannerOptionsBlock : TerraformBlockBase
{
    /// <summary>
    /// The banner_text attribute.
    /// </summary>
    [TerraformProperty("banner_text")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> BannerText { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> Enabled { get; set; }

}

/// <summary>
/// Block type for client_route_enforcement_options in .
/// Nesting mode: list
/// </summary>
public partial class AwsEc2ClientVpnEndpointClientRouteEnforcementOptionsBlock : TerraformBlockBase
{
    /// <summary>
    /// The enforced attribute.
    /// </summary>
    [TerraformProperty("enforced")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> Enforced { get; set; }

}

/// <summary>
/// Block type for connection_log_options in .
/// Nesting mode: list
/// </summary>
public partial class AwsEc2ClientVpnEndpointConnectionLogOptionsBlock : TerraformBlockBase
{
    /// <summary>
    /// The cloudwatch_log_group attribute.
    /// </summary>
    [TerraformProperty("cloudwatch_log_group")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CloudwatchLogGroup { get; set; }

    /// <summary>
    /// The cloudwatch_log_stream attribute.
    /// </summary>
    [TerraformProperty("cloudwatch_log_stream")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> CloudwatchLogStream { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformProperty("enabled")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> Enabled { get; set; }

}

/// <summary>
/// Manages a aws_ec2_client_vpn_endpoint resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsEc2ClientVpnEndpoint : TerraformResource
{
    public AwsEc2ClientVpnEndpoint(string name) : base("aws_ec2_client_vpn_endpoint", name)
    {
    }

    /// <summary>
    /// The client_cidr_block attribute.
    /// </summary>
    [TerraformProperty("client_cidr_block")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ClientCidrBlock { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The disconnect_on_session_timeout attribute.
    /// </summary>
    [TerraformProperty("disconnect_on_session_timeout")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> DisconnectOnSessionTimeout { get; set; }

    /// <summary>
    /// The dns_servers attribute.
    /// </summary>
    [TerraformProperty("dns_servers")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? DnsServers { get; set; }

    /// <summary>
    /// The endpoint_ip_address_type attribute.
    /// </summary>
    [TerraformProperty("endpoint_ip_address_type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> EndpointIpAddressType { get; set; }

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
    /// The security_group_ids attribute.
    /// </summary>
    [TerraformProperty("security_group_ids")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> SecurityGroupIds { get; set; }

    /// <summary>
    /// The self_service_portal attribute.
    /// </summary>
    [TerraformProperty("self_service_portal")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SelfServicePortal { get; set; }

    /// <summary>
    /// The server_certificate_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerCertificateArn is required")]
    [TerraformProperty("server_certificate_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ServerCertificateArn { get; set; }

    /// <summary>
    /// The session_timeout_hours attribute.
    /// </summary>
    [TerraformProperty("session_timeout_hours")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? SessionTimeoutHours { get; set; }

    /// <summary>
    /// The split_tunnel attribute.
    /// </summary>
    [TerraformProperty("split_tunnel")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? SplitTunnel { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The traffic_ip_address_type attribute.
    /// </summary>
    [TerraformProperty("traffic_ip_address_type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> TrafficIpAddressType { get; set; }

    /// <summary>
    /// The transport_protocol attribute.
    /// </summary>
    [TerraformProperty("transport_protocol")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TransportProtocol { get; set; }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformProperty("vpc_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> VpcId { get; set; }

    /// <summary>
    /// The vpn_port attribute.
    /// </summary>
    [TerraformProperty("vpn_port")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? VpnPort { get; set; }

    /// <summary>
    /// Block for authentication_options.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthenticationOptions is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AuthenticationOptions block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(2, ErrorMessage = "Maximum 2 AuthenticationOptions block(s) allowed")]
    [TerraformProperty("authentication_options")]
    public partial TerraformSet<TerraformBlock<AwsEc2ClientVpnEndpointAuthenticationOptionsBlock>>? AuthenticationOptions { get; set; }

    /// <summary>
    /// Block for client_connect_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClientConnectOptions block(s) allowed")]
    [TerraformProperty("client_connect_options")]
    public partial TerraformList<TerraformBlock<AwsEc2ClientVpnEndpointClientConnectOptionsBlock>>? ClientConnectOptions { get; set; }

    /// <summary>
    /// Block for client_login_banner_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClientLoginBannerOptions block(s) allowed")]
    [TerraformProperty("client_login_banner_options")]
    public partial TerraformList<TerraformBlock<AwsEc2ClientVpnEndpointClientLoginBannerOptionsBlock>>? ClientLoginBannerOptions { get; set; }

    /// <summary>
    /// Block for client_route_enforcement_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClientRouteEnforcementOptions block(s) allowed")]
    [TerraformProperty("client_route_enforcement_options")]
    public partial TerraformList<TerraformBlock<AwsEc2ClientVpnEndpointClientRouteEnforcementOptionsBlock>>? ClientRouteEnforcementOptions { get; set; }

    /// <summary>
    /// Block for connection_log_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionLogOptions is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ConnectionLogOptions block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConnectionLogOptions block(s) allowed")]
    [TerraformProperty("connection_log_options")]
    public partial TerraformList<TerraformBlock<AwsEc2ClientVpnEndpointConnectionLogOptionsBlock>>? ConnectionLogOptions { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    [TerraformProperty("dns_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DnsName { get; }

    /// <summary>
    /// The self_service_portal_url attribute.
    /// </summary>
    [TerraformProperty("self_service_portal_url")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SelfServicePortalUrl { get; }

}
