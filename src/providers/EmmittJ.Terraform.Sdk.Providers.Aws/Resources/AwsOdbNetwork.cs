using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsOdbNetworkTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_odb_network resource.
/// </summary>
public partial class AwsOdbNetwork : TerraformResource
{
    public AwsOdbNetwork(string name) : base("aws_odb_network", name)
    {
    }

    /// <summary>
    /// The name of the Availability Zone (AZ) where the odb network is located. Changing this will force terraform to create new resource
    /// </summary>
    [TerraformProperty("availability_zone")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> AvailabilityZone { get; set; }

    /// <summary>
    /// The AZ ID of the AZ where the ODB network is located. Changing this will force terraform to create new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AvailabilityZoneId is required")]
    [TerraformProperty("availability_zone_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AvailabilityZoneId { get; set; }

    /// <summary>
    /// The CIDR range of the backup subnet for the ODB network. Changing this will force terraform to create new resource.
    /// 	Constraints:
    /// 	   - Must not overlap with the CIDR range of the client subnet.
    /// 	   - Must not overlap with the CIDR ranges of the VPCs that are connected to the
    /// 	   ODB network.
    /// 	   - Must not use the following CIDR ranges that are reserved by OCI:
    /// 	   - 100.106.0.0/16 and 100.107.0.0/16
    /// 	   - 169.254.0.0/16
    /// 	   - 224.0.0.0 - 239.255.255.255
    /// 	   - 240.0.0.0 - 255.255.255.255
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupSubnetCidr is required")]
    [TerraformProperty("backup_subnet_cidr")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> BackupSubnetCidr { get; set; }

    /// <summary>
    /// The CIDR notation for the network resource. Changing this will force terraform to create new resource.
    ///  Constraints:
    ///   	 - Must not overlap with the CIDR range of the backup subnet.
    ///    	- Must not overlap with the CIDR ranges of the VPCs that are connected to the
    ///    ODB network.
    ///   	- Must not use the following CIDR ranges that are reserved by OCI:
    ///   	 - 100.106.0.0/16 and 100.107.0.0/16
    ///   	 - 169.254.0.0/16
    ///    	- 224.0.0.0 - 239.255.255.255
    ///    	- 240.0.0.0 - 255.255.255.255
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientSubnetCidr is required")]
    [TerraformProperty("client_subnet_cidr")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ClientSubnetCidr { get; set; }

    /// <summary>
    /// The name of the custom domain that the network is located. custom_domain_name and default_dns_prefix both can&#39;t be given.
    /// </summary>
    [TerraformProperty("custom_domain_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CustomDomainName { get; set; }

    /// <summary>
    /// The default DNS prefix for the network resource. Changing this will force terraform to create new resource.
    /// </summary>
    [TerraformProperty("default_dns_prefix")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DefaultDnsPrefix { get; set; }

    /// <summary>
    /// If set to true deletes associated OCI resources. Default false.
    /// </summary>
    [TerraformProperty("delete_associated_resources")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> DeleteAssociatedResources { get; set; }

    /// <summary>
    /// The user-friendly name for the odb network. Changing this will force terraform to create a new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformProperty("display_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Specifies the configuration for Amazon S3 access from the ODB network.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3Access is required")]
    [TerraformProperty("s3_access")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> S3Access { get; set; }

    /// <summary>
    /// Specifies the endpoint policy for Amazon S3 access from the ODB network.
    /// </summary>
    [TerraformProperty("s3_policy_document")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? S3PolicyDocument { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Specifies the configuration for Zero-ETL access from the ODB network.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ZeroEtlAccess is required")]
    [TerraformProperty("zero_etl_access")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ZeroEtlAccess { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsOdbNetworkTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The date and time when the ODB network was created.
    /// </summary>
    [TerraformProperty("created_at")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreatedAt { get; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Id { get; }

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
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TagsAll { get; }

}
