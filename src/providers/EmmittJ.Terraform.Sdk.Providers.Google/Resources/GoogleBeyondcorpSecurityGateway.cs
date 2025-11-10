using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for hubs in .
/// Nesting mode: set
/// </summary>
public class GoogleBeyondcorpSecurityGatewayHubsBlock : TerraformBlock
{
    /// <summary>
    /// The region attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Region is required")]
    public required TerraformProperty<string> Region
    {
        set => SetProperty("region", value);
    }

}

/// <summary>
/// Block type for proxy_protocol_config in .
/// Nesting mode: list
/// </summary>
public class GoogleBeyondcorpSecurityGatewayProxyProtocolConfigBlock : TerraformBlock
{
    /// <summary>
    /// The configuration for the proxy.
    /// </summary>
    public List<TerraformProperty<string>>? AllowedClientHeaders
    {
        set => SetProperty("allowed_client_headers", value);
    }

    /// <summary>
    /// Client IP configuration. The client IP address is included if true.
    /// </summary>
    public TerraformProperty<bool>? ClientIp
    {
        set => SetProperty("client_ip", value);
    }

    /// <summary>
    /// Gateway identity configuration. Possible values: [&amp;quot;RESOURCE_NAME&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? GatewayIdentity
    {
        set => SetProperty("gateway_identity", value);
    }

    /// <summary>
    /// Custom resource specific headers along with the values.
    /// The names should conform to RFC 9110:
    /// &amp;gt; Field names SHOULD constrain themselves to alphanumeric characters, &amp;quot;-&amp;quot;,
    ///   and &amp;quot;.&amp;quot;, and SHOULD begin with a letter.
    /// &amp;gt; Field values SHOULD contain only ASCII printable characters and tab.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? MetadataHeaders
    {
        set => SetProperty("metadata_headers", value);
    }

}

/// <summary>
/// Block type for service_discovery in .
/// Nesting mode: list
/// </summary>
public class GoogleBeyondcorpSecurityGatewayServiceDiscoveryBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleBeyondcorpSecurityGatewayTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a google_beyondcorp_security_gateway resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleBeyondcorpSecurityGateway : TerraformResource
{
    public GoogleBeyondcorpSecurityGateway(string name) : base("google_beyondcorp_security_gateway", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("create_time");
        SetOutput("delegating_service_account");
        SetOutput("external_ips");
        SetOutput("name");
        SetOutput("state");
        SetOutput("update_time");
        SetOutput("display_name");
        SetOutput("id");
        SetOutput("location");
        SetOutput("project");
        SetOutput("security_gateway_id");
    }

    /// <summary>
    /// Optional. An arbitrary user-provided name for the SecurityGateway.
    /// Cannot exceed 64 characters.
    /// </summary>
    public TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
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
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122. Must be omitted or set to &#39;global&#39;.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// Optional. User-settable SecurityGateway resource ID.
    /// * Must start with a letter.
    /// * Must contain between 4-63 characters from &#39;/a-z-/&#39;.
    /// * Must end with a number or letter.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGatewayId is required")]
    public required TerraformProperty<string> SecurityGatewayId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("security_gateway_id");
        set => SetProperty("security_gateway_id", value);
    }

    /// <summary>
    /// Block for hubs.
    /// Nesting mode: set
    /// </summary>
    public HashSet<GoogleBeyondcorpSecurityGatewayHubsBlock>? Hubs
    {
        set => SetProperty("hubs", value);
    }

    /// <summary>
    /// Block for proxy_protocol_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ProxyProtocolConfig block(s) allowed")]
    public List<GoogleBeyondcorpSecurityGatewayProxyProtocolConfigBlock>? ProxyProtocolConfig
    {
        set => SetProperty("proxy_protocol_config", value);
    }

    /// <summary>
    /// Block for service_discovery.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceDiscovery block(s) allowed")]
    public List<GoogleBeyondcorpSecurityGatewayServiceDiscoveryBlock>? ServiceDiscovery
    {
        set => SetProperty("service_discovery", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleBeyondcorpSecurityGatewayTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Output only. Timestamp when the resource was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// Service account used for operations that involve resources in consumer projects.
    /// </summary>
    public TerraformExpression DelegatingServiceAccount => this["delegating_service_account"];

    /// <summary>
    /// Output only. IP addresses that will be used for establishing
    /// connection to the endpoints.
    /// </summary>
    public TerraformExpression ExternalIps => this["external_ips"];

    /// <summary>
    /// Identifier. Name of the resource.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// Output only. The operational state of the SecurityGateway.
    /// Possible values:
    /// STATE_UNSPECIFIED
    /// CREATING
    /// UPDATING
    /// DELETING
    /// RUNNING
    /// DOWN
    /// ERROR
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// Output only. Timestamp when the resource was last modified.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
