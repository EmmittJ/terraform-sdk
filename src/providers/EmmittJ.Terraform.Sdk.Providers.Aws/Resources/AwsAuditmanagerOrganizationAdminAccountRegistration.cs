using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_auditmanager_organization_admin_account_registration Terraform resource.
/// Manages a aws_auditmanager_organization_admin_account_registration resource.
/// </summary>
public partial class AwsAuditmanagerOrganizationAdminAccountRegistration(string name) : TerraformResource("aws_auditmanager_organization_admin_account_registration", name)
{
    /// <summary>
    /// The admin_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdminAccountId is required")]
    public required TerraformValue<string> AdminAccountId
    {
        get => GetRequiredArgument<TerraformValue<string>>("admin_account_id");
        set => SetArgument("admin_account_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => CreateReference("id");

    /// <summary>
    /// The organization_id attribute.
    /// </summary>
    public TerraformValue<string> OrganizationId
        => CreateReference("organization_id");

}
