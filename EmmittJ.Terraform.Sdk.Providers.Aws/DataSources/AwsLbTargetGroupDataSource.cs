using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_lb_target_group.
/// </summary>
public class AwsLbTargetGroupDataSource : TerraformDataSource
{
    public AwsLbTargetGroupDataSource(string name) : base("aws_lb_target_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn_suffix");
        this.DeclareOutput("connection_termination");
        this.DeclareOutput("deregistration_delay");
        this.DeclareOutput("health_check");
        this.DeclareOutput("lambda_multi_value_headers_enabled");
        this.DeclareOutput("load_balancer_arns");
        this.DeclareOutput("load_balancing_algorithm_type");
        this.DeclareOutput("load_balancing_cross_zone_enabled");
        this.DeclareOutput("port");
        this.DeclareOutput("preserve_client_ip");
        this.DeclareOutput("protocol");
        this.DeclareOutput("protocol_version");
        this.DeclareOutput("proxy_protocol_v2");
        this.DeclareOutput("slow_start");
        this.DeclareOutput("stickiness");
        this.DeclareOutput("target_type");
        this.DeclareOutput("vpc_id");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public string? Arn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("arn")?.Value;
        set => this.WithProperty("arn", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The load_balancing_anomaly_mitigation attribute.
    /// </summary>
    public string? LoadBalancingAnomalyMitigation
    {
        get => GetProperty<TerraformLiteralProperty<string>>("load_balancing_anomaly_mitigation")?.Value;
        set => this.WithProperty("load_balancing_anomaly_mitigation", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The arn_suffix attribute.
    /// </summary>
    public TerraformExpression ArnSuffix => this["arn_suffix"];

    /// <summary>
    /// The connection_termination attribute.
    /// </summary>
    public TerraformExpression ConnectionTermination => this["connection_termination"];

    /// <summary>
    /// The deregistration_delay attribute.
    /// </summary>
    public TerraformExpression DeregistrationDelay => this["deregistration_delay"];

    /// <summary>
    /// The health_check attribute.
    /// </summary>
    public TerraformExpression HealthCheck => this["health_check"];

    /// <summary>
    /// The lambda_multi_value_headers_enabled attribute.
    /// </summary>
    public TerraformExpression LambdaMultiValueHeadersEnabled => this["lambda_multi_value_headers_enabled"];

    /// <summary>
    /// The load_balancer_arns attribute.
    /// </summary>
    public TerraformExpression LoadBalancerArns => this["load_balancer_arns"];

    /// <summary>
    /// The load_balancing_algorithm_type attribute.
    /// </summary>
    public TerraformExpression LoadBalancingAlgorithmType => this["load_balancing_algorithm_type"];

    /// <summary>
    /// The load_balancing_cross_zone_enabled attribute.
    /// </summary>
    public TerraformExpression LoadBalancingCrossZoneEnabled => this["load_balancing_cross_zone_enabled"];

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformExpression Port => this["port"];

    /// <summary>
    /// The preserve_client_ip attribute.
    /// </summary>
    public TerraformExpression PreserveClientIp => this["preserve_client_ip"];

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformExpression Protocol => this["protocol"];

    /// <summary>
    /// The protocol_version attribute.
    /// </summary>
    public TerraformExpression ProtocolVersion => this["protocol_version"];

    /// <summary>
    /// The proxy_protocol_v2 attribute.
    /// </summary>
    public TerraformExpression ProxyProtocolV2 => this["proxy_protocol_v2"];

    /// <summary>
    /// The slow_start attribute.
    /// </summary>
    public TerraformExpression SlowStart => this["slow_start"];

    /// <summary>
    /// The stickiness attribute.
    /// </summary>
    public TerraformExpression Stickiness => this["stickiness"];

    /// <summary>
    /// The target_type attribute.
    /// </summary>
    public TerraformExpression TargetType => this["target_type"];

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformExpression VpcId => this["vpc_id"];

}
