using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsSecuritylakeSubscriberNotificationConfigurationBlock : TerraformBlockBase
{
}

/// <summary>
/// Manages a aws_securitylake_subscriber_notification resource.
/// </summary>
public partial class AwsSecuritylakeSubscriberNotification : TerraformResource
{
    public AwsSecuritylakeSubscriberNotification(string name) : base("aws_securitylake_subscriber_notification", name)
    {
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The subscriber_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubscriberId is required")]
    [TerraformProperty("subscriber_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> SubscriberId { get; set; }

    /// <summary>
    /// Block for configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("configuration")]
    public TerraformList<TerraformBlock<AwsSecuritylakeSubscriberNotificationConfigurationBlock>>? Configuration { get; set; }

    /// <summary>
    /// The endpoint_id attribute.
    /// </summary>
    [TerraformProperty("endpoint_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> EndpointId { get; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Id { get; }

    /// <summary>
    /// The subscriber_endpoint attribute.
    /// </summary>
    [TerraformProperty("subscriber_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SubscriberEndpoint { get; }

}
