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
    public bool? Active
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("active")?.Value;
        set => this.WithProperty("active", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The allow_auto_registration attribute.
    /// </summary>
    public bool? AllowAutoRegistration
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("allow_auto_registration")?.Value;
        set => this.WithProperty("allow_auto_registration", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The ca_certificate_pem attribute.
    /// </summary>
    public string? CaCertificatePem
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ca_certificate_pem")?.Value;
        set => this.WithProperty("ca_certificate_pem", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The certificate_mode attribute.
    /// </summary>
    public string? CertificateMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("certificate_mode")?.Value;
        set => this.WithProperty("certificate_mode", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The verification_certificate_pem attribute.
    /// </summary>
    public string? VerificationCertificatePem
    {
        get => GetProperty<TerraformLiteralProperty<string>>("verification_certificate_pem")?.Value;
        set => this.WithProperty("verification_certificate_pem", value == null ? null : new TerraformLiteralProperty<string>(value));
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
