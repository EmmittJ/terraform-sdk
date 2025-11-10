using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadServicePrincipalDelegatedPermissionGrantTimeoutsBlock : TerraformBlock
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
/// Manages a azuread_service_principal_delegated_permission_grant resource.
/// </summary>
public class AzureadServicePrincipalDelegatedPermissionGrant : TerraformResource
{
    public AzureadServicePrincipalDelegatedPermissionGrant(string name) : base("azuread_service_principal_delegated_permission_grant", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("claim_values");
        SetOutput("id");
        SetOutput("resource_service_principal_object_id");
        SetOutput("service_principal_object_id");
        SetOutput("user_object_id");
    }

    /// <summary>
    /// A set of claim values for delegated permission scopes which should be included in access tokens for the resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClaimValues is required")]
    public HashSet<TerraformProperty<string>> ClaimValues
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("claim_values");
        set => SetProperty("claim_values", value);
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
    /// The object ID of the service principal representing the resource to be accessed
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceServicePrincipalObjectId is required")]
    public required TerraformProperty<string> ResourceServicePrincipalObjectId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_service_principal_object_id");
        set => SetProperty("resource_service_principal_object_id", value);
    }

    /// <summary>
    /// The object ID of the service principal for which this delegated permission grant should be created
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServicePrincipalObjectId is required")]
    public required TerraformProperty<string> ServicePrincipalObjectId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service_principal_object_id");
        set => SetProperty("service_principal_object_id", value);
    }

    /// <summary>
    /// The object ID of the user on behalf of whom the service principal is authorized to access the resource
    /// </summary>
    public TerraformProperty<string> UserObjectId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("user_object_id");
        set => SetProperty("user_object_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzureadServicePrincipalDelegatedPermissionGrantTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
