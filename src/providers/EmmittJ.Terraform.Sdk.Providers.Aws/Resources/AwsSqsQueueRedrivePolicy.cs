using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_sqs_queue_redrive_policy Terraform resource.
/// Manages a aws_sqs_queue_redrive_policy resource.
/// </summary>
public partial class AwsSqsQueueRedrivePolicy(string name) : TerraformResource("aws_sqs_queue_redrive_policy", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The queue_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QueueUrl is required")]
    public required TerraformValue<string> QueueUrl
    {
        get => new TerraformReference<string>(this, "queue_url");
        set => SetArgument("queue_url", value);
    }

    /// <summary>
    /// The redrive_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RedrivePolicy is required")]
    public required TerraformValue<string> RedrivePolicy
    {
        get => new TerraformReference<string>(this, "redrive_policy");
        set => SetArgument("redrive_policy", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

}
