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
        get => GetRequiredArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The availability zone where the ODB network is located.
    /// </summary>
    public TerraformValue<string> AvailabilityZone
        => CreateReference("availability_zone");

    /// <summary>
    /// The AZ ID of the AZ where the ODB network is located.
    /// </summary>
    public TerraformValue<string> AvailabilityZoneId
        => CreateReference("availability_zone_id");

    /// <summary>
    ///  The CIDR range of the backup subnet for the ODB network.
    /// </summary>
    public TerraformValue<string> BackupSubnetCidr
        => CreateReference("backup_subnet_cidr");

    /// <summary>
    /// The CIDR notation for the network resource.
    /// </summary>
    public TerraformValue<string> ClientSubnetCidr
        => CreateReference("client_subnet_cidr");

    /// <summary>
    /// The date and time when the ODB network was created.
    /// </summary>
    public TerraformValue<string> CreatedAt
        => CreateReference("created_at");

    /// <summary>
    /// The name of the custom domain that the network is located.
    /// </summary>
    public TerraformValue<string> CustomDomainName
        => CreateReference("custom_domain_name");

    /// <summary>
    /// The default DNS prefix for the network resource.
    /// </summary>
    public TerraformValue<string> DefaultDnsPrefix
        => CreateReference("default_dns_prefix");

    /// <summary>
    /// Display name for the network resource.
    /// </summary>
    public TerraformValue<string> DisplayName
        => CreateReference("display_name");

    /// <summary>
    /// The managed services configuration for the ODB network.
    /// </summary>
    public TerraformList<TerraformMap<object>> ManagedServices
        => CreateReference("managed_services");

    /// <summary>
    /// The DNS resolver endpoint in OCI for forwarding DNS queries for the ociPrivateZone domain.
    /// </summary>
    public TerraformList<TerraformMap<object>> OciDnsForwardingConfigs
        => CreateReference("oci_dns_forwarding_configs");

    /// <summary>
    /// The unique identifier of the OCI network anchor for the ODB network.
    /// </summary>
    public TerraformValue<string> OciNetworkAnchorId
        => CreateReference("oci_network_anchor_id");

    /// <summary>
    /// The URL of the OCI network anchor for the ODB network.
    /// </summary>
    public TerraformValue<string> OciNetworkAnchorUrl
        => CreateReference("oci_network_anchor_url");

    /// <summary>
    /// The name of the OCI resource anchor for the ODB network.
    /// </summary>
    public TerraformValue<string> OciResourceAnchorName
        => CreateReference("oci_resource_anchor_name");

    /// <summary>
    /// The unique identifier  Oracle Cloud ID (OCID) of the OCI VCN for the ODB network.
    /// </summary>
    public TerraformValue<string> OciVcnId
        => CreateReference("oci_vcn_id");

    /// <summary>
    /// The URL of the OCI VCN for the ODB network.
    /// </summary>
    public TerraformValue<string> OciVcnUrl
        => CreateReference("oci_vcn_url");

    /// <summary>
    /// The list of CIDR ranges from the peered VPC that are allowed access to the ODB network. Please refer odb network peering documentation.
    /// </summary>
    public TerraformSet<string> PeeredCidrs
        => CreateReference("peered_cidrs");

    /// <summary>
    /// The amount of progress made on the current operation on the ODB network, expressed as a percentage.
    /// </summary>
    public TerraformValue<double> PercentProgress
        => CreateReference("percent_progress");

    /// <summary>
    /// The status of the network resource.
    /// </summary>
    public TerraformValue<string> Status
        => CreateReference("status");

    /// <summary>
    /// Additional information about the current status of the ODB network.
    /// </summary>
    public TerraformValue<string> StatusReason
        => CreateReference("status_reason");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => CreateReference("tags");

}
