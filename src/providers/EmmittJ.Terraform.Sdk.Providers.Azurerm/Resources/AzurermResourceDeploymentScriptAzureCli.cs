using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for container in AzurermResourceDeploymentScriptAzureCli.
/// Nesting mode: list
/// </summary>
public class AzurermResourceDeploymentScriptAzureCliContainerBlock : TerraformBlock
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
/// Block type for environment_variable in AzurermResourceDeploymentScriptAzureCli.
/// Nesting mode: set
/// </summary>
public class AzurermResourceDeploymentScriptAzureCliEnvironmentVariableBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("name");
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
/// Block type for identity in AzurermResourceDeploymentScriptAzureCli.
/// Nesting mode: list
/// </summary>
public class AzurermResourceDeploymentScriptAzureCliIdentityBlock : TerraformBlock
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
        get => GetArgument<TerraformSet<string>>("identity_ids");
        set => SetArgument("identity_ids", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for storage_account in AzurermResourceDeploymentScriptAzureCli.
/// Nesting mode: list
/// </summary>
public class AzurermResourceDeploymentScriptAzureCliStorageAccountBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
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

}


/// <summary>
/// Block type for timeouts in AzurermResourceDeploymentScriptAzureCli.
/// Nesting mode: single
/// </summary>
public class AzurermResourceDeploymentScriptAzureCliTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_resource_deployment_script_azure_cli Terraform resource.
/// Manages a azurerm_resource_deployment_script_azure_cli resource.
/// </summary>
public partial class AzurermResourceDeploymentScriptAzureCli(string name) : TerraformResource("azurerm_resource_deployment_script_azure_cli", name)
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
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The retention_interval attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RetentionInterval is required")]
    public required TerraformValue<string> RetentionInterval
    {
        get => GetArgument<TerraformValue<string>>("retention_interval");
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
        get => GetArgument<TerraformValue<string>>("version");
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
    public TerraformList<AzurermResourceDeploymentScriptAzureCliContainerBlock>? Container
    {
        get => GetArgument<TerraformList<AzurermResourceDeploymentScriptAzureCliContainerBlock>>("container");
        set => SetArgument("container", value);
    }

    /// <summary>
    /// EnvironmentVariable block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermResourceDeploymentScriptAzureCliEnvironmentVariableBlock>? EnvironmentVariable
    {
        get => GetArgument<TerraformSet<AzurermResourceDeploymentScriptAzureCliEnvironmentVariableBlock>>("environment_variable");
        set => SetArgument("environment_variable", value);
    }

    /// <summary>
    /// Identity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public TerraformList<AzurermResourceDeploymentScriptAzureCliIdentityBlock>? Identity
    {
        get => GetArgument<TerraformList<AzurermResourceDeploymentScriptAzureCliIdentityBlock>>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// StorageAccount block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageAccount block(s) allowed")]
    public TerraformList<AzurermResourceDeploymentScriptAzureCliStorageAccountBlock>? StorageAccount
    {
        get => GetArgument<TerraformList<AzurermResourceDeploymentScriptAzureCliStorageAccountBlock>>("storage_account");
        set => SetArgument("storage_account", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermResourceDeploymentScriptAzureCliTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermResourceDeploymentScriptAzureCliTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
