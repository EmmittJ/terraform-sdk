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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Project { get; set; }

    /// <summary>
    /// The version_prefix attribute.
    /// </summary>
    [TerraformPropertyName("version_prefix")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? VersionPrefix { get; set; }

    /// <summary>
    /// The default_cluster_version attribute.
    /// </summary>
    [TerraformPropertyName("default_cluster_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DefaultClusterVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "default_cluster_version");

    /// <summary>
    /// The latest_master_version attribute.
    /// </summary>
    [TerraformPropertyName("latest_master_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LatestMasterVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "latest_master_version");

    /// <summary>
    /// The latest_node_version attribute.
    /// </summary>
    [TerraformPropertyName("latest_node_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LatestNodeVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "latest_node_version");

    /// <summary>
    /// The release_channel_default_version attribute.
    /// </summary>
    [TerraformPropertyName("release_channel_default_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> ReleaseChannelDefaultVersion => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "release_channel_default_version");

    /// <summary>
    /// The release_channel_latest_version attribute.
    /// </summary>
    [TerraformPropertyName("release_channel_latest_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> ReleaseChannelLatestVersion => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "release_channel_latest_version");

    /// <summary>
    /// The release_channel_upgrade_target_version attribute.
    /// </summary>
    [TerraformPropertyName("release_channel_upgrade_target_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> ReleaseChannelUpgradeTargetVersion => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "release_channel_upgrade_target_version");

    /// <summary>
    /// The valid_master_versions attribute.
    /// </summary>
    [TerraformPropertyName("valid_master_versions")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> ValidMasterVersions => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "valid_master_versions");

    /// <summary>
    /// The valid_node_versions attribute.
    /// </summary>
    [TerraformPropertyName("valid_node_versions")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> ValidNodeVersions => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "valid_node_versions");

}
