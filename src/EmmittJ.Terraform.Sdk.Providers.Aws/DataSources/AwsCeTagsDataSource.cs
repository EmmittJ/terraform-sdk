using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ce_tags.
/// </summary>
public class AwsCeTagsDataSource : TerraformDataSource
{
    public AwsCeTagsDataSource(string name) : base("aws_ce_tags", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("tags");
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
    /// The search_string attribute.
    /// </summary>
    public string? SearchString
    {
        get => GetProperty<TerraformLiteralProperty<string>>("search_string")?.Value;
        set => this.WithProperty("search_string", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tag_key attribute.
    /// </summary>
    public string? TagKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tag_key")?.Value;
        set => this.WithProperty("tag_key", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

}
