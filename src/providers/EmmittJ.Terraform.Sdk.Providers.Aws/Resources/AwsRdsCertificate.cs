using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_rds_certificate Terraform resource.
/// Manages a aws_rds_certificate resource.
/// </summary>
public partial class AwsRdsCertificate(string name) : TerraformResource("aws_rds_certificate", name)
{
    /// <summary>
    /// The certificate_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificateIdentifier is required")]
    public required TerraformValue<string> CertificateIdentifier
    {
        get => GetArgument<TerraformValue<string>>("certificate_identifier");
        set => SetArgument("certificate_identifier", value);
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

}
