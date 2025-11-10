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
        SetOutput("arn");
        SetOutput("ca_certificate_id");
        SetOutput("private_key");
        SetOutput("public_key");
        SetOutput("active");
        SetOutput("ca_pem");
        SetOutput("certificate_pem");
        SetOutput("csr");
        SetOutput("id");
        SetOutput("region");
    }

    /// <summary>
    /// The active attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Active is required")]
    public required TerraformProperty<bool> Active
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("active");
        set => SetProperty("active", value);
    }

    /// <summary>
    /// The ca_pem attribute.
    /// </summary>
    public TerraformProperty<string> CaPem
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ca_pem");
        set => SetProperty("ca_pem", value);
    }

    /// <summary>
    /// The certificate_pem attribute.
    /// </summary>
    public TerraformProperty<string> CertificatePem
    {
        get => GetRequiredOutput<TerraformProperty<string>>("certificate_pem");
        set => SetProperty("certificate_pem", value);
    }

    /// <summary>
    /// The csr attribute.
    /// </summary>
    public TerraformProperty<string> Csr
    {
        get => GetRequiredOutput<TerraformProperty<string>>("csr");
        set => SetProperty("csr", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
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
