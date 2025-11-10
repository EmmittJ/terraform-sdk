using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for event_subscription in .
/// Nesting mode: set
/// </summary>
public class AwsInspectorAssessmentTemplateEventSubscriptionBlock : TerraformBlock
{
    /// <summary>
    /// The event attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Event is required")]
    public required TerraformProperty<string> Event
    {
        set => SetProperty("event", value);
    }

    /// <summary>
    /// The topic_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TopicArn is required")]
    public required TerraformProperty<string> TopicArn
    {
        set => SetProperty("topic_arn", value);
    }

}

/// <summary>
/// Manages a aws_inspector_assessment_template resource.
/// </summary>
public class AwsInspectorAssessmentTemplate : TerraformResource
{
    public AwsInspectorAssessmentTemplate(string name) : base("aws_inspector_assessment_template", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("duration");
        SetOutput("id");
        SetOutput("name");
        SetOutput("region");
        SetOutput("rules_package_arns");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("target_arn");
    }

    /// <summary>
    /// The duration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Duration is required")]
    public required TerraformProperty<double> Duration
    {
        get => GetRequiredOutput<TerraformProperty<double>>("duration");
        set => SetProperty("duration", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The rules_package_arns attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RulesPackageArns is required")]
    public HashSet<TerraformProperty<string>> RulesPackageArns
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("rules_package_arns");
        set => SetProperty("rules_package_arns", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// The target_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetArn is required")]
    public required TerraformProperty<string> TargetArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("target_arn");
        set => SetProperty("target_arn", value);
    }

    /// <summary>
    /// Block for event_subscription.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsInspectorAssessmentTemplateEventSubscriptionBlock>? EventSubscription
    {
        set => SetProperty("event_subscription", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
