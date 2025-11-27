using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for configuration in AwsResourcegroupsGroup.
/// Nesting mode: set
/// </summary>
public class AwsResourcegroupsGroupConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "configuration";

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// Parameters block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsResourcegroupsGroupConfigurationBlockParametersBlock>? Parameters
    {
        get => GetArgument<TerraformSet<AwsResourcegroupsGroupConfigurationBlockParametersBlock>>("parameters");
        set => SetArgument("parameters", value);
    }

}

/// <summary>
/// Block type for parameters in AwsResourcegroupsGroupConfigurationBlock.
/// Nesting mode: set
/// </summary>
public class AwsResourcegroupsGroupConfigurationBlockParametersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "parameters";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public TerraformList<string>? ValuesAttribute
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "values").ResolveNodes(ctx));
        set => SetArgument("values", value);
    }

}


/// <summary>
/// Block type for resource_query in AwsResourcegroupsGroup.
/// Nesting mode: list
/// </summary>
public class AwsResourcegroupsGroupResourceQueryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "resource_query";

    /// <summary>
    /// The query attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Query is required")]
    public required TerraformValue<string> Query
    {
        get => new TerraformReference<string>(this, "query");
        set => SetArgument("query", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsResourcegroupsGroup.
/// Nesting mode: single
/// </summary>
public class AwsResourcegroupsGroupTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_resourcegroups_group Terraform resource.
/// Manages a aws_resourcegroups_group resource.
/// </summary>
public partial class AwsResourcegroupsGroup(string name) : TerraformResource("aws_resourcegroups_group", name)
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
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
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// Configuration block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsResourcegroupsGroupConfigurationBlock>? Configuration
    {
        get => GetArgument<TerraformSet<AwsResourcegroupsGroupConfigurationBlock>>("configuration");
        set => SetArgument("configuration", value);
    }

    /// <summary>
    /// ResourceQuery block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ResourceQuery block(s) allowed")]
    public TerraformList<AwsResourcegroupsGroupResourceQueryBlock>? ResourceQuery
    {
        get => GetArgument<TerraformList<AwsResourcegroupsGroupResourceQueryBlock>>("resource_query");
        set => SetArgument("resource_query", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsResourcegroupsGroupTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsResourcegroupsGroupTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
