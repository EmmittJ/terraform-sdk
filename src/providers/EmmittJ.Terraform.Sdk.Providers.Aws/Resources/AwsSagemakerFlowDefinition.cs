using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for human_loop_activation_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsSagemakerFlowDefinitionHumanLoopActivationConfigBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for human_loop_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsSagemakerFlowDefinitionHumanLoopConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The human_task_ui_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HumanTaskUiArn is required")]
    [TerraformProperty("human_task_ui_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> HumanTaskUiArn { get; set; }

    /// <summary>
    /// The task_availability_lifetime_in_seconds attribute.
    /// </summary>
    [TerraformProperty("task_availability_lifetime_in_seconds")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? TaskAvailabilityLifetimeInSeconds { get; set; }

    /// <summary>
    /// The task_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TaskCount is required")]
    [TerraformProperty("task_count")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> TaskCount { get; set; }

    /// <summary>
    /// The task_description attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TaskDescription is required")]
    [TerraformProperty("task_description")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> TaskDescription { get; set; }

    /// <summary>
    /// The task_keywords attribute.
    /// </summary>
    [TerraformProperty("task_keywords")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? TaskKeywords { get; set; }

    /// <summary>
    /// The task_time_limit_in_seconds attribute.
    /// </summary>
    [TerraformProperty("task_time_limit_in_seconds")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? TaskTimeLimitInSeconds { get; set; }

    /// <summary>
    /// The task_title attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TaskTitle is required")]
    [TerraformProperty("task_title")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> TaskTitle { get; set; }

    /// <summary>
    /// The workteam_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkteamArn is required")]
    [TerraformProperty("workteam_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> WorkteamArn { get; set; }

}

/// <summary>
/// Block type for human_loop_request_source in .
/// Nesting mode: list
/// </summary>
public partial class AwsSagemakerFlowDefinitionHumanLoopRequestSourceBlock : TerraformBlockBase
{
    /// <summary>
    /// The aws_managed_human_loop_request_source attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AwsManagedHumanLoopRequestSource is required")]
    [TerraformProperty("aws_managed_human_loop_request_source")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> AwsManagedHumanLoopRequestSource { get; set; }

}

/// <summary>
/// Block type for output_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsSagemakerFlowDefinitionOutputConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformProperty("kms_key_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? KmsKeyId { get; set; }

    /// <summary>
    /// The s3_output_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3OutputPath is required")]
    [TerraformProperty("s3_output_path")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> S3OutputPath { get; set; }

}

/// <summary>
/// Manages a aws_sagemaker_flow_definition resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsSagemakerFlowDefinition : TerraformResource
{
    public AwsSagemakerFlowDefinition(string name) : base("aws_sagemaker_flow_definition", name)
    {
    }

    /// <summary>
    /// The flow_definition_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FlowDefinitionName is required")]
    [TerraformProperty("flow_definition_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> FlowDefinitionName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformProperty("role_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> RoleArn { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for human_loop_activation_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HumanLoopActivationConfig block(s) allowed")]
    [TerraformProperty("human_loop_activation_config")]
    public TerraformList<TerraformBlock<AwsSagemakerFlowDefinitionHumanLoopActivationConfigBlock>>? HumanLoopActivationConfig { get; set; }

    /// <summary>
    /// Block for human_loop_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HumanLoopConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 HumanLoopConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HumanLoopConfig block(s) allowed")]
    [TerraformProperty("human_loop_config")]
    public TerraformList<TerraformBlock<AwsSagemakerFlowDefinitionHumanLoopConfigBlock>>? HumanLoopConfig { get; set; }

    /// <summary>
    /// Block for human_loop_request_source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HumanLoopRequestSource block(s) allowed")]
    [TerraformProperty("human_loop_request_source")]
    public TerraformList<TerraformBlock<AwsSagemakerFlowDefinitionHumanLoopRequestSourceBlock>>? HumanLoopRequestSource { get; set; }

    /// <summary>
    /// Block for output_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OutputConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 OutputConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OutputConfig block(s) allowed")]
    [TerraformProperty("output_config")]
    public TerraformList<TerraformBlock<AwsSagemakerFlowDefinitionOutputConfigBlock>>? OutputConfig { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

}
