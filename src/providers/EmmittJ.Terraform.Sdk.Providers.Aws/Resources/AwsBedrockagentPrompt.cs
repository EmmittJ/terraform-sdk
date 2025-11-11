using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for variant in .
/// Nesting mode: list
/// </summary>
public partial class AwsBedrockagentPromptVariantBlock : TerraformBlockBase
{
    /// <summary>
    /// The additional_model_request_fields attribute.
    /// </summary>
    [TerraformProperty("additional_model_request_fields")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? AdditionalModelRequestFields { get; set; }

    /// <summary>
    /// The model_id attribute.
    /// </summary>
    [TerraformProperty("model_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ModelId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The template_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TemplateType is required")]
    [TerraformProperty("template_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> TemplateType { get; set; }

}

/// <summary>
/// Manages a aws_bedrockagent_prompt resource.
/// </summary>
public partial class AwsBedrockagentPrompt : TerraformResource
{
    public AwsBedrockagentPrompt(string name) : base("aws_bedrockagent_prompt", name)
    {
    }

    /// <summary>
    /// The customer_encryption_key_arn attribute.
    /// </summary>
    [TerraformProperty("customer_encryption_key_arn")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CustomerEncryptionKeyArn { get; set; }

    /// <summary>
    /// The default_variant attribute.
    /// </summary>
    [TerraformProperty("default_variant")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DefaultVariant { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

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
    /// Block for variant.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("variant")]
    public TerraformList<TerraformBlock<AwsBedrockagentPromptVariantBlock>>? Variant { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    [TerraformProperty("created_at")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreatedAt { get; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Id { get; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> TagsAll { get; }

    /// <summary>
    /// The updated_at attribute.
    /// </summary>
    [TerraformProperty("updated_at")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> UpdatedAt { get; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformProperty("version")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Version { get; }

}
