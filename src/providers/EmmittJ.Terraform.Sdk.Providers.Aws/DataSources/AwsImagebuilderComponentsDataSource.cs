using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in AwsImagebuilderComponentsDataSource.
/// Nesting mode: set
/// </summary>
public class AwsImagebuilderComponentsDataSourceFilterBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public required TerraformSet<string> ValuesAttribute
    {
        get => GetArgument<TerraformSet<string>>("values");
        set => SetArgument("values", value);
    }

}


/// <summary>
/// Represents a aws_imagebuilder_components Terraform data source.
/// Retrieves information about a aws_imagebuilder_components.
/// </summary>
public partial class AwsImagebuilderComponentsDataSource(string name) : TerraformDataSource("aws_imagebuilder_components", name)
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
    /// The owner attribute.
    /// </summary>
    public TerraformValue<string>? Owner
    {
        get => GetArgument<TerraformValue<string>>("owner");
        set => SetArgument("owner", value);
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
    /// The arns attribute.
    /// </summary>
    public TerraformSet<string> Arns
        => AsReference("arns");

    /// <summary>
    /// The names attribute.
    /// </summary>
    public TerraformSet<string> Names
        => AsReference("names");

    /// <summary>
    /// Filter block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsImagebuilderComponentsDataSourceFilterBlock>? Filter
    {
        get => GetArgument<TerraformSet<AwsImagebuilderComponentsDataSourceFilterBlock>>("filter");
        set => SetArgument("filter", value);
    }

}
