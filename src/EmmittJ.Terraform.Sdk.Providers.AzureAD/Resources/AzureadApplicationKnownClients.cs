using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Manages a azuread_application_known_clients resource.
/// </summary>
public class AzureadApplicationKnownClients : TerraformResource
{
    public AzureadApplicationKnownClients(string name) : base("azuread_application_known_clients", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The resource ID of the application to which this API access is granted
    /// </summary>
    public TerraformProperty<string>? ApplicationId
    {
        get => GetProperty<TerraformProperty<string>>("application_id");
        set => this.WithProperty("application_id", value);
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
    /// A list of known client IDs, used for bundling consent if you have a solution that includes an API and a client application
    /// </summary>
    public TerraformProperty<HashSet<string>>? KnownClientIds
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("known_client_ids");
        set => this.WithProperty("known_client_ids", value);
    }

}
