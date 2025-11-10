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
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The public_key_type attribute.
    /// </summary>
    public TerraformProperty<string>? PublicKeyType
    {
        get => GetProperty<TerraformProperty<string>>("public_key_type");
        set => this.WithProperty("public_key_type", value);
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
