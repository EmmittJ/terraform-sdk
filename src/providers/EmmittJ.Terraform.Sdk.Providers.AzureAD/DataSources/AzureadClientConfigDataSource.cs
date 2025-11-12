using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzureadClientConfigDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azuread_client_config.
/// </summary>
public partial class AzureadClientConfigDataSource : TerraformDataSource
{
    public AzureadClientConfigDataSource(string name) : base("azuread_client_config", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzureadClientConfigDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The client ID (application ID) linked to the authenticated principal, or the application used for delegated authentication
    /// </summary>
    [TerraformProperty("client_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ClientId { get; }

    /// <summary>
    /// The object ID of the authenticated principal
    /// </summary>
    [TerraformProperty("object_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ObjectId { get; }

    /// <summary>
    /// The tenant ID of the authenticated principal
    /// </summary>
    [TerraformProperty("tenant_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> TenantId { get; }

}
