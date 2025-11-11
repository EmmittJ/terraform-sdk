using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ssm_document.
/// </summary>
public class AwsSsmDocumentDataSource : TerraformDataSource
{
    public AwsSsmDocumentDataSource(string name) : base("aws_ssm_document", name)
    {
    }

    /// <summary>
    /// The document_format attribute.
    /// </summary>
    [TerraformPropertyName("document_format")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DocumentFormat { get; set; }

    /// <summary>
    /// The document_version attribute.
    /// </summary>
    [TerraformPropertyName("document_version")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DocumentVersion { get; set; }

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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The content attribute.
    /// </summary>
    [TerraformPropertyName("content")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Content => new TerraformReference(this, "content");

    /// <summary>
    /// The document_type attribute.
    /// </summary>
    [TerraformPropertyName("document_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DocumentType => new TerraformReference(this, "document_type");

}
