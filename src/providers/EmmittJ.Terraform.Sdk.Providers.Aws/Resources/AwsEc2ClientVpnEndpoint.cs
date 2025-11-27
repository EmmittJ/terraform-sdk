using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for authentication_options in AwsEc2ClientVpnEndpoint.
/// Nesting mode: set
/// </summary>
public class AwsEc2ClientVpnEndpointAuthenticationOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "authentication_options";

    /// <summary>
    /// The active_directory_id attribute.
    /// </summary>
    public TerraformValue<string>? ActiveDirectoryId
    {
        get => new TerraformReference<string>(this, "active_directory_id");
        set => SetArgument("active_directory_id", value);
    }

    /// <summary>
    /// The root_certificate_chain_arn attribute.
    /// </summary>
    public TerraformValue<string>? RootCertificateChainArn
    {
        get => new TerraformReference<string>(this, "root_certificate_chain_arn");
        set => SetArgument("root_certificate_chain_arn", value);
    }

    /// <summary>
    /// The saml_provider_arn attribute.
    /// </summary>
    public TerraformValue<string>? SamlProviderArn
    {
        get => new TerraformReference<string>(this, "saml_provider_arn");
        set => SetArgument("saml_provider_arn", value);
    }

    /// <summary>
    /// The self_service_saml_provider_arn attribute.
    /// </summary>
    public TerraformValue<string>? SelfServiceSamlProviderArn
    {
        get => new TerraformReference<string>(this, "self_service_saml_provider_arn");
        set => SetArgument("self_service_saml_provider_arn", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for client_connect_options in AwsEc2ClientVpnEndpoint.
/// Nesting mode: list
/// </summary>
public class AwsEc2ClientVpnEndpointClientConnectOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "client_connect_options";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool> Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The lambda_function_arn attribute.
    /// </summary>
    public TerraformValue<string> LambdaFunctionArn
    {
        get => new TerraformReference<string>(this, "lambda_function_arn");
        set => SetArgument("lambda_function_arn", value);
    }

}


/// <summary>
/// Block type for client_login_banner_options in AwsEc2ClientVpnEndpoint.
/// Nesting mode: list
/// </summary>
public class AwsEc2ClientVpnEndpointClientLoginBannerOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "client_login_banner_options";

    /// <summary>
    /// The banner_text attribute.
    /// </summary>
    public TerraformValue<string> BannerText
    {
        get => new TerraformReference<string>(this, "banner_text");
        set => SetArgument("banner_text", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool> Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

}


/// <summary>
/// Block type for client_route_enforcement_options in AwsEc2ClientVpnEndpoint.
/// Nesting mode: list
/// </summary>
public class AwsEc2ClientVpnEndpointClientRouteEnforcementOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "client_route_enforcement_options";

    /// <summary>
    /// The enforced attribute.
    /// </summary>
    public TerraformValue<bool> Enforced
    {
        get => new TerraformReference<bool>(this, "enforced");
        set => SetArgument("enforced", value);
    }

}


/// <summary>
/// Block type for connection_log_options in AwsEc2ClientVpnEndpoint.
/// Nesting mode: list
/// </summary>
public class AwsEc2ClientVpnEndpointConnectionLogOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "connection_log_options";

    /// <summary>
    /// The cloudwatch_log_group attribute.
    /// </summary>
    public TerraformValue<string>? CloudwatchLogGroup
    {
        get => new TerraformReference<string>(this, "cloudwatch_log_group");
        set => SetArgument("cloudwatch_log_group", value);
    }

    /// <summary>
    /// The cloudwatch_log_stream attribute.
    /// </summary>
    public TerraformValue<string> CloudwatchLogStream
    {
        get => new TerraformReference<string>(this, "cloudwatch_log_stream");
        set => SetArgument("cloudwatch_log_stream", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

}


/// <summary>
/// Represents a aws_ec2_client_vpn_endpoint Terraform resource.
/// Manages a aws_ec2_client_vpn_endpoint resource.
/// </summary>
public partial class AwsEc2ClientVpnEndpoint(string name) : TerraformResource("aws_ec2_client_vpn_endpoint", name)
{
    /// <summary>
    /// The client_cidr_block attribute.
    /// </summary>
    public TerraformValue<string>? ClientCidrBlock
    {
        get => new TerraformReference<string>(this, "client_cidr_block");
        set => SetArgument("client_cidr_block", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The disconnect_on_session_timeout attribute.
    /// </summary>
    public TerraformValue<bool> DisconnectOnSessionTimeout
    {
        get => new TerraformReference<bool>(this, "disconnect_on_session_timeout");
        set => SetArgument("disconnect_on_session_timeout", value);
    }

    /// <summary>
    /// The dns_servers attribute.
    /// </summary>
    public TerraformList<string>? DnsServers
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "dns_servers").ResolveNodes(ctx));
        set => SetArgument("dns_servers", value);
    }

    /// <summary>
    /// The endpoint_ip_address_type attribute.
    /// </summary>
    public TerraformValue<string> EndpointIpAddressType
    {
        get => new TerraformReference<string>(this, "endpoint_ip_address_type");
        set => SetArgument("endpoint_ip_address_type", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public TerraformSet<string> SecurityGroupIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "security_group_ids").ResolveNodes(ctx));
        set => SetArgument("security_group_ids", value);
    }

    /// <summary>
    /// The self_service_portal attribute.
    /// </summary>
    public TerraformValue<string>? SelfServicePortal
    {
        get => new TerraformReference<string>(this, "self_service_portal");
        set => SetArgument("self_service_portal", value);
    }

    /// <summary>
    /// The server_certificate_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerCertificateArn is required")]
    public required TerraformValue<string> ServerCertificateArn
    {
        get => new TerraformReference<string>(this, "server_certificate_arn");
        set => SetArgument("server_certificate_arn", value);
    }

    /// <summary>
    /// The session_timeout_hours attribute.
    /// </summary>
    public TerraformValue<double>? SessionTimeoutHours
    {
        get => new TerraformReference<double>(this, "session_timeout_hours");
        set => SetArgument("session_timeout_hours", value);
    }

    /// <summary>
    /// The split_tunnel attribute.
    /// </summary>
    public TerraformValue<bool>? SplitTunnel
    {
        get => new TerraformReference<bool>(this, "split_tunnel");
        set => SetArgument("split_tunnel", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The traffic_ip_address_type attribute.
    /// </summary>
    public TerraformValue<string> TrafficIpAddressType
    {
        get => new TerraformReference<string>(this, "traffic_ip_address_type");
        set => SetArgument("traffic_ip_address_type", value);
    }

    /// <summary>
    /// The transport_protocol attribute.
    /// </summary>
    public TerraformValue<string>? TransportProtocol
    {
        get => new TerraformReference<string>(this, "transport_protocol");
        set => SetArgument("transport_protocol", value);
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformValue<string> VpcId
    {
        get => new TerraformReference<string>(this, "vpc_id");
        set => SetArgument("vpc_id", value);
    }

    /// <summary>
    /// The vpn_port attribute.
    /// </summary>
    public TerraformValue<double>? VpnPort
    {
        get => new TerraformReference<double>(this, "vpn_port");
        set => SetArgument("vpn_port", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    public TerraformValue<string> DnsName
    {
        get => new TerraformReference<string>(this, "dns_name");
    }

    /// <summary>
    /// The self_service_portal_url attribute.
    /// </summary>
    public TerraformValue<string> SelfServicePortalUrl
    {
        get => new TerraformReference<string>(this, "self_service_portal_url");
    }

    /// <summary>
    /// AuthenticationOptions block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthenticationOptions is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AuthenticationOptions block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(2, ErrorMessage = "Maximum 2 AuthenticationOptions block(s) allowed")]
    public required TerraformSet<AwsEc2ClientVpnEndpointAuthenticationOptionsBlock> AuthenticationOptions
    {
        get => GetRequiredArgument<TerraformSet<AwsEc2ClientVpnEndpointAuthenticationOptionsBlock>>("authentication_options");
        set => SetArgument("authentication_options", value);
    }

    /// <summary>
    /// ClientConnectOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClientConnectOptions block(s) allowed")]
    public TerraformList<AwsEc2ClientVpnEndpointClientConnectOptionsBlock>? ClientConnectOptions
    {
        get => GetArgument<TerraformList<AwsEc2ClientVpnEndpointClientConnectOptionsBlock>>("client_connect_options");
        set => SetArgument("client_connect_options", value);
    }

    /// <summary>
    /// ClientLoginBannerOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClientLoginBannerOptions block(s) allowed")]
    public TerraformList<AwsEc2ClientVpnEndpointClientLoginBannerOptionsBlock>? ClientLoginBannerOptions
    {
        get => GetArgument<TerraformList<AwsEc2ClientVpnEndpointClientLoginBannerOptionsBlock>>("client_login_banner_options");
        set => SetArgument("client_login_banner_options", value);
    }

    /// <summary>
    /// ClientRouteEnforcementOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClientRouteEnforcementOptions block(s) allowed")]
    public TerraformList<AwsEc2ClientVpnEndpointClientRouteEnforcementOptionsBlock>? ClientRouteEnforcementOptions
    {
        get => GetArgument<TerraformList<AwsEc2ClientVpnEndpointClientRouteEnforcementOptionsBlock>>("client_route_enforcement_options");
        set => SetArgument("client_route_enforcement_options", value);
    }

    /// <summary>
    /// ConnectionLogOptions block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionLogOptions is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ConnectionLogOptions block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConnectionLogOptions block(s) allowed")]
    public required TerraformList<AwsEc2ClientVpnEndpointConnectionLogOptionsBlock> ConnectionLogOptions
    {
        get => GetRequiredArgument<TerraformList<AwsEc2ClientVpnEndpointConnectionLogOptionsBlock>>("connection_log_options");
        set => SetArgument("connection_log_options", value);
    }

}
