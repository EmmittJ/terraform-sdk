using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for package_source in .
/// Nesting mode: list
/// </summary>
public class AwsOpensearchPackagePackageSourceBlock : ITerraformBlock
{
    /// <summary>
    /// The s3_bucket_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3BucketName is required")]
    [TerraformPropertyName("s3_bucket_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> S3BucketName { get; set; }

    /// <summary>
    /// The s3_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3Key is required")]
    [TerraformPropertyName("s3_key")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> S3Key { get; set; }

}

/// <summary>
/// Manages a aws_opensearch_package resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsOpensearchPackage : TerraformResource
{
    public AwsOpensearchPackage(string name) : base("aws_opensearch_package", name)
    {
    }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    [TerraformPropertyName("engine_version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? EngineVersion { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The package_description attribute.
    /// </summary>
    [TerraformPropertyName("package_description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PackageDescription { get; set; }

    /// <summary>
    /// The package_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PackageName is required")]
    [TerraformPropertyName("package_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> PackageName { get; set; }

    /// <summary>
    /// The package_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PackageType is required")]
    [TerraformPropertyName("package_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> PackageType { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// Block for package_source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PackageSource is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PackageSource block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PackageSource block(s) allowed")]
    [TerraformPropertyName("package_source")]
    public TerraformList<TerraformBlock<AwsOpensearchPackagePackageSourceBlock>>? PackageSource { get; set; } = new();

    /// <summary>
    /// The available_package_version attribute.
    /// </summary>
    [TerraformPropertyName("available_package_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AvailablePackageVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "available_package_version");

    /// <summary>
    /// The package_id attribute.
    /// </summary>
    [TerraformPropertyName("package_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PackageId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "package_id");

}
