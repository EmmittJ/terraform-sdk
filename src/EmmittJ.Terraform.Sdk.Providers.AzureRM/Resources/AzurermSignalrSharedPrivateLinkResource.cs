using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_signalr_shared_private_link_resource resource.
/// </summary>
public class AzurermSignalrSharedPrivateLinkResource : TerraformResource
{
    public AzurermSignalrSharedPrivateLinkResource(string name) : base("azurerm_signalr_shared_private_link_resource", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("status");
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
    /// The request_message attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RequestMessage
    {
        get => GetProperty<TerraformLiteralProperty<string>>("request_message");
        set => this.WithProperty("request_message", value);
    }

    /// <summary>
    /// The signalr_service_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SignalrServiceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("signalr_service_id");
        set => this.WithProperty("signalr_service_id", value);
    }

    /// <summary>
    /// The sub_resource_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SubResourceName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sub_resource_name");
        set => this.WithProperty("sub_resource_name", value);
    }

    /// <summary>
    /// The target_resource_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TargetResourceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_resource_id");
        set => this.WithProperty("target_resource_id", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

}
