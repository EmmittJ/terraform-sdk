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
        this.WithOutput("queue_urls");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The queue_name_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? QueueNamePrefix
    {
        get => GetProperty<TerraformProperty<string>>("queue_name_prefix");
        set => this.WithProperty("queue_name_prefix", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The queue_urls attribute.
    /// </summary>
    public TerraformExpression QueueUrls => this["queue_urls"];

}
