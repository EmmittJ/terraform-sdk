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
        get => GetProperty<TerraformProperty<string>>("active_directory_id");
        set => WithProperty("active_directory_id", value);
    }

    /// <summary>
    /// The root_certificate_chain_arn attribute.
    /// </summary>
    public TerraformProperty<string>? RootCertificateChainArn
    {
        get => GetProperty<TerraformProperty<string>>("root_certificate_chain_arn");
        set => WithProperty("root_certificate_chain_arn", value);
    }

    /// <summary>
    /// The saml_provider_arn attribute.
    /// </summary>
    public TerraformProperty<string>? SamlProviderArn
    {
        get => GetProperty<TerraformProperty<string>>("saml_provider_arn");
        set => WithProperty("saml_provider_arn", value);
    }

    /// <summary>
    /// The self_service_saml_provider_arn attribute.
    /// </summary>
    public TerraformProperty<string>? SelfServiceSamlProviderArn
    {
        get => GetProperty<TerraformProperty<string>>("self_service_saml_provider_arn");
        set => WithProperty("self_service_saml_provider_arn", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
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
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => WithProperty("enabled", value);
    }

    /// <summary>
    /// The lambda_function_arn attribute.
    /// </summary>
    public TerraformProperty<string>? LambdaFunctionArn
    {
        get => GetProperty<TerraformProperty<string>>("lambda_function_arn");
        set => WithProperty("lambda_function_arn", value);
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
        get => GetProperty<TerraformProperty<string>>("banner_text");
        set => WithProperty("banner_text", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => WithProperty("enabled", value);
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
        get => GetProperty<TerraformProperty<bool>>("enforced");
        set => WithProperty("enforced", value);
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
        get => GetProperty<TerraformProperty<string>>("cloudwatch_log_group");
        set => WithProperty("cloudwatch_log_group", value);
    }

    /// <summary>
    /// The cloudwatch_log_stream attribute.
    /// </summary>
    public TerraformProperty<string>? CloudwatchLogStream
    {
        get => GetProperty<TerraformProperty<string>>("cloudwatch_log_stream");
        set => WithProperty("cloudwatch_log_stream", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformProperty<bool> Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => WithProperty("enabled", value);
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
        this.DeclareOutput("arn");
        this.DeclareOutput("dns_name");
        this.DeclareOutput("self_service_portal_url");
    }

    /// <summary>
    /// The client_cidr_block attribute.
    /// </summary>
    public TerraformProperty<string>? ClientCidrBlock
    {
        get => GetProperty<TerraformProperty<string>>("client_cidr_block");
        set => this.WithProperty("client_cidr_block", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The disconnect_on_session_timeout attribute.
    /// </summary>
    public TerraformProperty<bool>? DisconnectOnSessionTimeout
    {
        get => GetProperty<TerraformProperty<bool>>("disconnect_on_session_timeout");
        set => this.WithProperty("disconnect_on_session_timeout", value);
    }

    /// <summary>
    /// The dns_servers attribute.
    /// </summary>
    public List<TerraformProperty<string>>? DnsServers
    {
        get => GetProperty<List<TerraformProperty<string>>>("dns_servers");
        set => this.WithProperty("dns_servers", value);
    }

    /// <summary>
    /// The endpoint_ip_address_type attribute.
    /// </summary>
    public TerraformProperty<string>? EndpointIpAddressType
    {
        get => GetProperty<TerraformProperty<string>>("endpoint_ip_address_type");
        set => this.WithProperty("endpoint_ip_address_type", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SecurityGroupIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("security_group_ids");
        set => this.WithProperty("security_group_ids", value);
    }

    /// <summary>
    /// The self_service_portal attribute.
    /// </summary>
    public TerraformProperty<string>? SelfServicePortal
    {
        get => GetProperty<TerraformProperty<string>>("self_service_portal");
        set => this.WithProperty("self_service_portal", value);
    }

    /// <summary>
    /// The server_certificate_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerCertificateArn is required")]
    public required TerraformProperty<string> ServerCertificateArn
    {
        get => GetProperty<TerraformProperty<string>>("server_certificate_arn");
        set => this.WithProperty("server_certificate_arn", value);
    }

    /// <summary>
    /// The session_timeout_hours attribute.
    /// </summary>
    public TerraformProperty<double>? SessionTimeoutHours
    {
        get => GetProperty<TerraformProperty<double>>("session_timeout_hours");
        set => this.WithProperty("session_timeout_hours", value);
    }

    /// <summary>
    /// The split_tunnel attribute.
    /// </summary>
    public TerraformProperty<bool>? SplitTunnel
    {
        get => GetProperty<TerraformProperty<bool>>("split_tunnel");
        set => this.WithProperty("split_tunnel", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The traffic_ip_address_type attribute.
    /// </summary>
    public TerraformProperty<string>? TrafficIpAddressType
    {
        get => GetProperty<TerraformProperty<string>>("traffic_ip_address_type");
        set => this.WithProperty("traffic_ip_address_type", value);
    }

    /// <summary>
    /// The transport_protocol attribute.
    /// </summary>
    public TerraformProperty<string>? TransportProtocol
    {
        get => GetProperty<TerraformProperty<string>>("transport_protocol");
        set => this.WithProperty("transport_protocol", value);
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformProperty<string>? VpcId
    {
        get => GetProperty<TerraformProperty<string>>("vpc_id");
        set => this.WithProperty("vpc_id", value);
    }

    /// <summary>
    /// The vpn_port attribute.
    /// </summary>
    public TerraformProperty<double>? VpnPort
    {
        get => GetProperty<TerraformProperty<double>>("vpn_port");
        set => this.WithProperty("vpn_port", value);
    }

    /// <summary>
    /// Block for authentication_options.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AuthenticationOptions block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(2, ErrorMessage = "Maximum 2 AuthenticationOptions block(s) allowed")]
    public HashSet<AwsEc2ClientVpnEndpointAuthenticationOptionsBlock>? AuthenticationOptions
    {
        get => GetProperty<HashSet<AwsEc2ClientVpnEndpointAuthenticationOptionsBlock>>("authentication_options");
        set => this.WithProperty("authentication_options", value);
    }

    /// <summary>
    /// Block for client_connect_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClientConnectOptions block(s) allowed")]
    public List<AwsEc2ClientVpnEndpointClientConnectOptionsBlock>? ClientConnectOptions
    {
        get => GetProperty<List<AwsEc2ClientVpnEndpointClientConnectOptionsBlock>>("client_connect_options");
        set => this.WithProperty("client_connect_options", value);
    }

    /// <summary>
    /// Block for client_login_banner_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClientLoginBannerOptions block(s) allowed")]
    public List<AwsEc2ClientVpnEndpointClientLoginBannerOptionsBlock>? ClientLoginBannerOptions
    {
        get => GetProperty<List<AwsEc2ClientVpnEndpointClientLoginBannerOptionsBlock>>("client_login_banner_options");
        set => this.WithProperty("client_login_banner_options", value);
    }

    /// <summary>
    /// Block for client_route_enforcement_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClientRouteEnforcementOptions block(s) allowed")]
    public List<AwsEc2ClientVpnEndpointClientRouteEnforcementOptionsBlock>? ClientRouteEnforcementOptions
    {
        get => GetProperty<List<AwsEc2ClientVpnEndpointClientRouteEnforcementOptionsBlock>>("client_route_enforcement_options");
        set => this.WithProperty("client_route_enforcement_options", value);
    }

    /// <summary>
    /// Block for connection_log_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ConnectionLogOptions block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConnectionLogOptions block(s) allowed")]
    public List<AwsEc2ClientVpnEndpointConnectionLogOptionsBlock>? ConnectionLogOptions
    {
        get => GetProperty<List<AwsEc2ClientVpnEndpointConnectionLogOptionsBlock>>("connection_log_options");
        set => this.WithProperty("connection_log_options", value);
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
