using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_service_account_key.
/// </summary>
public class GoogleServiceAccountKeyDataSource : TerraformDataSource
{
    public GoogleServiceAccountKeyDataSource(string name) : base("google_service_account_key", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("key_algorithm");
        this.DeclareOutput("public_key");
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
    /// The public_key_type attribute.
    /// </summary>
    public string? PublicKeyType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("public_key_type")?.Value;
        set => this.WithProperty("public_key_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The key_algorithm attribute.
    /// </summary>
    public TerraformExpression KeyAlgorithm => this["key_algorithm"];

    /// <summary>
    /// The public_key attribute.
    /// </summary>
    public TerraformExpression PublicKey => this["public_key"];

}
