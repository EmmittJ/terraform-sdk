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
/// Block type for rbac_authorization in .
/// Nesting mode: set
/// </summary>
public class AzurermDataFactoryIntegrationRuntimeSelfHostedRbacAuthorizationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rbac_authorization";

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceId is required")]
    [TerraformArgument("resource_id")]
    public required TerraformValue<string> ResourceId
    {
        get => new TerraformReference<string>(this, "resource_id");
        set => SetArgument("resource_id", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDataFactoryIntegrationRuntimeSelfHostedTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_data_factory_integration_runtime_self_hosted resource.
/// </summary>
public class AzurermDataFactoryIntegrationRuntimeSelfHosted : TerraformResource
{
    public AzurermDataFactoryIntegrationRuntimeSelfHosted(string name) : base("azurerm_data_factory_integration_runtime_self_hosted", name)
    {
    }

    /// <summary>
    /// The data_factory_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataFactoryId is required")]
    [TerraformArgument("data_factory_id")]
    public required TerraformValue<string> DataFactoryId
    {
        get => new TerraformReference<string>(this, "data_factory_id");
        set => SetArgument("data_factory_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformArgument("description")]
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
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
    /// The self_contained_interactive_authoring_enabled attribute.
    /// </summary>
    [TerraformArgument("self_contained_interactive_authoring_enabled")]
    public TerraformValue<bool>? SelfContainedInteractiveAuthoringEnabled
    {
        get => new TerraformReference<bool>(this, "self_contained_interactive_authoring_enabled");
        set => SetArgument("self_contained_interactive_authoring_enabled", value);
    }

    /// <summary>
    /// Block for rbac_authorization.
    /// Nesting mode: set
    /// </summary>
    [TerraformArgument("rbac_authorization")]
    public TerraformSet<AzurermDataFactoryIntegrationRuntimeSelfHostedRbacAuthorizationBlock> RbacAuthorization { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermDataFactoryIntegrationRuntimeSelfHostedTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The primary_authorization_key attribute.
    /// </summary>
    [TerraformArgument("primary_authorization_key")]
    public TerraformValue<string> PrimaryAuthorizationKey
    {
        get => new TerraformReference<string>(this, "primary_authorization_key");
    }

    /// <summary>
    /// The secondary_authorization_key attribute.
    /// </summary>
    [TerraformArgument("secondary_authorization_key")]
    public TerraformValue<string> SecondaryAuthorizationKey
    {
        get => new TerraformReference<string>(this, "secondary_authorization_key");
    }

}
