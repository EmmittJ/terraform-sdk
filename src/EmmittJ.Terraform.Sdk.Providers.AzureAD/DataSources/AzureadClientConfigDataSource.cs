using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Retrieves information about a azuread_client_config.
/// </summary>
public class AzureadClientConfigDataSource : TerraformDataSource
{
    public AzureadClientConfigDataSource(string name) : base("azuread_client_config", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("client_id");
        this.DeclareOutput("object_id");
        this.DeclareOutput("tenant_id");
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
    /// The client ID (application ID) linked to the authenticated principal, or the application used for delegated authentication
    /// </summary>
    public TerraformExpression ClientId => this["client_id"];

    /// <summary>
    /// The object ID of the authenticated principal
    /// </summary>
    public TerraformExpression ObjectId => this["object_id"];

    /// <summary>
    /// The tenant ID of the authenticated principal
    /// </summary>
    public TerraformExpression TenantId => this["tenant_id"];

}
