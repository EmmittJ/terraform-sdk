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
    public string? ClientCidrBlock
    {
        get => GetProperty<TerraformLiteralProperty<string>>("client_cidr_block")?.Value;
        set => this.WithProperty("client_cidr_block", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The disconnect_on_session_timeout attribute.
    /// </summary>
    public bool? DisconnectOnSessionTimeout
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("disconnect_on_session_timeout")?.Value;
        set => this.WithProperty("disconnect_on_session_timeout", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The dns_servers attribute.
    /// </summary>
    public List<string>? DnsServers
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("dns_servers")?.Value;
        set => this.WithProperty("dns_servers", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The endpoint_ip_address_type attribute.
    /// </summary>
    public string? EndpointIpAddressType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("endpoint_ip_address_type")?.Value;
        set => this.WithProperty("endpoint_ip_address_type", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The security_group_ids attribute.
    /// </summary>
    public HashSet<string>? SecurityGroupIds
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("security_group_ids")?.Value;
        set => this.WithProperty("security_group_ids", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The self_service_portal attribute.
    /// </summary>
    public string? SelfServicePortal
    {
        get => GetProperty<TerraformLiteralProperty<string>>("self_service_portal")?.Value;
        set => this.WithProperty("self_service_portal", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The server_certificate_arn attribute.
    /// </summary>
    public string? ServerCertificateArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("server_certificate_arn")?.Value;
        set => this.WithProperty("server_certificate_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The session_timeout_hours attribute.
    /// </summary>
    public double? SessionTimeoutHours
    {
        get => GetProperty<TerraformLiteralProperty<double>>("session_timeout_hours")?.Value;
        set => this.WithProperty("session_timeout_hours", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The split_tunnel attribute.
    /// </summary>
    public bool? SplitTunnel
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("split_tunnel")?.Value;
        set => this.WithProperty("split_tunnel", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The traffic_ip_address_type attribute.
    /// </summary>
    public string? TrafficIpAddressType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("traffic_ip_address_type")?.Value;
        set => this.WithProperty("traffic_ip_address_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The transport_protocol attribute.
    /// </summary>
    public string? TransportProtocol
    {
        get => GetProperty<TerraformLiteralProperty<string>>("transport_protocol")?.Value;
        set => this.WithProperty("transport_protocol", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public string? VpcId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vpc_id")?.Value;
        set => this.WithProperty("vpc_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The vpn_port attribute.
    /// </summary>
    public double? VpnPort
    {
        get => GetProperty<TerraformLiteralProperty<double>>("vpn_port")?.Value;
        set => this.WithProperty("vpn_port", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
