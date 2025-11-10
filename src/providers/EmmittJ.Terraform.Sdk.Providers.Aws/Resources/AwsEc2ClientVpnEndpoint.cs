using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for authentication_options in .
/// Nesting mode: set
/// </summary>
public class AwsEc2ClientVpnEndpointAuthenticationOptionsBlock : ITerraformBlock
{
    /// <summary>
    /// The active_directory_id attribute.
    /// </summary>
    [TerraformPropertyName("active_directory_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ActiveDirectoryId { get; set; }

    /// <summary>
    /// The root_certificate_chain_arn attribute.
    /// </summary>
    [TerraformPropertyName("root_certificate_chain_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RootCertificateChainArn { get; set; }

    /// <summary>
    /// The saml_provider_arn attribute.
    /// </summary>
    [TerraformPropertyName("saml_provider_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SamlProviderArn { get; set; }

    /// <summary>
    /// The self_service_saml_provider_arn attribute.
    /// </summary>
    [TerraformPropertyName("self_service_saml_provider_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SelfServiceSamlProviderArn { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

}

/// <summary>
/// Block type for client_connect_options in .
/// Nesting mode: list
/// </summary>
public class AwsEc2ClientVpnEndpointClientConnectOptionsBlock : ITerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> Enabled { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>("", "enabled");

    /// <summary>
    /// The lambda_function_arn attribute.
    /// </summary>
    [TerraformPropertyName("lambda_function_arn")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> LambdaFunctionArn { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "lambda_function_arn");

}

/// <summary>
/// Block type for client_login_banner_options in .
/// Nesting mode: list
/// </summary>
public class AwsEc2ClientVpnEndpointClientLoginBannerOptionsBlock : ITerraformBlock
{
    /// <summary>
    /// The banner_text attribute.
    /// </summary>
    [TerraformPropertyName("banner_text")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> BannerText { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "banner_text");

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> Enabled { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>("", "enabled");

}

/// <summary>
/// Block type for client_route_enforcement_options in .
/// Nesting mode: list
/// </summary>
public class AwsEc2ClientVpnEndpointClientRouteEnforcementOptionsBlock : ITerraformBlock
{
    /// <summary>
    /// The enforced attribute.
    /// </summary>
    [TerraformPropertyName("enforced")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> Enforced { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>("", "enforced");

}

/// <summary>
/// Block type for connection_log_options in .
/// Nesting mode: list
/// </summary>
public class AwsEc2ClientVpnEndpointConnectionLogOptionsBlock : ITerraformBlock
{
    /// <summary>
    /// The cloudwatch_log_group attribute.
    /// </summary>
    [TerraformPropertyName("cloudwatch_log_group")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CloudwatchLogGroup { get; set; }

    /// <summary>
    /// The cloudwatch_log_stream attribute.
    /// </summary>
    [TerraformPropertyName("cloudwatch_log_stream")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> CloudwatchLogStream { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "cloudwatch_log_stream");

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformPropertyName("enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> Enabled { get; set; }

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
    public TerraformProperty<TerraformProperty<string>>? ClientCidrBlock { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The disconnect_on_session_timeout attribute.
    /// </summary>
    [TerraformPropertyName("disconnect_on_session_timeout")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> DisconnectOnSessionTimeout { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "disconnect_on_session_timeout");

    /// <summary>
    /// The dns_servers attribute.
    /// </summary>
    [TerraformPropertyName("dns_servers")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? DnsServers { get; set; }

    /// <summary>
    /// The endpoint_ip_address_type attribute.
    /// </summary>
    [TerraformPropertyName("endpoint_ip_address_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> EndpointIpAddressType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "endpoint_ip_address_type");

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
    /// The security_group_ids attribute.
    /// </summary>
    [TerraformPropertyName("security_group_ids")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> SecurityGroupIds { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "security_group_ids");

    /// <summary>
    /// The self_service_portal attribute.
    /// </summary>
    [TerraformPropertyName("self_service_portal")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SelfServicePortal { get; set; }

    /// <summary>
    /// The server_certificate_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerCertificateArn is required")]
    [TerraformPropertyName("server_certificate_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ServerCertificateArn { get; set; }

    /// <summary>
    /// The session_timeout_hours attribute.
    /// </summary>
    [TerraformPropertyName("session_timeout_hours")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? SessionTimeoutHours { get; set; }

    /// <summary>
    /// The split_tunnel attribute.
    /// </summary>
    [TerraformPropertyName("split_tunnel")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? SplitTunnel { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// The traffic_ip_address_type attribute.
    /// </summary>
    [TerraformPropertyName("traffic_ip_address_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> TrafficIpAddressType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "traffic_ip_address_type");

    /// <summary>
    /// The transport_protocol attribute.
    /// </summary>
    [TerraformPropertyName("transport_protocol")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TransportProtocol { get; set; }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformPropertyName("vpc_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> VpcId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "vpc_id");

    /// <summary>
    /// The vpn_port attribute.
    /// </summary>
    [TerraformPropertyName("vpn_port")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? VpnPort { get; set; }

    /// <summary>
    /// Block for authentication_options.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthenticationOptions is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AuthenticationOptions block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(2, ErrorMessage = "Maximum 2 AuthenticationOptions block(s) allowed")]
    [TerraformPropertyName("authentication_options")]
    public TerraformSet<TerraformBlock<AwsEc2ClientVpnEndpointAuthenticationOptionsBlock>>? AuthenticationOptions { get; set; } = new();

    /// <summary>
    /// Block for client_connect_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClientConnectOptions block(s) allowed")]
    [TerraformPropertyName("client_connect_options")]
    public TerraformList<TerraformBlock<AwsEc2ClientVpnEndpointClientConnectOptionsBlock>>? ClientConnectOptions { get; set; } = new();

    /// <summary>
    /// Block for client_login_banner_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClientLoginBannerOptions block(s) allowed")]
    [TerraformPropertyName("client_login_banner_options")]
    public TerraformList<TerraformBlock<AwsEc2ClientVpnEndpointClientLoginBannerOptionsBlock>>? ClientLoginBannerOptions { get; set; } = new();

    /// <summary>
    /// Block for client_route_enforcement_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClientRouteEnforcementOptions block(s) allowed")]
    [TerraformPropertyName("client_route_enforcement_options")]
    public TerraformList<TerraformBlock<AwsEc2ClientVpnEndpointClientRouteEnforcementOptionsBlock>>? ClientRouteEnforcementOptions { get; set; } = new();

    /// <summary>
    /// Block for connection_log_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionLogOptions is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ConnectionLogOptions block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConnectionLogOptions block(s) allowed")]
    [TerraformPropertyName("connection_log_options")]
    public TerraformList<TerraformBlock<AwsEc2ClientVpnEndpointConnectionLogOptionsBlock>>? ConnectionLogOptions { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    [TerraformPropertyName("dns_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DnsName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "dns_name");

    /// <summary>
    /// The self_service_portal_url attribute.
    /// </summary>
    [TerraformPropertyName("self_service_portal_url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SelfServicePortalUrl => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "self_service_portal_url");

}
