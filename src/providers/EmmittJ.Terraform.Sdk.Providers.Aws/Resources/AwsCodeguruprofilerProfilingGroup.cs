using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for agent_orchestration_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsCodeguruprofilerProfilingGroupAgentOrchestrationConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The profiling_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProfilingEnabled is required")]
    [TerraformProperty("profiling_enabled")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<bool> ProfilingEnabled { get; set; }

}

/// <summary>
/// Manages a aws_codeguruprofiler_profiling_group resource.
/// </summary>
public partial class AwsCodeguruprofilerProfilingGroup : TerraformResource
{
    public AwsCodeguruprofilerProfilingGroup(string name) : base("aws_codeguruprofiler_profiling_group", name)
    {
    }

    /// <summary>
    /// The compute_platform attribute.
    /// </summary>
    [TerraformProperty("compute_platform")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ComputePlatform { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for agent_orchestration_config.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("agent_orchestration_config")]
    public TerraformList<TerraformBlock<AwsCodeguruprofilerProfilingGroupAgentOrchestrationConfigBlock>>? AgentOrchestrationConfig { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Id { get; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> TagsAll { get; }

}
