using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_synapse_integration_runtime_self_hosted resource.
/// </summary>
public class AzurermSynapseIntegrationRuntimeSelfHosted : TerraformResource
{
    public AzurermSynapseIntegrationRuntimeSelfHosted(string name) : base("azurerm_synapse_integration_runtime_self_hosted", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("authorization_key_primary");
        this.DeclareOutput("authorization_key_secondary");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The synapse_workspace_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SynapseWorkspaceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("synapse_workspace_id");
        set => this.WithProperty("synapse_workspace_id", value);
    }

    /// <summary>
    /// The authorization_key_primary attribute.
    /// </summary>
    public TerraformExpression AuthorizationKeyPrimary => this["authorization_key_primary"];

    /// <summary>
    /// The authorization_key_secondary attribute.
    /// </summary>
    public TerraformExpression AuthorizationKeySecondary => this["authorization_key_secondary"];

}
