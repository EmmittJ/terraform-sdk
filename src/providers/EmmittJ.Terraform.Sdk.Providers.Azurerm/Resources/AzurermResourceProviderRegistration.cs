using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for feature in AzurermResourceProviderRegistration.
/// Nesting mode: set
/// </summary>
public class AzurermResourceProviderRegistrationFeatureBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "feature";

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
    /// The registered attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Registered is required")]
    public required TerraformValue<bool> Registered
    {
        get => GetRequiredArgument<TerraformValue<bool>>("registered");
        set => SetArgument("registered", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermResourceProviderRegistration.
/// Nesting mode: single
/// </summary>
public class AzurermResourceProviderRegistrationTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_resource_provider_registration Terraform resource.
/// Manages a azurerm_resource_provider_registration resource.
/// </summary>
public partial class AzurermResourceProviderRegistration(string name) : TerraformResource("azurerm_resource_provider_registration", name)
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Feature block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermResourceProviderRegistrationFeatureBlock>? Feature
    {
        get => GetArgument<TerraformSet<AzurermResourceProviderRegistrationFeatureBlock>>("feature");
        set => SetArgument("feature", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermResourceProviderRegistrationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermResourceProviderRegistrationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
