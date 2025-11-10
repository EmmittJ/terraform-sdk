using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_compute_network_attachment.
/// </summary>
public class GoogleComputeNetworkAttachmentDataSource : TerraformDataSource
{
    public GoogleComputeNetworkAttachmentDataSource(string name) : base("google_compute_network_attachment", name)
    {
    }

    /// <summary>
    /// Name of the resource. Provided by the client when the resource is created. The name must be 1-63 characters long, and comply with RFC1035. Specifically, the name must be 1-63 characters long and match the regular expression [a-z]([-a-z0-9]*[a-z0-9])? which means the first character must be a lowercase letter, and all following characters must be a dash, lowercase letter, or digit, except the last character, which cannot be a dash.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Project { get; set; }

    /// <summary>
    /// URL of the region where the network attachment resides. This field applies only to the region resource. You must specify this field as part of the HTTP request URL. It is not settable as a field in the request body.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Region is required")]
    [TerraformPropertyName("region")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Region { get; set; }

    /// <summary>
    /// An array of connections for all the producers connected to this network attachment.
    /// </summary>
    [TerraformPropertyName("connection_endpoints")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ConnectionEndpoints => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "connection_endpoints");

    /// <summary>
    /// The connection preference of service attachment. The value can be set to ACCEPT_AUTOMATIC. An ACCEPT_AUTOMATIC service attachment is one that always accepts the connection from consumer forwarding rules. Possible values: [&amp;quot;ACCEPT_AUTOMATIC&amp;quot;, &amp;quot;ACCEPT_MANUAL&amp;quot;, &amp;quot;INVALID&amp;quot;]
    /// </summary>
    [TerraformPropertyName("connection_preference")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ConnectionPreference => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "connection_preference");

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    [TerraformPropertyName("creation_timestamp")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreationTimestamp => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "creation_timestamp");

    /// <summary>
    /// An optional description of this resource. Provide this property when you create the resource.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// Fingerprint of this resource. A hash of the contents stored in this object. This
    /// field is used in optimistic locking. An up-to-date fingerprint must be provided in order to patch.
    /// </summary>
    [TerraformPropertyName("fingerprint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Fingerprint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "fingerprint");

    /// <summary>
    /// The unique identifier for the resource type. The server generates this identifier.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Type of the resource.
    /// </summary>
    [TerraformPropertyName("kind")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Kind => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "kind");

    /// <summary>
    /// The URL of the network which the Network Attachment belongs to. Practically it is inferred by fetching the network of the first subnetwork associated.
    /// Because it is required that all the subnetworks must be from the same network, it is assured that the Network Attachment belongs to the same network as all the subnetworks.
    /// </summary>
    [TerraformPropertyName("network")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Network => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "network");

    /// <summary>
    /// Projects that are allowed to connect to this network attachment. The project can be specified using its id or number.
    /// </summary>
    [TerraformPropertyName("producer_accept_lists")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> ProducerAcceptLists => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "producer_accept_lists");

    /// <summary>
    /// Projects that are not allowed to connect to this network attachment. The project can be specified using its id or number.
    /// </summary>
    [TerraformPropertyName("producer_reject_lists")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> ProducerRejectLists => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "producer_reject_lists");

    /// <summary>
    /// Server-defined URL for the resource.
    /// </summary>
    [TerraformPropertyName("self_link")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SelfLink => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "self_link");

    /// <summary>
    /// Server-defined URL for this resource&#39;s resource id.
    /// </summary>
    [TerraformPropertyName("self_link_with_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SelfLinkWithId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "self_link_with_id");

    /// <summary>
    /// An array of URLs where each entry is the URL of a subnet provided by the service consumer to use for endpoints in the producers that connect to this network attachment.
    /// </summary>
    [TerraformPropertyName("subnetworks")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> Subnetworks => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "subnetworks");

}
