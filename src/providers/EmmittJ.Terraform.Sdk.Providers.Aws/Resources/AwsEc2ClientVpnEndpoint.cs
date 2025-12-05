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
        get => GetArgument<TerraformValue<string>>("active_directory_id");
        set => SetArgument("active_directory_id", value);
    }

    /// <summary>
    /// The root_certificate_chain_arn attribute.
    /// </summary>
    public TerraformValue<string>? RootCertificateChainArn
    {
        get => GetArgument<TerraformValue<string>>("root_certificate_chain_arn");
        set => SetArgument("root_certificate_chain_arn", value);
    }

    /// <summary>
    /// The saml_provider_arn attribute.
    /// </summary>
    public TerraformValue<string>? SamlProviderArn
    {
        get => GetArgument<TerraformValue<string>>("saml_provider_arn");
        set => SetArgument("saml_provider_arn", value);
    }

    /// <summary>
    /// The self_service_saml_provider_arn attribute.
    /// </summary>
    public TerraformValue<string>? SelfServiceSamlProviderArn
    {
        get => GetArgument<TerraformValue<string>>("self_service_saml_provider_arn");
        set => SetArgument("self_service_saml_provider_arn", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
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
        get => GetArgument<TerraformValue<bool>>("enabled") ?? CreateReference("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The lambda_function_arn attribute.
    /// </summary>
    public TerraformValue<string> LambdaFunctionArn
    {
        get => GetArgument<TerraformValue<string>>("lambda_function_arn") ?? CreateReference("lambda_function_arn");
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
        get => GetArgument<TerraformValue<string>>("banner_text") ?? CreateReference("banner_text");
        set => SetArgument("banner_text", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool> Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled") ?? CreateReference("enabled");
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
        get => GetArgument<TerraformValue<bool>>("enforced") ?? CreateReference("enforced");
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
        get => GetArgument<TerraformValue<string>>("cloudwatch_log_group");
        set => SetArgument("cloudwatch_log_group", value);
    }

    /// <summary>
    /// The cloudwatch_log_stream attribute.
    /// </summary>
    public TerraformValue<string> CloudwatchLogStream
    {
        get => GetArgument<TerraformValue<string>>("cloudwatch_log_stream") ?? CreateReference("cloudwatch_log_stream");
        set => SetArgument("cloudwatch_log_stream", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enabled");
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
        get => GetArgument<TerraformValue<string>>("client_cidr_block");
        set => SetArgument("client_cidr_block", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The disconnect_on_session_timeout attribute.
    /// </summary>
    public TerraformValue<bool> DisconnectOnSessionTimeout
    {
        get => GetArgument<TerraformValue<bool>>("disconnect_on_session_timeout") ?? CreateReference("disconnect_on_session_timeout");
        set => SetArgument("disconnect_on_session_timeout", value);
    }

    /// <summary>
    /// The dns_servers attribute.
    /// </summary>
    public TerraformList<string>? DnsServers
    {
        get => GetArgument<TerraformList<string>>("dns_servers");
        set => SetArgument("dns_servers", value);
    }

    /// <summary>
    /// The endpoint_ip_address_type attribute.
    /// </summary>
    public TerraformValue<string> EndpointIpAddressType
    {
        get => GetArgument<TerraformValue<string>>("endpoint_ip_address_type") ?? CreateReference("endpoint_ip_address_type");
        set => SetArgument("endpoint_ip_address_type", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public TerraformSet<string> SecurityGroupIds
    {
        get => GetArgument<TerraformSet<string>>("security_group_ids") ?? CreateReference("security_group_ids");
        set => SetArgument("security_group_ids", value);
    }

    /// <summary>
    /// The self_service_portal attribute.
    /// </summary>
    public TerraformValue<string>? SelfServicePortal
    {
        get => GetArgument<TerraformValue<string>>("self_service_portal");
        set => SetArgument("self_service_portal", value);
    }

    /// <summary>
    /// The server_certificate_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerCertificateArn is required")]
    public required TerraformValue<string> ServerCertificateArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("server_certificate_arn");
        set => SetArgument("server_certificate_arn", value);
    }

    /// <summary>
    /// The session_timeout_hours attribute.
    /// </summary>
    public TerraformValue<double>? SessionTimeoutHours
    {
        get => GetArgument<TerraformValue<double>>("session_timeout_hours");
        set => SetArgument("session_timeout_hours", value);
    }

    /// <summary>
    /// The split_tunnel attribute.
    /// </summary>
    public TerraformValue<bool>? SplitTunnel
    {
        get => GetArgument<TerraformValue<bool>>("split_tunnel");
        set => SetArgument("split_tunnel", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? CreateReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The traffic_ip_address_type attribute.
    /// </summary>
    public TerraformValue<string> TrafficIpAddressType
    {
        get => GetArgument<TerraformValue<string>>("traffic_ip_address_type") ?? CreateReference("traffic_ip_address_type");
        set => SetArgument("traffic_ip_address_type", value);
    }

    /// <summary>
    /// The transport_protocol attribute.
    /// </summary>
    public TerraformValue<string>? TransportProtocol
    {
        get => GetArgument<TerraformValue<string>>("transport_protocol");
        set => SetArgument("transport_protocol", value);
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformValue<string> VpcId
    {
        get => GetArgument<TerraformValue<string>>("vpc_id") ?? CreateReference("vpc_id");
        set => SetArgument("vpc_id", value);
    }

    /// <summary>
    /// The vpn_port attribute.
    /// </summary>
    public TerraformValue<double>? VpnPort
    {
        get => GetArgument<TerraformValue<double>>("vpn_port");
        set => SetArgument("vpn_port", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    public TerraformValue<string> DnsName
        => CreateReference("dns_name");

    /// <summary>
    /// The self_service_portal_url attribute.
    /// </summary>
    public TerraformValue<string> SelfServicePortalUrl
        => CreateReference("self_service_portal_url");

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
