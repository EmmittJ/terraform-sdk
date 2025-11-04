using EmmittJ.Terraform.Sdk.Resources;
using EmmittJ.Terraform.Sdk.Context;

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
        get => GetProperty<TerraformLiteralProperty&lt;string&gt;>("analyzer_name")?.Value;
        set => WithPropertyInternal("analyzer_name", value == null ? null : new TerraformLiteralProperty&lt;string&gt;(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty&lt;string&gt;>("id")?.Value;
        set => WithPropertyInternal("id", value == null ? null : new TerraformLiteralProperty&lt;string&gt;(value));
    }

    /// <summary>
    /// The rule_name attribute.
    /// </summary>
    public string? RuleName
    {
        get => GetProperty<TerraformLiteralProperty&lt;string&gt;>("rule_name")?.Value;
        set => WithPropertyInternal("rule_name", value == null ? null : new TerraformLiteralProperty&lt;string&gt;(value));
    }

}
