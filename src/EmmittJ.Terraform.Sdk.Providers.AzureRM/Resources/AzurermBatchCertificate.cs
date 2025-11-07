using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_batch_certificate resource.
/// </summary>
public class AzurermBatchCertificate : TerraformResource
{
    public AzurermBatchCertificate(string name) : base("azurerm_batch_certificate", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("name");
        this.DeclareOutput("public_data");
    }

    /// <summary>
    /// The account_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AccountName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("account_name");
        set => this.WithProperty("account_name", value);
    }

    /// <summary>
    /// The certificate attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Certificate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("certificate");
        set => this.WithProperty("certificate", value);
    }

    /// <summary>
    /// The format attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Format
    {
        get => GetProperty<TerraformLiteralProperty<string>>("format");
        set => this.WithProperty("format", value);
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
    /// The password attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Password
    {
        get => GetProperty<TerraformLiteralProperty<string>>("password");
        set => this.WithProperty("password", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Thumbprint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("thumbprint");
        set => this.WithProperty("thumbprint", value);
    }

    /// <summary>
    /// The thumbprint_algorithm attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ThumbprintAlgorithm
    {
        get => GetProperty<TerraformLiteralProperty<string>>("thumbprint_algorithm");
        set => this.WithProperty("thumbprint_algorithm", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The public_data attribute.
    /// </summary>
    public TerraformExpression PublicData => this["public_data"];

}
