using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for configuration in AwsBedrockagentcoreMemoryStrategy.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentcoreMemoryStrategyConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "configuration";

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// Consolidation block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentcoreMemoryStrategyConfigurationBlockConsolidationBlock>? Consolidation
    {
        get => GetArgument<TerraformList<AwsBedrockagentcoreMemoryStrategyConfigurationBlockConsolidationBlock>>("consolidation");
        set => SetArgument("consolidation", value);
    }

    /// <summary>
    /// Extraction block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentcoreMemoryStrategyConfigurationBlockExtractionBlock>? Extraction
    {
        get => GetArgument<TerraformList<AwsBedrockagentcoreMemoryStrategyConfigurationBlockExtractionBlock>>("extraction");
        set => SetArgument("extraction", value);
    }

}

/// <summary>
/// Block type for consolidation in AwsBedrockagentcoreMemoryStrategyConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentcoreMemoryStrategyConfigurationBlockConsolidationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "consolidation";

    /// <summary>
    /// The append_to_prompt attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppendToPrompt is required")]
    public required TerraformValue<string> AppendToPrompt
    {
        get => GetRequiredArgument<TerraformValue<string>>("append_to_prompt");
        set => SetArgument("append_to_prompt", value);
    }

    /// <summary>
    /// The model_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ModelId is required")]
    public required TerraformValue<string> ModelId
    {
        get => GetRequiredArgument<TerraformValue<string>>("model_id");
        set => SetArgument("model_id", value);
    }

}

/// <summary>
/// Block type for extraction in AwsBedrockagentcoreMemoryStrategyConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentcoreMemoryStrategyConfigurationBlockExtractionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "extraction";

    /// <summary>
    /// The append_to_prompt attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppendToPrompt is required")]
    public required TerraformValue<string> AppendToPrompt
    {
        get => GetRequiredArgument<TerraformValue<string>>("append_to_prompt");
        set => SetArgument("append_to_prompt", value);
    }

    /// <summary>
    /// The model_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ModelId is required")]
    public required TerraformValue<string> ModelId
    {
        get => GetRequiredArgument<TerraformValue<string>>("model_id");
        set => SetArgument("model_id", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsBedrockagentcoreMemoryStrategy.
/// Nesting mode: single
/// </summary>
public class AwsBedrockagentcoreMemoryStrategyTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_bedrockagentcore_memory_strategy Terraform resource.
/// Manages a aws_bedrockagentcore_memory_strategy resource.
/// </summary>
public partial class AwsBedrockagentcoreMemoryStrategy(string name) : TerraformResource("aws_bedrockagentcore_memory_strategy", name)
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The memory_execution_role_arn attribute.
    /// </summary>
    public TerraformValue<string>? MemoryExecutionRoleArn
    {
        get => GetArgument<TerraformValue<string>>("memory_execution_role_arn");
        set => SetArgument("memory_execution_role_arn", value);
    }

    /// <summary>
    /// The memory_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MemoryId is required")]
    public required TerraformValue<string> MemoryId
    {
        get => GetRequiredArgument<TerraformValue<string>>("memory_id");
        set => SetArgument("memory_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The namespaces attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Namespaces is required")]
    public required TerraformSet<string> Namespaces
    {
        get => GetRequiredArgument<TerraformSet<string>>("namespaces");
        set => SetArgument("namespaces", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The memory_strategy_id attribute.
    /// </summary>
    public TerraformValue<string> MemoryStrategyId
        => CreateReference("memory_strategy_id");

    /// <summary>
    /// Configuration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentcoreMemoryStrategyConfigurationBlock>? Configuration
    {
        get => GetArgument<TerraformList<AwsBedrockagentcoreMemoryStrategyConfigurationBlock>>("configuration");
        set => SetArgument("configuration", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsBedrockagentcoreMemoryStrategyTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsBedrockagentcoreMemoryStrategyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
