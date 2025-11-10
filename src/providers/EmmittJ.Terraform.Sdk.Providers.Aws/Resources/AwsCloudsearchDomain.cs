using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for endpoint_options in .
/// Nesting mode: list
/// </summary>
public class AwsCloudsearchDomainEndpointOptionsBlock : ITerraformBlock
{
    /// <summary>
    /// The enforce_https attribute.
    /// </summary>
    [TerraformPropertyName("enforce_https")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> EnforceHttps { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>("", "enforce_https");

    /// <summary>
    /// The tls_security_policy attribute.
    /// </summary>
    [TerraformPropertyName("tls_security_policy")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> TlsSecurityPolicy { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "tls_security_policy");

}

/// <summary>
/// Block type for index_field in .
/// Nesting mode: set
/// </summary>
public class AwsCloudsearchDomainIndexFieldBlock : ITerraformBlock
{
    /// <summary>
    /// The analysis_scheme attribute.
    /// </summary>
    [TerraformPropertyName("analysis_scheme")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AnalysisScheme { get; set; }

    /// <summary>
    /// The default_value attribute.
    /// </summary>
    [TerraformPropertyName("default_value")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DefaultValue { get; set; }

    /// <summary>
    /// The facet attribute.
    /// </summary>
    [TerraformPropertyName("facet")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Facet { get; set; }

    /// <summary>
    /// The highlight attribute.
    /// </summary>
    [TerraformPropertyName("highlight")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Highlight { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The return attribute.
    /// </summary>
    [TerraformPropertyName("return")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Return { get; set; }

    /// <summary>
    /// The search attribute.
    /// </summary>
    [TerraformPropertyName("search")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Search { get; set; }

    /// <summary>
    /// The sort attribute.
    /// </summary>
    [TerraformPropertyName("sort")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Sort { get; set; }

    /// <summary>
    /// The source_fields attribute.
    /// </summary>
    [TerraformPropertyName("source_fields")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SourceFields { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

}

/// <summary>
/// Block type for scaling_parameters in .
/// Nesting mode: list
/// </summary>
public class AwsCloudsearchDomainScalingParametersBlock : ITerraformBlock
{
    /// <summary>
    /// The desired_instance_type attribute.
    /// </summary>
    [TerraformPropertyName("desired_instance_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DesiredInstanceType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "desired_instance_type");

    /// <summary>
    /// The desired_partition_count attribute.
    /// </summary>
    [TerraformPropertyName("desired_partition_count")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> DesiredPartitionCount { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "desired_partition_count");

    /// <summary>
    /// The desired_replication_count attribute.
    /// </summary>
    [TerraformPropertyName("desired_replication_count")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> DesiredReplicationCount { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "desired_replication_count");

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsCloudsearchDomainTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a aws_cloudsearch_domain resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsCloudsearchDomain : TerraformResource
{
    public AwsCloudsearchDomain(string name) : base("aws_cloudsearch_domain", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The multi_az attribute.
    /// </summary>
    [TerraformPropertyName("multi_az")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> MultiAz { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "multi_az");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// Block for endpoint_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EndpointOptions block(s) allowed")]
    [TerraformPropertyName("endpoint_options")]
    public TerraformList<TerraformBlock<AwsCloudsearchDomainEndpointOptionsBlock>>? EndpointOptions { get; set; } = new();

    /// <summary>
    /// Block for index_field.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("index_field")]
    public TerraformSet<TerraformBlock<AwsCloudsearchDomainIndexFieldBlock>>? IndexField { get; set; } = new();

    /// <summary>
    /// Block for scaling_parameters.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScalingParameters block(s) allowed")]
    [TerraformPropertyName("scaling_parameters")]
    public TerraformList<TerraformBlock<AwsCloudsearchDomainScalingParametersBlock>>? ScalingParameters { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsCloudsearchDomainTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The document_service_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("document_service_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DocumentServiceEndpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "document_service_endpoint");

    /// <summary>
    /// The domain_id attribute.
    /// </summary>
    [TerraformPropertyName("domain_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DomainId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "domain_id");

    /// <summary>
    /// The search_service_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("search_service_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SearchServiceEndpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "search_service_endpoint");

}
