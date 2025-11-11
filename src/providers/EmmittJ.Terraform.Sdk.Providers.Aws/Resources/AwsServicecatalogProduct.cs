using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for provisioning_artifact_parameters in .
/// Nesting mode: list
/// </summary>
public class AwsServicecatalogProductProvisioningArtifactParametersBlock
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The disable_template_validation attribute.
    /// </summary>
    [TerraformPropertyName("disable_template_validation")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? DisableTemplateValidation { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Name { get; set; }

    /// <summary>
    /// The template_physical_id attribute.
    /// </summary>
    [TerraformPropertyName("template_physical_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TemplatePhysicalId { get; set; }

    /// <summary>
    /// The template_url attribute.
    /// </summary>
    [TerraformPropertyName("template_url")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TemplateUrl { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Type { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsServicecatalogProductTimeoutsBlock
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
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_servicecatalog_product resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsServicecatalogProduct : TerraformResource
{
    public AwsServicecatalogProduct(string name) : base("aws_servicecatalog_product", name)
    {
    }

    /// <summary>
    /// The accept_language attribute.
    /// </summary>
    [TerraformPropertyName("accept_language")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AcceptLanguage { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Description { get; set; } = default!;

    /// <summary>
    /// The distributor attribute.
    /// </summary>
    [TerraformPropertyName("distributor")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Distributor { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The owner attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Owner is required")]
    [TerraformPropertyName("owner")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Owner { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The support_description attribute.
    /// </summary>
    [TerraformPropertyName("support_description")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> SupportDescription { get; set; } = default!;

    /// <summary>
    /// The support_email attribute.
    /// </summary>
    [TerraformPropertyName("support_email")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> SupportEmail { get; set; } = default!;

    /// <summary>
    /// The support_url attribute.
    /// </summary>
    [TerraformPropertyName("support_url")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> SupportUrl { get; set; } = default!;

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
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Type { get; set; }

    /// <summary>
    /// Block for provisioning_artifact_parameters.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProvisioningArtifactParameters is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ProvisioningArtifactParameters block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ProvisioningArtifactParameters block(s) allowed")]
    [TerraformPropertyName("provisioning_artifact_parameters")]
    public TerraformList<TerraformBlock<AwsServicecatalogProductProvisioningArtifactParametersBlock>>? ProvisioningArtifactParameters { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsServicecatalogProductTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The created_time attribute.
    /// </summary>
    [TerraformPropertyName("created_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreatedTime => new TerraformReference(this, "created_time");

    /// <summary>
    /// The has_default_path attribute.
    /// </summary>
    [TerraformPropertyName("has_default_path")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> HasDefaultPath => new TerraformReference(this, "has_default_path");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Status => new TerraformReference(this, "status");

}
