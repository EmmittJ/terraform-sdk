using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_iap_client.
/// </summary>
public class GoogleIapClientDataSource : TerraformDataSource
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
    [TerraformPropertyName("brand")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Brand { get; set; }

    /// <summary>
    /// Output only. Unique identifier of the OAuth client.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    [TerraformPropertyName("client_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ClientId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Human-friendly name given to the OAuth client.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DisplayName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "display_name");

    /// <summary>
    /// Output only. Client secret of the OAuth client.
    /// </summary>
    [TerraformPropertyName("secret")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Secret => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "secret");

}
