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
    }

    /// <summary>
    /// A set of claim values for delegated permission scopes which should be included in access tokens for the resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClaimValues is required")]
    public HashSet<TerraformProperty<string>>? ClaimValues
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("claim_values");
        set => this.WithProperty("claim_values", value);
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
    /// The object ID of the service principal representing the resource to be accessed
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceServicePrincipalObjectId is required")]
    public required TerraformProperty<string> ResourceServicePrincipalObjectId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("resource_service_principal_object_id");
        set => this.WithProperty("resource_service_principal_object_id", value);
    }

    /// <summary>
    /// The object ID of the service principal for which this delegated permission grant should be created
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServicePrincipalObjectId is required")]
    public required TerraformProperty<string> ServicePrincipalObjectId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("service_principal_object_id");
        set => this.WithProperty("service_principal_object_id", value);
    }

    /// <summary>
    /// The object ID of the user on behalf of whom the service principal is authorized to access the resource
    /// </summary>
    public TerraformProperty<string>? UserObjectId
    {
        get => GetProperty<TerraformProperty<string>>("user_object_id");
        set => this.WithProperty("user_object_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzureadServicePrincipalDelegatedPermissionGrantTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzureadServicePrincipalDelegatedPermissionGrantTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
