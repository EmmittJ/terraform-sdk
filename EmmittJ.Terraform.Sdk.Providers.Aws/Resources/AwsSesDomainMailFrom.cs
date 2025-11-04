using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ses_domain_mail_from resource.
/// </summary>
public class AwsSesDomainMailFrom : TerraformResource
{
    public AwsSesDomainMailFrom(string name) : base("aws_ses_domain_mail_from", name)
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
    /// The domain attribute.
    /// </summary>
    public string? Domain
    {
        get => GetProperty<TerraformLiteralProperty<string>>("domain")?.Value;
        set => this.WithProperty("domain", value == null ? null : new TerraformLiteralProperty<string>(value));
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
