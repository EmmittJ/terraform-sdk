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
        get => new TerraformReference<bool>(this, "profiling_enabled");
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
        get => new TerraformReference<string>(this, "compute_platform");
        set => SetArgument("compute_platform", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
    }

    /// <summary>
    /// AgentOrchestrationConfig block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsCodeguruprofilerProfilingGroupAgentOrchestrationConfigBlock>? AgentOrchestrationConfig
    {
        get => GetArgument<TerraformList<AwsCodeguruprofilerProfilingGroupAgentOrchestrationConfigBlock>>("agent_orchestration_config");
        set => SetArgument("agent_orchestration_config", value);
    }

}
