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
        set => SetProperty("s3_bucket_name", value);
    }

    /// <summary>
    /// The s3_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3Key is required")]
    public required TerraformProperty<string> S3Key
    {
        set => SetProperty("s3_key", value);
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
        SetOutput("available_package_version");
        SetOutput("package_id");
        SetOutput("engine_version");
        SetOutput("id");
        SetOutput("package_description");
        SetOutput("package_name");
        SetOutput("package_type");
        SetOutput("region");
    }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    public TerraformProperty<string> EngineVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("engine_version");
        set => SetProperty("engine_version", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The package_description attribute.
    /// </summary>
    public TerraformProperty<string> PackageDescription
    {
        get => GetRequiredOutput<TerraformProperty<string>>("package_description");
        set => SetProperty("package_description", value);
    }

    /// <summary>
    /// The package_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PackageName is required")]
    public required TerraformProperty<string> PackageName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("package_name");
        set => SetProperty("package_name", value);
    }

    /// <summary>
    /// The package_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PackageType is required")]
    public required TerraformProperty<string> PackageType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("package_type");
        set => SetProperty("package_type", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// Block for package_source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PackageSource is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PackageSource block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PackageSource block(s) allowed")]
    public List<AwsOpensearchPackagePackageSourceBlock>? PackageSource
    {
        set => SetProperty("package_source", value);
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
