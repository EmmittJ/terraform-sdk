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
    public TerraformValue<string> IpAddressType
    {
        get => new TerraformReference<string>(this, "ip_address_type");
        set => SetArgument("ip_address_type", value);
    }

    /// <summary>
    /// The lambda_event_structure_version attribute.
    /// </summary>
    public TerraformValue<string> LambdaEventStructureVersion
    {
        get => new TerraformReference<string>(this, "lambda_event_structure_version");
        set => SetArgument("lambda_event_structure_version", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double> Port
    {
        get => new TerraformReference<double>(this, "port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformValue<string> Protocol
    {
        get => new TerraformReference<string>(this, "protocol");
        set => SetArgument("protocol", value);
    }

    /// <summary>
    /// The protocol_version attribute.
    /// </summary>
    public TerraformValue<string> ProtocolVersion
    {
        get => new TerraformReference<string>(this, "protocol_version");
        set => SetArgument("protocol_version", value);
    }

    /// <summary>
    /// The vpc_identifier attribute.
    /// </summary>
    public TerraformValue<string>? VpcIdentifier
    {
        get => new TerraformReference<string>(this, "vpc_identifier");
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
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The health_check_interval_seconds attribute.
    /// </summary>
    public TerraformValue<double>? HealthCheckIntervalSeconds
    {
        get => new TerraformReference<double>(this, "health_check_interval_seconds");
        set => SetArgument("health_check_interval_seconds", value);
    }

    /// <summary>
    /// The health_check_timeout_seconds attribute.
    /// </summary>
    public TerraformValue<double>? HealthCheckTimeoutSeconds
    {
        get => new TerraformReference<double>(this, "health_check_timeout_seconds");
        set => SetArgument("health_check_timeout_seconds", value);
    }

    /// <summary>
    /// The healthy_threshold_count attribute.
    /// </summary>
    public TerraformValue<double>? HealthyThresholdCount
    {
        get => new TerraformReference<double>(this, "healthy_threshold_count");
        set => SetArgument("healthy_threshold_count", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformValue<string>? Path
    {
        get => new TerraformReference<string>(this, "path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double> Port
    {
        get => new TerraformReference<double>(this, "port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformValue<string> Protocol
    {
        get => new TerraformReference<string>(this, "protocol");
        set => SetArgument("protocol", value);
    }

    /// <summary>
    /// The protocol_version attribute.
    /// </summary>
    public TerraformValue<string>? ProtocolVersion
    {
        get => new TerraformReference<string>(this, "protocol_version");
        set => SetArgument("protocol_version", value);
    }

    /// <summary>
    /// The unhealthy_threshold_count attribute.
    /// </summary>
    public TerraformValue<double>? UnhealthyThresholdCount
    {
        get => new TerraformReference<double>(this, "unhealthy_threshold_count");
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
        get => new TerraformReference<string>(this, "value");
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
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
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
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
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

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
