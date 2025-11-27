using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_acmpca_certificate_authority_certificate Terraform resource.
/// Manages a aws_acmpca_certificate_authority_certificate resource.
/// </summary>
public partial class AwsAcmpcaCertificateAuthorityCertificate(string name) : TerraformResource("aws_acmpca_certificate_authority_certificate", name)
{
    /// <summary>
    /// The certificate attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Certificate is required")]
    public required TerraformValue<string> Certificate
    {
        get => new TerraformReference<string>(this, "certificate");
        set => SetArgument("certificate", value);
    }

    /// <summary>
    /// The certificate_authority_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificateAuthorityArn is required")]
    public required TerraformValue<string> CertificateAuthorityArn
    {
        get => new TerraformReference<string>(this, "certificate_authority_arn");
        set => SetArgument("certificate_authority_arn", value);
    }

    /// <summary>
    /// The certificate_chain attribute.
    /// </summary>
    public TerraformValue<string>? CertificateChain
    {
        get => new TerraformReference<string>(this, "certificate_chain");
        set => SetArgument("certificate_chain", value);
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

}
