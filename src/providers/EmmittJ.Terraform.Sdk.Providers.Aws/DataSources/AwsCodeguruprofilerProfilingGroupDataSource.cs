using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_codeguruprofiler_profiling_group Terraform data source.
/// Retrieves information about a aws_codeguruprofiler_profiling_group.
/// </summary>
public partial class AwsCodeguruprofilerProfilingGroupDataSource(string name) : TerraformDataSource("aws_codeguruprofiler_profiling_group", name)
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The agent_orchestration_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> AgentOrchestrationConfig
        => AsReference("agent_orchestration_config");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The compute_platform attribute.
    /// </summary>
    public TerraformValue<string> ComputePlatform
        => AsReference("compute_platform");

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformValue<string> CreatedAt
        => AsReference("created_at");

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// The profiling_status attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ProfilingStatus
        => AsReference("profiling_status");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => AsReference("tags");

    /// <summary>
    /// The updated_at attribute.
    /// </summary>
    public TerraformValue<string> UpdatedAt
        => AsReference("updated_at");

}
