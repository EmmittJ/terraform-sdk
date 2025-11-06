using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_container_attached_install_manifest.
/// </summary>
public class GoogleContainerAttachedInstallManifestDataSource : TerraformDataSource
{
    public GoogleContainerAttachedInstallManifestDataSource(string name) : base("google_container_attached_install_manifest", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("manifest");
    }

    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    public string? ClusterId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cluster_id")?.Value;
        set => this.WithProperty("cluster_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The platform_version attribute.
    /// </summary>
    public string? PlatformVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("platform_version")?.Value;
        set => this.WithProperty("platform_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The manifest attribute.
    /// </summary>
    public TerraformExpression Manifest => this["manifest"];

}
