using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

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
    public TerraformProperty<HashSet<string>>? ClaimValues
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("claim_values");
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
    public TerraformProperty<string>? ResourceServicePrincipalObjectId
    {
        get => GetProperty<TerraformProperty<string>>("resource_service_principal_object_id");
        set => this.WithProperty("resource_service_principal_object_id", value);
    }

    /// <summary>
    /// The object ID of the service principal for which this delegated permission grant should be created
    /// </summary>
    public TerraformProperty<string>? ServicePrincipalObjectId
    {
        get => GetProperty<TerraformProperty<string>>("service_principal_object_id");
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

}
