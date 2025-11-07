using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_app_service_source_control_token resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public class AzurermAppServiceSourceControlToken : TerraformResource
{
    public AzurermAppServiceSourceControlToken(string name) : base("azurerm_app_service_source_control_token", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The token attribute.
    /// </summary>
    public TerraformProperty<string>? Token
    {
        get => GetProperty<TerraformProperty<string>>("token");
        set => this.WithProperty("token", value);
    }

    /// <summary>
    /// The token_secret attribute.
    /// </summary>
    public TerraformProperty<string>? TokenSecret
    {
        get => GetProperty<TerraformProperty<string>>("token_secret");
        set => this.WithProperty("token_secret", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

}
