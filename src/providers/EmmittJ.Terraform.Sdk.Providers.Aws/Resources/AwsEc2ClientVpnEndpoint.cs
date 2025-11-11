using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for authentication_options in .
/// Nesting mode: set
/// </summary>
public class AwsEc2ClientVpnEndpointAuthenticationOptionsBlock
{
    /// <summary>
    /// The active_directory_id attribute.
    /// </summary>
    [TerraformPropertyName("active_directory_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ActiveDirectoryId { get; set; }

    /// <summary>
    /// The root_certificate_chain_arn attribute.
    /// </summary>
    [TerraformPropertyName("root_certificate_chain_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RootCertificateChainArn { get; set; }

    /// <summary>
    /// The saml_provider_arn attribute.
    /// </summary>
    [TerraformPropertyName("saml_provider_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SamlProviderArn { get; set; }

    /// <summary>
    /// The self_service_saml_provider_arn attribute.
    /// </summary>
    [TerraformPropertyName("self_service_saml_provider_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SelfServiceSamlProviderArn { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for client_connect_options in .
/// Nesting mode: list
/// </summary>
public class AwsEc2ClientVpnEndpointClientConnectOptionsBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> Enabled { get; set; } = default!;

    /// <summary>
    /// The lambda_function_arn attribute.
    /// </summary>
    [TerraformPropertyName("lambda_function_arn")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> LambdaFunctionArn { get; set; } = default!;

}

/// <summary>
/// Block type for client_login_banner_options in .
/// Nesting mode: list
/// </summary>
public class AwsEc2ClientVpnEndpointClientLoginBannerOptionsBlock
{
    /// <summary>
    /// The banner_text attribute.
    /// </summary>
    [TerraformPropertyName("banner_text")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> BannerText { get; set; } = default!;

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> Enabled { get; set; } = default!;

}

/// <summary>
/// Block type for client_route_enforcement_options in .
/// Nesting mode: list
/// </summary>
public class AwsEc2ClientVpnEndpointClientRouteEnforcementOptionsBlock
{
    /// <summary>
    /// The enforced attribute.
    /// </summary>
    [TerraformPropertyName("enforced")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> Enforced { get; set; } = default!;

}

/// <summary>
/// Block type for connection_log_options in .
/// Nesting mode: list
/// </summary>
public class AwsEc2ClientVpnEndpointConnectionLogOptionsBlock
{
    /// <summary>
    /// The cloudwatch_log_group attribute.
    /// </summary>
    [TerraformPropertyName("cloudwatch_log_group")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CloudwatchLogGroup { get; set; }

    /// <summary>
    /// The cloudwatch_log_stream attribute.
    /// </summary>
    [TerraformPropertyName("cloudwatch_log_stream")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> CloudwatchLogStream { get; set; } = default!;

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformPropertyName("enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> Enabled { get; set; }

}

/// <summary>
/// Manages a aws_ec2_client_vpn_endpoint resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsEc2ClientVpnEndpoint : TerraformResource
{
    public AwsEc2ClientVpnEndpoint(string name) : base("aws_ec2_client_vpn_endpoint", name)
    {
    }

    /// <summary>
    /// The client_cidr_block attribute.
    /// </summary>
    [TerraformPropertyName("client_cidr_block")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ClientCidrBlock { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The disconnect_on_session_timeout attribute.
    /// </summary>
    [TerraformPropertyName("disconnect_on_session_timeout")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> DisconnectOnSessionTimeout { get; set; } = default!;

    /// <summary>
    /// The dns_servers attribute.
    /// </summary>
    [TerraformPropertyName("dns_servers")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? DnsServers { get; set; }

    /// <summary>
    /// The endpoint_ip_address_type attribute.
    /// </summary>
    [TerraformPropertyName("endpoint_ip_address_type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> EndpointIpAddressType { get; set; } = default!;

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
    /// The security_group_ids attribute.
    /// </summary>
    [TerraformPropertyName("security_group_ids")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformSet<string> SecurityGroupIds { get; set; } = default!;

    /// <summary>
    /// The self_service_portal attribute.
    /// </summary>
    [TerraformPropertyName("self_service_portal")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SelfServicePortal { get; set; }

    /// <summary>
    /// The server_certificate_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerCertificateArn is required")]
    [TerraformPropertyName("server_certificate_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ServerCertificateArn { get; set; }

    /// <summary>
    /// The session_timeout_hours attribute.
    /// </summary>
    [TerraformPropertyName("session_timeout_hours")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? SessionTimeoutHours { get; set; }

    /// <summary>
    /// The split_tunnel attribute.
    /// </summary>
    [TerraformPropertyName("split_tunnel")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? SplitTunnel { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// The traffic_ip_address_type attribute.
    /// </summary>
    [TerraformPropertyName("traffic_ip_address_type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> TrafficIpAddressType { get; set; } = default!;

    /// <summary>
    /// The transport_protocol attribute.
    /// </summary>
    [TerraformPropertyName("transport_protocol")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TransportProtocol { get; set; }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformPropertyName("vpc_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> VpcId { get; set; } = default!;

    /// <summary>
    /// The vpn_port attribute.
    /// </summary>
    [TerraformPropertyName("vpn_port")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? VpnPort { get; set; }

    /// <summary>
    /// Block for authentication_options.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthenticationOptions is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AuthenticationOptions block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(2, ErrorMessage = "Maximum 2 AuthenticationOptions block(s) allowed")]
    [TerraformPropertyName("authentication_options")]
    public TerraformSet<TerraformBlock<AwsEc2ClientVpnEndpointAuthenticationOptionsBlock>>? AuthenticationOptions { get; set; }

    /// <summary>
    /// Block for client_connect_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClientConnectOptions block(s) allowed")]
    [TerraformPropertyName("client_connect_options")]
    public TerraformList<TerraformBlock<AwsEc2ClientVpnEndpointClientConnectOptionsBlock>>? ClientConnectOptions { get; set; }

    /// <summary>
    /// Block for client_login_banner_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClientLoginBannerOptions block(s) allowed")]
    [TerraformPropertyName("client_login_banner_options")]
    public TerraformList<TerraformBlock<AwsEc2ClientVpnEndpointClientLoginBannerOptionsBlock>>? ClientLoginBannerOptions { get; set; }

    /// <summary>
    /// Block for client_route_enforcement_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClientRouteEnforcementOptions block(s) allowed")]
    [TerraformPropertyName("client_route_enforcement_options")]
    public TerraformList<TerraformBlock<AwsEc2ClientVpnEndpointClientRouteEnforcementOptionsBlock>>? ClientRouteEnforcementOptions { get; set; }

    /// <summary>
    /// Block for connection_log_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionLogOptions is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ConnectionLogOptions block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConnectionLogOptions block(s) allowed")]
    [TerraformPropertyName("connection_log_options")]
    public TerraformList<TerraformBlock<AwsEc2ClientVpnEndpointConnectionLogOptionsBlock>>? ConnectionLogOptions { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    [TerraformPropertyName("dns_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DnsName => new TerraformReference(this, "dns_name");

    /// <summary>
    /// The self_service_portal_url attribute.
    /// </summary>
    [TerraformPropertyName("self_service_portal_url")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SelfServicePortalUrl => new TerraformReference(this, "self_service_portal_url");

}
