using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

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
    public TerraformProperty<string>? ApplicationId
    {
        get => GetProperty<TerraformProperty<string>>("application_id");
        set => this.WithProperty("application_id", value);
    }

    /// <summary>
    /// The client ID of the pre-authorized application
    /// </summary>
    public TerraformProperty<string>? AuthorizedClientId
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
    public TerraformProperty<HashSet<string>>? PermissionIds
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("permission_ids");
        set => this.WithProperty("permission_ids", value);
    }

}
