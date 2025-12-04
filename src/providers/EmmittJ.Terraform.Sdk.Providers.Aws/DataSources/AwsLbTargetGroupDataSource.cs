using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsLbTargetGroupDataSource.
/// Nesting mode: single
/// </summary>
public class AwsLbTargetGroupDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a aws_lb_target_group Terraform data source.
/// Retrieves information about a aws_lb_target_group.
/// </summary>
public partial class AwsLbTargetGroupDataSource(string name) : TerraformDataSource("aws_lb_target_group", name)
{
    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string>? Arn
    {
        get => GetArgument<TerraformValue<string>>("arn");
        set => SetArgument("arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The load_balancing_anomaly_mitigation attribute.
    /// </summary>
    public TerraformValue<string>? LoadBalancingAnomalyMitigation
    {
        get => GetArgument<TerraformValue<string>>("load_balancing_anomaly_mitigation");
        set => SetArgument("load_balancing_anomaly_mitigation", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn_suffix attribute.
    /// </summary>
    public TerraformValue<string> ArnSuffix
        => AsReference("arn_suffix");

    /// <summary>
    /// The connection_termination attribute.
    /// </summary>
    public TerraformValue<bool> ConnectionTermination
        => AsReference("connection_termination");

    /// <summary>
    /// The deregistration_delay attribute.
    /// </summary>
    public TerraformValue<string> DeregistrationDelay
        => AsReference("deregistration_delay");

    /// <summary>
    /// The health_check attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> HealthCheck
        => AsReference("health_check");

    /// <summary>
    /// The lambda_multi_value_headers_enabled attribute.
    /// </summary>
    public TerraformValue<bool> LambdaMultiValueHeadersEnabled
        => AsReference("lambda_multi_value_headers_enabled");

    /// <summary>
    /// The load_balancer_arns attribute.
    /// </summary>
    public TerraformSet<string> LoadBalancerArns
        => AsReference("load_balancer_arns");

    /// <summary>
    /// The load_balancing_algorithm_type attribute.
    /// </summary>
    public TerraformValue<string> LoadBalancingAlgorithmType
        => AsReference("load_balancing_algorithm_type");

    /// <summary>
    /// The load_balancing_cross_zone_enabled attribute.
    /// </summary>
    public TerraformValue<string> LoadBalancingCrossZoneEnabled
        => AsReference("load_balancing_cross_zone_enabled");

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double> Port
        => AsReference("port");

    /// <summary>
    /// The preserve_client_ip attribute.
    /// </summary>
    public TerraformValue<string> PreserveClientIp
        => AsReference("preserve_client_ip");

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformValue<string> Protocol
        => AsReference("protocol");

    /// <summary>
    /// The protocol_version attribute.
    /// </summary>
    public TerraformValue<string> ProtocolVersion
        => AsReference("protocol_version");

    /// <summary>
    /// The proxy_protocol_v2 attribute.
    /// </summary>
    public TerraformValue<bool> ProxyProtocolV2
        => AsReference("proxy_protocol_v2");

    /// <summary>
    /// The slow_start attribute.
    /// </summary>
    public TerraformValue<double> SlowStart
        => AsReference("slow_start");

    /// <summary>
    /// The stickiness attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Stickiness
        => AsReference("stickiness");

    /// <summary>
    /// The target_type attribute.
    /// </summary>
    public TerraformValue<string> TargetType
        => AsReference("target_type");

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformValue<string> VpcId
        => AsReference("vpc_id");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsLbTargetGroupDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsLbTargetGroupDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
