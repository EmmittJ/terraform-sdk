using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

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
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The record_type attribute.
    /// </summary>
    public string? RecordType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("record_type")?.Value;
        set => this.WithProperty("record_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The start_endpoint attribute.
    /// </summary>
    public string? StartEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("start_endpoint")?.Value;
        set => this.WithProperty("start_endpoint", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The start_rule attribute.
    /// </summary>
    public string? StartRule
    {
        get => GetProperty<TerraformLiteralProperty<string>>("start_rule")?.Value;
        set => this.WithProperty("start_rule", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public string? Version
    {
        get => GetProperty<TerraformLiteralProperty<string>>("version")?.Value;
        set => this.WithProperty("version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The json attribute.
    /// </summary>
    public TerraformExpression Json => this["json"];

}
