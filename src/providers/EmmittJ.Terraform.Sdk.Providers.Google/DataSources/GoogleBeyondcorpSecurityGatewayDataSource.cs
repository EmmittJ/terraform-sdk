using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_beyondcorp_security_gateway.
/// </summary>
public partial class GoogleBeyondcorpSecurityGatewayDataSource : TerraformDataSource
{
    public GoogleBeyondcorpSecurityGatewayDataSource(string name) : base("google_beyondcorp_security_gateway", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// Optional. User-settable SecurityGateway resource ID.
    /// * Must start with a letter.
    /// * Must contain between 4-63 characters from &#39;/a-z-/&#39;.
    /// * Must end with a number or letter.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGatewayId is required")]
    [TerraformProperty("security_gateway_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> SecurityGatewayId { get; set; }

    /// <summary>
    /// Output only. Timestamp when the resource was created.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// Service account used for operations that involve resources in consumer projects.
    /// </summary>
    [TerraformProperty("delegating_service_account")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DelegatingServiceAccount { get; }

    /// <summary>
    /// Optional. An arbitrary user-provided name for the SecurityGateway.
    /// Cannot exceed 64 characters.
    /// </summary>
    [TerraformProperty("display_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DisplayName { get; }

    /// <summary>
    /// Output only. IP addresses that will be used for establishing
    /// connection to the endpoints.
    /// </summary>
    [TerraformProperty("external_ips")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> ExternalIps { get; }

    /// <summary>
    /// Optional. Map of Hubs that represents regional data path deployment with GCP region
    /// as a key.
    /// </summary>
    [TerraformProperty("hubs")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<object> Hubs { get; }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122. Must be omitted or set to &#39;global&#39;.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Location { get; }

    /// <summary>
    /// Identifier. Name of the resource.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

    /// <summary>
    /// Shared proxy configuration for all apps.
    /// </summary>
    [TerraformProperty("proxy_protocol_config")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> ProxyProtocolConfig { get; }

    /// <summary>
    /// Settings related to the Service Discovery.
    /// </summary>
    [TerraformProperty("service_discovery")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> ServiceDiscovery { get; }

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
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> State { get; }

    /// <summary>
    /// Output only. Timestamp when the resource was last modified.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> UpdateTime { get; }

}
