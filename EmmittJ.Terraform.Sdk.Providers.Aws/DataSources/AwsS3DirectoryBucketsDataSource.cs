using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_s3_directory_buckets.
/// </summary>
public class AwsS3DirectoryBucketsDataSource : TerraformDataSource
{
    public AwsS3DirectoryBucketsDataSource(string name) : base("aws_s3_directory_buckets", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arns");
        this.DeclareOutput("buckets");
        this.DeclareOutput("id");
    }

    /// <summary>
    /// The arns attribute.
    /// </summary>
    public TerraformExpression Arns => this["arns"];

    /// <summary>
    /// The buckets attribute.
    /// </summary>
    public TerraformExpression Buckets => this["buckets"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
