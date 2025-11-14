using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for error_blob_managed_identity in .
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
    [TerraformArgument("client_id")]
    public TerraformValue<string>? ClientId
    {
        get => new TerraformReference<string>(this, "client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The object_id attribute.
    /// </summary>
    [TerraformArgument("object_id")]
    public TerraformValue<string>? ObjectId
    {
        get => new TerraformReference<string>(this, "object_id");
        set => SetArgument("object_id", value);
    }

}

/// <summary>
/// Block type for output_blob_managed_identity in .
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
    [TerraformArgument("client_id")]
    public TerraformValue<string>? ClientId
    {
        get => new TerraformReference<string>(this, "client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The object_id attribute.
    /// </summary>
    [TerraformArgument("object_id")]
    public TerraformValue<string>? ObjectId
    {
        get => new TerraformReference<string>(this, "object_id");
        set => SetArgument("object_id", value);
    }

}

/// <summary>
/// Block type for parameter in .
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
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    [TerraformArgument("value")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for protected_parameter in .
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
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    [TerraformArgument("value")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for source in .
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
    [TerraformArgument("command_id")]
    public TerraformValue<string>? CommandId
    {
        get => new TerraformReference<string>(this, "command_id");
        set => SetArgument("command_id", value);
    }

    /// <summary>
    /// The script attribute.
    /// </summary>
    [TerraformArgument("script")]
    public TerraformValue<string>? Script
    {
        get => new TerraformReference<string>(this, "script");
        set => SetArgument("script", value);
    }

    /// <summary>
    /// The script_uri attribute.
    /// </summary>
    [TerraformArgument("script_uri")]
    public TerraformValue<string>? ScriptUri
    {
        get => new TerraformReference<string>(this, "script_uri");
        set => SetArgument("script_uri", value);
    }

}

/// <summary>
/// Block type for timeouts in .
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
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Manages a azurerm_virtual_machine_run_command resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermVirtualMachineRunCommand : TerraformResource
{
    public AzurermVirtualMachineRunCommand(string name) : base("azurerm_virtual_machine_run_command", name)
    {
    }

    /// <summary>
    /// The error_blob_uri attribute.
    /// </summary>
    [TerraformArgument("error_blob_uri")]
    public TerraformValue<string>? ErrorBlobUri
    {
        get => new TerraformReference<string>(this, "error_blob_uri");
        set => SetArgument("error_blob_uri", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformArgument("location")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The output_blob_uri attribute.
    /// </summary>
    [TerraformArgument("output_blob_uri")]
    public TerraformValue<string>? OutputBlobUri
    {
        get => new TerraformReference<string>(this, "output_blob_uri");
        set => SetArgument("output_blob_uri", value);
    }

    /// <summary>
    /// The run_as_password attribute.
    /// </summary>
    [TerraformArgument("run_as_password")]
    public TerraformValue<string>? RunAsPassword
    {
        get => new TerraformReference<string>(this, "run_as_password");
        set => SetArgument("run_as_password", value);
    }

    /// <summary>
    /// The run_as_user attribute.
    /// </summary>
    [TerraformArgument("run_as_user")]
    public TerraformValue<string>? RunAsUser
    {
        get => new TerraformReference<string>(this, "run_as_user");
        set => SetArgument("run_as_user", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The virtual_machine_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualMachineId is required")]
    [TerraformArgument("virtual_machine_id")]
    public required TerraformValue<string> VirtualMachineId
    {
        get => new TerraformReference<string>(this, "virtual_machine_id");
        set => SetArgument("virtual_machine_id", value);
    }

    /// <summary>
    /// Block for error_blob_managed_identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ErrorBlobManagedIdentity block(s) allowed")]
    [TerraformArgument("error_blob_managed_identity")]
    public TerraformList<AzurermVirtualMachineRunCommandErrorBlobManagedIdentityBlock> ErrorBlobManagedIdentity { get; set; } = new();

    /// <summary>
    /// Block for output_blob_managed_identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OutputBlobManagedIdentity block(s) allowed")]
    [TerraformArgument("output_blob_managed_identity")]
    public TerraformList<AzurermVirtualMachineRunCommandOutputBlobManagedIdentityBlock> OutputBlobManagedIdentity { get; set; } = new();

    /// <summary>
    /// Block for parameter.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("parameter")]
    public TerraformList<AzurermVirtualMachineRunCommandParameterBlock> Parameter { get; set; } = new();

    /// <summary>
    /// Block for protected_parameter.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("protected_parameter")]
    public TerraformList<AzurermVirtualMachineRunCommandProtectedParameterBlock> ProtectedParameter { get; set; } = new();

    /// <summary>
    /// Block for source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Source block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Source block(s) allowed")]
    [TerraformArgument("source")]
    public required TerraformList<AzurermVirtualMachineRunCommandSourceBlock> Source { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermVirtualMachineRunCommandTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The instance_view attribute.
    /// </summary>
    [TerraformArgument("instance_view")]
    public TerraformList<object> InstanceView
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "instance_view").ResolveNodes(ctx));
    }

}
