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
    public TerraformProperty<string>? ClientType
    {
        get => GetProperty<TerraformProperty<string>>("client_type");
        set => this.WithProperty("client_type", value);
    }

    /// <summary>
    /// The function_app_id attribute.
    /// </summary>
    public TerraformProperty<string>? FunctionAppId
    {
        get => GetProperty<TerraformProperty<string>>("function_app_id");
        set => this.WithProperty("function_app_id", value);
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
    /// The target_resource_id attribute.
    /// </summary>
    public TerraformProperty<string>? TargetResourceId
    {
        get => GetProperty<TerraformProperty<string>>("target_resource_id");
        set => this.WithProperty("target_resource_id", value);
    }

    /// <summary>
    /// The vnet_solution attribute.
    /// </summary>
    public TerraformProperty<string>? VnetSolution
    {
        get => GetProperty<TerraformProperty<string>>("vnet_solution");
        set => this.WithProperty("vnet_solution", value);
    }

}
