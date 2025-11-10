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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Active is required")]
    public required TerraformProperty<bool> Active
    {
        get => GetProperty<TerraformProperty<bool>>("active");
        set => this.WithProperty("active", value);
    }

    /// <summary>
    /// The ca_pem attribute.
    /// </summary>
    public TerraformProperty<string>? CaPem
    {
        get => GetProperty<TerraformProperty<string>>("ca_pem");
        set => this.WithProperty("ca_pem", value);
    }

    /// <summary>
    /// The certificate_pem attribute.
    /// </summary>
    public TerraformProperty<string>? CertificatePem
    {
        get => GetProperty<TerraformProperty<string>>("certificate_pem");
        set => this.WithProperty("certificate_pem", value);
    }

    /// <summary>
    /// The csr attribute.
    /// </summary>
    public TerraformProperty<string>? Csr
    {
        get => GetProperty<TerraformProperty<string>>("csr");
        set => this.WithProperty("csr", value);
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
