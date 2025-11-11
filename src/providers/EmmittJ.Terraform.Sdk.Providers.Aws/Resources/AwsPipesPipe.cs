using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for enrichment_parameters in .
/// Nesting mode: list
/// </summary>
public partial class AwsPipesPipeEnrichmentParametersBlock : TerraformBlockBase
{
    /// <summary>
    /// The input_template attribute.
    /// </summary>
    [TerraformProperty("input_template")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? InputTemplate { get; set; }

}

/// <summary>
/// Block type for log_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsPipesPipeLogConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The include_execution_data attribute.
    /// </summary>
    [TerraformProperty("include_execution_data")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? IncludeExecutionData { get; set; }

    /// <summary>
    /// The level attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Level is required")]
    [TerraformProperty("level")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Level { get; set; }

}

/// <summary>
/// Block type for source_parameters in .
/// Nesting mode: list
/// </summary>
public partial class AwsPipesPipeSourceParametersBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for target_parameters in .
/// Nesting mode: list
/// </summary>
public partial class AwsPipesPipeTargetParametersBlock : TerraformBlockBase
{
    /// <summary>
    /// The input_template attribute.
    /// </summary>
    [TerraformProperty("input_template")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? InputTemplate { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsPipesPipeTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_pipes_pipe resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsPipesPipe : TerraformResource
{
    public AwsPipesPipe(string name) : base("aws_pipes_pipe", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The desired_state attribute.
    /// </summary>
    [TerraformProperty("desired_state")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DesiredState { get; set; }

    /// <summary>
    /// The enrichment attribute.
    /// </summary>
    [TerraformProperty("enrichment")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Enrichment { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The kms_key_identifier attribute.
    /// </summary>
    [TerraformProperty("kms_key_identifier")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KmsKeyIdentifier { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    [TerraformProperty("name_prefix")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> NamePrefix { get; set; }

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
    /// The source attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    [TerraformProperty("source")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Source { get; set; }

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
    /// The target attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Target is required")]
    [TerraformProperty("target")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Target { get; set; }

    /// <summary>
    /// Block for enrichment_parameters.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EnrichmentParameters block(s) allowed")]
    [TerraformProperty("enrichment_parameters")]
    public partial TerraformList<TerraformBlock<AwsPipesPipeEnrichmentParametersBlock>>? EnrichmentParameters { get; set; }

    /// <summary>
    /// Block for log_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LogConfiguration block(s) allowed")]
    [TerraformProperty("log_configuration")]
    public partial TerraformList<TerraformBlock<AwsPipesPipeLogConfigurationBlock>>? LogConfiguration { get; set; }

    /// <summary>
    /// Block for source_parameters.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceParameters block(s) allowed")]
    [TerraformProperty("source_parameters")]
    public partial TerraformList<TerraformBlock<AwsPipesPipeSourceParametersBlock>>? SourceParameters { get; set; }

    /// <summary>
    /// Block for target_parameters.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TargetParameters block(s) allowed")]
    [TerraformProperty("target_parameters")]
    public partial TerraformList<TerraformBlock<AwsPipesPipeTargetParametersBlock>>? TargetParameters { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsPipesPipeTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

}
