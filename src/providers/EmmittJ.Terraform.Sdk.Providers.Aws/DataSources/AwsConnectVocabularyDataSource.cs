using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_connect_vocabulary.
/// </summary>
public class AwsConnectVocabularyDataSource : TerraformDataSource
{
    public AwsConnectVocabularyDataSource(string name) : base("aws_connect_vocabulary", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceId is required")]
    [TerraformPropertyName("instance_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> InstanceId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Name { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

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
    /// The vocabulary_id attribute.
    /// </summary>
    [TerraformPropertyName("vocabulary_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> VocabularyId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "vocabulary_id");

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
    /// The failure_reason attribute.
    /// </summary>
    [TerraformPropertyName("failure_reason")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> FailureReason => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "failure_reason");

    /// <summary>
    /// The language_code attribute.
    /// </summary>
    [TerraformPropertyName("language_code")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LanguageCode => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "language_code");

    /// <summary>
    /// The last_modified_time attribute.
    /// </summary>
    [TerraformPropertyName("last_modified_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LastModifiedTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "last_modified_time");

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> State => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state");

}
