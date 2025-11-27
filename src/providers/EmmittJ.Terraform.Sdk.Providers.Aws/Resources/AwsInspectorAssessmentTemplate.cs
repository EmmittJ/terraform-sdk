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
        get => new TerraformReference<string>(this, "event");
        set => SetArgument("event", value);
    }

    /// <summary>
    /// The topic_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TopicArn is required")]
    public required TerraformValue<string> TopicArn
    {
        get => new TerraformReference<string>(this, "topic_arn");
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
        get => new TerraformReference<double>(this, "duration");
        set => SetArgument("duration", value);
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
    /// The rules_package_arns attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RulesPackageArns is required")]
    public required TerraformSet<string> RulesPackageArns
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "rules_package_arns").ResolveNodes(ctx));
        set => SetArgument("rules_package_arns", value);
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
    /// The target_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetArn is required")]
    public required TerraformValue<string> TargetArn
    {
        get => new TerraformReference<string>(this, "target_arn");
        set => SetArgument("target_arn", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// EventSubscription block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsInspectorAssessmentTemplateEventSubscriptionBlock>? EventSubscription
    {
        get => GetArgument<TerraformSet<AwsInspectorAssessmentTemplateEventSubscriptionBlock>>("event_subscription");
        set => SetArgument("event_subscription", value);
    }

}
