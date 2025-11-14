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
/// Block type for container in .
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
    [TerraformArgument("container_group_name")]
    public TerraformValue<string>? ContainerGroupName
    {
        get => new TerraformReference<string>(this, "container_group_name");
        set => SetArgument("container_group_name", value);
    }

}

/// <summary>
/// Block type for environment_variable in .
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
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The secure_value attribute.
    /// </summary>
    [TerraformArgument("secure_value")]
    public TerraformValue<string>? SecureValue
    {
        get => new TerraformReference<string>(this, "secure_value");
        set => SetArgument("secure_value", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [TerraformArgument("value")]
    public TerraformValue<string>? Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for identity in .
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
    [TerraformArgument("identity_ids")]
    public required TerraformSet<string> IdentityIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "identity_ids").ResolveNodes(ctx));
        set => SetArgument("identity_ids", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformArgument("type")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for storage_account in .
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
    [TerraformArgument("key")]
    public required TerraformValue<string> Key
    {
        get => new TerraformReference<string>(this, "key");
        set => SetArgument("key", value);
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

}

/// <summary>
/// Block type for timeouts in .
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
/// Manages a azurerm_resource_deployment_script_azure_power_shell resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermResourceDeploymentScriptAzurePowerShell : TerraformResource
{
    public AzurermResourceDeploymentScriptAzurePowerShell(string name) : base("azurerm_resource_deployment_script_azure_power_shell", name)
    {
    }

    /// <summary>
    /// The cleanup_preference attribute.
    /// </summary>
    [TerraformArgument("cleanup_preference")]
    public TerraformValue<string>? CleanupPreference
    {
        get => new TerraformReference<string>(this, "cleanup_preference");
        set => SetArgument("cleanup_preference", value);
    }

    /// <summary>
    /// The command_line attribute.
    /// </summary>
    [TerraformArgument("command_line")]
    public TerraformValue<string>? CommandLine
    {
        get => new TerraformReference<string>(this, "command_line");
        set => SetArgument("command_line", value);
    }

    /// <summary>
    /// The force_update_tag attribute.
    /// </summary>
    [TerraformArgument("force_update_tag")]
    public TerraformValue<string>? ForceUpdateTag
    {
        get => new TerraformReference<string>(this, "force_update_tag");
        set => SetArgument("force_update_tag", value);
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
    /// The primary_script_uri attribute.
    /// </summary>
    [TerraformArgument("primary_script_uri")]
    public TerraformValue<string>? PrimaryScriptUri
    {
        get => new TerraformReference<string>(this, "primary_script_uri");
        set => SetArgument("primary_script_uri", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The retention_interval attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RetentionInterval is required")]
    [TerraformArgument("retention_interval")]
    public required TerraformValue<string> RetentionInterval
    {
        get => new TerraformReference<string>(this, "retention_interval");
        set => SetArgument("retention_interval", value);
    }

    /// <summary>
    /// The script_content attribute.
    /// </summary>
    [TerraformArgument("script_content")]
    public TerraformValue<string>? ScriptContent
    {
        get => new TerraformReference<string>(this, "script_content");
        set => SetArgument("script_content", value);
    }

    /// <summary>
    /// The supporting_script_uris attribute.
    /// </summary>
    [TerraformArgument("supporting_script_uris")]
    public TerraformList<string>? SupportingScriptUris
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "supporting_script_uris").ResolveNodes(ctx));
        set => SetArgument("supporting_script_uris", value);
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
    /// The timeout attribute.
    /// </summary>
    [TerraformArgument("timeout")]
    public TerraformValue<string>? Timeout
    {
        get => new TerraformReference<string>(this, "timeout");
        set => SetArgument("timeout", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    [TerraformArgument("version")]
    public required TerraformValue<string> Version
    {
        get => new TerraformReference<string>(this, "version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// Block for container.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Container block(s) allowed")]
    [TerraformArgument("container")]
    public TerraformList<AzurermResourceDeploymentScriptAzurePowerShellContainerBlock> Container { get; set; } = new();

    /// <summary>
    /// Block for environment_variable.
    /// Nesting mode: set
    /// </summary>
    [TerraformArgument("environment_variable")]
    public TerraformSet<AzurermResourceDeploymentScriptAzurePowerShellEnvironmentVariableBlock> EnvironmentVariable { get; set; } = new();

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformArgument("identity")]
    public TerraformList<AzurermResourceDeploymentScriptAzurePowerShellIdentityBlock> Identity { get; set; } = new();

    /// <summary>
    /// Block for storage_account.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageAccount block(s) allowed")]
    [TerraformArgument("storage_account")]
    public TerraformList<AzurermResourceDeploymentScriptAzurePowerShellStorageAccountBlock> StorageAccount { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermResourceDeploymentScriptAzurePowerShellTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The outputs attribute.
    /// </summary>
    [TerraformArgument("outputs")]
    public TerraformValue<string> Outputs
    {
        get => new TerraformReference<string>(this, "outputs");
    }

}
