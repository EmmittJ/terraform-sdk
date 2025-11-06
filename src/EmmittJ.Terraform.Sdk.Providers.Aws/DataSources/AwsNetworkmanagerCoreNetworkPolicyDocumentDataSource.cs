using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_networkmanager_core_network_policy_document.
/// </summary>
public class AwsNetworkmanagerCoreNetworkPolicyDocumentDataSource : TerraformDataSource
{
    public AwsNetworkmanagerCoreNetworkPolicyDocumentDataSource(string name) : base("aws_networkmanager_core_network_policy_document", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("json");
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
    /// The version attribute.
    /// </summary>
    public string? Version
    {
        get => GetProperty<TerraformLiteralProperty<string>>("version")?.Value;
        set => this.WithProperty("version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The json attribute.
    /// </summary>
    public TerraformExpression Json => this["json"];

}
