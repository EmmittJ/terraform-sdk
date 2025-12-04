using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_storage_transfer_project_service_account Terraform data source.
/// Retrieves information about a google_storage_transfer_project_service_account.
/// </summary>
public partial class GoogleStorageTransferProjectServiceAccountDataSource(string name) : TerraformDataSource("google_storage_transfer_project_service_account", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The email attribute.
    /// </summary>
    public TerraformValue<string> Email
        => AsReference("email");

    /// <summary>
    /// The member attribute.
    /// </summary>
    public TerraformValue<string> Member
        => AsReference("member");

    /// <summary>
    /// The subject_id attribute.
    /// </summary>
    public TerraformValue<string> SubjectId
        => AsReference("subject_id");

}
