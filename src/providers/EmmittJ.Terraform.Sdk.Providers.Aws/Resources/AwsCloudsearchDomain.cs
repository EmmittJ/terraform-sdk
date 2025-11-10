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
        get => GetProperty<TerraformProperty<bool>>("enforce_https");
        set => WithProperty("enforce_https", value);
    }

    /// <summary>
    /// The tls_security_policy attribute.
    /// </summary>
    public TerraformProperty<string>? TlsSecurityPolicy
    {
        get => GetProperty<TerraformProperty<string>>("tls_security_policy");
        set => WithProperty("tls_security_policy", value);
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
        get => GetProperty<TerraformProperty<string>>("analysis_scheme");
        set => WithProperty("analysis_scheme", value);
    }

    /// <summary>
    /// The default_value attribute.
    /// </summary>
    public TerraformProperty<string>? DefaultValue
    {
        get => GetProperty<TerraformProperty<string>>("default_value");
        set => WithProperty("default_value", value);
    }

    /// <summary>
    /// The facet attribute.
    /// </summary>
    public TerraformProperty<bool>? Facet
    {
        get => GetProperty<TerraformProperty<bool>>("facet");
        set => WithProperty("facet", value);
    }

    /// <summary>
    /// The highlight attribute.
    /// </summary>
    public TerraformProperty<bool>? Highlight
    {
        get => GetProperty<TerraformProperty<bool>>("highlight");
        set => WithProperty("highlight", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The return attribute.
    /// </summary>
    public TerraformProperty<bool>? Return
    {
        get => GetProperty<TerraformProperty<bool>>("return");
        set => WithProperty("return", value);
    }

    /// <summary>
    /// The search attribute.
    /// </summary>
    public TerraformProperty<bool>? Search
    {
        get => GetProperty<TerraformProperty<bool>>("search");
        set => WithProperty("search", value);
    }

    /// <summary>
    /// The sort attribute.
    /// </summary>
    public TerraformProperty<bool>? Sort
    {
        get => GetProperty<TerraformProperty<bool>>("sort");
        set => WithProperty("sort", value);
    }

    /// <summary>
    /// The source_fields attribute.
    /// </summary>
    public TerraformProperty<string>? SourceFields
    {
        get => GetProperty<TerraformProperty<string>>("source_fields");
        set => WithProperty("source_fields", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetRequiredProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
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
        get => GetProperty<TerraformProperty<string>>("desired_instance_type");
        set => WithProperty("desired_instance_type", value);
    }

    /// <summary>
    /// The desired_partition_count attribute.
    /// </summary>
    public TerraformProperty<double>? DesiredPartitionCount
    {
        get => GetProperty<TerraformProperty<double>>("desired_partition_count");
        set => WithProperty("desired_partition_count", value);
    }

    /// <summary>
    /// The desired_replication_count attribute.
    /// </summary>
    public TerraformProperty<double>? DesiredReplicationCount
    {
        get => GetProperty<TerraformProperty<double>>("desired_replication_count");
        set => WithProperty("desired_replication_count", value);
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
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
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
        this.WithOutput("arn");
        this.WithOutput("document_service_endpoint");
        this.WithOutput("domain_id");
        this.WithOutput("search_service_endpoint");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The multi_az attribute.
    /// </summary>
    public TerraformProperty<bool>? MultiAz
    {
        get => GetProperty<TerraformProperty<bool>>("multi_az");
        set => this.WithProperty("multi_az", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// Block for endpoint_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EndpointOptions block(s) allowed")]
    public List<AwsCloudsearchDomainEndpointOptionsBlock>? EndpointOptions
    {
        get => GetProperty<List<AwsCloudsearchDomainEndpointOptionsBlock>>("endpoint_options");
        set => this.WithProperty("endpoint_options", value);
    }

    /// <summary>
    /// Block for index_field.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsCloudsearchDomainIndexFieldBlock>? IndexField
    {
        get => GetProperty<HashSet<AwsCloudsearchDomainIndexFieldBlock>>("index_field");
        set => this.WithProperty("index_field", value);
    }

    /// <summary>
    /// Block for scaling_parameters.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScalingParameters block(s) allowed")]
    public List<AwsCloudsearchDomainScalingParametersBlock>? ScalingParameters
    {
        get => GetProperty<List<AwsCloudsearchDomainScalingParametersBlock>>("scaling_parameters");
        set => this.WithProperty("scaling_parameters", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsCloudsearchDomainTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsCloudsearchDomainTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
