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
    public TerraformLiteralProperty<string>? HubDescription
    {
        get => GetProperty<TerraformLiteralProperty<string>>("hub_description");
        set => this.WithProperty("hub_description", value);
    }

    /// <summary>
    /// The hub_display_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? HubDisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("hub_display_name");
        set => this.WithProperty("hub_display_name", value);
    }

    /// <summary>
    /// The hub_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? HubName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("hub_name");
        set => this.WithProperty("hub_name", value);
    }

    /// <summary>
    /// The hub_search_keywords attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? HubSearchKeywords
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("hub_search_keywords");
        set => this.WithProperty("hub_search_keywords", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
