using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsOdbNetworkTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

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
        SetOutput("arn");
        SetOutput("created_at");
        SetOutput("id");
        SetOutput("managed_services");
        SetOutput("oci_dns_forwarding_configs");
        SetOutput("oci_network_anchor_id");
        SetOutput("oci_network_anchor_url");
        SetOutput("oci_resource_anchor_name");
        SetOutput("oci_vcn_id");
        SetOutput("oci_vcn_url");
        SetOutput("peered_cidrs");
        SetOutput("percent_progress");
        SetOutput("status");
        SetOutput("status_reason");
        SetOutput("tags_all");
        SetOutput("availability_zone");
        SetOutput("availability_zone_id");
        SetOutput("backup_subnet_cidr");
        SetOutput("client_subnet_cidr");
        SetOutput("custom_domain_name");
        SetOutput("default_dns_prefix");
        SetOutput("delete_associated_resources");
        SetOutput("display_name");
        SetOutput("region");
        SetOutput("s3_access");
        SetOutput("s3_policy_document");
        SetOutput("tags");
        SetOutput("zero_etl_access");
    }

    /// <summary>
    /// The name of the Availability Zone (AZ) where the odb network is located. Changing this will force terraform to create new resource
    /// </summary>
    public TerraformProperty<string> AvailabilityZone
    {
        get => GetRequiredOutput<TerraformProperty<string>>("availability_zone");
        set => SetProperty("availability_zone", value);
    }

    /// <summary>
    /// The AZ ID of the AZ where the ODB network is located. Changing this will force terraform to create new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AvailabilityZoneId is required")]
    public required TerraformProperty<string> AvailabilityZoneId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("availability_zone_id");
        set => SetProperty("availability_zone_id", value);
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
    public required TerraformProperty<string> BackupSubnetCidr
    {
        get => GetRequiredOutput<TerraformProperty<string>>("backup_subnet_cidr");
        set => SetProperty("backup_subnet_cidr", value);
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
    public required TerraformProperty<string> ClientSubnetCidr
    {
        get => GetRequiredOutput<TerraformProperty<string>>("client_subnet_cidr");
        set => SetProperty("client_subnet_cidr", value);
    }

    /// <summary>
    /// The name of the custom domain that the network is located. custom_domain_name and default_dns_prefix both can&#39;t be given.
    /// </summary>
    public TerraformProperty<string> CustomDomainName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("custom_domain_name");
        set => SetProperty("custom_domain_name", value);
    }

    /// <summary>
    /// The default DNS prefix for the network resource. Changing this will force terraform to create new resource.
    /// </summary>
    public TerraformProperty<string> DefaultDnsPrefix
    {
        get => GetRequiredOutput<TerraformProperty<string>>("default_dns_prefix");
        set => SetProperty("default_dns_prefix", value);
    }

    /// <summary>
    /// If set to true deletes associated OCI resources. Default false.
    /// </summary>
    public TerraformProperty<bool> DeleteAssociatedResources
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("delete_associated_resources");
        set => SetProperty("delete_associated_resources", value);
    }

    /// <summary>
    /// The user-friendly name for the odb network. Changing this will force terraform to create a new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// Specifies the configuration for Amazon S3 access from the ODB network.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3Access is required")]
    public required TerraformProperty<string> S3Access
    {
        get => GetRequiredOutput<TerraformProperty<string>>("s3_access");
        set => SetProperty("s3_access", value);
    }

    /// <summary>
    /// Specifies the endpoint policy for Amazon S3 access from the ODB network.
    /// </summary>
    public TerraformProperty<string> S3PolicyDocument
    {
        get => GetRequiredOutput<TerraformProperty<string>>("s3_policy_document");
        set => SetProperty("s3_policy_document", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// Specifies the configuration for Zero-ETL access from the ODB network.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ZeroEtlAccess is required")]
    public required TerraformProperty<string> ZeroEtlAccess
    {
        get => GetRequiredOutput<TerraformProperty<string>>("zero_etl_access");
        set => SetProperty("zero_etl_access", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsOdbNetworkTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
