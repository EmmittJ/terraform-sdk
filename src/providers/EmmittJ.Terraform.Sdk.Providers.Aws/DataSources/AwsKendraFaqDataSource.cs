using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_kendra_faq.
/// </summary>
public class AwsKendraFaqDataSource : TerraformDataSource
{
    public AwsKendraFaqDataSource(string name) : base("aws_kendra_faq", name)
    {
    }

    /// <summary>
    /// The faq_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FaqId is required")]
    [TerraformPropertyName("faq_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> FaqId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The index_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IndexId is required")]
    [TerraformPropertyName("index_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> IndexId { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    [TerraformPropertyName("created_at")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreatedAt => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "created_at");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// The error_message attribute.
    /// </summary>
    [TerraformPropertyName("error_message")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ErrorMessage => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "error_message");

    /// <summary>
    /// The file_format attribute.
    /// </summary>
    [TerraformPropertyName("file_format")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> FileFormat => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "file_format");

    /// <summary>
    /// The language_code attribute.
    /// </summary>
    [TerraformPropertyName("language_code")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LanguageCode => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "language_code");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [TerraformPropertyName("role_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RoleArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "role_arn");

    /// <summary>
    /// The s3_path attribute.
    /// </summary>
    [TerraformPropertyName("s3_path")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> S3Path => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "s3_path");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Status => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status");

    /// <summary>
    /// The updated_at attribute.
    /// </summary>
    [TerraformPropertyName("updated_at")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdatedAt => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "updated_at");

}
