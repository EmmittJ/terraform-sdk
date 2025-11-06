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
    public HashSet<string>? ClaimValues
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("claim_values")?.Value;
        set => this.WithProperty("claim_values", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The object ID of the service principal representing the resource to be accessed
    /// </summary>
    public string? ResourceServicePrincipalObjectId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_service_principal_object_id")?.Value;
        set => this.WithProperty("resource_service_principal_object_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The object ID of the service principal for which this delegated permission grant should be created
    /// </summary>
    public string? ServicePrincipalObjectId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_principal_object_id")?.Value;
        set => this.WithProperty("service_principal_object_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The object ID of the user on behalf of whom the service principal is authorized to access the resource
    /// </summary>
    public string? UserObjectId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("user_object_id")?.Value;
        set => this.WithProperty("user_object_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
