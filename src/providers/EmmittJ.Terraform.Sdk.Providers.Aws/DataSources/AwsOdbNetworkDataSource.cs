using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_odb_network.
/// </summary>
public class AwsOdbNetworkDataSource : TerraformDataSource
{
    public AwsOdbNetworkDataSource(string name) : base("aws_odb_network", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
        this.WithOutput("availability_zone");
        this.WithOutput("availability_zone_id");
        this.WithOutput("backup_subnet_cidr");
        this.WithOutput("client_subnet_cidr");
        this.WithOutput("created_at");
        this.WithOutput("custom_domain_name");
        this.WithOutput("default_dns_prefix");
        this.WithOutput("display_name");
        this.WithOutput("managed_services");
        this.WithOutput("oci_dns_forwarding_configs");
        this.WithOutput("oci_network_anchor_id");
        this.WithOutput("oci_network_anchor_url");
        this.WithOutput("oci_resource_anchor_name");
        this.WithOutput("oci_vcn_id");
        this.WithOutput("oci_vcn_url");
        this.WithOutput("peered_cidrs");
        this.WithOutput("percent_progress");
        this.WithOutput("status");
        this.WithOutput("status_reason");
        this.WithOutput("tags");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformProperty<string> Id
    {
        get => GetRequiredProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The availability zone where the ODB network is located.
    /// </summary>
    public TerraformExpression AvailabilityZone => this["availability_zone"];

    /// <summary>
    /// The AZ ID of the AZ where the ODB network is located.
    /// </summary>
    public TerraformExpression AvailabilityZoneId => this["availability_zone_id"];

    /// <summary>
    ///  The CIDR range of the backup subnet for the ODB network.
    /// </summary>
    public TerraformExpression BackupSubnetCidr => this["backup_subnet_cidr"];

    /// <summary>
    /// The CIDR notation for the network resource.
    /// </summary>
    public TerraformExpression ClientSubnetCidr => this["client_subnet_cidr"];

    /// <summary>
    /// The date and time when the ODB network was created.
    /// </summary>
    public TerraformExpression CreatedAt => this["created_at"];

    /// <summary>
    /// The name of the custom domain that the network is located.
    /// </summary>
    public TerraformExpression CustomDomainName => this["custom_domain_name"];

    /// <summary>
    /// The default DNS prefix for the network resource.
    /// </summary>
    public TerraformExpression DefaultDnsPrefix => this["default_dns_prefix"];

    /// <summary>
    /// Display name for the network resource.
    /// </summary>
    public TerraformExpression DisplayName => this["display_name"];

    /// <summary>
    /// The managed services configuration for the ODB network.
    /// </summary>
    public TerraformExpression ManagedServices => this["managed_services"];

    /// <summary>
    /// The DNS resolver endpoint in OCI for forwarding DNS queries for the ociPrivateZone domain.
    /// </summary>
    public TerraformExpression OciDnsForwardingConfigs => this["oci_dns_forwarding_configs"];

    /// <summary>
    /// The unique identifier of the OCI network anchor for the ODB network.
    /// </summary>
    public TerraformExpression OciNetworkAnchorId => this["oci_network_anchor_id"];

    /// <summary>
    /// The URL of the OCI network anchor for the ODB network.
    /// </summary>
    public TerraformExpression OciNetworkAnchorUrl => this["oci_network_anchor_url"];

    /// <summary>
    /// The name of the OCI resource anchor for the ODB network.
    /// </summary>
    public TerraformExpression OciResourceAnchorName => this["oci_resource_anchor_name"];

    /// <summary>
    /// The unique identifier  Oracle Cloud ID (OCID) of the OCI VCN for the ODB network.
    /// </summary>
    public TerraformExpression OciVcnId => this["oci_vcn_id"];

    /// <summary>
    /// The URL of the OCI VCN for the ODB network.
    /// </summary>
    public TerraformExpression OciVcnUrl => this["oci_vcn_url"];

    /// <summary>
    /// The list of CIDR ranges from the peered VPC that are allowed access to the ODB network. Please refer odb network peering documentation.
    /// </summary>
    public TerraformExpression PeeredCidrs => this["peered_cidrs"];

    /// <summary>
    /// The amount of progress made on the current operation on the ODB network, expressed as a percentage.
    /// </summary>
    public TerraformExpression PercentProgress => this["percent_progress"];

    /// <summary>
    /// The status of the network resource.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// Additional information about the current status of the ODB network.
    /// </summary>
    public TerraformExpression StatusReason => this["status_reason"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

}
