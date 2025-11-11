using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for enrichment_parameters in .
/// Nesting mode: list
/// </summary>
public class AwsPipesPipeEnrichmentParametersBlock
{
    /// <summary>
    /// The input_template attribute.
    /// </summary>
    [TerraformPropertyName("input_template")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? InputTemplate { get; set; }

}

/// <summary>
/// Block type for log_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsPipesPipeLogConfigurationBlock
{
    /// <summary>
    /// The include_execution_data attribute.
    /// </summary>
    [TerraformPropertyName("include_execution_data")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? IncludeExecutionData { get; set; }

    /// <summary>
    /// The level attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Level is required")]
    [TerraformPropertyName("level")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Level { get; set; }

}

/// <summary>
/// Block type for source_parameters in .
/// Nesting mode: list
/// </summary>
public class AwsPipesPipeSourceParametersBlock
{
}

/// <summary>
/// Block type for target_parameters in .
/// Nesting mode: list
/// </summary>
public class AwsPipesPipeTargetParametersBlock
{
    /// <summary>
    /// The input_template attribute.
    /// </summary>
    [TerraformPropertyName("input_template")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? InputTemplate { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsPipesPipeTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_pipes_pipe resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsPipesPipe : TerraformResource
{
    public AwsPipesPipe(string name) : base("aws_pipes_pipe", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The desired_state attribute.
    /// </summary>
    [TerraformPropertyName("desired_state")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DesiredState { get; set; }

    /// <summary>
    /// The enrichment attribute.
    /// </summary>
    [TerraformPropertyName("enrichment")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Enrichment { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The kms_key_identifier attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_identifier")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? KmsKeyIdentifier { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Name { get; set; } = default!;

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    [TerraformPropertyName("name_prefix")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> NamePrefix { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformPropertyName("role_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RoleArn { get; set; }

    /// <summary>
    /// The source attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    [TerraformPropertyName("source")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Source { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// The target attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Target is required")]
    [TerraformPropertyName("target")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Target { get; set; }

    /// <summary>
    /// Block for enrichment_parameters.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EnrichmentParameters block(s) allowed")]
    [TerraformPropertyName("enrichment_parameters")]
    public TerraformList<TerraformBlock<AwsPipesPipeEnrichmentParametersBlock>>? EnrichmentParameters { get; set; }

    /// <summary>
    /// Block for log_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LogConfiguration block(s) allowed")]
    [TerraformPropertyName("log_configuration")]
    public TerraformList<TerraformBlock<AwsPipesPipeLogConfigurationBlock>>? LogConfiguration { get; set; }

    /// <summary>
    /// Block for source_parameters.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceParameters block(s) allowed")]
    [TerraformPropertyName("source_parameters")]
    public TerraformList<TerraformBlock<AwsPipesPipeSourceParametersBlock>>? SourceParameters { get; set; }

    /// <summary>
    /// Block for target_parameters.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TargetParameters block(s) allowed")]
    [TerraformPropertyName("target_parameters")]
    public TerraformList<TerraformBlock<AwsPipesPipeTargetParametersBlock>>? TargetParameters { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsPipesPipeTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

}
