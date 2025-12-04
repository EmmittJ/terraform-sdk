using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azuread;

/// <summary>
/// Block type for timeouts in AzureadApplicationOwner.
/// Nesting mode: single
/// </summary>
public class AzureadApplicationOwnerTimeoutsBlock : TerraformBlock
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

}


/// <summary>
/// Represents a azuread_application_owner Terraform resource.
/// Manages a azuread_application_owner resource.
/// </summary>
public partial class AzureadApplicationOwner(string name) : TerraformResource("azuread_application_owner", name)
{
    /// <summary>
    /// The resource ID of the application to which the owner should be added
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationId is required")]
    public required TerraformValue<string> ApplicationId
    {
        get => GetRequiredArgument<TerraformValue<string>>("application_id");
        set => SetArgument("application_id", value);
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
    /// Object ID of the principal that will be granted ownership of the application
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OwnerObjectId is required")]
    public required TerraformValue<string> OwnerObjectId
    {
        get => GetRequiredArgument<TerraformValue<string>>("owner_object_id");
        set => SetArgument("owner_object_id", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzureadApplicationOwnerTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzureadApplicationOwnerTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
