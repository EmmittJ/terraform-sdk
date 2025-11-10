using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsOdbNetworkTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a aws_odb_network resource.
/// </summary>
public class AwsOdbNetwork : TerraformResource
{
    public AwsOdbNetwork(string name) : base("aws_odb_network", name)
    {
    }

    /// <summary>
    /// The name of the Availability Zone (AZ) where the odb network is located. Changing this will force terraform to create new resource
    /// </summary>
    [TerraformPropertyName("availability_zone")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> AvailabilityZone { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "availability_zone");

    /// <summary>
    /// The AZ ID of the AZ where the ODB network is located. Changing this will force terraform to create new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AvailabilityZoneId is required")]
    [TerraformPropertyName("availability_zone_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AvailabilityZoneId { get; set; }

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
    [TerraformPropertyName("backup_subnet_cidr")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> BackupSubnetCidr { get; set; }

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
    [TerraformPropertyName("client_subnet_cidr")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ClientSubnetCidr { get; set; }

    /// <summary>
    /// The name of the custom domain that the network is located. custom_domain_name and default_dns_prefix both can&#39;t be given.
    /// </summary>
    [TerraformPropertyName("custom_domain_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CustomDomainName { get; set; }

    /// <summary>
    /// The default DNS prefix for the network resource. Changing this will force terraform to create new resource.
    /// </summary>
    [TerraformPropertyName("default_dns_prefix")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DefaultDnsPrefix { get; set; }

    /// <summary>
    /// If set to true deletes associated OCI resources. Default false.
    /// </summary>
    [TerraformPropertyName("delete_associated_resources")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> DeleteAssociatedResources { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "delete_associated_resources");

    /// <summary>
    /// The user-friendly name for the odb network. Changing this will force terraform to create a new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformPropertyName("display_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DisplayName { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// Specifies the configuration for Amazon S3 access from the ODB network.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3Access is required")]
    [TerraformPropertyName("s3_access")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> S3Access { get; set; }

    /// <summary>
    /// Specifies the endpoint policy for Amazon S3 access from the ODB network.
    /// </summary>
    [TerraformPropertyName("s3_policy_document")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? S3PolicyDocument { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// Specifies the configuration for Zero-ETL access from the ODB network.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ZeroEtlAccess is required")]
    [TerraformPropertyName("zero_etl_access")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ZeroEtlAccess { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsOdbNetworkTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The date and time when the ODB network was created.
    /// </summary>
    [TerraformPropertyName("created_at")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreatedAt => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "created_at");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

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
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

}
