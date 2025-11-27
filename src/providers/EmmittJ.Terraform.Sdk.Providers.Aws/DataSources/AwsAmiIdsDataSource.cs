using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in AwsAmiIdsDataSource.
/// Nesting mode: set
/// </summary>
public class AwsAmiIdsDataSourceFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "filter";

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
    public required TerraformSet<string> ValuesAttribute
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "values").ResolveNodes(ctx));
        set => SetArgument("values", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsAmiIdsDataSource.
/// Nesting mode: single
/// </summary>
public class AwsAmiIdsDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a aws_ami_ids Terraform data source.
/// Retrieves information about a aws_ami_ids.
/// </summary>
public partial class AwsAmiIdsDataSource(string name) : TerraformDataSource("aws_ami_ids", name)
{
    /// <summary>
    /// The executable_users attribute.
    /// </summary>
    public TerraformList<string>? ExecutableUsers
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "executable_users").ResolveNodes(ctx));
        set => SetArgument("executable_users", value);
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
    /// The include_deprecated attribute.
    /// </summary>
    public TerraformValue<bool>? IncludeDeprecated
    {
        get => new TerraformReference<bool>(this, "include_deprecated");
        set => SetArgument("include_deprecated", value);
    }

    /// <summary>
    /// The name_regex attribute.
    /// </summary>
    public TerraformValue<string>? NameRegex
    {
        get => new TerraformReference<string>(this, "name_regex");
        set => SetArgument("name_regex", value);
    }

    /// <summary>
    /// The owners attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Owners is required")]
    public TerraformList<string>? Owners
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "owners").ResolveNodes(ctx));
        set => SetArgument("owners", value);
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
    /// The sort_ascending attribute.
    /// </summary>
    public TerraformValue<bool>? SortAscending
    {
        get => new TerraformReference<bool>(this, "sort_ascending");
        set => SetArgument("sort_ascending", value);
    }

    /// <summary>
    /// The ids attribute.
    /// </summary>
    public TerraformList<string> Ids
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "ids").ResolveNodes(ctx));
    }

    /// <summary>
    /// Filter block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsAmiIdsDataSourceFilterBlock>? Filter
    {
        get => GetArgument<TerraformSet<AwsAmiIdsDataSourceFilterBlock>>("filter");
        set => SetArgument("filter", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsAmiIdsDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsAmiIdsDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
