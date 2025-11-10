using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadApplicationPreAuthorizedTimeoutsBlock : TerraformBlock
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
/// Manages a azuread_application_pre_authorized resource.
/// </summary>
public class AzureadApplicationPreAuthorized : TerraformResource
{
    public AzureadApplicationPreAuthorized(string name) : base("azuread_application_pre_authorized", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("application_id");
        SetOutput("authorized_client_id");
        SetOutput("id");
        SetOutput("permission_ids");
    }

    /// <summary>
    /// The resource ID of the application to which this pre-authorized application should be added
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationId is required")]
    public required TerraformProperty<string> ApplicationId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("application_id");
        set => SetProperty("application_id", value);
    }

    /// <summary>
    /// The client ID of the pre-authorized application
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthorizedClientId is required")]
    public required TerraformProperty<string> AuthorizedClientId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("authorized_client_id");
        set => SetProperty("authorized_client_id", value);
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
    /// The IDs of the permission scopes required by the pre-authorized application
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PermissionIds is required")]
    public HashSet<TerraformProperty<string>> PermissionIds
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("permission_ids");
        set => SetProperty("permission_ids", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzureadApplicationPreAuthorizedTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
