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
        this.DeclareOutput("account_email");
        this.DeclareOutput("name");
    }

    /// <summary>
    /// The folder_id attribute.
    /// </summary>
    public TerraformProperty<string>? FolderId
    {
        get => GetProperty<TerraformProperty<string>>("folder_id");
        set => this.WithProperty("folder_id", value);
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
    /// The account_email attribute.
    /// </summary>
    public TerraformExpression AccountEmail => this["account_email"];

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
