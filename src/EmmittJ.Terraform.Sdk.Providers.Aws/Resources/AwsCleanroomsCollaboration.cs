using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cleanrooms_collaboration resource.
/// </summary>
public class AwsCleanroomsCollaboration : TerraformResource
{
    public AwsCleanroomsCollaboration(string name) : base("aws_cleanrooms_collaboration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("create_time");
        this.DeclareOutput("id");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// The analytics_engine attribute.
    /// </summary>
    public string? AnalyticsEngine
    {
        get => GetProperty<TerraformLiteralProperty<string>>("analytics_engine")?.Value;
        set => this.WithProperty("analytics_engine", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The creator_display_name attribute.
    /// </summary>
    public string? CreatorDisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("creator_display_name")?.Value;
        set => this.WithProperty("creator_display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The creator_member_abilities attribute.
    /// </summary>
    public List<string>? CreatorMemberAbilities
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("creator_member_abilities")?.Value;
        set => this.WithProperty("creator_member_abilities", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The query_log_status attribute.
    /// </summary>
    public string? QueryLogStatus
    {
        get => GetProperty<TerraformLiteralProperty<string>>("query_log_status")?.Value;
        set => this.WithProperty("query_log_status", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
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

    /// <summary>
    /// The create_time attribute.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The update_time attribute.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
