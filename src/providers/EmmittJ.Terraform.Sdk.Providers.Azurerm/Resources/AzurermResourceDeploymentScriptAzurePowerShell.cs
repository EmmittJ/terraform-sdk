using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for container in AzurermResourceDeploymentScriptAzurePowerShell.
/// Nesting mode: list
/// </summary>
public class AzurermResourceDeploymentScriptAzurePowerShellContainerBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "container";

    /// <summary>
    /// The container_group_name attribute.
    /// </summary>
    public TerraformValue<string>? ContainerGroupName
    {
        get => GetArgument<TerraformValue<string>>("container_group_name");
        set => SetArgument("container_group_name", value);
    }

}


/// <summary>
/// Block type for environment_variable in AzurermResourceDeploymentScriptAzurePowerShell.
/// Nesting mode: set
/// </summary>
public class AzurermResourceDeploymentScriptAzurePowerShellEnvironmentVariableBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "environment_variable";

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
    /// The secure_value attribute.
    /// </summary>
    public TerraformValue<string>? SecureValue
    {
        get => GetArgument<TerraformValue<string>>("secure_value");
        set => SetArgument("secure_value", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for identity in AzurermResourceDeploymentScriptAzurePowerShell.
/// Nesting mode: list
/// </summary>
public class AzurermResourceDeploymentScriptAzurePowerShellIdentityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "identity";

    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityIds is required")]
    public required TerraformSet<string> IdentityIds
    {
        get => GetRequiredArgument<TerraformSet<string>>("identity_ids");
        set => SetArgument("identity_ids", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for storage_account in AzurermResourceDeploymentScriptAzurePowerShell.
/// Nesting mode: list
/// </summary>
public class AzurermResourceDeploymentScriptAzurePowerShellStorageAccountBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "storage_account";

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetRequiredArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermResourceDeploymentScriptAzurePowerShell.
/// Nesting mode: single
/// </summary>
public class AzurermResourceDeploymentScriptAzurePowerShellTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_resource_deployment_script_azure_power_shell Terraform resource.
/// Manages a azurerm_resource_deployment_script_azure_power_shell resource.
/// </summary>
public partial class AzurermResourceDeploymentScriptAzurePowerShell(string name) : TerraformResource("azurerm_resource_deployment_script_azure_power_shell", name)
{
    /// <summary>
    /// The cleanup_preference attribute.
    /// </summary>
    public TerraformValue<string>? CleanupPreference
    {
        get => GetArgument<TerraformValue<string>>("cleanup_preference");
        set => SetArgument("cleanup_preference", value);
    }

    /// <summary>
    /// The command_line attribute.
    /// </summary>
    public TerraformValue<string>? CommandLine
    {
        get => GetArgument<TerraformValue<string>>("command_line");
        set => SetArgument("command_line", value);
    }

    /// <summary>
    /// The force_update_tag attribute.
    /// </summary>
    public TerraformValue<string>? ForceUpdateTag
    {
        get => GetArgument<TerraformValue<string>>("force_update_tag");
        set => SetArgument("force_update_tag", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

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
    /// The primary_script_uri attribute.
    /// </summary>
    public TerraformValue<string>? PrimaryScriptUri
    {
        get => GetArgument<TerraformValue<string>>("primary_script_uri");
        set => SetArgument("primary_script_uri", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The retention_interval attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RetentionInterval is required")]
    public required TerraformValue<string> RetentionInterval
    {
        get => GetRequiredArgument<TerraformValue<string>>("retention_interval");
        set => SetArgument("retention_interval", value);
    }

    /// <summary>
    /// The script_content attribute.
    /// </summary>
    public TerraformValue<string>? ScriptContent
    {
        get => GetArgument<TerraformValue<string>>("script_content");
        set => SetArgument("script_content", value);
    }

    /// <summary>
    /// The supporting_script_uris attribute.
    /// </summary>
    public TerraformList<string>? SupportingScriptUris
    {
        get => GetArgument<TerraformList<string>>("supporting_script_uris");
        set => SetArgument("supporting_script_uris", value);
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
    /// The timeout attribute.
    /// </summary>
    public TerraformValue<string>? Timeout
    {
        get => GetArgument<TerraformValue<string>>("timeout");
        set => SetArgument("timeout", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    public required TerraformValue<string> Version
    {
        get => GetRequiredArgument<TerraformValue<string>>("version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// The outputs attribute.
    /// </summary>
    public TerraformValue<string> Outputs
        => AsReference("outputs");

    /// <summary>
    /// Container block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Container block(s) allowed")]
    public TerraformList<AzurermResourceDeploymentScriptAzurePowerShellContainerBlock>? Container
    {
        get => GetArgument<TerraformList<AzurermResourceDeploymentScriptAzurePowerShellContainerBlock>>("container");
        set => SetArgument("container", value);
    }

    /// <summary>
    /// EnvironmentVariable block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermResourceDeploymentScriptAzurePowerShellEnvironmentVariableBlock>? EnvironmentVariable
    {
        get => GetArgument<TerraformSet<AzurermResourceDeploymentScriptAzurePowerShellEnvironmentVariableBlock>>("environment_variable");
        set => SetArgument("environment_variable", value);
    }

    /// <summary>
    /// Identity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public TerraformList<AzurermResourceDeploymentScriptAzurePowerShellIdentityBlock>? Identity
    {
        get => GetArgument<TerraformList<AzurermResourceDeploymentScriptAzurePowerShellIdentityBlock>>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// StorageAccount block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageAccount block(s) allowed")]
    public TerraformList<AzurermResourceDeploymentScriptAzurePowerShellStorageAccountBlock>? StorageAccount
    {
        get => GetArgument<TerraformList<AzurermResourceDeploymentScriptAzurePowerShellStorageAccountBlock>>("storage_account");
        set => SetArgument("storage_account", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermResourceDeploymentScriptAzurePowerShellTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermResourceDeploymentScriptAzurePowerShellTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
