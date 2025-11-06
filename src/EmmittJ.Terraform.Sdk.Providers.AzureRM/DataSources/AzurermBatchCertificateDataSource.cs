using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_batch_certificate.
/// </summary>
public class AzurermBatchCertificateDataSource : TerraformDataSource
{
    public AzurermBatchCertificateDataSource(string name) : base("azurerm_batch_certificate", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("format");
        this.DeclareOutput("public_data");
        this.DeclareOutput("thumbprint");
        this.DeclareOutput("thumbprint_algorithm");
    }

    /// <summary>
    /// The account_name attribute.
    /// </summary>
    public string? AccountName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("account_name")?.Value;
        set => this.WithProperty("account_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The format attribute.
    /// </summary>
    public TerraformExpression Format => this["format"];

    /// <summary>
    /// The public_data attribute.
    /// </summary>
    public TerraformExpression PublicData => this["public_data"];

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    public TerraformExpression Thumbprint => this["thumbprint"];

    /// <summary>
    /// The thumbprint_algorithm attribute.
    /// </summary>
    public TerraformExpression ThumbprintAlgorithm => this["thumbprint_algorithm"];

}
