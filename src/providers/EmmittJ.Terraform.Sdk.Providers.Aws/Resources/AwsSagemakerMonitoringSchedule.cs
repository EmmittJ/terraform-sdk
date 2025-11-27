using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for monitoring_schedule_config in AwsSagemakerMonitoringSchedule.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerMonitoringScheduleMonitoringScheduleConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "monitoring_schedule_config";

    /// <summary>
    /// The monitoring_job_definition_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MonitoringJobDefinitionName is required")]
    public required TerraformValue<string> MonitoringJobDefinitionName
    {
        get => new TerraformReference<string>(this, "monitoring_job_definition_name");
        set => SetArgument("monitoring_job_definition_name", value);
    }

    /// <summary>
    /// The monitoring_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MonitoringType is required")]
    public required TerraformValue<string> MonitoringType
    {
        get => new TerraformReference<string>(this, "monitoring_type");
        set => SetArgument("monitoring_type", value);
    }

    /// <summary>
    /// ScheduleConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScheduleConfig block(s) allowed")]
    public TerraformList<AwsSagemakerMonitoringScheduleMonitoringScheduleConfigBlockScheduleConfigBlock>? ScheduleConfig
    {
        get => GetArgument<TerraformList<AwsSagemakerMonitoringScheduleMonitoringScheduleConfigBlockScheduleConfigBlock>>("schedule_config");
        set => SetArgument("schedule_config", value);
    }

}

/// <summary>
/// Block type for schedule_config in AwsSagemakerMonitoringScheduleMonitoringScheduleConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerMonitoringScheduleMonitoringScheduleConfigBlockScheduleConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "schedule_config";

    /// <summary>
    /// The schedule_expression attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScheduleExpression is required")]
    public required TerraformValue<string> ScheduleExpression
    {
        get => new TerraformReference<string>(this, "schedule_expression");
        set => SetArgument("schedule_expression", value);
    }

}


/// <summary>
/// Represents a aws_sagemaker_monitoring_schedule Terraform resource.
/// Manages a aws_sagemaker_monitoring_schedule resource.
/// </summary>
public partial class AwsSagemakerMonitoringSchedule(string name) : TerraformResource("aws_sagemaker_monitoring_schedule", name)
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
    /// MonitoringScheduleConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MonitoringScheduleConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 MonitoringScheduleConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MonitoringScheduleConfig block(s) allowed")]
    public required TerraformList<AwsSagemakerMonitoringScheduleMonitoringScheduleConfigBlock> MonitoringScheduleConfig
    {
        get => GetRequiredArgument<TerraformList<AwsSagemakerMonitoringScheduleMonitoringScheduleConfigBlock>>("monitoring_schedule_config");
        set => SetArgument("monitoring_schedule_config", value);
    }

}
