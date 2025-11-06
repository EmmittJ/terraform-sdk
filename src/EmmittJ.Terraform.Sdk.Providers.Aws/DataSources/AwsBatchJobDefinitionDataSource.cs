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
        this.DeclareOutput("arn_prefix");
        this.DeclareOutput("container_orchestration_type");
        this.DeclareOutput("eks_properties");
        this.DeclareOutput("id");
        this.DeclareOutput("node_properties");
        this.DeclareOutput("retry_strategy");
        this.DeclareOutput("scheduling_priority");
        this.DeclareOutput("tags");
        this.DeclareOutput("timeout");
        this.DeclareOutput("type");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public string? Arn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("arn")?.Value;
        set => this.WithProperty("arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The revision attribute.
    /// </summary>
    public double? Revision
    {
        get => GetProperty<TerraformLiteralProperty<double>>("revision")?.Value;
        set => this.WithProperty("revision", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public string? Status
    {
        get => GetProperty<TerraformLiteralProperty<string>>("status")?.Value;
        set => this.WithProperty("status", value == null ? null : new TerraformLiteralProperty<string>(value));
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
