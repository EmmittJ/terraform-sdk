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
        get => GetRequiredArgument<TerraformValue<string>>("s3_bucket_name");
        set => SetArgument("s3_bucket_name", value);
    }

    /// <summary>
    /// The s3_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3Key is required")]
    public required TerraformValue<string> S3Key
    {
        get => GetRequiredArgument<TerraformValue<string>>("s3_key");
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
        get => GetArgument<TerraformValue<string>>("engine_version");
        set => SetArgument("engine_version", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The package_description attribute.
    /// </summary>
    public TerraformValue<string>? PackageDescription
    {
        get => GetArgument<TerraformValue<string>>("package_description");
        set => SetArgument("package_description", value);
    }

    /// <summary>
    /// The package_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PackageName is required")]
    public required TerraformValue<string> PackageName
    {
        get => GetRequiredArgument<TerraformValue<string>>("package_name");
        set => SetArgument("package_name", value);
    }

    /// <summary>
    /// The package_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PackageType is required")]
    public required TerraformValue<string> PackageType
    {
        get => GetRequiredArgument<TerraformValue<string>>("package_type");
        set => SetArgument("package_type", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The available_package_version attribute.
    /// </summary>
    public TerraformValue<string> AvailablePackageVersion
        => CreateReference("available_package_version");

    /// <summary>
    /// The package_id attribute.
    /// </summary>
    public TerraformValue<string> PackageId
        => CreateReference("package_id");

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
