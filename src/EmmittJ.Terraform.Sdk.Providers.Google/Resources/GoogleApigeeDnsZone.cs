using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_apigee_dns_zone resource.
/// </summary>
public class GoogleApigeeDnsZone : TerraformResource
{
    public GoogleApigeeDnsZone(string name) : base("google_apigee_dns_zone", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("name");
    }

    /// <summary>
    /// Description for the zone.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// ID of the dns zone.
    /// </summary>
    public string? DnsZoneId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("dns_zone_id")?.Value;
        set => this.WithProperty("dns_zone_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Doamin for the zone.
    /// </summary>
    public string? Domain
    {
        get => GetProperty<TerraformLiteralProperty<string>>("domain")?.Value;
        set => this.WithProperty("domain", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The Apigee Organization associated with the Apigee instance,
    /// in the format &#39;organizations/{{org_name}}&#39;.
    /// </summary>
    public string? OrgId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("org_id")?.Value;
        set => this.WithProperty("org_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Name of the Dns Zone in the following format:
    /// organizations/{organization}/dnsZones/{dnsZone}.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
