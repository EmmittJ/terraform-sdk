using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for email_template in .
/// Nesting mode: list
/// </summary>
public partial class AwsPinpointEmailTemplateEmailTemplateBlock : TerraformBlockBase
{
    /// <summary>
    /// The default_substitutions attribute.
    /// </summary>
    [TerraformProperty("default_substitutions")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DefaultSubstitutions { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The html_part attribute.
    /// </summary>
    [TerraformProperty("html_part")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? HtmlPart { get; set; }

    /// <summary>
    /// The recommender_id attribute.
    /// </summary>
    [TerraformProperty("recommender_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RecommenderId { get; set; }

    /// <summary>
    /// The subject attribute.
    /// </summary>
    [TerraformProperty("subject")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Subject { get; set; }

    /// <summary>
    /// The text_part attribute.
    /// </summary>
    [TerraformProperty("text_part")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TextPart { get; set; }

}

/// <summary>
/// Manages a aws_pinpoint_email_template resource.
/// </summary>
public partial class AwsPinpointEmailTemplate : TerraformResource
{
    public AwsPinpointEmailTemplate(string name) : base("aws_pinpoint_email_template", name)
    {
    }

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
    /// The template_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TemplateName is required")]
    [TerraformProperty("template_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TemplateName { get; set; }

    /// <summary>
    /// Block for email_template.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("email_template")]
    public partial TerraformList<TerraformBlock<AwsPinpointEmailTemplateEmailTemplateBlock>>? EmailTemplate { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TagsAll { get; }

}
