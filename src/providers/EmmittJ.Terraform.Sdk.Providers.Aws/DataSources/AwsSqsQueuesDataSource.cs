using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_sqs_queues Terraform data source.
/// Retrieves information about a aws_sqs_queues.
/// </summary>
public partial class AwsSqsQueuesDataSource(string name) : TerraformDataSource("aws_sqs_queues", name)
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
    /// The queue_name_prefix attribute.
    /// </summary>
    public TerraformValue<string>? QueueNamePrefix
    {
        get => new TerraformReference<string>(this, "queue_name_prefix");
        set => SetArgument("queue_name_prefix", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The queue_urls attribute.
    /// </summary>
    public TerraformSet<string> QueueUrls
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "queue_urls").ResolveNodes(ctx));
    }

}
