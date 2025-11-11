using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for definition in .
/// Nesting mode: list
/// </summary>
public partial class AwsQuicksightAnalysisDefinitionBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for parameters in .
/// Nesting mode: list
/// </summary>
public partial class AwsQuicksightAnalysisParametersBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for permissions in .
/// Nesting mode: set
/// </summary>
public partial class AwsQuicksightAnalysisPermissionsBlock : TerraformBlockBase
{
    /// <summary>
    /// The actions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Actions is required")]
    [TerraformProperty("actions")]
    // Required argument - source generator will implement get/set
    public required TerraformSet<string> Actions { get; set; }

    /// <summary>
    /// The principal attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Principal is required")]
    [TerraformProperty("principal")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Principal { get; set; }

}

/// <summary>
/// Block type for source_entity in .
/// Nesting mode: list
/// </summary>
public partial class AwsQuicksightAnalysisSourceEntityBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsQuicksightAnalysisTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_quicksight_analysis resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsQuicksightAnalysis : TerraformResource
{
    public AwsQuicksightAnalysis(string name) : base("aws_quicksight_analysis", name)
    {
    }

    /// <summary>
    /// The analysis_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AnalysisId is required")]
    [TerraformProperty("analysis_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> AnalysisId { get; set; }

    /// <summary>
    /// The aws_account_id attribute.
    /// </summary>
    [TerraformProperty("aws_account_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> AwsAccountId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The recovery_window_in_days attribute.
    /// </summary>
    [TerraformProperty("recovery_window_in_days")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? RecoveryWindowInDays { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

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
    /// The theme_arn attribute.
    /// </summary>
    [TerraformProperty("theme_arn")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ThemeArn { get; set; }

    /// <summary>
    /// Block for definition.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Definition block(s) allowed")]
    [TerraformProperty("definition")]
    public TerraformList<TerraformBlock<AwsQuicksightAnalysisDefinitionBlock>>? Definition { get; set; }

    /// <summary>
    /// Block for parameters.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Parameters block(s) allowed")]
    [TerraformProperty("parameters")]
    public TerraformList<TerraformBlock<AwsQuicksightAnalysisParametersBlock>>? Parameters { get; set; }

    /// <summary>
    /// Block for permissions.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(64, ErrorMessage = "Maximum 64 Permissions block(s) allowed")]
    [TerraformProperty("permissions")]
    public TerraformSet<TerraformBlock<AwsQuicksightAnalysisPermissionsBlock>>? Permissions { get; set; }

    /// <summary>
    /// Block for source_entity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceEntity block(s) allowed")]
    [TerraformProperty("source_entity")]
    public TerraformList<TerraformBlock<AwsQuicksightAnalysisSourceEntityBlock>>? SourceEntity { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AwsQuicksightAnalysisTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The created_time attribute.
    /// </summary>
    [TerraformProperty("created_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreatedTime { get; }

    /// <summary>
    /// The last_published_time attribute.
    /// </summary>
    [TerraformProperty("last_published_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LastPublishedTime { get; }

    /// <summary>
    /// The last_updated_time attribute.
    /// </summary>
    [TerraformProperty("last_updated_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LastUpdatedTime { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Status { get; }

}
