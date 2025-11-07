using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_postgresql_database resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public class AzurermPostgresqlDatabase : TerraformResource
{
    public AzurermPostgresqlDatabase(string name) : base("azurerm_postgresql_database", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The charset attribute.
    /// </summary>
    public TerraformProperty<string>? Charset
    {
        get => GetProperty<TerraformProperty<string>>("charset");
        set => this.WithProperty("charset", value);
    }

    /// <summary>
    /// The collation attribute.
    /// </summary>
    public TerraformProperty<string>? Collation
    {
        get => GetProperty<TerraformProperty<string>>("collation");
        set => this.WithProperty("collation", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The server_name attribute.
    /// </summary>
    public TerraformProperty<string>? ServerName
    {
        get => GetProperty<TerraformProperty<string>>("server_name");
        set => this.WithProperty("server_name", value);
    }

}
