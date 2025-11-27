using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for package_source in AwsOpensearchPackage.
/// Nesting mode: list
/// </summary>
public class AwsOpensearchPackagePackageSourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "package_source";

    /// <summary>
    /// The s3_bucket_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3BucketName is required")]
    public required TerraformValue<string> S3BucketName
    {
        get => new TerraformReference<string>(this, "s3_bucket_name");
        set => SetArgument("s3_bucket_name", value);
    }

    /// <summary>
    /// The s3_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3Key is required")]
    public required TerraformValue<string> S3Key
    {
        get => new TerraformReference<string>(this, "s3_key");
        set => SetArgument("s3_key", value);
    }

}


/// <summary>
/// Represents a aws_opensearch_package Terraform resource.
/// Manages a aws_opensearch_package resource.
/// </summary>
public partial class AwsOpensearchPackage(string name) : TerraformResource("aws_opensearch_package", name)
{
    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    public TerraformValue<string>? EngineVersion
    {
        get => new TerraformReference<string>(this, "engine_version");
        set => SetArgument("engine_version", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The package_description attribute.
    /// </summary>
    public TerraformValue<string>? PackageDescription
    {
        get => new TerraformReference<string>(this, "package_description");
        set => SetArgument("package_description", value);
    }

    /// <summary>
    /// The package_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PackageName is required")]
    public required TerraformValue<string> PackageName
    {
        get => new TerraformReference<string>(this, "package_name");
        set => SetArgument("package_name", value);
    }

    /// <summary>
    /// The package_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PackageType is required")]
    public required TerraformValue<string> PackageType
    {
        get => new TerraformReference<string>(this, "package_type");
        set => SetArgument("package_type", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The available_package_version attribute.
    /// </summary>
    public TerraformValue<string> AvailablePackageVersion
    {
        get => new TerraformReference<string>(this, "available_package_version");
    }

    /// <summary>
    /// The package_id attribute.
    /// </summary>
    public TerraformValue<string> PackageId
    {
        get => new TerraformReference<string>(this, "package_id");
    }

    /// <summary>
    /// PackageSource block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PackageSource is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PackageSource block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PackageSource block(s) allowed")]
    public required TerraformList<AwsOpensearchPackagePackageSourceBlock> PackageSource
    {
        get => GetRequiredArgument<TerraformList<AwsOpensearchPackagePackageSourceBlock>>("package_source");
        set => SetArgument("package_source", value);
    }

}
