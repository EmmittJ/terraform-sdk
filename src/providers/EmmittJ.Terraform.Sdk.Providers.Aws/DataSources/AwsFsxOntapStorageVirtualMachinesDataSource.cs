using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in AwsFsxOntapStorageVirtualMachinesDataSource.
/// Nesting mode: set
/// </summary>
public class AwsFsxOntapStorageVirtualMachinesDataSourceFilterBlock : TerraformBlock
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
    public TerraformList<string>? ValuesAttribute
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "values").ResolveNodes(ctx));
        set => SetArgument("values", value);
    }

}


/// <summary>
/// Represents a aws_fsx_ontap_storage_virtual_machines Terraform data source.
/// Retrieves information about a aws_fsx_ontap_storage_virtual_machines.
/// </summary>
public partial class AwsFsxOntapStorageVirtualMachinesDataSource(string name) : TerraformDataSource("aws_fsx_ontap_storage_virtual_machines", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
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
    /// The ids attribute.
    /// </summary>
    public TerraformList<string> Ids
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "ids").ResolveNodes(ctx));
    }

    /// <summary>
    /// Filter block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsFsxOntapStorageVirtualMachinesDataSourceFilterBlock>? Filter
    {
        get => GetArgument<TerraformSet<AwsFsxOntapStorageVirtualMachinesDataSourceFilterBlock>>("filter");
        set => SetArgument("filter", value);
    }

}
