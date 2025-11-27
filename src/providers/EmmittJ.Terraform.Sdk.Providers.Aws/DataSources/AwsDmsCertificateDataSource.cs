using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_dms_certificate Terraform data source.
/// Retrieves information about a aws_dms_certificate.
/// </summary>
public partial class AwsDmsCertificateDataSource(string name) : TerraformDataSource("aws_dms_certificate", name)
{
    /// <summary>
    /// The certificate_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificateId is required")]
    public required TerraformValue<string> CertificateId
    {
        get => new TerraformReference<string>(this, "certificate_id");
        set => SetArgument("certificate_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The certificate_arn attribute.
    /// </summary>
    public TerraformValue<string> CertificateArn
    {
        get => new TerraformReference<string>(this, "certificate_arn");
    }

    /// <summary>
    /// The certificate_creation_date attribute.
    /// </summary>
    public TerraformValue<string> CertificateCreationDate
    {
        get => new TerraformReference<string>(this, "certificate_creation_date");
    }

    /// <summary>
    /// The certificate_owner attribute.
    /// </summary>
    public TerraformValue<string> CertificateOwner
    {
        get => new TerraformReference<string>(this, "certificate_owner");
    }

    /// <summary>
    /// The certificate_pem attribute.
    /// </summary>
    public TerraformValue<string> CertificatePem
    {
        get => new TerraformReference<string>(this, "certificate_pem");
    }

    /// <summary>
    /// The certificate_wallet attribute.
    /// </summary>
    public TerraformValue<string> CertificateWallet
    {
        get => new TerraformReference<string>(this, "certificate_wallet");
    }

    /// <summary>
    /// The key_length attribute.
    /// </summary>
    public TerraformValue<double> KeyLength
    {
        get => new TerraformReference<double>(this, "key_length");
    }

    /// <summary>
    /// The signing_algorithm attribute.
    /// </summary>
    public TerraformValue<string> SigningAlgorithm
    {
        get => new TerraformReference<string>(this, "signing_algorithm");
    }

    /// <summary>
    /// The valid_from_date attribute.
    /// </summary>
    public TerraformValue<string> ValidFromDate
    {
        get => new TerraformReference<string>(this, "valid_from_date");
    }

    /// <summary>
    /// The valid_to_date attribute.
    /// </summary>
    public TerraformValue<string> ValidToDate
    {
        get => new TerraformReference<string>(this, "valid_to_date");
    }

}
