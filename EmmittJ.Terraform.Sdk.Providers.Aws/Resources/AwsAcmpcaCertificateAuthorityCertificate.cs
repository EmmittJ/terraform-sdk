using EmmittJ.Terraform.Sdk.Resources;
using EmmittJ.Terraform.Sdk.Context;

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
        get => GetProperty<TerraformLiteralProperty&lt;string&gt;>("certificate")?.Value;
        set => WithPropertyInternal("certificate", value == null ? null : new TerraformLiteralProperty&lt;string&gt;(value));
    }

    /// <summary>
    /// The certificate_authority_arn attribute.
    /// </summary>
    public string? CertificateAuthorityArn
    {
        get => GetProperty<TerraformLiteralProperty&lt;string&gt;>("certificate_authority_arn")?.Value;
        set => WithPropertyInternal("certificate_authority_arn", value == null ? null : new TerraformLiteralProperty&lt;string&gt;(value));
    }

    /// <summary>
    /// The certificate_chain attribute.
    /// </summary>
    public string? CertificateChain
    {
        get => GetProperty<TerraformLiteralProperty&lt;string&gt;>("certificate_chain")?.Value;
        set => WithPropertyInternal("certificate_chain", value == null ? null : new TerraformLiteralProperty&lt;string&gt;(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty&lt;string&gt;>("id")?.Value;
        set => WithPropertyInternal("id", value == null ? null : new TerraformLiteralProperty&lt;string&gt;(value));
    }

}
