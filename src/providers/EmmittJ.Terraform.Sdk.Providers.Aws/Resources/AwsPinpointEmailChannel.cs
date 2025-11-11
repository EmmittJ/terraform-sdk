using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_pinpoint_email_channel resource.
/// </summary>
public partial class AwsPinpointEmailChannel : TerraformResource
{
    public AwsPinpointEmailChannel(string name) : base("aws_pinpoint_email_channel", name)
    {
    }

    /// <summary>
    /// The application_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationId is required")]
    [TerraformProperty("application_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ApplicationId { get; set; }

    /// <summary>
    /// The configuration_set attribute.
    /// </summary>
    [TerraformProperty("configuration_set")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ConfigurationSet { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The from_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FromAddress is required")]
    [TerraformProperty("from_address")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> FromAddress { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Identity is required")]
    [TerraformProperty("identity")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Identity { get; set; }

    /// <summary>
    /// The orchestration_sending_role_arn attribute.
    /// </summary>
    [TerraformProperty("orchestration_sending_role_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? OrchestrationSendingRoleArn { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [TerraformProperty("role_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RoleArn { get; set; }

    /// <summary>
    /// The messages_per_second attribute.
    /// </summary>
    [TerraformProperty("messages_per_second")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> MessagesPerSecond { get; }

}
