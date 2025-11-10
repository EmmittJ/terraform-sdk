using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_access_approval_project_service_account.
/// </summary>
public class GoogleAccessApprovalProjectServiceAccountDataSource : TerraformDataSource
{
    public GoogleAccessApprovalProjectServiceAccountDataSource(string name) : base("google_access_approval_project_service_account", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("account_email");
        SetOutput("name");
        SetOutput("id");
        SetOutput("project_id");
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
    /// The project_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectId is required")]
    public required TerraformProperty<string> ProjectId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project_id");
        set => SetProperty("project_id", value);
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
