using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_bedrockagentcore_memory_strategy resource.
/// </summary>
public class AwsBedrockagentcoreMemoryStrategy : TerraformResource
{
    public AwsBedrockagentcoreMemoryStrategy(string name) : base("aws_bedrockagentcore_memory_strategy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("memory_strategy_id");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The memory_execution_role_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? MemoryExecutionRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("memory_execution_role_arn");
        set => this.WithProperty("memory_execution_role_arn", value);
    }

    /// <summary>
    /// The memory_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? MemoryId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("memory_id");
        set => this.WithProperty("memory_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The namespaces attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? Namespaces
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("namespaces");
        set => this.WithProperty("namespaces", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Type
    {
        get => GetProperty<TerraformLiteralProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// The memory_strategy_id attribute.
    /// </summary>
    public TerraformExpression MemoryStrategyId => this["memory_strategy_id"];

}
