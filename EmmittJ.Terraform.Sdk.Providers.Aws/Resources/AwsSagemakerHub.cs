using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_sagemaker_hub resource.
/// </summary>
public class AwsSagemakerHub : TerraformResource
{
    public AwsSagemakerHub(string name) : base("aws_sagemaker_hub", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The hub_description attribute.
    /// </summary>
    public string? HubDescription
    {
        get => GetProperty<TerraformLiteralProperty<string>>("hub_description")?.Value;
        set => this.WithProperty("hub_description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The hub_display_name attribute.
    /// </summary>
    public string? HubDisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("hub_display_name")?.Value;
        set => this.WithProperty("hub_display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The hub_name attribute.
    /// </summary>
    public string? HubName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("hub_name")?.Value;
        set => this.WithProperty("hub_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The hub_search_keywords attribute.
    /// </summary>
    public HashSet<string>? HubSearchKeywords
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("hub_search_keywords")?.Value;
        set => this.WithProperty("hub_search_keywords", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
