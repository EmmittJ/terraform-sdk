using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleServiceNetworkingVpcServiceControlsTimeoutsBlock : TerraformBlock
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
/// Manages a google_service_networking_vpc_service_controls resource.
/// </summary>
public class GoogleServiceNetworkingVpcServiceControls : TerraformResource
{
    public GoogleServiceNetworkingVpcServiceControls(string name) : base("google_service_networking_vpc_service_controls", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("enabled");
        SetOutput("id");
        SetOutput("network");
        SetOutput("project");
        SetOutput("service");
    }

    /// <summary>
    /// Desired VPC Service Controls state service producer VPC network, as
    /// described at the top of this page.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformProperty<bool> Enabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enabled");
        set => SetProperty("enabled", value);
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
    /// The network that the consumer is using to connect with services.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Network is required")]
    public required TerraformProperty<string> Network
    {
        get => GetRequiredOutput<TerraformProperty<string>>("network");
        set => SetProperty("network", value);
    }

    /// <summary>
    /// The id of the Google Cloud project containing the consumer network.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// The service that is managing peering connectivity for a service
    /// producer&#39;s organization. For Google services that support this
    /// functionality, this value is &#39;servicenetworking.googleapis.com&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    public required TerraformProperty<string> Service
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service");
        set => SetProperty("service", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleServiceNetworkingVpcServiceControlsTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
