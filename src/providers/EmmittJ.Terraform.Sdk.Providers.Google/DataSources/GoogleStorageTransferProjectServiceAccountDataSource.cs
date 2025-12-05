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
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? CreateReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The email attribute.
    /// </summary>
    public TerraformValue<string> Email
        => CreateReference("email");

    /// <summary>
    /// The member attribute.
    /// </summary>
    public TerraformValue<string> Member
        => CreateReference("member");

    /// <summary>
    /// The subject_id attribute.
    /// </summary>
    public TerraformValue<string> SubjectId
        => CreateReference("subject_id");

}
