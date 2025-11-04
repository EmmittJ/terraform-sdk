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
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The policy attribute.
    /// </summary>
    public string? Policy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("policy")?.Value;
        set => this.WithProperty("policy", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The queue_url attribute.
    /// </summary>
    public string? QueueUrl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("queue_url")?.Value;
        set => this.WithProperty("queue_url", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
