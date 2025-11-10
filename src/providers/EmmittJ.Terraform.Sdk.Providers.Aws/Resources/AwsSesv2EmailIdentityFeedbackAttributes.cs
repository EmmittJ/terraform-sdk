using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_sesv2_email_identity_feedback_attributes resource.
/// </summary>
public class AwsSesv2EmailIdentityFeedbackAttributes : TerraformResource
{
    public AwsSesv2EmailIdentityFeedbackAttributes(string name) : base("aws_sesv2_email_identity_feedback_attributes", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("email_forwarding_enabled");
        SetOutput("email_identity");
        SetOutput("id");
        SetOutput("region");
    }

    /// <summary>
    /// The email_forwarding_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> EmailForwardingEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("email_forwarding_enabled");
        set => SetProperty("email_forwarding_enabled", value);
    }

    /// <summary>
    /// The email_identity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EmailIdentity is required")]
    public required TerraformProperty<string> EmailIdentity
    {
        get => GetRequiredOutput<TerraformProperty<string>>("email_identity");
        set => SetProperty("email_identity", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

}
