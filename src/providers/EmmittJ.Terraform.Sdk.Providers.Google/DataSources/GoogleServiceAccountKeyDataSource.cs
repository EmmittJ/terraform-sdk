using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_service_account_key Terraform data source.
/// Retrieves information about a google_service_account_key.
/// </summary>
public partial class GoogleServiceAccountKeyDataSource(string name) : TerraformDataSource("google_service_account_key", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The public_key_type attribute.
    /// </summary>
    public TerraformValue<string>? PublicKeyType
    {
        get => GetArgument<TerraformValue<string>>("public_key_type");
        set => SetArgument("public_key_type", value);
    }

    /// <summary>
    /// The key_algorithm attribute.
    /// </summary>
    public TerraformValue<string> KeyAlgorithm
        => AsReference("key_algorithm");

    /// <summary>
    /// The public_key attribute.
    /// </summary>
    public TerraformValue<string> PublicKey
        => AsReference("public_key");

}
