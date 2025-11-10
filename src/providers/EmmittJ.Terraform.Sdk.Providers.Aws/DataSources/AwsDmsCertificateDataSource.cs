using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_dms_certificate.
/// </summary>
public class AwsDmsCertificateDataSource : TerraformDataSource
{
    public AwsDmsCertificateDataSource(string name) : base("aws_dms_certificate", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("certificate_arn");
        SetOutput("certificate_creation_date");
        SetOutput("certificate_owner");
        SetOutput("certificate_pem");
        SetOutput("certificate_wallet");
        SetOutput("key_length");
        SetOutput("signing_algorithm");
        SetOutput("valid_from_date");
        SetOutput("valid_to_date");
        SetOutput("certificate_id");
        SetOutput("id");
        SetOutput("region");
        SetOutput("tags");
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
    /// The certificate_arn attribute.
    /// </summary>
    public TerraformExpression CertificateArn => this["certificate_arn"];

    /// <summary>
    /// The certificate_creation_date attribute.
    /// </summary>
    public TerraformExpression CertificateCreationDate => this["certificate_creation_date"];

    /// <summary>
    /// The certificate_owner attribute.
    /// </summary>
    public TerraformExpression CertificateOwner => this["certificate_owner"];

    /// <summary>
    /// The certificate_pem attribute.
    /// </summary>
    public TerraformExpression CertificatePem => this["certificate_pem"];

    /// <summary>
    /// The certificate_wallet attribute.
    /// </summary>
    public TerraformExpression CertificateWallet => this["certificate_wallet"];

    /// <summary>
    /// The key_length attribute.
    /// </summary>
    public TerraformExpression KeyLength => this["key_length"];

    /// <summary>
    /// The signing_algorithm attribute.
    /// </summary>
    public TerraformExpression SigningAlgorithm => this["signing_algorithm"];

    /// <summary>
    /// The valid_from_date attribute.
    /// </summary>
    public TerraformExpression ValidFromDate => this["valid_from_date"];

    /// <summary>
    /// The valid_to_date attribute.
    /// </summary>
    public TerraformExpression ValidToDate => this["valid_to_date"];

}
