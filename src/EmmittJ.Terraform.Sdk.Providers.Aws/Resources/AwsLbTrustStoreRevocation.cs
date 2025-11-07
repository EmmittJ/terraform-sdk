using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_lb_trust_store_revocation resource.
/// </summary>
public class AwsLbTrustStoreRevocation : TerraformResource
{
    public AwsLbTrustStoreRevocation(string name) : base("aws_lb_trust_store_revocation", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("revocation_id");
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
    /// The revocations_s3_bucket attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RevocationsS3Bucket
    {
        get => GetProperty<TerraformLiteralProperty<string>>("revocations_s3_bucket");
        set => this.WithProperty("revocations_s3_bucket", value);
    }

    /// <summary>
    /// The revocations_s3_key attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RevocationsS3Key
    {
        get => GetProperty<TerraformLiteralProperty<string>>("revocations_s3_key");
        set => this.WithProperty("revocations_s3_key", value);
    }

    /// <summary>
    /// The revocations_s3_object_version attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RevocationsS3ObjectVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("revocations_s3_object_version");
        set => this.WithProperty("revocations_s3_object_version", value);
    }

    /// <summary>
    /// The trust_store_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TrustStoreArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("trust_store_arn");
        set => this.WithProperty("trust_store_arn", value);
    }

    /// <summary>
    /// The revocation_id attribute.
    /// </summary>
    public TerraformExpression RevocationId => this["revocation_id"];

}
