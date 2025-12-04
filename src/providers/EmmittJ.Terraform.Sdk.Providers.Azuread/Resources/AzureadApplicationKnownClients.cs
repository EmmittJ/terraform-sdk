using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azuread;

/// <summary>
/// Block type for timeouts in AzureadApplicationKnownClients.
/// Nesting mode: single
/// </summary>
public class AzureadApplicationKnownClientsTimeoutsBlock : TerraformBlock
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
/// Represents a azuread_application_known_clients Terraform resource.
/// Manages a azuread_application_known_clients resource.
/// </summary>
public partial class AzureadApplicationKnownClients(string name) : TerraformResource("azuread_application_known_clients", name)
{
    /// <summary>
    /// The resource ID of the application to which this API access is granted
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationId is required")]
    public required TerraformValue<string> ApplicationId
    {
        get => GetArgument<TerraformValue<string>>("application_id");
        set => SetArgument("application_id", value);
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
    /// A list of known client IDs, used for bundling consent if you have a solution that includes an API and a client application
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KnownClientIds is required")]
    public required TerraformSet<string> KnownClientIds
    {
        get => GetArgument<TerraformSet<string>>("known_client_ids");
        set => SetArgument("known_client_ids", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzureadApplicationKnownClientsTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzureadApplicationKnownClientsTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
