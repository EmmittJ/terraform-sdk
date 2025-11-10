using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for email_template in .
/// Nesting mode: list
/// </summary>
public class AwsPinpointEmailTemplateEmailTemplateBlock : ITerraformBlock
{
    /// <summary>
    /// The default_substitutions attribute.
    /// </summary>
    [TerraformPropertyName("default_substitutions")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DefaultSubstitutions { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The html_part attribute.
    /// </summary>
    [TerraformPropertyName("html_part")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? HtmlPart { get; set; }

    /// <summary>
    /// The recommender_id attribute.
    /// </summary>
    [TerraformPropertyName("recommender_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RecommenderId { get; set; }

    /// <summary>
    /// The subject attribute.
    /// </summary>
    [TerraformPropertyName("subject")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Subject { get; set; }

    /// <summary>
    /// The text_part attribute.
    /// </summary>
    [TerraformPropertyName("text_part")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TextPart { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The template_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TemplateName is required")]
    [TerraformPropertyName("template_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> TemplateName { get; set; }

    /// <summary>
    /// Block for email_template.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("email_template")]
    public TerraformList<TerraformBlock<AwsPinpointEmailTemplateEmailTemplateBlock>>? EmailTemplate { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

}
