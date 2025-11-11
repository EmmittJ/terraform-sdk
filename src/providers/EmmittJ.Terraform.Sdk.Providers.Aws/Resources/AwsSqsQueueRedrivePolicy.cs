using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_sqs_queue_redrive_policy resource.
/// </summary>
public partial class AwsSqsQueueRedrivePolicy : TerraformResource
{
    public AwsSqsQueueRedrivePolicy(string name) : base("aws_sqs_queue_redrive_policy", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The queue_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QueueUrl is required")]
    [TerraformProperty("queue_url")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> QueueUrl { get; set; }

    /// <summary>
    /// The redrive_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RedrivePolicy is required")]
    [TerraformProperty("redrive_policy")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> RedrivePolicy { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

}
