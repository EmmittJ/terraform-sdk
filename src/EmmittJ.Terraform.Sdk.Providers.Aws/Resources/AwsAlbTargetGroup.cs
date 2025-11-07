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
    public TerraformLiteralProperty<bool>? ConnectionTermination
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("connection_termination");
        set => this.WithProperty("connection_termination", value);
    }

    /// <summary>
    /// The deregistration_delay attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DeregistrationDelay
    {
        get => GetProperty<TerraformLiteralProperty<string>>("deregistration_delay");
        set => this.WithProperty("deregistration_delay", value);
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
    /// The ip_address_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? IpAddressType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ip_address_type");
        set => this.WithProperty("ip_address_type", value);
    }

    /// <summary>
    /// The lambda_multi_value_headers_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? LambdaMultiValueHeadersEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("lambda_multi_value_headers_enabled");
        set => this.WithProperty("lambda_multi_value_headers_enabled", value);
    }

    /// <summary>
    /// The load_balancing_algorithm_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? LoadBalancingAlgorithmType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("load_balancing_algorithm_type");
        set => this.WithProperty("load_balancing_algorithm_type", value);
    }

    /// <summary>
    /// The load_balancing_anomaly_mitigation attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? LoadBalancingAnomalyMitigation
    {
        get => GetProperty<TerraformLiteralProperty<string>>("load_balancing_anomaly_mitigation");
        set => this.WithProperty("load_balancing_anomaly_mitigation", value);
    }

    /// <summary>
    /// The load_balancing_cross_zone_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? LoadBalancingCrossZoneEnabled
    {
        get => GetProperty<TerraformLiteralProperty<string>>("load_balancing_cross_zone_enabled");
        set => this.WithProperty("load_balancing_cross_zone_enabled", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? NamePrefix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name_prefix");
        set => this.WithProperty("name_prefix", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? Port
    {
        get => GetProperty<TerraformLiteralProperty<double>>("port");
        set => this.WithProperty("port", value);
    }

    /// <summary>
    /// The preserve_client_ip attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PreserveClientIp
    {
        get => GetProperty<TerraformLiteralProperty<string>>("preserve_client_ip");
        set => this.WithProperty("preserve_client_ip", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Protocol
    {
        get => GetProperty<TerraformLiteralProperty<string>>("protocol");
        set => this.WithProperty("protocol", value);
    }

    /// <summary>
    /// The protocol_version attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ProtocolVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("protocol_version");
        set => this.WithProperty("protocol_version", value);
    }

    /// <summary>
    /// The proxy_protocol_v2 attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? ProxyProtocolV2
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("proxy_protocol_v2");
        set => this.WithProperty("proxy_protocol_v2", value);
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
    /// The slow_start attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? SlowStart
    {
        get => GetProperty<TerraformLiteralProperty<double>>("slow_start");
        set => this.WithProperty("slow_start", value);
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
    /// The target_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TargetType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_type");
        set => this.WithProperty("target_type", value);
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
