using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadClientConfigDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

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
        SetOutput("client_id");
        SetOutput("object_id");
        SetOutput("tenant_id");
        SetOutput("id");
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzureadClientConfigDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
