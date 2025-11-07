using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ec2_client_vpn_endpoint resource.
/// </summary>
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
    public TerraformLiteralProperty<string>? ClientCidrBlock
    {
        get => GetProperty<TerraformLiteralProperty<string>>("client_cidr_block");
        set => this.WithProperty("client_cidr_block", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The disconnect_on_session_timeout attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? DisconnectOnSessionTimeout
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("disconnect_on_session_timeout");
        set => this.WithProperty("disconnect_on_session_timeout", value);
    }

    /// <summary>
    /// The dns_servers attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? DnsServers
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("dns_servers");
        set => this.WithProperty("dns_servers", value);
    }

    /// <summary>
    /// The endpoint_ip_address_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? EndpointIpAddressType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("endpoint_ip_address_type");
        set => this.WithProperty("endpoint_ip_address_type", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? SecurityGroupIds
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("security_group_ids");
        set => this.WithProperty("security_group_ids", value);
    }

    /// <summary>
    /// The self_service_portal attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SelfServicePortal
    {
        get => GetProperty<TerraformLiteralProperty<string>>("self_service_portal");
        set => this.WithProperty("self_service_portal", value);
    }

    /// <summary>
    /// The server_certificate_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ServerCertificateArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("server_certificate_arn");
        set => this.WithProperty("server_certificate_arn", value);
    }

    /// <summary>
    /// The session_timeout_hours attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? SessionTimeoutHours
    {
        get => GetProperty<TerraformLiteralProperty<double>>("session_timeout_hours");
        set => this.WithProperty("session_timeout_hours", value);
    }

    /// <summary>
    /// The split_tunnel attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? SplitTunnel
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("split_tunnel");
        set => this.WithProperty("split_tunnel", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The traffic_ip_address_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TrafficIpAddressType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("traffic_ip_address_type");
        set => this.WithProperty("traffic_ip_address_type", value);
    }

    /// <summary>
    /// The transport_protocol attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TransportProtocol
    {
        get => GetProperty<TerraformLiteralProperty<string>>("transport_protocol");
        set => this.WithProperty("transport_protocol", value);
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? VpcId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vpc_id");
        set => this.WithProperty("vpc_id", value);
    }

    /// <summary>
    /// The vpn_port attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? VpnPort
    {
        get => GetProperty<TerraformLiteralProperty<double>>("vpn_port");
        set => this.WithProperty("vpn_port", value);
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
