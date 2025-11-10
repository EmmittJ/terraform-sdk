using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_sesv2_email_identity_mail_from_attributes.
/// </summary>
public class AwsSesv2EmailIdentityMailFromAttributesDataSource : TerraformDataSource
{
    public AwsSesv2EmailIdentityMailFromAttributesDataSource(string name) : base("aws_sesv2_email_identity_mail_from_attributes", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("behavior_on_mx_failure");
        SetOutput("mail_from_domain");
        SetOutput("email_identity");
        SetOutput("id");
        SetOutput("region");
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

    /// <summary>
    /// The behavior_on_mx_failure attribute.
    /// </summary>
    public TerraformExpression BehaviorOnMxFailure => this["behavior_on_mx_failure"];

    /// <summary>
    /// The mail_from_domain attribute.
    /// </summary>
    public TerraformExpression MailFromDomain => this["mail_from_domain"];

}
