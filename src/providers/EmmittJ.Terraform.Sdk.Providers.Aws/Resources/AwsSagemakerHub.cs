using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for s3_storage_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsSagemakerHubS3StorageConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The s3_output_path attribute.
    /// </summary>
    [TerraformProperty("s3_output_path")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? S3OutputPath { get; set; }

}

/// <summary>
/// Manages a aws_sagemaker_hub resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsSagemakerHub : TerraformResource
{
    public AwsSagemakerHub(string name) : base("aws_sagemaker_hub", name)
    {
    }

    /// <summary>
    /// The hub_description attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HubDescription is required")]
    [TerraformProperty("hub_description")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> HubDescription { get; set; }

    /// <summary>
    /// The hub_display_name attribute.
    /// </summary>
    [TerraformProperty("hub_display_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? HubDisplayName { get; set; }

    /// <summary>
    /// The hub_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HubName is required")]
    [TerraformProperty("hub_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> HubName { get; set; }

    /// <summary>
    /// The hub_search_keywords attribute.
    /// </summary>
    [TerraformProperty("hub_search_keywords")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? HubSearchKeywords { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

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
    /// Block for s3_storage_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3StorageConfig block(s) allowed")]
    [TerraformProperty("s3_storage_config")]
    public partial TerraformList<TerraformBlock<AwsSagemakerHubS3StorageConfigBlock>>? S3StorageConfig { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

}
