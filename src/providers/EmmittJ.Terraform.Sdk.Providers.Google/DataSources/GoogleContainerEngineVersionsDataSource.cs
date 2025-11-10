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
        SetOutput("default_cluster_version");
        SetOutput("latest_master_version");
        SetOutput("latest_node_version");
        SetOutput("release_channel_default_version");
        SetOutput("release_channel_latest_version");
        SetOutput("release_channel_upgrade_target_version");
        SetOutput("valid_master_versions");
        SetOutput("valid_node_versions");
        SetOutput("id");
        SetOutput("location");
        SetOutput("project");
        SetOutput("version_prefix");
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
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// The version_prefix attribute.
    /// </summary>
    public TerraformProperty<string> VersionPrefix
    {
        get => GetRequiredOutput<TerraformProperty<string>>("version_prefix");
        set => SetProperty("version_prefix", value);
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
