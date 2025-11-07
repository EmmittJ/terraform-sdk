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
    public TerraformProperty<string>? CertificateBody
    {
        get => GetProperty<TerraformProperty<string>>("certificate_body");
        set => this.WithProperty("certificate_body", value);
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
    /// The status attribute.
    /// </summary>
    public TerraformProperty<string>? Status
    {
        get => GetProperty<TerraformProperty<string>>("status");
        set => this.WithProperty("status", value);
    }

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    public TerraformProperty<string>? UserName
    {
        get => GetProperty<TerraformProperty<string>>("user_name");
        set => this.WithProperty("user_name", value);
    }

    /// <summary>
    /// The certificate_id attribute.
    /// </summary>
    public TerraformExpression CertificateId => this["certificate_id"];

}
