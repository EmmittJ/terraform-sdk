using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_container_engine_versions.
/// </summary>
public partial class GoogleContainerEngineVersionsDataSource : TerraformDataSource
{
    public GoogleContainerEngineVersionsDataSource(string name) : base("google_container_engine_versions", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// The version_prefix attribute.
    /// </summary>
    [TerraformProperty("version_prefix")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? VersionPrefix { get; set; }

    /// <summary>
    /// The default_cluster_version attribute.
    /// </summary>
    [TerraformProperty("default_cluster_version")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DefaultClusterVersion { get; }

    /// <summary>
    /// The latest_master_version attribute.
    /// </summary>
    [TerraformProperty("latest_master_version")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LatestMasterVersion { get; }

    /// <summary>
    /// The latest_node_version attribute.
    /// </summary>
    [TerraformProperty("latest_node_version")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LatestNodeVersion { get; }

    /// <summary>
    /// The release_channel_default_version attribute.
    /// </summary>
    [TerraformProperty("release_channel_default_version")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> ReleaseChannelDefaultVersion { get; }

    /// <summary>
    /// The release_channel_latest_version attribute.
    /// </summary>
    [TerraformProperty("release_channel_latest_version")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> ReleaseChannelLatestVersion { get; }

    /// <summary>
    /// The release_channel_upgrade_target_version attribute.
    /// </summary>
    [TerraformProperty("release_channel_upgrade_target_version")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> ReleaseChannelUpgradeTargetVersion { get; }

    /// <summary>
    /// The valid_master_versions attribute.
    /// </summary>
    [TerraformProperty("valid_master_versions")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> ValidMasterVersions { get; }

    /// <summary>
    /// The valid_node_versions attribute.
    /// </summary>
    [TerraformProperty("valid_node_versions")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> ValidNodeVersions { get; }

}
