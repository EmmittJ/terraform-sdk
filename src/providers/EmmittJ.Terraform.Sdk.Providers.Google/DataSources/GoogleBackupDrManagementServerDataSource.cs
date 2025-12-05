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
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location for the management server (management console)
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The management console URI
    /// </summary>
    public TerraformList<TerraformMap<object>> ManagementUri
        => CreateReference("management_uri");

    /// <summary>
    /// The name of management server (management console)
    /// </summary>
    public TerraformValue<string> Name
        => CreateReference("name");

    /// <summary>
    /// Network details to create management server (management console).
    /// </summary>
    public TerraformList<TerraformMap<object>> Networks
        => CreateReference("networks");

    /// <summary>
    /// The oauth2ClientId of management console.
    /// </summary>
    public TerraformValue<string> Oauth2ClientId
        => CreateReference("oauth2_client_id");

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
        => CreateReference("project");

    /// <summary>
    /// The type of management server (management console). Default value: &amp;quot;BACKUP_RESTORE&amp;quot; Possible values: [&amp;quot;BACKUP_RESTORE&amp;quot;]
    /// </summary>
    public TerraformValue<string> Type
        => CreateReference("type");

}
