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
    public string? HomeDirectory
    {
        get => GetProperty<TerraformLiteralProperty<string>>("home_directory")?.Value;
        set => this.WithProperty("home_directory", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The ssh_key_enabled attribute.
    /// </summary>
    public bool? SshKeyEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("ssh_key_enabled")?.Value;
        set => this.WithProperty("ssh_key_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The ssh_password_enabled attribute.
    /// </summary>
    public bool? SshPasswordEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("ssh_password_enabled")?.Value;
        set => this.WithProperty("ssh_password_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    public string? StorageAccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_account_id")?.Value;
        set => this.WithProperty("storage_account_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
