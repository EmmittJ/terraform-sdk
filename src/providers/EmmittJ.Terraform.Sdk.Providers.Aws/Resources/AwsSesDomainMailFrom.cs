using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_ses_domain_mail_from Terraform resource.
/// Manages a aws_ses_domain_mail_from resource.
/// </summary>
public partial class AwsSesDomainMailFrom(string name) : TerraformResource("aws_ses_domain_mail_from", name)
{
    /// <summary>
    /// The behavior_on_mx_failure attribute.
    /// </summary>
    public TerraformValue<string>? BehaviorOnMxFailure
    {
        get => GetArgument<TerraformValue<string>>("behavior_on_mx_failure");
        set => SetArgument("behavior_on_mx_failure", value);
    }

    /// <summary>
    /// The domain attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Domain is required")]
    public required TerraformValue<string> Domain
    {
        get => GetRequiredArgument<TerraformValue<string>>("domain");
        set => SetArgument("domain", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The mail_from_domain attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MailFromDomain is required")]
    public required TerraformValue<string> MailFromDomain
    {
        get => GetRequiredArgument<TerraformValue<string>>("mail_from_domain");
        set => SetArgument("mail_from_domain", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

}
