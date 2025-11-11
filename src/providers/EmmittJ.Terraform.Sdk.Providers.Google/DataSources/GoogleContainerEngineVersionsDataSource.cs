using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_container_engine_versions.
/// </summary>
public class GoogleContainerEngineVersionsDataSource : TerraformDataSource
{
    public GoogleContainerEngineVersionsDataSource(string name) : base("google_container_engine_versions", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// The version_prefix attribute.
    /// </summary>
    [TerraformPropertyName("version_prefix")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? VersionPrefix { get; set; }

    /// <summary>
    /// The default_cluster_version attribute.
    /// </summary>
    [TerraformPropertyName("default_cluster_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DefaultClusterVersion => new TerraformReference(this, "default_cluster_version");

    /// <summary>
    /// The latest_master_version attribute.
    /// </summary>
    [TerraformPropertyName("latest_master_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LatestMasterVersion => new TerraformReference(this, "latest_master_version");

    /// <summary>
    /// The latest_node_version attribute.
    /// </summary>
    [TerraformPropertyName("latest_node_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LatestNodeVersion => new TerraformReference(this, "latest_node_version");

    /// <summary>
    /// The release_channel_default_version attribute.
    /// </summary>
    [TerraformPropertyName("release_channel_default_version")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> ReleaseChannelDefaultVersion => new TerraformReference(this, "release_channel_default_version");

    /// <summary>
    /// The release_channel_latest_version attribute.
    /// </summary>
    [TerraformPropertyName("release_channel_latest_version")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> ReleaseChannelLatestVersion => new TerraformReference(this, "release_channel_latest_version");

    /// <summary>
    /// The release_channel_upgrade_target_version attribute.
    /// </summary>
    [TerraformPropertyName("release_channel_upgrade_target_version")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> ReleaseChannelUpgradeTargetVersion => new TerraformReference(this, "release_channel_upgrade_target_version");

    /// <summary>
    /// The valid_master_versions attribute.
    /// </summary>
    [TerraformPropertyName("valid_master_versions")]
    // Output-only attribute - read-only reference
    public TerraformList<string> ValidMasterVersions => new TerraformReference(this, "valid_master_versions");

    /// <summary>
    /// The valid_node_versions attribute.
    /// </summary>
    [TerraformPropertyName("valid_node_versions")]
    // Output-only attribute - read-only reference
    public TerraformList<string> ValidNodeVersions => new TerraformReference(this, "valid_node_versions");

}
