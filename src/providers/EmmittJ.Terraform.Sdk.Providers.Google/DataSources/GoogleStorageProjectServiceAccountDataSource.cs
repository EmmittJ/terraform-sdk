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
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The user_project attribute.
    /// </summary>
    public TerraformValue<string>? UserProject
    {
        get => new TerraformReference<string>(this, "user_project");
        set => SetArgument("user_project", value);
    }

    /// <summary>
    /// The email_address attribute.
    /// </summary>
    public TerraformValue<string> EmailAddress
    {
        get => new TerraformReference<string>(this, "email_address");
    }

    /// <summary>
    /// The member attribute.
    /// </summary>
    public TerraformValue<string> Member
    {
        get => new TerraformReference<string>(this, "member");
    }

}
