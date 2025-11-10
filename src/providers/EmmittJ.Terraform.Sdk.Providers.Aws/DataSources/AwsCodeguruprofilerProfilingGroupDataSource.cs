using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_codeguruprofiler_profiling_group.
/// </summary>
public class AwsCodeguruprofilerProfilingGroupDataSource : TerraformDataSource
{
    public AwsCodeguruprofilerProfilingGroupDataSource(string name) : base("aws_codeguruprofiler_profiling_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("agent_orchestration_config");
        SetOutput("arn");
        SetOutput("compute_platform");
        SetOutput("created_at");
        SetOutput("id");
        SetOutput("profiling_status");
        SetOutput("tags");
        SetOutput("updated_at");
        SetOutput("name");
        SetOutput("region");
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
    /// The agent_orchestration_config attribute.
    /// </summary>
    public TerraformExpression AgentOrchestrationConfig => this["agent_orchestration_config"];

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The compute_platform attribute.
    /// </summary>
    public TerraformExpression ComputePlatform => this["compute_platform"];

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformExpression CreatedAt => this["created_at"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The profiling_status attribute.
    /// </summary>
    public TerraformExpression ProfilingStatus => this["profiling_status"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The updated_at attribute.
    /// </summary>
    public TerraformExpression UpdatedAt => this["updated_at"];

}
