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
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string>? Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The version_prefix attribute.
    /// </summary>
    public TerraformValue<string>? VersionPrefix
    {
        get => new TerraformReference<string>(this, "version_prefix");
        set => SetArgument("version_prefix", value);
    }

    /// <summary>
    /// The default_cluster_version attribute.
    /// </summary>
    public TerraformValue<string> DefaultClusterVersion
    {
        get => new TerraformReference<string>(this, "default_cluster_version");
    }

    /// <summary>
    /// The latest_master_version attribute.
    /// </summary>
    public TerraformValue<string> LatestMasterVersion
    {
        get => new TerraformReference<string>(this, "latest_master_version");
    }

    /// <summary>
    /// The latest_node_version attribute.
    /// </summary>
    public TerraformValue<string> LatestNodeVersion
    {
        get => new TerraformReference<string>(this, "latest_node_version");
    }

    /// <summary>
    /// The release_channel_default_version attribute.
    /// </summary>
    public TerraformMap<string> ReleaseChannelDefaultVersion
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "release_channel_default_version").ResolveNodes(ctx));
    }

    /// <summary>
    /// The release_channel_latest_version attribute.
    /// </summary>
    public TerraformMap<string> ReleaseChannelLatestVersion
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "release_channel_latest_version").ResolveNodes(ctx));
    }

    /// <summary>
    /// The release_channel_upgrade_target_version attribute.
    /// </summary>
    public TerraformMap<string> ReleaseChannelUpgradeTargetVersion
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "release_channel_upgrade_target_version").ResolveNodes(ctx));
    }

    /// <summary>
    /// The valid_master_versions attribute.
    /// </summary>
    public TerraformList<string> ValidMasterVersions
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "valid_master_versions").ResolveNodes(ctx));
    }

    /// <summary>
    /// The valid_node_versions attribute.
    /// </summary>
    public TerraformList<string> ValidNodeVersions
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "valid_node_versions").ResolveNodes(ctx));
    }

}
