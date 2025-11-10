using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for endpoint_options in .
/// Nesting mode: list
/// </summary>
public class AwsCloudsearchDomainEndpointOptionsBlock : TerraformBlock
{
    /// <summary>
    /// The enforce_https attribute.
    /// </summary>
    public TerraformProperty<bool>? EnforceHttps
    {
        set => SetProperty("enforce_https", value);
    }

    /// <summary>
    /// The tls_security_policy attribute.
    /// </summary>
    public TerraformProperty<string>? TlsSecurityPolicy
    {
        set => SetProperty("tls_security_policy", value);
    }

}

/// <summary>
/// Block type for index_field in .
/// Nesting mode: set
/// </summary>
public class AwsCloudsearchDomainIndexFieldBlock : TerraformBlock
{
    /// <summary>
    /// The analysis_scheme attribute.
    /// </summary>
    public TerraformProperty<string>? AnalysisScheme
    {
        set => SetProperty("analysis_scheme", value);
    }

    /// <summary>
    /// The default_value attribute.
    /// </summary>
    public TerraformProperty<string>? DefaultValue
    {
        set => SetProperty("default_value", value);
    }

    /// <summary>
    /// The facet attribute.
    /// </summary>
    public TerraformProperty<bool>? Facet
    {
        set => SetProperty("facet", value);
    }

    /// <summary>
    /// The highlight attribute.
    /// </summary>
    public TerraformProperty<bool>? Highlight
    {
        set => SetProperty("highlight", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The return attribute.
    /// </summary>
    public TerraformProperty<bool>? Return
    {
        set => SetProperty("return", value);
    }

    /// <summary>
    /// The search attribute.
    /// </summary>
    public TerraformProperty<bool>? Search
    {
        set => SetProperty("search", value);
    }

    /// <summary>
    /// The sort attribute.
    /// </summary>
    public TerraformProperty<bool>? Sort
    {
        set => SetProperty("sort", value);
    }

    /// <summary>
    /// The source_fields attribute.
    /// </summary>
    public TerraformProperty<string>? SourceFields
    {
        set => SetProperty("source_fields", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
    }

}

/// <summary>
/// Block type for scaling_parameters in .
/// Nesting mode: list
/// </summary>
public class AwsCloudsearchDomainScalingParametersBlock : TerraformBlock
{
    /// <summary>
    /// The desired_instance_type attribute.
    /// </summary>
    public TerraformProperty<string>? DesiredInstanceType
    {
        set => SetProperty("desired_instance_type", value);
    }

    /// <summary>
    /// The desired_partition_count attribute.
    /// </summary>
    public TerraformProperty<double>? DesiredPartitionCount
    {
        set => SetProperty("desired_partition_count", value);
    }

    /// <summary>
    /// The desired_replication_count attribute.
    /// </summary>
    public TerraformProperty<double>? DesiredReplicationCount
    {
        set => SetProperty("desired_replication_count", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsCloudsearchDomainTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_cloudsearch_domain resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsCloudsearchDomain : TerraformResource
{
    public AwsCloudsearchDomain(string name) : base("aws_cloudsearch_domain", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("document_service_endpoint");
        SetOutput("domain_id");
        SetOutput("search_service_endpoint");
        SetOutput("id");
        SetOutput("multi_az");
        SetOutput("name");
        SetOutput("region");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The multi_az attribute.
    /// </summary>
    public TerraformProperty<bool> MultiAz
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("multi_az");
        set => SetProperty("multi_az", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
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
    /// Block for endpoint_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EndpointOptions block(s) allowed")]
    public List<AwsCloudsearchDomainEndpointOptionsBlock>? EndpointOptions
    {
        set => SetProperty("endpoint_options", value);
    }

    /// <summary>
    /// Block for index_field.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsCloudsearchDomainIndexFieldBlock>? IndexField
    {
        set => SetProperty("index_field", value);
    }

    /// <summary>
    /// Block for scaling_parameters.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScalingParameters block(s) allowed")]
    public List<AwsCloudsearchDomainScalingParametersBlock>? ScalingParameters
    {
        set => SetProperty("scaling_parameters", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsCloudsearchDomainTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The document_service_endpoint attribute.
    /// </summary>
    public TerraformExpression DocumentServiceEndpoint => this["document_service_endpoint"];

    /// <summary>
    /// The domain_id attribute.
    /// </summary>
    public TerraformExpression DomainId => this["domain_id"];

    /// <summary>
    /// The search_service_endpoint attribute.
    /// </summary>
    public TerraformExpression SearchServiceEndpoint => this["search_service_endpoint"];

}
