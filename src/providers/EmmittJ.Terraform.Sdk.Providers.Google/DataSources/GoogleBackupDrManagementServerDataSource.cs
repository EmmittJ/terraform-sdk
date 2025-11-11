using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_backup_dr_management_server.
/// </summary>
public class GoogleBackupDrManagementServerDataSource : TerraformDataSource
{
    public GoogleBackupDrManagementServerDataSource(string name) : base("google_backup_dr_management_server", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The location for the management server (management console)
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The management console URI
    /// </summary>
    [TerraformPropertyName("management_uri")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ManagementUri => new TerraformReference(this, "management_uri");

    /// <summary>
    /// The name of management server (management console)
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

    /// <summary>
    /// Network details to create management server (management console).
    /// </summary>
    [TerraformPropertyName("networks")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Networks => new TerraformReference(this, "networks");

    /// <summary>
    /// The oauth2ClientId of management console.
    /// </summary>
    [TerraformPropertyName("oauth2_client_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Oauth2ClientId => new TerraformReference(this, "oauth2_client_id");

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Project => new TerraformReference(this, "project");

    /// <summary>
    /// The type of management server (management console). Default value: &amp;quot;BACKUP_RESTORE&amp;quot; Possible values: [&amp;quot;BACKUP_RESTORE&amp;quot;]
    /// </summary>
    [TerraformPropertyName("type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Type => new TerraformReference(this, "type");

}
