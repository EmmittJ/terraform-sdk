using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleActiveDirectoryDomainTimeoutsBlock : ITerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a google_active_directory_domain resource.
/// </summary>
public class GoogleActiveDirectoryDomain : TerraformResource
{
    public GoogleActiveDirectoryDomain(string name) : base("google_active_directory_domain", name)
    {
    }

    /// <summary>
    /// The name of delegated administrator account used to perform Active Directory operations.
    /// If not specified, setupadmin will be used.
    /// </summary>
    [TerraformPropertyName("admin")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Admin { get; set; }

    /// <summary>
    /// The full names of the Google Compute Engine networks the domain instance is connected to. The domain is only available on networks listed in authorizedNetworks.
    /// If CIDR subnets overlap between networks, domain creation will fail.
    /// </summary>
    [TerraformPropertyName("authorized_networks")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? AuthorizedNetworks { get; set; }

    /// <summary>
    /// Whether Terraform will be prevented from destroying the domain. Defaults to true.
    /// When a&#39;terraform destroy&#39; or &#39;terraform apply&#39; would delete the domain,
    /// the command will fail if this field is not set to false in Terraform state.
    /// When the field is set to true or unset in Terraform state, a &#39;terraform apply&#39;
    /// or &#39;terraform destroy&#39; that would delete the domain will fail.
    /// When the field is set to false, deleting the domain is allowed.
    /// </summary>
    [TerraformPropertyName("deletion_protection")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DeletionProtection { get; set; }

    /// <summary>
    /// The fully qualified domain name. e.g. mydomain.myorganization.com, with the restrictions
    /// of https://cloud.google.com/managed-microsoft-ad/reference/rest/v1/projects.locations.global.domains.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    [TerraformPropertyName("domain_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DomainName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Resource labels that can contain user-provided metadata
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Labels { get; set; }

    /// <summary>
    /// Locations where domain needs to be provisioned. [regions][compute/docs/regions-zones/]
    /// e.g. us-west1 or us-east4 Service supports up to 4 locations at once. Each location will use a /26 block.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Locations is required")]
    [TerraformPropertyName("locations")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<List<TerraformProperty<string>>>? Locations { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// The CIDR range of internal addresses that are reserved for this domain. Reserved networks must be /24 or larger.
    /// Ranges must be unique and non-overlapping with existing subnets in authorizedNetworks
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReservedIpRange is required")]
    [TerraformPropertyName("reserved_ip_range")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ReservedIpRange { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleActiveDirectoryDomainTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EffectiveLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "effective_labels");

    /// <summary>
    /// The fully-qualified domain name of the exposed domain used by clients to connect to the service.
    /// Similar to what would be chosen for an Active Directory set up on an internal network.
    /// </summary>
    [TerraformPropertyName("fqdn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Fqdn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "fqdn");

    /// <summary>
    /// The unique name of the domain using the format: &#39;projects/{project}/locations/global/domains/{domainName}&#39;.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TerraformLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "terraform_labels");

}
