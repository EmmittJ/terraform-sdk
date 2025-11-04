using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_container_engine_versions.
/// </summary>
public class GoogleContainerEngineVersionsDataSource : TerraformDataSource
{
    public GoogleContainerEngineVersionsDataSource(string name) : base("google_container_engine_versions", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("default_cluster_version");
        this.DeclareOutput("latest_master_version");
        this.DeclareOutput("latest_node_version");
        this.DeclareOutput("release_channel_default_version");
        this.DeclareOutput("release_channel_latest_version");
        this.DeclareOutput("release_channel_upgrade_target_version");
        this.DeclareOutput("valid_master_versions");
        this.DeclareOutput("valid_node_versions");
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
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The version_prefix attribute.
    /// </summary>
    public string? VersionPrefix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("version_prefix")?.Value;
        set => this.WithProperty("version_prefix", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The default_cluster_version attribute.
    /// </summary>
    public TerraformExpression DefaultClusterVersion => this["default_cluster_version"];

    /// <summary>
    /// The latest_master_version attribute.
    /// </summary>
    public TerraformExpression LatestMasterVersion => this["latest_master_version"];

    /// <summary>
    /// The latest_node_version attribute.
    /// </summary>
    public TerraformExpression LatestNodeVersion => this["latest_node_version"];

    /// <summary>
    /// The release_channel_default_version attribute.
    /// </summary>
    public TerraformExpression ReleaseChannelDefaultVersion => this["release_channel_default_version"];

    /// <summary>
    /// The release_channel_latest_version attribute.
    /// </summary>
    public TerraformExpression ReleaseChannelLatestVersion => this["release_channel_latest_version"];

    /// <summary>
    /// The release_channel_upgrade_target_version attribute.
    /// </summary>
    public TerraformExpression ReleaseChannelUpgradeTargetVersion => this["release_channel_upgrade_target_version"];

    /// <summary>
    /// The valid_master_versions attribute.
    /// </summary>
    public TerraformExpression ValidMasterVersions => this["valid_master_versions"];

    /// <summary>
    /// The valid_node_versions attribute.
    /// </summary>
    public TerraformExpression ValidNodeVersions => this["valid_node_versions"];

}
