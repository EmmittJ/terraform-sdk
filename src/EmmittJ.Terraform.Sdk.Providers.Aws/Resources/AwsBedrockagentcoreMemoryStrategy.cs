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
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The memory_execution_role_arn attribute.
    /// </summary>
    public string? MemoryExecutionRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("memory_execution_role_arn")?.Value;
        set => this.WithProperty("memory_execution_role_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The memory_id attribute.
    /// </summary>
    public string? MemoryId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("memory_id")?.Value;
        set => this.WithProperty("memory_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The namespaces attribute.
    /// </summary>
    public HashSet<string>? Namespaces
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("namespaces")?.Value;
        set => this.WithProperty("namespaces", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
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
    /// The type attribute.
    /// </summary>
    public string? Type
    {
        get => GetProperty<TerraformLiteralProperty<string>>("type")?.Value;
        set => this.WithProperty("type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The memory_strategy_id attribute.
    /// </summary>
    public TerraformExpression MemoryStrategyId => this["memory_strategy_id"];

}
