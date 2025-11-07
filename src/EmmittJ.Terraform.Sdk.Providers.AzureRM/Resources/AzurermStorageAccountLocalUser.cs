using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_storage_account_local_user resource.
/// </summary>
public class AzurermStorageAccountLocalUser : TerraformResource
{
    public AzurermStorageAccountLocalUser(string name) : base("azurerm_storage_account_local_user", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("password");
        this.DeclareOutput("sid");
    }

    /// <summary>
    /// The home_directory attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? HomeDirectory
    {
        get => GetProperty<TerraformLiteralProperty<string>>("home_directory");
        set => this.WithProperty("home_directory", value);
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
    /// The ssh_key_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? SshKeyEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("ssh_key_enabled");
        set => this.WithProperty("ssh_key_enabled", value);
    }

    /// <summary>
    /// The ssh_password_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? SshPasswordEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("ssh_password_enabled");
        set => this.WithProperty("ssh_password_enabled", value);
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? StorageAccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_account_id");
        set => this.WithProperty("storage_account_id", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    public TerraformExpression Password => this["password"];

    /// <summary>
    /// The sid attribute.
    /// </summary>
    public TerraformExpression Sid => this["sid"];

}
