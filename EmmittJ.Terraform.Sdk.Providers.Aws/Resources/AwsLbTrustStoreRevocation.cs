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
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The revocations_s3_bucket attribute.
    /// </summary>
    public string? RevocationsS3Bucket
    {
        get => GetProperty<TerraformLiteralProperty<string>>("revocations_s3_bucket")?.Value;
        set => this.WithProperty("revocations_s3_bucket", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The revocations_s3_key attribute.
    /// </summary>
    public string? RevocationsS3Key
    {
        get => GetProperty<TerraformLiteralProperty<string>>("revocations_s3_key")?.Value;
        set => this.WithProperty("revocations_s3_key", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The revocations_s3_object_version attribute.
    /// </summary>
    public string? RevocationsS3ObjectVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("revocations_s3_object_version")?.Value;
        set => this.WithProperty("revocations_s3_object_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The trust_store_arn attribute.
    /// </summary>
    public string? TrustStoreArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("trust_store_arn")?.Value;
        set => this.WithProperty("trust_store_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The revocation_id attribute.
    /// </summary>
    public TerraformExpression RevocationId => this["revocation_id"];

}
