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
    public TerraformLiteralProperty<string>? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// ID of the dns zone.
    /// </summary>
    public TerraformLiteralProperty<string>? DnsZoneId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("dns_zone_id");
        set => this.WithProperty("dns_zone_id", value);
    }

    /// <summary>
    /// Doamin for the zone.
    /// </summary>
    public TerraformLiteralProperty<string>? Domain
    {
        get => GetProperty<TerraformLiteralProperty<string>>("domain");
        set => this.WithProperty("domain", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The Apigee Organization associated with the Apigee instance,
    /// in the format &#39;organizations/{{org_name}}&#39;.
    /// </summary>
    public TerraformLiteralProperty<string>? OrgId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("org_id");
        set => this.WithProperty("org_id", value);
    }

    /// <summary>
    /// Name of the Dns Zone in the following format:
    /// organizations/{organization}/dnsZones/{dnsZone}.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
