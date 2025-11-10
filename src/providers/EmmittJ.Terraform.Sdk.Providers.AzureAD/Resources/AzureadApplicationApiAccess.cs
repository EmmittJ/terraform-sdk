using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadApplicationApiAccessTimeoutsBlock : TerraformBlock
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
/// Manages a azuread_application_api_access resource.
/// </summary>
public class AzureadApplicationApiAccess : TerraformResource
{
    public AzureadApplicationApiAccess(string name) : base("azuread_application_api_access", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("api_client_id");
        SetOutput("application_id");
        SetOutput("id");
        SetOutput("role_ids");
        SetOutput("scope_ids");
    }

    /// <summary>
    /// The client ID of the API to which access is being granted
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiClientId is required")]
    public required TerraformProperty<string> ApiClientId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("api_client_id");
        set => SetProperty("api_client_id", value);
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
    /// A set of role IDs to be granted to the application, as published by the API
    /// </summary>
    public HashSet<TerraformProperty<string>> RoleIds
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("role_ids");
        set => SetProperty("role_ids", value);
    }

    /// <summary>
    /// A set of scope IDs to be granted to the application, as published by the API
    /// </summary>
    public HashSet<TerraformProperty<string>> ScopeIds
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("scope_ids");
        set => SetProperty("scope_ids", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzureadApplicationApiAccessTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
