using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_alb_target_group resource.
/// </summary>
public class AwsAlbTargetGroup : TerraformResource
{
    public AwsAlbTargetGroup(string name) : base("aws_alb_target_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("arn_suffix");
        this.DeclareOutput("load_balancer_arns");
    }

    /// <summary>
    /// The connection_termination attribute.
    /// </summary>
    public TerraformProperty<bool>? ConnectionTermination
    {
        get => GetProperty<TerraformProperty<bool>>("connection_termination");
        set => this.WithProperty("connection_termination", value);
    }

    /// <summary>
    /// The deregistration_delay attribute.
    /// </summary>
    public TerraformProperty<string>? DeregistrationDelay
    {
        get => GetProperty<TerraformProperty<string>>("deregistration_delay");
        set => this.WithProperty("deregistration_delay", value);
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
    /// The ip_address_type attribute.
    /// </summary>
    public TerraformProperty<string>? IpAddressType
    {
        get => GetProperty<TerraformProperty<string>>("ip_address_type");
        set => this.WithProperty("ip_address_type", value);
    }

    /// <summary>
    /// The lambda_multi_value_headers_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? LambdaMultiValueHeadersEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("lambda_multi_value_headers_enabled");
        set => this.WithProperty("lambda_multi_value_headers_enabled", value);
    }

    /// <summary>
    /// The load_balancing_algorithm_type attribute.
    /// </summary>
    public TerraformProperty<string>? LoadBalancingAlgorithmType
    {
        get => GetProperty<TerraformProperty<string>>("load_balancing_algorithm_type");
        set => this.WithProperty("load_balancing_algorithm_type", value);
    }

    /// <summary>
    /// The load_balancing_anomaly_mitigation attribute.
    /// </summary>
    public TerraformProperty<string>? LoadBalancingAnomalyMitigation
    {
        get => GetProperty<TerraformProperty<string>>("load_balancing_anomaly_mitigation");
        set => this.WithProperty("load_balancing_anomaly_mitigation", value);
    }

    /// <summary>
    /// The load_balancing_cross_zone_enabled attribute.
    /// </summary>
    public TerraformProperty<string>? LoadBalancingCrossZoneEnabled
    {
        get => GetProperty<TerraformProperty<string>>("load_balancing_cross_zone_enabled");
        set => this.WithProperty("load_balancing_cross_zone_enabled", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? NamePrefix
    {
        get => GetProperty<TerraformProperty<string>>("name_prefix");
        set => this.WithProperty("name_prefix", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformProperty<double>? Port
    {
        get => GetProperty<TerraformProperty<double>>("port");
        set => this.WithProperty("port", value);
    }

    /// <summary>
    /// The preserve_client_ip attribute.
    /// </summary>
    public TerraformProperty<string>? PreserveClientIp
    {
        get => GetProperty<TerraformProperty<string>>("preserve_client_ip");
        set => this.WithProperty("preserve_client_ip", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformProperty<string>? Protocol
    {
        get => GetProperty<TerraformProperty<string>>("protocol");
        set => this.WithProperty("protocol", value);
    }

    /// <summary>
    /// The protocol_version attribute.
    /// </summary>
    public TerraformProperty<string>? ProtocolVersion
    {
        get => GetProperty<TerraformProperty<string>>("protocol_version");
        set => this.WithProperty("protocol_version", value);
    }

    /// <summary>
    /// The proxy_protocol_v2 attribute.
    /// </summary>
    public TerraformProperty<bool>? ProxyProtocolV2
    {
        get => GetProperty<TerraformProperty<bool>>("proxy_protocol_v2");
        set => this.WithProperty("proxy_protocol_v2", value);
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
    /// The slow_start attribute.
    /// </summary>
    public TerraformProperty<double>? SlowStart
    {
        get => GetProperty<TerraformProperty<double>>("slow_start");
        set => this.WithProperty("slow_start", value);
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
    /// The target_type attribute.
    /// </summary>
    public TerraformProperty<string>? TargetType
    {
        get => GetProperty<TerraformProperty<string>>("target_type");
        set => this.WithProperty("target_type", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The arn_suffix attribute.
    /// </summary>
    public TerraformExpression ArnSuffix => this["arn_suffix"];

    /// <summary>
    /// The load_balancer_arns attribute.
    /// </summary>
    public TerraformExpression LoadBalancerArns => this["load_balancer_arns"];

}
