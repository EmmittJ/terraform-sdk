using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadApplicationKnownClientsTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a azuread_application_known_clients resource.
/// </summary>
public class AzureadApplicationKnownClients : TerraformResource
{
    public AzureadApplicationKnownClients(string name) : base("azuread_application_known_clients", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("application_id");
        SetOutput("id");
        SetOutput("known_client_ids");
    }

    /// <summary>
    /// The resource ID of the application to which this API access is granted
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationId is required")]
    public required TerraformProperty<string> ApplicationId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("application_id");
        set => SetProperty("application_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// A list of known client IDs, used for bundling consent if you have a solution that includes an API and a client application
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KnownClientIds is required")]
    public HashSet<TerraformProperty<string>> KnownClientIds
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("known_client_ids");
        set => SetProperty("known_client_ids", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzureadApplicationKnownClientsTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
