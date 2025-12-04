using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for action in AzurermCustomProvider.
/// Nesting mode: set
/// </summary>
public class AzurermCustomProviderActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "action";

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Endpoint is required")]
    public required TerraformValue<string> Endpoint
    {
        get => GetRequiredArgument<TerraformValue<string>>("endpoint");
        set => SetArgument("endpoint", value);
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
/// Block type for resource_type in AzurermCustomProvider.
/// Nesting mode: set
/// </summary>
public class AzurermCustomProviderResourceTypeAttributeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "resource_type";

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Endpoint is required")]
    public required TerraformValue<string> Endpoint
    {
        get => GetRequiredArgument<TerraformValue<string>>("endpoint");
        set => SetArgument("endpoint", value);
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
    /// The routing_type attribute.
    /// </summary>
    public TerraformValue<string>? RoutingType
    {
        get => GetArgument<TerraformValue<string>>("routing_type");
        set => SetArgument("routing_type", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermCustomProvider.
/// Nesting mode: single
/// </summary>
public class AzurermCustomProviderTimeoutsBlock : TerraformBlock
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
/// Block type for validation in AzurermCustomProvider.
/// Nesting mode: set
/// </summary>
public class AzurermCustomProviderValidationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "validation";

    /// <summary>
    /// The specification attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Specification is required")]
    public required TerraformValue<string> Specification
    {
        get => GetRequiredArgument<TerraformValue<string>>("specification");
        set => SetArgument("specification", value);
    }

}


/// <summary>
/// Represents a azurerm_custom_provider Terraform resource.
/// Manages a azurerm_custom_provider resource.
/// </summary>
public partial class AzurermCustomProvider(string name) : TerraformResource("azurerm_custom_provider", name)
{
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
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
    /// Action block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermCustomProviderActionBlock>? Action
    {
        get => GetArgument<TerraformSet<AzurermCustomProviderActionBlock>>("action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// ResourceTypeAttribute block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermCustomProviderResourceTypeAttributeBlock>? ResourceTypeAttribute
    {
        get => GetArgument<TerraformSet<AzurermCustomProviderResourceTypeAttributeBlock>>("resource_type");
        set => SetArgument("resource_type", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermCustomProviderTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermCustomProviderTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// Validation block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermCustomProviderValidationBlock>? Validation
    {
        get => GetArgument<TerraformSet<AzurermCustomProviderValidationBlock>>("validation");
        set => SetArgument("validation", value);
    }

}
