using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for acl_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsAthenaDatabaseAclConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The s3_acl_option attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3AclOption is required")]
    [TerraformProperty("s3_acl_option")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> S3AclOption { get; set; }

}

/// <summary>
/// Block type for encryption_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsAthenaDatabaseEncryptionConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The encryption_option attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EncryptionOption is required")]
    [TerraformProperty("encryption_option")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> EncryptionOption { get; set; }

    /// <summary>
    /// The kms_key attribute.
    /// </summary>
    [TerraformProperty("kms_key")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? KmsKey { get; set; }

}

/// <summary>
/// Manages a aws_athena_database resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsAthenaDatabase : TerraformResource
{
    public AwsAthenaDatabase(string name) : base("aws_athena_database", name)
    {
    }

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [TerraformProperty("bucket")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Bucket { get; set; }

    /// <summary>
    /// The comment attribute.
    /// </summary>
    [TerraformProperty("comment")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Comment { get; set; }

    /// <summary>
    /// The expected_bucket_owner attribute.
    /// </summary>
    [TerraformProperty("expected_bucket_owner")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ExpectedBucketOwner { get; set; }

    /// <summary>
    /// The force_destroy attribute.
    /// </summary>
    [TerraformProperty("force_destroy")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? ForceDestroy { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The properties attribute.
    /// </summary>
    [TerraformProperty("properties")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Properties { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The workgroup attribute.
    /// </summary>
    [TerraformProperty("workgroup")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Workgroup { get; set; }

    /// <summary>
    /// Block for acl_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AclConfiguration block(s) allowed")]
    [TerraformProperty("acl_configuration")]
    public TerraformList<TerraformBlock<AwsAthenaDatabaseAclConfigurationBlock>>? AclConfiguration { get; set; }

    /// <summary>
    /// Block for encryption_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionConfiguration block(s) allowed")]
    [TerraformProperty("encryption_configuration")]
    public TerraformList<TerraformBlock<AwsAthenaDatabaseEncryptionConfigurationBlock>>? EncryptionConfiguration { get; set; }

}
