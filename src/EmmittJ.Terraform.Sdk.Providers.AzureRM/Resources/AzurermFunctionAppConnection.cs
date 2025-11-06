using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_function_app_connection resource.
/// </summary>
public class AzurermFunctionAppConnection : TerraformResource
{
    public AzurermFunctionAppConnection(string name) : base("azurerm_function_app_connection", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The client_type attribute.
    /// </summary>
    public string? ClientType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("client_type")?.Value;
        set => this.WithProperty("client_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The function_app_id attribute.
    /// </summary>
    public string? FunctionAppId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("function_app_id")?.Value;
        set => this.WithProperty("function_app_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The target_resource_id attribute.
    /// </summary>
    public string? TargetResourceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_resource_id")?.Value;
        set => this.WithProperty("target_resource_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The vnet_solution attribute.
    /// </summary>
    public string? VnetSolution
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vnet_solution")?.Value;
        set => this.WithProperty("vnet_solution", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
