using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for peering_config in GoogleApigeeDnsZone.
/// Nesting mode: list
/// </summary>
public class GoogleApigeeDnsZonePeeringConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "peering_config";

    /// <summary>
    /// The name of the producer VPC network.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetNetworkId is required")]
    public required TerraformValue<string> TargetNetworkId
    {
        get => GetRequiredArgument<TerraformValue<string>>("target_network_id");
        set => SetArgument("target_network_id", value);
    }

    /// <summary>
    /// The ID of the project that contains the producer VPC network.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetProjectId is required")]
    public required TerraformValue<string> TargetProjectId
    {
        get => GetRequiredArgument<TerraformValue<string>>("target_project_id");
        set => SetArgument("target_project_id", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleApigeeDnsZone.
/// Nesting mode: single
/// </summary>
public class GoogleApigeeDnsZoneTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

}


/// <summary>
/// Represents a google_apigee_dns_zone Terraform resource.
/// Manages a google_apigee_dns_zone resource.
/// </summary>
public partial class GoogleApigeeDnsZone(string name) : TerraformResource("google_apigee_dns_zone", name)
{
    /// <summary>
    /// Description for the zone.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Description is required")]
    public required TerraformValue<string> Description
    {
        get => GetRequiredArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// ID of the dns zone.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DnsZoneId is required")]
    public required TerraformValue<string> DnsZoneId
    {
        get => GetRequiredArgument<TerraformValue<string>>("dns_zone_id");
        set => SetArgument("dns_zone_id", value);
    }

    /// <summary>
    /// Doamin for the zone.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Domain is required")]
    public required TerraformValue<string> Domain
    {
        get => GetRequiredArgument<TerraformValue<string>>("domain");
        set => SetArgument("domain", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The Apigee Organization associated with the Apigee instance,
    /// in the format &#39;organizations/{{org_name}}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrgId is required")]
    public required TerraformValue<string> OrgId
    {
        get => GetRequiredArgument<TerraformValue<string>>("org_id");
        set => SetArgument("org_id", value);
    }

    /// <summary>
    /// Name of the Dns Zone in the following format:
    /// organizations/{organization}/dnsZones/{dnsZone}.
    /// </summary>
    public TerraformValue<string> Name
        => CreateReference("name");

    /// <summary>
    /// PeeringConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeeringConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PeeringConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PeeringConfig block(s) allowed")]
    public required TerraformList<GoogleApigeeDnsZonePeeringConfigBlock> PeeringConfig
    {
        get => GetRequiredArgument<TerraformList<GoogleApigeeDnsZonePeeringConfigBlock>>("peering_config");
        set => SetArgument("peering_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleApigeeDnsZoneTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleApigeeDnsZoneTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
