using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_iot_certificate resource.
/// </summary>
public class AwsIotCertificate : TerraformResource
{
    public AwsIotCertificate(string name) : base("aws_iot_certificate", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("ca_certificate_id");
        this.DeclareOutput("private_key");
        this.DeclareOutput("public_key");
    }

    /// <summary>
    /// The active attribute.
    /// </summary>
    public bool? Active
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("active")?.Value;
        set => this.WithProperty("active", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The ca_pem attribute.
    /// </summary>
    public string? CaPem
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ca_pem")?.Value;
        set => this.WithProperty("ca_pem", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The certificate_pem attribute.
    /// </summary>
    public string? CertificatePem
    {
        get => GetProperty<TerraformLiteralProperty<string>>("certificate_pem")?.Value;
        set => this.WithProperty("certificate_pem", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The csr attribute.
    /// </summary>
    public string? Csr
    {
        get => GetProperty<TerraformLiteralProperty<string>>("csr")?.Value;
        set => this.WithProperty("csr", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The ca_certificate_id attribute.
    /// </summary>
    public TerraformExpression CaCertificateId => this["ca_certificate_id"];

    /// <summary>
    /// The private_key attribute.
    /// </summary>
    public TerraformExpression PrivateKey => this["private_key"];

    /// <summary>
    /// The public_key attribute.
    /// </summary>
    public TerraformExpression PublicKey => this["public_key"];

}
