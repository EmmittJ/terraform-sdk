using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_rds_certificate resource.
/// </summary>
public class AwsRdsCertificate : TerraformResource
{
    public AwsRdsCertificate(string name) : base("aws_rds_certificate", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The certificate_identifier attribute.
    /// </summary>
    public string? CertificateIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("certificate_identifier")?.Value;
        set => this.WithProperty("certificate_identifier", value == null ? null : new TerraformLiteralProperty<string>(value));
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
