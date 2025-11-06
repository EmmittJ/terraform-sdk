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
    public string? AccountName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("account_name")?.Value;
        set => this.WithProperty("account_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The certificate attribute.
    /// </summary>
    public string? Certificate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("certificate")?.Value;
        set => this.WithProperty("certificate", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The format attribute.
    /// </summary>
    public string? Format
    {
        get => GetProperty<TerraformLiteralProperty<string>>("format")?.Value;
        set => this.WithProperty("format", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The password attribute.
    /// </summary>
    public string? Password
    {
        get => GetProperty<TerraformLiteralProperty<string>>("password")?.Value;
        set => this.WithProperty("password", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The thumbprint attribute.
    /// </summary>
    public string? Thumbprint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("thumbprint")?.Value;
        set => this.WithProperty("thumbprint", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The thumbprint_algorithm attribute.
    /// </summary>
    public string? ThumbprintAlgorithm
    {
        get => GetProperty<TerraformLiteralProperty<string>>("thumbprint_algorithm")?.Value;
        set => this.WithProperty("thumbprint_algorithm", value == null ? null : new TerraformLiteralProperty<string>(value));
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
