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
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The region attribute.
    /// </summary>
    public TerraformProperty<string>? Region
    {
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        set => SetProperty("type", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformProperty<string>? Value
    {
        set => SetProperty("value", value);
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
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        set => SetProperty("type", value);
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
        SetOutput("json");
        SetOutput("id");
        SetOutput("record_type");
        SetOutput("start_endpoint");
        SetOutput("start_rule");
        SetOutput("version");
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
    /// The record_type attribute.
    /// </summary>
    public TerraformProperty<string> RecordType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("record_type");
        set => SetProperty("record_type", value);
    }

    /// <summary>
    /// The start_endpoint attribute.
    /// </summary>
    public TerraformProperty<string> StartEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("start_endpoint");
        set => SetProperty("start_endpoint", value);
    }

    /// <summary>
    /// The start_rule attribute.
    /// </summary>
    public TerraformProperty<string> StartRule
    {
        get => GetRequiredOutput<TerraformProperty<string>>("start_rule");
        set => SetProperty("start_rule", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformProperty<string> Version
    {
        get => GetRequiredOutput<TerraformProperty<string>>("version");
        set => SetProperty("version", value);
    }

    /// <summary>
    /// Block for endpoint.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsRoute53TrafficPolicyDocumentDataSourceEndpointBlock>? Endpoint
    {
        set => SetProperty("endpoint", value);
    }

    /// <summary>
    /// Block for rule.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsRoute53TrafficPolicyDocumentDataSourceRuleBlock>? Rule
    {
        set => SetProperty("rule", value);
    }

    /// <summary>
    /// The json attribute.
    /// </summary>
    public TerraformExpression Json => this["json"];

}
