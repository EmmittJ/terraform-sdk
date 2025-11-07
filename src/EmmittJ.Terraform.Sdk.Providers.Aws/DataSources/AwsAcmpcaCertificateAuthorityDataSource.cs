using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_acmpca_certificate_authority.
/// </summary>
public class AwsAcmpcaCertificateAuthorityDataSource : TerraformDataSource
{
    public AwsAcmpcaCertificateAuthorityDataSource(string name) : base("aws_acmpca_certificate_authority", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("certificate");
        this.DeclareOutput("certificate_chain");
        this.DeclareOutput("certificate_signing_request");
        this.DeclareOutput("key_storage_security_standard");
        this.DeclareOutput("not_after");
        this.DeclareOutput("not_before");
        this.DeclareOutput("revocation_configuration");
        this.DeclareOutput("serial");
        this.DeclareOutput("status");
        this.DeclareOutput("type");
        this.DeclareOutput("usage_mode");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformProperty<string>? Arn
    {
        get => GetProperty<TerraformProperty<string>>("arn");
        set => this.WithProperty("arn", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The certificate attribute.
    /// </summary>
    public TerraformExpression Certificate => this["certificate"];

    /// <summary>
    /// The certificate_chain attribute.
    /// </summary>
    public TerraformExpression CertificateChain => this["certificate_chain"];

    /// <summary>
    /// The certificate_signing_request attribute.
    /// </summary>
    public TerraformExpression CertificateSigningRequest => this["certificate_signing_request"];

    /// <summary>
    /// The key_storage_security_standard attribute.
    /// </summary>
    public TerraformExpression KeyStorageSecurityStandard => this["key_storage_security_standard"];

    /// <summary>
    /// The not_after attribute.
    /// </summary>
    public TerraformExpression NotAfter => this["not_after"];

    /// <summary>
    /// The not_before attribute.
    /// </summary>
    public TerraformExpression NotBefore => this["not_before"];

    /// <summary>
    /// The revocation_configuration attribute.
    /// </summary>
    public TerraformExpression RevocationConfiguration => this["revocation_configuration"];

    /// <summary>
    /// The serial attribute.
    /// </summary>
    public TerraformExpression Serial => this["serial"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformExpression Type => this["type"];

    /// <summary>
    /// The usage_mode attribute.
    /// </summary>
    public TerraformExpression UsageMode => this["usage_mode"];

}
