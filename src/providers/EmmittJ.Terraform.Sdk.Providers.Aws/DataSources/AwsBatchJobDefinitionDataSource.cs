using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_batch_job_definition.
/// </summary>
public class AwsBatchJobDefinitionDataSource : TerraformDataSource
{
    public AwsBatchJobDefinitionDataSource(string name) : base("aws_batch_job_definition", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn_prefix");
        this.WithOutput("container_orchestration_type");
        this.WithOutput("eks_properties");
        this.WithOutput("id");
        this.WithOutput("node_properties");
        this.WithOutput("retry_strategy");
        this.WithOutput("scheduling_priority");
        this.WithOutput("tags");
        this.WithOutput("timeout");
        this.WithOutput("type");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformProperty<string>? Arn
    {
        get => GetProperty<TerraformProperty<string>>("arn");
        set => this.WithProperty("arn", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// The revision attribute.
    /// </summary>
    public TerraformProperty<double>? Revision
    {
        get => GetProperty<TerraformProperty<double>>("revision");
        set => this.WithProperty("revision", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformProperty<string>? Status
    {
        get => GetProperty<TerraformProperty<string>>("status");
        set => this.WithProperty("status", value);
    }

    /// <summary>
    /// The arn_prefix attribute.
    /// </summary>
    public TerraformExpression ArnPrefix => this["arn_prefix"];

    /// <summary>
    /// The container_orchestration_type attribute.
    /// </summary>
    public TerraformExpression ContainerOrchestrationType => this["container_orchestration_type"];

    /// <summary>
    /// The eks_properties attribute.
    /// </summary>
    public TerraformExpression EksProperties => this["eks_properties"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The node_properties attribute.
    /// </summary>
    public TerraformExpression NodeProperties => this["node_properties"];

    /// <summary>
    /// The retry_strategy attribute.
    /// </summary>
    public TerraformExpression RetryStrategy => this["retry_strategy"];

    /// <summary>
    /// The scheduling_priority attribute.
    /// </summary>
    public TerraformExpression SchedulingPriority => this["scheduling_priority"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The timeout attribute.
    /// </summary>
    public TerraformExpression Timeout => this["timeout"];

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformExpression Type => this["type"];

}
