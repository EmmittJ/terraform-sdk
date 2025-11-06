using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_sqs_queue_redrive_allow_policy resource.
/// </summary>
public class AwsSqsQueueRedriveAllowPolicy : TerraformResource
{
    public AwsSqsQueueRedriveAllowPolicy(string name) : base("aws_sqs_queue_redrive_allow_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The queue_url attribute.
    /// </summary>
    public string? QueueUrl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("queue_url")?.Value;
        set => this.WithProperty("queue_url", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The redrive_allow_policy attribute.
    /// </summary>
    public string? RedriveAllowPolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("redrive_allow_policy")?.Value;
        set => this.WithProperty("redrive_allow_policy", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
