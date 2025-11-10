using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleIapClientTimeoutsBlock : ITerraformBlock
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
/// Manages a google_iap_client resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public class GoogleIapClient : TerraformResource
{
    public GoogleIapClient(string name) : base("google_iap_client", name)
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
    /// Human-friendly name given to the OAuth client.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformPropertyName("display_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleIapClientTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Output only. Unique identifier of the OAuth client.
    /// </summary>
    [TerraformPropertyName("client_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ClientId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "client_id");

    /// <summary>
    /// Output only. Client secret of the OAuth client.
    /// </summary>
    [TerraformPropertyName("secret")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Secret => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "secret");

}
