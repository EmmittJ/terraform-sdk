using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filters in .
/// Nesting mode: list
/// </summary>
public partial class AwsDevopsguruNotificationChannelFiltersBlock : TerraformBlockBase
{
    /// <summary>
    /// The message_types attribute.
    /// </summary>
    [TerraformProperty("message_types")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? MessageTypes { get; set; }

    /// <summary>
    /// The severities attribute.
    /// </summary>
    [TerraformProperty("severities")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? Severities { get; set; }

}

/// <summary>
/// Block type for sns in .
/// Nesting mode: list
/// </summary>
public partial class AwsDevopsguruNotificationChannelSnsBlock : TerraformBlockBase
{
    /// <summary>
    /// The topic_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TopicArn is required")]
    [TerraformProperty("topic_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TopicArn { get; set; }

}

/// <summary>
/// Manages a aws_devopsguru_notification_channel resource.
/// </summary>
public partial class AwsDevopsguruNotificationChannel : TerraformResource
{
    public AwsDevopsguruNotificationChannel(string name) : base("aws_devopsguru_notification_channel", name)
    {
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for filters.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("filters")]
    public partial TerraformList<TerraformBlock<AwsDevopsguruNotificationChannelFiltersBlock>>? Filters { get; set; }

    /// <summary>
    /// Block for sns.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("sns")]
    public partial TerraformList<TerraformBlock<AwsDevopsguruNotificationChannelSnsBlock>>? Sns { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Id { get; }

}
