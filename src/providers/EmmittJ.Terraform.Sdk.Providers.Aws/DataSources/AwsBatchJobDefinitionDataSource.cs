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
        SetOutput("arn_prefix");
        SetOutput("container_orchestration_type");
        SetOutput("eks_properties");
        SetOutput("id");
        SetOutput("node_properties");
        SetOutput("retry_strategy");
        SetOutput("scheduling_priority");
        SetOutput("tags");
        SetOutput("timeout");
        SetOutput("type");
        SetOutput("arn");
        SetOutput("name");
        SetOutput("region");
        SetOutput("revision");
        SetOutput("status");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformProperty<string> Arn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("arn");
        set => SetProperty("arn", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
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
    /// The revision attribute.
    /// </summary>
    public TerraformProperty<double> Revision
    {
        get => GetRequiredOutput<TerraformProperty<double>>("revision");
        set => SetProperty("revision", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformProperty<string> Status
    {
        get => GetRequiredOutput<TerraformProperty<string>>("status");
        set => SetProperty("status", value);
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
