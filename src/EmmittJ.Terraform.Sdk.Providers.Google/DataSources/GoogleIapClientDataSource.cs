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
        this.DeclareOutput("display_name");
        this.DeclareOutput("secret");
    }

    /// <summary>
    /// Identifier of the brand to which this client
    /// is attached to. The format is
    /// &#39;projects/{project_number}/brands/{brand_id}&#39;.
    /// </summary>
    public string? Brand
    {
        get => GetProperty<TerraformLiteralProperty<string>>("brand")?.Value;
        set => this.WithProperty("brand", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Output only. Unique identifier of the OAuth client.
    /// </summary>
    public string? ClientId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("client_id")?.Value;
        set => this.WithProperty("client_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// Human-friendly name given to the OAuth client.
    /// </summary>
    public TerraformExpression DisplayName => this["display_name"];

    /// <summary>
    /// Output only. Client secret of the OAuth client.
    /// </summary>
    public TerraformExpression Secret => this["secret"];

}
