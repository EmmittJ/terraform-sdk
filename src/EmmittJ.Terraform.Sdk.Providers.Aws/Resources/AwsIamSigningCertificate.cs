using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_iam_signing_certificate resource.
/// </summary>
public class AwsIamSigningCertificate : TerraformResource
{
    public AwsIamSigningCertificate(string name) : base("aws_iam_signing_certificate", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("certificate_id");
    }

    /// <summary>
    /// The certificate_body attribute.
    /// </summary>
    public string? CertificateBody
    {
        get => GetProperty<TerraformLiteralProperty<string>>("certificate_body")?.Value;
        set => this.WithProperty("certificate_body", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The status attribute.
    /// </summary>
    public string? Status
    {
        get => GetProperty<TerraformLiteralProperty<string>>("status")?.Value;
        set => this.WithProperty("status", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    public string? UserName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("user_name")?.Value;
        set => this.WithProperty("user_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The certificate_id attribute.
    /// </summary>
    public TerraformExpression CertificateId => this["certificate_id"];

}
