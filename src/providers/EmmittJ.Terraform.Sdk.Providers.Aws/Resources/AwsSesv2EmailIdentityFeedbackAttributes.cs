using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_sesv2_email_identity_feedback_attributes Terraform resource.
/// Manages a aws_sesv2_email_identity_feedback_attributes resource.
/// </summary>
public partial class AwsSesv2EmailIdentityFeedbackAttributes(string name) : TerraformResource("aws_sesv2_email_identity_feedback_attributes", name)
{
    /// <summary>
    /// The email_forwarding_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? EmailForwardingEnabled
    {
        get => new TerraformReference<bool>(this, "email_forwarding_enabled");
        set => SetArgument("email_forwarding_enabled", value);
    }

    /// <summary>
    /// The email_identity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EmailIdentity is required")]
    public required TerraformValue<string> EmailIdentity
    {
        get => new TerraformReference<string>(this, "email_identity");
        set => SetArgument("email_identity", value);
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
