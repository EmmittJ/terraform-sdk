using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_access_approval_organization_service_account Terraform data source.
/// Retrieves information about a google_access_approval_organization_service_account.
/// </summary>
public partial class GoogleAccessApprovalOrganizationServiceAccountDataSource(string name) : TerraformDataSource("google_access_approval_organization_service_account", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The organization_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrganizationId is required")]
    public required TerraformValue<string> OrganizationId
    {
        get => new TerraformReference<string>(this, "organization_id");
        set => SetArgument("organization_id", value);
    }

    /// <summary>
    /// The account_email attribute.
    /// </summary>
    public TerraformValue<string> AccountEmail
    {
        get => new TerraformReference<string>(this, "account_email");
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

}
