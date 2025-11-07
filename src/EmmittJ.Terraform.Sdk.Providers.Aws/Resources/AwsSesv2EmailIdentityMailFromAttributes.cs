using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_sesv2_email_identity_mail_from_attributes resource.
/// </summary>
public class AwsSesv2EmailIdentityMailFromAttributes : TerraformResource
{
    public AwsSesv2EmailIdentityMailFromAttributes(string name) : base("aws_sesv2_email_identity_mail_from_attributes", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The behavior_on_mx_failure attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? BehaviorOnMxFailure
    {
        get => GetProperty<TerraformLiteralProperty<string>>("behavior_on_mx_failure");
        set => this.WithProperty("behavior_on_mx_failure", value);
    }

    /// <summary>
    /// The email_identity attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? EmailIdentity
    {
        get => GetProperty<TerraformLiteralProperty<string>>("email_identity");
        set => this.WithProperty("email_identity", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The mail_from_domain attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? MailFromDomain
    {
        get => GetProperty<TerraformLiteralProperty<string>>("mail_from_domain");
        set => this.WithProperty("mail_from_domain", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

}
