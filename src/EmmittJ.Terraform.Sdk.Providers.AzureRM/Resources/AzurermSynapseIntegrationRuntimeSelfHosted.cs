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
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The synapse_workspace_id attribute.
    /// </summary>
    public string? SynapseWorkspaceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("synapse_workspace_id")?.Value;
        set => this.WithProperty("synapse_workspace_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
