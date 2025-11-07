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
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The record_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RecordType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("record_type");
        set => this.WithProperty("record_type", value);
    }

    /// <summary>
    /// The start_endpoint attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? StartEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("start_endpoint");
        set => this.WithProperty("start_endpoint", value);
    }

    /// <summary>
    /// The start_rule attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? StartRule
    {
        get => GetProperty<TerraformLiteralProperty<string>>("start_rule");
        set => this.WithProperty("start_rule", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Version
    {
        get => GetProperty<TerraformLiteralProperty<string>>("version");
        set => this.WithProperty("version", value);
    }

    /// <summary>
    /// The json attribute.
    /// </summary>
    public TerraformExpression Json => this["json"];

}
