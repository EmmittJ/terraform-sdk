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
    public required TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The availability zone where the ODB network is located.
    /// </summary>
    [TerraformPropertyName("availability_zone")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AvailabilityZone => new TerraformReference(this, "availability_zone");

    /// <summary>
    /// The AZ ID of the AZ where the ODB network is located.
    /// </summary>
    [TerraformPropertyName("availability_zone_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AvailabilityZoneId => new TerraformReference(this, "availability_zone_id");

    /// <summary>
    ///  The CIDR range of the backup subnet for the ODB network.
    /// </summary>
    [TerraformPropertyName("backup_subnet_cidr")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> BackupSubnetCidr => new TerraformReference(this, "backup_subnet_cidr");

    /// <summary>
    /// The CIDR notation for the network resource.
    /// </summary>
    [TerraformPropertyName("client_subnet_cidr")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ClientSubnetCidr => new TerraformReference(this, "client_subnet_cidr");

    /// <summary>
    /// The date and time when the ODB network was created.
    /// </summary>
    [TerraformPropertyName("created_at")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreatedAt => new TerraformReference(this, "created_at");

    /// <summary>
    /// The name of the custom domain that the network is located.
    /// </summary>
    [TerraformPropertyName("custom_domain_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CustomDomainName => new TerraformReference(this, "custom_domain_name");

    /// <summary>
    /// The default DNS prefix for the network resource.
    /// </summary>
    [TerraformPropertyName("default_dns_prefix")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DefaultDnsPrefix => new TerraformReference(this, "default_dns_prefix");

    /// <summary>
    /// Display name for the network resource.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DisplayName => new TerraformReference(this, "display_name");

    /// <summary>
    /// The managed services configuration for the ODB network.
    /// </summary>
    [TerraformPropertyName("managed_services")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ManagedServices => new TerraformReference(this, "managed_services");

    /// <summary>
    /// The DNS resolver endpoint in OCI for forwarding DNS queries for the ociPrivateZone domain.
    /// </summary>
    [TerraformPropertyName("oci_dns_forwarding_configs")]
    // Output-only attribute - read-only reference
    public TerraformList<object> OciDnsForwardingConfigs => new TerraformReference(this, "oci_dns_forwarding_configs");

    /// <summary>
    /// The unique identifier of the OCI network anchor for the ODB network.
    /// </summary>
    [TerraformPropertyName("oci_network_anchor_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OciNetworkAnchorId => new TerraformReference(this, "oci_network_anchor_id");

    /// <summary>
    /// The URL of the OCI network anchor for the ODB network.
    /// </summary>
    [TerraformPropertyName("oci_network_anchor_url")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OciNetworkAnchorUrl => new TerraformReference(this, "oci_network_anchor_url");

    /// <summary>
    /// The name of the OCI resource anchor for the ODB network.
    /// </summary>
    [TerraformPropertyName("oci_resource_anchor_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OciResourceAnchorName => new TerraformReference(this, "oci_resource_anchor_name");

    /// <summary>
    /// The unique identifier  Oracle Cloud ID (OCID) of the OCI VCN for the ODB network.
    /// </summary>
    [TerraformPropertyName("oci_vcn_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OciVcnId => new TerraformReference(this, "oci_vcn_id");

    /// <summary>
    /// The URL of the OCI VCN for the ODB network.
    /// </summary>
    [TerraformPropertyName("oci_vcn_url")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OciVcnUrl => new TerraformReference(this, "oci_vcn_url");

    /// <summary>
    /// The list of CIDR ranges from the peered VPC that are allowed access to the ODB network. Please refer odb network peering documentation.
    /// </summary>
    [TerraformPropertyName("peered_cidrs")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> PeeredCidrs => new TerraformReference(this, "peered_cidrs");

    /// <summary>
    /// The amount of progress made on the current operation on the ODB network, expressed as a percentage.
    /// </summary>
    [TerraformPropertyName("percent_progress")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> PercentProgress => new TerraformReference(this, "percent_progress");

    /// <summary>
    /// The status of the network resource.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Status => new TerraformReference(this, "status");

    /// <summary>
    /// Additional information about the current status of the ODB network.
    /// </summary>
    [TerraformPropertyName("status_reason")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> StatusReason => new TerraformReference(this, "status_reason");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Tags => new TerraformReference(this, "tags");

}
