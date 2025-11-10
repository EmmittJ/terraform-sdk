using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for peering_config in .
/// Nesting mode: list
/// </summary>
public class GoogleApigeeDnsZonePeeringConfigBlock : TerraformBlock
{
    /// <summary>
    /// The name of the producer VPC network.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetNetworkId is required")]
    public required TerraformProperty<string> TargetNetworkId
    {
        set => SetProperty("target_network_id", value);
    }

    /// <summary>
    /// The ID of the project that contains the producer VPC network.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetProjectId is required")]
    public required TerraformProperty<string> TargetProjectId
    {
        set => SetProperty("target_project_id", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleApigeeDnsZoneTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

}

/// <summary>
/// Manages a google_apigee_dns_zone resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleApigeeDnsZone : TerraformResource
{
    public GoogleApigeeDnsZone(string name) : base("google_apigee_dns_zone", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("name");
        SetOutput("description");
        SetOutput("dns_zone_id");
        SetOutput("domain");
        SetOutput("id");
        SetOutput("org_id");
    }

    /// <summary>
    /// Description for the zone.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Description is required")]
    public required TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// ID of the dns zone.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DnsZoneId is required")]
    public required TerraformProperty<string> DnsZoneId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("dns_zone_id");
        set => SetProperty("dns_zone_id", value);
    }

    /// <summary>
    /// Doamin for the zone.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Domain is required")]
    public required TerraformProperty<string> Domain
    {
        get => GetRequiredOutput<TerraformProperty<string>>("domain");
        set => SetProperty("domain", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The Apigee Organization associated with the Apigee instance,
    /// in the format &#39;organizations/{{org_name}}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrgId is required")]
    public required TerraformProperty<string> OrgId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("org_id");
        set => SetProperty("org_id", value);
    }

    /// <summary>
    /// Block for peering_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeeringConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PeeringConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PeeringConfig block(s) allowed")]
    public List<GoogleApigeeDnsZonePeeringConfigBlock>? PeeringConfig
    {
        set => SetProperty("peering_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleApigeeDnsZoneTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Name of the Dns Zone in the following format:
    /// organizations/{organization}/dnsZones/{dnsZone}.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
