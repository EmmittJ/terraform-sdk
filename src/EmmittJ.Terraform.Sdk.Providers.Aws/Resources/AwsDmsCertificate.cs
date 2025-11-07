using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_dms_certificate resource.
/// </summary>
public class AwsDmsCertificate : TerraformResource
{
    public AwsDmsCertificate(string name) : base("aws_dms_certificate", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("certificate_arn");
    }

    /// <summary>
    /// The certificate_id attribute.
    /// </summary>
    public TerraformProperty<string>? CertificateId
    {
        get => GetProperty<TerraformProperty<string>>("certificate_id");
        set => this.WithProperty("certificate_id", value);
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
    /// The certificate_wallet attribute.
    /// </summary>
    public TerraformProperty<string>? CertificateWallet
    {
        get => GetProperty<TerraformProperty<string>>("certificate_wallet");
        set => this.WithProperty("certificate_wallet", value);
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
    /// The certificate_arn attribute.
    /// </summary>
    public TerraformExpression CertificateArn => this["certificate_arn"];

}
