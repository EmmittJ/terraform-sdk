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
    public TerraformLiteralProperty<string>? ApplicationId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("application_id");
        set => this.WithProperty("application_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// A list of known client IDs, used for bundling consent if you have a solution that includes an API and a client application
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? KnownClientIds
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("known_client_ids");
        set => this.WithProperty("known_client_ids", value);
    }

}
