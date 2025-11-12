using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for routing_policy in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDnsRecordSetRoutingPolicyBlock() : TerraformBlock("routing_policy")
{
    /// <summary>
    /// Specifies whether to enable fencing for geo queries.
    /// </summary>
    [TerraformProperty("enable_geo_fencing")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableGeoFencing { get; set; }

    /// <summary>
    /// Specifies the health check.
    /// </summary>
    [TerraformProperty("health_check")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? HealthCheck { get; set; }

}

/// <summary>
/// Manages a google_dns_record_set resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleDnsRecordSet : TerraformResource
{
    public GoogleDnsRecordSet(string name) : base("google_dns_record_set", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name of the zone in which this record set will reside.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedZone is required")]
    [TerraformProperty("managed_zone")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ManagedZone { get; set; }

    /// <summary>
    /// The DNS name this record set will apply to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The string data for the records in this record set whose meaning depends on the DNS type. For TXT record, if the string data contains spaces, add surrounding \&amp;quot; if you don&#39;t want your string to get split on spaces. To specify a single record value longer than 255 characters such as a TXT record for DKIM, add \&amp;quot;\&amp;quot; inside the Terraform configuration string (e.g. &amp;quot;first255characters\&amp;quot;\&amp;quot;morecharacters&amp;quot;).
    /// </summary>
    [TerraformProperty("rrdatas")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? Rrdatas { get; set; }

    /// <summary>
    /// The time-to-live of this record set (seconds).
    /// </summary>
    [TerraformProperty("ttl")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Ttl { get; set; }

    /// <summary>
    /// The DNS record set type.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

    /// <summary>
    /// Block for routing_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RoutingPolicy block(s) allowed")]
    [TerraformProperty("routing_policy")]
    public TerraformList<GoogleDnsRecordSetRoutingPolicyBlock> RoutingPolicy { get; set; } = new();

}
