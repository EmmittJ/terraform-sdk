using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_compute_preview_feature resource.
/// </summary>
public class GoogleComputePreviewFeature : TerraformResource
{
    public GoogleComputePreviewFeature(string name) : base("google_compute_preview_feature", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The activation status of the preview feature. Possible values: [&amp;quot;ENABLED&amp;quot;, &amp;quot;ACTIVATION_STATE_UNSPECIFIED&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? ActivationStatus
    {
        get => GetProperty<TerraformProperty<string>>("activation_status");
        set => this.WithProperty("activation_status", value);
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
    /// The name of the preview feature.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

}
