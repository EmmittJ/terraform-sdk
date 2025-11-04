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
    public string? BehaviorOnMxFailure
    {
        get => GetProperty<TerraformLiteralProperty<string>>("behavior_on_mx_failure")?.Value;
        set => this.WithProperty("behavior_on_mx_failure", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The email_identity attribute.
    /// </summary>
    public string? EmailIdentity
    {
        get => GetProperty<TerraformLiteralProperty<string>>("email_identity")?.Value;
        set => this.WithProperty("email_identity", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The mail_from_domain attribute.
    /// </summary>
    public string? MailFromDomain
    {
        get => GetProperty<TerraformLiteralProperty<string>>("mail_from_domain")?.Value;
        set => this.WithProperty("mail_from_domain", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
