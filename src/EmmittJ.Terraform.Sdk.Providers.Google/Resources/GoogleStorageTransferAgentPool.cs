using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_storage_transfer_agent_pool resource.
/// </summary>
public class GoogleStorageTransferAgentPool : TerraformResource
{
    public GoogleStorageTransferAgentPool(string name) : base("google_storage_transfer_agent_pool", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("state");
    }

    /// <summary>
    /// Specifies the client-specified AgentPool description.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
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
    /// The ID of the agent pool to create.
    /// 
    /// The agentPoolId must meet the following requirements:
    /// * Length of 128 characters or less.
    /// * Not start with the string goog.
    /// * Start with a lowercase ASCII character, followed by:
    ///   * Zero or more: lowercase Latin alphabet characters, numerals, hyphens (-), periods (.), underscores (_), or tildes (~).
    ///   * One or more numerals or lowercase ASCII characters.
    /// 
    /// As expressed by the regular expression: ^(?!goog)[a-z]([a-z0-9-._~]*[a-z0-9])?$.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// Specifies the state of the AgentPool.
    /// </summary>
    public TerraformExpression State => this["state"];

}
