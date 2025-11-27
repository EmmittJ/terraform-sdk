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
        get => new TerraformReference<string>(this, "arn");
        set => SetArgument("arn", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
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
    /// The revision attribute.
    /// </summary>
    public TerraformValue<double>? Revision
    {
        get => new TerraformReference<double>(this, "revision");
        set => SetArgument("revision", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string>? Status
    {
        get => new TerraformReference<string>(this, "status");
        set => SetArgument("status", value);
    }

    /// <summary>
    /// The arn_prefix attribute.
    /// </summary>
    public TerraformValue<string> ArnPrefix
    {
        get => new TerraformReference<string>(this, "arn_prefix");
    }

    /// <summary>
    /// The container_orchestration_type attribute.
    /// </summary>
    public TerraformValue<string> ContainerOrchestrationType
    {
        get => new TerraformReference<string>(this, "container_orchestration_type");
    }

    /// <summary>
    /// The eks_properties attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> EksProperties
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "eks_properties").ResolveNodes(ctx));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The node_properties attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> NodeProperties
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "node_properties").ResolveNodes(ctx));
    }

    /// <summary>
    /// The retry_strategy attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> RetryStrategy
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "retry_strategy").ResolveNodes(ctx));
    }

    /// <summary>
    /// The scheduling_priority attribute.
    /// </summary>
    public TerraformValue<double> SchedulingPriority
    {
        get => new TerraformReference<double>(this, "scheduling_priority");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The timeout attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Timeout
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "timeout").ResolveNodes(ctx));
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
    }

}
