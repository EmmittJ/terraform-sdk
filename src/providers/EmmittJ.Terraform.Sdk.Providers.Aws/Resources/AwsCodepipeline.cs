using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for artifact_store in .
/// Nesting mode: set
/// </summary>
public partial class AwsCodepipelineArtifactStoreBlock() : TerraformBlock("artifact_store")
{
    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The region attribute.
    /// </summary>
    [TerraformProperty("region")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Region { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for stage in .
/// Nesting mode: list
/// </summary>
public partial class AwsCodepipelineStageBlock() : TerraformBlock("stage")
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

}

/// <summary>
/// Block type for trigger in .
/// Nesting mode: list
/// </summary>
public partial class AwsCodepipelineTriggerBlock() : TerraformBlock("trigger")
{
    /// <summary>
    /// The provider_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProviderType is required")]
    [TerraformProperty("provider_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ProviderType { get; set; }

}

/// <summary>
/// Block type for variable in .
/// Nesting mode: list
/// </summary>
public partial class AwsCodepipelineVariableBlock() : TerraformBlock("variable")
{
    /// <summary>
    /// The default_value attribute.
    /// </summary>
    [TerraformProperty("default_value")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DefaultValue { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

}

/// <summary>
/// Manages a aws_codepipeline resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsCodepipeline : TerraformResource
{
    public AwsCodepipeline(string name) : base("aws_codepipeline", name)
    {
    }

    /// <summary>
    /// The execution_mode attribute.
    /// </summary>
    [TerraformProperty("execution_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ExecutionMode { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The pipeline_type attribute.
    /// </summary>
    [TerraformProperty("pipeline_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PipelineType { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformProperty("role_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RoleArn { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for artifact_store.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ArtifactStore is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ArtifactStore block(s) required")]
    [TerraformProperty("artifact_store")]
    public required TerraformSet<AwsCodepipelineArtifactStoreBlock> ArtifactStore { get; set; } = new();

    /// <summary>
    /// Block for stage.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(2, ErrorMessage = "At least 2 Stage block(s) required")]
    [TerraformProperty("stage")]
    public TerraformList<AwsCodepipelineStageBlock> Stage { get; set; } = new();

    /// <summary>
    /// Block for trigger.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(50, ErrorMessage = "Maximum 50 Trigger block(s) allowed")]
    [TerraformProperty("trigger")]
    public TerraformList<AwsCodepipelineTriggerBlock> Trigger { get; set; } = new();

    /// <summary>
    /// Block for variable.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("variable")]
    public TerraformList<AwsCodepipelineVariableBlock> Variable { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The trigger_all attribute.
    /// </summary>
    [TerraformProperty("trigger_all")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> TriggerAll { get; }

}
