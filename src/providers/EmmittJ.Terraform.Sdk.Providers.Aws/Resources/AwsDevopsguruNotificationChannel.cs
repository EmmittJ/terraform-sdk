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
        get => GetProperty<HashSet<TerraformProperty<string>>>("message_types");
        set => WithProperty("message_types", value);
    }

    /// <summary>
    /// The severities attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Severities
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("severities");
        set => WithProperty("severities", value);
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
        get => GetRequiredProperty<TerraformProperty<string>>("topic_arn");
        set => WithProperty("topic_arn", value);
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
        this.DeclareOutput("id");
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// Block for filters.
    /// Nesting mode: list
    /// </summary>
    public List<AwsDevopsguruNotificationChannelFiltersBlock>? Filters
    {
        get => GetProperty<List<AwsDevopsguruNotificationChannelFiltersBlock>>("filters");
        set => this.WithProperty("filters", value);
    }

    /// <summary>
    /// Block for sns.
    /// Nesting mode: list
    /// </summary>
    public List<AwsDevopsguruNotificationChannelSnsBlock>? Sns
    {
        get => GetProperty<List<AwsDevopsguruNotificationChannelSnsBlock>>("sns");
        set => this.WithProperty("sns", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
