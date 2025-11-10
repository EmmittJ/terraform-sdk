using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for routing_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleDnsRecordSetRoutingPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Specifies whether to enable fencing for geo queries.
    /// </summary>
    public TerraformProperty<bool>? EnableGeoFencing
    {
        get => GetProperty<TerraformProperty<bool>>("enable_geo_fencing");
        set => WithProperty("enable_geo_fencing", value);
    }

    /// <summary>
    /// Specifies the health check.
    /// </summary>
    public TerraformProperty<string>? HealthCheck
    {
        get => GetProperty<TerraformProperty<string>>("health_check");
        set => WithProperty("health_check", value);
    }

}

/// <summary>
/// Manages a google_dns_record_set resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleDnsRecordSet : TerraformResource
{
    public GoogleDnsRecordSet(string name) : base("google_dns_record_set", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name of the zone in which this record set will reside.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedZone is required")]
    public required TerraformProperty<string> ManagedZone
    {
        get => GetRequiredProperty<TerraformProperty<string>>("managed_zone");
        set => this.WithProperty("managed_zone", value);
    }

    /// <summary>
    /// The DNS name this record set will apply to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The string data for the records in this record set whose meaning depends on the DNS type. For TXT record, if the string data contains spaces, add surrounding \&amp;quot; if you don&#39;t want your string to get split on spaces. To specify a single record value longer than 255 characters such as a TXT record for DKIM, add \&amp;quot;\&amp;quot; inside the Terraform configuration string (e.g. &amp;quot;first255characters\&amp;quot;\&amp;quot;morecharacters&amp;quot;).
    /// </summary>
    public List<TerraformProperty<string>>? Rrdatas
    {
        get => GetProperty<List<TerraformProperty<string>>>("rrdatas");
        set => this.WithProperty("rrdatas", value);
    }

    /// <summary>
    /// The time-to-live of this record set (seconds).
    /// </summary>
    public TerraformProperty<double>? Ttl
    {
        get => GetProperty<TerraformProperty<double>>("ttl");
        set => this.WithProperty("ttl", value);
    }

    /// <summary>
    /// The DNS record set type.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetRequiredProperty<TerraformProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// Block for routing_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RoutingPolicy block(s) allowed")]
    public List<GoogleDnsRecordSetRoutingPolicyBlock>? RoutingPolicy
    {
        get => GetProperty<List<GoogleDnsRecordSetRoutingPolicyBlock>>("routing_policy");
        set => this.WithProperty("routing_policy", value);
    }

}
