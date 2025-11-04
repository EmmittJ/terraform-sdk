using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_source_control_token resource.
/// </summary>
public class AzurermSourceControlToken : TerraformResource
{
    public AzurermSourceControlToken(string name) : base("azurerm_source_control_token", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The token attribute.
    /// </summary>
    public string? Token
    {
        get => GetProperty<TerraformLiteralProperty<string>>("token")?.Value;
        set => this.WithProperty("token", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The token_secret attribute.
    /// </summary>
    public string? TokenSecret
    {
        get => GetProperty<TerraformLiteralProperty<string>>("token_secret")?.Value;
        set => this.WithProperty("token_secret", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public string? Type
    {
        get => GetProperty<TerraformLiteralProperty<string>>("type")?.Value;
        set => this.WithProperty("type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
