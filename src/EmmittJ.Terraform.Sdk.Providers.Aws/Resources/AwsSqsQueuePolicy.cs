using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_sqs_queue_policy resource.
/// </summary>
public class AwsSqsQueuePolicy : TerraformResource
{
    public AwsSqsQueuePolicy(string name) : base("aws_sqs_queue_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The policy attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Policy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("policy");
        set => this.WithProperty("policy", value);
    }

    /// <summary>
    /// The queue_url attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? QueueUrl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("queue_url");
        set => this.WithProperty("queue_url", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

}
