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
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetArgument<TerraformValue<string>>("value");
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
        get => GetArgument<TerraformValue<string>>("api_passthrough");
        set => SetArgument("api_passthrough", value);
    }

    /// <summary>
    /// The certificate_authority_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificateAuthorityArn is required")]
    public required TerraformValue<string> CertificateAuthorityArn
    {
        get => GetArgument<TerraformValue<string>>("certificate_authority_arn");
        set => SetArgument("certificate_authority_arn", value);
    }

    /// <summary>
    /// The certificate_signing_request attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificateSigningRequest is required")]
    public required TerraformValue<string> CertificateSigningRequest
    {
        get => GetArgument<TerraformValue<string>>("certificate_signing_request");
        set => SetArgument("certificate_signing_request", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The signing_algorithm attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SigningAlgorithm is required")]
    public required TerraformValue<string> SigningAlgorithm
    {
        get => GetArgument<TerraformValue<string>>("signing_algorithm");
        set => SetArgument("signing_algorithm", value);
    }

    /// <summary>
    /// The template_arn attribute.
    /// </summary>
    public TerraformValue<string>? TemplateArn
    {
        get => GetArgument<TerraformValue<string>>("template_arn");
        set => SetArgument("template_arn", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The certificate attribute.
    /// </summary>
    public TerraformValue<string> Certificate
        => AsReference("certificate");

    /// <summary>
    /// The certificate_chain attribute.
    /// </summary>
    public TerraformValue<string> CertificateChain
        => AsReference("certificate_chain");

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
