using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for networks in .
/// Nesting mode: list
/// </summary>
public partial class GoogleBackupDrManagementServerNetworksBlock : TerraformBlockBase
{
    /// <summary>
    /// Network with format &#39;projects/{{project_id}}/global/networks/{{network_id}}&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Network is required")]
    [TerraformProperty("network")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Network { get; set; }

    /// <summary>
    /// Type of Network peeringMode Default value: &amp;quot;PRIVATE_SERVICE_ACCESS&amp;quot; Possible values: [&amp;quot;PRIVATE_SERVICE_ACCESS&amp;quot;]
    /// </summary>
    [TerraformProperty("peering_mode")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PeeringMode { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleBackupDrManagementServerTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

}

/// <summary>
/// Manages a google_backup_dr_management_server resource.
/// </summary>
public partial class GoogleBackupDrManagementServer : TerraformResource
{
    public GoogleBackupDrManagementServer(string name) : base("google_backup_dr_management_server", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location for the management server (management console)
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name of management server (management console)
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The type of management server (management console). Default value: &amp;quot;BACKUP_RESTORE&amp;quot; Possible values: [&amp;quot;BACKUP_RESTORE&amp;quot;]
    /// </summary>
    [TerraformProperty("type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Type { get; set; }

    /// <summary>
    /// Block for networks.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("networks")]
    public TerraformList<TerraformBlock<GoogleBackupDrManagementServerNetworksBlock>>? Networks { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleBackupDrManagementServerTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The management console URI
    /// </summary>
    [TerraformProperty("management_uri")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> ManagementUri { get; }

    /// <summary>
    /// The oauth2ClientId of management console.
    /// </summary>
    [TerraformProperty("oauth2_client_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Oauth2ClientId { get; }

}
