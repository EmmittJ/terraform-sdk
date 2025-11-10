using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsLbTargetGroupDataSourceTimeoutsBlock : TerraformBlock
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
        SetOutput("arn_suffix");
        SetOutput("connection_termination");
        SetOutput("deregistration_delay");
        SetOutput("health_check");
        SetOutput("lambda_multi_value_headers_enabled");
        SetOutput("load_balancer_arns");
        SetOutput("load_balancing_algorithm_type");
        SetOutput("load_balancing_cross_zone_enabled");
        SetOutput("port");
        SetOutput("preserve_client_ip");
        SetOutput("protocol");
        SetOutput("protocol_version");
        SetOutput("proxy_protocol_v2");
        SetOutput("slow_start");
        SetOutput("stickiness");
        SetOutput("target_type");
        SetOutput("vpc_id");
        SetOutput("arn");
        SetOutput("id");
        SetOutput("load_balancing_anomaly_mitigation");
        SetOutput("name");
        SetOutput("region");
        SetOutput("tags");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformProperty<string> Arn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("arn");
        set => SetProperty("arn", value);
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
    /// The load_balancing_anomaly_mitigation attribute.
    /// </summary>
    public TerraformProperty<string> LoadBalancingAnomalyMitigation
    {
        get => GetRequiredOutput<TerraformProperty<string>>("load_balancing_anomaly_mitigation");
        set => SetProperty("load_balancing_anomaly_mitigation", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsLbTargetGroupDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
