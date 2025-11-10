using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for agent_orchestration_config in .
/// Nesting mode: list
/// </summary>
public class AwsCodeguruprofilerProfilingGroupAgentOrchestrationConfigBlock : TerraformBlock
{
    /// <summary>
    /// The profiling_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProfilingEnabled is required")]
    public required TerraformProperty<bool> ProfilingEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("profiling_enabled");
        set => WithProperty("profiling_enabled", value);
    }

}

/// <summary>
/// Manages a aws_codeguruprofiler_profiling_group resource.
/// </summary>
public class AwsCodeguruprofilerProfilingGroup : TerraformResource
{
    public AwsCodeguruprofilerProfilingGroup(string name) : base("aws_codeguruprofiler_profiling_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("id");
        this.DeclareOutput("tags_all");
    }

    /// <summary>
    /// The compute_platform attribute.
    /// </summary>
    public TerraformProperty<string>? ComputePlatform
    {
        get => GetProperty<TerraformProperty<string>>("compute_platform");
        set => this.WithProperty("compute_platform", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// Block for agent_orchestration_config.
    /// Nesting mode: list
    /// </summary>
    public List<AwsCodeguruprofilerProfilingGroupAgentOrchestrationConfigBlock>? AgentOrchestrationConfig
    {
        get => GetProperty<List<AwsCodeguruprofilerProfilingGroupAgentOrchestrationConfigBlock>>("agent_orchestration_config");
        set => this.WithProperty("agent_orchestration_config", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

}
