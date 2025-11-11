using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_odb_network.
/// </summary>
public partial class AwsOdbNetworkDataSource : TerraformDataSource
{
    public AwsOdbNetworkDataSource(string name) : base("aws_odb_network", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformProperty("id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The availability zone where the ODB network is located.
    /// </summary>
    [TerraformProperty("availability_zone")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AvailabilityZone { get; }

    /// <summary>
    /// The AZ ID of the AZ where the ODB network is located.
    /// </summary>
    [TerraformProperty("availability_zone_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AvailabilityZoneId { get; }

    /// <summary>
    ///  The CIDR range of the backup subnet for the ODB network.
    /// </summary>
    [TerraformProperty("backup_subnet_cidr")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> BackupSubnetCidr { get; }

    /// <summary>
    /// The CIDR notation for the network resource.
    /// </summary>
    [TerraformProperty("client_subnet_cidr")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ClientSubnetCidr { get; }

    /// <summary>
    /// The date and time when the ODB network was created.
    /// </summary>
    [TerraformProperty("created_at")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreatedAt { get; }

    /// <summary>
    /// The name of the custom domain that the network is located.
    /// </summary>
    [TerraformProperty("custom_domain_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CustomDomainName { get; }

    /// <summary>
    /// The default DNS prefix for the network resource.
    /// </summary>
    [TerraformProperty("default_dns_prefix")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DefaultDnsPrefix { get; }

    /// <summary>
    /// Display name for the network resource.
    /// </summary>
    [TerraformProperty("display_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DisplayName { get; }

    /// <summary>
    /// The managed services configuration for the ODB network.
    /// </summary>
    [TerraformProperty("managed_services")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ManagedServices { get; }

    /// <summary>
    /// The DNS resolver endpoint in OCI for forwarding DNS queries for the ociPrivateZone domain.
    /// </summary>
    [TerraformProperty("oci_dns_forwarding_configs")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> OciDnsForwardingConfigs { get; }

    /// <summary>
    /// The unique identifier of the OCI network anchor for the ODB network.
    /// </summary>
    [TerraformProperty("oci_network_anchor_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> OciNetworkAnchorId { get; }

    /// <summary>
    /// The URL of the OCI network anchor for the ODB network.
    /// </summary>
    [TerraformProperty("oci_network_anchor_url")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> OciNetworkAnchorUrl { get; }

    /// <summary>
    /// The name of the OCI resource anchor for the ODB network.
    /// </summary>
    [TerraformProperty("oci_resource_anchor_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> OciResourceAnchorName { get; }

    /// <summary>
    /// The unique identifier  Oracle Cloud ID (OCID) of the OCI VCN for the ODB network.
    /// </summary>
    [TerraformProperty("oci_vcn_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> OciVcnId { get; }

    /// <summary>
    /// The URL of the OCI VCN for the ODB network.
    /// </summary>
    [TerraformProperty("oci_vcn_url")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> OciVcnUrl { get; }

    /// <summary>
    /// The list of CIDR ranges from the peered VPC that are allowed access to the ODB network. Please refer odb network peering documentation.
    /// </summary>
    [TerraformProperty("peered_cidrs")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> PeeredCidrs { get; }

    /// <summary>
    /// The amount of progress made on the current operation on the ODB network, expressed as a percentage.
    /// </summary>
    [TerraformProperty("percent_progress")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> PercentProgress { get; }

    /// <summary>
    /// The status of the network resource.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Status { get; }

    /// <summary>
    /// Additional information about the current status of the ODB network.
    /// </summary>
    [TerraformProperty("status_reason")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> StatusReason { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Tags { get; }

}
