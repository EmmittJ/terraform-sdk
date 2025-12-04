using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_backup_dr_management_server Terraform data source.
/// Retrieves information about a google_backup_dr_management_server.
/// </summary>
public partial class GoogleBackupDrManagementServerDataSource(string name) : TerraformDataSource("google_backup_dr_management_server", name)
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
    /// The location for the management server (management console)
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The management console URI
    /// </summary>
    public TerraformList<TerraformMap<object>> ManagementUri
        => AsReference("management_uri");

    /// <summary>
    /// The name of management server (management console)
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// Network details to create management server (management console).
    /// </summary>
    public TerraformList<TerraformMap<object>> Networks
        => AsReference("networks");

    /// <summary>
    /// The oauth2ClientId of management console.
    /// </summary>
    public TerraformValue<string> Oauth2ClientId
        => AsReference("oauth2_client_id");

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
        => AsReference("project");

    /// <summary>
    /// The type of management server (management console). Default value: &amp;quot;BACKUP_RESTORE&amp;quot; Possible values: [&amp;quot;BACKUP_RESTORE&amp;quot;]
    /// </summary>
    public TerraformValue<string> Type
        => AsReference("type");

}
