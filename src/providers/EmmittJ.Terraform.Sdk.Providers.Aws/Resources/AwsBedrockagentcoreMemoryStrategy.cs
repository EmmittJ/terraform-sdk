using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsBedrockagentcoreMemoryStrategyConfigurationBlock() : TerraformBlock("configuration")
{
    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsBedrockagentcoreMemoryStrategyTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_bedrockagentcore_memory_strategy resource.
/// </summary>
public partial class AwsBedrockagentcoreMemoryStrategy : TerraformResource
{
    public AwsBedrockagentcoreMemoryStrategy(string name) : base("aws_bedrockagentcore_memory_strategy", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The memory_execution_role_arn attribute.
    /// </summary>
    [TerraformProperty("memory_execution_role_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MemoryExecutionRoleArn { get; set; }

    /// <summary>
    /// The memory_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MemoryId is required")]
    [TerraformProperty("memory_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> MemoryId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The namespaces attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Namespaces is required")]
    [TerraformProperty("namespaces")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> Namespaces { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

    /// <summary>
    /// Block for configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("configuration")]
    public TerraformList<AwsBedrockagentcoreMemoryStrategyConfigurationBlock> Configuration { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsBedrockagentcoreMemoryStrategyTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The memory_strategy_id attribute.
    /// </summary>
    [TerraformProperty("memory_strategy_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> MemoryStrategyId { get; }

}
