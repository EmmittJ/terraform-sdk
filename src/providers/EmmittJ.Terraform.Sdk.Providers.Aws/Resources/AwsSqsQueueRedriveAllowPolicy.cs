using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_sqs_queue_redrive_allow_policy Terraform resource.
/// Manages a aws_sqs_queue_redrive_allow_policy resource.
/// </summary>
public partial class AwsSqsQueueRedriveAllowPolicy(string name) : TerraformResource("aws_sqs_queue_redrive_allow_policy", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The queue_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QueueUrl is required")]
    public required TerraformValue<string> QueueUrl
    {
        get => GetRequiredArgument<TerraformValue<string>>("queue_url");
        set => SetArgument("queue_url", value);
    }

    /// <summary>
    /// The redrive_allow_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RedriveAllowPolicy is required")]
    public required TerraformValue<string> RedriveAllowPolicy
    {
        get => GetRequiredArgument<TerraformValue<string>>("redrive_allow_policy");
        set => SetArgument("redrive_allow_policy", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

}
