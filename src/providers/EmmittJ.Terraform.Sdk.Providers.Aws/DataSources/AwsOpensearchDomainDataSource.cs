using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for off_peak_window_options in .
/// Nesting mode: list
/// </summary>
public class AwsOpensearchDomainDataSourceOffPeakWindowOptionsBlock : ITerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> Enabled => new TerraformReferenceProperty<TerraformProperty<bool>>("", "enabled");

    /// <summary>
    /// The off_peak_window attribute.
    /// </summary>
    [TerraformPropertyName("off_peak_window")]
    // Computed attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> OffPeakWindow => new TerraformReferenceProperty<List<TerraformProperty<object>>>("", "off_peak_window");

}

/// <summary>
/// Retrieves information about a aws_opensearch_domain.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsOpensearchDomainDataSource : TerraformDataSource
{
    public AwsOpensearchDomainDataSource(string name) : base("aws_opensearch_domain", name)
    {
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    [TerraformPropertyName("domain_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DomainName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// Block for off_peak_window_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OffPeakWindowOptions block(s) allowed")]
    [TerraformPropertyName("off_peak_window_options")]
    public TerraformList<TerraformBlock<AwsOpensearchDomainDataSourceOffPeakWindowOptionsBlock>>? OffPeakWindowOptions { get; set; } = new();

    /// <summary>
    /// The access_policies attribute.
    /// </summary>
    [TerraformPropertyName("access_policies")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AccessPolicies => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "access_policies");

    /// <summary>
    /// The advanced_options attribute.
    /// </summary>
    [TerraformPropertyName("advanced_options")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> AdvancedOptions => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "advanced_options");

    /// <summary>
    /// The advanced_security_options attribute.
    /// </summary>
    [TerraformPropertyName("advanced_security_options")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> AdvancedSecurityOptions => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "advanced_security_options");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The auto_tune_options attribute.
    /// </summary>
    [TerraformPropertyName("auto_tune_options")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> AutoTuneOptions => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "auto_tune_options");

    /// <summary>
    /// The cluster_config attribute.
    /// </summary>
    [TerraformPropertyName("cluster_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ClusterConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "cluster_config");

    /// <summary>
    /// The cognito_options attribute.
    /// </summary>
    [TerraformPropertyName("cognito_options")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> CognitoOptions => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "cognito_options");

    /// <summary>
    /// The created attribute.
    /// </summary>
    [TerraformPropertyName("created")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> Created => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "created");

    /// <summary>
    /// The dashboard_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("dashboard_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DashboardEndpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "dashboard_endpoint");

    /// <summary>
    /// The dashboard_endpoint_v2 attribute.
    /// </summary>
    [TerraformPropertyName("dashboard_endpoint_v2")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DashboardEndpointV2 => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "dashboard_endpoint_v2");

    /// <summary>
    /// The deleted attribute.
    /// </summary>
    [TerraformPropertyName("deleted")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> Deleted => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "deleted");

    /// <summary>
    /// The domain_endpoint_v2_hosted_zone_id attribute.
    /// </summary>
    [TerraformPropertyName("domain_endpoint_v2_hosted_zone_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DomainEndpointV2HostedZoneId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "domain_endpoint_v2_hosted_zone_id");

    /// <summary>
    /// The domain_id attribute.
    /// </summary>
    [TerraformPropertyName("domain_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DomainId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "domain_id");

    /// <summary>
    /// The ebs_options attribute.
    /// </summary>
    [TerraformPropertyName("ebs_options")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> EbsOptions => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "ebs_options");

    /// <summary>
    /// The encryption_at_rest attribute.
    /// </summary>
    [TerraformPropertyName("encryption_at_rest")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> EncryptionAtRest => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "encryption_at_rest");

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformPropertyName("endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Endpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "endpoint");

    /// <summary>
    /// The endpoint_v2 attribute.
    /// </summary>
    [TerraformPropertyName("endpoint_v2")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EndpointV2 => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "endpoint_v2");

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    [TerraformPropertyName("engine_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EngineVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "engine_version");

    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    [TerraformPropertyName("ip_address_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> IpAddressType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ip_address_type");

    /// <summary>
    /// The log_publishing_options attribute.
    /// </summary>
    [TerraformPropertyName("log_publishing_options")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<object>>> LogPublishingOptions => new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>(ResourceAddress, "log_publishing_options");

    /// <summary>
    /// The node_to_node_encryption attribute.
    /// </summary>
    [TerraformPropertyName("node_to_node_encryption")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> NodeToNodeEncryption => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "node_to_node_encryption");

    /// <summary>
    /// The processing attribute.
    /// </summary>
    [TerraformPropertyName("processing")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> Processing => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "processing");

    /// <summary>
    /// The snapshot_options attribute.
    /// </summary>
    [TerraformPropertyName("snapshot_options")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> SnapshotOptions => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "snapshot_options");

    /// <summary>
    /// The software_update_options attribute.
    /// </summary>
    [TerraformPropertyName("software_update_options")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> SoftwareUpdateOptions => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "software_update_options");

    /// <summary>
    /// The vpc_options attribute.
    /// </summary>
    [TerraformPropertyName("vpc_options")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> VpcOptions => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "vpc_options");

}
