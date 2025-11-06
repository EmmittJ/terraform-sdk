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
        this.DeclareOutput("email_address");
        this.DeclareOutput("member");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The user_project attribute.
    /// </summary>
    public string? UserProject
    {
        get => GetProperty<TerraformLiteralProperty<string>>("user_project")?.Value;
        set => this.WithProperty("user_project", value == null ? null : new TerraformLiteralProperty<string>(value));
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
