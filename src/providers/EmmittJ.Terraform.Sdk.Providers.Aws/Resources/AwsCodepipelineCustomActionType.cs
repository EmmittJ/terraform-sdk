using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for configuration_property in .
/// Nesting mode: list
/// </summary>
public class AwsCodepipelineCustomActionTypeConfigurationPropertyBlock : ITerraformBlock
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    [TerraformPropertyName("key")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> Key { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The queryable attribute.
    /// </summary>
    [TerraformPropertyName("queryable")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Queryable { get; set; }

    /// <summary>
    /// The required attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Required is required")]
    [TerraformPropertyName("required")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> Required { get; set; }

    /// <summary>
    /// The secret attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Secret is required")]
    [TerraformPropertyName("secret")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> Secret { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Type { get; set; }

}

/// <summary>
/// Block type for input_artifact_details in .
/// Nesting mode: list
/// </summary>
public class AwsCodepipelineCustomActionTypeInputArtifactDetailsBlock : ITerraformBlock
{
    /// <summary>
    /// The maximum_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaximumCount is required")]
    [TerraformPropertyName("maximum_count")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> MaximumCount { get; set; }

    /// <summary>
    /// The minimum_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinimumCount is required")]
    [TerraformPropertyName("minimum_count")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> MinimumCount { get; set; }

}

/// <summary>
/// Block type for output_artifact_details in .
/// Nesting mode: list
/// </summary>
public class AwsCodepipelineCustomActionTypeOutputArtifactDetailsBlock : ITerraformBlock
{
    /// <summary>
    /// The maximum_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaximumCount is required")]
    [TerraformPropertyName("maximum_count")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> MaximumCount { get; set; }

    /// <summary>
    /// The minimum_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinimumCount is required")]
    [TerraformPropertyName("minimum_count")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> MinimumCount { get; set; }

}

/// <summary>
/// Block type for settings in .
/// Nesting mode: list
/// </summary>
public class AwsCodepipelineCustomActionTypeSettingsBlock : ITerraformBlock
{
    /// <summary>
    /// The entity_url_template attribute.
    /// </summary>
    [TerraformPropertyName("entity_url_template")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? EntityUrlTemplate { get; set; }

    /// <summary>
    /// The execution_url_template attribute.
    /// </summary>
    [TerraformPropertyName("execution_url_template")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ExecutionUrlTemplate { get; set; }

    /// <summary>
    /// The revision_url_template attribute.
    /// </summary>
    [TerraformPropertyName("revision_url_template")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RevisionUrlTemplate { get; set; }

    /// <summary>
    /// The third_party_configuration_url attribute.
    /// </summary>
    [TerraformPropertyName("third_party_configuration_url")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ThirdPartyConfigurationUrl { get; set; }

}

/// <summary>
/// Manages a aws_codepipeline_custom_action_type resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsCodepipelineCustomActionType : TerraformResource
{
    public AwsCodepipelineCustomActionType(string name) : base("aws_codepipeline_custom_action_type", name)
    {
    }

    /// <summary>
    /// The category attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Category is required")]
    [TerraformPropertyName("category")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Category { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The provider_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProviderName is required")]
    [TerraformPropertyName("provider_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ProviderName { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

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
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    [TerraformPropertyName("version")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Version { get; set; }

    /// <summary>
    /// Block for configuration_property.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 ConfigurationProperty block(s) allowed")]
    [TerraformPropertyName("configuration_property")]
    public TerraformList<TerraformBlock<AwsCodepipelineCustomActionTypeConfigurationPropertyBlock>>? ConfigurationProperty { get; set; } = new();

    /// <summary>
    /// Block for input_artifact_details.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InputArtifactDetails is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 InputArtifactDetails block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InputArtifactDetails block(s) allowed")]
    [TerraformPropertyName("input_artifact_details")]
    public TerraformList<TerraformBlock<AwsCodepipelineCustomActionTypeInputArtifactDetailsBlock>>? InputArtifactDetails { get; set; } = new();

    /// <summary>
    /// Block for output_artifact_details.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OutputArtifactDetails is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 OutputArtifactDetails block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OutputArtifactDetails block(s) allowed")]
    [TerraformPropertyName("output_artifact_details")]
    public TerraformList<TerraformBlock<AwsCodepipelineCustomActionTypeOutputArtifactDetailsBlock>>? OutputArtifactDetails { get; set; } = new();

    /// <summary>
    /// Block for settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Settings block(s) allowed")]
    [TerraformPropertyName("settings")]
    public TerraformList<TerraformBlock<AwsCodepipelineCustomActionTypeSettingsBlock>>? Settings { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The owner attribute.
    /// </summary>
    [TerraformPropertyName("owner")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Owner => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "owner");

}
