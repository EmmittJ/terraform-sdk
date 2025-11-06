using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

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
        this.DeclareOutput("arn");
        this.DeclareOutput("authentication_options");
        this.DeclareOutput("client_cidr_block");
        this.DeclareOutput("client_connect_options");
        this.DeclareOutput("client_login_banner_options");
        this.DeclareOutput("client_route_enforcement_options");
        this.DeclareOutput("connection_log_options");
        this.DeclareOutput("description");
        this.DeclareOutput("dns_name");
        this.DeclareOutput("dns_servers");
        this.DeclareOutput("endpoint_ip_address_type");
        this.DeclareOutput("security_group_ids");
        this.DeclareOutput("self_service_portal");
        this.DeclareOutput("self_service_portal_url");
        this.DeclareOutput("server_certificate_arn");
        this.DeclareOutput("session_timeout_hours");
        this.DeclareOutput("split_tunnel");
        this.DeclareOutput("traffic_ip_address_type");
        this.DeclareOutput("transport_protocol");
        this.DeclareOutput("vpc_id");
        this.DeclareOutput("vpn_port");
    }

    /// <summary>
    /// The client_vpn_endpoint_id attribute.
    /// </summary>
    public string? ClientVpnEndpointId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("client_vpn_endpoint_id")?.Value;
        set => this.WithProperty("client_vpn_endpoint_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
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
