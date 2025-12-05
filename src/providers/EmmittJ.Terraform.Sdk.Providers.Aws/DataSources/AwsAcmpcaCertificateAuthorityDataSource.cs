using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_acmpca_certificate_authority Terraform data source.
/// Retrieves information about a aws_acmpca_certificate_authority.
/// </summary>
public partial class AwsAcmpcaCertificateAuthorityDataSource(string name) : TerraformDataSource("aws_acmpca_certificate_authority", name)
{
    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    public required TerraformValue<string> Arn
    {
        get => GetRequiredArgument<TerraformValue<string>>("arn");
        set => SetArgument("arn", value);
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
    /// The certificate attribute.
    /// </summary>
    public TerraformValue<string> Certificate
        => CreateReference("certificate");

    /// <summary>
    /// The certificate_chain attribute.
    /// </summary>
    public TerraformValue<string> CertificateChain
        => CreateReference("certificate_chain");

    /// <summary>
    /// The certificate_signing_request attribute.
    /// </summary>
    public TerraformValue<string> CertificateSigningRequest
        => CreateReference("certificate_signing_request");

    /// <summary>
    /// The key_storage_security_standard attribute.
    /// </summary>
    public TerraformValue<string> KeyStorageSecurityStandard
        => CreateReference("key_storage_security_standard");

    /// <summary>
    /// The not_after attribute.
    /// </summary>
    public TerraformValue<string> NotAfter
        => CreateReference("not_after");

    /// <summary>
    /// The not_before attribute.
    /// </summary>
    public TerraformValue<string> NotBefore
        => CreateReference("not_before");

    /// <summary>
    /// The revocation_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> RevocationConfiguration
        => CreateReference("revocation_configuration");

    /// <summary>
    /// The serial attribute.
    /// </summary>
    public TerraformValue<string> Serial
        => CreateReference("serial");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => CreateReference("status");

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string> Type
        => CreateReference("type");

    /// <summary>
    /// The usage_mode attribute.
    /// </summary>
    public TerraformValue<string> UsageMode
        => CreateReference("usage_mode");

}
