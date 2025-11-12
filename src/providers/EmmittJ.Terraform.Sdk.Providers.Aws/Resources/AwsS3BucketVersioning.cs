using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for versioning_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsS3BucketVersioningVersioningConfigurationBlock() : TerraformBlock("versioning_configuration")
{
    /// <summary>
    /// The mfa_delete attribute.
    /// </summary>
    [TerraformProperty("mfa_delete")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> MfaDelete { get; set; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Status is required")]
    [TerraformProperty("status")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Status { get; set; }

}

/// <summary>
/// Manages a aws_s3_bucket_versioning resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsS3BucketVersioning : TerraformResource
{
    public AwsS3BucketVersioning(string name) : base("aws_s3_bucket_versioning", name)
    {
    }

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    [TerraformProperty("bucket")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Bucket { get; set; }

    /// <summary>
    /// The expected_bucket_owner attribute.
    /// </summary>
    [TerraformProperty("expected_bucket_owner")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ExpectedBucketOwner { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The mfa attribute.
    /// </summary>
    [TerraformProperty("mfa")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Mfa { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for versioning_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VersioningConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 VersioningConfiguration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VersioningConfiguration block(s) allowed")]
    [TerraformProperty("versioning_configuration")]
    public required TerraformList<AwsS3BucketVersioningVersioningConfigurationBlock> VersioningConfiguration { get; set; } = new();

}
