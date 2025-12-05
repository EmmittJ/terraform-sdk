using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for endpoint_options in AwsCloudsearchDomain.
/// Nesting mode: list
/// </summary>
public class AwsCloudsearchDomainEndpointOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "endpoint_options";

    /// <summary>
    /// The enforce_https attribute.
    /// </summary>
    public TerraformValue<bool> EnforceHttps
    {
        get => GetArgument<TerraformValue<bool>>("enforce_https") ?? CreateReference("enforce_https");
        set => SetArgument("enforce_https", value);
    }

    /// <summary>
    /// The tls_security_policy attribute.
    /// </summary>
    public TerraformValue<string> TlsSecurityPolicy
    {
        get => GetArgument<TerraformValue<string>>("tls_security_policy") ?? CreateReference("tls_security_policy");
        set => SetArgument("tls_security_policy", value);
    }

}


/// <summary>
/// Block type for index_field in AwsCloudsearchDomain.
/// Nesting mode: set
/// </summary>
public class AwsCloudsearchDomainIndexFieldBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "index_field";

    /// <summary>
    /// The analysis_scheme attribute.
    /// </summary>
    public TerraformValue<string>? AnalysisScheme
    {
        get => GetArgument<TerraformValue<string>>("analysis_scheme");
        set => SetArgument("analysis_scheme", value);
    }

    /// <summary>
    /// The default_value attribute.
    /// </summary>
    public TerraformValue<string>? DefaultValue
    {
        get => GetArgument<TerraformValue<string>>("default_value");
        set => SetArgument("default_value", value);
    }

    /// <summary>
    /// The facet attribute.
    /// </summary>
    public TerraformValue<bool>? Facet
    {
        get => GetArgument<TerraformValue<bool>>("facet");
        set => SetArgument("facet", value);
    }

    /// <summary>
    /// The highlight attribute.
    /// </summary>
    public TerraformValue<bool>? Highlight
    {
        get => GetArgument<TerraformValue<bool>>("highlight");
        set => SetArgument("highlight", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The return attribute.
    /// </summary>
    public TerraformValue<bool>? ReturnAttribute
    {
        get => GetArgument<TerraformValue<bool>>("return");
        set => SetArgument("return", value);
    }

    /// <summary>
    /// The search attribute.
    /// </summary>
    public TerraformValue<bool>? Search
    {
        get => GetArgument<TerraformValue<bool>>("search");
        set => SetArgument("search", value);
    }

    /// <summary>
    /// The sort attribute.
    /// </summary>
    public TerraformValue<bool>? Sort
    {
        get => GetArgument<TerraformValue<bool>>("sort");
        set => SetArgument("sort", value);
    }

    /// <summary>
    /// The source_fields attribute.
    /// </summary>
    public TerraformValue<string>? SourceFields
    {
        get => GetArgument<TerraformValue<string>>("source_fields");
        set => SetArgument("source_fields", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for scaling_parameters in AwsCloudsearchDomain.
/// Nesting mode: list
/// </summary>
public class AwsCloudsearchDomainScalingParametersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "scaling_parameters";

    /// <summary>
    /// The desired_instance_type attribute.
    /// </summary>
    public TerraformValue<string> DesiredInstanceType
    {
        get => GetArgument<TerraformValue<string>>("desired_instance_type") ?? CreateReference("desired_instance_type");
        set => SetArgument("desired_instance_type", value);
    }

    /// <summary>
    /// The desired_partition_count attribute.
    /// </summary>
    public TerraformValue<double> DesiredPartitionCount
    {
        get => GetArgument<TerraformValue<double>>("desired_partition_count") ?? CreateReference("desired_partition_count");
        set => SetArgument("desired_partition_count", value);
    }

    /// <summary>
    /// The desired_replication_count attribute.
    /// </summary>
    public TerraformValue<double> DesiredReplicationCount
    {
        get => GetArgument<TerraformValue<double>>("desired_replication_count") ?? CreateReference("desired_replication_count");
        set => SetArgument("desired_replication_count", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsCloudsearchDomain.
/// Nesting mode: single
/// </summary>
public class AwsCloudsearchDomainTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_cloudsearch_domain Terraform resource.
/// Manages a aws_cloudsearch_domain resource.
/// </summary>
public partial class AwsCloudsearchDomain(string name) : TerraformResource("aws_cloudsearch_domain", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The multi_az attribute.
    /// </summary>
    public TerraformValue<bool> MultiAz
    {
        get => GetArgument<TerraformValue<bool>>("multi_az") ?? CreateReference("multi_az");
        set => SetArgument("multi_az", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The document_service_endpoint attribute.
    /// </summary>
    public TerraformValue<string> DocumentServiceEndpoint
        => CreateReference("document_service_endpoint");

    /// <summary>
    /// The domain_id attribute.
    /// </summary>
    public TerraformValue<string> DomainId
        => CreateReference("domain_id");

    /// <summary>
    /// The search_service_endpoint attribute.
    /// </summary>
    public TerraformValue<string> SearchServiceEndpoint
        => CreateReference("search_service_endpoint");

    /// <summary>
    /// EndpointOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EndpointOptions block(s) allowed")]
    public TerraformList<AwsCloudsearchDomainEndpointOptionsBlock>? EndpointOptions
    {
        get => GetArgument<TerraformList<AwsCloudsearchDomainEndpointOptionsBlock>>("endpoint_options");
        set => SetArgument("endpoint_options", value);
    }

    /// <summary>
    /// IndexField block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsCloudsearchDomainIndexFieldBlock>? IndexField
    {
        get => GetArgument<TerraformSet<AwsCloudsearchDomainIndexFieldBlock>>("index_field");
        set => SetArgument("index_field", value);
    }

    /// <summary>
    /// ScalingParameters block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScalingParameters block(s) allowed")]
    public TerraformList<AwsCloudsearchDomainScalingParametersBlock>? ScalingParameters
    {
        get => GetArgument<TerraformList<AwsCloudsearchDomainScalingParametersBlock>>("scaling_parameters");
        set => SetArgument("scaling_parameters", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsCloudsearchDomainTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsCloudsearchDomainTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
