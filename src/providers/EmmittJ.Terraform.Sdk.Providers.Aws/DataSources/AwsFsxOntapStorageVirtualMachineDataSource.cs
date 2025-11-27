using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in AwsFsxOntapStorageVirtualMachineDataSource.
/// Nesting mode: set
/// </summary>
public class AwsFsxOntapStorageVirtualMachineDataSourceFilterBlock : TerraformBlock
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
/// Represents a aws_fsx_ontap_storage_virtual_machine Terraform data source.
/// Retrieves information about a aws_fsx_ontap_storage_virtual_machine.
/// </summary>
public partial class AwsFsxOntapStorageVirtualMachineDataSource(string name) : TerraformDataSource("aws_fsx_ontap_storage_virtual_machine", name)
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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The active_directory_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ActiveDirectoryConfiguration
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "active_directory_configuration").ResolveNodes(ctx));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The creation_time attribute.
    /// </summary>
    public TerraformValue<string> CreationTime
    {
        get => new TerraformReference<string>(this, "creation_time");
    }

    /// <summary>
    /// The endpoints attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Endpoints
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "endpoints").ResolveNodes(ctx));
    }

    /// <summary>
    /// The file_system_id attribute.
    /// </summary>
    public TerraformValue<string> FileSystemId
    {
        get => new TerraformReference<string>(this, "file_system_id");
    }

    /// <summary>
    /// The lifecycle_status attribute.
    /// </summary>
    public TerraformValue<string> LifecycleStatus
    {
        get => new TerraformReference<string>(this, "lifecycle_status");
    }

    /// <summary>
    /// The lifecycle_transition_reason attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> LifecycleTransitionReason
    {
        get => TerraformSet<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformMap<object>>>(this, "lifecycle_transition_reason").ResolveNodes(ctx));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// The subtype attribute.
    /// </summary>
    public TerraformValue<string> Subtype
    {
        get => new TerraformReference<string>(this, "subtype");
    }

    /// <summary>
    /// The uuid attribute.
    /// </summary>
    public TerraformValue<string> Uuid
    {
        get => new TerraformReference<string>(this, "uuid");
    }

    /// <summary>
    /// Filter block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsFsxOntapStorageVirtualMachineDataSourceFilterBlock>? Filter
    {
        get => GetArgument<TerraformSet<AwsFsxOntapStorageVirtualMachineDataSourceFilterBlock>>("filter");
        set => SetArgument("filter", value);
    }

}
