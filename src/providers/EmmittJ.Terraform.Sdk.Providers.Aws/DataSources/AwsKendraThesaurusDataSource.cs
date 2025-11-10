using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_kendra_thesaurus.
/// </summary>
public class AwsKendraThesaurusDataSource : TerraformDataSource
{
    public AwsKendraThesaurusDataSource(string name) : base("aws_kendra_thesaurus", name)
    {
    }

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
    /// The thesaurus_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ThesaurusId is required")]
    [TerraformPropertyName("thesaurus_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ThesaurusId { get; set; }

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
    /// The file_size_bytes attribute.
    /// </summary>
    [TerraformPropertyName("file_size_bytes")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> FileSizeBytes => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "file_size_bytes");

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
    /// The source_s3_path attribute.
    /// </summary>
    [TerraformPropertyName("source_s3_path")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> SourceS3Path => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "source_s3_path");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Status => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status");

    /// <summary>
    /// The synonym_rule_count attribute.
    /// </summary>
    [TerraformPropertyName("synonym_rule_count")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> SynonymRuleCount => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "synonym_rule_count");

    /// <summary>
    /// The term_count attribute.
    /// </summary>
    [TerraformPropertyName("term_count")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> TermCount => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "term_count");

    /// <summary>
    /// The updated_at attribute.
    /// </summary>
    [TerraformPropertyName("updated_at")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdatedAt => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "updated_at");

}
