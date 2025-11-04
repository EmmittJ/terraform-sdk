using EmmittJ.Terraform.Sdk.Resources;
using EmmittJ.Terraform.Sdk.Context;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_acmpca_certificate resource.
/// </summary>
public class AwsAcmpcaCertificate : TerraformResource
{
    public AwsAcmpcaCertificate(string name) : base("aws_acmpca_certificate", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        DeclareOutput("arn");
        DeclareOutput("certificate");
        DeclareOutput("certificate_chain");
    }

    /// <summary>
    /// The api_passthrough attribute.
    /// </summary>
    public string? ApiPassthrough
    {
        get => GetProperty<TerraformLiteralProperty&lt;string&gt;>("api_passthrough")?.Value;
        set => WithPropertyInternal("api_passthrough", value == null ? null : new TerraformLiteralProperty&lt;string&gt;(value));
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
    /// The certificate_signing_request attribute.
    /// </summary>
    public string? CertificateSigningRequest
    {
        get => GetProperty<TerraformLiteralProperty&lt;string&gt;>("certificate_signing_request")?.Value;
        set => WithPropertyInternal("certificate_signing_request", value == null ? null : new TerraformLiteralProperty&lt;string&gt;(value));
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
    /// The signing_algorithm attribute.
    /// </summary>
    public string? SigningAlgorithm
    {
        get => GetProperty<TerraformLiteralProperty&lt;string&gt;>("signing_algorithm")?.Value;
        set => WithPropertyInternal("signing_algorithm", value == null ? null : new TerraformLiteralProperty&lt;string&gt;(value));
    }

    /// <summary>
    /// The template_arn attribute.
    /// </summary>
    public string? TemplateArn
    {
        get => GetProperty<TerraformLiteralProperty&lt;string&gt;>("template_arn")?.Value;
        set => WithPropertyInternal("template_arn", value == null ? null : new TerraformLiteralProperty&lt;string&gt;(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The certificate attribute.
    /// </summary>
    public TerraformExpression Certificate => this["certificate"];

    /// <summary>
    /// The certificate_chain attribute.
    /// </summary>
    public TerraformExpression CertificateChain => this["certificate_chain"];

}
