using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsLbTrustStoreRevocationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

}

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
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
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
    /// The revocations_s3_bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RevocationsS3Bucket is required")]
    public required TerraformProperty<string> RevocationsS3Bucket
    {
        get => GetRequiredProperty<TerraformProperty<string>>("revocations_s3_bucket");
        set => this.WithProperty("revocations_s3_bucket", value);
    }

    /// <summary>
    /// The revocations_s3_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RevocationsS3Key is required")]
    public required TerraformProperty<string> RevocationsS3Key
    {
        get => GetRequiredProperty<TerraformProperty<string>>("revocations_s3_key");
        set => this.WithProperty("revocations_s3_key", value);
    }

    /// <summary>
    /// The revocations_s3_object_version attribute.
    /// </summary>
    public TerraformProperty<string>? RevocationsS3ObjectVersion
    {
        get => GetProperty<TerraformProperty<string>>("revocations_s3_object_version");
        set => this.WithProperty("revocations_s3_object_version", value);
    }

    /// <summary>
    /// The trust_store_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TrustStoreArn is required")]
    public required TerraformProperty<string> TrustStoreArn
    {
        get => GetRequiredProperty<TerraformProperty<string>>("trust_store_arn");
        set => this.WithProperty("trust_store_arn", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsLbTrustStoreRevocationTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsLbTrustStoreRevocationTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The revocation_id attribute.
    /// </summary>
    public TerraformExpression RevocationId => this["revocation_id"];

}
