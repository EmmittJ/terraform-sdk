using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for connection_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleNetworkServicesMulticastDomainConnectionConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The VPC connection type.
    /// Possible values:
    /// NCC
    /// SAME_VPC
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionType is required")]
    [TerraformProperty("connection_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ConnectionType { get; set; }

    /// <summary>
    /// The resource name of the
    /// [NCC](https://cloud.google.com/network-connectivity-center) hub.
    /// Use the following format:
    /// &#39;projects/{project}/locations/global/hubs/{hub}&#39;.
    /// </summary>
    [TerraformProperty("ncc_hub")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? NccHub { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleNetworkServicesMulticastDomainTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_network_services_multicast_domain resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleNetworkServicesMulticastDomain : TerraformResource
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
    [TerraformProperty("admin_network")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AdminNetwork { get; set; }

    /// <summary>
    /// An optional text description of the multicast domain.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Labels as key-value pairs.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The multicast domain group this domain should be associated with.
    /// Use the following format:
    /// &#39;projects/{project}/locations/global/multicastDomainGroups/{multicast_domain_group}&#39;.
    /// </summary>
    [TerraformProperty("multicast_domain_group")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MulticastDomainGroup { get; set; }

    /// <summary>
    /// A unique name for the multicast domain.
    /// The name is restricted to letters, numbers, and hyphen, with the first
    /// character a letter, and the last a letter or a number. The name must not
    /// exceed 48 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MulticastDomainId is required")]
    [TerraformProperty("multicast_domain_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> MulticastDomainId { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for connection_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ConnectionConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConnectionConfig block(s) allowed")]
    [TerraformProperty("connection_config")]
    public partial TerraformList<TerraformBlock<GoogleNetworkServicesMulticastDomainConnectionConfigBlock>>? ConnectionConfig { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleNetworkServicesMulticastDomainTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// [Output only] The timestamp when the multicast domain was created.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// Identifier. The resource name of the multicast domain.
    /// Use the following format:
    /// &#39;projects/*/locations/global/multicastDomains/*&#39;
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TerraformLabels { get; }

    /// <summary>
    /// [Output only] The Google-generated UUID for the resource. This value is
    /// unique across all multicast domain resources. If a domain is deleted and
    /// another with the same name is created, the new domain is assigned a
    /// different unique_id.
    /// </summary>
    [TerraformProperty("unique_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UniqueId { get; }

    /// <summary>
    /// [Output only] The timestamp when the multicast domain was most recently
    /// updated.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

}
