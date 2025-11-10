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
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
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
    }

    /// <summary>
    /// The resource ID of the application to which this pre-authorized application should be added
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationId is required")]
    public required TerraformProperty<string> ApplicationId
    {
        get => GetProperty<TerraformProperty<string>>("application_id");
        set => this.WithProperty("application_id", value);
    }

    /// <summary>
    /// The client ID of the pre-authorized application
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthorizedClientId is required")]
    public required TerraformProperty<string> AuthorizedClientId
    {
        get => GetProperty<TerraformProperty<string>>("authorized_client_id");
        set => this.WithProperty("authorized_client_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The IDs of the permission scopes required by the pre-authorized application
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PermissionIds is required")]
    public HashSet<TerraformProperty<string>>? PermissionIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("permission_ids");
        set => this.WithProperty("permission_ids", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzureadApplicationPreAuthorizedTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzureadApplicationPreAuthorizedTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
