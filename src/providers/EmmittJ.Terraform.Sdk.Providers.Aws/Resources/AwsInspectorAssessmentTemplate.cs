using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for event_subscription in AwsInspectorAssessmentTemplate.
/// Nesting mode: set
/// </summary>
public class AwsInspectorAssessmentTemplateEventSubscriptionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "event_subscription";

    /// <summary>
    /// The event attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventAttribute is required")]
    public required TerraformValue<string> EventAttribute
    {
        get => GetArgument<TerraformValue<string>>("event");
        set => SetArgument("event", value);
    }

    /// <summary>
    /// The topic_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TopicArn is required")]
    public required TerraformValue<string> TopicArn
    {
        get => GetArgument<TerraformValue<string>>("topic_arn");
        set => SetArgument("topic_arn", value);
    }

}


/// <summary>
/// Represents a aws_inspector_assessment_template Terraform resource.
/// Manages a aws_inspector_assessment_template resource.
/// </summary>
public partial class AwsInspectorAssessmentTemplate(string name) : TerraformResource("aws_inspector_assessment_template", name)
{
    /// <summary>
    /// The duration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Duration is required")]
    public required TerraformValue<double> Duration
    {
        get => GetArgument<TerraformValue<double>>("duration");
        set => SetArgument("duration", value);
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
    /// The rules_package_arns attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RulesPackageArns is required")]
    public required TerraformSet<string> RulesPackageArns
    {
        get => GetArgument<TerraformSet<string>>("rules_package_arns");
        set => SetArgument("rules_package_arns", value);
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
    /// The target_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetArn is required")]
    public required TerraformValue<string> TargetArn
    {
        get => GetArgument<TerraformValue<string>>("target_arn");
        set => SetArgument("target_arn", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// EventSubscription block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsInspectorAssessmentTemplateEventSubscriptionBlock>? EventSubscription
    {
        get => GetArgument<TerraformSet<AwsInspectorAssessmentTemplateEventSubscriptionBlock>>("event_subscription");
        set => SetArgument("event_subscription", value);
    }

}
