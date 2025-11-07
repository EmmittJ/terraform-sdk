using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_odb_network resource.
/// </summary>
public class AwsOdbNetwork : TerraformResource
{
    public AwsOdbNetwork(string name) : base("aws_odb_network", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("created_at");
        this.DeclareOutput("id");
        this.DeclareOutput("managed_services");
        this.DeclareOutput("oci_dns_forwarding_configs");
        this.DeclareOutput("oci_network_anchor_id");
        this.DeclareOutput("oci_network_anchor_url");
        this.DeclareOutput("oci_resource_anchor_name");
        this.DeclareOutput("oci_vcn_id");
        this.DeclareOutput("oci_vcn_url");
        this.DeclareOutput("peered_cidrs");
        this.DeclareOutput("percent_progress");
        this.DeclareOutput("status");
        this.DeclareOutput("status_reason");
        this.DeclareOutput("tags_all");
    }

    /// <summary>
    /// The name of the Availability Zone (AZ) where the odb network is located. Changing this will force terraform to create new resource
    /// </summary>
    public TerraformLiteralProperty<string>? AvailabilityZone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("availability_zone");
        set => this.WithProperty("availability_zone", value);
    }

    /// <summary>
    /// The AZ ID of the AZ where the ODB network is located. Changing this will force terraform to create new resource.
    /// </summary>
    public TerraformLiteralProperty<string>? AvailabilityZoneId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("availability_zone_id");
        set => this.WithProperty("availability_zone_id", value);
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
    public TerraformLiteralProperty<string>? BackupSubnetCidr
    {
        get => GetProperty<TerraformLiteralProperty<string>>("backup_subnet_cidr");
        set => this.WithProperty("backup_subnet_cidr", value);
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
    public TerraformLiteralProperty<string>? ClientSubnetCidr
    {
        get => GetProperty<TerraformLiteralProperty<string>>("client_subnet_cidr");
        set => this.WithProperty("client_subnet_cidr", value);
    }

    /// <summary>
    /// The name of the custom domain that the network is located. custom_domain_name and default_dns_prefix both can&#39;t be given.
    /// </summary>
    public TerraformLiteralProperty<string>? CustomDomainName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("custom_domain_name");
        set => this.WithProperty("custom_domain_name", value);
    }

    /// <summary>
    /// The default DNS prefix for the network resource. Changing this will force terraform to create new resource.
    /// </summary>
    public TerraformLiteralProperty<string>? DefaultDnsPrefix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("default_dns_prefix");
        set => this.WithProperty("default_dns_prefix", value);
    }

    /// <summary>
    /// If set to true deletes associated OCI resources. Default false.
    /// </summary>
    public TerraformLiteralProperty<bool>? DeleteAssociatedResources
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("delete_associated_resources");
        set => this.WithProperty("delete_associated_resources", value);
    }

    /// <summary>
    /// The user-friendly name for the odb network. Changing this will force terraform to create a new resource.
    /// </summary>
    public TerraformLiteralProperty<string>? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// Specifies the configuration for Amazon S3 access from the ODB network.
    /// </summary>
    public TerraformLiteralProperty<string>? S3Access
    {
        get => GetProperty<TerraformLiteralProperty<string>>("s3_access");
        set => this.WithProperty("s3_access", value);
    }

    /// <summary>
    /// Specifies the endpoint policy for Amazon S3 access from the ODB network.
    /// </summary>
    public TerraformLiteralProperty<string>? S3PolicyDocument
    {
        get => GetProperty<TerraformLiteralProperty<string>>("s3_policy_document");
        set => this.WithProperty("s3_policy_document", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// Specifies the configuration for Zero-ETL access from the ODB network.
    /// </summary>
    public TerraformLiteralProperty<string>? ZeroEtlAccess
    {
        get => GetProperty<TerraformLiteralProperty<string>>("zero_etl_access");
        set => this.WithProperty("zero_etl_access", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The date and time when the ODB network was created.
    /// </summary>
    public TerraformExpression CreatedAt => this["created_at"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

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
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

}
