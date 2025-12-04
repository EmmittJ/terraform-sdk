using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_container_engine_versions Terraform data source.
/// Retrieves information about a google_container_engine_versions.
/// </summary>
public partial class GoogleContainerEngineVersionsDataSource(string name) : TerraformDataSource("google_container_engine_versions", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string>? Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The version_prefix attribute.
    /// </summary>
    public TerraformValue<string>? VersionPrefix
    {
        get => GetArgument<TerraformValue<string>>("version_prefix");
        set => SetArgument("version_prefix", value);
    }

    /// <summary>
    /// The default_cluster_version attribute.
    /// </summary>
    public TerraformValue<string> DefaultClusterVersion
        => AsReference("default_cluster_version");

    /// <summary>
    /// The latest_master_version attribute.
    /// </summary>
    public TerraformValue<string> LatestMasterVersion
        => AsReference("latest_master_version");

    /// <summary>
    /// The latest_node_version attribute.
    /// </summary>
    public TerraformValue<string> LatestNodeVersion
        => AsReference("latest_node_version");

    /// <summary>
    /// The release_channel_default_version attribute.
    /// </summary>
    public TerraformMap<string> ReleaseChannelDefaultVersion
        => AsReference("release_channel_default_version");

    /// <summary>
    /// The release_channel_latest_version attribute.
    /// </summary>
    public TerraformMap<string> ReleaseChannelLatestVersion
        => AsReference("release_channel_latest_version");

    /// <summary>
    /// The release_channel_upgrade_target_version attribute.
    /// </summary>
    public TerraformMap<string> ReleaseChannelUpgradeTargetVersion
        => AsReference("release_channel_upgrade_target_version");

    /// <summary>
    /// The valid_master_versions attribute.
    /// </summary>
    public TerraformList<string> ValidMasterVersions
        => AsReference("valid_master_versions");

    /// <summary>
    /// The valid_node_versions attribute.
    /// </summary>
    public TerraformList<string> ValidNodeVersions
        => AsReference("valid_node_versions");

}
