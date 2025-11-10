using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filters in .
/// Nesting mode: list
/// </summary>
public class AwsDevopsguruNotificationChannelFiltersBlock : TerraformBlock
{
    /// <summary>
    /// The message_types attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? MessageTypes
    {
        set => SetProperty("message_types", value);
    }

    /// <summary>
    /// The severities attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Severities
    {
        set => SetProperty("severities", value);
    }

}

/// <summary>
/// Block type for sns in .
/// Nesting mode: list
/// </summary>
public class AwsDevopsguruNotificationChannelSnsBlock : TerraformBlock
{
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
/// Manages a aws_devopsguru_notification_channel resource.
/// </summary>
public class AwsDevopsguruNotificationChannel : TerraformResource
{
    public AwsDevopsguruNotificationChannel(string name) : base("aws_devopsguru_notification_channel", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("id");
        SetOutput("region");
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
    /// Block for filters.
    /// Nesting mode: list
    /// </summary>
    public List<AwsDevopsguruNotificationChannelFiltersBlock>? Filters
    {
        set => SetProperty("filters", value);
    }

    /// <summary>
    /// Block for sns.
    /// Nesting mode: list
    /// </summary>
    public List<AwsDevopsguruNotificationChannelSnsBlock>? Sns
    {
        set => SetProperty("sns", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
