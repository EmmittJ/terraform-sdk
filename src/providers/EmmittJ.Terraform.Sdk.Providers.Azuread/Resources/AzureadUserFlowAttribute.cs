using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azuread;

/// <summary>
/// Block type for timeouts in AzureadUserFlowAttribute.
/// Nesting mode: single
/// </summary>
public class AzureadUserFlowAttributeTimeoutsBlock : TerraformBlock
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
/// Represents a azuread_user_flow_attribute Terraform resource.
/// Manages a azuread_user_flow_attribute resource.
/// </summary>
public partial class AzureadUserFlowAttribute(string name) : TerraformResource("azuread_user_flow_attribute", name)
{
    /// <summary>
    /// The data type of the user flow attribute
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataType is required")]
    public required TerraformValue<string> DataType
    {
        get => GetRequiredArgument<TerraformValue<string>>("data_type");
        set => SetArgument("data_type", value);
    }

    /// <summary>
    /// The description of the user flow attribute that is shown to the user at the time of sign-up
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Description is required")]
    public required TerraformValue<string> Description
    {
        get => GetRequiredArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The display name of the user flow attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => GetRequiredArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
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
    /// The type of the user flow attribute
    /// </summary>
    public TerraformValue<string> AttributeType
        => AsReference("attribute_type");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzureadUserFlowAttributeTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzureadUserFlowAttributeTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
