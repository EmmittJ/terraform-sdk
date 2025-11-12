using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleActiveDirectoryDomainTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a google_active_directory_domain resource.
/// </summary>
public partial class GoogleActiveDirectoryDomain : TerraformResource
{
    public GoogleActiveDirectoryDomain(string name) : base("google_active_directory_domain", name)
    {
    }

    /// <summary>
    /// The name of delegated administrator account used to perform Active Directory operations.
    /// If not specified, setupadmin will be used.
    /// </summary>
    [TerraformProperty("admin")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Admin { get; set; }

    /// <summary>
    /// The full names of the Google Compute Engine networks the domain instance is connected to. The domain is only available on networks listed in authorizedNetworks.
    /// If CIDR subnets overlap between networks, domain creation will fail.
    /// </summary>
    [TerraformProperty("authorized_networks")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? AuthorizedNetworks { get; set; }

    /// <summary>
    /// Whether Terraform will be prevented from destroying the domain. Defaults to true.
    /// When a&#39;terraform destroy&#39; or &#39;terraform apply&#39; would delete the domain,
    /// the command will fail if this field is not set to false in Terraform state.
    /// When the field is set to true or unset in Terraform state, a &#39;terraform apply&#39;
    /// or &#39;terraform destroy&#39; that would delete the domain will fail.
    /// When the field is set to false, deleting the domain is allowed.
    /// </summary>
    [TerraformProperty("deletion_protection")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DeletionProtection { get; set; }

    /// <summary>
    /// The fully qualified domain name. e.g. mydomain.myorganization.com, with the restrictions
    /// of https://cloud.google.com/managed-microsoft-ad/reference/rest/v1/projects.locations.global.domains.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    [TerraformProperty("domain_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DomainName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Resource labels that can contain user-provided metadata
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// Locations where domain needs to be provisioned. [regions][compute/docs/regions-zones/]
    /// e.g. us-west1 or us-east4 Service supports up to 4 locations at once. Each location will use a /26 block.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Locations is required")]
    [TerraformProperty("locations")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<string>? Locations { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The CIDR range of internal addresses that are reserved for this domain. Reserved networks must be /24 or larger.
    /// Ranges must be unique and non-overlapping with existing subnets in authorizedNetworks
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReservedIpRange is required")]
    [TerraformProperty("reserved_ip_range")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ReservedIpRange { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleActiveDirectoryDomainTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// The fully-qualified domain name of the exposed domain used by clients to connect to the service.
    /// Similar to what would be chosen for an Active Directory set up on an internal network.
    /// </summary>
    [TerraformProperty("fqdn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Fqdn { get; }

    /// <summary>
    /// The unique name of the domain using the format: &#39;projects/{project}/locations/global/domains/{domainName}&#39;.
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

}
