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
    public TerraformValue<string> Arn
    {
        get => GetArgument<TerraformValue<string>>("arn") ?? CreateReference("arn");
        set => SetArgument("arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The load_balancing_anomaly_mitigation attribute.
    /// </summary>
    public TerraformValue<string> LoadBalancingAnomalyMitigation
    {
        get => GetArgument<TerraformValue<string>>("load_balancing_anomaly_mitigation") ?? CreateReference("load_balancing_anomaly_mitigation");
        set => SetArgument("load_balancing_anomaly_mitigation", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name") ?? CreateReference("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => GetArgument<TerraformMap<string>>("tags") ?? CreateReference("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn_suffix attribute.
    /// </summary>
    public TerraformValue<string> ArnSuffix
        => CreateReference("arn_suffix");

    /// <summary>
    /// The connection_termination attribute.
    /// </summary>
    public TerraformValue<bool> ConnectionTermination
        => CreateReference("connection_termination");

    /// <summary>
    /// The deregistration_delay attribute.
    /// </summary>
    public TerraformValue<string> DeregistrationDelay
        => CreateReference("deregistration_delay");

    /// <summary>
    /// The health_check attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> HealthCheck
        => CreateReference("health_check");

    /// <summary>
    /// The lambda_multi_value_headers_enabled attribute.
    /// </summary>
    public TerraformValue<bool> LambdaMultiValueHeadersEnabled
        => CreateReference("lambda_multi_value_headers_enabled");

    /// <summary>
    /// The load_balancer_arns attribute.
    /// </summary>
    public TerraformSet<string> LoadBalancerArns
        => CreateReference("load_balancer_arns");

    /// <summary>
    /// The load_balancing_algorithm_type attribute.
    /// </summary>
    public TerraformValue<string> LoadBalancingAlgorithmType
        => CreateReference("load_balancing_algorithm_type");

    /// <summary>
    /// The load_balancing_cross_zone_enabled attribute.
    /// </summary>
    public TerraformValue<string> LoadBalancingCrossZoneEnabled
        => CreateReference("load_balancing_cross_zone_enabled");

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double> Port
        => CreateReference("port");

    /// <summary>
    /// The preserve_client_ip attribute.
    /// </summary>
    public TerraformValue<string> PreserveClientIp
        => CreateReference("preserve_client_ip");

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformValue<string> Protocol
        => CreateReference("protocol");

    /// <summary>
    /// The protocol_version attribute.
    /// </summary>
    public TerraformValue<string> ProtocolVersion
        => CreateReference("protocol_version");

    /// <summary>
    /// The proxy_protocol_v2 attribute.
    /// </summary>
    public TerraformValue<bool> ProxyProtocolV2
        => CreateReference("proxy_protocol_v2");

    /// <summary>
    /// The slow_start attribute.
    /// </summary>
    public TerraformValue<double> SlowStart
        => CreateReference("slow_start");

    /// <summary>
    /// The stickiness attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Stickiness
        => CreateReference("stickiness");

    /// <summary>
    /// The target_type attribute.
    /// </summary>
    public TerraformValue<string> TargetType
        => CreateReference("target_type");

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformValue<string> VpcId
        => CreateReference("vpc_id");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsLbTargetGroupDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsLbTargetGroupDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
