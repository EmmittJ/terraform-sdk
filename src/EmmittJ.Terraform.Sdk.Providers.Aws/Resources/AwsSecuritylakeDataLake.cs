using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_securitylake_data_lake resource.
/// </summary>
public class AwsSecuritylakeDataLake : TerraformResource
{
    public AwsSecuritylakeDataLake(string name) : base("aws_securitylake_data_lake", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("id");
        this.DeclareOutput("s3_bucket_arn");
        this.DeclareOutput("tags_all");
    }

    /// <summary>
    /// The meta_store_manager_role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? MetaStoreManagerRoleArn
    {
        get => GetProperty<TerraformProperty<string>>("meta_store_manager_role_arn");
        set => this.WithProperty("meta_store_manager_role_arn", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The s3_bucket_arn attribute.
    /// </summary>
    public TerraformExpression S3BucketArn => this["s3_bucket_arn"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

}
