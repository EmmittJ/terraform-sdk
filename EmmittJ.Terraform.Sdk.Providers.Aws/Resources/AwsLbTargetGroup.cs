using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_lb_target_group resource.
/// </summary>
public class AwsLbTargetGroup : TerraformResource
{
    public AwsLbTargetGroup(string name) : base("aws_lb_target_group", name)
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
    public bool? ConnectionTermination
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("connection_termination")?.Value;
        set => this.WithProperty("connection_termination", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The deregistration_delay attribute.
    /// </summary>
    public string? DeregistrationDelay
    {
        get => GetProperty<TerraformLiteralProperty<string>>("deregistration_delay")?.Value;
        set => this.WithProperty("deregistration_delay", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The ip_address_type attribute.
    /// </summary>
    public string? IpAddressType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ip_address_type")?.Value;
        set => this.WithProperty("ip_address_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The lambda_multi_value_headers_enabled attribute.
    /// </summary>
    public bool? LambdaMultiValueHeadersEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("lambda_multi_value_headers_enabled")?.Value;
        set => this.WithProperty("lambda_multi_value_headers_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The load_balancing_algorithm_type attribute.
    /// </summary>
    public string? LoadBalancingAlgorithmType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("load_balancing_algorithm_type")?.Value;
        set => this.WithProperty("load_balancing_algorithm_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The load_balancing_anomaly_mitigation attribute.
    /// </summary>
    public string? LoadBalancingAnomalyMitigation
    {
        get => GetProperty<TerraformLiteralProperty<string>>("load_balancing_anomaly_mitigation")?.Value;
        set => this.WithProperty("load_balancing_anomaly_mitigation", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The load_balancing_cross_zone_enabled attribute.
    /// </summary>
    public string? LoadBalancingCrossZoneEnabled
    {
        get => GetProperty<TerraformLiteralProperty<string>>("load_balancing_cross_zone_enabled")?.Value;
        set => this.WithProperty("load_balancing_cross_zone_enabled", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public string? NamePrefix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name_prefix")?.Value;
        set => this.WithProperty("name_prefix", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public double? Port
    {
        get => GetProperty<TerraformLiteralProperty<double>>("port")?.Value;
        set => this.WithProperty("port", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The preserve_client_ip attribute.
    /// </summary>
    public string? PreserveClientIp
    {
        get => GetProperty<TerraformLiteralProperty<string>>("preserve_client_ip")?.Value;
        set => this.WithProperty("preserve_client_ip", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public string? Protocol
    {
        get => GetProperty<TerraformLiteralProperty<string>>("protocol")?.Value;
        set => this.WithProperty("protocol", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The protocol_version attribute.
    /// </summary>
    public string? ProtocolVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("protocol_version")?.Value;
        set => this.WithProperty("protocol_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The proxy_protocol_v2 attribute.
    /// </summary>
    public bool? ProxyProtocolV2
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("proxy_protocol_v2")?.Value;
        set => this.WithProperty("proxy_protocol_v2", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The slow_start attribute.
    /// </summary>
    public double? SlowStart
    {
        get => GetProperty<TerraformLiteralProperty<double>>("slow_start")?.Value;
        set => this.WithProperty("slow_start", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// The target_type attribute.
    /// </summary>
    public string? TargetType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_type")?.Value;
        set => this.WithProperty("target_type", value == null ? null : new TerraformLiteralProperty<string>(value));
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
