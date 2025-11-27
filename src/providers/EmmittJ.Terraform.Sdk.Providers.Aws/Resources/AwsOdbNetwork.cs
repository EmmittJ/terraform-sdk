using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsOdbNetwork.
/// Nesting mode: single
/// </summary>
public class AwsOdbNetworkTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_odb_network Terraform resource.
/// Manages a aws_odb_network resource.
/// </summary>
public partial class AwsOdbNetwork(string name) : TerraformResource("aws_odb_network", name)
{
    /// <summary>
    /// The name of the Availability Zone (AZ) where the odb network is located. Changing this will force terraform to create new resource
    /// </summary>
    public TerraformValue<string> AvailabilityZone
    {
        get => new TerraformReference<string>(this, "availability_zone");
        set => SetArgument("availability_zone", value);
    }

    /// <summary>
    /// The AZ ID of the AZ where the ODB network is located. Changing this will force terraform to create new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AvailabilityZoneId is required")]
    public required TerraformValue<string> AvailabilityZoneId
    {
        get => new TerraformReference<string>(this, "availability_zone_id");
        set => SetArgument("availability_zone_id", value);
    }

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
    public required TerraformValue<string> BackupSubnetCidr
    {
        get => new TerraformReference<string>(this, "backup_subnet_cidr");
        set => SetArgument("backup_subnet_cidr", value);
    }

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
    public required TerraformValue<string> ClientSubnetCidr
    {
        get => new TerraformReference<string>(this, "client_subnet_cidr");
        set => SetArgument("client_subnet_cidr", value);
    }

    /// <summary>
    /// The name of the custom domain that the network is located. custom_domain_name and default_dns_prefix both can&#39;t be given.
    /// </summary>
    public TerraformValue<string>? CustomDomainName
    {
        get => new TerraformReference<string>(this, "custom_domain_name");
        set => SetArgument("custom_domain_name", value);
    }

    /// <summary>
    /// The default DNS prefix for the network resource. Changing this will force terraform to create new resource.
    /// </summary>
    public TerraformValue<string>? DefaultDnsPrefix
    {
        get => new TerraformReference<string>(this, "default_dns_prefix");
        set => SetArgument("default_dns_prefix", value);
    }

    /// <summary>
    /// If set to true deletes associated OCI resources. Default false.
    /// </summary>
    public TerraformValue<bool> DeleteAssociatedResources
    {
        get => new TerraformReference<bool>(this, "delete_associated_resources");
        set => SetArgument("delete_associated_resources", value);
    }

    /// <summary>
    /// The user-friendly name for the odb network. Changing this will force terraform to create a new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// Specifies the configuration for Amazon S3 access from the ODB network.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3Access is required")]
    public required TerraformValue<string> S3Access
    {
        get => new TerraformReference<string>(this, "s3_access");
        set => SetArgument("s3_access", value);
    }

    /// <summary>
    /// Specifies the endpoint policy for Amazon S3 access from the ODB network.
    /// </summary>
    public TerraformValue<string>? S3PolicyDocument
    {
        get => new TerraformReference<string>(this, "s3_policy_document");
        set => SetArgument("s3_policy_document", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// Specifies the configuration for Zero-ETL access from the ODB network.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ZeroEtlAccess is required")]
    public required TerraformValue<string> ZeroEtlAccess
    {
        get => new TerraformReference<string>(this, "zero_etl_access");
        set => SetArgument("zero_etl_access", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The date and time when the ODB network was created.
    /// </summary>
    public TerraformValue<string> CreatedAt
    {
        get => new TerraformReference<string>(this, "created_at");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The managed services configuration for the ODB network.
    /// </summary>
    public TerraformList<TerraformMap<object>> ManagedServices
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "managed_services").ResolveNodes(ctx));
    }

    /// <summary>
    /// The DNS resolver endpoint in OCI for forwarding DNS queries for the ociPrivateZone domain.
    /// </summary>
    public TerraformList<TerraformMap<object>> OciDnsForwardingConfigs
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "oci_dns_forwarding_configs").ResolveNodes(ctx));
    }

    /// <summary>
    /// The unique identifier of the OCI network anchor for the ODB network.
    /// </summary>
    public TerraformValue<string> OciNetworkAnchorId
    {
        get => new TerraformReference<string>(this, "oci_network_anchor_id");
    }

    /// <summary>
    /// The URL of the OCI network anchor for the ODB network.
    /// </summary>
    public TerraformValue<string> OciNetworkAnchorUrl
    {
        get => new TerraformReference<string>(this, "oci_network_anchor_url");
    }

    /// <summary>
    /// The name of the OCI resource anchor for the ODB network.
    /// </summary>
    public TerraformValue<string> OciResourceAnchorName
    {
        get => new TerraformReference<string>(this, "oci_resource_anchor_name");
    }

    /// <summary>
    /// The unique identifier  Oracle Cloud ID (OCID) of the OCI VCN for the ODB network.
    /// </summary>
    public TerraformValue<string> OciVcnId
    {
        get => new TerraformReference<string>(this, "oci_vcn_id");
    }

    /// <summary>
    /// The URL of the OCI VCN for the ODB network.
    /// </summary>
    public TerraformValue<string> OciVcnUrl
    {
        get => new TerraformReference<string>(this, "oci_vcn_url");
    }

    /// <summary>
    /// The list of CIDR ranges from the peered VPC that are allowed access to the ODB network. Please refer odb network peering documentation.
    /// </summary>
    public TerraformSet<string> PeeredCidrs
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "peered_cidrs").ResolveNodes(ctx));
    }

    /// <summary>
    /// The amount of progress made on the current operation on the ODB network, expressed as a percentage.
    /// </summary>
    public TerraformValue<double> PercentProgress
    {
        get => new TerraformReference<double>(this, "percent_progress");
    }

    /// <summary>
    /// The status of the network resource.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

    /// <summary>
    /// Additional information about the current status of the ODB network.
    /// </summary>
    public TerraformValue<string> StatusReason
    {
        get => new TerraformReference<string>(this, "status_reason");
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsOdbNetworkTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsOdbNetworkTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
