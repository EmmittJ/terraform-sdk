using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_s3_directory_buckets Terraform data source.
/// Retrieves information about a aws_s3_directory_buckets.
/// </summary>
public partial class AwsS3DirectoryBucketsDataSource(string name) : TerraformDataSource("aws_s3_directory_buckets", name)
{
    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The arns attribute.
    /// </summary>
    public TerraformList<string> Arns
        => CreateReference("arns");

    /// <summary>
    /// The buckets attribute.
    /// </summary>
    public TerraformList<string> Buckets
        => CreateReference("buckets");

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => CreateReference("id");

}
