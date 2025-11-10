using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for human_loop_activation_config in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerFlowDefinitionHumanLoopActivationConfigBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for human_loop_config in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerFlowDefinitionHumanLoopConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The human_task_ui_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HumanTaskUiArn is required")]
    [TerraformPropertyName("human_task_ui_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> HumanTaskUiArn { get; set; }

    /// <summary>
    /// The task_availability_lifetime_in_seconds attribute.
    /// </summary>
    [TerraformPropertyName("task_availability_lifetime_in_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? TaskAvailabilityLifetimeInSeconds { get; set; }

    /// <summary>
    /// The task_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TaskCount is required")]
    [TerraformPropertyName("task_count")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> TaskCount { get; set; }

    /// <summary>
    /// The task_description attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TaskDescription is required")]
    [TerraformPropertyName("task_description")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> TaskDescription { get; set; }

    /// <summary>
    /// The task_keywords attribute.
    /// </summary>
    [TerraformPropertyName("task_keywords")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? TaskKeywords { get; set; }

    /// <summary>
    /// The task_time_limit_in_seconds attribute.
    /// </summary>
    [TerraformPropertyName("task_time_limit_in_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? TaskTimeLimitInSeconds { get; set; }

    /// <summary>
    /// The task_title attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TaskTitle is required")]
    [TerraformPropertyName("task_title")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> TaskTitle { get; set; }

    /// <summary>
    /// The workteam_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkteamArn is required")]
    [TerraformPropertyName("workteam_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> WorkteamArn { get; set; }

}

/// <summary>
/// Block type for human_loop_request_source in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerFlowDefinitionHumanLoopRequestSourceBlock : ITerraformBlock
{
    /// <summary>
    /// The aws_managed_human_loop_request_source attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AwsManagedHumanLoopRequestSource is required")]
    [TerraformPropertyName("aws_managed_human_loop_request_source")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AwsManagedHumanLoopRequestSource { get; set; }

}

/// <summary>
/// Block type for output_config in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerFlowDefinitionOutputConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? KmsKeyId { get; set; }

    /// <summary>
    /// The s3_output_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3OutputPath is required")]
    [TerraformPropertyName("s3_output_path")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> S3OutputPath { get; set; }

}

/// <summary>
/// Manages a aws_sagemaker_flow_definition resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsSagemakerFlowDefinition : TerraformResource
{
    public AwsSagemakerFlowDefinition(string name) : base("aws_sagemaker_flow_definition", name)
    {
    }

    /// <summary>
    /// The flow_definition_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FlowDefinitionName is required")]
    [TerraformPropertyName("flow_definition_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> FlowDefinitionName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformPropertyName("role_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RoleArn { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// Block for human_loop_activation_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HumanLoopActivationConfig block(s) allowed")]
    [TerraformPropertyName("human_loop_activation_config")]
    public TerraformList<TerraformBlock<AwsSagemakerFlowDefinitionHumanLoopActivationConfigBlock>>? HumanLoopActivationConfig { get; set; } = new();

    /// <summary>
    /// Block for human_loop_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HumanLoopConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 HumanLoopConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HumanLoopConfig block(s) allowed")]
    [TerraformPropertyName("human_loop_config")]
    public TerraformList<TerraformBlock<AwsSagemakerFlowDefinitionHumanLoopConfigBlock>>? HumanLoopConfig { get; set; } = new();

    /// <summary>
    /// Block for human_loop_request_source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HumanLoopRequestSource block(s) allowed")]
    [TerraformPropertyName("human_loop_request_source")]
    public TerraformList<TerraformBlock<AwsSagemakerFlowDefinitionHumanLoopRequestSourceBlock>>? HumanLoopRequestSource { get; set; } = new();

    /// <summary>
    /// Block for output_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OutputConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 OutputConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OutputConfig block(s) allowed")]
    [TerraformPropertyName("output_config")]
    public TerraformList<TerraformBlock<AwsSagemakerFlowDefinitionOutputConfigBlock>>? OutputConfig { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

}
