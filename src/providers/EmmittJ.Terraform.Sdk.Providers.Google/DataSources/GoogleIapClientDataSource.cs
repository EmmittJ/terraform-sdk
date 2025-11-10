using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_iap_client.
/// </summary>
public class GoogleIapClientDataSource : TerraformDataSource
{
    public GoogleIapClientDataSource(string name) : base("google_iap_client", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("display_name");
        SetOutput("secret");
        SetOutput("brand");
        SetOutput("client_id");
        SetOutput("id");
    }

    /// <summary>
    /// Identifier of the brand to which this client
    /// is attached to. The format is
    /// &#39;projects/{project_number}/brands/{brand_id}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Brand is required")]
    public required TerraformProperty<string> Brand
    {
        get => GetRequiredOutput<TerraformProperty<string>>("brand");
        set => SetProperty("brand", value);
    }

    /// <summary>
    /// Output only. Unique identifier of the OAuth client.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    public required TerraformProperty<string> ClientId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("client_id");
        set => SetProperty("client_id", value);
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
    /// Human-friendly name given to the OAuth client.
    /// </summary>
    public TerraformExpression DisplayName => this["display_name"];

    /// <summary>
    /// Output only. Client secret of the OAuth client.
    /// </summary>
    public TerraformExpression Secret => this["secret"];

}
