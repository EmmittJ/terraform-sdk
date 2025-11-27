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
        get => new TerraformReference<string>(this, "read");
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
        get => new TerraformReference<string>(this, "arn");
        set => SetArgument("arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The load_balancing_anomaly_mitigation attribute.
    /// </summary>
    public TerraformValue<string> LoadBalancingAnomalyMitigation
    {
        get => new TerraformReference<string>(this, "load_balancing_anomaly_mitigation");
        set => SetArgument("load_balancing_anomaly_mitigation", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn_suffix attribute.
    /// </summary>
    public TerraformValue<string> ArnSuffix
    {
        get => new TerraformReference<string>(this, "arn_suffix");
    }

    /// <summary>
    /// The connection_termination attribute.
    /// </summary>
    public TerraformValue<bool> ConnectionTermination
    {
        get => new TerraformReference<bool>(this, "connection_termination");
    }

    /// <summary>
    /// The deregistration_delay attribute.
    /// </summary>
    public TerraformValue<string> DeregistrationDelay
    {
        get => new TerraformReference<string>(this, "deregistration_delay");
    }

    /// <summary>
    /// The health_check attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> HealthCheck
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "health_check").ResolveNodes(ctx));
    }

    /// <summary>
    /// The lambda_multi_value_headers_enabled attribute.
    /// </summary>
    public TerraformValue<bool> LambdaMultiValueHeadersEnabled
    {
        get => new TerraformReference<bool>(this, "lambda_multi_value_headers_enabled");
    }

    /// <summary>
    /// The load_balancer_arns attribute.
    /// </summary>
    public TerraformSet<string> LoadBalancerArns
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "load_balancer_arns").ResolveNodes(ctx));
    }

    /// <summary>
    /// The load_balancing_algorithm_type attribute.
    /// </summary>
    public TerraformValue<string> LoadBalancingAlgorithmType
    {
        get => new TerraformReference<string>(this, "load_balancing_algorithm_type");
    }

    /// <summary>
    /// The load_balancing_cross_zone_enabled attribute.
    /// </summary>
    public TerraformValue<string> LoadBalancingCrossZoneEnabled
    {
        get => new TerraformReference<string>(this, "load_balancing_cross_zone_enabled");
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double> Port
    {
        get => new TerraformReference<double>(this, "port");
    }

    /// <summary>
    /// The preserve_client_ip attribute.
    /// </summary>
    public TerraformValue<string> PreserveClientIp
    {
        get => new TerraformReference<string>(this, "preserve_client_ip");
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformValue<string> Protocol
    {
        get => new TerraformReference<string>(this, "protocol");
    }

    /// <summary>
    /// The protocol_version attribute.
    /// </summary>
    public TerraformValue<string> ProtocolVersion
    {
        get => new TerraformReference<string>(this, "protocol_version");
    }

    /// <summary>
    /// The proxy_protocol_v2 attribute.
    /// </summary>
    public TerraformValue<bool> ProxyProtocolV2
    {
        get => new TerraformReference<bool>(this, "proxy_protocol_v2");
    }

    /// <summary>
    /// The slow_start attribute.
    /// </summary>
    public TerraformValue<double> SlowStart
    {
        get => new TerraformReference<double>(this, "slow_start");
    }

    /// <summary>
    /// The stickiness attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Stickiness
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "stickiness").ResolveNodes(ctx));
    }

    /// <summary>
    /// The target_type attribute.
    /// </summary>
    public TerraformValue<string> TargetType
    {
        get => new TerraformReference<string>(this, "target_type");
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformValue<string> VpcId
    {
        get => new TerraformReference<string>(this, "vpc_id");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsLbTargetGroupDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsLbTargetGroupDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
