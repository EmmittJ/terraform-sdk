using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_access_approval_folder_service_account Terraform data source.
/// Retrieves information about a google_access_approval_folder_service_account.
/// </summary>
public partial class GoogleAccessApprovalFolderServiceAccountDataSource(string name) : TerraformDataSource("google_access_approval_folder_service_account", name)
{
    /// <summary>
    /// The folder_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FolderId is required")]
    public required TerraformValue<string> FolderId
    {
        get => GetArgument<TerraformValue<string>>("folder_id");
        set => SetArgument("folder_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The account_email attribute.
    /// </summary>
    public TerraformValue<string> AccountEmail
        => AsReference("account_email");

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

}
