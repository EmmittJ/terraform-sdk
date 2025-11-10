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
        SetOutput("access_key_id");
        SetOutput("created_at");
        SetOutput("secret_access_key");
        SetOutput("status");
        SetOutput("bucket_name");
        SetOutput("id");
        SetOutput("region");
    }

    /// <summary>
    /// The bucket_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketName is required")]
    public required TerraformProperty<string> BucketName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("bucket_name");
        set => SetProperty("bucket_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
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
