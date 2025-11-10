using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_backup_dr_management_server.
/// </summary>
public class GoogleBackupDrManagementServerDataSource : TerraformDataSource
{
    public GoogleBackupDrManagementServerDataSource(string name) : base("google_backup_dr_management_server", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("management_uri");
        this.WithOutput("name");
        this.WithOutput("networks");
        this.WithOutput("oauth2_client_id");
        this.WithOutput("project");
        this.WithOutput("type");
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
    /// The location for the management server (management console)
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The management console URI
    /// </summary>
    public TerraformExpression ManagementUri => this["management_uri"];

    /// <summary>
    /// The name of management server (management console)
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// Network details to create management server (management console).
    /// </summary>
    public TerraformExpression Networks => this["networks"];

    /// <summary>
    /// The oauth2ClientId of management console.
    /// </summary>
    public TerraformExpression Oauth2ClientId => this["oauth2_client_id"];

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformExpression Project => this["project"];

    /// <summary>
    /// The type of management server (management console). Default value: &amp;quot;BACKUP_RESTORE&amp;quot; Possible values: [&amp;quot;BACKUP_RESTORE&amp;quot;]
    /// </summary>
    public TerraformExpression Type => this["type"];

}
