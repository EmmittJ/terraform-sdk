using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_iot_certificate Terraform resource.
/// Manages a aws_iot_certificate resource.
/// </summary>
public partial class AwsIotCertificate(string name) : TerraformResource("aws_iot_certificate", name)
{
    /// <summary>
    /// The active attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Active is required")]
    public required TerraformValue<bool> Active
    {
        get => GetRequiredArgument<TerraformValue<bool>>("active");
        set => SetArgument("active", value);
    }

    /// <summary>
    /// The ca_pem attribute.
    /// </summary>
    public TerraformValue<string>? CaPem
    {
        get => GetArgument<TerraformValue<string>>("ca_pem");
        set => SetArgument("ca_pem", value);
    }

    /// <summary>
    /// The certificate_pem attribute.
    /// </summary>
    public TerraformValue<string> CertificatePem
    {
        get => GetArgument<TerraformValue<string>>("certificate_pem") ?? CreateReference("certificate_pem");
        set => SetArgument("certificate_pem", value);
    }

    /// <summary>
    /// The csr attribute.
    /// </summary>
    public TerraformValue<string>? Csr
    {
        get => GetArgument<TerraformValue<string>>("csr");
        set => SetArgument("csr", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The ca_certificate_id attribute.
    /// </summary>
    public TerraformValue<string> CaCertificateId
        => CreateReference("ca_certificate_id");

    /// <summary>
    /// The private_key attribute.
    /// </summary>
    public TerraformValue<string> PrivateKey
        => CreateReference("private_key");

    /// <summary>
    /// The public_key attribute.
    /// </summary>
    public TerraformValue<string> PublicKey
        => CreateReference("public_key");

}
