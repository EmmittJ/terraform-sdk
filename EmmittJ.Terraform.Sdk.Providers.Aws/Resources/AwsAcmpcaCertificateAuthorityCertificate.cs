using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_acmpca_certificate_authority_certificate resource.
/// </summary>
public class AwsAcmpcaCertificateAuthorityCertificate : TerraformResource
{
    public AwsAcmpcaCertificateAuthorityCertificate(string name) : base("aws_acmpca_certificate_authority_certificate", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The certificate attribute.
    /// </summary>
    public string? Certificate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("certificate")?.Value;
        set => this.WithProperty("certificate", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The certificate_authority_arn attribute.
    /// </summary>
    public string? CertificateAuthorityArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("certificate_authority_arn")?.Value;
        set => this.WithProperty("certificate_authority_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The certificate_chain attribute.
    /// </summary>
    public string? CertificateChain
    {
        get => GetProperty<TerraformLiteralProperty<string>>("certificate_chain")?.Value;
        set => this.WithProperty("certificate_chain", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
