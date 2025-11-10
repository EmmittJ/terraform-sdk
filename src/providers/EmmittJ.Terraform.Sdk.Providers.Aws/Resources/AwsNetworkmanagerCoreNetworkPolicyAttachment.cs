using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsNetworkmanagerCoreNetworkPolicyAttachmentTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

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
        this.WithOutput("state");
    }

    /// <summary>
    /// The core_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CoreNetworkId is required")]
    public required TerraformProperty<string> CoreNetworkId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("core_network_id");
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyDocument is required")]
    public required TerraformProperty<string> PolicyDocument
    {
        get => GetRequiredProperty<TerraformProperty<string>>("policy_document");
        set => this.WithProperty("policy_document", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsNetworkmanagerCoreNetworkPolicyAttachmentTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsNetworkmanagerCoreNetworkPolicyAttachmentTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformExpression State => this["state"];

}
