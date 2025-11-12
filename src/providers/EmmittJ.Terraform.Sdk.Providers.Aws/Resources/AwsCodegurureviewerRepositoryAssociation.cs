using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for kms_key_details in .
/// Nesting mode: list
/// </summary>
public partial class AwsCodegurureviewerRepositoryAssociationKmsKeyDetailsBlock() : TerraformBlock("kms_key_details")
{
    /// <summary>
    /// The encryption_option attribute.
    /// </summary>
    [TerraformProperty("encryption_option")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? EncryptionOption { get; set; }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformProperty("kms_key_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KmsKeyId { get; set; }

}

/// <summary>
/// Block type for repository in .
/// Nesting mode: list
/// </summary>
public partial class AwsCodegurureviewerRepositoryAssociationRepositoryBlock() : TerraformBlock("repository")
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsCodegurureviewerRepositoryAssociationTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_codegurureviewer_repository_association resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsCodegurureviewerRepositoryAssociation : TerraformResource
{
    public AwsCodegurureviewerRepositoryAssociation(string name) : base("aws_codegurureviewer_repository_association", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

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
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for kms_key_details.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KmsKeyDetails block(s) allowed")]
    [TerraformProperty("kms_key_details")]
    public TerraformList<AwsCodegurureviewerRepositoryAssociationKmsKeyDetailsBlock> KmsKeyDetails { get; set; } = new();

    /// <summary>
    /// Block for repository.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Repository is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Repository block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Repository block(s) allowed")]
    [TerraformProperty("repository")]
    public required TerraformList<AwsCodegurureviewerRepositoryAssociationRepositoryBlock> Repository { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsCodegurureviewerRepositoryAssociationTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The association_id attribute.
    /// </summary>
    [TerraformProperty("association_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AssociationId { get; }

    /// <summary>
    /// The connection_arn attribute.
    /// </summary>
    [TerraformProperty("connection_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ConnectionArn { get; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// The owner attribute.
    /// </summary>
    [TerraformProperty("owner")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Owner { get; }

    /// <summary>
    /// The provider_type attribute.
    /// </summary>
    [TerraformProperty("provider_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ProviderType { get; }

    /// <summary>
    /// The s3_repository_details attribute.
    /// </summary>
    [TerraformProperty("s3_repository_details")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> S3RepositoryDetails { get; }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

    /// <summary>
    /// The state_reason attribute.
    /// </summary>
    [TerraformProperty("state_reason")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> StateReason { get; }

}
