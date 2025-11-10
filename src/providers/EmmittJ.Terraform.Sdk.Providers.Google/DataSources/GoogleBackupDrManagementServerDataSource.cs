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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The location for the management server (management console)
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The management console URI
    /// </summary>
    [TerraformPropertyName("management_uri")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ManagementUri => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "management_uri");

    /// <summary>
    /// The name of management server (management console)
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// Network details to create management server (management console).
    /// </summary>
    [TerraformPropertyName("networks")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Networks => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "networks");

    /// <summary>
    /// The oauth2ClientId of management console.
    /// </summary>
    [TerraformPropertyName("oauth2_client_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Oauth2ClientId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "oauth2_client_id");

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Project => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// The type of management server (management console). Default value: &amp;quot;BACKUP_RESTORE&amp;quot; Possible values: [&amp;quot;BACKUP_RESTORE&amp;quot;]
    /// </summary>
    [TerraformPropertyName("type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Type => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "type");

}
