using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_accessanalyzer_archive_rule resource.
/// </summary>
public class AwsAccessanalyzerArchiveRule : TerraformResource
{
    public AwsAccessanalyzerArchiveRule(string name) : base("aws_accessanalyzer_archive_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The analyzer_name attribute.
    /// </summary>
    public string? AnalyzerName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("analyzer_name")?.Value;
        set => this.WithProperty("analyzer_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The rule_name attribute.
    /// </summary>
    public string? RuleName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("rule_name")?.Value;
        set => this.WithProperty("rule_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
