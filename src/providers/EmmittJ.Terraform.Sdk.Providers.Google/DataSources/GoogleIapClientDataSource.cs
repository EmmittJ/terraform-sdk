using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_iap_client.
/// </summary>
public partial class GoogleIapClientDataSource : TerraformDataSource
{
    public GoogleIapClientDataSource(string name) : base("google_iap_client", name)
    {
    }

    /// <summary>
    /// Identifier of the brand to which this client
    /// is attached to. The format is
    /// &#39;projects/{project_number}/brands/{brand_id}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Brand is required")]
    [TerraformProperty("brand")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Brand { get; set; }

    /// <summary>
    /// Output only. Unique identifier of the OAuth client.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    [TerraformProperty("client_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ClientId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Human-friendly name given to the OAuth client.
    /// </summary>
    [TerraformProperty("display_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DisplayName { get; }

    /// <summary>
    /// Output only. Client secret of the OAuth client.
    /// </summary>
    [TerraformProperty("secret")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Secret { get; }

}
