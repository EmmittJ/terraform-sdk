using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_sqs_queue_redrive_policy resource.
/// </summary>
public class AwsSqsQueueRedrivePolicy : TerraformResource
{
    public AwsSqsQueueRedrivePolicy(string name) : base("aws_sqs_queue_redrive_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("id");
        SetOutput("queue_url");
        SetOutput("redrive_policy");
        SetOutput("region");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The queue_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QueueUrl is required")]
    public required TerraformProperty<string> QueueUrl
    {
        get => GetRequiredOutput<TerraformProperty<string>>("queue_url");
        set => SetProperty("queue_url", value);
    }

    /// <summary>
    /// The redrive_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RedrivePolicy is required")]
    public required TerraformProperty<string> RedrivePolicy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("redrive_policy");
        set => SetProperty("redrive_policy", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

}
