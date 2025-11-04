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
    public string? CaCertificatesBundleS3Bucket
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ca_certificates_bundle_s3_bucket")?.Value;
        set => this.WithProperty("ca_certificates_bundle_s3_bucket", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ca_certificates_bundle_s3_key attribute.
    /// </summary>
    public string? CaCertificatesBundleS3Key
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ca_certificates_bundle_s3_key")?.Value;
        set => this.WithProperty("ca_certificates_bundle_s3_key", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ca_certificates_bundle_s3_object_version attribute.
    /// </summary>
    public string? CaCertificatesBundleS3ObjectVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ca_certificates_bundle_s3_object_version")?.Value;
        set => this.WithProperty("ca_certificates_bundle_s3_object_version", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public string? NamePrefix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name_prefix")?.Value;
        set => this.WithProperty("name_prefix", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
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
