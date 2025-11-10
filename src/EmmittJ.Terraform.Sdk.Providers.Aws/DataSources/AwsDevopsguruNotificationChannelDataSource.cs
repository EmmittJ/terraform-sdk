using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filters in .
/// Nesting mode: list
/// </summary>
public class AwsDevopsguruNotificationChannelDataSourceFiltersBlock : TerraformBlock
{
    /// <summary>
    /// The message_types attribute.
    /// </summary>
    public List<TerraformProperty<string>>? MessageTypes
    {
        get => GetProperty<List<TerraformProperty<string>>>("message_types");
        set => WithProperty("message_types", value);
    }

    /// <summary>
    /// The severities attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Severities
    {
        get => GetProperty<List<TerraformProperty<string>>>("severities");
        set => WithProperty("severities", value);
    }

}

/// <summary>
/// Block type for sns in .
/// Nesting mode: list
/// </summary>
public class AwsDevopsguruNotificationChannelDataSourceSnsBlock : TerraformBlock
{
    /// <summary>
    /// The topic_arn attribute.
    /// </summary>
    public TerraformProperty<string>? TopicArn
    {
        get => GetProperty<TerraformProperty<string>>("topic_arn");
        set => WithProperty("topic_arn", value);
    }

}

/// <summary>
/// Retrieves information about a aws_devopsguru_notification_channel.
/// </summary>
public class AwsDevopsguruNotificationChannelDataSource : TerraformDataSource
{
    public AwsDevopsguruNotificationChannelDataSource(string name) : base("aws_devopsguru_notification_channel", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformProperty<string> Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
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
    public List<AwsDevopsguruNotificationChannelDataSourceFiltersBlock>? Filters
    {
        get => GetProperty<List<AwsDevopsguruNotificationChannelDataSourceFiltersBlock>>("filters");
        set => this.WithProperty("filters", value);
    }

    /// <summary>
    /// Block for sns.
    /// Nesting mode: list
    /// </summary>
    public List<AwsDevopsguruNotificationChannelDataSourceSnsBlock>? Sns
    {
        get => GetProperty<List<AwsDevopsguruNotificationChannelDataSourceSnsBlock>>("sns");
        set => this.WithProperty("sns", value);
    }

}
