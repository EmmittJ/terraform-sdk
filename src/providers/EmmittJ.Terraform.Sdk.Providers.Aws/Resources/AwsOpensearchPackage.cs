using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for package_source in .
/// Nesting mode: list
/// </summary>
public partial class AwsOpensearchPackagePackageSourceBlock() : TerraformBlock("package_source")
{
    /// <summary>
    /// The s3_bucket_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3BucketName is required")]
    [TerraformProperty("s3_bucket_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> S3BucketName { get; set; }

    /// <summary>
    /// The s3_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3Key is required")]
    [TerraformProperty("s3_key")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> S3Key { get; set; }

}

/// <summary>
/// Manages a aws_opensearch_package resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsOpensearchPackage : TerraformResource
{
    public AwsOpensearchPackage(string name) : base("aws_opensearch_package", name)
    {
    }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    [TerraformProperty("engine_version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? EngineVersion { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The package_description attribute.
    /// </summary>
    [TerraformProperty("package_description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PackageDescription { get; set; }

    /// <summary>
    /// The package_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PackageName is required")]
    [TerraformProperty("package_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PackageName { get; set; }

    /// <summary>
    /// The package_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PackageType is required")]
    [TerraformProperty("package_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PackageType { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for package_source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PackageSource is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PackageSource block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PackageSource block(s) allowed")]
    [TerraformProperty("package_source")]
    public required TerraformList<AwsOpensearchPackagePackageSourceBlock> PackageSource { get; set; } = new();

    /// <summary>
    /// The available_package_version attribute.
    /// </summary>
    [TerraformProperty("available_package_version")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AvailablePackageVersion { get; }

    /// <summary>
    /// The package_id attribute.
    /// </summary>
    [TerraformProperty("package_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PackageId { get; }

}
