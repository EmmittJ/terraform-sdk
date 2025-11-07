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
    public TerraformLiteralProperty<string>? AnalyticsEngine
    {
        get => GetProperty<TerraformLiteralProperty<string>>("analytics_engine");
        set => this.WithProperty("analytics_engine", value);
    }

    /// <summary>
    /// The creator_display_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CreatorDisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("creator_display_name");
        set => this.WithProperty("creator_display_name", value);
    }

    /// <summary>
    /// The creator_member_abilities attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? CreatorMemberAbilities
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("creator_member_abilities");
        set => this.WithProperty("creator_member_abilities", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The query_log_status attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? QueryLogStatus
    {
        get => GetProperty<TerraformLiteralProperty<string>>("query_log_status");
        set => this.WithProperty("query_log_status", value);
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
