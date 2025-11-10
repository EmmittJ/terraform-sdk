using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for endpoint_matchers in .
/// Nesting mode: list
/// </summary>
public class GoogleBeyondcorpSecurityGatewayApplicationEndpointMatchersBlock : TerraformBlock
{
    /// <summary>
    /// Required. Hostname of the application.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hostname is required")]
    public required TerraformProperty<string> Hostname
    {
        set => SetProperty("hostname", value);
    }

    /// <summary>
    /// Optional. Ports of the application.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Ports is required")]
    public List<TerraformProperty<double>>? Ports
    {
        set => SetProperty("ports", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleBeyondcorpSecurityGatewayApplicationTimeoutsBlock : TerraformBlock
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
/// Block type for upstreams in .
/// Nesting mode: list
/// </summary>
public class GoogleBeyondcorpSecurityGatewayApplicationUpstreamsBlock : TerraformBlock
{
}

/// <summary>
/// Manages a google_beyondcorp_security_gateway_application resource.
/// </summary>
public class GoogleBeyondcorpSecurityGatewayApplication : TerraformResource
{
    public GoogleBeyondcorpSecurityGatewayApplication(string name) : base("google_beyondcorp_security_gateway_application", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("create_time");
        SetOutput("name");
        SetOutput("update_time");
        SetOutput("application_id");
        SetOutput("display_name");
        SetOutput("id");
        SetOutput("project");
        SetOutput("schema");
        SetOutput("security_gateway_id");
    }

    /// <summary>
    /// User-settable Application resource ID.
    /// * Must start with a letter.
    /// * Must contain between 4-63 characters from &#39;/a-z-/&#39;.
    /// * Must end with a number or letter.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationId is required")]
    public required TerraformProperty<string> ApplicationId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("application_id");
        set => SetProperty("application_id", value);
    }

    /// <summary>
    /// Optional. An arbitrary user-provided name for the Application resource.
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
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// Type of the external application. Possible values: [&amp;quot;PROXY_GATEWAY&amp;quot;, &amp;quot;API_GATEWAY&amp;quot;]
    /// </summary>
    public TerraformProperty<string> Schema
    {
        get => GetRequiredOutput<TerraformProperty<string>>("schema");
        set => SetProperty("schema", value);
    }

    /// <summary>
    /// ID of the Security Gateway resource this belongs to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGatewayId is required")]
    public required TerraformProperty<string> SecurityGatewayId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("security_gateway_id");
        set => SetProperty("security_gateway_id", value);
    }

    /// <summary>
    /// Block for endpoint_matchers.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleBeyondcorpSecurityGatewayApplicationEndpointMatchersBlock>? EndpointMatchers
    {
        set => SetProperty("endpoint_matchers", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleBeyondcorpSecurityGatewayApplicationTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for upstreams.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleBeyondcorpSecurityGatewayApplicationUpstreamsBlock>? Upstreams
    {
        set => SetProperty("upstreams", value);
    }

    /// <summary>
    /// Output only. Timestamp when the resource was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// Identifier. Name of the resource.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// Output only. Timestamp when the resource was last modified.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
