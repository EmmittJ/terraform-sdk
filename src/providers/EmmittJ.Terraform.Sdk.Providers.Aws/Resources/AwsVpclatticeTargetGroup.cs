using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for config in AwsVpclatticeTargetGroup.
/// Nesting mode: list
/// </summary>
public class AwsVpclatticeTargetGroupConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "config";

    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    public TerraformValue<string>? IpAddressType
    {
        get => GetArgument<TerraformValue<string>>("ip_address_type");
        set => SetArgument("ip_address_type", value);
    }

    /// <summary>
    /// The lambda_event_structure_version attribute.
    /// </summary>
    public TerraformValue<string>? LambdaEventStructureVersion
    {
        get => GetArgument<TerraformValue<string>>("lambda_event_structure_version");
        set => SetArgument("lambda_event_structure_version", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double>? Port
    {
        get => GetArgument<TerraformValue<double>>("port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformValue<string>? Protocol
    {
        get => GetArgument<TerraformValue<string>>("protocol");
        set => SetArgument("protocol", value);
    }

    /// <summary>
    /// The protocol_version attribute.
    /// </summary>
    public TerraformValue<string>? ProtocolVersion
    {
        get => GetArgument<TerraformValue<string>>("protocol_version");
        set => SetArgument("protocol_version", value);
    }

    /// <summary>
    /// The vpc_identifier attribute.
    /// </summary>
    public TerraformValue<string>? VpcIdentifier
    {
        get => GetArgument<TerraformValue<string>>("vpc_identifier");
        set => SetArgument("vpc_identifier", value);
    }

    /// <summary>
    /// HealthCheck block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HealthCheck block(s) allowed")]
    public TerraformList<AwsVpclatticeTargetGroupConfigBlockHealthCheckBlock>? HealthCheck
    {
        get => GetArgument<TerraformList<AwsVpclatticeTargetGroupConfigBlockHealthCheckBlock>>("health_check");
        set => SetArgument("health_check", value);
    }

}

/// <summary>
/// Block type for health_check in AwsVpclatticeTargetGroupConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsVpclatticeTargetGroupConfigBlockHealthCheckBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "health_check";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The health_check_interval_seconds attribute.
    /// </summary>
    public TerraformValue<double>? HealthCheckIntervalSeconds
    {
        get => GetArgument<TerraformValue<double>>("health_check_interval_seconds");
        set => SetArgument("health_check_interval_seconds", value);
    }

    /// <summary>
    /// The health_check_timeout_seconds attribute.
    /// </summary>
    public TerraformValue<double>? HealthCheckTimeoutSeconds
    {
        get => GetArgument<TerraformValue<double>>("health_check_timeout_seconds");
        set => SetArgument("health_check_timeout_seconds", value);
    }

    /// <summary>
    /// The healthy_threshold_count attribute.
    /// </summary>
    public TerraformValue<double>? HealthyThresholdCount
    {
        get => GetArgument<TerraformValue<double>>("healthy_threshold_count");
        set => SetArgument("healthy_threshold_count", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformValue<string>? Path
    {
        get => GetArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double>? Port
    {
        get => GetArgument<TerraformValue<double>>("port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformValue<string>? Protocol
    {
        get => GetArgument<TerraformValue<string>>("protocol");
        set => SetArgument("protocol", value);
    }

    /// <summary>
    /// The protocol_version attribute.
    /// </summary>
    public TerraformValue<string>? ProtocolVersion
    {
        get => GetArgument<TerraformValue<string>>("protocol_version");
        set => SetArgument("protocol_version", value);
    }

    /// <summary>
    /// The unhealthy_threshold_count attribute.
    /// </summary>
    public TerraformValue<double>? UnhealthyThresholdCount
    {
        get => GetArgument<TerraformValue<double>>("unhealthy_threshold_count");
        set => SetArgument("unhealthy_threshold_count", value);
    }

    /// <summary>
    /// Matcher block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Matcher block(s) allowed")]
    public TerraformList<AwsVpclatticeTargetGroupConfigBlockHealthCheckBlockMatcherBlock>? Matcher
    {
        get => GetArgument<TerraformList<AwsVpclatticeTargetGroupConfigBlockHealthCheckBlockMatcherBlock>>("matcher");
        set => SetArgument("matcher", value);
    }

}

/// <summary>
/// Block type for matcher in AwsVpclatticeTargetGroupConfigBlockHealthCheckBlock.
/// Nesting mode: list
/// </summary>
public class AwsVpclatticeTargetGroupConfigBlockHealthCheckBlockMatcherBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "matcher";

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsVpclatticeTargetGroup.
/// Nesting mode: single
/// </summary>
public class AwsVpclatticeTargetGroupTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_vpclattice_target_group Terraform resource.
/// Manages a aws_vpclattice_target_group resource.
/// </summary>
public partial class AwsVpclatticeTargetGroup(string name) : TerraformResource("aws_vpclattice_target_group", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
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
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string>? TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => AsReference("status");

    /// <summary>
    /// Config block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Config block(s) allowed")]
    public TerraformList<AwsVpclatticeTargetGroupConfigBlock>? Config
    {
        get => GetArgument<TerraformList<AwsVpclatticeTargetGroupConfigBlock>>("config");
        set => SetArgument("config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsVpclatticeTargetGroupTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsVpclatticeTargetGroupTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
