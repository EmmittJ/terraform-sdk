using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for validity in AwsAcmpcaCertificate.
/// Nesting mode: list
/// </summary>
public class AwsAcmpcaCertificateValidityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "validity";

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Represents a aws_acmpca_certificate Terraform resource.
/// Manages a aws_acmpca_certificate resource.
/// </summary>
public partial class AwsAcmpcaCertificate(string name) : TerraformResource("aws_acmpca_certificate", name)
{
    /// <summary>
    /// The api_passthrough attribute.
    /// </summary>
    public TerraformValue<string>? ApiPassthrough
    {
        get => new TerraformReference<string>(this, "api_passthrough");
        set => SetArgument("api_passthrough", value);
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
    /// The certificate_signing_request attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificateSigningRequest is required")]
    public required TerraformValue<string> CertificateSigningRequest
    {
        get => new TerraformReference<string>(this, "certificate_signing_request");
        set => SetArgument("certificate_signing_request", value);
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
    /// The signing_algorithm attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SigningAlgorithm is required")]
    public required TerraformValue<string> SigningAlgorithm
    {
        get => new TerraformReference<string>(this, "signing_algorithm");
        set => SetArgument("signing_algorithm", value);
    }

    /// <summary>
    /// The template_arn attribute.
    /// </summary>
    public TerraformValue<string>? TemplateArn
    {
        get => new TerraformReference<string>(this, "template_arn");
        set => SetArgument("template_arn", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The certificate attribute.
    /// </summary>
    public TerraformValue<string> Certificate
    {
        get => new TerraformReference<string>(this, "certificate");
    }

    /// <summary>
    /// The certificate_chain attribute.
    /// </summary>
    public TerraformValue<string> CertificateChain
    {
        get => new TerraformReference<string>(this, "certificate_chain");
    }

    /// <summary>
    /// Validity block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Validity is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Validity block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Validity block(s) allowed")]
    public required TerraformList<AwsAcmpcaCertificateValidityBlock> Validity
    {
        get => GetRequiredArgument<TerraformList<AwsAcmpcaCertificateValidityBlock>>("validity");
        set => SetArgument("validity", value);
    }

}
