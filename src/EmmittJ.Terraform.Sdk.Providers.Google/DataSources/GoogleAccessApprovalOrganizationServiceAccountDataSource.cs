using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_access_approval_organization_service_account.
/// </summary>
public class GoogleAccessApprovalOrganizationServiceAccountDataSource : TerraformDataSource
{
    public GoogleAccessApprovalOrganizationServiceAccountDataSource(string name) : base("google_access_approval_organization_service_account", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("account_email");
        this.DeclareOutput("name");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The organization_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrganizationId is required")]
    public required TerraformProperty<string> OrganizationId
    {
        get => GetProperty<TerraformProperty<string>>("organization_id");
        set => this.WithProperty("organization_id", value);
    }

    /// <summary>
    /// The account_email attribute.
    /// </summary>
    public TerraformExpression AccountEmail => this["account_email"];

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
