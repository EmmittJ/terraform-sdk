using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for configuration_property in .
/// Nesting mode: list
/// </summary>
public partial class AwsCodepipelineCustomActionTypeConfigurationPropertyBlock : TerraformBlockBase
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    [TerraformProperty("key")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<bool> Key { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The queryable attribute.
    /// </summary>
    [TerraformProperty("queryable")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Queryable { get; set; }

    /// <summary>
    /// The required attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Required is required")]
    [TerraformProperty("required")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<bool> Required { get; set; }

    /// <summary>
    /// The secret attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Secret is required")]
    [TerraformProperty("secret")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<bool> Secret { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformProperty("type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Type { get; set; }

}

/// <summary>
/// Block type for input_artifact_details in .
/// Nesting mode: list
/// </summary>
public partial class AwsCodepipelineCustomActionTypeInputArtifactDetailsBlock : TerraformBlockBase
{
    /// <summary>
    /// The maximum_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaximumCount is required")]
    [TerraformProperty("maximum_count")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> MaximumCount { get; set; }

    /// <summary>
    /// The minimum_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinimumCount is required")]
    [TerraformProperty("minimum_count")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> MinimumCount { get; set; }

}

/// <summary>
/// Block type for output_artifact_details in .
/// Nesting mode: list
/// </summary>
public partial class AwsCodepipelineCustomActionTypeOutputArtifactDetailsBlock : TerraformBlockBase
{
    /// <summary>
    /// The maximum_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaximumCount is required")]
    [TerraformProperty("maximum_count")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> MaximumCount { get; set; }

    /// <summary>
    /// The minimum_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinimumCount is required")]
    [TerraformProperty("minimum_count")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> MinimumCount { get; set; }

}

/// <summary>
/// Block type for settings in .
/// Nesting mode: list
/// </summary>
public partial class AwsCodepipelineCustomActionTypeSettingsBlock : TerraformBlockBase
{
    /// <summary>
    /// The entity_url_template attribute.
    /// </summary>
    [TerraformProperty("entity_url_template")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? EntityUrlTemplate { get; set; }

    /// <summary>
    /// The execution_url_template attribute.
    /// </summary>
    [TerraformProperty("execution_url_template")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ExecutionUrlTemplate { get; set; }

    /// <summary>
    /// The revision_url_template attribute.
    /// </summary>
    [TerraformProperty("revision_url_template")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? RevisionUrlTemplate { get; set; }

    /// <summary>
    /// The third_party_configuration_url attribute.
    /// </summary>
    [TerraformProperty("third_party_configuration_url")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ThirdPartyConfigurationUrl { get; set; }

}

/// <summary>
/// Manages a aws_codepipeline_custom_action_type resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsCodepipelineCustomActionType : TerraformResource
{
    public AwsCodepipelineCustomActionType(string name) : base("aws_codepipeline_custom_action_type", name)
    {
    }

    /// <summary>
    /// The category attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Category is required")]
    [TerraformProperty("category")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Category { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The provider_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProviderName is required")]
    [TerraformProperty("provider_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ProviderName { get; set; }

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
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    [TerraformProperty("version")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Version { get; set; }

    /// <summary>
    /// Block for configuration_property.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 ConfigurationProperty block(s) allowed")]
    [TerraformProperty("configuration_property")]
    public TerraformList<TerraformBlock<AwsCodepipelineCustomActionTypeConfigurationPropertyBlock>>? ConfigurationProperty { get; set; }

    /// <summary>
    /// Block for input_artifact_details.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InputArtifactDetails is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 InputArtifactDetails block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InputArtifactDetails block(s) allowed")]
    [TerraformProperty("input_artifact_details")]
    public TerraformList<TerraformBlock<AwsCodepipelineCustomActionTypeInputArtifactDetailsBlock>>? InputArtifactDetails { get; set; }

    /// <summary>
    /// Block for output_artifact_details.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OutputArtifactDetails is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 OutputArtifactDetails block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OutputArtifactDetails block(s) allowed")]
    [TerraformProperty("output_artifact_details")]
    public TerraformList<TerraformBlock<AwsCodepipelineCustomActionTypeOutputArtifactDetailsBlock>>? OutputArtifactDetails { get; set; }

    /// <summary>
    /// Block for settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Settings block(s) allowed")]
    [TerraformProperty("settings")]
    public TerraformList<TerraformBlock<AwsCodepipelineCustomActionTypeSettingsBlock>>? Settings { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The owner attribute.
    /// </summary>
    [TerraformProperty("owner")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Owner { get; }

}
