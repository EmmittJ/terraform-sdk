using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_iap_client Terraform data source.
/// Retrieves information about a google_iap_client.
/// </summary>
public partial class GoogleIapClientDataSource(string name) : TerraformDataSource("google_iap_client", name)
{
    /// <summary>
    /// Identifier of the brand to which this client
    /// is attached to. The format is
    /// &#39;projects/{project_number}/brands/{brand_id}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Brand is required")]
    public required TerraformValue<string> Brand
    {
        get => new TerraformReference<string>(this, "brand");
        set => SetArgument("brand", value);
    }

    /// <summary>
    /// Output only. Unique identifier of the OAuth client.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    public required TerraformValue<string> ClientId
    {
        get => new TerraformReference<string>(this, "client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Human-friendly name given to the OAuth client.
    /// </summary>
    public TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
    }

    /// <summary>
    /// Output only. Client secret of the OAuth client.
    /// </summary>
    public TerraformValue<string> Secret
    {
        get => new TerraformReference<string>(this, "secret");
    }

}
