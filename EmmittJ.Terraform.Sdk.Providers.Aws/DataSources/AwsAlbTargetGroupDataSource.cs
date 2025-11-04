using EmmittJ.Terraform.Sdk.Resources;
using EmmittJ.Terraform.Sdk.Context;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_alb_target_group.
/// </summary>
public class AwsAlbTargetGroupDataSource : TerraformDataSource
{
    public AwsAlbTargetGroupDataSource(string name) : base("aws_alb_target_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        DeclareOutput("arn_suffix");
        DeclareOutput("connection_termination");
        DeclareOutput("deregistration_delay");
        DeclareOutput("health_check");
        DeclareOutput("lambda_multi_value_headers_enabled");
        DeclareOutput("load_balancer_arns");
        DeclareOutput("load_balancing_algorithm_type");
        DeclareOutput("load_balancing_cross_zone_enabled");
        DeclareOutput("port");
        DeclareOutput("preserve_client_ip");
        DeclareOutput("protocol");
        DeclareOutput("protocol_version");
        DeclareOutput("proxy_protocol_v2");
        DeclareOutput("slow_start");
        DeclareOutput("stickiness");
        DeclareOutput("target_type");
        DeclareOutput("vpc_id");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public string? Arn
    {
        get => GetProperty<TerraformLiteralProperty&lt;string&gt;>("arn")?.Value;
        set => WithPropertyInternal("arn", value == null ? null : new TerraformLiteralProperty&lt;string&gt;(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty&lt;string&gt;>("id")?.Value;
        set => WithPropertyInternal("id", value == null ? null : new TerraformLiteralProperty&lt;string&gt;(value));
    }

    /// <summary>
    /// The load_balancing_anomaly_mitigation attribute.
    /// </summary>
    public string? LoadBalancingAnomalyMitigation
    {
        get => GetProperty<TerraformLiteralProperty&lt;string&gt;>("load_balancing_anomaly_mitigation")?.Value;
        set => WithPropertyInternal("load_balancing_anomaly_mitigation", value == null ? null : new TerraformLiteralProperty&lt;string&gt;(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty&lt;string&gt;>("name")?.Value;
        set => WithPropertyInternal("name", value == null ? null : new TerraformLiteralProperty&lt;string&gt;(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary&lt;string, string&gt;? Tags
    {
        get => GetProperty<TerraformLiteralProperty&lt;Dictionary&lt;string, string&gt;&gt;>("tags")?.Value;
        set => WithPropertyInternal("tags", value == null ? null : new TerraformLiteralProperty&lt;Dictionary&lt;string, string&gt;&gt;(value));
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
