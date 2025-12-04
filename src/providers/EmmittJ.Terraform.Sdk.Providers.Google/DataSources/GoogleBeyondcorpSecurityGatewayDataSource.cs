using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_beyondcorp_security_gateway Terraform data source.
/// Retrieves information about a google_beyondcorp_security_gateway.
/// </summary>
public partial class GoogleBeyondcorpSecurityGatewayDataSource(string name) : TerraformDataSource("google_beyondcorp_security_gateway", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Optional. User-settable SecurityGateway resource ID.
    /// * Must start with a letter.
    /// * Must contain between 4-63 characters from &#39;/a-z-/&#39;.
    /// * Must end with a number or letter.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGatewayId is required")]
    public required TerraformValue<string> SecurityGatewayId
    {
        get => GetArgument<TerraformValue<string>>("security_gateway_id");
        set => SetArgument("security_gateway_id", value);
    }

    /// <summary>
    /// Output only. Timestamp when the resource was created.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// Service account used for operations that involve resources in consumer projects.
    /// </summary>
    public TerraformValue<string> DelegatingServiceAccount
        => AsReference("delegating_service_account");

    /// <summary>
    /// Optional. An arbitrary user-provided name for the SecurityGateway.
    /// Cannot exceed 64 characters.
    /// </summary>
    public TerraformValue<string> DisplayName
        => AsReference("display_name");

    /// <summary>
    /// Output only. IP addresses that will be used for establishing
    /// connection to the endpoints.
    /// </summary>
    public TerraformList<string> ExternalIps
        => AsReference("external_ips");

    /// <summary>
    /// Optional. Map of Hubs that represents regional data path deployment with GCP region
    /// as a key.
    /// </summary>
    public TerraformSet<TerraformMap<object>> Hubs
        => AsReference("hubs");

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122. Must be omitted or set to &#39;global&#39;.
    /// </summary>
    public TerraformValue<string> Location
        => AsReference("location");

    /// <summary>
    /// Identifier. Name of the resource.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// Shared proxy configuration for all apps.
    /// </summary>
    public TerraformList<TerraformMap<object>> ProxyProtocolConfig
        => AsReference("proxy_protocol_config");

    /// <summary>
    /// Settings related to the Service Discovery.
    /// </summary>
    public TerraformList<TerraformMap<object>> ServiceDiscovery
        => AsReference("service_discovery");

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
    public TerraformValue<string> State
        => AsReference("state");

    /// <summary>
    /// Output only. Timestamp when the resource was last modified.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

}
