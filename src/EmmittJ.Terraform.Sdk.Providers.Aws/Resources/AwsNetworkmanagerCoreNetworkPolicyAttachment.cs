using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_networkmanager_core_network_policy_attachment resource.
/// </summary>
public class AwsNetworkmanagerCoreNetworkPolicyAttachment : TerraformResource
{
    public AwsNetworkmanagerCoreNetworkPolicyAttachment(string name) : base("aws_networkmanager_core_network_policy_attachment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("state");
    }

    /// <summary>
    /// The core_network_id attribute.
    /// </summary>
    public TerraformProperty<string>? CoreNetworkId
    {
        get => GetProperty<TerraformProperty<string>>("core_network_id");
        set => this.WithProperty("core_network_id", value);
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
    /// The policy_document attribute.
    /// </summary>
    public TerraformProperty<string>? PolicyDocument
    {
        get => GetProperty<TerraformProperty<string>>("policy_document");
        set => this.WithProperty("policy_document", value);
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformExpression State => this["state"];

}
