using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_redshift_hsm_client_certificate Terraform resource.
/// Manages a aws_redshift_hsm_client_certificate resource.
/// </summary>
public partial class AwsRedshiftHsmClientCertificate(string name) : TerraformResource("aws_redshift_hsm_client_certificate", name)
{
    /// <summary>
    /// The hsm_client_certificate_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HsmClientCertificateIdentifier is required")]
    public required TerraformValue<string> HsmClientCertificateIdentifier
    {
        get => GetArgument<TerraformValue<string>>("hsm_client_certificate_identifier");
        set => SetArgument("hsm_client_certificate_identifier", value);
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
    public TerraformMap<string>? TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The hsm_client_certificate_public_key attribute.
    /// </summary>
    public TerraformValue<string> HsmClientCertificatePublicKey
        => AsReference("hsm_client_certificate_public_key");

}
