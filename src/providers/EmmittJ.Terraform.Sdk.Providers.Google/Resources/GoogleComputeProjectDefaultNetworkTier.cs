using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeProjectDefaultNetworkTierTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

}

/// <summary>
/// Manages a google_compute_project_default_network_tier resource.
/// </summary>
public class GoogleComputeProjectDefaultNetworkTier : TerraformResource
{
    public GoogleComputeProjectDefaultNetworkTier(string name) : base("google_compute_project_default_network_tier", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("id");
        SetOutput("network_tier");
        SetOutput("project");
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
    /// The default network tier to be configured for the project. This field can take the following values: PREMIUM or STANDARD.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkTier is required")]
    public required TerraformProperty<string> NetworkTier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("network_tier");
        set => SetProperty("network_tier", value);
    }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleComputeProjectDefaultNetworkTierTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
