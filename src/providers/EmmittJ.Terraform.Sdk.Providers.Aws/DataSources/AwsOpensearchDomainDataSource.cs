using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for off_peak_window_options in .
/// Nesting mode: list
/// </summary>
public partial class AwsOpensearchDomainDataSourceOffPeakWindowOptionsBlock() : TerraformBlock("off_peak_window_options")
{


}

/// <summary>
/// Retrieves information about a aws_opensearch_domain.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsOpensearchDomainDataSource : TerraformDataSource
{
    public AwsOpensearchDomainDataSource(string name) : base("aws_opensearch_domain", name)
    {
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    [TerraformProperty("domain_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DomainName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// Block for off_peak_window_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OffPeakWindowOptions block(s) allowed")]
    [TerraformProperty("off_peak_window_options")]
    public TerraformList<AwsOpensearchDomainDataSourceOffPeakWindowOptionsBlock> OffPeakWindowOptions { get; set; } = new();

    /// <summary>
    /// The access_policies attribute.
    /// </summary>
    [TerraformProperty("access_policies")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AccessPolicies { get; }

    /// <summary>
    /// The advanced_options attribute.
    /// </summary>
    [TerraformProperty("advanced_options")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> AdvancedOptions { get; }

    /// <summary>
    /// The advanced_security_options attribute.
    /// </summary>
    [TerraformProperty("advanced_security_options")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> AdvancedSecurityOptions { get; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The auto_tune_options attribute.
    /// </summary>
    [TerraformProperty("auto_tune_options")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> AutoTuneOptions { get; }

    /// <summary>
    /// The cluster_config attribute.
    /// </summary>
    [TerraformProperty("cluster_config")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ClusterConfig { get; }

    /// <summary>
    /// The cognito_options attribute.
    /// </summary>
    [TerraformProperty("cognito_options")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> CognitoOptions { get; }

    /// <summary>
    /// The created attribute.
    /// </summary>
    [TerraformProperty("created")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> Created { get; }

    /// <summary>
    /// The dashboard_endpoint attribute.
    /// </summary>
    [TerraformProperty("dashboard_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DashboardEndpoint { get; }

    /// <summary>
    /// The dashboard_endpoint_v2 attribute.
    /// </summary>
    [TerraformProperty("dashboard_endpoint_v2")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DashboardEndpointV2 { get; }

    /// <summary>
    /// The deleted attribute.
    /// </summary>
    [TerraformProperty("deleted")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> Deleted { get; }

    /// <summary>
    /// The domain_endpoint_v2_hosted_zone_id attribute.
    /// </summary>
    [TerraformProperty("domain_endpoint_v2_hosted_zone_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DomainEndpointV2HostedZoneId { get; }

    /// <summary>
    /// The domain_id attribute.
    /// </summary>
    [TerraformProperty("domain_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DomainId { get; }

    /// <summary>
    /// The ebs_options attribute.
    /// </summary>
    [TerraformProperty("ebs_options")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> EbsOptions { get; }

    /// <summary>
    /// The encryption_at_rest attribute.
    /// </summary>
    [TerraformProperty("encryption_at_rest")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> EncryptionAtRest { get; }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformProperty("endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Endpoint { get; }

    /// <summary>
    /// The endpoint_v2 attribute.
    /// </summary>
    [TerraformProperty("endpoint_v2")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> EndpointV2 { get; }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    [TerraformProperty("engine_version")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> EngineVersion { get; }

    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    [TerraformProperty("ip_address_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> IpAddressType { get; }

    /// <summary>
    /// The log_publishing_options attribute.
    /// </summary>
    [TerraformProperty("log_publishing_options")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<object> LogPublishingOptions { get; }

    /// <summary>
    /// The node_to_node_encryption attribute.
    /// </summary>
    [TerraformProperty("node_to_node_encryption")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> NodeToNodeEncryption { get; }

    /// <summary>
    /// The processing attribute.
    /// </summary>
    [TerraformProperty("processing")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> Processing { get; }

    /// <summary>
    /// The snapshot_options attribute.
    /// </summary>
    [TerraformProperty("snapshot_options")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> SnapshotOptions { get; }

    /// <summary>
    /// The software_update_options attribute.
    /// </summary>
    [TerraformProperty("software_update_options")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> SoftwareUpdateOptions { get; }

    /// <summary>
    /// The vpc_options attribute.
    /// </summary>
    [TerraformProperty("vpc_options")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> VpcOptions { get; }

}
