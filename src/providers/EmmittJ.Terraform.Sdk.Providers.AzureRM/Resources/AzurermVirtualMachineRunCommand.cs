using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for error_blob_managed_identity in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualMachineRunCommandErrorBlobManagedIdentityBlock : TerraformBlock
{
    /// <summary>
    /// The client_id attribute.
    /// </summary>
    public TerraformProperty<string>? ClientId
    {
        set => SetProperty("client_id", value);
    }

    /// <summary>
    /// The object_id attribute.
    /// </summary>
    public TerraformProperty<string>? ObjectId
    {
        set => SetProperty("object_id", value);
    }

}

/// <summary>
/// Block type for output_blob_managed_identity in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualMachineRunCommandOutputBlobManagedIdentityBlock : TerraformBlock
{
    /// <summary>
    /// The client_id attribute.
    /// </summary>
    public TerraformProperty<string>? ClientId
    {
        set => SetProperty("client_id", value);
    }

    /// <summary>
    /// The object_id attribute.
    /// </summary>
    public TerraformProperty<string>? ObjectId
    {
        set => SetProperty("object_id", value);
    }

}

/// <summary>
/// Block type for parameter in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualMachineRunCommandParameterBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformProperty<string> Value
    {
        set => SetProperty("value", value);
    }

}

/// <summary>
/// Block type for protected_parameter in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualMachineRunCommandProtectedParameterBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformProperty<string> Value
    {
        set => SetProperty("value", value);
    }

}

/// <summary>
/// Block type for source in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualMachineRunCommandSourceBlock : TerraformBlock
{
    /// <summary>
    /// The command_id attribute.
    /// </summary>
    public TerraformProperty<string>? CommandId
    {
        set => SetProperty("command_id", value);
    }

    /// <summary>
    /// The script attribute.
    /// </summary>
    public TerraformProperty<string>? Script
    {
        set => SetProperty("script", value);
    }

    /// <summary>
    /// The script_uri attribute.
    /// </summary>
    public TerraformProperty<string>? ScriptUri
    {
        set => SetProperty("script_uri", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermVirtualMachineRunCommandTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("instance_view");
        SetOutput("error_blob_uri");
        SetOutput("id");
        SetOutput("location");
        SetOutput("name");
        SetOutput("output_blob_uri");
        SetOutput("run_as_password");
        SetOutput("run_as_user");
        SetOutput("tags");
        SetOutput("virtual_machine_id");
    }

    /// <summary>
    /// The error_blob_uri attribute.
    /// </summary>
    public TerraformProperty<string> ErrorBlobUri
    {
        get => GetRequiredOutput<TerraformProperty<string>>("error_blob_uri");
        set => SetProperty("error_blob_uri", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The output_blob_uri attribute.
    /// </summary>
    public TerraformProperty<string> OutputBlobUri
    {
        get => GetRequiredOutput<TerraformProperty<string>>("output_blob_uri");
        set => SetProperty("output_blob_uri", value);
    }

    /// <summary>
    /// The run_as_password attribute.
    /// </summary>
    public TerraformProperty<string> RunAsPassword
    {
        get => GetRequiredOutput<TerraformProperty<string>>("run_as_password");
        set => SetProperty("run_as_password", value);
    }

    /// <summary>
    /// The run_as_user attribute.
    /// </summary>
    public TerraformProperty<string> RunAsUser
    {
        get => GetRequiredOutput<TerraformProperty<string>>("run_as_user");
        set => SetProperty("run_as_user", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The virtual_machine_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualMachineId is required")]
    public required TerraformProperty<string> VirtualMachineId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("virtual_machine_id");
        set => SetProperty("virtual_machine_id", value);
    }

    /// <summary>
    /// Block for error_blob_managed_identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ErrorBlobManagedIdentity block(s) allowed")]
    public List<AzurermVirtualMachineRunCommandErrorBlobManagedIdentityBlock>? ErrorBlobManagedIdentity
    {
        set => SetProperty("error_blob_managed_identity", value);
    }

    /// <summary>
    /// Block for output_blob_managed_identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OutputBlobManagedIdentity block(s) allowed")]
    public List<AzurermVirtualMachineRunCommandOutputBlobManagedIdentityBlock>? OutputBlobManagedIdentity
    {
        set => SetProperty("output_blob_managed_identity", value);
    }

    /// <summary>
    /// Block for parameter.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermVirtualMachineRunCommandParameterBlock>? Parameter
    {
        set => SetProperty("parameter", value);
    }

    /// <summary>
    /// Block for protected_parameter.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermVirtualMachineRunCommandProtectedParameterBlock>? ProtectedParameter
    {
        set => SetProperty("protected_parameter", value);
    }

    /// <summary>
    /// Block for source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Source block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Source block(s) allowed")]
    public List<AzurermVirtualMachineRunCommandSourceBlock>? Source
    {
        set => SetProperty("source", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermVirtualMachineRunCommandTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The instance_view attribute.
    /// </summary>
    public TerraformExpression InstanceView => this["instance_view"];

}
