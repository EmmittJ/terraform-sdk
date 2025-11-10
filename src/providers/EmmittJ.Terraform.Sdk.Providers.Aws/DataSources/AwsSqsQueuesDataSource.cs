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
        SetOutput("queue_urls");
        SetOutput("id");
        SetOutput("queue_name_prefix");
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
    /// The queue_name_prefix attribute.
    /// </summary>
    public TerraformProperty<string> QueueNamePrefix
    {
        get => GetRequiredOutput<TerraformProperty<string>>("queue_name_prefix");
        set => SetProperty("queue_name_prefix", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The queue_urls attribute.
    /// </summary>
    public TerraformExpression QueueUrls => this["queue_urls"];

}
