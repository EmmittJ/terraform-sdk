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
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The registered attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Registered is required")]
    public required TerraformValue<bool> Registered
    {
        get => new TerraformReference<bool>(this, "registered");
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
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
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
