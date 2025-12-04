using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_connect_user_hierarchy_group Terraform resource.
/// Manages a aws_connect_user_hierarchy_group resource.
/// </summary>
public partial class AwsConnectUserHierarchyGroup(string name) : TerraformResource("aws_connect_user_hierarchy_group", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceId is required")]
    public required TerraformValue<string> InstanceId
    {
        get => GetArgument<TerraformValue<string>>("instance_id");
        set => SetArgument("instance_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The parent_group_id attribute.
    /// </summary>
    public TerraformValue<string>? ParentGroupId
    {
        get => GetArgument<TerraformValue<string>>("parent_group_id");
        set => SetArgument("parent_group_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string>? TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The hierarchy_group_id attribute.
    /// </summary>
    public TerraformValue<string> HierarchyGroupId
        => AsReference("hierarchy_group_id");

    /// <summary>
    /// The hierarchy_path attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> HierarchyPath
        => AsReference("hierarchy_path");

    /// <summary>
    /// The level_id attribute.
    /// </summary>
    public TerraformValue<string> LevelId
        => AsReference("level_id");

}
