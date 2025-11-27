using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_securityhub_organization_admin_account Terraform resource.
/// Manages a aws_securityhub_organization_admin_account resource.
/// </summary>
public partial class AwsSecurityhubOrganizationAdminAccount(string name) : TerraformResource("aws_securityhub_organization_admin_account", name)
{
    /// <summary>
    /// The admin_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdminAccountId is required")]
    public required TerraformValue<string> AdminAccountId
    {
        get => new TerraformReference<string>(this, "admin_account_id");
        set => SetArgument("admin_account_id", value);
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
