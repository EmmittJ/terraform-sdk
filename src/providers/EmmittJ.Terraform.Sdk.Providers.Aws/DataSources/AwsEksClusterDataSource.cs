using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_eks_cluster.
/// </summary>
public partial class AwsEksClusterDataSource : TerraformDataSource
{
    public AwsEksClusterDataSource(string name) : base("aws_eks_cluster", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// The access_config attribute.
    /// </summary>
    [TerraformProperty("access_config")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> AccessConfig { get; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The certificate_authority attribute.
    /// </summary>
    [TerraformProperty("certificate_authority")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> CertificateAuthority { get; }

    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    [TerraformProperty("cluster_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ClusterId { get; }

    /// <summary>
    /// The compute_config attribute.
    /// </summary>
    [TerraformProperty("compute_config")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ComputeConfig { get; }

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    [TerraformProperty("created_at")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreatedAt { get; }

    /// <summary>
    /// The deletion_protection attribute.
    /// </summary>
    [TerraformProperty("deletion_protection")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> DeletionProtection { get; }

    /// <summary>
    /// The enabled_cluster_log_types attribute.
    /// </summary>
    [TerraformProperty("enabled_cluster_log_types")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> EnabledClusterLogTypes { get; }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformProperty("endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Endpoint { get; }

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformProperty("identity")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Identity { get; }

    /// <summary>
    /// The kubernetes_network_config attribute.
    /// </summary>
    [TerraformProperty("kubernetes_network_config")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> KubernetesNetworkConfig { get; }

    /// <summary>
    /// The outpost_config attribute.
    /// </summary>
    [TerraformProperty("outpost_config")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> OutpostConfig { get; }

    /// <summary>
    /// The platform_version attribute.
    /// </summary>
    [TerraformProperty("platform_version")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PlatformVersion { get; }

    /// <summary>
    /// The remote_network_config attribute.
    /// </summary>
    [TerraformProperty("remote_network_config")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> RemoteNetworkConfig { get; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [TerraformProperty("role_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> RoleArn { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Status { get; }

    /// <summary>
    /// The storage_config attribute.
    /// </summary>
    [TerraformProperty("storage_config")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> StorageConfig { get; }

    /// <summary>
    /// The upgrade_policy attribute.
    /// </summary>
    [TerraformProperty("upgrade_policy")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> UpgradePolicy { get; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformProperty("version")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Version { get; }

    /// <summary>
    /// The vpc_config attribute.
    /// </summary>
    [TerraformProperty("vpc_config")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> VpcConfig { get; }

    /// <summary>
    /// The zonal_shift_config attribute.
    /// </summary>
    [TerraformProperty("zonal_shift_config")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ZonalShiftConfig { get; }

}
