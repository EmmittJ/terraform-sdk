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
/// Block type for metadata in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerAppEnvironmentDaprComponentMetadataBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "metadata";

    /// <summary>
    /// The name of the Metadata configuration item.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The name of a secret specified in the `secrets` block that contains the value for this metadata configuration item.
    /// </summary>
    [TerraformArgument("secret_name")]
    public TerraformValue<string>? SecretName
    {
        get => new TerraformReference<string>(this, "secret_name");
        set => SetArgument("secret_name", value);
    }

    /// <summary>
    /// The value for this metadata configuration item.
    /// </summary>
    [TerraformArgument("value")]
    public TerraformValue<string>? Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for secret in .
/// Nesting mode: set
/// </summary>
public class AzurermContainerAppEnvironmentDaprComponentSecretBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "secret";

    /// <summary>
    /// The identity to use for accessing key vault reference.
    /// </summary>
    [TerraformArgument("identity")]
    public TerraformValue<string>? Identity
    {
        get => new TerraformReference<string>(this, "identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// The Key Vault Secret ID. Could be either one of `id` or `versionless_id`.
    /// </summary>
    [TerraformArgument("key_vault_secret_id")]
    public TerraformValue<string>? KeyVaultSecretId
    {
        get => new TerraformReference<string>(this, "key_vault_secret_id");
        set => SetArgument("key_vault_secret_id", value);
    }

    /// <summary>
    /// The secret name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The value for this secret.
    /// </summary>
    [TerraformArgument("value")]
    public TerraformValue<string>? Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermContainerAppEnvironmentDaprComponentTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_container_app_environment_dapr_component resource.
/// </summary>
public class AzurermContainerAppEnvironmentDaprComponent : TerraformResource
{
    public AzurermContainerAppEnvironmentDaprComponent(string name) : base("azurerm_container_app_environment_dapr_component", name)
    {
    }

    /// <summary>
    /// The Dapr Component Type. For example `state.azure.blobstorage`.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComponentType is required")]
    [TerraformArgument("component_type")]
    public required TerraformValue<string> ComponentType
    {
        get => new TerraformReference<string>(this, "component_type");
        set => SetArgument("component_type", value);
    }

    /// <summary>
    /// The Container App Managed Environment ID to configure this Dapr component on.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerAppEnvironmentId is required")]
    [TerraformArgument("container_app_environment_id")]
    public required TerraformValue<string> ContainerAppEnvironmentId
    {
        get => new TerraformReference<string>(this, "container_app_environment_id");
        set => SetArgument("container_app_environment_id", value);
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
    /// Should the Dapr sidecar to continue initialisation if the component fails to load. Defaults to `false`
    /// </summary>
    [TerraformArgument("ignore_errors")]
    public TerraformValue<bool>? IgnoreErrors
    {
        get => new TerraformReference<bool>(this, "ignore_errors");
        set => SetArgument("ignore_errors", value);
    }

    /// <summary>
    /// The component initialisation timeout in ISO8601 format. e.g. `5s`, `2h`, `1m`. Defaults to `5s`.
    /// </summary>
    [TerraformArgument("init_timeout")]
    public TerraformValue<string>? InitTimeout
    {
        get => new TerraformReference<string>(this, "init_timeout");
        set => SetArgument("init_timeout", value);
    }

    /// <summary>
    /// The name for this Dapr Component.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// A list of scopes to which this component applies. e.g. a Container App&#39;s `dapr.app_id` value.
    /// </summary>
    [TerraformArgument("scopes")]
    public TerraformList<string>? Scopes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "scopes").ResolveNodes(ctx));
        set => SetArgument("scopes", value);
    }

    /// <summary>
    /// The version of the component.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    [TerraformArgument("version")]
    public required TerraformValue<string> Version
    {
        get => new TerraformReference<string>(this, "version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// Block for metadata.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("metadata")]
    public TerraformList<AzurermContainerAppEnvironmentDaprComponentMetadataBlock> Metadata { get; set; } = new();

    /// <summary>
    /// Block for secret.
    /// Nesting mode: set
    /// </summary>
    [TerraformArgument("secret")]
    public TerraformSet<AzurermContainerAppEnvironmentDaprComponentSecretBlock> Secret { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermContainerAppEnvironmentDaprComponentTimeoutsBlock Timeouts { get; set; } = new();

}
