using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in AwsRegionsDataSource.
/// Nesting mode: set
/// </summary>
public class AwsRegionsDataSourceFilterBlock : TerraformBlock
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
/// Represents a aws_regions Terraform data source.
/// Retrieves information about a aws_regions.
/// </summary>
public partial class AwsRegionsDataSource(string name) : TerraformDataSource("aws_regions", name)
{
    /// <summary>
    /// The all_regions attribute.
    /// </summary>
    public TerraformValue<bool>? AllRegions
    {
        get => new TerraformReference<bool>(this, "all_regions");
        set => SetArgument("all_regions", value);
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
    /// The names attribute.
    /// </summary>
    public TerraformSet<string> Names
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "names").ResolveNodes(ctx));
    }

    /// <summary>
    /// Filter block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsRegionsDataSourceFilterBlock>? Filter
    {
        get => GetArgument<TerraformSet<AwsRegionsDataSourceFilterBlock>>("filter");
        set => SetArgument("filter", value);
    }

}
