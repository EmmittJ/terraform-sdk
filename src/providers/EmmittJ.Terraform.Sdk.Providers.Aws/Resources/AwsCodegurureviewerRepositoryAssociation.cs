using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for kms_key_details in .
/// Nesting mode: list
/// </summary>
public class AwsCodegurureviewerRepositoryAssociationKmsKeyDetailsBlock : ITerraformBlock
{
    /// <summary>
    /// The encryption_option attribute.
    /// </summary>
    [TerraformPropertyName("encryption_option")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? EncryptionOption { get; set; }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? KmsKeyId { get; set; }

}

/// <summary>
/// Block type for repository in .
/// Nesting mode: list
/// </summary>
public class AwsCodegurureviewerRepositoryAssociationRepositoryBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsCodegurureviewerRepositoryAssociationTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a aws_codegurureviewer_repository_association resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsCodegurureviewerRepositoryAssociation : TerraformResource
{
    public AwsCodegurureviewerRepositoryAssociation(string name) : base("aws_codegurureviewer_repository_association", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

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
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// Block for kms_key_details.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KmsKeyDetails block(s) allowed")]
    [TerraformPropertyName("kms_key_details")]
    public TerraformList<TerraformBlock<AwsCodegurureviewerRepositoryAssociationKmsKeyDetailsBlock>>? KmsKeyDetails { get; set; } = new();

    /// <summary>
    /// Block for repository.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Repository is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Repository block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Repository block(s) allowed")]
    [TerraformPropertyName("repository")]
    public TerraformList<TerraformBlock<AwsCodegurureviewerRepositoryAssociationRepositoryBlock>>? Repository { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsCodegurureviewerRepositoryAssociationTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The association_id attribute.
    /// </summary>
    [TerraformPropertyName("association_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AssociationId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "association_id");

    /// <summary>
    /// The connection_arn attribute.
    /// </summary>
    [TerraformPropertyName("connection_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ConnectionArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "connection_arn");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The owner attribute.
    /// </summary>
    [TerraformPropertyName("owner")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Owner => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "owner");

    /// <summary>
    /// The provider_type attribute.
    /// </summary>
    [TerraformPropertyName("provider_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ProviderType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "provider_type");

    /// <summary>
    /// The s3_repository_details attribute.
    /// </summary>
    [TerraformPropertyName("s3_repository_details")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> S3RepositoryDetails => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "s3_repository_details");

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> State => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state");

    /// <summary>
    /// The state_reason attribute.
    /// </summary>
    [TerraformPropertyName("state_reason")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StateReason => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state_reason");

}
