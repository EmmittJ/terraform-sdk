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
        SetOutput("key_algorithm");
        SetOutput("public_key");
        SetOutput("id");
        SetOutput("name");
        SetOutput("public_key_type");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The public_key_type attribute.
    /// </summary>
    public TerraformProperty<string> PublicKeyType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("public_key_type");
        set => SetProperty("public_key_type", value);
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
