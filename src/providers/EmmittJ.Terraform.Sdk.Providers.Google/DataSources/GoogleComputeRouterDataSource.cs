using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_compute_router.
/// </summary>
public class GoogleComputeRouterDataSource : TerraformDataSource
{
    public GoogleComputeRouterDataSource(string name) : base("google_compute_router", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Name of the resource. The name must be 1-63 characters long, and
    /// comply with RFC1035. Specifically, the name must be 1-63 characters
    /// long and match the regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39;
    /// which means the first character must be a lowercase letter, and all
    /// following characters must be a dash, lowercase letter, or digit,
    /// except the last character, which cannot be a dash.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// A reference to the network to which this router belongs.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Network is required")]
    [TerraformPropertyName("network")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Network { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Project { get; set; }

    /// <summary>
    /// Region where the router resides.
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Region { get; set; }

    /// <summary>
    /// BGP information specific to this router.
    /// </summary>
    [TerraformPropertyName("bgp")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Bgp => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "bgp");

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    [TerraformPropertyName("creation_timestamp")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreationTimestamp => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "creation_timestamp");

    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// Indicates if a router is dedicated for use with encrypted VLAN
    /// attachments (interconnectAttachments).
    /// </summary>
    [TerraformPropertyName("encrypted_interconnect_router")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> EncryptedInterconnectRouter => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "encrypted_interconnect_router");

    /// <summary>
    /// Keys used for MD5 authentication.
    /// </summary>
    [TerraformPropertyName("md5_authentication_keys")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Md5AuthenticationKeys => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "md5_authentication_keys");

    /// <summary>
    /// Additional params passed with the request, but not persisted as part of resource payload
    /// </summary>
    [TerraformPropertyName("params")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Params => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "params");

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    [TerraformPropertyName("self_link")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SelfLink => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "self_link");

}
