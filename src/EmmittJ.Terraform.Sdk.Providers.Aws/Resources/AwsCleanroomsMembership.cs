using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cleanrooms_membership resource.
/// </summary>
public class AwsCleanroomsMembership : TerraformResource
{
    public AwsCleanroomsMembership(string name) : base("aws_cleanrooms_membership", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("collaboration_arn");
        this.DeclareOutput("collaboration_creator_account_id");
        this.DeclareOutput("collaboration_creator_display_name");
        this.DeclareOutput("collaboration_name");
        this.DeclareOutput("create_time");
        this.DeclareOutput("id");
        this.DeclareOutput("member_abilities");
        this.DeclareOutput("status");
        this.DeclareOutput("tags_all");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// The collaboration_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CollaborationId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("collaboration_id");
        set => this.WithProperty("collaboration_id", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The collaboration_arn attribute.
    /// </summary>
    public TerraformExpression CollaborationArn => this["collaboration_arn"];

    /// <summary>
    /// The collaboration_creator_account_id attribute.
    /// </summary>
    public TerraformExpression CollaborationCreatorAccountId => this["collaboration_creator_account_id"];

    /// <summary>
    /// The collaboration_creator_display_name attribute.
    /// </summary>
    public TerraformExpression CollaborationCreatorDisplayName => this["collaboration_creator_display_name"];

    /// <summary>
    /// The collaboration_name attribute.
    /// </summary>
    public TerraformExpression CollaborationName => this["collaboration_name"];

    /// <summary>
    /// The create_time attribute.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The member_abilities attribute.
    /// </summary>
    public TerraformExpression MemberAbilities => this["member_abilities"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

    /// <summary>
    /// The update_time attribute.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
