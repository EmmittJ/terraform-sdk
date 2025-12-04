using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for hierarchy_structure in AwsConnectUserHierarchyStructure.
/// Nesting mode: list
/// </summary>
public class AwsConnectUserHierarchyStructureHierarchyStructureBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "hierarchy_structure";

    /// <summary>
    /// LevelFive block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LevelFive block(s) allowed")]
    public TerraformList<AwsConnectUserHierarchyStructureHierarchyStructureBlockLevelFiveBlock>? LevelFive
    {
        get => GetArgument<TerraformList<AwsConnectUserHierarchyStructureHierarchyStructureBlockLevelFiveBlock>>("level_five");
        set => SetArgument("level_five", value);
    }

    /// <summary>
    /// LevelFour block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LevelFour block(s) allowed")]
    public TerraformList<AwsConnectUserHierarchyStructureHierarchyStructureBlockLevelFourBlock>? LevelFour
    {
        get => GetArgument<TerraformList<AwsConnectUserHierarchyStructureHierarchyStructureBlockLevelFourBlock>>("level_four");
        set => SetArgument("level_four", value);
    }

    /// <summary>
    /// LevelOne block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LevelOne block(s) allowed")]
    public TerraformList<AwsConnectUserHierarchyStructureHierarchyStructureBlockLevelOneBlock>? LevelOne
    {
        get => GetArgument<TerraformList<AwsConnectUserHierarchyStructureHierarchyStructureBlockLevelOneBlock>>("level_one");
        set => SetArgument("level_one", value);
    }

    /// <summary>
    /// LevelThree block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LevelThree block(s) allowed")]
    public TerraformList<AwsConnectUserHierarchyStructureHierarchyStructureBlockLevelThreeBlock>? LevelThree
    {
        get => GetArgument<TerraformList<AwsConnectUserHierarchyStructureHierarchyStructureBlockLevelThreeBlock>>("level_three");
        set => SetArgument("level_three", value);
    }

    /// <summary>
    /// LevelTwo block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LevelTwo block(s) allowed")]
    public TerraformList<AwsConnectUserHierarchyStructureHierarchyStructureBlockLevelTwoBlock>? LevelTwo
    {
        get => GetArgument<TerraformList<AwsConnectUserHierarchyStructureHierarchyStructureBlockLevelTwoBlock>>("level_two");
        set => SetArgument("level_two", value);
    }

}

/// <summary>
/// Block type for level_five in AwsConnectUserHierarchyStructureHierarchyStructureBlock.
/// Nesting mode: list
/// </summary>
public class AwsConnectUserHierarchyStructureHierarchyStructureBlockLevelFiveBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "level_five";

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for level_four in AwsConnectUserHierarchyStructureHierarchyStructureBlock.
/// Nesting mode: list
/// </summary>
public class AwsConnectUserHierarchyStructureHierarchyStructureBlockLevelFourBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "level_four";

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for level_one in AwsConnectUserHierarchyStructureHierarchyStructureBlock.
/// Nesting mode: list
/// </summary>
public class AwsConnectUserHierarchyStructureHierarchyStructureBlockLevelOneBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "level_one";

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for level_three in AwsConnectUserHierarchyStructureHierarchyStructureBlock.
/// Nesting mode: list
/// </summary>
public class AwsConnectUserHierarchyStructureHierarchyStructureBlockLevelThreeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "level_three";

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for level_two in AwsConnectUserHierarchyStructureHierarchyStructureBlock.
/// Nesting mode: list
/// </summary>
public class AwsConnectUserHierarchyStructureHierarchyStructureBlockLevelTwoBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "level_two";

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}


/// <summary>
/// Represents a aws_connect_user_hierarchy_structure Terraform resource.
/// Manages a aws_connect_user_hierarchy_structure resource.
/// </summary>
public partial class AwsConnectUserHierarchyStructure(string name) : TerraformResource("aws_connect_user_hierarchy_structure", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceId is required")]
    public required TerraformValue<string> InstanceId
    {
        get => GetRequiredArgument<TerraformValue<string>>("instance_id");
        set => SetArgument("instance_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// HierarchyStructure block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HierarchyStructure is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 HierarchyStructure block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HierarchyStructure block(s) allowed")]
    public required TerraformList<AwsConnectUserHierarchyStructureHierarchyStructureBlock> HierarchyStructure
    {
        get => GetRequiredArgument<TerraformList<AwsConnectUserHierarchyStructureHierarchyStructureBlock>>("hierarchy_structure");
        set => SetArgument("hierarchy_structure", value);
    }

}
