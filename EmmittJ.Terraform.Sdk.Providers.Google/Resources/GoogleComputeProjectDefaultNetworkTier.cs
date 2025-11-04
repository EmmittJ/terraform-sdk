using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

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
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The default network tier to be configured for the project. This field can take the following values: PREMIUM or STANDARD.
    /// </summary>
    public string? NetworkTier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("network_tier")?.Value;
        set => this.WithProperty("network_tier", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
