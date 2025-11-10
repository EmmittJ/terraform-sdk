using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_beyondcorp_security_gateway.
/// </summary>
public class GoogleBeyondcorpSecurityGatewayDataSource : TerraformDataSource
{
    public GoogleBeyondcorpSecurityGatewayDataSource(string name) : base("google_beyondcorp_security_gateway", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Project { get; set; }

    /// <summary>
    /// Optional. User-settable SecurityGateway resource ID.
    /// * Must start with a letter.
    /// * Must contain between 4-63 characters from &#39;/a-z-/&#39;.
    /// * Must end with a number or letter.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGatewayId is required")]
    [TerraformPropertyName("security_gateway_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SecurityGatewayId { get; set; }

    /// <summary>
    /// Output only. Timestamp when the resource was created.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// Service account used for operations that involve resources in consumer projects.
    /// </summary>
    [TerraformPropertyName("delegating_service_account")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DelegatingServiceAccount => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "delegating_service_account");

    /// <summary>
    /// Optional. An arbitrary user-provided name for the SecurityGateway.
    /// Cannot exceed 64 characters.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DisplayName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "display_name");

    /// <summary>
    /// Output only. IP addresses that will be used for establishing
    /// connection to the endpoints.
    /// </summary>
    [TerraformPropertyName("external_ips")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> ExternalIps => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "external_ips");

    /// <summary>
    /// Optional. Map of Hubs that represents regional data path deployment with GCP region
    /// as a key.
    /// </summary>
    [TerraformPropertyName("hubs")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<object>>> Hubs => new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>(ResourceAddress, "hubs");

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122. Must be omitted or set to &#39;global&#39;.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Location => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "location");

    /// <summary>
    /// Identifier. Name of the resource.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// Shared proxy configuration for all apps.
    /// </summary>
    [TerraformPropertyName("proxy_protocol_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ProxyProtocolConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "proxy_protocol_config");

    /// <summary>
    /// Settings related to the Service Discovery.
    /// </summary>
    [TerraformPropertyName("service_discovery")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ServiceDiscovery => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "service_discovery");

    /// <summary>
    /// Output only. The operational state of the SecurityGateway.
    /// Possible values:
    /// STATE_UNSPECIFIED
    /// CREATING
    /// UPDATING
    /// DELETING
    /// RUNNING
    /// DOWN
    /// ERROR
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> State => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state");

    /// <summary>
    /// Output only. Timestamp when the resource was last modified.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "update_time");

}
