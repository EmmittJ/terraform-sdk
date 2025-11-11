using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_backup_dr_management_server.
/// </summary>
public partial class GoogleBackupDrManagementServerDataSource : TerraformDataSource
{
    public GoogleBackupDrManagementServerDataSource(string name) : base("google_backup_dr_management_server", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location for the management server (management console)
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The management console URI
    /// </summary>
    [TerraformProperty("management_uri")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ManagementUri { get; }

    /// <summary>
    /// The name of management server (management console)
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// Network details to create management server (management console).
    /// </summary>
    [TerraformProperty("networks")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Networks { get; }

    /// <summary>
    /// The oauth2ClientId of management console.
    /// </summary>
    [TerraformProperty("oauth2_client_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Oauth2ClientId { get; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Project { get; }

    /// <summary>
    /// The type of management server (management console). Default value: &amp;quot;BACKUP_RESTORE&amp;quot; Possible values: [&amp;quot;BACKUP_RESTORE&amp;quot;]
    /// </summary>
    [TerraformProperty("type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Type { get; }

}
