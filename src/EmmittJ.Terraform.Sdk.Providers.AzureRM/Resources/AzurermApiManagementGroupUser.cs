using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_api_management_group_user resource.
/// </summary>
public class AzurermApiManagementGroupUser : TerraformResource
{
    public AzurermApiManagementGroupUser(string name) : base("azurerm_api_management_group_user", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The api_management_name attribute.
    /// </summary>
    public string? ApiManagementName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("api_management_name")?.Value;
        set => this.WithProperty("api_management_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The group_name attribute.
    /// </summary>
    public string? GroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("group_name")?.Value;
        set => this.WithProperty("group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The user_id attribute.
    /// </summary>
    public string? UserId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("user_id")?.Value;
        set => this.WithProperty("user_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
