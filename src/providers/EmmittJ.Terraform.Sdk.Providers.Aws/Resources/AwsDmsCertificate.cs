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
        SetOutput("certificate_arn");
        SetOutput("certificate_id");
        SetOutput("certificate_pem");
        SetOutput("certificate_wallet");
        SetOutput("id");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The certificate_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificateId is required")]
    public required TerraformProperty<string> CertificateId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("certificate_id");
        set => SetProperty("certificate_id", value);
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
    /// The certificate_wallet attribute.
    /// </summary>
    public TerraformProperty<string> CertificateWallet
    {
        get => GetRequiredOutput<TerraformProperty<string>>("certificate_wallet");
        set => SetProperty("certificate_wallet", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// The certificate_arn attribute.
    /// </summary>
    public TerraformExpression CertificateArn => this["certificate_arn"];

}
