using EmmittJ.Terraform.Sdk.Resources;
using EmmittJ.Terraform.Sdk.Context;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_accessanalyzer_analyzer resource.
/// </summary>
public class AwsAccessanalyzerAnalyzer : TerraformResource
{
    public AwsAccessanalyzerAnalyzer(string name) : base("aws_accessanalyzer_analyzer", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        DeclareOutput("arn");
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
    /// The tags attribute.
    /// </summary>
    public Dictionary&lt;string, string&gt;? Tags
    {
        get => GetProperty<TerraformLiteralProperty&lt;Dictionary&lt;string, string&gt;&gt;>("tags")?.Value;
        set => WithPropertyInternal("tags", value == null ? null : new TerraformLiteralProperty&lt;Dictionary&lt;string, string&gt;&gt;(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary&lt;string, string&gt;? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty&lt;Dictionary&lt;string, string&gt;&gt;>("tags_all")?.Value;
        set => WithPropertyInternal("tags_all", value == null ? null : new TerraformLiteralProperty&lt;Dictionary&lt;string, string&gt;&gt;(value));
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public string? Type
    {
        get => GetProperty<TerraformLiteralProperty&lt;string&gt;>("type")?.Value;
        set => WithPropertyInternal("type", value == null ? null : new TerraformLiteralProperty&lt;string&gt;(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
