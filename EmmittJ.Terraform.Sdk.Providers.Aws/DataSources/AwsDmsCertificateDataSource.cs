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
        this.DeclareOutput("certificate_arn");
        this.DeclareOutput("certificate_creation_date");
        this.DeclareOutput("certificate_owner");
        this.DeclareOutput("certificate_pem");
        this.DeclareOutput("certificate_wallet");
        this.DeclareOutput("key_length");
        this.DeclareOutput("signing_algorithm");
        this.DeclareOutput("valid_from_date");
        this.DeclareOutput("valid_to_date");
    }

    /// <summary>
    /// The certificate_id attribute.
    /// </summary>
    public string? CertificateId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("certificate_id")?.Value;
        set => this.WithProperty("certificate_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
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
