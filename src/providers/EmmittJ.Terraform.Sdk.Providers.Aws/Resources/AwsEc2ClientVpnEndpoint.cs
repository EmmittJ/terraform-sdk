using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for authentication_options in .
/// Nesting mode: set
/// </summary>
public class AwsEc2ClientVpnEndpointAuthenticationOptionsBlock : TerraformBlock
{
    /// <summary>
    /// The active_directory_id attribute.
    /// </summary>
    public TerraformProperty<string>? ActiveDirectoryId
    {
        set => SetProperty("active_directory_id", value);
    }

    /// <summary>
    /// The root_certificate_chain_arn attribute.
    /// </summary>
    public TerraformProperty<string>? RootCertificateChainArn
    {
        set => SetProperty("root_certificate_chain_arn", value);
    }

    /// <summary>
    /// The saml_provider_arn attribute.
    /// </summary>
    public TerraformProperty<string>? SamlProviderArn
    {
        set => SetProperty("saml_provider_arn", value);
    }

    /// <summary>
    /// The self_service_saml_provider_arn attribute.
    /// </summary>
    public TerraformProperty<string>? SelfServiceSamlProviderArn
    {
        set => SetProperty("self_service_saml_provider_arn", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
    }

}

/// <summary>
/// Block type for client_connect_options in .
/// Nesting mode: list
/// </summary>
public class AwsEc2ClientVpnEndpointClientConnectOptionsBlock : TerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// The lambda_function_arn attribute.
    /// </summary>
    public TerraformProperty<string>? LambdaFunctionArn
    {
        set => SetProperty("lambda_function_arn", value);
    }

}

/// <summary>
/// Block type for client_login_banner_options in .
/// Nesting mode: list
/// </summary>
public class AwsEc2ClientVpnEndpointClientLoginBannerOptionsBlock : TerraformBlock
{
    /// <summary>
    /// The banner_text attribute.
    /// </summary>
    public TerraformProperty<string>? BannerText
    {
        set => SetProperty("banner_text", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        set => SetProperty("enabled", value);
    }

}

/// <summary>
/// Block type for client_route_enforcement_options in .
/// Nesting mode: list
/// </summary>
public class AwsEc2ClientVpnEndpointClientRouteEnforcementOptionsBlock : TerraformBlock
{
    /// <summary>
    /// The enforced attribute.
    /// </summary>
    public TerraformProperty<bool>? Enforced
    {
        set => SetProperty("enforced", value);
    }

}

/// <summary>
/// Block type for connection_log_options in .
/// Nesting mode: list
/// </summary>
public class AwsEc2ClientVpnEndpointConnectionLogOptionsBlock : TerraformBlock
{
    /// <summary>
    /// The cloudwatch_log_group attribute.
    /// </summary>
    public TerraformProperty<string>? CloudwatchLogGroup
    {
        set => SetProperty("cloudwatch_log_group", value);
    }

    /// <summary>
    /// The cloudwatch_log_stream attribute.
    /// </summary>
    public TerraformProperty<string>? CloudwatchLogStream
    {
        set => SetProperty("cloudwatch_log_stream", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformProperty<bool> Enabled
    {
        set => SetProperty("enabled", value);
    }

}

/// <summary>
/// Manages a aws_ec2_client_vpn_endpoint resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsEc2ClientVpnEndpoint : TerraformResource
{
    public AwsEc2ClientVpnEndpoint(string name) : base("aws_ec2_client_vpn_endpoint", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("dns_name");
        SetOutput("self_service_portal_url");
        SetOutput("client_cidr_block");
        SetOutput("description");
        SetOutput("disconnect_on_session_timeout");
        SetOutput("dns_servers");
        SetOutput("endpoint_ip_address_type");
        SetOutput("id");
        SetOutput("region");
        SetOutput("security_group_ids");
        SetOutput("self_service_portal");
        SetOutput("server_certificate_arn");
        SetOutput("session_timeout_hours");
        SetOutput("split_tunnel");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("traffic_ip_address_type");
        SetOutput("transport_protocol");
        SetOutput("vpc_id");
        SetOutput("vpn_port");
    }

    /// <summary>
    /// The client_cidr_block attribute.
    /// </summary>
    public TerraformProperty<string> ClientCidrBlock
    {
        get => GetRequiredOutput<TerraformProperty<string>>("client_cidr_block");
        set => SetProperty("client_cidr_block", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The disconnect_on_session_timeout attribute.
    /// </summary>
    public TerraformProperty<bool> DisconnectOnSessionTimeout
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("disconnect_on_session_timeout");
        set => SetProperty("disconnect_on_session_timeout", value);
    }

    /// <summary>
    /// The dns_servers attribute.
    /// </summary>
    public List<TerraformProperty<string>> DnsServers
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("dns_servers");
        set => SetProperty("dns_servers", value);
    }

    /// <summary>
    /// The endpoint_ip_address_type attribute.
    /// </summary>
    public TerraformProperty<string> EndpointIpAddressType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("endpoint_ip_address_type");
        set => SetProperty("endpoint_ip_address_type", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> SecurityGroupIds
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("security_group_ids");
        set => SetProperty("security_group_ids", value);
    }

    /// <summary>
    /// The self_service_portal attribute.
    /// </summary>
    public TerraformProperty<string> SelfServicePortal
    {
        get => GetRequiredOutput<TerraformProperty<string>>("self_service_portal");
        set => SetProperty("self_service_portal", value);
    }

    /// <summary>
    /// The server_certificate_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerCertificateArn is required")]
    public required TerraformProperty<string> ServerCertificateArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("server_certificate_arn");
        set => SetProperty("server_certificate_arn", value);
    }

    /// <summary>
    /// The session_timeout_hours attribute.
    /// </summary>
    public TerraformProperty<double> SessionTimeoutHours
    {
        get => GetRequiredOutput<TerraformProperty<double>>("session_timeout_hours");
        set => SetProperty("session_timeout_hours", value);
    }

    /// <summary>
    /// The split_tunnel attribute.
    /// </summary>
    public TerraformProperty<bool> SplitTunnel
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("split_tunnel");
        set => SetProperty("split_tunnel", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// The traffic_ip_address_type attribute.
    /// </summary>
    public TerraformProperty<string> TrafficIpAddressType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("traffic_ip_address_type");
        set => SetProperty("traffic_ip_address_type", value);
    }

    /// <summary>
    /// The transport_protocol attribute.
    /// </summary>
    public TerraformProperty<string> TransportProtocol
    {
        get => GetRequiredOutput<TerraformProperty<string>>("transport_protocol");
        set => SetProperty("transport_protocol", value);
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformProperty<string> VpcId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("vpc_id");
        set => SetProperty("vpc_id", value);
    }

    /// <summary>
    /// The vpn_port attribute.
    /// </summary>
    public TerraformProperty<double> VpnPort
    {
        get => GetRequiredOutput<TerraformProperty<double>>("vpn_port");
        set => SetProperty("vpn_port", value);
    }

    /// <summary>
    /// Block for authentication_options.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthenticationOptions is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AuthenticationOptions block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(2, ErrorMessage = "Maximum 2 AuthenticationOptions block(s) allowed")]
    public HashSet<AwsEc2ClientVpnEndpointAuthenticationOptionsBlock>? AuthenticationOptions
    {
        set => SetProperty("authentication_options", value);
    }

    /// <summary>
    /// Block for client_connect_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClientConnectOptions block(s) allowed")]
    public List<AwsEc2ClientVpnEndpointClientConnectOptionsBlock>? ClientConnectOptions
    {
        set => SetProperty("client_connect_options", value);
    }

    /// <summary>
    /// Block for client_login_banner_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClientLoginBannerOptions block(s) allowed")]
    public List<AwsEc2ClientVpnEndpointClientLoginBannerOptionsBlock>? ClientLoginBannerOptions
    {
        set => SetProperty("client_login_banner_options", value);
    }

    /// <summary>
    /// Block for client_route_enforcement_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClientRouteEnforcementOptions block(s) allowed")]
    public List<AwsEc2ClientVpnEndpointClientRouteEnforcementOptionsBlock>? ClientRouteEnforcementOptions
    {
        set => SetProperty("client_route_enforcement_options", value);
    }

    /// <summary>
    /// Block for connection_log_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionLogOptions is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ConnectionLogOptions block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConnectionLogOptions block(s) allowed")]
    public List<AwsEc2ClientVpnEndpointConnectionLogOptionsBlock>? ConnectionLogOptions
    {
        set => SetProperty("connection_log_options", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    public TerraformExpression DnsName => this["dns_name"];

    /// <summary>
    /// The self_service_portal_url attribute.
    /// </summary>
    public TerraformExpression SelfServicePortalUrl => this["self_service_portal_url"];

}
