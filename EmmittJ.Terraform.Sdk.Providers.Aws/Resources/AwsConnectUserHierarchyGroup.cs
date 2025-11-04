using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_connect_user_hierarchy_group resource.
/// </summary>
public class AwsConnectUserHierarchyGroup : TerraformResource
{
    public AwsConnectUserHierarchyGroup(string name) : base("aws_connect_user_hierarchy_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("hierarchy_group_id");
        this.DeclareOutput("hierarchy_path");
        this.DeclareOutput("level_id");
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
    /// The instance_id attribute.
    /// </summary>
    public string? InstanceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("instance_id")?.Value;
        set => this.WithProperty("instance_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The parent_group_id attribute.
    /// </summary>
    public string? ParentGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("parent_group_id")?.Value;
        set => this.WithProperty("parent_group_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The hierarchy_group_id attribute.
    /// </summary>
    public TerraformExpression HierarchyGroupId => this["hierarchy_group_id"];

    /// <summary>
    /// The hierarchy_path attribute.
    /// </summary>
    public TerraformExpression HierarchyPath => this["hierarchy_path"];

    /// <summary>
    /// The level_id attribute.
    /// </summary>
    public TerraformExpression LevelId => this["level_id"];

}
