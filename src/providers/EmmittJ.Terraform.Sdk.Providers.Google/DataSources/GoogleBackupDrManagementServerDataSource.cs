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
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location for the management server (management console)
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The management console URI
    /// </summary>
    public TerraformList<TerraformMap<object>> ManagementUri
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "management_uri").ResolveNodes(ctx));
    }

    /// <summary>
    /// The name of management server (management console)
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// Network details to create management server (management console).
    /// </summary>
    public TerraformList<TerraformMap<object>> Networks
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "networks").ResolveNodes(ctx));
    }

    /// <summary>
    /// The oauth2ClientId of management console.
    /// </summary>
    public TerraformValue<string> Oauth2ClientId
    {
        get => new TerraformReference<string>(this, "oauth2_client_id");
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
    }

    /// <summary>
    /// The type of management server (management console). Default value: &amp;quot;BACKUP_RESTORE&amp;quot; Possible values: [&amp;quot;BACKUP_RESTORE&amp;quot;]
    /// </summary>
    public TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
    }

}
