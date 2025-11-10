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
        get => GetProperty<TerraformProperty<string>>("client_id");
        set => WithProperty("client_id", value);
    }

    /// <summary>
    /// The object_id attribute.
    /// </summary>
    public TerraformProperty<string>? ObjectId
    {
        get => GetProperty<TerraformProperty<string>>("object_id");
        set => WithProperty("object_id", value);
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
        get => GetProperty<TerraformProperty<string>>("client_id");
        set => WithProperty("client_id", value);
    }

    /// <summary>
    /// The object_id attribute.
    /// </summary>
    public TerraformProperty<string>? ObjectId
    {
        get => GetProperty<TerraformProperty<string>>("object_id");
        set => WithProperty("object_id", value);
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
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformProperty<string> Value
    {
        get => GetProperty<TerraformProperty<string>>("value");
        set => WithProperty("value", value);
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
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformProperty<string> Value
    {
        get => GetProperty<TerraformProperty<string>>("value");
        set => WithProperty("value", value);
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
        get => GetProperty<TerraformProperty<string>>("command_id");
        set => WithProperty("command_id", value);
    }

    /// <summary>
    /// The script attribute.
    /// </summary>
    public TerraformProperty<string>? Script
    {
        get => GetProperty<TerraformProperty<string>>("script");
        set => WithProperty("script", value);
    }

    /// <summary>
    /// The script_uri attribute.
    /// </summary>
    public TerraformProperty<string>? ScriptUri
    {
        get => GetProperty<TerraformProperty<string>>("script_uri");
        set => WithProperty("script_uri", value);
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
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_virtual_machine_run_command resource.
/// </summary>
public class AzurermVirtualMachineRunCommand : TerraformResource
{
    public AzurermVirtualMachineRunCommand(string name) : base("azurerm_virtual_machine_run_command", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("instance_view");
    }

    /// <summary>
    /// The error_blob_uri attribute.
    /// </summary>
    public TerraformProperty<string>? ErrorBlobUri
    {
        get => GetProperty<TerraformProperty<string>>("error_blob_uri");
        set => this.WithProperty("error_blob_uri", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The output_blob_uri attribute.
    /// </summary>
    public TerraformProperty<string>? OutputBlobUri
    {
        get => GetProperty<TerraformProperty<string>>("output_blob_uri");
        set => this.WithProperty("output_blob_uri", value);
    }

    /// <summary>
    /// The run_as_password attribute.
    /// </summary>
    public TerraformProperty<string>? RunAsPassword
    {
        get => GetProperty<TerraformProperty<string>>("run_as_password");
        set => this.WithProperty("run_as_password", value);
    }

    /// <summary>
    /// The run_as_user attribute.
    /// </summary>
    public TerraformProperty<string>? RunAsUser
    {
        get => GetProperty<TerraformProperty<string>>("run_as_user");
        set => this.WithProperty("run_as_user", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The virtual_machine_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualMachineId is required")]
    public required TerraformProperty<string> VirtualMachineId
    {
        get => GetProperty<TerraformProperty<string>>("virtual_machine_id");
        set => this.WithProperty("virtual_machine_id", value);
    }

    /// <summary>
    /// Block for error_blob_managed_identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ErrorBlobManagedIdentity block(s) allowed")]
    public List<AzurermVirtualMachineRunCommandErrorBlobManagedIdentityBlock>? ErrorBlobManagedIdentity
    {
        get => GetProperty<List<AzurermVirtualMachineRunCommandErrorBlobManagedIdentityBlock>>("error_blob_managed_identity");
        set => this.WithProperty("error_blob_managed_identity", value);
    }

    /// <summary>
    /// Block for output_blob_managed_identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OutputBlobManagedIdentity block(s) allowed")]
    public List<AzurermVirtualMachineRunCommandOutputBlobManagedIdentityBlock>? OutputBlobManagedIdentity
    {
        get => GetProperty<List<AzurermVirtualMachineRunCommandOutputBlobManagedIdentityBlock>>("output_blob_managed_identity");
        set => this.WithProperty("output_blob_managed_identity", value);
    }

    /// <summary>
    /// Block for parameter.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermVirtualMachineRunCommandParameterBlock>? Parameter
    {
        get => GetProperty<List<AzurermVirtualMachineRunCommandParameterBlock>>("parameter");
        set => this.WithProperty("parameter", value);
    }

    /// <summary>
    /// Block for protected_parameter.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermVirtualMachineRunCommandProtectedParameterBlock>? ProtectedParameter
    {
        get => GetProperty<List<AzurermVirtualMachineRunCommandProtectedParameterBlock>>("protected_parameter");
        set => this.WithProperty("protected_parameter", value);
    }

    /// <summary>
    /// Block for source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Source block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Source block(s) allowed")]
    public List<AzurermVirtualMachineRunCommandSourceBlock>? Source
    {
        get => GetProperty<List<AzurermVirtualMachineRunCommandSourceBlock>>("source");
        set => this.WithProperty("source", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermVirtualMachineRunCommandTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermVirtualMachineRunCommandTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The instance_view attribute.
    /// </summary>
    public TerraformExpression InstanceView => this["instance_view"];

}
