using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_storage_transfer_project_service_account.
/// </summary>
public class GoogleStorageTransferProjectServiceAccountDataSource : TerraformDataSource
{
    public GoogleStorageTransferProjectServiceAccountDataSource(string name) : base("google_storage_transfer_project_service_account", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("email");
        this.WithOutput("member");
        this.WithOutput("subject_id");
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
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The email attribute.
    /// </summary>
    public TerraformExpression Email => this["email"];

    /// <summary>
    /// The member attribute.
    /// </summary>
    public TerraformExpression Member => this["member"];

    /// <summary>
    /// The subject_id attribute.
    /// </summary>
    public TerraformExpression SubjectId => this["subject_id"];

}
