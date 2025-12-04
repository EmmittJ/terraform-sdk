using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for rbac_authorization in AzurermDataFactoryIntegrationRuntimeSelfHosted.
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
    public required TerraformValue<string> ResourceId
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_id");
        set => SetArgument("resource_id", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermDataFactoryIntegrationRuntimeSelfHosted.
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
/// Represents a azurerm_data_factory_integration_runtime_self_hosted Terraform resource.
/// Manages a azurerm_data_factory_integration_runtime_self_hosted resource.
/// </summary>
public partial class AzurermDataFactoryIntegrationRuntimeSelfHosted(string name) : TerraformResource("azurerm_data_factory_integration_runtime_self_hosted", name)
{
    /// <summary>
    /// The data_factory_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataFactoryId is required")]
    public required TerraformValue<string> DataFactoryId
    {
        get => GetRequiredArgument<TerraformValue<string>>("data_factory_id");
        set => SetArgument("data_factory_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The self_contained_interactive_authoring_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? SelfContainedInteractiveAuthoringEnabled
    {
        get => GetArgument<TerraformValue<bool>>("self_contained_interactive_authoring_enabled");
        set => SetArgument("self_contained_interactive_authoring_enabled", value);
    }

    /// <summary>
    /// The primary_authorization_key attribute.
    /// </summary>
    public TerraformValue<string> PrimaryAuthorizationKey
        => AsReference("primary_authorization_key");

    /// <summary>
    /// The secondary_authorization_key attribute.
    /// </summary>
    public TerraformValue<string> SecondaryAuthorizationKey
        => AsReference("secondary_authorization_key");

    /// <summary>
    /// RbacAuthorization block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermDataFactoryIntegrationRuntimeSelfHostedRbacAuthorizationBlock>? RbacAuthorization
    {
        get => GetArgument<TerraformSet<AzurermDataFactoryIntegrationRuntimeSelfHostedRbacAuthorizationBlock>>("rbac_authorization");
        set => SetArgument("rbac_authorization", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermDataFactoryIntegrationRuntimeSelfHostedTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermDataFactoryIntegrationRuntimeSelfHostedTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
