using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for error_blob_managed_identity in .
/// Nesting mode: list
/// </summary>
public partial class AzurermVirtualMachineRunCommandErrorBlobManagedIdentityBlock : TerraformBlockBase
{
    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [TerraformProperty("client_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ClientId { get; set; }

    /// <summary>
    /// The object_id attribute.
    /// </summary>
    [TerraformProperty("object_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ObjectId { get; set; }

}

/// <summary>
/// Block type for output_blob_managed_identity in .
/// Nesting mode: list
/// </summary>
public partial class AzurermVirtualMachineRunCommandOutputBlobManagedIdentityBlock : TerraformBlockBase
{
    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [TerraformProperty("client_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ClientId { get; set; }

    /// <summary>
    /// The object_id attribute.
    /// </summary>
    [TerraformProperty("object_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ObjectId { get; set; }

}

/// <summary>
/// Block type for parameter in .
/// Nesting mode: list
/// </summary>
public partial class AzurermVirtualMachineRunCommandParameterBlock : TerraformBlockBase
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    [TerraformProperty("value")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Value { get; set; }

}

/// <summary>
/// Block type for protected_parameter in .
/// Nesting mode: list
/// </summary>
public partial class AzurermVirtualMachineRunCommandProtectedParameterBlock : TerraformBlockBase
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    [TerraformProperty("value")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Value { get; set; }

}

/// <summary>
/// Block type for source in .
/// Nesting mode: list
/// </summary>
public partial class AzurermVirtualMachineRunCommandSourceBlock : TerraformBlockBase
{
    /// <summary>
    /// The command_id attribute.
    /// </summary>
    [TerraformProperty("command_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CommandId { get; set; }

    /// <summary>
    /// The script attribute.
    /// </summary>
    [TerraformProperty("script")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Script { get; set; }

    /// <summary>
    /// The script_uri attribute.
    /// </summary>
    [TerraformProperty("script_uri")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ScriptUri { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermVirtualMachineRunCommandTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_virtual_machine_run_command resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermVirtualMachineRunCommand : TerraformResource
{
    public AzurermVirtualMachineRunCommand(string name) : base("azurerm_virtual_machine_run_command", name)
    {
    }

    /// <summary>
    /// The error_blob_uri attribute.
    /// </summary>
    [TerraformProperty("error_blob_uri")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ErrorBlobUri { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The output_blob_uri attribute.
    /// </summary>
    [TerraformProperty("output_blob_uri")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? OutputBlobUri { get; set; }

    /// <summary>
    /// The run_as_password attribute.
    /// </summary>
    [TerraformProperty("run_as_password")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? RunAsPassword { get; set; }

    /// <summary>
    /// The run_as_user attribute.
    /// </summary>
    [TerraformProperty("run_as_user")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? RunAsUser { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The virtual_machine_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualMachineId is required")]
    [TerraformProperty("virtual_machine_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> VirtualMachineId { get; set; }

    /// <summary>
    /// Block for error_blob_managed_identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ErrorBlobManagedIdentity block(s) allowed")]
    [TerraformProperty("error_blob_managed_identity")]
    public TerraformList<TerraformBlock<AzurermVirtualMachineRunCommandErrorBlobManagedIdentityBlock>>? ErrorBlobManagedIdentity { get; set; }

    /// <summary>
    /// Block for output_blob_managed_identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OutputBlobManagedIdentity block(s) allowed")]
    [TerraformProperty("output_blob_managed_identity")]
    public TerraformList<TerraformBlock<AzurermVirtualMachineRunCommandOutputBlobManagedIdentityBlock>>? OutputBlobManagedIdentity { get; set; }

    /// <summary>
    /// Block for parameter.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("parameter")]
    public TerraformList<TerraformBlock<AzurermVirtualMachineRunCommandParameterBlock>>? Parameter { get; set; }

    /// <summary>
    /// Block for protected_parameter.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("protected_parameter")]
    public TerraformList<TerraformBlock<AzurermVirtualMachineRunCommandProtectedParameterBlock>>? ProtectedParameter { get; set; }

    /// <summary>
    /// Block for source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Source block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Source block(s) allowed")]
    [TerraformProperty("source")]
    public TerraformList<TerraformBlock<AzurermVirtualMachineRunCommandSourceBlock>>? Source { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermVirtualMachineRunCommandTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The instance_view attribute.
    /// </summary>
    [TerraformProperty("instance_view")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> InstanceView { get; }

}
