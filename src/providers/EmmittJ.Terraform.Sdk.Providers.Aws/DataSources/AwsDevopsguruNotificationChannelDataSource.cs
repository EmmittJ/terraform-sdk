using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filters in .
/// Nesting mode: list
/// </summary>
public class AwsDevopsguruNotificationChannelDataSourceFiltersBlock : ITerraformBlock
{
    /// <summary>
    /// The message_types attribute.
    /// </summary>
    [TerraformPropertyName("message_types")]
    // Computed attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> MessageTypes => new TerraformReferenceProperty<List<TerraformProperty<string>>>("", "message_types");

    /// <summary>
    /// The severities attribute.
    /// </summary>
    [TerraformPropertyName("severities")]
    // Computed attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> Severities => new TerraformReferenceProperty<List<TerraformProperty<string>>>("", "severities");

}

/// <summary>
/// Block type for sns in .
/// Nesting mode: list
/// </summary>
public class AwsDevopsguruNotificationChannelDataSourceSnsBlock : ITerraformBlock
{
    /// <summary>
    /// The topic_arn attribute.
    /// </summary>
    [TerraformPropertyName("topic_arn")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TopicArn => new TerraformReferenceProperty<TerraformProperty<string>>("", "topic_arn");

}

/// <summary>
/// Retrieves information about a aws_devopsguru_notification_channel.
/// </summary>
public class AwsDevopsguruNotificationChannelDataSource : TerraformDataSource
{
    public AwsDevopsguruNotificationChannelDataSource(string name) : base("aws_devopsguru_notification_channel", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformPropertyName("id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// Block for filters.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("filters")]
    public TerraformList<TerraformBlock<AwsDevopsguruNotificationChannelDataSourceFiltersBlock>>? Filters { get; set; } = new();

    /// <summary>
    /// Block for sns.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("sns")]
    public TerraformList<TerraformBlock<AwsDevopsguruNotificationChannelDataSourceSnsBlock>>? Sns { get; set; } = new();

}
