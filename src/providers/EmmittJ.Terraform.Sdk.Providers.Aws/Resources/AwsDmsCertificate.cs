using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_dms_certificate Terraform resource.
/// Manages a aws_dms_certificate resource.
/// </summary>
public partial class AwsDmsCertificate(string name) : TerraformResource("aws_dms_certificate", name)
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
    /// The certificate_pem attribute.
    /// </summary>
    public TerraformValue<string>? CertificatePem
    {
        get => GetArgument<TerraformValue<string>>("certificate_pem");
        set => SetArgument("certificate_pem", value);
    }

    /// <summary>
    /// The certificate_wallet attribute.
    /// </summary>
    public TerraformValue<string>? CertificateWallet
    {
        get => GetArgument<TerraformValue<string>>("certificate_wallet");
        set => SetArgument("certificate_wallet", value);
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
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? CreateReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The certificate_arn attribute.
    /// </summary>
    public TerraformValue<string> CertificateArn
        => CreateReference("certificate_arn");

}
