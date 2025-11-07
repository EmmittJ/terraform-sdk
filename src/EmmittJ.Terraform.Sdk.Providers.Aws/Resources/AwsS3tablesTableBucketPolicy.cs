using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_s3tables_table_bucket_policy resource.
/// </summary>
public class AwsS3tablesTableBucketPolicy : TerraformResource
{
    public AwsS3tablesTableBucketPolicy(string name) : base("aws_s3tables_table_bucket_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The resource_policy attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourcePolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_policy");
        set => this.WithProperty("resource_policy", value);
    }

    /// <summary>
    /// The table_bucket_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TableBucketArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("table_bucket_arn");
        set => this.WithProperty("table_bucket_arn", value);
    }

}
