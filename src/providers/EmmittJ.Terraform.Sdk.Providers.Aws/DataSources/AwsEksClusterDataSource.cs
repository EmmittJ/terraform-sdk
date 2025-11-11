using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_eks_cluster.
/// </summary>
public class AwsEksClusterDataSource : TerraformDataSource
{
    public AwsEksClusterDataSource(string name) : base("aws_eks_cluster", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Tags { get; set; } = default!;

    /// <summary>
    /// The access_config attribute.
    /// </summary>
    [TerraformPropertyName("access_config")]
    // Output-only attribute - read-only reference
    public TerraformList<object> AccessConfig => new TerraformReference(this, "access_config");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The certificate_authority attribute.
    /// </summary>
    [TerraformPropertyName("certificate_authority")]
    // Output-only attribute - read-only reference
    public TerraformList<object> CertificateAuthority => new TerraformReference(this, "certificate_authority");

    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    [TerraformPropertyName("cluster_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ClusterId => new TerraformReference(this, "cluster_id");

    /// <summary>
    /// The compute_config attribute.
    /// </summary>
    [TerraformPropertyName("compute_config")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ComputeConfig => new TerraformReference(this, "compute_config");

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    [TerraformPropertyName("created_at")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreatedAt => new TerraformReference(this, "created_at");

    /// <summary>
    /// The deletion_protection attribute.
    /// </summary>
    [TerraformPropertyName("deletion_protection")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> DeletionProtection => new TerraformReference(this, "deletion_protection");

    /// <summary>
    /// The enabled_cluster_log_types attribute.
    /// </summary>
    [TerraformPropertyName("enabled_cluster_log_types")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> EnabledClusterLogTypes => new TerraformReference(this, "enabled_cluster_log_types");

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformPropertyName("endpoint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Endpoint => new TerraformReference(this, "endpoint");

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformPropertyName("identity")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Identity => new TerraformReference(this, "identity");

    /// <summary>
    /// The kubernetes_network_config attribute.
    /// </summary>
    [TerraformPropertyName("kubernetes_network_config")]
    // Output-only attribute - read-only reference
    public TerraformList<object> KubernetesNetworkConfig => new TerraformReference(this, "kubernetes_network_config");

    /// <summary>
    /// The outpost_config attribute.
    /// </summary>
    [TerraformPropertyName("outpost_config")]
    // Output-only attribute - read-only reference
    public TerraformList<object> OutpostConfig => new TerraformReference(this, "outpost_config");

    /// <summary>
    /// The platform_version attribute.
    /// </summary>
    [TerraformPropertyName("platform_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PlatformVersion => new TerraformReference(this, "platform_version");

    /// <summary>
    /// The remote_network_config attribute.
    /// </summary>
    [TerraformPropertyName("remote_network_config")]
    // Output-only attribute - read-only reference
    public TerraformList<object> RemoteNetworkConfig => new TerraformReference(this, "remote_network_config");

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [TerraformPropertyName("role_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> RoleArn => new TerraformReference(this, "role_arn");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Status => new TerraformReference(this, "status");

    /// <summary>
    /// The storage_config attribute.
    /// </summary>
    [TerraformPropertyName("storage_config")]
    // Output-only attribute - read-only reference
    public TerraformList<object> StorageConfig => new TerraformReference(this, "storage_config");

    /// <summary>
    /// The upgrade_policy attribute.
    /// </summary>
    [TerraformPropertyName("upgrade_policy")]
    // Output-only attribute - read-only reference
    public TerraformList<object> UpgradePolicy => new TerraformReference(this, "upgrade_policy");

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformPropertyName("version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Version => new TerraformReference(this, "version");

    /// <summary>
    /// The vpc_config attribute.
    /// </summary>
    [TerraformPropertyName("vpc_config")]
    // Output-only attribute - read-only reference
    public TerraformList<object> VpcConfig => new TerraformReference(this, "vpc_config");

    /// <summary>
    /// The zonal_shift_config attribute.
    /// </summary>
    [TerraformPropertyName("zonal_shift_config")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ZonalShiftConfig => new TerraformReference(this, "zonal_shift_config");

}
