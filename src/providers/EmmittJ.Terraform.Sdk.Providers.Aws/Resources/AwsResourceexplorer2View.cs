using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filters in AwsResourceexplorer2View.
/// Nesting mode: list
/// </summary>
public class AwsResourceexplorer2ViewFiltersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "filters";

    /// <summary>
    /// The filter_string attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FilterString is required")]
    public required TerraformValue<string> FilterString
    {
        get => new TerraformReference<string>(this, "filter_string");
        set => SetArgument("filter_string", value);
    }

}


/// <summary>
/// Block type for included_property in AwsResourceexplorer2View.
/// Nesting mode: list
/// </summary>
public class AwsResourceexplorer2ViewIncludedPropertyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "included_property";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

}


/// <summary>
/// Represents a aws_resourceexplorer2_view Terraform resource.
/// Manages a aws_resourceexplorer2_view resource.
/// </summary>
public partial class AwsResourceexplorer2View(string name) : TerraformResource("aws_resourceexplorer2_view", name)
{
    /// <summary>
    /// The default_view attribute.
    /// </summary>
    public TerraformValue<bool> DefaultView
    {
        get => new TerraformReference<bool>(this, "default_view");
        set => SetArgument("default_view", value);
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
    /// The scope attribute.
    /// </summary>
    public TerraformValue<string> Scope
    {
        get => new TerraformReference<string>(this, "scope");
        set => SetArgument("scope", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
    }

    /// <summary>
    /// Filters block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsResourceexplorer2ViewFiltersBlock>? Filters
    {
        get => GetArgument<TerraformList<AwsResourceexplorer2ViewFiltersBlock>>("filters");
        set => SetArgument("filters", value);
    }

    /// <summary>
    /// IncludedProperty block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsResourceexplorer2ViewIncludedPropertyBlock>? IncludedProperty
    {
        get => GetArgument<TerraformList<AwsResourceexplorer2ViewIncludedPropertyBlock>>("included_property");
        set => SetArgument("included_property", value);
    }

}
