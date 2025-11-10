using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for package_source in .
/// Nesting mode: list
/// </summary>
public class AwsOpensearchPackagePackageSourceBlock : TerraformBlock
{
    /// <summary>
    /// The s3_bucket_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3BucketName is required")]
    public required TerraformProperty<string> S3BucketName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("s3_bucket_name");
        set => WithProperty("s3_bucket_name", value);
    }

    /// <summary>
    /// The s3_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3Key is required")]
    public required TerraformProperty<string> S3Key
    {
        get => GetRequiredProperty<TerraformProperty<string>>("s3_key");
        set => WithProperty("s3_key", value);
    }

}

/// <summary>
/// Manages a aws_opensearch_package resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsOpensearchPackage : TerraformResource
{
    public AwsOpensearchPackage(string name) : base("aws_opensearch_package", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("available_package_version");
        this.WithOutput("package_id");
    }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    public TerraformProperty<string>? EngineVersion
    {
        get => GetProperty<TerraformProperty<string>>("engine_version");
        set => this.WithProperty("engine_version", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The package_description attribute.
    /// </summary>
    public TerraformProperty<string>? PackageDescription
    {
        get => GetProperty<TerraformProperty<string>>("package_description");
        set => this.WithProperty("package_description", value);
    }

    /// <summary>
    /// The package_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PackageName is required")]
    public required TerraformProperty<string> PackageName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("package_name");
        set => this.WithProperty("package_name", value);
    }

    /// <summary>
    /// The package_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PackageType is required")]
    public required TerraformProperty<string> PackageType
    {
        get => GetRequiredProperty<TerraformProperty<string>>("package_type");
        set => this.WithProperty("package_type", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// Block for package_source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PackageSource block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PackageSource block(s) allowed")]
    public List<AwsOpensearchPackagePackageSourceBlock>? PackageSource
    {
        get => GetProperty<List<AwsOpensearchPackagePackageSourceBlock>>("package_source");
        set => this.WithProperty("package_source", value);
    }

    /// <summary>
    /// The available_package_version attribute.
    /// </summary>
    public TerraformExpression AvailablePackageVersion => this["available_package_version"];

    /// <summary>
    /// The package_id attribute.
    /// </summary>
    public TerraformExpression PackageId => this["package_id"];

}
