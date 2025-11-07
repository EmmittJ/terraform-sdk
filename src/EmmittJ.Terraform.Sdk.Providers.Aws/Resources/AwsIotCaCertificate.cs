using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_iot_ca_certificate resource.
/// </summary>
public class AwsIotCaCertificate : TerraformResource
{
    public AwsIotCaCertificate(string name) : base("aws_iot_ca_certificate", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("customer_version");
        this.DeclareOutput("generation_id");
        this.DeclareOutput("validity");
    }

    /// <summary>
    /// The active attribute.
    /// </summary>
    public TerraformProperty<bool>? Active
    {
        get => GetProperty<TerraformProperty<bool>>("active");
        set => this.WithProperty("active", value);
    }

    /// <summary>
    /// The allow_auto_registration attribute.
    /// </summary>
    public TerraformProperty<bool>? AllowAutoRegistration
    {
        get => GetProperty<TerraformProperty<bool>>("allow_auto_registration");
        set => this.WithProperty("allow_auto_registration", value);
    }

    /// <summary>
    /// The ca_certificate_pem attribute.
    /// </summary>
    public TerraformProperty<string>? CaCertificatePem
    {
        get => GetProperty<TerraformProperty<string>>("ca_certificate_pem");
        set => this.WithProperty("ca_certificate_pem", value);
    }

    /// <summary>
    /// The certificate_mode attribute.
    /// </summary>
    public TerraformProperty<string>? CertificateMode
    {
        get => GetProperty<TerraformProperty<string>>("certificate_mode");
        set => this.WithProperty("certificate_mode", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The verification_certificate_pem attribute.
    /// </summary>
    public TerraformProperty<string>? VerificationCertificatePem
    {
        get => GetProperty<TerraformProperty<string>>("verification_certificate_pem");
        set => this.WithProperty("verification_certificate_pem", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The customer_version attribute.
    /// </summary>
    public TerraformExpression CustomerVersion => this["customer_version"];

    /// <summary>
    /// The generation_id attribute.
    /// </summary>
    public TerraformExpression GenerationId => this["generation_id"];

    /// <summary>
    /// The validity attribute.
    /// </summary>
    public TerraformExpression Validity => this["validity"];

}
