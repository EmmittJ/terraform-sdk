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
        this.DeclareOutput("behavior_on_mx_failure");
        this.DeclareOutput("mail_from_domain");
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
    /// The behavior_on_mx_failure attribute.
    /// </summary>
    public TerraformExpression BehaviorOnMxFailure => this["behavior_on_mx_failure"];

    /// <summary>
    /// The mail_from_domain attribute.
    /// </summary>
    public TerraformExpression MailFromDomain => this["mail_from_domain"];

}
