using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_network_manager_verifier_workspace_reachability_analysis_intent resource.
/// </summary>
public class AzurermNetworkManagerVerifierWorkspaceReachabilityAnalysisIntent : TerraformResource
{
    public AzurermNetworkManagerVerifierWorkspaceReachabilityAnalysisIntent(string name) : base("azurerm_network_manager_verifier_workspace_reachability_analysis_intent", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The destination_resource_id attribute.
    /// </summary>
    public TerraformProperty<string>? DestinationResourceId
    {
        get => GetProperty<TerraformProperty<string>>("destination_resource_id");
        set => this.WithProperty("destination_resource_id", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The source_resource_id attribute.
    /// </summary>
    public TerraformProperty<string>? SourceResourceId
    {
        get => GetProperty<TerraformProperty<string>>("source_resource_id");
        set => this.WithProperty("source_resource_id", value);
    }

    /// <summary>
    /// The verifier_workspace_id attribute.
    /// </summary>
    public TerraformProperty<string>? VerifierWorkspaceId
    {
        get => GetProperty<TerraformProperty<string>>("verifier_workspace_id");
        set => this.WithProperty("verifier_workspace_id", value);
    }

}
