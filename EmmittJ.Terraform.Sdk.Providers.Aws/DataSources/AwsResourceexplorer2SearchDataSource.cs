using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_resourceexplorer2_search.
/// </summary>
public class AwsResourceexplorer2SearchDataSource : TerraformDataSource
{
    public AwsResourceexplorer2SearchDataSource(string name) : base("aws_resourceexplorer2_search", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("id");
        this.DeclareOutput("resource_count");
        this.DeclareOutput("resources");
    }

    /// <summary>
    /// The query_string attribute.
    /// </summary>
    public string? QueryString
    {
        get => GetProperty<TerraformLiteralProperty<string>>("query_string")?.Value;
        set => this.WithProperty("query_string", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The view_arn attribute.
    /// </summary>
    public string? ViewArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("view_arn")?.Value;
        set => this.WithProperty("view_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The resource_count attribute.
    /// </summary>
    public TerraformExpression ResourceCount => this["resource_count"];

    /// <summary>
    /// The resources attribute.
    /// </summary>
    public TerraformExpression Resources => this["resources"];

}
