using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for endpoint_options in .
/// Nesting mode: list
/// </summary>
public partial class AwsCloudsearchDomainEndpointOptionsBlock : TerraformBlockBase
{
    /// <summary>
    /// The enforce_https attribute.
    /// </summary>
    [TerraformProperty("enforce_https")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> EnforceHttps { get; set; }

    /// <summary>
    /// The tls_security_policy attribute.
    /// </summary>
    [TerraformProperty("tls_security_policy")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> TlsSecurityPolicy { get; set; }

}

/// <summary>
/// Block type for index_field in .
/// Nesting mode: set
/// </summary>
public partial class AwsCloudsearchDomainIndexFieldBlock : TerraformBlockBase
{
    /// <summary>
    /// The analysis_scheme attribute.
    /// </summary>
    [TerraformProperty("analysis_scheme")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? AnalysisScheme { get; set; }

    /// <summary>
    /// The default_value attribute.
    /// </summary>
    [TerraformProperty("default_value")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DefaultValue { get; set; }

    /// <summary>
    /// The facet attribute.
    /// </summary>
    [TerraformProperty("facet")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Facet { get; set; }

    /// <summary>
    /// The highlight attribute.
    /// </summary>
    [TerraformProperty("highlight")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Highlight { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The return attribute.
    /// </summary>
    [TerraformProperty("return")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Return { get; set; }

    /// <summary>
    /// The search attribute.
    /// </summary>
    [TerraformProperty("search")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Search { get; set; }

    /// <summary>
    /// The sort attribute.
    /// </summary>
    [TerraformProperty("sort")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Sort { get; set; }

    /// <summary>
    /// The source_fields attribute.
    /// </summary>
    [TerraformProperty("source_fields")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SourceFields { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for scaling_parameters in .
/// Nesting mode: list
/// </summary>
public partial class AwsCloudsearchDomainScalingParametersBlock : TerraformBlockBase
{
    /// <summary>
    /// The desired_instance_type attribute.
    /// </summary>
    [TerraformProperty("desired_instance_type")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> DesiredInstanceType { get; set; }

    /// <summary>
    /// The desired_partition_count attribute.
    /// </summary>
    [TerraformProperty("desired_partition_count")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> DesiredPartitionCount { get; set; }

    /// <summary>
    /// The desired_replication_count attribute.
    /// </summary>
    [TerraformProperty("desired_replication_count")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> DesiredReplicationCount { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsCloudsearchDomainTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_cloudsearch_domain resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsCloudsearchDomain : TerraformResource
{
    public AwsCloudsearchDomain(string name) : base("aws_cloudsearch_domain", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The multi_az attribute.
    /// </summary>
    [TerraformProperty("multi_az")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> MultiAz { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for endpoint_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EndpointOptions block(s) allowed")]
    [TerraformProperty("endpoint_options")]
    public TerraformList<TerraformBlock<AwsCloudsearchDomainEndpointOptionsBlock>>? EndpointOptions { get; set; }

    /// <summary>
    /// Block for index_field.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("index_field")]
    public TerraformSet<TerraformBlock<AwsCloudsearchDomainIndexFieldBlock>>? IndexField { get; set; }

    /// <summary>
    /// Block for scaling_parameters.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScalingParameters block(s) allowed")]
    [TerraformProperty("scaling_parameters")]
    public TerraformList<TerraformBlock<AwsCloudsearchDomainScalingParametersBlock>>? ScalingParameters { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AwsCloudsearchDomainTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The document_service_endpoint attribute.
    /// </summary>
    [TerraformProperty("document_service_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DocumentServiceEndpoint { get; }

    /// <summary>
    /// The domain_id attribute.
    /// </summary>
    [TerraformProperty("domain_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DomainId { get; }

    /// <summary>
    /// The search_service_endpoint attribute.
    /// </summary>
    [TerraformProperty("search_service_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SearchServiceEndpoint { get; }

}
