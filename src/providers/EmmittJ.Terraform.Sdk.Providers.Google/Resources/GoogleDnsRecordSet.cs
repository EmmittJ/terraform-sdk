using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for routing_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleDnsRecordSetRoutingPolicyBlock : ITerraformBlock
{
    /// <summary>
    /// Specifies whether to enable fencing for geo queries.
    /// </summary>
    [TerraformPropertyName("enable_geo_fencing")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableGeoFencing { get; set; }

    /// <summary>
    /// Specifies the health check.
    /// </summary>
    [TerraformPropertyName("health_check")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? HealthCheck { get; set; }

}

/// <summary>
/// Manages a google_dns_record_set resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleDnsRecordSet : TerraformResource
{
    public GoogleDnsRecordSet(string name) : base("google_dns_record_set", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name of the zone in which this record set will reside.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedZone is required")]
    [TerraformPropertyName("managed_zone")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ManagedZone { get; set; }

    /// <summary>
    /// The DNS name this record set will apply to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// The string data for the records in this record set whose meaning depends on the DNS type. For TXT record, if the string data contains spaces, add surrounding \&amp;quot; if you don&#39;t want your string to get split on spaces. To specify a single record value longer than 255 characters such as a TXT record for DKIM, add \&amp;quot;\&amp;quot; inside the Terraform configuration string (e.g. &amp;quot;first255characters\&amp;quot;\&amp;quot;morecharacters&amp;quot;).
    /// </summary>
    [TerraformPropertyName("rrdatas")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? Rrdatas { get; set; }

    /// <summary>
    /// The time-to-live of this record set (seconds).
    /// </summary>
    [TerraformPropertyName("ttl")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Ttl { get; set; }

    /// <summary>
    /// The DNS record set type.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

    /// <summary>
    /// Block for routing_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RoutingPolicy block(s) allowed")]
    [TerraformPropertyName("routing_policy")]
    public TerraformList<TerraformBlock<GoogleDnsRecordSetRoutingPolicyBlock>>? RoutingPolicy { get; set; } = new();

}
