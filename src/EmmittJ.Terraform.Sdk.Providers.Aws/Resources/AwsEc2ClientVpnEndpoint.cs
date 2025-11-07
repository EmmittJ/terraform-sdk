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
    public TerraformProperty<List<string>>? DnsServers
    {
        get => GetProperty<TerraformProperty<List<string>>>("dns_servers");
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
    public TerraformProperty<HashSet<string>>? SecurityGroupIds
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("security_group_ids");
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
    public TerraformProperty<string>? ServerCertificateArn
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
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags_all");
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
