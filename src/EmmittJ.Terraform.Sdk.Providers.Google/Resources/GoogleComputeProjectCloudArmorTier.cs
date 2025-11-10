using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeProjectCloudArmorTierTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CloudArmorTier is required")]
    public required TerraformProperty<string> CloudArmorTier
    {
        get => GetProperty<TerraformProperty<string>>("cloud_armor_tier");
        set => this.WithProperty("cloud_armor_tier", value);
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
    /// The project attribute.
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
    public GoogleComputeProjectCloudArmorTierTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleComputeProjectCloudArmorTierTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
