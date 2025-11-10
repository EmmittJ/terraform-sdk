using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for network_settings in .
/// Nesting mode: list
/// </summary>
public class GoogleAppEngineServiceNetworkSettingsNetworkSettingsBlock : TerraformBlock
{
    /// <summary>
    /// The ingress settings for version or service. Default value: &amp;quot;INGRESS_TRAFFIC_ALLOWED_UNSPECIFIED&amp;quot; Possible values: [&amp;quot;INGRESS_TRAFFIC_ALLOWED_UNSPECIFIED&amp;quot;, &amp;quot;INGRESS_TRAFFIC_ALLOWED_ALL&amp;quot;, &amp;quot;INGRESS_TRAFFIC_ALLOWED_INTERNAL_ONLY&amp;quot;, &amp;quot;INGRESS_TRAFFIC_ALLOWED_INTERNAL_AND_LB&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? IngressTrafficAllowed
    {
        set => SetProperty("ingress_traffic_allowed", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleAppEngineServiceNetworkSettingsTimeoutsBlock : TerraformBlock
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
/// Manages a google_app_engine_service_network_settings resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleAppEngineServiceNetworkSettings : TerraformResource
{
    public GoogleAppEngineServiceNetworkSettings(string name) : base("google_app_engine_service_network_settings", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("id");
        SetOutput("project");
        SetOutput("service");
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
    /// The name of the service these settings apply to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    public required TerraformProperty<string> Service
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service");
        set => SetProperty("service", value);
    }

    /// <summary>
    /// Block for network_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkSettings is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 NetworkSettings block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkSettings block(s) allowed")]
    public List<GoogleAppEngineServiceNetworkSettingsNetworkSettingsBlock>? NetworkSettings
    {
        set => SetProperty("network_settings", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleAppEngineServiceNetworkSettingsTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
