using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_storage_project_service_account Terraform data source.
/// Retrieves information about a google_storage_project_service_account.
/// </summary>
public partial class GoogleStorageProjectServiceAccountDataSource(string name) : TerraformDataSource("google_storage_project_service_account", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? AsReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The user_project attribute.
    /// </summary>
    public TerraformValue<string>? UserProject
    {
        get => GetArgument<TerraformValue<string>>("user_project");
        set => SetArgument("user_project", value);
    }

    /// <summary>
    /// The email_address attribute.
    /// </summary>
    public TerraformValue<string> EmailAddress
        => AsReference("email_address");

    /// <summary>
    /// The member attribute.
    /// </summary>
    public TerraformValue<string> Member
        => AsReference("member");

}
