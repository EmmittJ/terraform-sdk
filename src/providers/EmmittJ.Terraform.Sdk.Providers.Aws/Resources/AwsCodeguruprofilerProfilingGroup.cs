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
        set => SetProperty("profiling_enabled", value);
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
        SetOutput("arn");
        SetOutput("id");
        SetOutput("tags_all");
        SetOutput("compute_platform");
        SetOutput("name");
        SetOutput("region");
        SetOutput("tags");
    }

    /// <summary>
    /// The compute_platform attribute.
    /// </summary>
    public TerraformProperty<string> ComputePlatform
    {
        get => GetRequiredOutput<TerraformProperty<string>>("compute_platform");
        set => SetProperty("compute_platform", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// Block for agent_orchestration_config.
    /// Nesting mode: list
    /// </summary>
    public List<AwsCodeguruprofilerProfilingGroupAgentOrchestrationConfigBlock>? AgentOrchestrationConfig
    {
        set => SetProperty("agent_orchestration_config", value);
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
