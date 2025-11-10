using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_fsx_ontap_file_system.
/// </summary>
public class AwsFsxOntapFileSystemDataSource : TerraformDataSource
{
    public AwsFsxOntapFileSystemDataSource(string name) : base("aws_fsx_ontap_file_system", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformPropertyName("id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Id { get; set; }

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
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The automatic_backup_retention_days attribute.
    /// </summary>
    [TerraformPropertyName("automatic_backup_retention_days")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> AutomaticBackupRetentionDays => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "automatic_backup_retention_days");

    /// <summary>
    /// The daily_automatic_backup_start_time attribute.
    /// </summary>
    [TerraformPropertyName("daily_automatic_backup_start_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DailyAutomaticBackupStartTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "daily_automatic_backup_start_time");

    /// <summary>
    /// The deployment_type attribute.
    /// </summary>
    [TerraformPropertyName("deployment_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DeploymentType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "deployment_type");

    /// <summary>
    /// The disk_iops_configuration attribute.
    /// </summary>
    [TerraformPropertyName("disk_iops_configuration")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> DiskIopsConfiguration => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "disk_iops_configuration");

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    [TerraformPropertyName("dns_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DnsName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "dns_name");

    /// <summary>
    /// The endpoint_ip_address_range attribute.
    /// </summary>
    [TerraformPropertyName("endpoint_ip_address_range")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EndpointIpAddressRange => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "endpoint_ip_address_range");

    /// <summary>
    /// The endpoints attribute.
    /// </summary>
    [TerraformPropertyName("endpoints")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Endpoints => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "endpoints");

    /// <summary>
    /// The ha_pairs attribute.
    /// </summary>
    [TerraformPropertyName("ha_pairs")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> HaPairs => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "ha_pairs");

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> KmsKeyId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "kms_key_id");

    /// <summary>
    /// The network_interface_ids attribute.
    /// </summary>
    [TerraformPropertyName("network_interface_ids")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> NetworkInterfaceIds => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "network_interface_ids");

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [TerraformPropertyName("owner_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OwnerId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "owner_id");

    /// <summary>
    /// The preferred_subnet_id attribute.
    /// </summary>
    [TerraformPropertyName("preferred_subnet_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PreferredSubnetId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "preferred_subnet_id");

    /// <summary>
    /// The route_table_ids attribute.
    /// </summary>
    [TerraformPropertyName("route_table_ids")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> RouteTableIds => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "route_table_ids");

    /// <summary>
    /// The storage_capacity attribute.
    /// </summary>
    [TerraformPropertyName("storage_capacity")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> StorageCapacity => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "storage_capacity");

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    [TerraformPropertyName("storage_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StorageType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "storage_type");

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [TerraformPropertyName("subnet_ids")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> SubnetIds => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "subnet_ids");

    /// <summary>
    /// The throughput_capacity attribute.
    /// </summary>
    [TerraformPropertyName("throughput_capacity")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> ThroughputCapacity => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "throughput_capacity");

    /// <summary>
    /// The throughput_capacity_per_ha_pair attribute.
    /// </summary>
    [TerraformPropertyName("throughput_capacity_per_ha_pair")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> ThroughputCapacityPerHaPair => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "throughput_capacity_per_ha_pair");

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformPropertyName("vpc_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VpcId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "vpc_id");

    /// <summary>
    /// The weekly_maintenance_start_time attribute.
    /// </summary>
    [TerraformPropertyName("weekly_maintenance_start_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> WeeklyMaintenanceStartTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "weekly_maintenance_start_time");

}
