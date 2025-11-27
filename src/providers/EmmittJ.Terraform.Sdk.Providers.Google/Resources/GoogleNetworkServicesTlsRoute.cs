using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for rules in GoogleNetworkServicesTlsRoute.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesTlsRouteRulesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rules";

    /// <summary>
    /// Action block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Action block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Action block(s) allowed")]
    public required TerraformList<GoogleNetworkServicesTlsRouteRulesBlockActionBlock> Action
    {
        get => GetRequiredArgument<TerraformList<GoogleNetworkServicesTlsRouteRulesBlockActionBlock>>("action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// Matches block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Matches is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Matches block(s) required")]
    public required TerraformList<GoogleNetworkServicesTlsRouteRulesBlockMatchesBlock> Matches
    {
        get => GetRequiredArgument<TerraformList<GoogleNetworkServicesTlsRouteRulesBlockMatchesBlock>>("matches");
        set => SetArgument("matches", value);
    }

}

/// <summary>
/// Block type for action in GoogleNetworkServicesTlsRouteRulesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesTlsRouteRulesBlockActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "action";

    /// <summary>
    /// Destinations block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleNetworkServicesTlsRouteRulesBlockActionBlockDestinationsBlock>? Destinations
    {
        get => GetArgument<TerraformList<GoogleNetworkServicesTlsRouteRulesBlockActionBlockDestinationsBlock>>("destinations");
        set => SetArgument("destinations", value);
    }

}

/// <summary>
/// Block type for destinations in GoogleNetworkServicesTlsRouteRulesBlockActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesTlsRouteRulesBlockActionBlockDestinationsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "destinations";

    /// <summary>
    /// The URL of a BackendService to route traffic to.
    /// </summary>
    public TerraformValue<string>? ServiceName
    {
        get => new TerraformReference<string>(this, "service_name");
        set => SetArgument("service_name", value);
    }

    /// <summary>
    /// Specifies the proportion of requests forwarded to the backend referenced by the serviceName field.
    /// </summary>
    public TerraformValue<double>? Weight
    {
        get => new TerraformReference<double>(this, "weight");
        set => SetArgument("weight", value);
    }

}

/// <summary>
/// Block type for matches in GoogleNetworkServicesTlsRouteRulesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesTlsRouteRulesBlockMatchesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "matches";

    /// <summary>
    /// ALPN (Application-Layer Protocol Negotiation) to match against. Examples: &amp;quot;http/1.1&amp;quot;, &amp;quot;h2&amp;quot;. At least one of sniHost and alpn is required. Up to 5 alpns across all matches can be set.
    /// </summary>
    public TerraformList<string>? Alpn
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "alpn").ResolveNodes(ctx));
        set => SetArgument("alpn", value);
    }

    /// <summary>
    /// SNI (server name indicator) to match against. SNI will be matched against all wildcard domains, i.e. www.example.com will be first matched against www.example.com, then *.example.com, then *.com.
    /// Partial wildcards are not supported, and values like *w.example.com are invalid. At least one of sniHost and alpn is required. Up to 5 sni hosts across all matches can be set.
    /// </summary>
    public TerraformList<string>? SniHost
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "sni_host").ResolveNodes(ctx));
        set => SetArgument("sni_host", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleNetworkServicesTlsRoute.
/// Nesting mode: single
/// </summary>
public class GoogleNetworkServicesTlsRouteTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_network_services_tls_route Terraform resource.
/// Manages a google_network_services_tls_route resource.
/// </summary>
public partial class GoogleNetworkServicesTlsRoute(string name) : TerraformResource("google_network_services_tls_route", name)
{
    /// <summary>
    /// A free-text description of the resource. Max length 1024 characters.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// Gateways defines a list of gateways this TlsRoute is attached to, as one of the routing rules to route the requests served by the gateway.
    /// Each gateway reference should match the pattern: projects/*/locations/global/gateways/&amp;lt;gateway_name&amp;gt;
    /// </summary>
    public TerraformList<string>? Gateways
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "gateways").ResolveNodes(ctx));
        set => SetArgument("gateways", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Meshes defines a list of meshes this TlsRoute is attached to, as one of the routing rules to route the requests served by the mesh.
    /// Each mesh reference should match the pattern: projects/*/locations/global/meshes/&amp;lt;mesh_name&amp;gt;
    /// The attached Mesh should be of a type SIDECAR
    /// </summary>
    public TerraformList<string>? Meshes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "meshes").ResolveNodes(ctx));
        set => SetArgument("meshes", value);
    }

    /// <summary>
    /// Name of the TlsRoute resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Time the TlsRoute was created in UTC.
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// Server-defined URL of this resource.
    /// </summary>
    public TerraformValue<string> SelfLink
    {
        get => new TerraformReference<string>(this, "self_link");
    }

    /// <summary>
    /// Time the TlsRoute was updated in UTC.
    /// </summary>
    public TerraformValue<string> UpdateTime
    {
        get => new TerraformReference<string>(this, "update_time");
    }

    /// <summary>
    /// Rules block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rules is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Rules block(s) required")]
    public required TerraformList<GoogleNetworkServicesTlsRouteRulesBlock> Rules
    {
        get => GetRequiredArgument<TerraformList<GoogleNetworkServicesTlsRouteRulesBlock>>("rules");
        set => SetArgument("rules", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleNetworkServicesTlsRouteTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleNetworkServicesTlsRouteTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
