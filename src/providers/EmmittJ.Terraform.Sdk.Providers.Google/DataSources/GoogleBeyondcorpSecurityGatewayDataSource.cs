using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_beyondcorp_security_gateway.
/// </summary>
public class GoogleBeyondcorpSecurityGatewayDataSource : TerraformDataSource
{
    public GoogleBeyondcorpSecurityGatewayDataSource(string name) : base("google_beyondcorp_security_gateway", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("create_time");
        SetOutput("delegating_service_account");
        SetOutput("display_name");
        SetOutput("external_ips");
        SetOutput("hubs");
        SetOutput("location");
        SetOutput("name");
        SetOutput("proxy_protocol_config");
        SetOutput("service_discovery");
        SetOutput("state");
        SetOutput("update_time");
        SetOutput("id");
        SetOutput("project");
        SetOutput("security_gateway_id");
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
    /// Output only. Timestamp when the resource was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// Service account used for operations that involve resources in consumer projects.
    /// </summary>
    public TerraformExpression DelegatingServiceAccount => this["delegating_service_account"];

    /// <summary>
    /// Optional. An arbitrary user-provided name for the SecurityGateway.
    /// Cannot exceed 64 characters.
    /// </summary>
    public TerraformExpression DisplayName => this["display_name"];

    /// <summary>
    /// Output only. IP addresses that will be used for establishing
    /// connection to the endpoints.
    /// </summary>
    public TerraformExpression ExternalIps => this["external_ips"];

    /// <summary>
    /// Optional. Map of Hubs that represents regional data path deployment with GCP region
    /// as a key.
    /// </summary>
    public TerraformExpression Hubs => this["hubs"];

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122. Must be omitted or set to &#39;global&#39;.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// Identifier. Name of the resource.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// Shared proxy configuration for all apps.
    /// </summary>
    public TerraformExpression ProxyProtocolConfig => this["proxy_protocol_config"];

    /// <summary>
    /// Settings related to the Service Discovery.
    /// </summary>
    public TerraformExpression ServiceDiscovery => this["service_discovery"];

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
