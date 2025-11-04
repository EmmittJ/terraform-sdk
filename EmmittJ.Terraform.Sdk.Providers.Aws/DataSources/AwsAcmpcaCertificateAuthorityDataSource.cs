using EmmittJ.Terraform.Sdk.Resources;
using EmmittJ.Terraform.Sdk.Context;

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
        DeclareOutput("certificate");
        DeclareOutput("certificate_chain");
        DeclareOutput("certificate_signing_request");
        DeclareOutput("key_storage_security_standard");
        DeclareOutput("not_after");
        DeclareOutput("not_before");
        DeclareOutput("revocation_configuration");
        DeclareOutput("serial");
        DeclareOutput("status");
        DeclareOutput("type");
        DeclareOutput("usage_mode");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public string? Arn
    {
        get => GetProperty<TerraformLiteralProperty&lt;string&gt;>("arn")?.Value;
        set => WithPropertyInternal("arn", value == null ? null : new TerraformLiteralProperty&lt;string&gt;(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty&lt;string&gt;>("id")?.Value;
        set => WithPropertyInternal("id", value == null ? null : new TerraformLiteralProperty&lt;string&gt;(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary&lt;string, string&gt;? Tags
    {
        get => GetProperty<TerraformLiteralProperty&lt;Dictionary&lt;string, string&gt;&gt;>("tags")?.Value;
        set => WithPropertyInternal("tags", value == null ? null : new TerraformLiteralProperty&lt;Dictionary&lt;string, string&gt;&gt;(value));
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
