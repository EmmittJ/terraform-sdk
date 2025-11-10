using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for networks in .
/// Nesting mode: list
/// </summary>
public class GoogleBackupDrManagementServerNetworksBlock : ITerraformBlock
{
    /// <summary>
    /// Network with format &#39;projects/{{project_id}}/global/networks/{{network_id}}&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Network is required")]
    [TerraformPropertyName("network")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Network { get; set; }

    /// <summary>
    /// Type of Network peeringMode Default value: &amp;quot;PRIVATE_SERVICE_ACCESS&amp;quot; Possible values: [&amp;quot;PRIVATE_SERVICE_ACCESS&amp;quot;]
    /// </summary>
    [TerraformPropertyName("peering_mode")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PeeringMode { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleBackupDrManagementServerTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

}

/// <summary>
/// Manages a google_backup_dr_management_server resource.
/// </summary>
public class GoogleBackupDrManagementServer : TerraformResource
{
    public GoogleBackupDrManagementServer(string name) : base("google_backup_dr_management_server", name)
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
    /// The name of management server (management console)
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// The type of management server (management console). Default value: &amp;quot;BACKUP_RESTORE&amp;quot; Possible values: [&amp;quot;BACKUP_RESTORE&amp;quot;]
    /// </summary>
    [TerraformPropertyName("type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Type { get; set; }

    /// <summary>
    /// Block for networks.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("networks")]
    public TerraformList<TerraformBlock<GoogleBackupDrManagementServerNetworksBlock>>? Networks { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleBackupDrManagementServerTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The management console URI
    /// </summary>
    [TerraformPropertyName("management_uri")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ManagementUri => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "management_uri");

    /// <summary>
    /// The oauth2ClientId of management console.
    /// </summary>
    [TerraformPropertyName("oauth2_client_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Oauth2ClientId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "oauth2_client_id");

}
