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
        get => GetRequiredArgument<TerraformValue<string>>("name");
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
    /// The active_directory_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ActiveDirectoryConfiguration
        => AsReference("active_directory_configuration");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The creation_time attribute.
    /// </summary>
    public TerraformValue<string> CreationTime
        => AsReference("creation_time");

    /// <summary>
    /// The endpoints attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Endpoints
        => AsReference("endpoints");

    /// <summary>
    /// The file_system_id attribute.
    /// </summary>
    public TerraformValue<string> FileSystemId
        => AsReference("file_system_id");

    /// <summary>
    /// The lifecycle_status attribute.
    /// </summary>
    public TerraformValue<string> LifecycleStatus
        => AsReference("lifecycle_status");

    /// <summary>
    /// The lifecycle_transition_reason attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> LifecycleTransitionReason
        => AsReference("lifecycle_transition_reason");

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The subtype attribute.
    /// </summary>
    public TerraformValue<string> Subtype
        => AsReference("subtype");

    /// <summary>
    /// The uuid attribute.
    /// </summary>
    public TerraformValue<string> Uuid
        => AsReference("uuid");

    /// <summary>
    /// Filter block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsFsxOntapStorageVirtualMachineDataSourceFilterBlock>? Filter
    {
        get => GetArgument<TerraformSet<AwsFsxOntapStorageVirtualMachineDataSourceFilterBlock>>("filter");
        set => SetArgument("filter", value);
    }

}
