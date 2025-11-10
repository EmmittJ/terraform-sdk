using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_access_approval_folder_service_account.
/// </summary>
public class GoogleAccessApprovalFolderServiceAccountDataSource : TerraformDataSource
{
    public GoogleAccessApprovalFolderServiceAccountDataSource(string name) : base("google_access_approval_folder_service_account", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("account_email");
        SetOutput("name");
        SetOutput("folder_id");
        SetOutput("id");
    }

    /// <summary>
    /// The folder_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FolderId is required")]
    public required TerraformProperty<string> FolderId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("folder_id");
        set => SetProperty("folder_id", value);
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
    /// The account_email attribute.
    /// </summary>
    public TerraformExpression AccountEmail => this["account_email"];

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
