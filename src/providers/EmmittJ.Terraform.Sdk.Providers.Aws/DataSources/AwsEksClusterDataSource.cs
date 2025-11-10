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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The access_config attribute.
    /// </summary>
    [TerraformPropertyName("access_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> AccessConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "access_config");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The certificate_authority attribute.
    /// </summary>
    [TerraformPropertyName("certificate_authority")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> CertificateAuthority => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "certificate_authority");

    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    [TerraformPropertyName("cluster_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ClusterId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "cluster_id");

    /// <summary>
    /// The compute_config attribute.
    /// </summary>
    [TerraformPropertyName("compute_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ComputeConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "compute_config");

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    [TerraformPropertyName("created_at")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreatedAt => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "created_at");

    /// <summary>
    /// The deletion_protection attribute.
    /// </summary>
    [TerraformPropertyName("deletion_protection")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> DeletionProtection => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "deletion_protection");

    /// <summary>
    /// The enabled_cluster_log_types attribute.
    /// </summary>
    [TerraformPropertyName("enabled_cluster_log_types")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> EnabledClusterLogTypes => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "enabled_cluster_log_types");

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformPropertyName("endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Endpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "endpoint");

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformPropertyName("identity")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Identity => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "identity");

    /// <summary>
    /// The kubernetes_network_config attribute.
    /// </summary>
    [TerraformPropertyName("kubernetes_network_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> KubernetesNetworkConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "kubernetes_network_config");

    /// <summary>
    /// The outpost_config attribute.
    /// </summary>
    [TerraformPropertyName("outpost_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> OutpostConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "outpost_config");

    /// <summary>
    /// The platform_version attribute.
    /// </summary>
    [TerraformPropertyName("platform_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PlatformVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "platform_version");

    /// <summary>
    /// The remote_network_config attribute.
    /// </summary>
    [TerraformPropertyName("remote_network_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> RemoteNetworkConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "remote_network_config");

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [TerraformPropertyName("role_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RoleArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "role_arn");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Status => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status");

    /// <summary>
    /// The storage_config attribute.
    /// </summary>
    [TerraformPropertyName("storage_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> StorageConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "storage_config");

    /// <summary>
    /// The upgrade_policy attribute.
    /// </summary>
    [TerraformPropertyName("upgrade_policy")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> UpgradePolicy => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "upgrade_policy");

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformPropertyName("version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Version => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "version");

    /// <summary>
    /// The vpc_config attribute.
    /// </summary>
    [TerraformPropertyName("vpc_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> VpcConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "vpc_config");

    /// <summary>
    /// The zonal_shift_config attribute.
    /// </summary>
    [TerraformPropertyName("zonal_shift_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ZonalShiftConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "zonal_shift_config");

}
