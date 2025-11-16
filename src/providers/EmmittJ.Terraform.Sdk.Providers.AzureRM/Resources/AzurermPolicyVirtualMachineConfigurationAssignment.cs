using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermPolicyVirtualMachineConfigurationAssignmentConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "configuration";

    /// <summary>
    /// The assignment_type attribute.
    /// </summary>
    public TerraformValue<string>? AssignmentType
    {
        get => new TerraformReference<string>(this, "assignment_type");
        set => SetArgument("assignment_type", value);
    }

    /// <summary>
    /// The content_hash attribute.
    /// </summary>
    public TerraformValue<string> ContentHash
    {
        get => new TerraformReference<string>(this, "content_hash");
        set => SetArgument("content_hash", value);
    }

    /// <summary>
    /// The content_uri attribute.
    /// </summary>
    public TerraformValue<string> ContentUri
    {
        get => new TerraformReference<string>(this, "content_uri");
        set => SetArgument("content_uri", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string>? Version
    {
        get => new TerraformReference<string>(this, "version");
        set => SetArgument("version", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermPolicyVirtualMachineConfigurationAssignmentTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Represents a azurerm_policy_virtual_machine_configuration_assignment Terraform resource.
/// Manages a azurerm_policy_virtual_machine_configuration_assignment resource.
/// </summary>
public partial class AzurermPolicyVirtualMachineConfigurationAssignment(string name) : TerraformResource("azurerm_policy_virtual_machine_configuration_assignment", name)
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

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
    /// The virtual_machine_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualMachineId is required")]
    public required TerraformValue<string> VirtualMachineId
    {
        get => new TerraformReference<string>(this, "virtual_machine_id");
        set => SetArgument("virtual_machine_id", value);
    }

    /// <summary>
    /// Configuration block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Configuration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Configuration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Configuration block(s) allowed")]
    public required TerraformList<AzurermPolicyVirtualMachineConfigurationAssignmentConfigurationBlock> Configuration
    {
        get => GetRequiredArgument<TerraformList<AzurermPolicyVirtualMachineConfigurationAssignmentConfigurationBlock>>("configuration");
        set => SetArgument("configuration", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermPolicyVirtualMachineConfigurationAssignmentTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermPolicyVirtualMachineConfigurationAssignmentTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
