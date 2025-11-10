using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for human_loop_activation_config in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerFlowDefinitionHumanLoopActivationConfigBlock : TerraformBlock
{
}

/// <summary>
/// Block type for human_loop_config in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerFlowDefinitionHumanLoopConfigBlock : TerraformBlock
{
    /// <summary>
    /// The human_task_ui_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HumanTaskUiArn is required")]
    public required TerraformProperty<string> HumanTaskUiArn
    {
        get => GetRequiredProperty<TerraformProperty<string>>("human_task_ui_arn");
        set => WithProperty("human_task_ui_arn", value);
    }

    /// <summary>
    /// The task_availability_lifetime_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? TaskAvailabilityLifetimeInSeconds
    {
        get => GetProperty<TerraformProperty<double>>("task_availability_lifetime_in_seconds");
        set => WithProperty("task_availability_lifetime_in_seconds", value);
    }

    /// <summary>
    /// The task_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TaskCount is required")]
    public required TerraformProperty<double> TaskCount
    {
        get => GetRequiredProperty<TerraformProperty<double>>("task_count");
        set => WithProperty("task_count", value);
    }

    /// <summary>
    /// The task_description attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TaskDescription is required")]
    public required TerraformProperty<string> TaskDescription
    {
        get => GetRequiredProperty<TerraformProperty<string>>("task_description");
        set => WithProperty("task_description", value);
    }

    /// <summary>
    /// The task_keywords attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? TaskKeywords
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("task_keywords");
        set => WithProperty("task_keywords", value);
    }

    /// <summary>
    /// The task_time_limit_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? TaskTimeLimitInSeconds
    {
        get => GetProperty<TerraformProperty<double>>("task_time_limit_in_seconds");
        set => WithProperty("task_time_limit_in_seconds", value);
    }

    /// <summary>
    /// The task_title attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TaskTitle is required")]
    public required TerraformProperty<string> TaskTitle
    {
        get => GetRequiredProperty<TerraformProperty<string>>("task_title");
        set => WithProperty("task_title", value);
    }

    /// <summary>
    /// The workteam_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkteamArn is required")]
    public required TerraformProperty<string> WorkteamArn
    {
        get => GetRequiredProperty<TerraformProperty<string>>("workteam_arn");
        set => WithProperty("workteam_arn", value);
    }

}

/// <summary>
/// Block type for human_loop_request_source in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerFlowDefinitionHumanLoopRequestSourceBlock : TerraformBlock
{
    /// <summary>
    /// The aws_managed_human_loop_request_source attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AwsManagedHumanLoopRequestSource is required")]
    public required TerraformProperty<string> AwsManagedHumanLoopRequestSource
    {
        get => GetRequiredProperty<TerraformProperty<string>>("aws_managed_human_loop_request_source");
        set => WithProperty("aws_managed_human_loop_request_source", value);
    }

}

/// <summary>
/// Block type for output_config in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerFlowDefinitionOutputConfigBlock : TerraformBlock
{
    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKeyId
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_id");
        set => WithProperty("kms_key_id", value);
    }

    /// <summary>
    /// The s3_output_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3OutputPath is required")]
    public required TerraformProperty<string> S3OutputPath
    {
        get => GetRequiredProperty<TerraformProperty<string>>("s3_output_path");
        set => WithProperty("s3_output_path", value);
    }

}

/// <summary>
/// Manages a aws_sagemaker_flow_definition resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsSagemakerFlowDefinition : TerraformResource
{
    public AwsSagemakerFlowDefinition(string name) : base("aws_sagemaker_flow_definition", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The flow_definition_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FlowDefinitionName is required")]
    public required TerraformProperty<string> FlowDefinitionName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("flow_definition_name");
        set => this.WithProperty("flow_definition_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
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
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        get => GetRequiredProperty<TerraformProperty<string>>("role_arn");
        set => this.WithProperty("role_arn", value);
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
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// Block for human_loop_activation_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HumanLoopActivationConfig block(s) allowed")]
    public List<AwsSagemakerFlowDefinitionHumanLoopActivationConfigBlock>? HumanLoopActivationConfig
    {
        get => GetProperty<List<AwsSagemakerFlowDefinitionHumanLoopActivationConfigBlock>>("human_loop_activation_config");
        set => this.WithProperty("human_loop_activation_config", value);
    }

    /// <summary>
    /// Block for human_loop_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 HumanLoopConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HumanLoopConfig block(s) allowed")]
    public List<AwsSagemakerFlowDefinitionHumanLoopConfigBlock>? HumanLoopConfig
    {
        get => GetProperty<List<AwsSagemakerFlowDefinitionHumanLoopConfigBlock>>("human_loop_config");
        set => this.WithProperty("human_loop_config", value);
    }

    /// <summary>
    /// Block for human_loop_request_source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HumanLoopRequestSource block(s) allowed")]
    public List<AwsSagemakerFlowDefinitionHumanLoopRequestSourceBlock>? HumanLoopRequestSource
    {
        get => GetProperty<List<AwsSagemakerFlowDefinitionHumanLoopRequestSourceBlock>>("human_loop_request_source");
        set => this.WithProperty("human_loop_request_source", value);
    }

    /// <summary>
    /// Block for output_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 OutputConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OutputConfig block(s) allowed")]
    public List<AwsSagemakerFlowDefinitionOutputConfigBlock>? OutputConfig
    {
        get => GetProperty<List<AwsSagemakerFlowDefinitionOutputConfigBlock>>("output_config");
        set => this.WithProperty("output_config", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
