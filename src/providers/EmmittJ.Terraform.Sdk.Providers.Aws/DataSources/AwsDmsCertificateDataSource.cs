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
        get => GetRequiredArgument<TerraformValue<string>>("certificate_id");
        set => SetArgument("certificate_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => GetArgument<TerraformMap<string>>("tags") ?? CreateReference("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The certificate_arn attribute.
    /// </summary>
    public TerraformValue<string> CertificateArn
        => CreateReference("certificate_arn");

    /// <summary>
    /// The certificate_creation_date attribute.
    /// </summary>
    public TerraformValue<string> CertificateCreationDate
        => CreateReference("certificate_creation_date");

    /// <summary>
    /// The certificate_owner attribute.
    /// </summary>
    public TerraformValue<string> CertificateOwner
        => CreateReference("certificate_owner");

    /// <summary>
    /// The certificate_pem attribute.
    /// </summary>
    public TerraformValue<string> CertificatePem
        => CreateReference("certificate_pem");

    /// <summary>
    /// The certificate_wallet attribute.
    /// </summary>
    public TerraformValue<string> CertificateWallet
        => CreateReference("certificate_wallet");

    /// <summary>
    /// The key_length attribute.
    /// </summary>
    public TerraformValue<double> KeyLength
        => CreateReference("key_length");

    /// <summary>
    /// The signing_algorithm attribute.
    /// </summary>
    public TerraformValue<string> SigningAlgorithm
        => CreateReference("signing_algorithm");

    /// <summary>
    /// The valid_from_date attribute.
    /// </summary>
    public TerraformValue<string> ValidFromDate
        => CreateReference("valid_from_date");

    /// <summary>
    /// The valid_to_date attribute.
    /// </summary>
    public TerraformValue<string> ValidToDate
        => CreateReference("valid_to_date");

}
