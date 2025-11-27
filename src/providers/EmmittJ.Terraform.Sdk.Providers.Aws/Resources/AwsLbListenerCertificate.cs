using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_lb_listener_certificate Terraform resource.
/// Manages a aws_lb_listener_certificate resource.
/// </summary>
public partial class AwsLbListenerCertificate(string name) : TerraformResource("aws_lb_listener_certificate", name)
{
    /// <summary>
    /// The certificate_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificateArn is required")]
    public required TerraformValue<string> CertificateArn
    {
        get => new TerraformReference<string>(this, "certificate_arn");
        set => SetArgument("certificate_arn", value);
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
    /// The listener_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ListenerArn is required")]
    public required TerraformValue<string> ListenerArn
    {
        get => new TerraformReference<string>(this, "listener_arn");
        set => SetArgument("listener_arn", value);
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
