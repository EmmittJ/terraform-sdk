using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public class AwsEc2ClientVpnEndpointDataSourceFilterBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    public HashSet<TerraformProperty<string>>? Values
    {
        set => SetProperty("values", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsEc2ClientVpnEndpointDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a aws_ec2_client_vpn_endpoint.
/// </summary>
public class AwsEc2ClientVpnEndpointDataSource : TerraformDataSource
{
    public AwsEc2ClientVpnEndpointDataSource(string name) : base("aws_ec2_client_vpn_endpoint", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("authentication_options");
        SetOutput("client_cidr_block");
        SetOutput("client_connect_options");
        SetOutput("client_login_banner_options");
        SetOutput("client_route_enforcement_options");
        SetOutput("connection_log_options");
        SetOutput("description");
        SetOutput("dns_name");
        SetOutput("dns_servers");
        SetOutput("endpoint_ip_address_type");
        SetOutput("security_group_ids");
        SetOutput("self_service_portal");
        SetOutput("self_service_portal_url");
        SetOutput("server_certificate_arn");
        SetOutput("session_timeout_hours");
        SetOutput("split_tunnel");
        SetOutput("traffic_ip_address_type");
        SetOutput("transport_protocol");
        SetOutput("vpc_id");
        SetOutput("vpn_port");
        SetOutput("client_vpn_endpoint_id");
        SetOutput("id");
        SetOutput("region");
        SetOutput("tags");
    }

    /// <summary>
    /// The client_vpn_endpoint_id attribute.
    /// </summary>
    public TerraformProperty<string> ClientVpnEndpointId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("client_vpn_endpoint_id");
        set => SetProperty("client_vpn_endpoint_id", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsEc2ClientVpnEndpointDataSourceFilterBlock>? Filter
    {
        set => SetProperty("filter", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsEc2ClientVpnEndpointDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The authentication_options attribute.
    /// </summary>
    public TerraformExpression AuthenticationOptions => this["authentication_options"];

    /// <summary>
    /// The client_cidr_block attribute.
    /// </summary>
    public TerraformExpression ClientCidrBlock => this["client_cidr_block"];

    /// <summary>
    /// The client_connect_options attribute.
    /// </summary>
    public TerraformExpression ClientConnectOptions => this["client_connect_options"];

    /// <summary>
    /// The client_login_banner_options attribute.
    /// </summary>
    public TerraformExpression ClientLoginBannerOptions => this["client_login_banner_options"];

    /// <summary>
    /// The client_route_enforcement_options attribute.
    /// </summary>
    public TerraformExpression ClientRouteEnforcementOptions => this["client_route_enforcement_options"];

    /// <summary>
    /// The connection_log_options attribute.
    /// </summary>
    public TerraformExpression ConnectionLogOptions => this["connection_log_options"];

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    public TerraformExpression DnsName => this["dns_name"];

    /// <summary>
    /// The dns_servers attribute.
    /// </summary>
    public TerraformExpression DnsServers => this["dns_servers"];

    /// <summary>
    /// The endpoint_ip_address_type attribute.
    /// </summary>
    public TerraformExpression EndpointIpAddressType => this["endpoint_ip_address_type"];

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public TerraformExpression SecurityGroupIds => this["security_group_ids"];

    /// <summary>
    /// The self_service_portal attribute.
    /// </summary>
    public TerraformExpression SelfServicePortal => this["self_service_portal"];

    /// <summary>
    /// The self_service_portal_url attribute.
    /// </summary>
    public TerraformExpression SelfServicePortalUrl => this["self_service_portal_url"];

    /// <summary>
    /// The server_certificate_arn attribute.
    /// </summary>
    public TerraformExpression ServerCertificateArn => this["server_certificate_arn"];

    /// <summary>
    /// The session_timeout_hours attribute.
    /// </summary>
    public TerraformExpression SessionTimeoutHours => this["session_timeout_hours"];

    /// <summary>
    /// The split_tunnel attribute.
    /// </summary>
    public TerraformExpression SplitTunnel => this["split_tunnel"];

    /// <summary>
    /// The traffic_ip_address_type attribute.
    /// </summary>
    public TerraformExpression TrafficIpAddressType => this["traffic_ip_address_type"];

    /// <summary>
    /// The transport_protocol attribute.
    /// </summary>
    public TerraformExpression TransportProtocol => this["transport_protocol"];

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformExpression VpcId => this["vpc_id"];

    /// <summary>
    /// The vpn_port attribute.
    /// </summary>
    public TerraformExpression VpnPort => this["vpn_port"];

}
