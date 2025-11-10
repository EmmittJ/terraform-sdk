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
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
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
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The default network tier to be configured for the project. This field can take the following values: PREMIUM or STANDARD.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkTier is required")]
    public required TerraformProperty<string> NetworkTier
    {
        get => GetRequiredProperty<TerraformProperty<string>>("network_tier");
        set => this.WithProperty("network_tier", value);
    }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleComputeProjectDefaultNetworkTierTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleComputeProjectDefaultNetworkTierTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
