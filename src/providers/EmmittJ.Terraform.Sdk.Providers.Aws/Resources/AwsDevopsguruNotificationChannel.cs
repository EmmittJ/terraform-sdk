using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filters in .
/// Nesting mode: list
/// </summary>
public class AwsDevopsguruNotificationChannelFiltersBlock
{
    /// <summary>
    /// The message_types attribute.
    /// </summary>
    [TerraformPropertyName("message_types")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? MessageTypes { get; set; }

    /// <summary>
    /// The severities attribute.
    /// </summary>
    [TerraformPropertyName("severities")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? Severities { get; set; }

}

/// <summary>
/// Block type for sns in .
/// Nesting mode: list
/// </summary>
public class AwsDevopsguruNotificationChannelSnsBlock
{
    /// <summary>
    /// The topic_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TopicArn is required")]
    [TerraformPropertyName("topic_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> TopicArn { get; set; }

}

/// <summary>
/// Manages a aws_devopsguru_notification_channel resource.
/// </summary>
public class AwsDevopsguruNotificationChannel : TerraformResource
{
    public AwsDevopsguruNotificationChannel(string name) : base("aws_devopsguru_notification_channel", name)
    {
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// Block for filters.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("filters")]
    public TerraformList<TerraformBlock<AwsDevopsguruNotificationChannelFiltersBlock>>? Filters { get; set; }

    /// <summary>
    /// Block for sns.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("sns")]
    public TerraformList<TerraformBlock<AwsDevopsguruNotificationChannelSnsBlock>>? Sns { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Id => new TerraformReference(this, "id");

}
