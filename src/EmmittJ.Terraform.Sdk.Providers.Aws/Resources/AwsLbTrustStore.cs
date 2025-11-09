using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_lb_trust_store resource.
/// </summary>
public class AwsLbTrustStore : TerraformResource
{
    public AwsLbTrustStore(string name) : base("aws_lb_trust_store", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("arn_suffix");
    }

    /// <summary>
    /// The ca_certificates_bundle_s3_bucket attribute.
    /// </summary>
    public TerraformProperty<string>? CaCertificatesBundleS3Bucket
    {
        get => GetProperty<TerraformProperty<string>>("ca_certificates_bundle_s3_bucket");
        set => this.WithProperty("ca_certificates_bundle_s3_bucket", value);
    }

    /// <summary>
    /// The ca_certificates_bundle_s3_key attribute.
    /// </summary>
    public TerraformProperty<string>? CaCertificatesBundleS3Key
    {
        get => GetProperty<TerraformProperty<string>>("ca_certificates_bundle_s3_key");
        set => this.WithProperty("ca_certificates_bundle_s3_key", value);
    }

    /// <summary>
    /// The ca_certificates_bundle_s3_object_version attribute.
    /// </summary>
    public TerraformProperty<string>? CaCertificatesBundleS3ObjectVersion
    {
        get => GetProperty<TerraformProperty<string>>("ca_certificates_bundle_s3_object_version");
        set => this.WithProperty("ca_certificates_bundle_s3_object_version", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? NamePrefix
    {
        get => GetProperty<TerraformProperty<string>>("name_prefix");
        set => this.WithProperty("name_prefix", value);
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
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMapProperty<string>? TagsAll
    {
        get => GetProperty<TerraformMapProperty<string>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The arn_suffix attribute.
    /// </summary>
    public TerraformExpression ArnSuffix => this["arn_suffix"];

}
