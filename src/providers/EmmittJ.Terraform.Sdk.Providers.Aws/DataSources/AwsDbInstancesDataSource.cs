using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in AwsDbInstancesDataSource.
/// Nesting mode: set
/// </summary>
public class AwsDbInstancesDataSourceFilterBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public required TerraformSet<string> ValuesAttribute
    {
        get => GetRequiredArgument<TerraformSet<string>>("values");
        set => SetArgument("values", value);
    }

}


/// <summary>
/// Represents a aws_db_instances Terraform data source.
/// Retrieves information about a aws_db_instances.
/// </summary>
public partial class AwsDbInstancesDataSource(string name) : TerraformDataSource("aws_db_instances", name)
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => GetArgument<TerraformMap<string>>("tags") ?? AsReference("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The instance_arns attribute.
    /// </summary>
    public TerraformList<string> InstanceArns
        => AsReference("instance_arns");

    /// <summary>
    /// The instance_identifiers attribute.
    /// </summary>
    public TerraformList<string> InstanceIdentifiers
        => AsReference("instance_identifiers");

    /// <summary>
    /// Filter block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsDbInstancesDataSourceFilterBlock>? Filter
    {
        get => GetArgument<TerraformSet<AwsDbInstancesDataSourceFilterBlock>>("filter");
        set => SetArgument("filter", value);
    }

}
