using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for certificate_configuration in AwsGameliftFleet.
/// Nesting mode: list
/// </summary>
public class AwsGameliftFleetCertificateConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "certificate_configuration";

    /// <summary>
    /// The certificate_type attribute.
    /// </summary>
    public TerraformValue<string>? CertificateType
    {
        get => new TerraformReference<string>(this, "certificate_type");
        set => SetArgument("certificate_type", value);
    }

}


/// <summary>
/// Block type for ec2_inbound_permission in AwsGameliftFleet.
/// Nesting mode: set
/// </summary>
public class AwsGameliftFleetEc2InboundPermissionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ec2_inbound_permission";

    /// <summary>
    /// The from_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FromPort is required")]
    public required TerraformValue<double> FromPort
    {
        get => new TerraformReference<double>(this, "from_port");
        set => SetArgument("from_port", value);
    }

    /// <summary>
    /// The ip_range attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpRange is required")]
    public required TerraformValue<string> IpRange
    {
        get => new TerraformReference<string>(this, "ip_range");
        set => SetArgument("ip_range", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformValue<string> Protocol
    {
        get => new TerraformReference<string>(this, "protocol");
        set => SetArgument("protocol", value);
    }

    /// <summary>
    /// The to_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ToPort is required")]
    public required TerraformValue<double> ToPort
    {
        get => new TerraformReference<double>(this, "to_port");
        set => SetArgument("to_port", value);
    }

}


/// <summary>
/// Block type for resource_creation_limit_policy in AwsGameliftFleet.
/// Nesting mode: list
/// </summary>
public class AwsGameliftFleetResourceCreationLimitPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "resource_creation_limit_policy";

    /// <summary>
    /// The new_game_sessions_per_creator attribute.
    /// </summary>
    public TerraformValue<double>? NewGameSessionsPerCreator
    {
        get => new TerraformReference<double>(this, "new_game_sessions_per_creator");
        set => SetArgument("new_game_sessions_per_creator", value);
    }

    /// <summary>
    /// The policy_period_in_minutes attribute.
    /// </summary>
    public TerraformValue<double>? PolicyPeriodInMinutes
    {
        get => new TerraformReference<double>(this, "policy_period_in_minutes");
        set => SetArgument("policy_period_in_minutes", value);
    }

}


/// <summary>
/// Block type for runtime_configuration in AwsGameliftFleet.
/// Nesting mode: list
/// </summary>
public class AwsGameliftFleetRuntimeConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "runtime_configuration";

    /// <summary>
    /// The game_session_activation_timeout_seconds attribute.
    /// </summary>
    public TerraformValue<double>? GameSessionActivationTimeoutSeconds
    {
        get => new TerraformReference<double>(this, "game_session_activation_timeout_seconds");
        set => SetArgument("game_session_activation_timeout_seconds", value);
    }

    /// <summary>
    /// The max_concurrent_game_session_activations attribute.
    /// </summary>
    public TerraformValue<double>? MaxConcurrentGameSessionActivations
    {
        get => new TerraformReference<double>(this, "max_concurrent_game_session_activations");
        set => SetArgument("max_concurrent_game_session_activations", value);
    }

    /// <summary>
    /// ServerProcess block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(50, ErrorMessage = "Maximum 50 ServerProcess block(s) allowed")]
    public TerraformList<AwsGameliftFleetRuntimeConfigurationBlockServerProcessBlock>? ServerProcess
    {
        get => GetArgument<TerraformList<AwsGameliftFleetRuntimeConfigurationBlockServerProcessBlock>>("server_process");
        set => SetArgument("server_process", value);
    }

}

/// <summary>
/// Block type for server_process in AwsGameliftFleetRuntimeConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsGameliftFleetRuntimeConfigurationBlockServerProcessBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "server_process";

    /// <summary>
    /// The concurrent_executions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConcurrentExecutions is required")]
    public required TerraformValue<double> ConcurrentExecutions
    {
        get => new TerraformReference<double>(this, "concurrent_executions");
        set => SetArgument("concurrent_executions", value);
    }

    /// <summary>
    /// The launch_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LaunchPath is required")]
    public required TerraformValue<string> LaunchPath
    {
        get => new TerraformReference<string>(this, "launch_path");
        set => SetArgument("launch_path", value);
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public TerraformValue<string>? Parameters
    {
        get => new TerraformReference<string>(this, "parameters");
        set => SetArgument("parameters", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsGameliftFleet.
/// Nesting mode: single
/// </summary>
public class AwsGameliftFleetTimeoutsBlock : TerraformBlock
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

}


/// <summary>
/// Represents a aws_gamelift_fleet Terraform resource.
/// Manages a aws_gamelift_fleet resource.
/// </summary>
public partial class AwsGameliftFleet(string name) : TerraformResource("aws_gamelift_fleet", name)
{
    /// <summary>
    /// The build_id attribute.
    /// </summary>
    public TerraformValue<string>? BuildId
    {
        get => new TerraformReference<string>(this, "build_id");
        set => SetArgument("build_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The ec2_instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Ec2InstanceType is required")]
    public required TerraformValue<string> Ec2InstanceType
    {
        get => new TerraformReference<string>(this, "ec2_instance_type");
        set => SetArgument("ec2_instance_type", value);
    }

    /// <summary>
    /// The fleet_type attribute.
    /// </summary>
    public TerraformValue<string>? FleetType
    {
        get => new TerraformReference<string>(this, "fleet_type");
        set => SetArgument("fleet_type", value);
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
    /// The instance_role_arn attribute.
    /// </summary>
    public TerraformValue<string>? InstanceRoleArn
    {
        get => new TerraformReference<string>(this, "instance_role_arn");
        set => SetArgument("instance_role_arn", value);
    }

    /// <summary>
    /// The metric_groups attribute.
    /// </summary>
    public TerraformList<string> MetricGroups
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "metric_groups").ResolveNodes(ctx));
        set => SetArgument("metric_groups", value);
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
    /// The new_game_session_protection_policy attribute.
    /// </summary>
    public TerraformValue<string>? NewGameSessionProtectionPolicy
    {
        get => new TerraformReference<string>(this, "new_game_session_protection_policy");
        set => SetArgument("new_game_session_protection_policy", value);
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
    /// The script_id attribute.
    /// </summary>
    public TerraformValue<string>? ScriptId
    {
        get => new TerraformReference<string>(this, "script_id");
        set => SetArgument("script_id", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The build_arn attribute.
    /// </summary>
    public TerraformValue<string> BuildArn
    {
        get => new TerraformReference<string>(this, "build_arn");
    }

    /// <summary>
    /// The log_paths attribute.
    /// </summary>
    public TerraformList<string> LogPaths
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "log_paths").ResolveNodes(ctx));
    }

    /// <summary>
    /// The operating_system attribute.
    /// </summary>
    public TerraformValue<string> OperatingSystem
    {
        get => new TerraformReference<string>(this, "operating_system");
    }

    /// <summary>
    /// The script_arn attribute.
    /// </summary>
    public TerraformValue<string> ScriptArn
    {
        get => new TerraformReference<string>(this, "script_arn");
    }

    /// <summary>
    /// CertificateConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CertificateConfiguration block(s) allowed")]
    public TerraformList<AwsGameliftFleetCertificateConfigurationBlock>? CertificateConfiguration
    {
        get => GetArgument<TerraformList<AwsGameliftFleetCertificateConfigurationBlock>>("certificate_configuration");
        set => SetArgument("certificate_configuration", value);
    }

    /// <summary>
    /// Ec2InboundPermission block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(50, ErrorMessage = "Maximum 50 Ec2InboundPermission block(s) allowed")]
    public TerraformSet<AwsGameliftFleetEc2InboundPermissionBlock>? Ec2InboundPermission
    {
        get => GetArgument<TerraformSet<AwsGameliftFleetEc2InboundPermissionBlock>>("ec2_inbound_permission");
        set => SetArgument("ec2_inbound_permission", value);
    }

    /// <summary>
    /// ResourceCreationLimitPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ResourceCreationLimitPolicy block(s) allowed")]
    public TerraformList<AwsGameliftFleetResourceCreationLimitPolicyBlock>? ResourceCreationLimitPolicy
    {
        get => GetArgument<TerraformList<AwsGameliftFleetResourceCreationLimitPolicyBlock>>("resource_creation_limit_policy");
        set => SetArgument("resource_creation_limit_policy", value);
    }

    /// <summary>
    /// RuntimeConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RuntimeConfiguration block(s) allowed")]
    public TerraformList<AwsGameliftFleetRuntimeConfigurationBlock>? RuntimeConfiguration
    {
        get => GetArgument<TerraformList<AwsGameliftFleetRuntimeConfigurationBlock>>("runtime_configuration");
        set => SetArgument("runtime_configuration", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsGameliftFleetTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsGameliftFleetTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
