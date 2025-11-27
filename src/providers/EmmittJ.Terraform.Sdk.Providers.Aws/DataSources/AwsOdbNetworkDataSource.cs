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
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The availability zone where the ODB network is located.
    /// </summary>
    public TerraformValue<string> AvailabilityZone
    {
        get => new TerraformReference<string>(this, "availability_zone");
    }

    /// <summary>
    /// The AZ ID of the AZ where the ODB network is located.
    /// </summary>
    public TerraformValue<string> AvailabilityZoneId
    {
        get => new TerraformReference<string>(this, "availability_zone_id");
    }

    /// <summary>
    ///  The CIDR range of the backup subnet for the ODB network.
    /// </summary>
    public TerraformValue<string> BackupSubnetCidr
    {
        get => new TerraformReference<string>(this, "backup_subnet_cidr");
    }

    /// <summary>
    /// The CIDR notation for the network resource.
    /// </summary>
    public TerraformValue<string> ClientSubnetCidr
    {
        get => new TerraformReference<string>(this, "client_subnet_cidr");
    }

    /// <summary>
    /// The date and time when the ODB network was created.
    /// </summary>
    public TerraformValue<string> CreatedAt
    {
        get => new TerraformReference<string>(this, "created_at");
    }

    /// <summary>
    /// The name of the custom domain that the network is located.
    /// </summary>
    public TerraformValue<string> CustomDomainName
    {
        get => new TerraformReference<string>(this, "custom_domain_name");
    }

    /// <summary>
    /// The default DNS prefix for the network resource.
    /// </summary>
    public TerraformValue<string> DefaultDnsPrefix
    {
        get => new TerraformReference<string>(this, "default_dns_prefix");
    }

    /// <summary>
    /// Display name for the network resource.
    /// </summary>
    public TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

}
