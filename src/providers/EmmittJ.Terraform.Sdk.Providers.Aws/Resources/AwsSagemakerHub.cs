using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for s3_storage_config in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerHubS3StorageConfigBlock
{
    /// <summary>
    /// The s3_output_path attribute.
    /// </summary>
    [TerraformPropertyName("s3_output_path")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? S3OutputPath { get; set; }

}

/// <summary>
/// Manages a aws_sagemaker_hub resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsSagemakerHub : TerraformResource
{
    public AwsSagemakerHub(string name) : base("aws_sagemaker_hub", name)
    {
    }

    /// <summary>
    /// The hub_description attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HubDescription is required")]
    [TerraformPropertyName("hub_description")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> HubDescription { get; set; }

    /// <summary>
    /// The hub_display_name attribute.
    /// </summary>
    [TerraformPropertyName("hub_display_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? HubDisplayName { get; set; }

    /// <summary>
    /// The hub_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HubName is required")]
    [TerraformPropertyName("hub_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> HubName { get; set; }

    /// <summary>
    /// The hub_search_keywords attribute.
    /// </summary>
    [TerraformPropertyName("hub_search_keywords")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? HubSearchKeywords { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

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
    /// Block for s3_storage_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3StorageConfig block(s) allowed")]
    [TerraformPropertyName("s3_storage_config")]
    public TerraformList<TerraformBlock<AwsSagemakerHubS3StorageConfigBlock>>? S3StorageConfig { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

}
