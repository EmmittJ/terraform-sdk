using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_compute_project_cloud_armor_tier resource.
/// </summary>
public class GoogleComputeProjectCloudArmorTier : TerraformResource
{
    public GoogleComputeProjectCloudArmorTier(string name) : base("google_compute_project_cloud_armor_tier", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// Managed protection tier to be set. Possible values: [&amp;quot;CA_STANDARD&amp;quot;, &amp;quot;CA_ENTERPRISE_PAYGO&amp;quot;, &amp;quot;CA_ENTERPRISE_ANNUAL&amp;quot;]
    /// </summary>
    public string? CloudArmorTier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cloud_armor_tier")?.Value;
        set => this.WithProperty("cloud_armor_tier", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
