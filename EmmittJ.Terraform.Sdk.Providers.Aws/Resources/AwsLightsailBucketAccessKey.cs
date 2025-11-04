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
    public string? BucketName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("bucket_name")?.Value;
        set => this.WithProperty("bucket_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
