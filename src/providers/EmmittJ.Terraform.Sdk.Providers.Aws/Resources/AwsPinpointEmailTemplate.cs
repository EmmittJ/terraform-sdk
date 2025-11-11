using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for email_template in .
/// Nesting mode: list
/// </summary>
public class AwsPinpointEmailTemplateEmailTemplateBlock
{
    /// <summary>
    /// The default_substitutions attribute.
    /// </summary>
    [TerraformPropertyName("default_substitutions")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DefaultSubstitutions { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The html_part attribute.
    /// </summary>
    [TerraformPropertyName("html_part")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? HtmlPart { get; set; }

    /// <summary>
    /// The recommender_id attribute.
    /// </summary>
    [TerraformPropertyName("recommender_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RecommenderId { get; set; }

    /// <summary>
    /// The subject attribute.
    /// </summary>
    [TerraformPropertyName("subject")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Subject { get; set; }

    /// <summary>
    /// The text_part attribute.
    /// </summary>
    [TerraformPropertyName("text_part")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TextPart { get; set; }

}

/// <summary>
/// Manages a aws_pinpoint_email_template resource.
/// </summary>
public class AwsPinpointEmailTemplate : TerraformResource
{
    public AwsPinpointEmailTemplate(string name) : base("aws_pinpoint_email_template", name)
    {
    }

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
    /// The template_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TemplateName is required")]
    [TerraformPropertyName("template_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> TemplateName { get; set; }

    /// <summary>
    /// Block for email_template.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("email_template")]
    public TerraformList<TerraformBlock<AwsPinpointEmailTemplateEmailTemplateBlock>>? EmailTemplate { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> TagsAll => new TerraformReference(this, "tags_all");

}
