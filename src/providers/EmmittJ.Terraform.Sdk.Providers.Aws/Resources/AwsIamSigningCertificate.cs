using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_iam_signing_certificate Terraform resource.
/// Manages a aws_iam_signing_certificate resource.
/// </summary>
public partial class AwsIamSigningCertificate(string name) : TerraformResource("aws_iam_signing_certificate", name)
{
    /// <summary>
    /// The certificate_body attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificateBody is required")]
    public required TerraformValue<string> CertificateBody
    {
        get => GetRequiredArgument<TerraformValue<string>>("certificate_body");
        set => SetArgument("certificate_body", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string>? Status
    {
        get => GetArgument<TerraformValue<string>>("status");
        set => SetArgument("status", value);
    }

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserName is required")]
    public required TerraformValue<string> UserName
    {
        get => GetRequiredArgument<TerraformValue<string>>("user_name");
        set => SetArgument("user_name", value);
    }

    /// <summary>
    /// The certificate_id attribute.
    /// </summary>
    public TerraformValue<string> CertificateId
        => AsReference("certificate_id");

}
