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
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The resource_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourcePolicy is required")]
    public required TerraformProperty<string> ResourcePolicy
    {
        get => GetProperty<TerraformProperty<string>>("resource_policy");
        set => this.WithProperty("resource_policy", value);
    }

    /// <summary>
    /// The table_bucket_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableBucketArn is required")]
    public required TerraformProperty<string> TableBucketArn
    {
        get => GetProperty<TerraformProperty<string>>("table_bucket_arn");
        set => this.WithProperty("table_bucket_arn", value);
    }

}
