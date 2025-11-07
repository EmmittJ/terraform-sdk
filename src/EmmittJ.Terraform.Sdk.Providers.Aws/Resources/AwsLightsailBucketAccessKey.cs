using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_lightsail_bucket_access_key resource.
/// </summary>
public class AwsLightsailBucketAccessKey : TerraformResource
{
    public AwsLightsailBucketAccessKey(string name) : base("aws_lightsail_bucket_access_key", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("access_key_id");
        this.DeclareOutput("created_at");
        this.DeclareOutput("secret_access_key");
        this.DeclareOutput("status");
    }

    /// <summary>
    /// The bucket_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? BucketName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("bucket_name");
        set => this.WithProperty("bucket_name", value);
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
    /// The access_key_id attribute.
    /// </summary>
    public TerraformExpression AccessKeyId => this["access_key_id"];

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformExpression CreatedAt => this["created_at"];

    /// <summary>
    /// The secret_access_key attribute.
    /// </summary>
    public TerraformExpression SecretAccessKey => this["secret_access_key"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

}
