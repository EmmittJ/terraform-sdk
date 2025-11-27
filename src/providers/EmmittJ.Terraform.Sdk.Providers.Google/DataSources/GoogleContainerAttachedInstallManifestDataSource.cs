using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_container_attached_install_manifest Terraform data source.
/// Retrieves information about a google_container_attached_install_manifest.
/// </summary>
public partial class GoogleContainerAttachedInstallManifestDataSource(string name) : TerraformDataSource("google_container_attached_install_manifest", name)
{
    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterId is required")]
    public required TerraformValue<string> ClusterId
    {
        get => new TerraformReference<string>(this, "cluster_id");
        set => SetArgument("cluster_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The platform_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PlatformVersion is required")]
    public required TerraformValue<string> PlatformVersion
    {
        get => new TerraformReference<string>(this, "platform_version");
        set => SetArgument("platform_version", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Project is required")]
    public required TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The manifest attribute.
    /// </summary>
    public TerraformValue<string> Manifest
    {
        get => new TerraformReference<string>(this, "manifest");
    }

}
