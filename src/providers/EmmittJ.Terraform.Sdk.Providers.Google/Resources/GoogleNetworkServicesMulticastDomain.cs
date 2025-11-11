using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for connection_config in .
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesMulticastDomainConnectionConfigBlock
{
    /// <summary>
    /// The VPC connection type.
    /// Possible values:
    /// NCC
    /// SAME_VPC
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionType is required")]
    [TerraformPropertyName("connection_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ConnectionType { get; set; }

    /// <summary>
    /// The resource name of the
    /// [NCC](https://cloud.google.com/network-connectivity-center) hub.
    /// Use the following format:
    /// &#39;projects/{project}/locations/global/hubs/{hub}&#39;.
    /// </summary>
    [TerraformPropertyName("ncc_hub")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? NccHub { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleNetworkServicesMulticastDomainTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_network_services_multicast_domain resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleNetworkServicesMulticastDomain : TerraformResource
{
    public GoogleNetworkServicesMulticastDomain(string name) : base("google_network_services_multicast_domain", name)
    {
    }

    /// <summary>
    /// The resource name of the multicast admin VPC network.
    /// Use the following format:
    /// &#39;projects/{project}/locations/global/networks/{network}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdminNetwork is required")]
    [TerraformPropertyName("admin_network")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> AdminNetwork { get; set; }

    /// <summary>
    /// An optional text description of the multicast domain.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Labels as key-value pairs.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The multicast domain group this domain should be associated with.
    /// Use the following format:
    /// &#39;projects/{project}/locations/global/multicastDomainGroups/{multicast_domain_group}&#39;.
    /// </summary>
    [TerraformPropertyName("multicast_domain_group")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MulticastDomainGroup { get; set; }

    /// <summary>
    /// A unique name for the multicast domain.
    /// The name is restricted to letters, numbers, and hyphen, with the first
    /// character a letter, and the last a letter or a number. The name must not
    /// exceed 48 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MulticastDomainId is required")]
    [TerraformPropertyName("multicast_domain_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> MulticastDomainId { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// Block for connection_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ConnectionConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConnectionConfig block(s) allowed")]
    [TerraformPropertyName("connection_config")]
    public TerraformList<TerraformBlock<GoogleNetworkServicesMulticastDomainConnectionConfigBlock>>? ConnectionConfig { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleNetworkServicesMulticastDomainTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// [Output only] The timestamp when the multicast domain was created.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreateTime => new TerraformReference(this, "create_time");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> EffectiveLabels => new TerraformReference(this, "effective_labels");

    /// <summary>
    /// Identifier. The resource name of the multicast domain.
    /// Use the following format:
    /// &#39;projects/*/locations/global/multicastDomains/*&#39;
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> TerraformLabels => new TerraformReference(this, "terraform_labels");

    /// <summary>
    /// [Output only] The Google-generated UUID for the resource. This value is
    /// unique across all multicast domain resources. If a domain is deleted and
    /// another with the same name is created, the new domain is assigned a
    /// different unique_id.
    /// </summary>
    [TerraformPropertyName("unique_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UniqueId => new TerraformReference(this, "unique_id");

    /// <summary>
    /// [Output only] The timestamp when the multicast domain was most recently
    /// updated.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UpdateTime => new TerraformReference(this, "update_time");

}
