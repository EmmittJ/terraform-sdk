using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_batch_job_definition Terraform data source.
/// Retrieves information about a aws_batch_job_definition.
/// </summary>
public partial class AwsBatchJobDefinitionDataSource(string name) : TerraformDataSource("aws_batch_job_definition", name)
{
    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string>? Arn
    {
        get => GetArgument<TerraformValue<string>>("arn");
        set => SetArgument("arn", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The revision attribute.
    /// </summary>
    public TerraformValue<double>? Revision
    {
        get => GetArgument<TerraformValue<double>>("revision");
        set => SetArgument("revision", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string>? Status
    {
        get => GetArgument<TerraformValue<string>>("status");
        set => SetArgument("status", value);
    }

    /// <summary>
    /// The arn_prefix attribute.
    /// </summary>
    public TerraformValue<string> ArnPrefix
        => AsReference("arn_prefix");

    /// <summary>
    /// The container_orchestration_type attribute.
    /// </summary>
    public TerraformValue<string> ContainerOrchestrationType
        => AsReference("container_orchestration_type");

    /// <summary>
    /// The eks_properties attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> EksProperties
        => AsReference("eks_properties");

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// The node_properties attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> NodeProperties
        => AsReference("node_properties");

    /// <summary>
    /// The retry_strategy attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> RetryStrategy
        => AsReference("retry_strategy");

    /// <summary>
    /// The scheduling_priority attribute.
    /// </summary>
    public TerraformValue<double> SchedulingPriority
        => AsReference("scheduling_priority");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => AsReference("tags");

    /// <summary>
    /// The timeout attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Timeout
        => AsReference("timeout");

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string> Type
        => AsReference("type");

}
