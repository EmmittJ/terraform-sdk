using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for target_action in AwsRedshiftScheduledAction.
/// Nesting mode: list
/// </summary>
public class AwsRedshiftScheduledActionTargetActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "target_action";

    /// <summary>
    /// PauseCluster block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PauseCluster block(s) allowed")]
    public TerraformList<AwsRedshiftScheduledActionTargetActionBlockPauseClusterBlock>? PauseCluster
    {
        get => GetArgument<TerraformList<AwsRedshiftScheduledActionTargetActionBlockPauseClusterBlock>>("pause_cluster");
        set => SetArgument("pause_cluster", value);
    }

    /// <summary>
    /// ResizeCluster block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ResizeCluster block(s) allowed")]
    public TerraformList<AwsRedshiftScheduledActionTargetActionBlockResizeClusterBlock>? ResizeCluster
    {
        get => GetArgument<TerraformList<AwsRedshiftScheduledActionTargetActionBlockResizeClusterBlock>>("resize_cluster");
        set => SetArgument("resize_cluster", value);
    }

    /// <summary>
    /// ResumeCluster block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ResumeCluster block(s) allowed")]
    public TerraformList<AwsRedshiftScheduledActionTargetActionBlockResumeClusterBlock>? ResumeCluster
    {
        get => GetArgument<TerraformList<AwsRedshiftScheduledActionTargetActionBlockResumeClusterBlock>>("resume_cluster");
        set => SetArgument("resume_cluster", value);
    }

}

/// <summary>
/// Block type for pause_cluster in AwsRedshiftScheduledActionTargetActionBlock.
/// Nesting mode: list
/// </summary>
public class AwsRedshiftScheduledActionTargetActionBlockPauseClusterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "pause_cluster";

    /// <summary>
    /// The cluster_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterIdentifier is required")]
    public required TerraformValue<string> ClusterIdentifier
    {
        get => GetArgument<TerraformValue<string>>("cluster_identifier");
        set => SetArgument("cluster_identifier", value);
    }

}

/// <summary>
/// Block type for resize_cluster in AwsRedshiftScheduledActionTargetActionBlock.
/// Nesting mode: list
/// </summary>
public class AwsRedshiftScheduledActionTargetActionBlockResizeClusterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "resize_cluster";

    /// <summary>
    /// The classic attribute.
    /// </summary>
    public TerraformValue<bool>? Classic
    {
        get => GetArgument<TerraformValue<bool>>("classic");
        set => SetArgument("classic", value);
    }

    /// <summary>
    /// The cluster_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterIdentifier is required")]
    public required TerraformValue<string> ClusterIdentifier
    {
        get => GetArgument<TerraformValue<string>>("cluster_identifier");
        set => SetArgument("cluster_identifier", value);
    }

    /// <summary>
    /// The cluster_type attribute.
    /// </summary>
    public TerraformValue<string>? ClusterType
    {
        get => GetArgument<TerraformValue<string>>("cluster_type");
        set => SetArgument("cluster_type", value);
    }

    /// <summary>
    /// The node_type attribute.
    /// </summary>
    public TerraformValue<string>? NodeType
    {
        get => GetArgument<TerraformValue<string>>("node_type");
        set => SetArgument("node_type", value);
    }

    /// <summary>
    /// The number_of_nodes attribute.
    /// </summary>
    public TerraformValue<double>? NumberOfNodes
    {
        get => GetArgument<TerraformValue<double>>("number_of_nodes");
        set => SetArgument("number_of_nodes", value);
    }

}

/// <summary>
/// Block type for resume_cluster in AwsRedshiftScheduledActionTargetActionBlock.
/// Nesting mode: list
/// </summary>
public class AwsRedshiftScheduledActionTargetActionBlockResumeClusterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "resume_cluster";

    /// <summary>
    /// The cluster_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterIdentifier is required")]
    public required TerraformValue<string> ClusterIdentifier
    {
        get => GetArgument<TerraformValue<string>>("cluster_identifier");
        set => SetArgument("cluster_identifier", value);
    }

}


/// <summary>
/// Represents a aws_redshift_scheduled_action Terraform resource.
/// Manages a aws_redshift_scheduled_action resource.
/// </summary>
public partial class AwsRedshiftScheduledAction(string name) : TerraformResource("aws_redshift_scheduled_action", name)
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The enable attribute.
    /// </summary>
    public TerraformValue<bool>? Enable
    {
        get => GetArgument<TerraformValue<bool>>("enable");
        set => SetArgument("enable", value);
    }

    /// <summary>
    /// The end_time attribute.
    /// </summary>
    public TerraformValue<string>? EndTime
    {
        get => GetArgument<TerraformValue<string>>("end_time");
        set => SetArgument("end_time", value);
    }

    /// <summary>
    /// The iam_role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IamRole is required")]
    public required TerraformValue<string> IamRole
    {
        get => GetArgument<TerraformValue<string>>("iam_role");
        set => SetArgument("iam_role", value);
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
    /// The schedule attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Schedule is required")]
    public required TerraformValue<string> Schedule
    {
        get => GetArgument<TerraformValue<string>>("schedule");
        set => SetArgument("schedule", value);
    }

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    public TerraformValue<string>? StartTime
    {
        get => GetArgument<TerraformValue<string>>("start_time");
        set => SetArgument("start_time", value);
    }

    /// <summary>
    /// TargetAction block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetAction is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 TargetAction block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TargetAction block(s) allowed")]
    public required TerraformList<AwsRedshiftScheduledActionTargetActionBlock> TargetAction
    {
        get => GetRequiredArgument<TerraformList<AwsRedshiftScheduledActionTargetActionBlock>>("target_action");
        set => SetArgument("target_action", value);
    }

}
