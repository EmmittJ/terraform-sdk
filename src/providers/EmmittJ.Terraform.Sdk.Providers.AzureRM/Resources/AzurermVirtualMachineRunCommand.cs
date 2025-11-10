using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for error_blob_managed_identity in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualMachineRunCommandErrorBlobManagedIdentityBlock : ITerraformBlock
{
    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [TerraformPropertyName("client_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ClientId { get; set; }

    /// <summary>
    /// The object_id attribute.
    /// </summary>
    [TerraformPropertyName("object_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ObjectId { get; set; }

}

/// <summary>
/// Block type for output_blob_managed_identity in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualMachineRunCommandOutputBlobManagedIdentityBlock : ITerraformBlock
{
    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [TerraformPropertyName("client_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ClientId { get; set; }

    /// <summary>
    /// The object_id attribute.
    /// </summary>
    [TerraformPropertyName("object_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ObjectId { get; set; }

}

/// <summary>
/// Block type for parameter in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualMachineRunCommandParameterBlock : ITerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    [TerraformPropertyName("value")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Value { get; set; }

}

/// <summary>
/// Block type for protected_parameter in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualMachineRunCommandProtectedParameterBlock : ITerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    [TerraformPropertyName("value")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Value { get; set; }

}

/// <summary>
/// Block type for source in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualMachineRunCommandSourceBlock : ITerraformBlock
{
    /// <summary>
    /// The command_id attribute.
    /// </summary>
    [TerraformPropertyName("command_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CommandId { get; set; }

    /// <summary>
    /// The script attribute.
    /// </summary>
    [TerraformPropertyName("script")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Script { get; set; }

    /// <summary>
    /// The script_uri attribute.
    /// </summary>
    [TerraformPropertyName("script_uri")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ScriptUri { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermVirtualMachineRunCommandTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

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
    [TerraformPropertyName("error_blob_uri")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ErrorBlobUri { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The output_blob_uri attribute.
    /// </summary>
    [TerraformPropertyName("output_blob_uri")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? OutputBlobUri { get; set; }

    /// <summary>
    /// The run_as_password attribute.
    /// </summary>
    [TerraformPropertyName("run_as_password")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RunAsPassword { get; set; }

    /// <summary>
    /// The run_as_user attribute.
    /// </summary>
    [TerraformPropertyName("run_as_user")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RunAsUser { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The virtual_machine_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualMachineId is required")]
    [TerraformPropertyName("virtual_machine_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> VirtualMachineId { get; set; }

    /// <summary>
    /// Block for error_blob_managed_identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ErrorBlobManagedIdentity block(s) allowed")]
    [TerraformPropertyName("error_blob_managed_identity")]
    public TerraformList<TerraformBlock<AzurermVirtualMachineRunCommandErrorBlobManagedIdentityBlock>>? ErrorBlobManagedIdentity { get; set; } = new();

    /// <summary>
    /// Block for output_blob_managed_identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OutputBlobManagedIdentity block(s) allowed")]
    [TerraformPropertyName("output_blob_managed_identity")]
    public TerraformList<TerraformBlock<AzurermVirtualMachineRunCommandOutputBlobManagedIdentityBlock>>? OutputBlobManagedIdentity { get; set; } = new();

    /// <summary>
    /// Block for parameter.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("parameter")]
    public TerraformList<TerraformBlock<AzurermVirtualMachineRunCommandParameterBlock>>? Parameter { get; set; } = new();

    /// <summary>
    /// Block for protected_parameter.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("protected_parameter")]
    public TerraformList<TerraformBlock<AzurermVirtualMachineRunCommandProtectedParameterBlock>>? ProtectedParameter { get; set; } = new();

    /// <summary>
    /// Block for source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Source block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Source block(s) allowed")]
    [TerraformPropertyName("source")]
    public TerraformList<TerraformBlock<AzurermVirtualMachineRunCommandSourceBlock>>? Source { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermVirtualMachineRunCommandTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The instance_view attribute.
    /// </summary>
    [TerraformPropertyName("instance_view")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> InstanceView => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "instance_view");

}
