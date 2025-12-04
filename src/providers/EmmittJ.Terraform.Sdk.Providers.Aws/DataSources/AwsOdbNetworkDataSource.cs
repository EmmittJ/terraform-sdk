using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_odb_network Terraform data source.
/// Retrieves information about a aws_odb_network.
/// </summary>
public partial class AwsOdbNetworkDataSource(string name) : TerraformDataSource("aws_odb_network", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The availability zone where the ODB network is located.
    /// </summary>
    public TerraformValue<string> AvailabilityZone
        => AsReference("availability_zone");

    /// <summary>
    /// The AZ ID of the AZ where the ODB network is located.
    /// </summary>
    public TerraformValue<string> AvailabilityZoneId
        => AsReference("availability_zone_id");

    /// <summary>
    ///  The CIDR range of the backup subnet for the ODB network.
    /// </summary>
    public TerraformValue<string> BackupSubnetCidr
        => AsReference("backup_subnet_cidr");

    /// <summary>
    /// The CIDR notation for the network resource.
    /// </summary>
    public TerraformValue<string> ClientSubnetCidr
        => AsReference("client_subnet_cidr");

    /// <summary>
    /// The date and time when the ODB network was created.
    /// </summary>
    public TerraformValue<string> CreatedAt
        => AsReference("created_at");

    /// <summary>
    /// The name of the custom domain that the network is located.
    /// </summary>
    public TerraformValue<string> CustomDomainName
        => AsReference("custom_domain_name");

    /// <summary>
    /// The default DNS prefix for the network resource.
    /// </summary>
    public TerraformValue<string> DefaultDnsPrefix
        => AsReference("default_dns_prefix");

    /// <summary>
    /// Display name for the network resource.
    /// </summary>
    public TerraformValue<string> DisplayName
        => AsReference("display_name");

    /// <summary>
    /// The managed services configuration for the ODB network.
    /// </summary>
    public TerraformList<TerraformMap<object>> ManagedServices
        => AsReference("managed_services");

    /// <summary>
    /// The DNS resolver endpoint in OCI for forwarding DNS queries for the ociPrivateZone domain.
    /// </summary>
    public TerraformList<TerraformMap<object>> OciDnsForwardingConfigs
        => AsReference("oci_dns_forwarding_configs");

    /// <summary>
    /// The unique identifier of the OCI network anchor for the ODB network.
    /// </summary>
    public TerraformValue<string> OciNetworkAnchorId
        => AsReference("oci_network_anchor_id");

    /// <summary>
    /// The URL of the OCI network anchor for the ODB network.
    /// </summary>
    public TerraformValue<string> OciNetworkAnchorUrl
        => AsReference("oci_network_anchor_url");

    /// <summary>
    /// The name of the OCI resource anchor for the ODB network.
    /// </summary>
    public TerraformValue<string> OciResourceAnchorName
        => AsReference("oci_resource_anchor_name");

    /// <summary>
    /// The unique identifier  Oracle Cloud ID (OCID) of the OCI VCN for the ODB network.
    /// </summary>
    public TerraformValue<string> OciVcnId
        => AsReference("oci_vcn_id");

    /// <summary>
    /// The URL of the OCI VCN for the ODB network.
    /// </summary>
    public TerraformValue<string> OciVcnUrl
        => AsReference("oci_vcn_url");

    /// <summary>
    /// The list of CIDR ranges from the peered VPC that are allowed access to the ODB network. Please refer odb network peering documentation.
    /// </summary>
    public TerraformSet<string> PeeredCidrs
        => AsReference("peered_cidrs");

    /// <summary>
    /// The amount of progress made on the current operation on the ODB network, expressed as a percentage.
    /// </summary>
    public TerraformValue<double> PercentProgress
        => AsReference("percent_progress");

    /// <summary>
    /// The status of the network resource.
    /// </summary>
    public TerraformValue<string> Status
        => AsReference("status");

    /// <summary>
    /// Additional information about the current status of the ODB network.
    /// </summary>
    public TerraformValue<string> StatusReason
        => AsReference("status_reason");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => AsReference("tags");

}
