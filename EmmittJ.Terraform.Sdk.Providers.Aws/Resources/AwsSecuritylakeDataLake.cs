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
    public string? MetaStoreManagerRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("meta_store_manager_role_arn")?.Value;
        set => this.WithProperty("meta_store_manager_role_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
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
