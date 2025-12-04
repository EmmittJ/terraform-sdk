using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for agent_orchestration_config in AwsCodeguruprofilerProfilingGroup.
/// Nesting mode: list
/// </summary>
public class AwsCodeguruprofilerProfilingGroupAgentOrchestrationConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "agent_orchestration_config";

    /// <summary>
    /// The profiling_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProfilingEnabled is required")]
    public required TerraformValue<bool> ProfilingEnabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("profiling_enabled");
        set => SetArgument("profiling_enabled", value);
    }

}


/// <summary>
/// Represents a aws_codeguruprofiler_profiling_group Terraform resource.
/// Manages a aws_codeguruprofiler_profiling_group resource.
/// </summary>
public partial class AwsCodeguruprofilerProfilingGroup(string name) : TerraformResource("aws_codeguruprofiler_profiling_group", name)
{
    /// <summary>
    /// The compute_platform attribute.
    /// </summary>
    public TerraformValue<string> ComputePlatform
    {
        get => GetArgument<TerraformValue<string>>("compute_platform") ?? AsReference("compute_platform");
        set => SetArgument("compute_platform", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
        => AsReference("tags_all");

    /// <summary>
    /// AgentOrchestrationConfig block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsCodeguruprofilerProfilingGroupAgentOrchestrationConfigBlock>? AgentOrchestrationConfig
    {
        get => GetArgument<TerraformList<AwsCodeguruprofilerProfilingGroupAgentOrchestrationConfigBlock>>("agent_orchestration_config");
        set => SetArgument("agent_orchestration_config", value);
    }

}
