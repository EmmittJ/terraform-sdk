using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_sqs_queue_redrive_allow_policy resource.
/// </summary>
public class AwsSqsQueueRedriveAllowPolicy : TerraformResource
{
    public AwsSqsQueueRedriveAllowPolicy(string name) : base("aws_sqs_queue_redrive_allow_policy", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The queue_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QueueUrl is required")]
    [TerraformPropertyName("queue_url")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> QueueUrl { get; set; }

    /// <summary>
    /// The redrive_allow_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RedriveAllowPolicy is required")]
    [TerraformPropertyName("redrive_allow_policy")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RedriveAllowPolicy { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

}
