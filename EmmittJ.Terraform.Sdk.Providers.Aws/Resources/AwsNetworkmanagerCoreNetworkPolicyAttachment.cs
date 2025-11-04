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
    public string? CoreNetworkId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("core_network_id")?.Value;
        set => this.WithProperty("core_network_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The policy_document attribute.
    /// </summary>
    public string? PolicyDocument
    {
        get => GetProperty<TerraformLiteralProperty<string>>("policy_document")?.Value;
        set => this.WithProperty("policy_document", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformExpression State => this["state"];

}
