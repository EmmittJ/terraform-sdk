using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for endpoint in .
/// Nesting mode: set
/// </summary>
public class AwsRoute53TrafficPolicyDocumentDataSourceEndpointBlock : TerraformBlock
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformProperty<string> Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => WithProperty("id", value);
    }

    /// <summary>
    /// The region attribute.
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => WithProperty("region", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformProperty<string>? Value
    {
        get => GetProperty<TerraformProperty<string>>("value");
        set => WithProperty("value", value);
    }

}

/// <summary>
/// Block type for rule in .
/// Nesting mode: set
/// </summary>
public class AwsRoute53TrafficPolicyDocumentDataSourceRuleBlock : TerraformBlock
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformProperty<string> Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => WithProperty("id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Retrieves information about a aws_route53_traffic_policy_document.
/// </summary>
public class AwsRoute53TrafficPolicyDocumentDataSource : TerraformDataSource
{
    public AwsRoute53TrafficPolicyDocumentDataSource(string name) : base("aws_route53_traffic_policy_document", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("json");
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
    /// The record_type attribute.
    /// </summary>
    public TerraformProperty<string>? RecordType
    {
        get => GetProperty<TerraformProperty<string>>("record_type");
        set => this.WithProperty("record_type", value);
    }

    /// <summary>
    /// The start_endpoint attribute.
    /// </summary>
    public TerraformProperty<string>? StartEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("start_endpoint");
        set => this.WithProperty("start_endpoint", value);
    }

    /// <summary>
    /// The start_rule attribute.
    /// </summary>
    public TerraformProperty<string>? StartRule
    {
        get => GetProperty<TerraformProperty<string>>("start_rule");
        set => this.WithProperty("start_rule", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformProperty<string>? Version
    {
        get => GetProperty<TerraformProperty<string>>("version");
        set => this.WithProperty("version", value);
    }

    /// <summary>
    /// Block for endpoint.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsRoute53TrafficPolicyDocumentDataSourceEndpointBlock>? Endpoint
    {
        get => GetProperty<HashSet<AwsRoute53TrafficPolicyDocumentDataSourceEndpointBlock>>("endpoint");
        set => this.WithProperty("endpoint", value);
    }

    /// <summary>
    /// Block for rule.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsRoute53TrafficPolicyDocumentDataSourceRuleBlock>? Rule
    {
        get => GetProperty<HashSet<AwsRoute53TrafficPolicyDocumentDataSourceRuleBlock>>("rule");
        set => this.WithProperty("rule", value);
    }

    /// <summary>
    /// The json attribute.
    /// </summary>
    public TerraformExpression Json => this["json"];

}
