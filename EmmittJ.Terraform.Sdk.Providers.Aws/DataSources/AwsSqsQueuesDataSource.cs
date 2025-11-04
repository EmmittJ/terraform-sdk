using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_sqs_queues.
/// </summary>
public class AwsSqsQueuesDataSource : TerraformDataSource
{
    public AwsSqsQueuesDataSource(string name) : base("aws_sqs_queues", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("queue_urls");
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
    /// The queue_name_prefix attribute.
    /// </summary>
    public string? QueueNamePrefix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("queue_name_prefix")?.Value;
        set => this.WithProperty("queue_name_prefix", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The queue_urls attribute.
    /// </summary>
    public TerraformExpression QueueUrls => this["queue_urls"];

}
