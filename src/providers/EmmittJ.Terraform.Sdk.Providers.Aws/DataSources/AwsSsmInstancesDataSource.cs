using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in AwsSsmInstancesDataSource.
/// Nesting mode: set
/// </summary>
public class AwsSsmInstancesDataSourceFilterBlock : TerraformBlock
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
    public TerraformList<string>? ValuesAttribute
    {
        get => GetArgument<TerraformList<string>>("values");
        set => SetArgument("values", value);
    }

}


/// <summary>
/// Represents a aws_ssm_instances Terraform data source.
/// Retrieves information about a aws_ssm_instances.
/// </summary>
public partial class AwsSsmInstancesDataSource(string name) : TerraformDataSource("aws_ssm_instances", name)
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The ids attribute.
    /// </summary>
    public TerraformSet<string> Ids
        => AsReference("ids");

    /// <summary>
    /// Filter block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsSsmInstancesDataSourceFilterBlock>? Filter
    {
        get => GetArgument<TerraformSet<AwsSsmInstancesDataSourceFilterBlock>>("filter");
        set => SetArgument("filter", value);
    }

}
