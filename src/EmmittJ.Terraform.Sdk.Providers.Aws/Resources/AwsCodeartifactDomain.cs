using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_codeartifact_domain resource.
/// </summary>
public class AwsCodeartifactDomain : TerraformResource
{
    public AwsCodeartifactDomain(string name) : base("aws_codeartifact_domain", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("asset_size_bytes");
        this.DeclareOutput("created_time");
        this.DeclareOutput("owner");
        this.DeclareOutput("repository_count");
        this.DeclareOutput("s3_bucket_arn");
    }

    /// <summary>
    /// The domain attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Domain
    {
        get => GetProperty<TerraformLiteralProperty<string>>("domain");
        set => this.WithProperty("domain", value);
    }

    /// <summary>
    /// The encryption_key attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? EncryptionKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("encryption_key");
        set => this.WithProperty("encryption_key", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The asset_size_bytes attribute.
    /// </summary>
    public TerraformExpression AssetSizeBytes => this["asset_size_bytes"];

    /// <summary>
    /// The created_time attribute.
    /// </summary>
    public TerraformExpression CreatedTime => this["created_time"];

    /// <summary>
    /// The owner attribute.
    /// </summary>
    public TerraformExpression Owner => this["owner"];

    /// <summary>
    /// The repository_count attribute.
    /// </summary>
    public TerraformExpression RepositoryCount => this["repository_count"];

    /// <summary>
    /// The s3_bucket_arn attribute.
    /// </summary>
    public TerraformExpression S3BucketArn => this["s3_bucket_arn"];

}
