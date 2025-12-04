using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for error_blob_managed_identity in AzurermVirtualMachineRunCommand.
/// Nesting mode: list
/// </summary>
public class AzurermVirtualMachineRunCommandErrorBlobManagedIdentityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "error_blob_managed_identity";

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    public TerraformValue<string>? ClientId
    {
        get => GetArgument<TerraformValue<string>>("client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The object_id attribute.
    /// </summary>
    public TerraformValue<string>? ObjectId
    {
        get => GetArgument<TerraformValue<string>>("object_id");
        set => SetArgument("object_id", value);
    }

}


/// <summary>
/// Block type for output_blob_managed_identity in AzurermVirtualMachineRunCommand.
/// Nesting mode: list
/// </summary>
public class AzurermVirtualMachineRunCommandOutputBlobManagedIdentityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "output_blob_managed_identity";

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    public TerraformValue<string>? ClientId
    {
        get => GetArgument<TerraformValue<string>>("client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The object_id attribute.
    /// </summary>
    public TerraformValue<string>? ObjectId
    {
        get => GetArgument<TerraformValue<string>>("object_id");
        set => SetArgument("object_id", value);
    }

}


/// <summary>
/// Block type for parameter in AzurermVirtualMachineRunCommand.
/// Nesting mode: list
/// </summary>
public class AzurermVirtualMachineRunCommandParameterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "parameter";

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
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for protected_parameter in AzurermVirtualMachineRunCommand.
/// Nesting mode: list
/// </summary>
public class AzurermVirtualMachineRunCommandProtectedParameterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "protected_parameter";

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
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for source in AzurermVirtualMachineRunCommand.
/// Nesting mode: list
/// </summary>
public class AzurermVirtualMachineRunCommandSourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "source";

    /// <summary>
    /// The command_id attribute.
    /// </summary>
    public TerraformValue<string>? CommandId
    {
        get => GetArgument<TerraformValue<string>>("command_id");
        set => SetArgument("command_id", value);
    }

    /// <summary>
    /// The script attribute.
    /// </summary>
    public TerraformValue<string>? Script
    {
        get => GetArgument<TerraformValue<string>>("script");
        set => SetArgument("script", value);
    }

    /// <summary>
    /// The script_uri attribute.
    /// </summary>
    public TerraformValue<string>? ScriptUri
    {
        get => GetArgument<TerraformValue<string>>("script_uri");
        set => SetArgument("script_uri", value);
    }

    /// <summary>
    /// ScriptUriManagedIdentity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScriptUriManagedIdentity block(s) allowed")]
    public TerraformList<AzurermVirtualMachineRunCommandSourceBlockScriptUriManagedIdentityBlock>? ScriptUriManagedIdentity
    {
        get => GetArgument<TerraformList<AzurermVirtualMachineRunCommandSourceBlockScriptUriManagedIdentityBlock>>("script_uri_managed_identity");
        set => SetArgument("script_uri_managed_identity", value);
    }

}

/// <summary>
/// Block type for script_uri_managed_identity in AzurermVirtualMachineRunCommandSourceBlock.
/// Nesting mode: list
/// </summary>
public class AzurermVirtualMachineRunCommandSourceBlockScriptUriManagedIdentityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "script_uri_managed_identity";

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    public TerraformValue<string>? ClientId
    {
        get => GetArgument<TerraformValue<string>>("client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The object_id attribute.
    /// </summary>
    public TerraformValue<string>? ObjectId
    {
        get => GetArgument<TerraformValue<string>>("object_id");
        set => SetArgument("object_id", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermVirtualMachineRunCommand.
/// Nesting mode: single
/// </summary>
public class AzurermVirtualMachineRunCommandTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_virtual_machine_run_command Terraform resource.
/// Manages a azurerm_virtual_machine_run_command resource.
/// </summary>
public partial class AzurermVirtualMachineRunCommand(string name) : TerraformResource("azurerm_virtual_machine_run_command", name)
{
    /// <summary>
    /// The error_blob_uri attribute.
    /// </summary>
    public TerraformValue<string>? ErrorBlobUri
    {
        get => GetArgument<TerraformValue<string>>("error_blob_uri");
        set => SetArgument("error_blob_uri", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

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
    /// The output_blob_uri attribute.
    /// </summary>
    public TerraformValue<string>? OutputBlobUri
    {
        get => GetArgument<TerraformValue<string>>("output_blob_uri");
        set => SetArgument("output_blob_uri", value);
    }

    /// <summary>
    /// The run_as_password attribute.
    /// </summary>
    public TerraformValue<string>? RunAsPassword
    {
        get => GetArgument<TerraformValue<string>>("run_as_password");
        set => SetArgument("run_as_password", value);
    }

    /// <summary>
    /// The run_as_user attribute.
    /// </summary>
    public TerraformValue<string>? RunAsUser
    {
        get => GetArgument<TerraformValue<string>>("run_as_user");
        set => SetArgument("run_as_user", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The virtual_machine_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualMachineId is required")]
    public required TerraformValue<string> VirtualMachineId
    {
        get => GetArgument<TerraformValue<string>>("virtual_machine_id");
        set => SetArgument("virtual_machine_id", value);
    }

    /// <summary>
    /// The instance_view attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> InstanceView
        => AsReference("instance_view");

    /// <summary>
    /// ErrorBlobManagedIdentity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ErrorBlobManagedIdentity block(s) allowed")]
    public TerraformList<AzurermVirtualMachineRunCommandErrorBlobManagedIdentityBlock>? ErrorBlobManagedIdentity
    {
        get => GetArgument<TerraformList<AzurermVirtualMachineRunCommandErrorBlobManagedIdentityBlock>>("error_blob_managed_identity");
        set => SetArgument("error_blob_managed_identity", value);
    }

    /// <summary>
    /// OutputBlobManagedIdentity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OutputBlobManagedIdentity block(s) allowed")]
    public TerraformList<AzurermVirtualMachineRunCommandOutputBlobManagedIdentityBlock>? OutputBlobManagedIdentity
    {
        get => GetArgument<TerraformList<AzurermVirtualMachineRunCommandOutputBlobManagedIdentityBlock>>("output_blob_managed_identity");
        set => SetArgument("output_blob_managed_identity", value);
    }

    /// <summary>
    /// Parameter block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermVirtualMachineRunCommandParameterBlock>? Parameter
    {
        get => GetArgument<TerraformList<AzurermVirtualMachineRunCommandParameterBlock>>("parameter");
        set => SetArgument("parameter", value);
    }

    /// <summary>
    /// ProtectedParameter block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermVirtualMachineRunCommandProtectedParameterBlock>? ProtectedParameter
    {
        get => GetArgument<TerraformList<AzurermVirtualMachineRunCommandProtectedParameterBlock>>("protected_parameter");
        set => SetArgument("protected_parameter", value);
    }

    /// <summary>
    /// Source block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Source block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Source block(s) allowed")]
    public required TerraformList<AzurermVirtualMachineRunCommandSourceBlock> Source
    {
        get => GetRequiredArgument<TerraformList<AzurermVirtualMachineRunCommandSourceBlock>>("source");
        set => SetArgument("source", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermVirtualMachineRunCommandTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermVirtualMachineRunCommandTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
