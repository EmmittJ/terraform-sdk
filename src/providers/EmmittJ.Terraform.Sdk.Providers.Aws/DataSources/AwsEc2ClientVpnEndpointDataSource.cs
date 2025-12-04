using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in AwsEc2ClientVpnEndpointDataSource.
/// Nesting mode: set
/// </summary>
public class AwsEc2ClientVpnEndpointDataSourceFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "filter";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public required TerraformSet<string> ValuesAttribute
    {
        get => GetRequiredArgument<TerraformSet<string>>("values");
        set => SetArgument("values", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsEc2ClientVpnEndpointDataSource.
/// Nesting mode: single
/// </summary>
public class AwsEc2ClientVpnEndpointDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a aws_ec2_client_vpn_endpoint Terraform data source.
/// Retrieves information about a aws_ec2_client_vpn_endpoint.
/// </summary>
public partial class AwsEc2ClientVpnEndpointDataSource(string name) : TerraformDataSource("aws_ec2_client_vpn_endpoint", name)
{
    /// <summary>
    /// The client_vpn_endpoint_id attribute.
    /// </summary>
    public TerraformValue<string> ClientVpnEndpointId
    {
        get => GetArgument<TerraformValue<string>>("client_vpn_endpoint_id") ?? AsReference("client_vpn_endpoint_id");
        set => SetArgument("client_vpn_endpoint_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => GetArgument<TerraformMap<string>>("tags") ?? AsReference("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The authentication_options attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> AuthenticationOptions
        => AsReference("authentication_options");

    /// <summary>
    /// The client_cidr_block attribute.
    /// </summary>
    public TerraformValue<string> ClientCidrBlock
        => AsReference("client_cidr_block");

    /// <summary>
    /// The client_connect_options attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ClientConnectOptions
        => AsReference("client_connect_options");

    /// <summary>
    /// The client_login_banner_options attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ClientLoginBannerOptions
        => AsReference("client_login_banner_options");

    /// <summary>
    /// The client_route_enforcement_options attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ClientRouteEnforcementOptions
        => AsReference("client_route_enforcement_options");

    /// <summary>
    /// The connection_log_options attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ConnectionLogOptions
        => AsReference("connection_log_options");

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    public TerraformValue<string> DnsName
        => AsReference("dns_name");

    /// <summary>
    /// The dns_servers attribute.
    /// </summary>
    public TerraformList<string> DnsServers
        => AsReference("dns_servers");

    /// <summary>
    /// The endpoint_ip_address_type attribute.
    /// </summary>
    public TerraformValue<string> EndpointIpAddressType
        => AsReference("endpoint_ip_address_type");

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public TerraformList<string> SecurityGroupIds
        => AsReference("security_group_ids");

    /// <summary>
    /// The self_service_portal attribute.
    /// </summary>
    public TerraformValue<string> SelfServicePortal
        => AsReference("self_service_portal");

    /// <summary>
    /// The self_service_portal_url attribute.
    /// </summary>
    public TerraformValue<string> SelfServicePortalUrl
        => AsReference("self_service_portal_url");

    /// <summary>
    /// The server_certificate_arn attribute.
    /// </summary>
    public TerraformValue<string> ServerCertificateArn
        => AsReference("server_certificate_arn");

    /// <summary>
    /// The session_timeout_hours attribute.
    /// </summary>
    public TerraformValue<double> SessionTimeoutHours
        => AsReference("session_timeout_hours");

    /// <summary>
    /// The split_tunnel attribute.
    /// </summary>
    public TerraformValue<bool> SplitTunnel
        => AsReference("split_tunnel");

    /// <summary>
    /// The traffic_ip_address_type attribute.
    /// </summary>
    public TerraformValue<string> TrafficIpAddressType
        => AsReference("traffic_ip_address_type");

    /// <summary>
    /// The transport_protocol attribute.
    /// </summary>
    public TerraformValue<string> TransportProtocol
        => AsReference("transport_protocol");

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformValue<string> VpcId
        => AsReference("vpc_id");

    /// <summary>
    /// The vpn_port attribute.
    /// </summary>
    public TerraformValue<double> VpnPort
        => AsReference("vpn_port");

    /// <summary>
    /// Filter block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsEc2ClientVpnEndpointDataSourceFilterBlock>? Filter
    {
        get => GetArgument<TerraformSet<AwsEc2ClientVpnEndpointDataSourceFilterBlock>>("filter");
        set => SetArgument("filter", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsEc2ClientVpnEndpointDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsEc2ClientVpnEndpointDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
