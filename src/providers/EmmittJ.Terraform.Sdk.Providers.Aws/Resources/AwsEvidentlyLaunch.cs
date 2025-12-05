using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for groups in AwsEvidentlyLaunch.
/// Nesting mode: list
/// </summary>
public class AwsEvidentlyLaunchGroupsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "groups";

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The feature attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Feature is required")]
    public required TerraformValue<string> Feature
    {
        get => GetRequiredArgument<TerraformValue<string>>("feature");
        set => SetArgument("feature", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The variation attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Variation is required")]
    public required TerraformValue<string> Variation
    {
        get => GetRequiredArgument<TerraformValue<string>>("variation");
        set => SetArgument("variation", value);
    }

}


/// <summary>
/// Block type for metric_monitors in AwsEvidentlyLaunch.
/// Nesting mode: list
/// </summary>
public class AwsEvidentlyLaunchMetricMonitorsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "metric_monitors";

    /// <summary>
    /// MetricDefinition block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricDefinition is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 MetricDefinition block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MetricDefinition block(s) allowed")]
    public required TerraformList<AwsEvidentlyLaunchMetricMonitorsBlockMetricDefinitionBlock> MetricDefinition
    {
        get => GetRequiredArgument<TerraformList<AwsEvidentlyLaunchMetricMonitorsBlockMetricDefinitionBlock>>("metric_definition");
        set => SetArgument("metric_definition", value);
    }

}

/// <summary>
/// Block type for metric_definition in AwsEvidentlyLaunchMetricMonitorsBlock.
/// Nesting mode: list
/// </summary>
public class AwsEvidentlyLaunchMetricMonitorsBlockMetricDefinitionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "metric_definition";

    /// <summary>
    /// The entity_id_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EntityIdKey is required")]
    public required TerraformValue<string> EntityIdKey
    {
        get => GetRequiredArgument<TerraformValue<string>>("entity_id_key");
        set => SetArgument("entity_id_key", value);
    }

    /// <summary>
    /// The event_pattern attribute.
    /// </summary>
    public TerraformValue<string>? EventPattern
    {
        get => GetArgument<TerraformValue<string>>("event_pattern");
        set => SetArgument("event_pattern", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The unit_label attribute.
    /// </summary>
    public TerraformValue<string>? UnitLabel
    {
        get => GetArgument<TerraformValue<string>>("unit_label");
        set => SetArgument("unit_label", value);
    }

    /// <summary>
    /// The value_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValueKey is required")]
    public required TerraformValue<string> ValueKey
    {
        get => GetRequiredArgument<TerraformValue<string>>("value_key");
        set => SetArgument("value_key", value);
    }

}


/// <summary>
/// Block type for scheduled_splits_config in AwsEvidentlyLaunch.
/// Nesting mode: list
/// </summary>
public class AwsEvidentlyLaunchScheduledSplitsConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "scheduled_splits_config";

    /// <summary>
    /// Steps block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Steps is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Steps block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(6, ErrorMessage = "Maximum 6 Steps block(s) allowed")]
    public required TerraformList<AwsEvidentlyLaunchScheduledSplitsConfigBlockStepsBlock> Steps
    {
        get => GetRequiredArgument<TerraformList<AwsEvidentlyLaunchScheduledSplitsConfigBlockStepsBlock>>("steps");
        set => SetArgument("steps", value);
    }

}

/// <summary>
/// Block type for steps in AwsEvidentlyLaunchScheduledSplitsConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsEvidentlyLaunchScheduledSplitsConfigBlockStepsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "steps";

    /// <summary>
    /// The group_weights attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GroupWeights is required")]
    public required TerraformMap<double> GroupWeights
    {
        get => GetRequiredArgument<TerraformMap<double>>("group_weights");
        set => SetArgument("group_weights", value);
    }

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartTime is required")]
    public required TerraformValue<string> StartTime
    {
        get => GetRequiredArgument<TerraformValue<string>>("start_time");
        set => SetArgument("start_time", value);
    }

    /// <summary>
    /// SegmentOverrides block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(6, ErrorMessage = "Maximum 6 SegmentOverrides block(s) allowed")]
    public TerraformList<AwsEvidentlyLaunchScheduledSplitsConfigBlockStepsBlockSegmentOverridesBlock>? SegmentOverrides
    {
        get => GetArgument<TerraformList<AwsEvidentlyLaunchScheduledSplitsConfigBlockStepsBlockSegmentOverridesBlock>>("segment_overrides");
        set => SetArgument("segment_overrides", value);
    }

}

/// <summary>
/// Block type for segment_overrides in AwsEvidentlyLaunchScheduledSplitsConfigBlockStepsBlock.
/// Nesting mode: list
/// </summary>
public class AwsEvidentlyLaunchScheduledSplitsConfigBlockStepsBlockSegmentOverridesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "segment_overrides";

    /// <summary>
    /// The evaluation_order attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EvaluationOrder is required")]
    public required TerraformValue<double> EvaluationOrder
    {
        get => GetRequiredArgument<TerraformValue<double>>("evaluation_order");
        set => SetArgument("evaluation_order", value);
    }

    /// <summary>
    /// The segment attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Segment is required")]
    public required TerraformValue<string> Segment
    {
        get => GetRequiredArgument<TerraformValue<string>>("segment");
        set => SetArgument("segment", value);
    }

    /// <summary>
    /// The weights attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Weights is required")]
    public required TerraformMap<double> Weights
    {
        get => GetRequiredArgument<TerraformMap<double>>("weights");
        set => SetArgument("weights", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsEvidentlyLaunch.
/// Nesting mode: single
/// </summary>
public class AwsEvidentlyLaunchTimeoutsBlock : TerraformBlock
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
/// Represents a aws_evidently_launch Terraform resource.
/// Manages a aws_evidently_launch resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public partial class AwsEvidentlyLaunch(string name) : TerraformResource("aws_evidently_launch", name)
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
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Project is required")]
    public required TerraformValue<string> Project
    {
        get => GetRequiredArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The randomization_salt attribute.
    /// </summary>
    public TerraformValue<string>? RandomizationSalt
    {
        get => GetArgument<TerraformValue<string>>("randomization_salt");
        set => SetArgument("randomization_salt", value);
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
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? CreateReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The created_time attribute.
    /// </summary>
    public TerraformValue<string> CreatedTime
        => CreateReference("created_time");

    /// <summary>
    /// The execution attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Execution
        => CreateReference("execution");

    /// <summary>
    /// The last_updated_time attribute.
    /// </summary>
    public TerraformValue<string> LastUpdatedTime
        => CreateReference("last_updated_time");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => CreateReference("status");

    /// <summary>
    /// The status_reason attribute.
    /// </summary>
    public TerraformValue<string> StatusReason
        => CreateReference("status_reason");

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string> Type
        => CreateReference("type");

    /// <summary>
    /// Groups block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Groups is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Groups block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(5, ErrorMessage = "Maximum 5 Groups block(s) allowed")]
    public required TerraformList<AwsEvidentlyLaunchGroupsBlock> Groups
    {
        get => GetRequiredArgument<TerraformList<AwsEvidentlyLaunchGroupsBlock>>("groups");
        set => SetArgument("groups", value);
    }

    /// <summary>
    /// MetricMonitors block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(3, ErrorMessage = "Maximum 3 MetricMonitors block(s) allowed")]
    public TerraformList<AwsEvidentlyLaunchMetricMonitorsBlock>? MetricMonitors
    {
        get => GetArgument<TerraformList<AwsEvidentlyLaunchMetricMonitorsBlock>>("metric_monitors");
        set => SetArgument("metric_monitors", value);
    }

    /// <summary>
    /// ScheduledSplitsConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScheduledSplitsConfig block(s) allowed")]
    public TerraformList<AwsEvidentlyLaunchScheduledSplitsConfigBlock>? ScheduledSplitsConfig
    {
        get => GetArgument<TerraformList<AwsEvidentlyLaunchScheduledSplitsConfigBlock>>("scheduled_splits_config");
        set => SetArgument("scheduled_splits_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsEvidentlyLaunchTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsEvidentlyLaunchTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
