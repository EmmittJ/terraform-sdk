using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

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
    }

    /// <summary>
    /// The client ID of the API to which access is being granted
    /// </summary>
    public string? ApiClientId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("api_client_id")?.Value;
        set => this.WithProperty("api_client_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource ID of the application to which this API access is granted
    /// </summary>
    public string? ApplicationId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("application_id")?.Value;
        set => this.WithProperty("application_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// A set of role IDs to be granted to the application, as published by the API
    /// </summary>
    public HashSet<string>? RoleIds
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("role_ids")?.Value;
        set => this.WithProperty("role_ids", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// A set of scope IDs to be granted to the application, as published by the API
    /// </summary>
    public HashSet<string>? ScopeIds
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("scope_ids")?.Value;
        set => this.WithProperty("scope_ids", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

}
