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
    public string? ApplicationId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("application_id")?.Value;
        set => this.WithProperty("application_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The client ID of the pre-authorized application
    /// </summary>
    public string? AuthorizedClientId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("authorized_client_id")?.Value;
        set => this.WithProperty("authorized_client_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The IDs of the permission scopes required by the pre-authorized application
    /// </summary>
    public HashSet<string>? PermissionIds
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("permission_ids")?.Value;
        set => this.WithProperty("permission_ids", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

}
