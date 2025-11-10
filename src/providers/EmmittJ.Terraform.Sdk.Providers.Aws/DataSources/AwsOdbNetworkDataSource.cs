using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_odb_network.
/// </summary>
public class AwsOdbNetworkDataSource : TerraformDataSource
{
    public AwsOdbNetworkDataSource(string name) : base("aws_odb_network", name)
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
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The availability zone where the ODB network is located.
    /// </summary>
    [TerraformPropertyName("availability_zone")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AvailabilityZone => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "availability_zone");

    /// <summary>
    /// The AZ ID of the AZ where the ODB network is located.
    /// </summary>
    [TerraformPropertyName("availability_zone_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AvailabilityZoneId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "availability_zone_id");

    /// <summary>
    ///  The CIDR range of the backup subnet for the ODB network.
    /// </summary>
    [TerraformPropertyName("backup_subnet_cidr")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> BackupSubnetCidr => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "backup_subnet_cidr");

    /// <summary>
    /// The CIDR notation for the network resource.
    /// </summary>
    [TerraformPropertyName("client_subnet_cidr")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ClientSubnetCidr => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "client_subnet_cidr");

    /// <summary>
    /// The date and time when the ODB network was created.
    /// </summary>
    [TerraformPropertyName("created_at")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreatedAt => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "created_at");

    /// <summary>
    /// The name of the custom domain that the network is located.
    /// </summary>
    [TerraformPropertyName("custom_domain_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CustomDomainName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "custom_domain_name");

    /// <summary>
    /// The default DNS prefix for the network resource.
    /// </summary>
    [TerraformPropertyName("default_dns_prefix")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DefaultDnsPrefix => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "default_dns_prefix");

    /// <summary>
    /// Display name for the network resource.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DisplayName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "display_name");

    /// <summary>
    /// The managed services configuration for the ODB network.
    /// </summary>
    [TerraformPropertyName("managed_services")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ManagedServices => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "managed_services");

    /// <summary>
    /// The DNS resolver endpoint in OCI for forwarding DNS queries for the ociPrivateZone domain.
    /// </summary>
    [TerraformPropertyName("oci_dns_forwarding_configs")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> OciDnsForwardingConfigs => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "oci_dns_forwarding_configs");

    /// <summary>
    /// The unique identifier of the OCI network anchor for the ODB network.
    /// </summary>
    [TerraformPropertyName("oci_network_anchor_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OciNetworkAnchorId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "oci_network_anchor_id");

    /// <summary>
    /// The URL of the OCI network anchor for the ODB network.
    /// </summary>
    [TerraformPropertyName("oci_network_anchor_url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OciNetworkAnchorUrl => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "oci_network_anchor_url");

    /// <summary>
    /// The name of the OCI resource anchor for the ODB network.
    /// </summary>
    [TerraformPropertyName("oci_resource_anchor_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OciResourceAnchorName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "oci_resource_anchor_name");

    /// <summary>
    /// The unique identifier  Oracle Cloud ID (OCID) of the OCI VCN for the ODB network.
    /// </summary>
    [TerraformPropertyName("oci_vcn_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OciVcnId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "oci_vcn_id");

    /// <summary>
    /// The URL of the OCI VCN for the ODB network.
    /// </summary>
    [TerraformPropertyName("oci_vcn_url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OciVcnUrl => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "oci_vcn_url");

    /// <summary>
    /// The list of CIDR ranges from the peered VPC that are allowed access to the ODB network. Please refer odb network peering documentation.
    /// </summary>
    [TerraformPropertyName("peered_cidrs")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> PeeredCidrs => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "peered_cidrs");

    /// <summary>
    /// The amount of progress made on the current operation on the ODB network, expressed as a percentage.
    /// </summary>
    [TerraformPropertyName("percent_progress")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> PercentProgress => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "percent_progress");

    /// <summary>
    /// The status of the network resource.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Status => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status");

    /// <summary>
    /// Additional information about the current status of the ODB network.
    /// </summary>
    [TerraformPropertyName("status_reason")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StatusReason => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status_reason");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

}
