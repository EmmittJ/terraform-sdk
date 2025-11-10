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
    public TerraformProperty<TerraformProperty<string>>? DocumentFormat { get; set; }

    /// <summary>
    /// The document_version attribute.
    /// </summary>
    [TerraformPropertyName("document_version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DocumentVersion { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The content attribute.
    /// </summary>
    [TerraformPropertyName("content")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Content => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "content");

    /// <summary>
    /// The document_type attribute.
    /// </summary>
    [TerraformPropertyName("document_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DocumentType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "document_type");

}
