using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_connect_user_hierarchy_group Terraform data source.
/// Retrieves information about a aws_connect_user_hierarchy_group.
/// </summary>
public partial class AwsConnectUserHierarchyGroupDataSource(string name) : TerraformDataSource("aws_connect_user_hierarchy_group", name)
{
    /// <summary>
    /// The hierarchy_group_id attribute.
    /// </summary>
    public TerraformValue<string> HierarchyGroupId
    {
        get => new TerraformReference<string>(this, "hierarchy_group_id");
        set => SetArgument("hierarchy_group_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceId is required")]
    public required TerraformValue<string> InstanceId
    {
        get => new TerraformReference<string>(this, "instance_id");
        set => SetArgument("instance_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The hierarchy_path attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> HierarchyPath
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "hierarchy_path").ResolveNodes(ctx));
    }

    /// <summary>
    /// The level_id attribute.
    /// </summary>
    public TerraformValue<string> LevelId
    {
        get => new TerraformReference<string>(this, "level_id");
    }

}
