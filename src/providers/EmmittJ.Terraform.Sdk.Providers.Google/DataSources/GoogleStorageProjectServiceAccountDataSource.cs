using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_storage_project_service_account.
/// </summary>
public class GoogleStorageProjectServiceAccountDataSource : TerraformDataSource
{
    public GoogleStorageProjectServiceAccountDataSource(string name) : base("google_storage_project_service_account", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("email_address");
        SetOutput("member");
        SetOutput("id");
        SetOutput("project");
        SetOutput("user_project");
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
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// The user_project attribute.
    /// </summary>
    public TerraformProperty<string> UserProject
    {
        get => GetRequiredOutput<TerraformProperty<string>>("user_project");
        set => SetProperty("user_project", value);
    }

    /// <summary>
    /// The email_address attribute.
    /// </summary>
    public TerraformExpression EmailAddress => this["email_address"];

    /// <summary>
    /// The member attribute.
    /// </summary>
    public TerraformExpression Member => this["member"];

}
